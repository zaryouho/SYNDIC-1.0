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
    public partial class FormEmploye : Form
    {
        DataClassesSyndicDataContext syndicDataContext = new DataClassesSyndicDataContext();
        char c = 'A';
        static int i = 0;
        employe em = new employe();
        ville vl = new ville();
        public FormEmploye()
        {
            InitializeComponent();
        }

        private void FormEmploye_Load(object sender, EventArgs e)
        {

            var res = from em in syndicDataContext.employes
                      join vil in syndicDataContext.villes on em.id_ville equals vil.id
                      where em.date_depart == null

                      select new
                      {
                          em.id,
                          Nom = em.nom,
                          Prénom = em.prenom,
                          Adresse = em.adresse,
                          Code_Postal = em.code_postal,
                          Tele = em.tel,
                          Email = em.email,
                          em.date_recrutement,
                          em.typeEmploye,
                          Ville = vil.nom,

                          Disponible = em.actif,
                      };

            dataGridViewEmploye.DataSource = res;
            dataGridViewEmploye.Columns[0].Visible = false;
            dataGridViewEmploye.Columns[7].HeaderText = "Date Recruteement";
            dataGridViewEmploye.Columns[8].HeaderText = "Type Employe";
            dataGridViewEmploye.Columns[4].HeaderText = "Code Postal";
            dataGridViewEmploye.AutoResizeColumns();
            dataGridViewEmploye.AutoResizeRows();

            dataGridViewEmploye.Columns[8].Width = "Type Employe".Length * 11;
            dataGridViewEmploye.Columns[7].Width = "Date Recruteement".Length * 11;
            dataGridViewEmploye.Columns[4].Width = "Code Postal".Length * 11;
        }

        private void buttonEmploye_Click(object sender, EventArgs e)
        {
            buttonEmploye.BackColor = Color.Navy;
            buttonEmployeArchive.BackColor = Color.Blue;
            buttonAjouterEmploye.BackColor = Color.Blue;
            FormEmploye_Load(sender, e);
        }

        private void buttonAjouterEmploye_Click(object sender, EventArgs e)
        {
            buttonEmploye.BackColor = Color.Blue;
            buttonEmployeArchive.BackColor = Color.Blue;
            buttonAjouterEmploye.BackColor = Color.Navy;
            c = 'A';

            using (var FormAjouterModifierEmploye = new FormAjouterModifierEmploye(new employe(), c))
            {
                FormAjouterModifierEmploye.ShowDialog();

            }
            FormEmploye_Load(sender, e);
            dataGridViewEmploye.CurrentCell = dataGridViewEmploye[1, i];
        }

        private void buttonEmployeArchive_Click(object sender, EventArgs e)
        {
            buttonEmploye.BackColor = Color.Blue;
            buttonEmployeArchive.BackColor = Color.Navy;
            buttonAjouterEmploye.BackColor = Color.Blue;

            var res = (from em in syndicDataContext.employes
                       join vil in syndicDataContext.villes on em.id_ville equals vil.id
                       where em.date_depart != null
                       select new
                       {
                           em.id,
                           Nom = em.nom,
                           Prénom = em.prenom,
                           Adresse = em.adresse,
                           em.code_postal,
                           Tele = em.tel,
                           Email = em.email,
                           em.date_recrutement,
                           em.typeEmploye,
                           Ville = vil.nom,
                           em.date_depart,
                           Disponible = em.actif,
                       });

            buttonModifierEmploye.Enabled = false;
            dataGridViewEmploye.DataSource = res;
            dataGridViewEmploye.Columns[0].Visible = false;
            dataGridViewEmploye.Columns[7].HeaderText = "Date Recruteement";
            dataGridViewEmploye.Columns[8].HeaderText = "Type Employe";
            dataGridViewEmploye.Columns[9].HeaderText = "Date Depart";
            dataGridViewEmploye.Columns[4].HeaderText = "Code Postal";
            dataGridViewEmploye.AutoResizeColumns();
            dataGridViewEmploye.AutoResizeRows();

            dataGridViewEmploye.Columns[8].Width = "Type Employe".Length * 11;
            dataGridViewEmploye.Columns[7].Width = "Date Recruteement".Length * 11;
            dataGridViewEmploye.Columns[9].Width = "Date Depart".Length*11 ;
            dataGridViewEmploye.Columns[4].Width = "Code Postal".Length*11 ;
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            i = 0;
            dataGridViewEmploye.CurrentCell = dataGridViewEmploye[1, i];
        }

        private void buttonprevious_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {

                i--;
                dataGridViewEmploye.CurrentCell = dataGridViewEmploye[1,i];

            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (i < dataGridViewEmploye.RowCount - 1)
            {
                i++;
                dataGridViewEmploye.CurrentCell = dataGridViewEmploye[1, i];
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            i = dataGridViewEmploye.RowCount - 1;
            dataGridViewEmploye.CurrentCell = dataGridViewEmploye[1, i];
        }

        private void buttonModifierEmploye_Click(object sender, EventArgs e)
        {
            c = 'M';

            em.id = int.Parse(dataGridViewEmploye.CurrentRow.Cells[0].Value.ToString());
            em.nom = dataGridViewEmploye.CurrentRow.Cells[1].Value.ToString();
            em.prenom = dataGridViewEmploye.CurrentRow.Cells[2].Value.ToString();
            em.adresse = dataGridViewEmploye.CurrentRow.Cells[3].Value.ToString();
            em.code_postal = int.Parse(dataGridViewEmploye.CurrentRow.Cells[4].Value.ToString());
            em.tel = dataGridViewEmploye.CurrentRow.Cells[5].Value.ToString();
            em.email = dataGridViewEmploye.CurrentRow.Cells[6].Value.ToString();
            //em.date_recrutement = DateTime.Parse(dataGridViewEmploye.CurrentRow.Cells[7].Value.ToString());
            //em.actif = bool.Parse(dataGridViewEmploye.CurrentRow.Cells[11].Value.ToString());
            
            em.typeEmploye = dataGridViewEmploye.CurrentRow.Cells[8].Value.ToString();
           



            using (var FormAjouterModifierEmploye = new FormAjouterModifierEmploye(em, c))
            {
                FormAjouterModifierEmploye.ShowDialog();

            }
            FormEmploye_Load(sender, e);
            dataGridViewEmploye.CurrentCell = dataGridViewEmploye[1, i];
        }

        private void buttonSupprimerEmploye_Click(object sender, EventArgs e)
        {
            var question = MessageBox.Show("Voullez vous supprimer cet Employe ?", "Information", MessageBoxButtons.YesNo);
            if (question == DialogResult.No)
                return;
            if (question == DialogResult.Yes)
            {
                em.id = int.Parse(dataGridViewEmploye.CurrentRow.Cells[0].Value.ToString());

                var empl = (from pr in syndicDataContext.employes
                            where pr.id.Equals(em.id)
                            select pr).Single();

                empl.date_depart = DateTime.Today;
                empl.actif = false;

                
                syndicDataContext.SubmitChanges();

                this.FormEmploye_Load(sender, e);
            }
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            if (!textBoxRechercher.Text.Equals(string.Empty))
            {
                var vs = textBoxRechercher.Text.Split(' ');
                for (int i = 0; i < vs.Length; i++)
                {
                    vs[i].Trim();
                    if (vs[i].Equals(string.Empty))
                        vs.SetValue("gOgLgXgPgIg9", i);
                }

                var src = from em in syndicDataContext.employes
                          join vil in syndicDataContext.villes on em.id_ville equals vil.id
                          where vs.Contains(em.nom) || vs.Contains(em.prenom)
                          || vs.Contains(em.tel) || vs.Contains(em.email) || vs.Contains(em.adresse)
                          || vs.Contains(em.date_recrutement.ToString()) || vs.Contains(em.code_postal.ToString())
                          || vs.Contains(vil.nom) || vs.Contains(em.typeEmploye)
                          select new
                          {
                              em.id,
                              Nom = em.nom,
                              Prénom = em.prenom,
                              Adresse = em.adresse,
                              Code_Postal = em.code_postal,
                              Tele = em.tel,
                              Email = em.email,
                              em.date_recrutement,
                              em.typeEmploye,
                              Ville = vil.nom,

                              Disponible = em.actif,
                          };

                dataGridViewEmploye.DataSource = src;
                dataGridViewEmploye.Columns[0].Visible = false;
                dataGridViewEmploye.Columns[7].HeaderText = "Date Recruteement";
                dataGridViewEmploye.Columns[8].HeaderText = "Type Employe";
                dataGridViewEmploye.Columns[4].HeaderText = "Code Postal";
                dataGridViewEmploye.AutoResizeColumns();
                dataGridViewEmploye.AutoResizeRows();

                dataGridViewEmploye.Columns[8].Width = "Type Employe".Length * 11;
                dataGridViewEmploye.Columns[7].Width = "Date Recruteement".Length * 11;
                dataGridViewEmploye.Columns[4].Width = "Code Postal".Length * 11;
            }
        }



        private void buttonListDocs_Click(object sender, EventArgs e)
        {
            var current_Id = Convert.ToInt32(dataGridViewEmploye.CurrentRow.Cells[0].Value.ToString());
            using (var formGestionDocument = new FormGestionDocument(nameof(documentEmploye), "where id_employe = " + current_Id.ToString(), current_Id))
            {
                formGestionDocument.ShowDialog();
            }
        }

        private void textBoxRechercher_TextChanged(object sender, EventArgs e)
        {
            if(textBoxRechercher.Text=="")
                FormEmploye_Load(sender, e);
        }
    }
}

