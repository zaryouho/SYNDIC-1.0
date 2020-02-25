using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

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
            string connectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString;
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
                 string query = "select name from sys.databases";
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
            string connectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString;
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
                                comboBoxServerName.Items.Add(reader[1]);
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

        private void FormSettings_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            getDataBaseNames();
            getServerNames();
            this.Cursor = Cursors.Default;
            
            if (comboBoxDataBaseName.Items.Count != 0)
            {
                autoBackupDatabaseName = comboBoxDataBaseName.Items[0].ToString();
            }
            
            checkBoxAutoBackup.Checked = Properties.Settings.Default.Interval != 0 ? true : false ;

            if (checkBoxAutoBackup.Checked)
            {
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
        }

        /// <summary>
        /// Prompt and openFileDialog to the user to select the restoration file path
        /// </summary>
        /// <returns>File path string</returns>
        private string restorePath()
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.InitialDirectory = @"c:\ Program Files\Microsoft SQL Server\\MSSQL12.SQLEXPRESS\MSSQL\Backup";
                file.Filter = "Backup Files (*.bak)|*.bak";
                file.DefaultExt = "bak";
                file.Title = "Fichier de restoration";
                
                if (file.ShowDialog() == DialogResult.OK)
                {
                    string extension = Path.GetExtension(file.FileName);
                    if (extension != "bak")
                    {
                        MessageBox.Show("Fichier invalide","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return null;
                    }
                    return file.FileName;
                }
                return null;
            }
        }
        private string defaultBackupPath()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
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
                string query = "EXEC  master.dbo.xp_instance_regread  N'HKEY_LOCAL_MACHINE', N'Software\\Microsoft\\MSSQLServer\\MSSQLServer',N'BackupDirectory'";
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return reader.GetString(1);
                        }
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// Prompt a FolderBrowserDialog to the user to select the backup folder
        /// </summary>
        /// <returns>Folder name string</returns>
        private string backupPath(string operation)
        {
            if (operation == "restore")
            {
                using (OpenFileDialog folder = new OpenFileDialog())
                {
                    folder.Title = "Selectioner un emplacement ";
                    folder.Filter = "fichier BackUp|*.bak";
                    if (folder.ShowDialog() == DialogResult.OK)
                    {
                        if(Path.GetExtension(folder.FileName)!="bak")
                            return folder.FileName;
                    }
                    return null;
                }
            }
            using (FolderBrowserDialog folder = new FolderBrowserDialog() )
            {
                folder.Description = "Selectioner un emplacement ";
                folder.ShowNewFolderButton = false;
                
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    return folder.SelectedPath;
                }
                return null;
            }
        }

        private void buttonBackupDataBase_Click(object sender, EventArgs e)
        {
            backupandRestore("backup", false, false); 
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
            
            buttonRestoreFromExternalDrive.Enabled = checkBoxAutoBackup.Checked ? false : true;
            buttonBackuptoExternalDrive.Enabled = checkBoxAutoBackup.Checked ? false : true;

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

        /// <summary>
        /// Either backs up or restores the current database 
        /// </summary>
        /// <param name="operation">
        /// the sql command to be executed on the server <b>string<b> <em>backup<em> or <em>restore<em>
        /// </param>
        /// <param name="autoBackup"> <b>true<b> if checkBoxAutoBackup is checked else <b>false<b> </param>
        /// <param name="external"> <b>true<b> if the back up or restore location is an external drive else <b>false<b></param>
        private void backupandRestore(string operation,bool autoBackup,bool external)
        {
            string databaseName = comboBoxDataBaseName.Text;

            string query = string.Empty;
            switch (operation)
            {
                case "backup" :
                    {
                        query = "backup database "+databaseName + " to disk = ";
                        break;
                    }
                case "restore":
                    {
                        query = "use master restore database " + databaseName + " from disk = ";
                        break;
                    }
            }
            
            if (!autoBackup)
            {
                if (comboBoxDataBaseName.SelectedIndex == -1)
                {
                    MessageBox.Show("Selectioner le nom de la base de donnee puis continuer!","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    comboBoxServerName.Focus();
                    return;
                }
            }

            string path = string.Empty;
            if (external)
            {
                path = backupPath(operation);

                if (operation != "restore")
                    path += "\\";
                if (string.IsNullOrWhiteSpace(path))
                {
                    MessageBox.Show("Selectioner un ficher pour sauvgarder la base de donnee","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    external = false;
                    return;
                }
            }

            else if (!external)
            {
                //    path = defaultBackupPath()+"\\";
                //    path = @"C:\Program Files\Microsoft SQL Server\MSSQL12.BENZIAN\MSSQL\Backup";
            }
            string fullPath = path;
            if (operation=="backup")
                fullPath = String.Format("{0}{1}{2}.bak", path, databaseName, DateTime.Now.ToString().Replace(':', ' ').Replace('/',' ')).Replace(" ","");

            string connection = ConfigurationManager.ConnectionStrings[1].ConnectionString;
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
                query += "'"+fullPath+"'";
                using (SqlCommand command = new SqlCommand(query, myConnection))
                {
                    command.CommandText = query;

                    if (autoBackup)
                    {
                        command.Parameters.AddWithValue("@databasename", autoBackupDatabaseName);
                    }
                    else if (!autoBackup)
                    {
                        command.Parameters.AddWithValue("@databsename", databaseName);
                    }



                    command.Parameters.AddWithValue("@path", fullPath);

                    if (operation == "restore")
                    {
                        using (SqlCommand commandseq = new SqlCommand("alter database " + databaseName + " set single_user with rollback after 3600", myConnection))
                        {
                            commandseq.ExecuteNonQuery();
                        }

                    }


                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        int result = command.ExecuteNonQuery();
                        this.Cursor = Cursors.Default;

                        if (result != 0 && !autoBackup)
                        {
                            MessageBox.Show("Operation réussie","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }

                        if (operation == "restore")
                        {
                            using (SqlCommand commandseq = new SqlCommand("alter database " + databaseName + " set multi_user", myConnection))
                            {
                                commandseq.ExecuteNonQuery();
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
    }
}
