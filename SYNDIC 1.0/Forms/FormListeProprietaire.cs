using SYNDIC_1._0.Forms;
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
            var src = from v in syndicDataContext.villes
                      join p in syndicDataContext.proprietaires
                        on v.id equals p.id_ville
                      join b in syndicDataContext.biens
                        on p.id equals b.id_proprietaire
                      where b.id_proprietaire != null
                      select new { CIN = p.CIN, Prénom = p.prenom, Nom = p.nom, Sexe = p.Sexe, p.Titre, Telephone = p.tel, Email = p.email, CodePostal = p.code_postal, Ville = v.nom, Adresse = p.adresse, Bien = String.Concat(b.id_immeuble, "-", b.nom), p.id };

            dataGridViewProprietaires.DataSource = src;
            dataGridViewProprietaires.Columns[11].Visible = false;
            dataGridViewProprietaires.AutoResizeColumns();
            dataGridViewProprietaires.AutoResizeRows();

            dataGridViewProprietaires.CurrentCell = dataGridViewProprietaires[0, i];

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

            var s = (from v in syndicDataContext.villes
                     where v.nom.Equals(dataGridViewProprietaires.CurrentRow.Cells[8].Value.ToString())
                     select v).First();
            p.id = int.Parse(dataGridViewProprietaires.CurrentRow.Cells[11].Value.ToString());
            p.nom = dataGridViewProprietaires.CurrentRow.Cells[2].Value.ToString();
            p.prenom = dataGridViewProprietaires.CurrentRow.Cells[1].Value.ToString();
            p.adresse = dataGridViewProprietaires.CurrentRow.Cells[9].Value.ToString();
            p.code_postal = Convert.ToInt32(dataGridViewProprietaires.CurrentRow.Cells[7].Value.ToString());
            p.tel = dataGridViewProprietaires.CurrentRow.Cells[5].Value.ToString();
            p.email = dataGridViewProprietaires.CurrentRow.Cells[6].Value.ToString();
            p.id_ville = s.id;
            p.Sexe = dataGridViewProprietaires.CurrentRow.Cells[3].Value.ToString();
            p.Titre = dataGridViewProprietaires.CurrentRow.Cells[4].Value.ToString();
            p.CIN = dataGridViewProprietaires.CurrentRow.Cells[0].Value.ToString();






            using (var formAjouterModifierProp = new FormAjouterModifierProp(p, op))
            {
                formAjouterModifierProp.ShowDialog();
                dataGridViewProprietaires.DataSource = null;
                FormListeProprietaire_Load(sender, e);

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
            if (!textBoxrechercher.Text.Equals(string.Empty))
            {
                string[] vs = textBoxrechercher.Text.Split(' ');
                for (int i = 0; i < vs.Length; i++)
                {
                    vs[i].Trim();
                    if (vs[i].Equals(string.Empty))
                        vs.SetValue("gOgLgXgPgIg9", i);
                }
                var src = from v in syndicDataContext.villes
                          join p in syndicDataContext.proprietaires
                            on v.id equals p.id_ville
                          join b in syndicDataContext.biens
                            on p.id equals b.id_proprietaire
                          where vs.Contains(p.CIN) || vs.Contains(p.nom) || vs.Contains(p.prenom)
                          || vs.Contains(p.tel) || vs.Contains(p.email) || vs.Contains(p.Titre)
                          || vs.Contains(p.adresse) || vs.Contains(p.Sexe) || vs.Contains(p.code_postal.ToString())
                          || vs.Contains(v.nom)
                          select new { CIN = p.CIN, Prénom = p.prenom, Nom = p.nom, Sexe = p.Sexe, p.Titre, Telephone = p.tel, Email = p.email, CodePostal = p.code_postal, Ville = v.nom, Adresse = p.adresse, Bien = String.Concat(b.id_immeuble, "-", b.nom), p.id };

                dataGridViewProprietaires.DataSource = src;
                dataGridViewProprietaires.Columns[11].Visible = false;
                dataGridViewProprietaires.AutoResizeColumns();
                dataGridViewProprietaires.AutoResizeRows();
            }
        }

        private void textBoxrechercher_TextChanged(object sender, EventArgs e)
        {
            if (textBoxrechercher.Text.Equals(string.Empty))
                FormListeProprietaire_Load(sender, e);
        }
    

    private void buttonListDocs_Click(object sender, EventArgs e)
        {
            int current_Id = Convert.ToInt32(dataGridViewProprietaires.CurrentRow.Cells[11].Value.ToString());
            new FormGestionDocument("documentProprietaire", "where id_Proprietaire = " + current_Id.ToString(), current_Id).ShowDialog();

        }
    }
}
