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
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Threading;

namespace SYNDIC_1._0.Forms
{
    public partial class LoginToBeDeleted : Form
    {
        private SqlConnection connection;
        private string connectionString = ConfigurationManager.ConnectionStrings["SyndicConnectionStringReda"].ToString();
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        private string typeUtilisateur = string.Empty;
        public LoginToBeDeleted()
        {
            Thread thread = new Thread(new ThreadStart(startForm));
            thread.Start();
            Thread.Sleep(4000); // duration in ms => 4 seconds
            InitializeComponent();
            thread.Abort();
        }
        public void startForm()
        {
            Application.Run(new FormSplachScreen());
        }
        #region Authentification and Cryptography
        public class HashandSalt
        {
            public string hash { get; set; }
            public string salt { get; set; }
        }
        public static HashandSalt GenerathashandSalt(int size, string password)
        {
            byte[] saltbytes = new byte[size];
            RNGCryptoServiceProvider cryptoServiceProvider = new RNGCryptoServiceProvider();
            cryptoServiceProvider.GetNonZeroBytes(saltbytes);
            var salt = Convert.ToBase64String(saltbytes);

            Rfc2898DeriveBytes deriveBytes = new Rfc2898DeriveBytes(password, saltbytes);
            var hashedPassword = Convert.ToBase64String(deriveBytes.GetBytes(256));
            HashandSalt hashSalt = new HashandSalt { hash = hashedPassword, salt = salt };
            return hashSalt;
            //HashandSalt hashandsalt = GenerathashandSalt(64, password);
            
        }
        public static bool VerifyPassword(string enteredPassword, string storedHash, string storedSalt)
        {
            byte[] saltBytes = Convert.FromBase64String(storedSalt);
            Rfc2898DeriveBytes deriveBytes = new Rfc2898DeriveBytes(enteredPassword, saltBytes);
            return Convert.ToBase64String(deriveBytes.GetBytes(256)).Equals(storedHash);
        }
        #endregion

        //private string generateSalt(int size)
        //{
        //    RNGCryptoServiceProvider cryptoServiceProvider = new RNGCryptoServiceProvider();
        //    byte[] buffer = new byte[size];
        //    cryptoServiceProvider.GetBytes(buffer);
        //    return Convert.ToString(Convert.ToBase64String(buffer));
        //}
        //private string generateHash(string password, string salt)
        //{
        //    byte[] bytes = Encoding.UTF8.GetBytes(password + salt);
        //    SHA256Managed sHA256Managed = new SHA256Managed();
        //    byte[] hash = sHA256Managed.ComputeHash(bytes);
        //    return Convert.ToString(Convert.ToBase64String(hash));
        //}
        //private bool authenticate(string enteredPassword,string mot_de_pass,string storedSalt)
        //{
        //    string salt = Convert.ToString(Convert.FromBase64String(storedSalt));
        //    return mot_de_pass.Equals(generateHash(enteredPassword, salt));
        //}
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim().ToLower().Replace("'","") ;
            string password = textBoxPassword.Text.Trim().ToLower().Replace("'", "");

            if (!textBoxUsername.hasText() || !textBoxPassword.hasText())
            {
                MessageBox.Show("type something");
                return;
            }
            
            string query = "select * from utilisateur where login ='" + username + "'and mot_de_passe = '" + password +"'";
            connection = new SqlConnection(connectionString);
            connection.Open();
            
            dataAdapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Close();
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("majebroxi");
                return;
            }
            if (dataTable.Rows.Count == 1)
            {
                string mot_de_pass = dataTable.Rows[1]["mot_de_pass"] as string;
                string salt = dataTable.Rows[1]["salt"] as string;
                bool authenticat = VerifyPassword(password, mot_de_pass, salt);
                if (authenticat)
                {
                    // login successful
                    switch (dataTable.Rows[1]["typeUtilisateur"] as string)
                    {
                        case "Admin":
                            {
                                typeUtilisateur = "Admin";
                                this.Hide();
                                // Show the main menu
                                MessageBox.Show("Login was succesful. " + username + " !");
                                break;
                            }
                        case "Utilisateur":
                            {
                                typeUtilisateur = "Utilisateur";
                                this.Hide();
                                // Show the main menu
                                MessageBox.Show("Login was succesful. " + username + " !");
                                break;
                            }
                    }
                }
                if (!authenticat)
                {
                    MessageBox.Show("jrijri");
                    return;
                }
            }
            dataAdapter.Dispose();

        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        { 
            
            if (textBoxUsername.hasText() && textBoxPassword.hasText())
            {
                if (e.KeyChar == 13)
                {
                    buttonLogin.PerformClick(); 
                }
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (!textBoxUsername.hasText() && textBoxUsername.TextLength < 5)
            {
                MessageBox.Show("login Failed");
                textBoxUsername.Clear();
                textBoxUsername.Focus(); 
            }
            if (!textBoxPassword.hasText() && textBoxPassword.TextLength < 6)
            {
                MessageBox.Show("login Failed");
                textBoxPassword.Clear();
                textBoxPassword.Focus();
            }
            else
            {
                string username = textBoxUsername.Text.Trim().ToLower().Replace("'", "");
                string password = textBoxPassword.Text.Trim().ToLower().Replace("'", "");

                connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "select * from utilisateur where login ='" + username + "'and mot_de_passe = '" + password + "'";
                dataAdapter = new SqlDataAdapter(query,connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                
                if (dataTable.Rows.Count != 0)
                {
                    MessageBox.Show("Utilisateur deja exist");
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                    textBoxUsername.Focus();
                    return;
                }
                else
                {
                    string sqlQuery = " insert into utilisateur (login,mot_de_pass) values ("+ username +",'" + password +")";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
            }
            connection.Dispose();
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;   
        }
    }
}
