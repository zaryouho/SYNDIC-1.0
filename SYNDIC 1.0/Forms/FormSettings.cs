using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Data.SqlClient;
using System.Configuration;


namespace SYNDIC_1._0
{
    public partial class FormSettings : Form
    {
        public string autoBackupDatabaseName = string.Empty;
        
        public FormSettings()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Gets all system Sql Server databases names
        /// </summary>
        public void getDataBaseNames()
        {
            string connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (ConnectionState.Open != connection.State)
                {
                    try
                    {
                       connection.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                string query = "select * from sys.databases";
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBoxDataBaseName.Items.Add(reader[0]);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }   
        /// <summary>
        /// Gets all system Sql Server instences names
        /// </summary>
        public void getServerNames()
        {
            string connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                string query = "select *  from sys.servers";
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBoxServerName.Items.Add(reader[0]);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }

        private void panelWrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            getDataBaseNames();
            getServerNames();
            this.Cursor = Cursors.Default;
            
            while (comboBoxDataBaseName.Items.Count != 0)
            {
                autoBackupDatabaseName = comboBoxDataBaseName.Items[0].ToString();
            }
            
            panelBackgroundWorkerContainer.Visible = false;

            checkBoxAutoBackup.Checked = Properties.Settings.Default.Interval != 0 ? true : false ;
            
            switch (Properties.Settings.Default.Interval)
            {
                case 1:
                    radioButtonDailyBackup.Checked = true;
                    break;
                case 7:
                    radioButtonWeeklyBackup.Checked = true;
                    break;
                case 30:
                    radioButtonMonthlyBackup.Checked = true;
                    break;
            }
        }

        private void buttonBackupDataBase_Click(object sender, EventArgs e)
        {
            backupandRestore("backup", false, false);
        }

        public string backupPath()
        {
            using (FolderBrowserDialog browserDialog = new FolderBrowserDialog())
            {
                DialogResult path = browserDialog.ShowDialog();
                return browserDialog.SelectedPath;
            }
        }

        private void buttonBackuptoExternalDrive_Click(object sender, EventArgs e)
        {
            backupandRestore("backup", false, true);
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            backupandRestore("restore", false, false);
        }

        private void buttonRestoreFromExternalDrive_Click(object sender, EventArgs e)
        {
            backupandRestore("restore", false, true);
        }

        private void checkBoxAutoBackup_CheckedChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            int interval = 0;
            
            buttonRestoreFromExternalDrive.Enabled = groupBoxBackup.Visible = checkBoxAutoBackup.Checked ? false : true;
            buttonBackuptoExternalDrive.Enabled = groupBoxBackup.Visible = checkBoxAutoBackup.Checked ? false : true;

            while (checkBoxAutoBackup.Checked)
            {
                interval = radioButtonDailyBackup.Checked ? 1 : 0;
                interval = radioButtonWeeklyBackup.Checked ? 7 : 0;
                interval = radioButtonMonthlyBackup.Checked ? 30 : 0;

                while (interval != 0)
                {
                    Properties.Settings.Default.Interval = interval;
                    Properties.Settings.Default.Today = today;
                    Properties.Settings.Default.Save();

                    if (Properties.Settings.Default.Today.AddDays(Properties.Settings.Default.Interval) == DateTime.Now)
                    {
                        backupandRestore("backup", true, false);
                    }
                } 
            }
        }

        private void backgroundWorkerBackup_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }
        /// <summary>
        /// Either backs up or restores the current database 
        /// </summary>
        /// <param name="operation">
        /// the sql command to be executed on the server <b>string<b> <em>backup<em> or <em>restore<em>
        /// </param>
        /// <param name="autoBackup"> <b>true<b> if checkBoxAutoBackup is checked else <b>false<b> </param>
        /// <param name="external"> <b>true<b> if the back up or restore location is an external drive else <b>false<b></param>
        public void backupandRestore(string operation,bool autoBackup,bool external)
        {
            string query = string.Empty;
            switch (operation)
            {
                case "backup" :
                    {
                        query = "back up database @databasename to disk = '@path'";
                        break;
                    }
                case "restore":
                    {
                        query = " restore database @databsename from disk ='@path'";
                        break;
                    }

            }
            if (!autoBackup)
            {
                if (String.IsNullOrWhiteSpace(comboBoxDataBaseName.Text))
                {
                    MessageBox.Show("Plz Select the server name the the database then proceed");
                    comboBoxServerName.Focus();
                    return;
                }
            }
            
            string path = string.Empty;
            if (external)
            {
                path = backupPath();
                if (string.IsNullOrWhiteSpace(path))
                {
                    MessageBox.Show("plz select a path to back up your database");
                    external = false;
                    return;
                }
            }
            else if (!external)
            {
                path = ConfigurationManager.AppSettings["BackupFolder"].ToString();
            }
            string databaseName = comboBoxDataBaseName.Text;
            string name = String.Format("{0}{1}{2}.bak", path, databaseName, DateTime.Now.ToString("yyyy-MM-dd"));

            string connection = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            using (SqlConnection myConnection = new SqlConnection(connection))
            {
                if (myConnection.State != ConnectionState.Open)
                {
                    try
                    {
                        myConnection.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                using (SqlCommand command = new SqlCommand(query, myConnection))
                {
                    if (autoBackup)
                    {
                        command.Parameters.AddWithValue("@databasename", autoBackupDatabaseName);
                    }
                    else if (!autoBackup)
                    {
                        command.Parameters.AddWithValue("@databsename", databaseName);
                    }
                    command.Parameters.AddWithValue("@path", path);
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        int result = command.ExecuteNonQuery();
                        this.Cursor = Cursors.Default;

                        if (result != -1 && !autoBackup)
                        {
                            MessageBox.Show("Backup successful");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
