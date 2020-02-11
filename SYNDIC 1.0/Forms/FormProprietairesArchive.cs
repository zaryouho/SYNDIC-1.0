using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYNDIC_1._0.Forms
{
    public partial class FormProprietairesArchive : Form
    {
        DataClassesSyndicDataContext syndicDataContext = new DataClassesSyndicDataContext();
        static int i = 0;
        public FormProprietairesArchive()
        {
            InitializeComponent();
        }

        private void FormProprietairesArchive_Load(object sender, EventArgs e)
        {
            var src = from p in syndicDataContext.ProprietaireArchives
                      join v in syndicDataContext.villes on p.id_ville equals v.id
                      select new { CIN = p.cin, Prénom = p.prenom, Nom = p.nom, Sexe = p.sexe, p.titre, Telephone = p.tele, Email = p.email, CodePostal = p.code_postal, Ville = v.nom, Adresse = p.adresse, Bien = p.bien, Immeuble = p.immeuble, Date_Vente = p.dateVente, p.id };

            dataGridViewProprietaires.DataSource = src;
            dataGridViewProprietaires.Columns[13].Visible = false;
            dataGridViewProprietaires.AutoResizeColumns();
            dataGridViewProprietaires.AutoResizeRows();



        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            i = 0;
            dataGridViewProprietaires.CurrentCell = dataGridViewProprietaires[0, i];
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
                var src = from p in syndicDataContext.ProprietaireArchives
                          join v in syndicDataContext.villes on p.id_ville equals v.id
                          where vs.Contains(p.cin) || vs.Contains(p.nom) || vs.Contains(p.prenom)
                          || vs.Contains(p.tele) || vs.Contains(p.email) || vs.Contains(p.titre)
                          || vs.Contains(p.adresse) || vs.Contains(p.sexe) || vs.Contains(p.bien.ToString())
                          || vs.Contains(p.immeuble.ToString()) || vs.Contains(p.code_postal.ToString())
                          || vs.Contains(p.dateVente.ToString())
                          select new { CIN = p.cin, Prénom = p.prenom, Nom = p.nom, Sexe = p.sexe, p.titre, Telephone = p.tele, Email = p.email, CodePostal = p.code_postal, Ville = v.nom, Adresse = p.adresse, Bien = p.bien, Immeuble = p.immeuble, Date_Vente = p.dateVente, p.id };

                dataGridViewProprietaires.DataSource = src;
                dataGridViewProprietaires.Columns[13].Visible = false;
                dataGridViewProprietaires.AutoResizeColumns();
                dataGridViewProprietaires.AutoResizeRows();
            }
        }

        private void textBoxrechercher_TextChanged(object sender, EventArgs e)
        {
            if (textBoxrechercher.Text.Equals(string.Empty))
                FormProprietairesArchive_Load(sender, e);
        }



    }
}
