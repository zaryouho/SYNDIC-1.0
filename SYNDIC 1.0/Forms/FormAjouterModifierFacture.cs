using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SYNDIC_1._0
{
    public partial class FormAjouterModifierFacture : Form
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


        string operation;
        ligne ligneA;
        string produitLibelle;

        public FormAjouterModifierFacture(string _operation, ligne _ligne, string _produitLibelle = "")
        {
            InitializeComponent();
            operation = _operation;
            ligneA = _ligne;
            produitLibelle = _produitLibelle;
        }

        private void labelCloseDepense_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAjouterModifierFacture_Load(object sender, EventArgs e)
        {
            /*var test = from ligne
                       in syndicDataContext.lignes
                       where ligne.id_depense.Equals(ligneA.id_depense)
                       select ligne;

            var produits = from produit in syndicDataContext.produits
                           select produit;
            */



            SqlCommand command = new SqlCommand("select id,designation " +
                                                " from produit " +
                                                " where id not in ( " +
                                                    " select id_produit " +
                                                    " from ligne " +
                                                    " where id_depense = " + ligneA.id_depense.ToString() + ")", DBHelper.connection);

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                comboBoxProduit.Items.Add(dataReader["designation"]);
                comboBoxidProduit.Items.Add(dataReader["id"]);
            }
            dataReader.Close();
            command = null;
            dataReader = null;

            comboBoxProduit.SelectedIndex = 0;

            /* foreach(ligne l in test)
                 produits.Where(prod => prod.id == l.id_produit);*/

            /* comboBoxProduit.DisplayMember = "designation";
             comboBoxProduit.ValueMember = "id";
             comboBoxProduit.DataSource = produits;*/

            if (operation == "Modifier")
            {
                comboBoxProduit.Items.Add(produitLibelle);
                comboBoxidProduit.Items.Add(ligneA.id_produit.ToString());
                comboBoxProduit.Text = produitLibelle;
                textBoxPrixProduit.Text = ligneA.prix.ToString();
                textBoxQteProduit.Text = ligneA.qte.ToString();

            }
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous vraiment enregistrez ces Informations ?"
                + "\nProduit : " + comboBoxProduit.Text
                + "\nPrix : " + textBoxPrixProduit.Text
                + "\nQuantité : " + textBoxQteProduit.Text
                + "\nMonatant : " + (Convert.ToDouble(textBoxPrixProduit.Text) * Convert.ToDouble(textBoxQteProduit.Text)).ToString()
                , operation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {


                if (operation == "Ajouter")
                {
                    SqlCommand command = new SqlCommand("insert into ligne values (" +
                        comboBoxidProduit.Text + "," +
                        ligneA.id_depense.ToString() + "," +
                        textBoxQteProduit.Text + "," +
                        textBoxPrixProduit.Text.Replace(",", ".") +
                        ")", DBHelper.connection);

                    command.ExecuteNonQuery();
                    command = null;
                }

                if (operation == "Modifier")
                {
                    SqlCommand command = new SqlCommand("update ligne set " +
                        "id_produit = " + comboBoxidProduit.Text + " , " +
                        "id_depense = " + ligneA.id_depense.ToString() + " , " +
                        "qte = " + textBoxQteProduit.Text + " , " +
                        "prix = " + textBoxPrixProduit.Text.Replace(",", ".") +
                        " where id_depense = " + ligneA.id_depense.ToString() + " and id_produit = " + ligneA.id_produit.ToString()

                        , DBHelper.connection);
                    command.ExecuteNonQuery();
                }
                this.Close();
            }
            if (result == DialogResult.No) this.Close();




        }



        private void comboBoxProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxidProduit.SelectedIndex = comboBoxProduit.SelectedIndex;
        }

        private void buttonAjouterProduit_Click(object sender, EventArgs e)
        {
            comboBoxidProduit.Items.Clear();
            comboBoxProduit.Items.Clear();
            FormAjouterProduit frm = new FormAjouterProduit();
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(this.Location.X + this.Width-20, this.Location.Y);
            
            frm.ShowDialog();

            comboBoxidProduit.Text = "";
            comboBoxProduit.Text = "";
            FormAjouterModifierFacture_Load(sender, e);
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous vraiment sortir sans sauvegarder les Informations ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) this.Close();
        }

        private void textBoxQteProduit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
                e.Handled = true;
        }

        private void textBoxPrixProduit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxPrixProduit.Text.Contains('.') && e.KeyChar == '.' && (e.KeyChar != (char)(Keys.Back)))
                e.Handled = true;

            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)) && e.KeyChar != '.')
                e.Handled = true;
        }
    }
}
