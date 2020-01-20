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
    public partial class FormListeProprietaire : Form
    {
        DataClassesSyndicDataContext syndicDataContext = new DataClassesSyndicDataContext();
        char op = 'A';
        static int i = 0;
        proprietaire p = new proprietaire();

        public FormListeProprietaire()
        {
            InitializeComponent();
        }

        private void FormListeProprietaire_Load(object sender, EventArgs e)
        {
            DBHelper.ouvrirConnection("SyndicConnectionStringReda");
            var src = from p in syndicDataContext.proprietaire
                      select p;

            dataGridViewProprietaires.DataSource = src;
        }

        private void buttonAjouterProprietaire_Click(object sender, EventArgs e)
        {
            op = 'A';
            using (var formAjouterModifierProp = new FormAjouterModifierProp(new proprietaire(), op))
            {
                formAjouterModifierProp.ShowDialog();
            }

            FormListeProprietaire_Load(sender, e);
            dataGridViewProprietaires.CurrentCell = dataGridViewProprietaires[0, i];
           
        }

        private void buttonModifierProprietaire_Click(object sender, EventArgs e)
        {
            op = 'M';

            p.id = int.Parse(dataGridViewProprietaires.CurrentRow.Cells[0].Value.ToString());
            p.nom = dataGridViewProprietaires.CurrentRow.Cells[1].Value.ToString();
            p.prenom = dataGridViewProprietaires.CurrentRow.Cells[2].Value.ToString();
            p.adresse = dataGridViewProprietaires.CurrentRow.Cells[3].Value.ToString();
            p.code_postal = int.Parse(dataGridViewProprietaires.CurrentRow.Cells[4].Value.ToString());
            p.tel = dataGridViewProprietaires.CurrentRow.Cells[5].Value.ToString();
            p.email = dataGridViewProprietaires.CurrentRow.Cells[6].Value.ToString();
            p.id_ville = int.Parse(dataGridViewProprietaires.CurrentRow.Cells[7].Value.ToString());
            p.Sexe = dataGridViewProprietaires.CurrentRow.Cells[8].Value.ToString();
            p.Titre = dataGridViewProprietaires.CurrentRow.Cells[9].Value.ToString();
            p.CIN = dataGridViewProprietaires.CurrentRow.Cells[10].Value.ToString();


            using (var formAjouterModifierProp = new FormAjouterModifierProp(p, op))
            {
                formAjouterModifierProp.ShowDialog();

            }
            FormListeProprietaire_Load(sender, e);
            dataGridViewProprietaires.CurrentCell = dataGridViewProprietaires[0, i];
        }

        private void buttonSupprimerProprietaire_Click(object sender, EventArgs e)
        {
            var question = MessageBox.Show("Voullez vous supprimer cet proprietaire ?", "Information", MessageBoxButtons.YesNo);
            if (question == DialogResult.No)
                return;
            if (question == DialogResult.Yes)
            {
                p.id = int.Parse(dataGridViewProprietaires.CurrentRow.Cells[0].Value.ToString());

                var prop = (from pr in syndicDataContext.proprietaire
                            where pr.id.Equals(p.id)
                            select pr).Single();

                syndicDataContext.proprietaire.DeleteOnSubmit(prop);
                syndicDataContext.SubmitChanges();

                this.FormListeProprietaire_Load(sender, e);
            }
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            i = 0;
            dataGridViewProprietaires.CurrentCell = dataGridViewProprietaires[0, 0];
        }

        private void buttonprevious_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                dataGridViewProprietaires.CurrentCell = dataGridViewProprietaires[0, i];

            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (i < dataGridViewProprietaires.RowCount - 1)
            {
                i++;
                dataGridViewProprietaires.CurrentCell = dataGridViewProprietaires[0, i];
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {

            i = dataGridViewProprietaires.RowCount - 1;
            dataGridViewProprietaires.CurrentCell = dataGridViewProprietaires[0, i];
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            string[] vs = textBoxrechercher.Text.Split(' ');
            for (int i = 0; i < vs.Length; i++)
            {
                vs[i].Trim();
                if (vs[i].Equals(string.Empty))
                    vs.SetValue("gOgLgXgPgIg9", i);
            }
            var src = from p in syndicDataContext.proprietaire
                      where vs.Contains(p.CIN) || vs.Contains(p.nom) || vs.Contains(p.prenom)
                      || vs.Contains(p.tel) || vs.Contains(p.email) || vs.Contains(p.Titre)
                      || vs.Contains(p.adresse) || vs.Contains(p.Sexe)
                      select p;

            dataGridViewProprietaires.DataSource = src;
        }

        private void textBoxrechercher_TextChanged(object sender, EventArgs e)
        {
            if (textBoxrechercher.Text.Equals(string.Empty))
                FormListeProprietaire_Load(sender, e);
        }
    }
}
