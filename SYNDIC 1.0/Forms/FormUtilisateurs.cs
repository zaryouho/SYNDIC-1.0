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
using SYNDIC_1._0.Helpers;

namespace SYNDIC_1._0.Forms
{
    public partial class FormUtilisateurs : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
        string login = string.Empty;
        string passWord = string.Empty;
        string confirmedPassWord = string.Empty;
        bool update = false;
        
        public FormUtilisateurs()
        {
            InitializeComponent();
        }
        private void FormUtilisateurs_Load(object sender, EventArgs e)
        {
            comboBoxTypeUser.SelectedIndex = 1;
            dataGridViewUsers.ColumnCount = 2;
            dataGridViewUsers.Columns[0].Name = "Type";
            dataGridViewUsers.Columns[1].Name = "Login";
            fillDataGrid();
        }
        private void fillDataGrid()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString))
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                string query = "select typeUtilisateur,login from utilisateur";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataGridViewUsers.Rows.Add(reader[0].ToString(), reader[1].ToString());
                        }
                    }
                }
            }
        }
        private bool isUnique(string login)
        {
            foreach (DataGridViewRow row in dataGridViewUsers.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(login))
                {
                    return false;
                }
            }
            return true;
        }
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxConfirmePassword.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '*' ;
        }
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (!textBoxLogin.hasText() || !textBoxPassword.hasText() || !textBoxConfirmePassword.hasText())
            {
                textBoxLogin.Focus();
                MessageBox.Show("empty");
                return;
            }

            login = textBoxLogin.Text.Trim().Replace("'", "''").Replace("-","");
            passWord = textBoxPassword.Text.Trim().Replace("'", "''");
            confirmedPassWord = textBoxConfirmePassword.Text.Trim().Replace("'", "''");

            string hash = Security.GenerathashandSalt(64, passWord).hash;
            string salt = Security.GenerathashandSalt(64, passWord).salt;
            
            while (passWord.Equals(confirmedPassWord) && isUnique(login))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    if (ConnectionState.Open != connection.State)
                    {
                        connection.Open();
                    }
                    string queryInsert = "inesrt into utilisateur values @type,@login,@hash,@salt";
                    string queryUpdate = "update table ulilisatur set mot_de_pass = @passWord,salt = @salt where login like '% @login %'";
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        int result = -1;
                        
                        if (update)
                        {
                            command.CommandText = queryUpdate;
                            command.Parameters.AddWithValue("@passWord", hash);
                            command.Parameters.AddWithValue("@salt", salt);
                            command.Parameters.AddWithValue("@login", login);
                            result = command.ExecuteNonQuery();
                        }
                        if (!update)
                        {
                            command.CommandText = queryInsert;
                            command.Parameters.AddWithValue("@type", comboBoxTypeUser.SelectedText);
                            command.Parameters.AddWithValue("@login", login);
                            command.Parameters.AddWithValue("@hash", hash);
                            command.Parameters.AddWithValue("@salt", salt);
                            result = command.ExecuteNonQuery();
                        }
                        
                        if (result != -1)
                        {
                            if (update)
                            {
                                Helper.Log.makeLog(FormLogin.userId, DateTime.Now, Helper.Log.actions.Modifer.ToString(),"utilisateur", "oldPassword", "newPassword");
                                MessageBox.Show("daz update");
                            }
                            else
                            {
                                Helper.Log.makeLog(FormLogin.userId, DateTime.Now, Helper.Log.actions.Ajouter.ToString(),"utilisateur", "oldPassword", "newPassword");
                                MessageBox.Show("daz insert");
                            }
                        }
                    }
                }
            }
        }
        private void buttonModifyUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("No user is selected");
                dataGridViewUsers.Focus();
                return;
            }
            while (dataGridViewUsers.SelectedRows.Count != 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this user ?","Deleting...",MessageBoxButtons.YesNo))
                {
                    update = true;
                    buttonAddUser.PerformClick();
                    update = false;
                }
            }
        }
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("select a user to delete");
                dataGridViewUsers.Focus();
                return;
            }
            if (DialogResult.Yes.Equals(MessageBox.Show("Test")))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    string query = "delete * from utililsateur where login like '% @login %'";
                    string currentLogin = dataGridViewUsers.CurrentRow.Cells[1].Value.ToString();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", currentLogin);
                        int result = command.ExecuteNonQuery();
                        
                        if (result != -1)
                        {
                            Helper.Log.makeLog(FormLogin.userId, DateTime.Now, Helper.Log.actions.Supprimer.ToString(), "utilisateur", currentLogin, "-");
                            MessageBox.Show("daz");
                            fillDataGrid();
                        }
                    }
                }
            }
        }

        private void textBoxConfirmePassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }
    }
}
