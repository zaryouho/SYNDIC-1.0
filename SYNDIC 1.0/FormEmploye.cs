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

        private void buttonEmploye_Click(object sender, EventArgs e)
        {
           
            buttonEmploye.BackColor = Color.Navy;
            buttonEmployeArchive.BackColor = Color.Blue;
            buttonAjouterEmploye.BackColor = Color.Blue;
            var res = (from em in syndicDataContext.employe
                       join vil in syndicDataContext.ville on em.id_ville equals vil.id

                       select new { em.id, em.nom, em.prenom, em.adresse, em.code_postal, em.tel, em.email, em.date_recrutement, em.typeEmploye, idville = vil.id, ville = vil.nom });

            dataGridViewEmploye.DataSource = res;
            dataGridViewEmploye.Columns[9].Visible = false;

            // OpenFormInPannel(new FormListeProprietaire());
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {

        }

        private void buttonAjouterSEmploye_Click(object sender, EventArgs e)
        {
            c = 'A';
            using (var formAjouterModifierEmp = new FormAjouterModifierEmp(new employe(), c))
            {
                formAjouterModifierEmp.ShowDialog();
            }
            FormEmploye_Load(sender, e);
        }

        private void FormEmploye_Load(object sender, EventArgs e)
        {
            DBHelper.ouvrirConnection("SyndicConnectionStringSliman");

            var res = (from em in syndicDataContext.employe
                       join vil in syndicDataContext.ville on em.id_ville equals vil.id
                       
                       select new { em.id,em.nom,em.prenom,em.adresse,em.code_postal,em.tel,em.email,em.date_recrutement,em.typeEmploye,idville=vil.id,ville=vil.nom } );
       
            dataGridViewEmploye.DataSource = res;
            dataGridViewEmploye.Columns[9].Visible = false;
           


            /*var src = from v in syndicDataContext.ville
                      select v;

            var src = from em in syndicDataContext.employe
                      select new { em.id, em.nom, em.prenom, em.adresse, em.code_postal,
                          em.tel, em.email, em.typeEmploye, em.id_ville } ;

            dataGridViewEmploye.DataSource = src;*/


           
        }

        private void buttonFirst_Click_1(object sender, EventArgs e)
        {
            dataGridViewEmploye.CurrentCell = dataGridViewEmploye[0, 0];
        }

        private void buttonprevious_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {

                i--;
                dataGridViewEmploye.CurrentCell = dataGridViewEmploye[0, i];

            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (i < dataGridViewEmploye.RowCount - 1)
            {
                i++;
                dataGridViewEmploye.CurrentCell = dataGridViewEmploye[0, i];
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            i = dataGridViewEmploye.RowCount - 1;
            dataGridViewEmploye.CurrentCell = dataGridViewEmploye[0, i];
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
            em.date_recrutement = DateTime.Parse(dataGridViewEmploye.CurrentRow.Cells[7].Value.ToString());
           // em.actif = bool.Parse(dataGridViewEmploye.CurrentRow.Cells[8].Value.ToString());
            // em.date_depart = DateTime.Parse(dataGridViewEmploye.CurrentRow.Cells[9].Value.ToString());
            em.typeEmploye = dataGridViewEmploye.CurrentRow.Cells[7].Value.ToString();
            em.id = int.Parse(dataGridViewEmploye.CurrentRow.Cells[9].Value.ToString());



            using (var formAjouterModifierEmp = new FormAjouterModifierEmp(em, c))
            {
                formAjouterModifierEmp.ShowDialog();

            }
            FormEmploye_Load(sender, e);
            dataGridViewEmploye.CurrentCell = dataGridViewEmploye[0, i];
        }

        private void buttonAjouterSEmploye_Click_1(object sender, EventArgs e)
        {
            c = 'A';
            
            using (var formAjouterModifierEmp = new FormAjouterModifierEmp(new employe(), c))
            {
                formAjouterModifierEmp.ShowDialog();
                
            }
            
            FormEmploye_Load(sender, e);
          
        }

        private void buttonSupprimerEmploye_Click(object sender, EventArgs e)
        {
            var question = MessageBox.Show("Voullez vous supprimer cet Employe ?", "Information", MessageBoxButtons.YesNo);
            if (question == DialogResult.No)
                return;
            if (question == DialogResult.Yes)
            {
                em.id = int.Parse(dataGridViewEmploye.CurrentRow.Cells[0].Value.ToString());

                var empl = (from pr in syndicDataContext.employe
                            where pr.id.Equals(em.id)
                            select pr).Single();

                syndicDataContext.employe.DeleteOnSubmit(empl);
                syndicDataContext.SubmitChanges();

                this.FormEmploye_Load(sender, e);
            }
        }

        private void labelCloseEmploye_Click(object sender, EventArgs e)
        {
            this.Close();
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

            var src = from em in syndicDataContext.employe
                      where vs.Contains(em.nom) || vs.Contains(em.prenom)
                      || vs.Contains(em.tel) || vs.Contains(em.email) || vs.Contains(em.adresse)
                      select em;

            dataGridViewEmploye.DataSource = src;
        }

        private void buttonEmployeArchive_Click(object sender, EventArgs e)
        {
            buttonEmploye.BackColor = Color.Blue;
            buttonEmployeArchive.BackColor = Color.Navy;
            buttonAjouterEmploye.BackColor = Color.Blue;
            
            var res = (from em in syndicDataContext.employe
                       join vil in syndicDataContext.ville on em.id_ville equals vil.id
                       where em.date_depart != null 
                       select new { em.id, em.nom, em.prenom, em.adresse, em.code_postal, em.tel, em.email, 
                           em.date_recrutement,em.typeEmploye, idville = vil.id, ville = vil.nom , em.date_depart});
           
         
            dataGridViewEmploye.DataSource = res;
            dataGridViewEmploye.Columns[9].Visible = false;

       

        
        }

        private void buttonAjouterEmploye_Click(object sender, EventArgs e)
        {
            buttonEmploye.BackColor = Color.Blue;
            buttonEmployeArchive.BackColor = Color.Blue;
            buttonAjouterEmploye.BackColor = Color.Navy;
          
        }

        private void panelIN_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}



