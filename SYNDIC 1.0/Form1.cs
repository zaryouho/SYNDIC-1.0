﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SYNDIC_1._0
{
    public partial class frmMenuOfficiel : Form
    {
        public frmMenuOfficiel()
        {
            InitializeComponent();
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
            if (flag!=1)
                OpenFormInPannel(new frmBiens());


            flag = 1;

        }

        private void buttonProprietaires_Click(object sender, EventArgs e)
        {
            if(flag!=2)
                OpenFormInPannel(new frmProprietaires());

            flag = 2;

        }

        private void buttonFinances_Click(object sender, EventArgs e)
        {
            if (flag != 3)
                OpenFormInPannel(new frmFinances());

            flag = 3;

        }

        private void buttonDocuments_Click(object sender, EventArgs e)
        {
            if (flag != 4)
                OpenFormInPannel(new frmDocuments());

            flag = 4;

        }

        private void buttonHistoriques_Click(object sender, EventArgs e)
        {
            if (flag != 5)
                OpenFormInPannel(new frmHistoriques());

            flag = 5;
        }

        private void buttonRapportsStatistiques_Click(object sender, EventArgs e)
        {
            if (flag != 6)
                OpenFormInPannel(new frmRapportsStatistiques());


            flag = 6;
        }

        
    }
}
