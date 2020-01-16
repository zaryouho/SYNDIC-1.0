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
    public partial class frmBiens : Form
    {
        public frmBiens()
        {
            InitializeComponent();
        }

        private void labelCloseBiens_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSsBiensListe_Click(object sender, EventArgs e)
        {
            tabControlFinancesEcheances.SelectedTab = tabPageBiensListe;
            buttonSsBiensListe.BackColor = Color.Navy;
            buttonSsBiensEcheances.BackColor = Color.Blue;
            buttonSsBiensEchangeProprietaire.BackColor = Color.Blue;
        }

        private void buttonSsBiensEchangeProprietaire_Click(object sender, EventArgs e)
        {
            tabControlFinancesEcheances.SelectedTab = tabPageBiensEchangeProprietaire;
            buttonSsBiensListe.BackColor = Color.Blue;
            buttonSsBiensEcheances.BackColor = Color.Blue;
            buttonSsBiensEchangeProprietaire.BackColor = Color.Navy;
        }

        private void buttonSsBiensEcheances_Click(object sender, EventArgs e)
        {
            tabControlFinancesEcheances.SelectedTab = tabPageBiensEcheances;
            buttonSsBiensListe.BackColor = Color.Blue;
            buttonSsBiensEcheances.BackColor = Color.Navy;
            buttonSsBiensEchangeProprietaire.BackColor = Color.Blue;
        }

        private void frmBiens_Load(object sender, EventArgs e)
        {
            buttonSsBiensListe.BackColor = Color.Navy;
        }
    }
}
