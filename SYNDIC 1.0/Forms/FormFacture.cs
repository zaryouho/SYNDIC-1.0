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
    public partial class FormFacture : Form
    {
        BindingSource bsFacture, bsProduit;
        int id;
        string button = "";

        public FormFacture(BindingSource _bsFacture, int _id, BindingSource _bsProduit)
        {
            bsProduit = _bsProduit;
            bsFacture = _bsFacture;
            id = _id;
            InitializeComponent();
        }
        private void FormFacture_Load(object sender, EventArgs e)
        {
            DBHelper.remplir_Grille(dataGridViewFactures, bsFacture);
            dataGridViewFactures.Columns[1].Visible = false;
            for (int i = 0; i < dataGridViewFactures.Rows.Count; ++i)
            {
                int price = Convert.ToInt32(dataGridViewFactures.Rows[i].Cells[1].Value);
                int quantity = Convert.ToInt32(dataGridViewFactures.Rows[i].Cells[2].Value);

                dataGridViewFactures.Rows[i].Cells[3].Value = price * quantity;

            }
        }

        private void buttonAjouterFacture_Click(object sender, EventArgs e)
        {
            button = "ajouter";
            new FormAjouterModifierFacture(bsProduit, bsFacture, id).ShowDialog();
        }

        private void labelCloseDepense_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
