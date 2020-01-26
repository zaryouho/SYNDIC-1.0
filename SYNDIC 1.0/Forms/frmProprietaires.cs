using SYNDIC_1._0.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYNDIC_1._0
{
    public partial class frmProprietaires : Form
    {
        private void OpenFormInPannel(object formChild)
        {
            if (this.splitContainerProprietaire.Panel2.Controls.Count > 0)
                this.splitContainerProprietaire.Panel2.Controls.RemoveAt(0);

            Form frmchild = formChild as Form;
            frmchild.TopLevel = false;
            frmchild.Dock = DockStyle.Fill;
            this.splitContainerProprietaire.Panel2.Controls.Add(frmchild);
            this.splitContainerProprietaire.Panel2.Tag = frmchild;
            frmchild.Show();
        }

        public frmProprietaires()
        {
            InitializeComponent();
        }

        private void labelCloseProprietaires_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        

        private void frmProprietaires_Load(object sender, EventArgs e)
        {
            buttonSsProprietaires.BackColor = Color.Navy;
            buttonSsProprietaires_Click(sender, e);

        }

        private void buttonSsProprietaires_Click(object sender, EventArgs e)
        {
            buttonSsProprietaires.BackColor = Color.Navy;
            buttonSsProprietairesArchive.BackColor = Color.Blue;
            buttonSsAjouterProprietaires.BackColor = Color.Blue;
            buttonSsProprietairesRecettes.BackColor = Color.Blue;
            OpenFormInPannel(new FormListeProprietaire());

        }

        private void buttonSsAjouterProprietaires_Click(object sender, EventArgs e)
        {
            buttonSsProprietaires.BackColor = Color.Blue;
            buttonSsProprietairesArchive.BackColor = Color.Blue;
            buttonSsAjouterProprietaires.BackColor = Color.Navy;
            buttonSsProprietairesRecettes.BackColor = Color.Blue;

        }

        private void buttonSsProprietairesArchive_Click(object sender, EventArgs e)
        {
            buttonSsProprietaires.BackColor = Color.Blue;
            buttonSsProprietairesArchive.BackColor = Color.Navy;
            buttonSsAjouterProprietaires.BackColor = Color.Blue;
            buttonSsProprietairesRecettes.BackColor = Color.Blue;
            OpenFormInPannel(new FormProprietairesArchive());
        }

        private void buttonSsProprietairesRecettes_Click(object sender, EventArgs e)
        {
            buttonSsProprietaires.BackColor = Color.Blue;
            buttonSsProprietairesArchive.BackColor = Color.Blue;
            buttonSsAjouterProprietaires.BackColor = Color.Blue;
            buttonSsProprietairesRecettes.BackColor = Color.Navy;
            OpenFormInPannel(new FormRecetteProprietaire());

        }
    }
}
