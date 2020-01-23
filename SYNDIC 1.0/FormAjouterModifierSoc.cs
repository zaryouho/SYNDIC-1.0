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
    public partial class FormAjouterModifierSoc : Form
    {
        DataClassesSyndicDataContext syndicDataContext = new DataClassesSyndicDataContext();
        societe s = new societe();
        char k;
        public FormAjouterModifierSoc(societe _s, char _k)
        {

            InitializeComponent();
            k = _k;
            s = _s;
        }

       

        private void labelCloseBiens_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAjouterModifierSoc_Load(object sender, EventArgs e)
        {
            var src = from v in syndicDataContext.ville
                      select v;

            comboBoxVille.DataSource = src;
            comboBoxVille.DisplayMember = "nom";
            comboBoxVille.ValueMember = "id";

            comboBoxidville.DataSource = src;
            comboBoxidville.DisplayMember = "id";
            comboBoxidville.ValueMember = "id";



            if (k == 'M')
            {

                textBoxRaison_Social.Text = s.raison_sociale.ToString();
                textBoxNom.Text = s.nom.ToString();
                textBoxPrenom.Text = s.prenom.ToString();
                textBoxAddress.Text = s.adresse.ToString();
                textBoxcode_Postal.Text = s.code_postal.ToString();
                textBoxTelephone.Text = s.tel.ToString();
                textBoxEmail.Text = s.email.ToString();
                comboBoxVille.SelectedValue = s.id_ville;

            }
        }

        private void buttonValdier_Click(object sender, EventArgs e)
        {
            if (k == 'M')
            {
                var soci = (from soc in syndicDataContext.societe
                            where soc.id == s.id
                            select soc).Single();

                s.raison_sociale = textBoxRaison_Social.Text;
                s.nom = textBoxNom.Text;
                s.prenom = textBoxPrenom.Text;
                s.adresse = textBoxAddress.Text;
                s.code_postal = int.Parse(textBoxcode_Postal.Text);
                s.tel = textBoxTelephone.Text;
                s.email = textBoxEmail.Text;
                s.id_ville = int.Parse(comboBoxVille.Text.ToString());

            }

            else
            {

                s.raison_sociale = textBoxRaison_Social.Text;
                s.nom = textBoxNom.Text;
                s.prenom = textBoxPrenom.Text;
                s.adresse = textBoxAddress.Text;
                s.code_postal = int.Parse(textBoxcode_Postal.Text);
                s.tel = textBoxTelephone.Text;
                s.email = textBoxEmail.Text;
                s.id_ville = int.Parse(comboBoxidville.Text.ToString());
                textBoxRaison_Social.Focus();
                syndicDataContext.societe.InsertOnSubmit(s);

            }

            syndicDataContext.SubmitChanges();
            syndicDataContext.Dispose();
            this.Close();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            if (k == 'A')
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
            else
                this.Close();
        }

        private void labelCloseBiens_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
