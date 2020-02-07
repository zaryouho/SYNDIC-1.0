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
        public static bool flag = false;
        
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
                    connection.Open();
                }
                string query = "select* from sys.databases";
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            comboBoxDataBaseName.Items.Add(reader[0]);
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
                    connection.Open();
                }
                string query = "select *  from sys.servers";
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            comboBoxServerName.Items.Add(reader[0]);
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

        }

        private void buttonBackupDataBase_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(comboBoxDataBaseName.Text)|| String.IsNullOrWhiteSpace(comboBoxServerName.Text))
            {
                MessageBox.Show("Plz Select the server name the the database then proceed");
                comboBoxServerName.Focus();
                return;
            }
            
            string query = "back up database @databasename to disk = '@path'";
            string folder = string.Empty;
            if (flag)
            {
                folder = backupPath();
                if (string.IsNullOrWhiteSpace(folder))
                {
                    MessageBox.Show("plz select a path to back up your database");
                }
                flag = !flag;
            }
            else
            {
                folder = ConfigurationManager.AppSettings["BackupFolder"].ToString();
            }
            string databaseName = comboBoxDataBaseName.Text;
            string path = String.Format("{0}{1}{2}.bak", folder, databaseName,DateTime.Now.ToString("yyyy-MM-dd"));

            string connection = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            using (SqlConnection myConnection = new SqlConnection(connection))
            {
                if (myConnection.State != ConnectionState.Open)
                {
                    myConnection.Open();
                }
                using (SqlCommand command = new SqlCommand(query,myConnection))
                {
                    command.Parameters.AddWithValue("@databsename", databaseName);
                    command.Parameters.AddWithValue("@path",path);
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        int result = command.ExecuteNonQuery();
                        this.Cursor = Cursors.Default;
                        if (result != -1)
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
            flag = true;
            buttonBackupDataBase.PerformClick();
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            string query = " use master restore database @databsename from disk ='@path'";
            string databaseName = comboBoxDataBaseName.Text;
            if (flag)
            {
                path = backupPath();
                if (string.IsNullOrWhiteSpace(path))
                {
                    MessageBox.Show("plz select a path to restore your database");
                }
                flag = !flag;
            }
            path = ConfigurationManager.AppSettings["BackupFolder"].ToString();
            string connection = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            using (SqlConnection myConnection = new SqlConnection(connection))
            {
                if (myConnection.State != ConnectionState.Open)
                {
                    myConnection.Open();
                }
                using (SqlCommand command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@databsename", databaseName);
                    command.Parameters.AddWithValue("@path", path);
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        int result = command.ExecuteNonQuery();
                        this.Cursor = Cursors.Default;
                        if (result != -1)
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

        private void buttonRestoreFromExternalDrive_Click(object sender, EventArgs e)
        {
            flag = true;
            buttonRestore.PerformClick();
        }

        private void checkBoxAutoBackup_CheckedChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            int interval = 0;
            
            buttonRestore.Enabled = groupBoxBackup.Visible = checkBoxAutoBackup.Checked ? false : true;
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
                        buttonBackupDataBase.PerformClick();
                    }
                } 
            }
        }
    }
}
