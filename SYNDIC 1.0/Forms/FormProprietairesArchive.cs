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
                      select new { CIN = p.cin, Prénom = p.prenom, Nom = p.nom, Sexe = p.sexe, p.titre, Telephone = p.tele, Email = p.email, CodePostal = p.code_postal, Ville = v.nom, Adresse = p.adresse, Bien = p.bien,Immeuble =p.immeuble,Date_Vente=p.dateVente, p.id };

            dataGridViewProprietaires.DataSource = src;
            dataGridViewProprietaires.Columns[13].Visible = false;
            dataGridViewProprietaires.AutoResizeColumns();

           

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
    }
}
