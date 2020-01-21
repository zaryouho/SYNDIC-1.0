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
    public partial class FormAjouterModifierEmp : Form
    {
        DataClassesSyndicDataContext syndicDataContext = new DataClassesSyndicDataContext();
        employe em = new employe();
        char c;
        public FormAjouterModifierEmp(employe _em, char _c)
        {
            InitializeComponent();
            c = _c;
            em = _em;
        }

        private void FormAjouterModifierEmp_Load(object sender, EventArgs e)
        {
            if (c == 'A')
            {
                dateTimePickerDateRecrutement.Enabled = false;
            
            }
            else
                dateTimePickerDateRecrutement.Enabled = true;
            var src = from v in syndicDataContext.ville
                      select  v;

            comboBoxVille.DataSource = src;
            comboBoxVille.DisplayMember = "nom";
            comboBoxVille.ValueMember = "id";

            comboBoxIdVille.DataSource = src;
            comboBoxIdVille.DisplayMember = "id";
            comboBoxIdVille.ValueMember = "id";


            comboBoxActif.Items.Add("True");
            comboBoxActif.Items.Add("False");
            var scr = from TEmp in syndicDataContext.employe
                      select TEmp;
            comboBoxTypeEmploye.DataSource = scr;
            comboBoxTypeEmploye.DisplayMember = "typeEmploye";

            /*  comboBoxIdVille.DataSource = src;
               comboBoxIdVille.DisplayMember = "id";
               comboBoxIdVille.ValueMember = "id";*/

            if (c == 'M')
            {


                textBoxNom.Text = em.nom.ToString();
                textBoxPrenom.Text = em.prenom.ToString();
                textBoxAdresse.Text = em.adresse.ToString();
                textBoxCodePostal.Text = em.code_postal.ToString();
                textBoxEmail.Text = em.email.ToString();
                textBoxTele.Text = em.tel.ToString();
                comboBoxActif.SelectedItem = em.actif.ToString();
                comboBoxTypeEmploye.SelectedItem = em.typeEmploye.ToString();
              //  comboBoxVille.SelectedValue = em.id_ville;

            }
        }

       

        private void buttonValdier_Click(object sender, EventArgs e)
        {

            if (c == 'M')
            {
                var empl = (from emp in syndicDataContext.employe
                            where emp.id == em.id
                            select emp).Single();


                empl.nom = textBoxNom.Text;
                empl.prenom = textBoxPrenom.Text;
                empl.adresse = textBoxAdresse.Text;
                empl.code_postal = int.Parse(textBoxCodePostal.Text);
                empl.tel = textBoxTele.Text;
                empl.email = textBoxEmail.Text;
                empl.date_recrutement = dateTimePickerDateRecrutement.Value;
                
                empl.actif = bool.Parse(comboBoxActif.Text);
                empl.typeEmploye = comboBoxTypeEmploye.Text;
                empl.id_ville = int.Parse(comboBoxIdVille.Text.ToString());



            }

            else
            {

                MessageBox.Show("aaaaa");
                em.nom = textBoxNom.Text;
                em.prenom = textBoxPrenom.Text;
                em.adresse = textBoxAdresse.Text;
                em.code_postal = Int32.Parse(textBoxCodePostal.Text);
                em.tel = textBoxTele.Text;
                em.email = textBoxEmail.Text;
                em.date_recrutement = dateTimePickerDateRecrutement.Value;
               
                em.actif = bool.Parse(comboBoxActif.Text);

              //  em.date_depart = dateTimePickerDateDepart.Value;
                em.typeEmploye = comboBoxTypeEmploye.Text;
                em.id_ville = int.Parse(comboBoxIdVille.Text.ToString()); ;
                syndicDataContext.employe.InsertOnSubmit(em);

            }

            syndicDataContext.SubmitChanges();
            syndicDataContext.Dispose();
            this.Close();
        }

       

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            if (c == 'A')
            {
               
                textBoxNom.Clear();
                textBoxPrenom.Clear();
                textBoxAdresse.Clear();
                textBoxCodePostal.Clear();
                textBoxTele.Clear();
                textBoxEmail.Clear();
                
                comboBoxActif.SelectedIndex = 1;
                //comboBoxActif.Items.Add("True");
                comboBoxTypeEmploye.SelectedIndex = 0;
                textBoxNom.Focus();

            }
            else
                this.Close();
        }

       
        private void comboBoxVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxIdVille.SelectedItem = comboBoxVille.SelectedValue;
        }
    }
}
