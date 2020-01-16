using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYNDIC_1._0
{
    public partial class frmProprietaires : Form
    {
        public frmProprietaires()
        {
            InitializeComponent();
        }

        private void labelCloseProprietaires_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSsProprietaires_Click(object sender, EventArgs e)
        {
            tabcontrolProprietaires.SelectedTab = tabPageProprietaires;
            buttonSsProprietaires.BackColor = Color.Navy;
            buttonSsAjouterProprietaires.BackColor = Color.Blue;
            buttonSsProprietairesArchive.BackColor = Color.Blue;
            buttonSsProprietairesRecettes.BackColor = Color.Blue;

        }

        private void buttonSsAjouterProprietaires_Click(object sender, EventArgs e)
        {
            tabcontrolProprietaires.SelectedTab = tabPageProprietairesAjouter;
            buttonSsProprietaires.BackColor = Color.Blue;
            buttonSsAjouterProprietaires.BackColor = Color.Navy;
            buttonSsProprietairesArchive.BackColor = Color.Blue;
            buttonSsProprietairesRecettes.BackColor = Color.Blue;
        }

        private void buttonSsProprietairesArchive_Click(object sender, EventArgs e)
        {
            tabcontrolProprietaires.SelectedTab = tabPageProprietairesArchivee;
            buttonSsProprietaires.BackColor = Color.Blue;
            buttonSsAjouterProprietaires.BackColor = Color.Blue;
            buttonSsProprietairesArchive.BackColor = Color.Navy;
            buttonSsProprietairesRecettes.BackColor = Color.Blue;
        }

        private void buttonSsProprietairesRecettes_Click(object sender, EventArgs e)
        {
            tabcontrolProprietaires.SelectedTab = tabPageProprietairesRecettes;
            buttonSsProprietaires.BackColor = Color.Blue;
            buttonSsAjouterProprietaires.BackColor = Color.Blue;
            buttonSsProprietairesArchive.BackColor = Color.Blue;
            buttonSsProprietairesRecettes.BackColor = Color.Navy;
        }

        private void frmProprietaires_Load(object sender, EventArgs e)
        {
            buttonSsProprietaires.BackColor = Color.Navy;
        }
    }
}
