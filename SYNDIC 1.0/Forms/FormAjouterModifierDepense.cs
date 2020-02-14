using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace SYNDIC_1._0
{
    public partial class FormAjouterModifierDepense : Form
    {
        private BindingSource bsEmploye;
        private BindingSource bsSociete;
        private BindingSource bstype;
       // BindingSource bsdepense;
        private string button;
        private depense depenseModifier;
        
        public FormAjouterModifierDepense(string _button,depense _depenseModifier=null)
        {

            InitializeComponent();
            button = _button;
            depenseModifier = _depenseModifier;
            //bsdepense = _bsdepense;
        }

        private void FormAjouterModifierDepense_Load(object sender, EventArgs e)
        {
            DBHelper.ouvrirConnection("SyndicConnectionStringReda");

            // Remplissage de ComboBox avec les employées
            DBHelper.remplir_dataset("select nom + ' '+ prenom as nameCom,id from employe", "employeDepense");
            bsEmploye = DBHelper.remplir_bindingsource("employeDepense");
            DBHelper.remplir_ListControl(comboBoxEmploye, bsEmploye, "nameCom", "id");

            // Remplissage de ComboBox avec les Sociétés
            DBHelper.remplir_dataset("select raison_sociale,id from societe", "societeDepense");
            bsSociete = DBHelper.remplir_bindingsource("societeDepense");
            DBHelper.remplir_ListControl(comboBoxSociete, bsSociete, "raison_sociale", "id");

            // Remplissage de ComboBox avec les types de dépenses
            string sql = "select * from type where idTableType in (select id from tabletype where libelle like 'depense')";
            DBHelper.remplir_dataset(sql, "typeDepense");
            bstype = DBHelper.remplir_bindingsource("typeDepense");
            DBHelper.remplir_ListControl(comboBoxTypeDepense, bstype, "libelleType", "libelleType");

            //SqlCommand sqlCommandDepense = new SqlCommand("select distinct typeDepense from depense", DBHelper.cn);
            //SqlDataReader sqlDataReaderDepense = sqlCommandDepense.ExecuteReader();
            //while (sqlDataReaderDepense.Read())
            //{
            //    comboBoxTypeDepense.Items.Add(sqlDataReaderDepense["typeDepense"]);
            //}
            if (button == "Ajouter")
            {
                comboBoxEmploye.SelectedIndex = -1;
                comboBoxSociete.SelectedIndex = -1;
                comboBoxTypeDepense.SelectedIndex = 0;
                dateTimePickerDepense.Value = DateTime.Today;
            }
            else if (button == "Modifier")
            {
                //textBoxDesignationDepense.DataBindings.Add("text", bsdepense, "designation");
                //dateTimePickerDepense.DataBindings.Add("value", bsdepense, "date_depense");
                //textBoxMontant.DataBindings.Add("text", bsdepense, "montant");

                //comboBoxEmploye.DataBindings.Add("selectedvalue", bsdepense, "id_employe");
                //comboBoxSociete.DataBindings.Add("selectedvalue", bsdepense, "id_entreprise");
                //comboBoxTypeDepense.DataBindings.Add("selectedvalue", bsdepense, "typeDepense");


                //textBoxNumDocument.DataBindings.Add("text", bsdepense, "numDocument");
                //textBoxTypeDocument.DataBindings.Add("text", bsdepense, "typeDocument");
                textBoxDesignationDepense.Text = depenseModifier.designation;
                textBoxMontant.Text = depenseModifier.montant.ToString();
                if (depenseModifier.numDocument != null)
                    textBoxNumDocument.Text = depenseModifier.numDocument.ToString();
                if(depenseModifier.typeDocument !=null)
                    textBoxTypeDocument.Text = depenseModifier.typeDocument;

                dateTimePickerDepense.Value = depenseModifier.date_depense.Value;
                if (depenseModifier.id_employe != null)
                    comboBoxEmploye.SelectedValue = depenseModifier.id_employe;
                else
                    comboBoxEmploye.SelectedIndex = -1;
                if (depenseModifier.id_entreprise != null)
                    comboBoxSociete.SelectedValue = depenseModifier.id_entreprise;
                else
                    comboBoxSociete.SelectedIndex = -1;

                comboBoxTypeDepense.SelectedValue = depenseModifier.typeDepense;
            }

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous vraiment Enregistrez ces Information ?\n" +
                "Designation : " + textBoxDesignationDepense.Text + "\n" +
                "Date de Depense : "+ dateTimePickerDepense.Text + "\n" +
                "Montant : "+ textBoxMontant.Text
                , "Information",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string soc, emp;
                if (button == "Ajouter")
                {
                    if (comboBoxSociete.Text == "")
                        soc = "null";
                    else
                        soc = comboBoxSociete.SelectedValue.ToString();

                    if (comboBoxEmploye.Text == "")
                        emp = "null";
                    else
                        emp = comboBoxEmploye.SelectedValue.ToString();

                    string sql = "insert into depense values ('"
                        + textBoxDesignationDepense.Text.Replace("'", "''") + "','"
                        + dateTimePickerDepense.Text + "'," + textBoxMontant.Text + "," + emp + ","
                        + soc + ",'" + comboBoxTypeDepense.Text + "'," + textBoxNumDocument.Text + ",'" + textBoxTypeDocument.Text + "')";

                    SqlCommand com = new SqlCommand(sql, DBHelper.connection);
                    com.ExecuteNonQuery();
                    com = null;

                }
                else
                {

                    if (comboBoxSociete.Text == "")
                        soc = "null";
                    else
                        soc = comboBoxSociete.SelectedValue.ToString();

                    if (comboBoxEmploye.Text == "")
                        emp = "null";
                    else
                        emp = comboBoxEmploye.SelectedValue.ToString();

                    string sql = "update depense "+
                        "set designation = '" + textBoxDesignationDepense.Text.Replace("'", "''") + "' ," +
                        " date_depense = '"+ dateTimePickerDepense.Text + "' ," +
                        " montant = " + textBoxMontant.Text.Replace(",",".") + " , " +
                        " id_employe = " + emp + " ," +
                        " id_entreprise = " + soc + " ," +
                        " typeDepense = '" + comboBoxTypeDepense.Text + "' ," +
                        " numDocument = " + textBoxNumDocument.Text + " ," +
                        " typeDocument = '" + textBoxTypeDocument.Text.Replace("'","''") + "' " +
                        " where id = "+depenseModifier.id;

                    SqlCommand com = new SqlCommand(sql, DBHelper.connection);
                    com.ExecuteNonQuery();
                    com = null;
                }

                this.Close();
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelCloseDepense_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxDesignationDepense_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)) && (e.KeyChar !=(char)(Keys.Space)))
                e.Handled = true;
        }

        private void textBoxMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxMontant.Text.Contains('.') && e.KeyChar == '.')
                e.Handled = true;

            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void textBoxNumDocument_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)(Keys.Back)))
                e.Handled = true;
        }

        private void textBoxMontant_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDesignationDepense.Text != "" && textBoxMontant.Text != "")
                buttonValider.Enabled = true;
            else
                buttonValider.Enabled = false;
        }
    }
}
