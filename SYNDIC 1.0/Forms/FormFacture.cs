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
        DataClassesSyndicDataContext syndicDataContext = new DataClassesSyndicDataContext();
        int id_Depense;
        int pos;

        public FormFacture(int _id_Depense)
        {
            InitializeComponent();
            id_Depense = _id_Depense;
        }
        private void FormFacture_Load(object sender, EventArgs e)
        {
            var lignes = from ligne in syndicDataContext.lignes
                         join produit in syndicDataContext.produits on ligne.id_produit equals produit.id
                         where ligne.id_depense.Equals(id_Depense)
                         select new { ligne.id_depense, ligne.id_produit, produit.designation, ligne.prix, ligne.qte, Montant = ligne.prix * ligne.qte };


            dataGridViewFactures.DataSource = lignes;

            if (dataGridViewFactures.RowCount > 0)
            {
                buttonFirst_Click(sender, e);
            }
            dataGridViewFactures.Columns[0].Visible = false;
            dataGridViewFactures.Columns[1].Visible = false;

        }

        private void buttonAjouterFacture_Click(object sender, EventArgs e)
        {
            ligne ligne = new ligne();
            ligne.id_depense = id_Depense;
            new FormAjouterModifierFacture("Ajouter", ligne).ShowDialog();
            FormFacture_Load(sender, e);
        }

        private void labelCloseDepense_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (dataGridViewFactures.RowCount > 0)
                if (dataGridViewFactures.CurrentRow.Index < dataGridViewFactures.RowCount - 1)
                {
                    pos++;
                    dataGridViewFactures.CurrentCell = dataGridViewFactures[2, pos];
                }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            if (dataGridViewFactures.RowCount > 0)
            {
                pos = dataGridViewFactures.RowCount - 1;
                dataGridViewFactures.CurrentCell = dataGridViewFactures[2, pos];
            }

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (dataGridViewFactures.RowCount > 0)
                if (dataGridViewFactures.CurrentRow.Index > 0)
                {
                    pos--;
                    dataGridViewFactures.CurrentCell = dataGridViewFactures[2, pos];
                }

        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            if (dataGridViewFactures.RowCount > 0)
            {
                pos = 0;
                dataGridViewFactures.CurrentCell = dataGridViewFactures[2, pos];
            }
        }

        private void buttonModifierFacture_Click(object sender, EventArgs e)
        {
            if (dataGridViewFactures.CurrentRow == null)
            {
                MessageBox.Show("Selectioner une dépense d'abord !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ligne ligne = new ligne();
            ligne.id_depense = id_Depense;
            ligne.id_produit = Convert.ToInt32(dataGridViewFactures.CurrentRow.Cells[1].Value.ToString());
            ligne.prix = Convert.ToDecimal(dataGridViewFactures.CurrentRow.Cells[3].Value.ToString());
            ligne.qte = Convert.ToInt32(dataGridViewFactures.CurrentRow.Cells[4].Value.ToString());
            new FormAjouterModifierFacture("Modifier", ligne, dataGridViewFactures.CurrentRow.Cells[2].Value.ToString()).ShowDialog();
            FormFacture_Load(sender, e);
        }

        private void buttonImprimer_Click(object sender, EventArgs e)
        {
            crystalR.Facture facture = new crystalR.Facture();
            string filter = "{depense.id} = " + id_Depense;
            Forms.FormImpression imprimer = new Forms.FormImpression(facture, filter);
            imprimer.ShowDialog();
        }
    }
}
