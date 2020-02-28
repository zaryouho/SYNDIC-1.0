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
using SYNDIC_1._0.Helpers;
using SYNDIC_1._0.Forms;

namespace SYNDIC_1._0.Forms
{
    public partial class FormLogin : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }


        string connectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString;
        public static string typeUtilisateur = string.Empty;
        public static int userId = -1;
        public bool authentitace = false;
        public FormLogin()
        {
            //Thread thread = new Thread(new ThreadStart(startForm));
            //thread.Start();
            //Thread.Sleep(4000); // duration in ms => 4 seconds
            InitializeComponent();
            //thread.Abort();

        }
        //public void startForm()
        //{
        //    Application.Run(new FormSplachScreen());
        //}
        
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
            //if (MessageBox.Show("Are you sure you want to store sensitive information").Equals(DialogResult.Yes))
            //{
            //    Properties.Settings.Default.CheckBox = checkBoxRememberMe.Checked;
            //    Properties.Settings.Default.Save();
            //}

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

            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Rempisser les zone de text avant de continuer","Manque des donnees",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if (username.Length != 0)
                {
                    textBoxPassword.Select();
                    textBoxPassword.Focus();
                }
                if (password.Length != 0)
                {
                    textBoxUsername.Select();
                    textBoxUsername.Focus();
                }
                return;
            }
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
                        MessageBox.Show(ex.Message,"Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                string query = "select * from utilisateur where login like '"+username+"' ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            userId = reader.GetInt32(0);
                            typeUtilisateur = reader.GetString(1);
                            string storedPassword = reader.GetString(3);
                            string storedSalt = reader.GetString(4);
                            if(password==storedPassword)
                                authentitace = true;
                        }

                        if (authentitace)//<============ To be check 
                        {
                            // login successful
                            switch (typeUtilisateur)
                            {
                                case "Admin":
                                    {
                                        typeUtilisateur = "Admin";
                                        new frmMenuOfficiel().Show();
                                        this.Hide();
                                        MessageBox.Show("Login was succesful. " + username + " !");
                                        break;
                                    }
                                case "Utilisateur":
                                    {
                                        typeUtilisateur = "Utilisateur";
                                        new frmMenuOfficiel().Show();
                                        this.Hide();
                                        MessageBox.Show("Login was succesful. " + username + " !");
                                        break;
                                    }
                            }
                        }
                        if (!authentitace)
                        {
                            MessageBox.Show("Verification Echouer","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
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
                MessageBox.Show("Remplissez le login et le mot de passe puis vérifiez à nouveau cette case", "manque des informations",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            DialogResult dialogResult = 
                MessageBox.Show("si vous cochez cette case, vous n'aurez pas à taper votre mot de passe la prochaine fois", "Se souvenir du mot de passe", MessageBoxButtons.YesNo);
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
         
        }

        private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }
    }
}
