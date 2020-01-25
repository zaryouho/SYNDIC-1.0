using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;
using System.Security.Cryptography;

namespace SYNDIC_1._0.Forms
{
    public partial class FormLogin : Form
    {
        private SqlConnection connection;
        private string connectionString = ConfigurationManager.ConnectionStrings["SyndicConnectionStringReda"].ToString();
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        private string typeUtilisateur = string.Empty;
        public FormLogin()
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
        
         #region DragingFrom

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        #endregion

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void FormLogin_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim().ToLower().Replace("'", "''");
            string password = textBoxPassword.Text.Trim().ToLower().Replace("'", "''");

            if (!textBoxUsername.hasText() || !textBoxPassword.hasText())
            {
                MessageBox.Show("type something");
                if (textBoxUsername.hasText())
                {
                    textBoxPassword.Select();
                    textBoxPassword.Focus();
                }
                if (textBoxPassword.hasText())
                {
                    textBoxUsername.Select();
                    textBoxUsername.Focus();
                }
                return;
            }

            string query = "select * from utilisateur where login ='" + username + "'and mot_de_passe = '" + password + "'";
            connection = new SqlConnection(connectionString);
            connection.Open();

            dataAdapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Close();

            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("majebroxi");
                dataAdapter.Dispose();
                connection.Dispose();
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
                                dataAdapter = null;
                                connection = null;
                                break;
                            }
                        case "Utilisateur":
                            {
                                typeUtilisateur = "Utilisateur";
                                this.Hide();
                                // Show the main menu
                                MessageBox.Show("Login was succesful. " + username + " !");
                                dataAdapter = null;
                                connection = null;
                                break;
                            }
                    }
                }
                if (!authenticat)
                {
                    MessageBox.Show("jrijri");
                    dataAdapter = null;
                    connection = null;
                    return;
                }
            }
            
        }

        private void FormLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxUsername.hasText() && textBoxPassword.hasText())
            {
                if (e.KeyChar == 13)
                {
                    buttonLogin.PerformClick();
                }
            }
        }

        private void checkBoxShowHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = checkBoxShowHidePassword.Checked ? '\0' : '*';
        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (!textBoxUsername.hasText() || !textBoxPassword.hasText())
            {
                MessageBox.Show("plz fill the login and pass then chech this box again","missing information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            DialogResult dialogResult = 
                MessageBox.Show("if you check this box you won't have to type your password next time","Remember your password",MessageBoxButtons.YesNo);
            if (dialogResult.Equals(DialogResult.Yes))
            {
                Properties.Settings.Default.CheckBox = checkBoxRememberMe.Checked;
                Properties.Settings.Default.TextBoxLogin = textBoxUsername.Text;
                Properties.Settings.Default.TextBoxPass = textBoxPassword.Text;
                Properties.Settings.Default.Save();
            }
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CheckBox)
            {
                textBoxUsername.Text = Properties.Settings.Default.TextBoxLogin;
                textBoxPassword.Text = Properties.Settings.Default.TextBoxPass;
                checkBoxRememberMe.Checked = Properties.Settings.Default.CheckBox;
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.CheckBox = checkBoxRememberMe.Checked;
            Properties.Settings.Default.Save();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormForgotPassword formForgotPassword = new FormForgotPassword();
            formForgotPassword.Show();
        }
    }
}
