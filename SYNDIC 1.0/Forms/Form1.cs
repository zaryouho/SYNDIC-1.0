using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SYNDIC_1._0.Forms;
using System.Configuration;

namespace SYNDIC_1._0
{
    public partial class frmMenuOfficiel : Form
    {
        public frmMenuOfficiel()
        {
            InitializeComponent();
        }

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
        

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnSlideBar_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 265)
                MenuVertical.Width = 65;
            else
                MenuVertical.Width = 265;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaure.Visible = true;
            btnMaximized.Visible = false;
        }

        private void btnRestaure_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaure.Visible = false;
            btnMaximized.Visible = true;

        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void BarreTitulaire_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenFormInPannel(object formChild)
        {
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);

            Form frmchild = formChild as Form;
            frmchild.TopLevel = false;
            frmchild.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(frmchild);
            this.panelContainer.Tag = frmchild;
            frmchild.Show();            
        }

        int flag = 0;

        private void buttonBiens_Click(object sender, EventArgs e)
        {
            if (flag!=1 || this.panelContainer.Controls.Count == 0)
                OpenFormInPannel(new frmBiens());


            flag = 1;

        }

        private void buttonProprietaires_Click(object sender, EventArgs e)
        {
            if(flag!=2 || this.panelContainer.Controls.Count == 0)
                OpenFormInPannel(new frmProprietaires());

            flag = 2;

        }

        private void buttonFinances_Click(object sender, EventArgs e)
        {
            if (flag != 3 || this.panelContainer.Controls.Count == 0)
                OpenFormInPannel(new frmFinances());

            flag = 3;

        }

        private void buttonDocuments_Click(object sender, EventArgs e)
        {
            if (flag != 4 || this.panelContainer.Controls.Count == 0)
                OpenFormInPannel(new FormResidence());

            flag = 4;

        }

        private void buttonHistoriques_Click(object sender, EventArgs e)
        {
            if (flag != 5 || this.panelContainer.Controls.Count == 0)
                OpenFormInPannel(new frmHistoriques());

            flag = 5;
        }

        private void buttonRapportsStatistiques_Click(object sender, EventArgs e)
        {
            if (flag != 6 || this.panelContainer.Controls.Count == 0)
                OpenFormInPannel(new frmRapportsStatistiques());


            flag = 6;
        }

        private void buttonSociete_Click(object sender, EventArgs e)
        {
            if (flag != 7 || this.panelContainer.Controls.Count == 0)
                OpenFormInPannel(new FormSociete());


            flag = 7;
        }

        private void buttonEmploye_Click(object sender, EventArgs e)
        {
            if (flag != 8 || this.panelContainer.Controls.Count == 0)
                OpenFormInPannel(new FormEmploye());


            flag = 8;
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            if (flag != 9 || this.panelContainer.Controls.Count == 0)
                OpenFormInPannel(new FormUtilisateurs());


            flag = 9;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            if (flag != 10 || this.panelContainer.Controls.Count == 0)
                OpenFormInPannel(new FormSettings());// to be replaced wit the settings form


            flag = 10;
        }

        private void frmMenuOfficiel_Load(object sender, EventArgs e)
        {
            FormLogin.userId = 22;

            
            
        }
    }
}
