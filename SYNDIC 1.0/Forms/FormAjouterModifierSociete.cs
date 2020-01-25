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
    public partial class FormAjouterModifierSociete : Form
    {
        DataClassesSyndicDataContext syndicDataContext = new DataClassesSyndicDataContext();
        societe so= new societe();
        char k;
        public FormAjouterModifierSociete(societe _so,char _k)
        {
            InitializeComponent();
            k = _k;
            so = _so;
        }

        private void labelCloseBiens_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void FormAjouterModifierSociete_Load(object sender, EventArgs e)
        {

            textBoxRaison_Social.Focus();

            var src = from v in syndicDataContext.ville
                      select v;

            comboBoxVille.DataSource = src;
            comboBoxVille.DisplayMember = "nom";
            comboBoxVille.ValueMember = "id";

            comboBoxIdVille.DataSource = src;
            comboBoxIdVille.DisplayMember = "id";
            comboBoxIdVille.ValueMember = "id";


          
            var scr = from soci in syndicDataContext.societe
                      select soci;
           

            /*  comboBoxIdVille.DataSource = src;
               comboBoxIdVille.DisplayMember = "id";
               comboBoxIdVille.ValueMember = "id";*/

            if (k == 'M')
            {

                textBoxRaison_Social.Text = so.raison_sociale.ToString();
                textBoxNom.Text = so.nom.ToString();
                textBoxPrenom.Text = so.prenom.ToString();
                textBoxAddress.Text = so.adresse.ToString();
                textBoxcode_Postal.Text = so.code_postal.ToString();
                textBoxEmail.Text = so.email.ToString();
                textBoxTelephone.Text = so.tel.ToString();
                
               

            }
        }

        private void buttonValdier_Click(object sender, EventArgs e)
        {

            if (k == 'M')
            {
                var soci = (from soc in syndicDataContext.societe
                            where soc.id == so.id
                            select soc).Single();


                soci.nom = textBoxNom.Text;
                soci.prenom = textBoxPrenom.Text;
                soci.adresse = textBoxAddress.Text;
                soci.code_postal = int.Parse(textBoxcode_Postal.Text);
                soci.tel = textBoxTelephone.Text;
                soci.email = textBoxEmail.Text;
                soci.id_ville = int.Parse(comboBoxIdVille.Text.ToString());



            }

            else
            {

             
                so.nom = textBoxNom.Text;
                so.prenom = textBoxPrenom.Text;
                so.adresse = textBoxAddress.Text;
                so.code_postal = Int32.Parse(textBoxcode_Postal.Text);
                so.tel = textBoxTelephone.Text;
                so.email = textBoxEmail.Text;


                so.id_ville = int.Parse(comboBoxIdVille.Text.ToString()); ;
                syndicDataContext.societe.InsertOnSubmit(so);

            }

            syndicDataContext.SubmitChanges();
            syndicDataContext.Dispose();
            this.Close();
        }

        private void buttonRaz_Click(object sender, EventArgs e)
        {
            textBoxRaison_Social.Clear();
            textBoxNom.Clear();
            textBoxPrenom.Clear();
            textBoxAddress.Clear();
            textBoxcode_Postal.Clear();
            textBoxTelephone.Clear();
            textBoxEmail.Clear();
            textBoxRaison_Social.Focus();
        }
    }
}
