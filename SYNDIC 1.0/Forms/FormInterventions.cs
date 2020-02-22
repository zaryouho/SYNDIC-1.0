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
    public partial class FormInterventions : Form
    {
        DataClassesSyndicDataContext syndicDataContext = new DataClassesSyndicDataContext();
        int id;
        int pos;
        public FormInterventions(int _id)
        {

            id = _id;
            InitializeComponent();
        }

        private void FormInterventions_Load(object sender, EventArgs e)
        {

            var inters = from intervention in syndicDataContext.interventions
                         where intervention.id_depense.Equals(id)
                         select new { intervention.id, intervention.libelle, intervention.dateDebut, intervention.dateFin, intervention.montant, intervention.id_depense };

            /* DBHelper.ouvrirConnection("SyndicConnectionStringReda");
             DBHelper.remplir_dataset("select * from intervention","intervention");
             bsIntervention = DBHelper.remplir_bindingsource("intervention");
             DBHelper.remplir_Grille(dataGridViewInterventions, bsIntervention);*/
            dataGridViewInterventions.DataSource = inters;

            dataGridViewInterventions.Columns[0].Visible = false;
            dataGridViewInterventions.Columns[5].Visible = false;
        }

        private void labelCloseDepense_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAjouterIntervention_Click(object sender, EventArgs e)
        {
            intervention intervention = new intervention();
            intervention.id_depense = id;
            new FormAjouterModifierIntervention("Ajouter", intervention).ShowDialog();

            FormInterventions_Load(sender, e);

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (dataGridViewInterventions.CurrentRow.Index < dataGridViewInterventions.RowCount - 1)
            {
                pos++;
                dataGridViewInterventions.CurrentCell = dataGridViewInterventions[1, pos];
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            pos = dataGridViewInterventions.RowCount - 1;
            dataGridViewInterventions.CurrentCell = dataGridViewInterventions[1, pos];

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (dataGridViewInterventions.CurrentRow.Index > 0)
            {
                pos--;
                dataGridViewInterventions.CurrentCell = dataGridViewInterventions[1, pos];
            }
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            dataGridViewInterventions.CurrentCell = dataGridViewInterventions[1, pos];

        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModifierIntervention_Click(object sender, EventArgs e)
        {
            if (dataGridViewInterventions.CurrentRow == null)
            {
                MessageBox.Show("Sélectioner une intervention d'abord !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int index = dataGridViewInterventions.CurrentRow.Index;
            intervention intervention = new intervention();
            intervention.id = Convert.ToInt32(dataGridViewInterventions.CurrentRow.Cells[0].Value.ToString());
            intervention.libelle = dataGridViewInterventions.CurrentRow.Cells[1].Value.ToString();
            intervention.dateDebut = Convert.ToDateTime(dataGridViewInterventions.CurrentRow.Cells[2].Value.ToString());
            intervention.dateFin = Convert.ToDateTime(dataGridViewInterventions.CurrentRow.Cells[3].Value.ToString());
            intervention.montant = Convert.ToDecimal(dataGridViewInterventions.CurrentRow.Cells[4].Value.ToString());
            intervention.id_depense = Convert.ToInt32(dataGridViewInterventions.CurrentRow.Cells[5].Value.ToString());

            new FormAjouterModifierIntervention("Modifier", intervention).ShowDialog();
            FormInterventions_Load(sender, e);

            dataGridViewInterventions.CurrentCell = dataGridViewInterventions[1, index];

        }
    }
}
