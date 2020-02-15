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

namespace SYNDIC_1._0
{
    public partial class FormAjouterModifierFacture : Form
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


        BindingSource bsProduit, bsFacture;

        int idDepense;
        DataClassesSyndicDataContext dc = new DataClassesSyndicDataContext();

        public FormAjouterModifierFacture(BindingSource _bsProduit, BindingSource _bsFacture, int _idDepense)
        {
            idDepense = _idDepense;
            bsProduit = _bsProduit;
            bsFacture = _bsFacture;

            InitializeComponent();
        }

        private void labelCloseDepense_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAjouterModifierFacture_Load(object sender, EventArgs e)
        {
            comboBoxProduit.DataSource = bsProduit;
            comboBoxProduit.ValueMember = "id";
            comboBoxProduit.DisplayMember = "designation";
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {


        }

        private void buttonAjouterProduit_Click(object sender, EventArgs e)
        {
            bsProduit.AddNew();
            new FormAjouterProduit(bsProduit).ShowDialog();
        }
    }
}
