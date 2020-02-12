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
    public partial class FormAjouterModifierEmploye : Form
    {
        DataClassesSyndicDataContext syndicDataContext = new DataClassesSyndicDataContext();
        employe em = new employe();
        char c;
        public FormAjouterModifierEmploye(employe _em, char _c)
        {
            InitializeComponent();
            c = _c;
            em = _em;
        }

        private void FormAjouterModifierEmploye_Load(object sender, EventArgs e)
        {
         
            if (c == 'A')
            {
                dateTimePickerDateRecrutement.Enabled = false;

            }
            else
                dateTimePickerDateRecrutement.Enabled = true;
            var src = from v in syndicDataContext.villes
                      select v;

            comboBoxVille.DisplayMember = "nom";
            comboBoxVille.ValueMember = "id";
            comboBoxVille.DataSource = src;

          
            radioButtonActifTrue.Checked = true;
            

            var scr = from TEmp in syndicDataContext.employes
                      select TEmp;
            comboBoxTypeEmploye.DataSource = scr;
            comboBoxTypeEmploye.DisplayMember = "typeEmploye";

            /*  comboBoxIdVille.DataSource = src;
               comboBoxIdVille.DisplayMember = "id";
               comboBoxIdVille.ValueMember = "id";*/

            if (c == 'M')
            {
                var emp = (from emps in syndicDataContext.employes
                           where emps.id.Equals(em.id)
                           select emps).Single();

                em = emp;



                textBoxNom.Text = em.nom.ToString();
                textBoxPrenom.Text = em.prenom.ToString();
                textBoxAdresse.Text = em.adresse.ToString();
                textBoxCodePostal.Text = em.code_postal.ToString();
                textBoxEmail.Text = em.email.ToString();
                textBoxTele.Text = em.tel.ToString();
                radioButtonActifFalse.Checked = Convert.ToBoolean(!em.actif);
                comboBoxTypeEmploye.SelectedItem = em.typeEmploye.ToString();
                MessageBox.Show(em.actif.ToString());
                comboBoxVille.SelectedValue = em.id_ville;

            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            var question = MessageBox.Show("Voullez vous Ferme cet Forme ?", "Information", MessageBoxButtons.YesNo);
            if (question == DialogResult.No)
                return;
            if (question == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void labelCloseBiens_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRaz_Click(object sender, EventArgs e)
        {
            if (c == 'A')
            {

                textBoxNom.Clear();
                textBoxPrenom.Clear();
                textBoxAdresse.Clear();
                textBoxCodePostal.Clear();
                textBoxTele.Clear();
                textBoxEmail.Clear();

                //comboBoxActif.Items.Add("True");
                comboBoxTypeEmploye.SelectedIndex = 0;
                textBoxNom.Focus();

            }
        }

        private void buttonValdier_Click(object sender, EventArgs e)
        {

            if (c == 'M')
            {
                var empl = (from emp in syndicDataContext.employes
                            where emp.id == em.id
                            select emp).Single();


                empl.nom = textBoxNom.Text;
                empl.prenom = textBoxPrenom.Text;
                empl.adresse = textBoxAdresse.Text;
                empl.code_postal = int.Parse(textBoxCodePostal.Text);
                empl.tel = textBoxTele.Text;
                empl.email = textBoxEmail.Text;
                empl.date_recrutement = dateTimePickerDateRecrutement.Value;
                empl.typeEmploye = comboBoxTypeEmploye.Text;
                empl.id_ville = int.Parse(comboBoxVille.Text.ToString());
            }
            else
            {

                em.nom = textBoxNom.Text;
                em.prenom = textBoxPrenom.Text;
                em.adresse = textBoxAdresse.Text;
                em.code_postal = Int32.Parse(textBoxCodePostal.Text);
                em.tel = textBoxTele.Text;
                em.email = textBoxEmail.Text;
                em.date_recrutement = dateTimePickerDateRecrutement.Value;

                em.actif = radioButtonActifTrue.Checked;

                //  em.date_depart = dateTimePickerDateDepart.Value;
                em.typeEmploye = comboBoxTypeEmploye.Text;
                em.id_ville = int.Parse(comboBoxVille.SelectedValue.ToString()); ;
                syndicDataContext.employes.InsertOnSubmit(em);

            }

            syndicDataContext.SubmitChanges();
            syndicDataContext.Dispose();
            this.Close();
        }
    }
}
