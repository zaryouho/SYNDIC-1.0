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
    public partial class FormAjouterProduit : Form
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

        BindingSource bsProduit;

        public FormAjouterProduit(BindingSource _bsProduit)
        {
            InitializeComponent();

            bsProduit = _bsProduit;
        }

        private void FormAjouterProduit_Load(object sender, EventArgs e)
        {
            textBoxDesignation.DataBindings.Add("text", bsProduit, "designation");
            textBoxQteStckProduit.DataBindings.Add("text", bsProduit, "qteStock");
            textBoxCategorieProduit.DataBindings.Add("text", bsProduit, "categorie");
            textBoxID.DataBindings.Add("text", bsProduit, "id");

            textBoxCategorieProduit.Clear();
            textBoxDesignation.Clear();
            textBoxQteStckProduit.Clear();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            bsProduit.EndEdit();
            DBHelper.syncroniser("produit");
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            bsProduit.CancelEdit();
        }

        private void labelCloseDepense_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
