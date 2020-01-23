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
    public partial class FormAjouterModifierProp : Form
    {
        DataClassesSyndicDataContext syndicDataContext = new DataClassesSyndicDataContext();
        proprietaire p = new proprietaire();
        readonly char op;
        public FormAjouterModifierProp( proprietaire _p,char _op )
        {
            InitializeComponent();
            p = _p;
            op = _op;
        }

        private void labelTitre_Click(object sender, EventArgs e)
        {

        }

        private void FormAjouterModifierProp_Load(object sender, EventArgs e)
        {
            comboBoxSexe.Items.Add("Homme");
            comboBoxSexe.Items.Add("Femme");

            comboBoxTitre.Items.Add("Mlle.");
            comboBoxTitre.Items.Add("Mme.");
            comboBoxTitre.Items.Add("Mr.");

            var src = from v in syndicDataContext.ville
                      select v;

            comboBoxVille.DataSource = src;
            comboBoxVille.DisplayMember = "nom";
            comboBoxVille.ValueMember = "id";

            comboBoxIdVille.DataSource = src;
            comboBoxIdVille.DisplayMember = "id";
            comboBoxIdVille.ValueMember = "id";

            if (op == 'M')
            {

                textBoxCin.Text = p.CIN.ToString();
                textBoxNom.Text = p.nom.ToString();
                textBoxPrenom.Text = p.prenom.ToString();
                comboBoxSexe.SelectedItem = p.Sexe.ToString();
                textBoxAdresse.Text = p.adresse.ToString();
                textBoxCodePostal.Text = p.code_postal.ToString();
                textBoxEmail.Text = p.email.ToString();
                textBoxTele.Text = p.tel.ToString();
                comboBoxTitre.SelectedItem = p.Titre.ToString();
                comboBoxIdVille.SelectedItem = p.id_ville ;
                comboBoxVille.SelectedValue = p.id_ville;

            }

            
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            

            if (op == 'M')
            {
                var prop = (from pro in syndicDataContext.proprietaire
                           where pro.id == p.id
                           select pro).Single();
                    
                prop.CIN= textBoxCin.Text ;
                prop.nom= textBoxNom.Text ;
                prop.prenom= textBoxPrenom.Text ;
                prop.Sexe = comboBoxSexe.SelectedItem.ToString() ;
                prop.adresse = textBoxAdresse.Text ;
                prop.code_postal= int.Parse(textBoxCodePostal.Text) ;
                prop.email= textBoxEmail.Text ;
                prop.tel= textBoxTele.Text ;
                prop.Titre= comboBoxTitre.Text;
                prop.id_ville = int.Parse(comboBoxIdVille.Text.ToString());              
                
            }

            else
            {

                p.CIN = textBoxCin.Text;
                p.nom = textBoxNom.Text;
                p.prenom = textBoxPrenom.Text;
                p.Sexe = comboBoxSexe.SelectedItem.ToString();
                p.adresse = textBoxAdresse.Text;
                p.code_postal = int.Parse(textBoxCodePostal.Text);
                p.email = textBoxEmail.Text;
                p.tel = textBoxTele.Text;
                p.Titre = comboBoxTitre.Text;
                p.id_ville = int.Parse(comboBoxIdVille.Text.ToString());
                
                syndicDataContext.proprietaire.InsertOnSubmit(p);
            }
            
            syndicDataContext.SubmitChanges();
            syndicDataContext.Dispose();
            this.Close();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            if (op == 'A')
            {

                textBoxNom.Clear();
                textBoxPrenom.Clear();
                textBoxAdresse.Clear();
                textBoxCin.Clear();
                textBoxCodePostal.Clear();
                textBoxTele.Clear();
                comboBoxTitre.SelectedIndex=0;
                textBoxEmail.Clear();
                comboBoxSexe.SelectedIndex = 0;
                comboBoxSexe.SelectedIndex = 0;
                textBoxCin.Focus();

            }
            else
                this.Close();
        }

        private void labelCloseProprietaires_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxIdVille_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxSexe_TextChanged(object sender, EventArgs e)
        {
            //if (textBoxCin.Text != "" && textBoxNom.Text != "" && textBoxPrenom.Text != "" 
            //    && comboBoxSexe.Text != "" && textBoxEmail.Text != "" && textBoxTele.Text != "" && comboBoxTitre.Text != "")
            //    buttonValider.Enabled = true;
            //else
            //    buttonValider.Enabled = false;
        }

        private void comboBoxVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxIdVille.SelectedItem = comboBoxVille.SelectedValue;
        }
    }
}
