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
using SYNDIC_1._0.Forms;
using SYNDIC_1._0.Helper;

namespace SYNDIC_1._0
{
    public partial class FormAjouterModifierIntervention : Form
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

        intervention intervention;
        string operation;
        BindingSource bsDepInter;
        string[] values = null;
        public FormAjouterModifierIntervention(string _operation, intervention _intervention)
        {

            InitializeComponent();
            intervention = _intervention;
            operation = _operation;

        }

        private void labelCloseDepense_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void visble(bool oper)
        {
            labelidDepense.Visible = oper;
            comboBoxIdDepense.Visible = oper;
        }

        private void FormAjouterModifierIntervention_Load(object sender, EventArgs e)
        {
            if (operation == "Ajouter")
            {
                dateTimePickerDebutIntervention.Value = DateTime.Now;
                dateTimePickerFinIntervention.Value = DateTime.Now;
                visble(false);

            }
            else
            {
                visble(true);
                textBoxDesignationDepense.Text = intervention.libelle;
                dateTimePickerDebutIntervention.Value = intervention.dateDebut.Value;
                dateTimePickerFinIntervention.Value = intervention.dateFin.Value;
                textBoxMontantIntervention.Text = intervention.montant.ToString();
                DBHelper.remplir_dataset("select id,designation from depense", "depenseAddInterv");
                bsDepInter = DBHelper.remplir_bindingsource("depenseAddInterv");
                DBHelper.remplir_ListControl(comboBoxIdDepense, bsDepInter, "designation", "id");

                comboBoxIdDepense.SelectedValue = intervention.id_depense;

            }
        }
        private void buttonValider_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous vraiment enregistrer ces informations ?" +
                "\nDésignation de l'intervention : " + textBoxDesignationDepense.Text +
                "\nDate de début de l'intervention : " + dateTimePickerDebutIntervention.Value.ToShortDateString() +
                "\nDate de fin de l'intervention : " + dateTimePickerFinIntervention.Value.ToShortDateString() +
                "\nMontant de l'intervention : " + textBoxMontantIntervention.Text
                , operation, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (operation == "Ajouter")
                {
                    string sql = "insert into intervention values ('"
                       + textBoxDesignationDepense.Text.Replace("'", "''") + "','"
                       + dateTimePickerDebutIntervention.Value.ToShortDateString() + "'," +
                       "'" + dateTimePickerFinIntervention.Value.ToShortDateString() + "'," +
                       textBoxMontantIntervention.Text + "," + intervention.id_depense + ")";

                    SqlCommand com = new SqlCommand(sql, DBHelper.connection);
                    com.ExecuteNonQuery();
                    com = null;

                    string[] oldValues = { "",""};
                    string[] newValues = { textBoxDesignationDepense.Text, dateTimePickerDebutIntervention.Text, dateTimePickerFinIntervention.Text, textBoxMontantIntervention.Text };
                    Helper.Log.makeLog(FormLogin.userId, DateTime.Now, "Ajouter", "Intervention", oldValues, newValues);
                    values = newValues;

                }
                else
                {
                    string sql = "update intervention set "
                       + "libelle = '" + textBoxDesignationDepense.Text.Replace("'", "''") + "' ," +
                       "dateDebut = '" + dateTimePickerDebutIntervention.Value.ToShortDateString() + "' ," +
                       "dateFin = '" + dateTimePickerFinIntervention.Value.ToShortDateString() + "'," +
                       "montant = " + textBoxMontantIntervention.Text.Replace(",", ".") + "," +
                       "id_depense = " + comboBoxIdDepense.SelectedValue +
                       " where id = " + intervention.id;

                    SqlCommand com = new SqlCommand(sql, DBHelper.connection);
                    com.ExecuteNonQuery();
                    com = null;
                    string[] oldValues = values;
                    string[] newValues = { textBoxDesignationDepense.Text.Replace("'", "''") , dateTimePickerDebutIntervention.Value.ToShortDateString() ,
                    dateTimePickerFinIntervention.Value.ToShortDateString(),textBoxMontantIntervention.Text.Replace(",", "."),
                    comboBoxIdDepense.SelectedValue.ToString()};
                    Log.makeLog(FormLogin.userId, DateTime.Now, "Modifier", "Intervention", oldValues, newValues);

                }
                this.Close();
            }
            else if (result == DialogResult.No) this.Close();
        }

        private void dateTimePickerFinIntervention_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerFinIntervention.Value < dateTimePickerDebutIntervention.Value)
            {
                MessageBox.Show("La date de fin doit être supérieur de la date de début !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerFinIntervention.Value = dateTimePickerDebutIntervention.Value;

            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous vraiment sortir sans sauvegarder ces informations ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) this.Close();
        }

        private void textBoxMontantIntervention_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxMontantIntervention.Text.Contains('.') && e.KeyChar == '.' && (e.KeyChar != (char)(Keys.Back)))
                e.Handled = true;

            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void textBoxDesignationDepense_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)(Keys.Back))&&(e.KeyChar != (char)(Keys.Space)))
                e.Handled = true;
        }
    }
}
