﻿using System;
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
            DialogResult result = MessageBox.Show("Voulez vous vraiment enregistrez ces Information ?" +
                "\nDesignation de l'Intervention : " + textBoxDesignationDepense.Text +
                "\nDate Debut de l'Intervention : " + dateTimePickerDebutIntervention.Value.ToShortDateString() +
                "\nDate Fin de l'Intervention : " + dateTimePickerFinIntervention.Value.ToShortDateString() +
                "\nMontant de l'Intervention : " + textBoxMontantIntervention.Text
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

                    string[] oldValues = null;
                    string[] newValues = { textBoxDesignationDepense.Text, dateTimePickerDebutIntervention.Text, dateTimePickerFinIntervention.Text, textBoxMontantIntervention.Text };
                    Helper.Log.makeLog(FormLogin.userId, DateTime.Now, "Ajouter", "Intervention", oldValues, newValues);

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

                }
                this.Close();
            }
            else if (result == DialogResult.No) this.Close();
        }

        private void dateTimePickerFinIntervention_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerFinIntervention.Value < dateTimePickerDebutIntervention.Value)
            {
                MessageBox.Show("la date de fin doit etre superieur de la date de debut !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerFinIntervention.Value = dateTimePickerDebutIntervention.Value;

            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous vraiment sortir sans sauvegarder les Information ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) this.Close();
        }
    }
}