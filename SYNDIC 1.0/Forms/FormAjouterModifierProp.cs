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
        public FormAjouterModifierProp(proprietaire _p, char _op)
        {
            InitializeComponent();
            p = _p;
            op = _op;
        }

     

        private void FormAjouterModifierProp_Load(object sender, EventArgs e)
        {
            comboBoxSexe.Items.Add("Homme");
            comboBoxSexe.Items.Add("Femme");

            comboBoxTitre.Items.Add("Mlle.");
            comboBoxTitre.Items.Add("Mme.");
            comboBoxTitre.Items.Add("Mr.");



            var src = from v in syndicDataContext.villes
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
                comboBoxIdVille.SelectedItem = p.id_ville;
                comboBoxVille.SelectedValue = p.id_ville;

            }

            else
            {
                comboBoxTitre.SelectedIndex = 2;
                comboBoxSexe.SelectedIndex = 0;
                comboBoxIdVille.SelectedIndex = 0;
                textBoxCin.Focus();
            }


        }

        private void buttonValider_Click(object sender, EventArgs e)
        {


            if (op == 'M')
            {
                var prop = (from pro in syndicDataContext.proprietaires
                            where pro.id == p.id
                            select pro).Single();

                prop.CIN = textBoxCin.Text;
                prop.nom = textBoxNom.Text;
                prop.prenom = textBoxPrenom.Text;
                prop.Sexe = comboBoxSexe.SelectedItem.ToString();
                prop.adresse = textBoxAdresse.Text;
                prop.code_postal = int.Parse(textBoxCodePostal.Text);
                prop.email = textBoxEmail.Text;
                prop.tel = textBoxTele.Text;
                prop.Titre = comboBoxTitre.Text;
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
                p.id_ville = int.Parse(comboBoxIdVille.Text.ToString()); ;

                syndicDataContext.proprietaires.InsertOnSubmit(p);

            }

            syndicDataContext.SubmitChanges();
            syndicDataContext.Dispose();
            this.Close();
        }

        public void buttonAnnuler_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void labelCloseProprietaires_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void comboBoxSexe_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCin.Text != "" && textBoxNom.Text != "" && textBoxPrenom.Text != ""
             && StringHelper.IsValidEmailFormat(textBoxEmail.Text) && StringHelper.IsValidPhoneNumberFormat(textBoxTele.Text))
                buttonValider.Enabled = true;
            else
                buttonValider.Enabled = false;


        }

        private void comboBoxVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxIdVille.SelectedItem = comboBoxVille.SelectedValue;
        }

        private void buttonRAZ_Click(object sender, EventArgs e)
        {
            InitializeControls.clearText(this);
            comboBoxTitre.SelectedIndex = 2;
            comboBoxSexe.SelectedIndex = 0;
            comboBoxIdVille.SelectedIndex = 0;
            textBoxCin.Focus();
        }

        private void textBoxTele_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxTele.Text.Contains('+') && e.KeyChar == '+')
                e.Handled = true;


            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)) && e.KeyChar != '+')
            {
                e.Handled = true;
            }
            else
            {

                if (Char.IsDigit(e.KeyChar))
                {
                    if (textBoxTele.Text.Length > 12)
                    {
                        e.Handled = true;

                    }
                }
            }


        }

        private void textBoxCodePostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) || textBoxCodePostal.TextLength > 4) && (e.KeyChar != (char)(Keys.Back)))
                e.Handled = true;
        }

        private void textBoxPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
                e.Handled = true;
        }
    }
}
