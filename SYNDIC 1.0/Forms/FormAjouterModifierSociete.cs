using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SYNDIC_1._0.Forms;

namespace SYNDIC_1._0.Forms
{
    public partial class FormAjouterModifierSociete : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

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

            var src = from v in syndicDataContext.villes
                      select v;

            comboBoxVille.DataSource = src;
            comboBoxVille.DisplayMember = "nom";
            comboBoxVille.ValueMember = "id";

            comboBoxIdVille.DataSource = src;
            comboBoxIdVille.DisplayMember = "id";
            comboBoxIdVille.ValueMember = "id";


          
            var scr = from soci in syndicDataContext.societes
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
                var soci = (from soc in syndicDataContext.societes
                            where soc.id == so.id
                            select soc).Single();
                string[] oldValues = { soci.raison_sociale, soci.nom, soci.prenom, soci.adresse, soci.code_postal.ToString(), soci.tel, soci.email };
                
                soci.raison_sociale = textBoxRaison_Social.Text;
                soci.nom = textBoxNom.Text;
                soci.prenom = textBoxPrenom.Text;
                soci.adresse = textBoxAddress.Text;
                soci.code_postal = int.Parse(textBoxcode_Postal.Text);
                soci.tel = textBoxTelephone.Text;
                soci.email = textBoxEmail.Text;
                soci.id_ville = int.Parse(comboBoxIdVille.Text.ToString());

                string [] newValues = { soci.raison_sociale, soci.nom, soci.prenom, soci.adresse, soci.code_postal.ToString(), soci.tel, soci.email };

                Helper.Log.makeLog(FormLogin.userId, DateTime.Now, "Modifier", "Societe", oldValues, newValues);
            }

            else
            {

                so.raison_sociale = textBoxRaison_Social.Text;
                so.nom = textBoxNom.Text;
                so.prenom = textBoxPrenom.Text;
                so.adresse = textBoxAddress.Text;
                so.code_postal = Int32.Parse(textBoxcode_Postal.Text);
                so.tel = textBoxTelephone.Text;
                so.email = textBoxEmail.Text;


                so.id_ville = int.Parse(comboBoxIdVille.Text.ToString()); ;
                syndicDataContext.societes.InsertOnSubmit(so);

                string[] newValues = { so.raison_sociale, so.nom, so.prenom, so.adresse, so.code_postal.ToString(), so.tel, so.email };
                string[] oldValues = null;
                Helper.Log.makeLog(FormLogin.userId, DateTime.Now, "Ajouter", "Societe",oldValues ,newValues);

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

        private void textBoxPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
                e.Handled = true;
        }

        private void textBoxcode_Postal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) || textBoxcode_Postal.TextLength > 4) && (e.KeyChar != (char)(Keys.Back)))
                e.Handled = true;
        }

        private void textBoxTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxTelephone.Text.Contains('+') && e.KeyChar == '+')
                e.Handled = true;


            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)) && e.KeyChar != '+')
            {
                e.Handled = true;
            }
            else
            {

                if (Char.IsDigit(e.KeyChar))
                {
                    if (textBoxTelephone.Text.Length > 12)
                    {
                        e.Handled = true;

                    }
                }
            }
        }

        private void textBoxEmail_TextChanged_1(object sender, EventArgs e)
        {
            if (textBoxNom.Text != "" && textBoxPrenom.Text != "" && textBoxRaison_Social.Text != ""
            && StringHelper.IsValidEmailFormat(textBoxEmail.Text) && StringHelper.IsValidPhoneNumberFormat(textBoxTelephone.Text))
                buttonValdier.Enabled = true;
            else
                buttonValdier.Enabled = false;
        }
    }
}
