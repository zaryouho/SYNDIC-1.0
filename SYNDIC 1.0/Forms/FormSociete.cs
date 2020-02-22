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
    public partial class FormSociete : Form
    {
        DataClassesSyndicDataContext syndicDataContext = new DataClassesSyndicDataContext();
        char K = 'A';
        static int i = 0;
        societe so = new societe();
        public FormSociete()
        {
            InitializeComponent();
        }

        private void FormSociete_Load(object sender, EventArgs e)
        {

            var src = from soc in syndicDataContext.societes
                      join v in syndicDataContext.villes on soc.id_ville equals v.id
                      select new {    soc.id,
                                     Nom= soc.nom, 
                                     Prénom= soc.prenom, 
                                     soc.raison_sociale, 
                                     Tele=  soc.tel,
                                     Email= soc.email,
                                     Adresse= soc.adresse,
                                     soc.code_postal,
                                     ville = v.nom,
                                     soc.id_ville };

            dataGridViewSociete.DataSource = src;
            dataGridViewSociete.Columns[0].Visible = false;
            dataGridViewSociete.Columns[9].Visible = false;
            dataGridViewSociete.Columns[3].HeaderText = "Raison Sociale";
            dataGridViewSociete.Columns[7].HeaderText = "Code Postal";
            dataGridViewSociete.AutoResizeColumns();
            dataGridViewSociete.AutoResizeRows();

            dataGridViewSociete.Columns[7].Width = "Code Postal".Length * 11;
            dataGridViewSociete.Columns[3].Width = "Raison Sociale".Length * 11;

        }

        private void buttonSociete_Click(object sender, EventArgs e)
        {

            buttonSociete.BackColor = Color.Navy;
            buttonSocieteArchive.BackColor = Color.Blue;
            buttonAjouterSociete.BackColor = Color.Blue;
            FormSociete_Load(sender, e);
        }

        private void buttonAjouterSociete_Click(object sender, EventArgs e)
        {
            buttonSociete.BackColor = Color.Blue;
            buttonSocieteArchive.BackColor = Color.Blue;
            buttonAjouterSociete.BackColor = Color.Navy;
            K = 'A';

            using (var FormAjouterModifierSociete = new FormAjouterModifierSociete(new societe(), K))
            {
                FormAjouterModifierSociete.ShowDialog();

            }

            FormSociete_Load(sender, e);
        }

        private void buttonSocieteArchive_Click(object sender, EventArgs e)
        {
            buttonSociete.BackColor = Color.Blue;
            buttonSocieteArchive.BackColor = Color.Navy;
            buttonAjouterSociete.BackColor = Color.Blue;
            var src = from soc in syndicDataContext.societes
                      select soc;
            dataGridViewSociete.DataSource = src;
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            if (!textBoxRechercher.Text.Equals(string.Empty))
            {
                string[] vs = textBoxRechercher.Text.Split(' ');
                for (int i = 0; i < vs.Length; i++)
                {
                    vs[i].Trim();
                    if (vs[i].Equals(string.Empty))
                        vs.SetValue("gOgLgXgPgIg9", i);
                }

                var src = from soc in syndicDataContext.societes
                          join v in syndicDataContext.villes on soc.id_ville equals v.id
                          where vs.Contains(soc.nom) || vs.Contains(soc.prenom)
                          || vs.Contains(soc.tel) || vs.Contains(soc.email) || vs.Contains(soc.adresse)
                          || vs.Contains(soc.code_postal.ToString()) || vs.Contains(v.nom)
                          select new
                          {
                              soc.id,
                              Nom = soc.nom,
                              Prénom = soc.prenom,
                              soc.raison_sociale,
                              Tele = soc.tel,
                              Email = soc.email,
                              Adresse = soc.adresse,
                              soc.code_postal,
                              ville = v.nom,
                              soc.id_ville
                          };

                dataGridViewSociete.DataSource = src;
                dataGridViewSociete.Columns[0].Visible = false;
                dataGridViewSociete.Columns[9].Visible = false;
                dataGridViewSociete.Columns[3].HeaderText = "Raison Sociale";
                dataGridViewSociete.Columns[7].HeaderText = "Code Postal";
                dataGridViewSociete.AutoResizeColumns();
                dataGridViewSociete.AutoResizeRows();

                dataGridViewSociete.Columns[7].Width = "Code Postal".Length * 11;
                dataGridViewSociete.Columns[3].Width = "Raison Sociale".Length * 11;
            }
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            i = 0;
            dataGridViewSociete.CurrentCell = dataGridViewSociete[1, i];
        }

        private void buttonprevious_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {

                i--;
                dataGridViewSociete.CurrentCell = dataGridViewSociete[1, i];

            }
        }


        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (i < dataGridViewSociete.RowCount - 1)
            {
                i++;
                dataGridViewSociete.CurrentCell = dataGridViewSociete[1, i];
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            i = dataGridViewSociete.RowCount - 1;
            dataGridViewSociete.CurrentCell = dataGridViewSociete[1, i];
        }

        private void buttonAjouterSSociete_Click(object sender, EventArgs e)
        {
            K = 'A';

            using (var FormAjouterModifierSociete = new FormAjouterModifierSociete(new societe(), K))
            {
                FormAjouterModifierSociete.ShowDialog();

            }

            FormSociete_Load(sender, e);
        }

        private void buttonModifierSociete_Click(object sender, EventArgs e)
        {
            K = 'M';

            so.id = int.Parse(dataGridViewSociete.CurrentRow.Cells[0].Value.ToString());
            so.nom = dataGridViewSociete.CurrentRow.Cells[1].Value.ToString();
            so.prenom = dataGridViewSociete.CurrentRow.Cells[2].Value.ToString();
            so.raison_sociale = dataGridViewSociete.CurrentRow.Cells[3].Value.ToString();
            so.tel = dataGridViewSociete.CurrentRow.Cells[4].Value.ToString();
            so.email = dataGridViewSociete.CurrentRow.Cells[5].Value.ToString();
            so.adresse = dataGridViewSociete.CurrentRow.Cells[6].Value.ToString();
            so.code_postal = int.Parse(dataGridViewSociete.CurrentRow.Cells[7].Value.ToString());
            so.id_ville = int.Parse(dataGridViewSociete.CurrentRow.Cells[9].Value.ToString());



   
            using (var FormAjouterModifierSociete = new FormAjouterModifierSociete(so, K))
            {
                FormAjouterModifierSociete.ShowDialog();
            }
            FormSociete_Load(sender, e);

            /*  using (var formAjouterModifierSociete = new formAjouterModifierSociete(so, c))
              {
                  formAjouterModifierSociete.ShowDialog();

              }
              frmSociete_Load(sender, e);
              dataGridViewSociete.CurrentCell = dataGridViewSociete[0, i];*/
        }

        private void buttonSupprimerSociete_Click(object sender, EventArgs e)
        {
            var question = MessageBox.Show("Voulez vous supprimer cette société ?", "Information", MessageBoxButtons.YesNo);
            if (question == DialogResult.No)
                return;
            if (question == DialogResult.Yes)
            {
                so.id = int.Parse(dataGridViewSociete.CurrentRow.Cells[0].Value.ToString());

                var soci = (from soc in syndicDataContext.societes
                            where soc.id.Equals(so.id)
                            select soc).Single();

                syndicDataContext.societes.DeleteOnSubmit(soci);
                syndicDataContext.SubmitChanges();

                this.FormSociete_Load(sender, e);
            }
        }

        private void textBoxRechercher_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRechercher.Text == "")
                FormSociete_Load(sender, e);
        }
    }
}



