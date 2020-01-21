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
    public partial class FormSociete : Form
    {
        DataClassesSyndicDataContext syndicDataContext = new DataClassesSyndicDataContext();
        char k = 'A';
        static int i = 0;
        societe so = new societe();
        public FormSociete()
        {
            InitializeComponent();
        }

        private void panelIN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelCloseSociete_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            dataGridViewSociete.CurrentCell = dataGridViewSociete[0, 0];
        }

        private void buttonprevious_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {

                i--;
                dataGridViewSociete.CurrentCell = dataGridViewSociete[0, i];

            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (i < dataGridViewSociete.RowCount - 1)
            {
                i++;
                dataGridViewSociete.CurrentCell = dataGridViewSociete[0, i];
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            i = dataGridViewSociete.RowCount - 1;
            dataGridViewSociete.CurrentCell = dataGridViewSociete[0, i];
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            string[] vs = textBoxRechercher.Text.Split(' ');
            for (int i = 0; i < vs.Length; i++)
            {
                vs[i].Trim();
                if (vs[i].Equals(string.Empty))
                    vs.SetValue("gOgLgXgPgIg9", i);
            }

            var src = from em in syndicDataContext.societe
                      where vs.Contains(em.nom) || vs.Contains(em.prenom)
                      || vs.Contains(em.tel) || vs.Contains(em.email) || vs.Contains(em.adresse)
                      select em;

            dataGridViewSociete.DataSource = src;
        }

        private void buttonAjouterSSociete_Click(object sender, EventArgs e)
        {
            k = 'A';
            using (var formAjouterModifiersociete = new FormAjouterModifierSociete(new societe(), k))
            {
                formAjouterModifiersociete.ShowDialog();
            }
            FormSociete_Load(sender, e);
        }

        private void FormSociete_Load(object sender, EventArgs e)
        {
            DBHelper.ouvrirConnection("SyndicConnectionStringSliman");

            var res = (from so in syndicDataContext.societe
                       join vil in syndicDataContext.ville on so.id_ville equals vil.id

                       select new
                       { so.id, so.raison_sociale, so.nom,
                           so.prenom,
                           so.adresse,
                           so.code_postal,
                           so.tel, so.email, idville = vil.id, ville = vil.nom,

                       }) ;
            dataGridViewSociete.DataSource = res;
            dataGridViewSociete.Columns[8].Visible = false;

        }

        private void buttonModifierSociete_Click(object sender, EventArgs e)
        {
            k = 'M';

            so.id = int.Parse(dataGridViewSociete.CurrentRow.Cells[0].Value.ToString());
            so.raison_sociale = dataGridViewSociete.CurrentRow.Cells[1].Value.ToString();
            so.nom = dataGridViewSociete.CurrentRow.Cells[2].Value.ToString();
            so.prenom = dataGridViewSociete.CurrentRow.Cells[3].Value.ToString();
            so.adresse = dataGridViewSociete.CurrentRow.Cells[4].Value.ToString();
            so.code_postal = int.Parse(dataGridViewSociete.CurrentRow.Cells[5].Value.ToString());
            so.tel = dataGridViewSociete.CurrentRow.Cells[6].Value.ToString();
            so.email = dataGridViewSociete.CurrentRow.Cells[7].Value.ToString();
            so.id_ville = int.Parse(dataGridViewSociete.CurrentRow.Cells[8].Value.ToString());

            using (var FormAjouterModifierSociete = new FormAjouterModifierSociete(so, k))
            {
                FormAjouterModifierSociete.ShowDialog();
            }
            FormSociete_Load(sender, e);
            dataGridViewSociete.CurrentCell = dataGridViewSociete[0, 1];
            /*  using (var formAjouterModifierSociete = new formAjouterModifierSociete(so, c))
              {
                  formAjouterModifierSociete.ShowDialog();

              }
              frmSociete_Load(sender, e);
              dataGridViewSociete.CurrentCell = dataGridViewSociete[0, i];*/
        }

        private void buttonSupprimerSociete_Click(object sender, EventArgs e)
        {
            var question = MessageBox.Show("Voullez vous supprimer cet Societe ?", "Information", MessageBoxButtons.YesNo);
            if (question == DialogResult.No)
                return;
            if (question == DialogResult.Yes)
            {
                so.id = int.Parse(dataGridViewSociete.CurrentRow.Cells[0].Value.ToString());

                var socie = (from sc in syndicDataContext.societe
                             where sc.id.Equals(so.id)
                             select sc).Single();

                syndicDataContext.societe.DeleteOnSubmit(socie);
                syndicDataContext.SubmitChanges();

                this.FormSociete_Load(sender, e);
            }
        }

        private void buttonAjouterSSociete_Click_1(object sender, EventArgs e)
        {
            k = 'A';
            using (var formAjouterModifiersociete = new FormAjouterModifierSociete(new societe(), k))
            {
                formAjouterModifiersociete.ShowDialog();
            }
            FormSociete_Load(sender, e);
        }

        private void buttonSociete_Click(object sender, EventArgs e)
        {
            buttonSociete.BackColor = Color.Navy;
            buttonSocieteArchive.BackColor = Color.Blue;
            buttonAjouterSociete.BackColor = Color.Blue;
      
            var src = from soc in syndicDataContext.societe
                      select soc;
            dataGridViewSociete.DataSource = src;

        }

        private void panelIN_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonSocieteArchive_Click(object sender, EventArgs e)
        {
            buttonSociete.BackColor = Color.Blue;
            buttonSocieteArchive.BackColor = Color.Navy;
            buttonAjouterSociete.BackColor = Color.Blue;

        }

        private void buttonAjouterSociete_Click(object sender, EventArgs e)
        {
            buttonSociete.BackColor = Color.Blue;
            buttonSocieteArchive.BackColor = Color.Blue;
            buttonAjouterSociete.BackColor = Color.Navy;
        }

        private void buttonRechercher_Click_1(object sender, EventArgs e)
        {

            string[] vs = textBoxRechercher.Text.Split(' ');
            for (int i = 0; i < vs.Length; i++)
            {
                vs[i].Trim();
                if (vs[i].Equals(string.Empty))
                    vs.SetValue("gOgLgXgPgIg9", i);
            }

            var src = from so in syndicDataContext.employe
                      where vs.Contains(so.nom) || vs.Contains(so.prenom)
                      || vs.Contains(so.tel) || vs.Contains(so.email) || vs.Contains(so.adresse)
                      select so;

            dataGridViewSociete.DataSource = src;

        }

        private void buttonFirst_Click_1(object sender, EventArgs e)
        {
            dataGridViewSociete.CurrentCell = dataGridViewSociete[0, 0];
        }

        private void buttonprevious_Click_1(object sender, EventArgs e)
        {
            if (i > 0)
            {

                i--;
                dataGridViewSociete.CurrentCell = dataGridViewSociete[0, i];

            }
        }

        private void buttonNext_Click_1(object sender, EventArgs e)
        {
            if (i < dataGridViewSociete.RowCount - 1)
            {
                i++;
                dataGridViewSociete.CurrentCell = dataGridViewSociete[0, i];
            }
        }

        private void buttonLast_Click_1(object sender, EventArgs e)
        {
            i = dataGridViewSociete.RowCount - 1;
            dataGridViewSociete.CurrentCell = dataGridViewSociete[0, i];
        }
    }
}
