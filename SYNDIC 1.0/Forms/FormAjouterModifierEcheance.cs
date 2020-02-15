using SYNDIC_1._0.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYNDIC_1._0
{
    public partial class FormAjouterModifierEcheance : Form
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


        private string operation;
        private BindingSource bsTypeEcheance;
        private BindingSource bsBien;
        private echeance echeanceModifier;

        public FormAjouterModifierEcheance(string _operation, BindingSource _bsBien = null, echeance _echeanceModifier = null)
        {
            InitializeComponent();
            bsBien = _bsBien;
            operation = _operation;
            echeanceModifier = _echeanceModifier;
        }


        private void FormAjouterModifierEcheance_Load(object sender, EventArgs e)
        {

            string query = "select * from type where idTableType in (select id from tabletype where libelle like 'echeance')";
            DBHelper.remplir_dataset(query, "TypeAddEcheance");

            bsTypeEcheance = DBHelper.remplir_bindingsource("TypeAddEcheance");


            DBHelper.remplir_ListControl(comboBoxTypeEcheance, bsTypeEcheance, "libelleType", "libelleType");
            bsTypeEcheance.Filter = "libelleType not like 'Frais biens'";

            DBHelper.remplir_ListControl(comboBoxBien, bsBien, "Nom Bien et Titre", "id");

            if (operation == "Modifier")
            {
                textBoxIdEchea.Text = echeanceModifier.id.ToString();
                textBoxMontant.Text = echeanceModifier.montant.ToString();
                textBoxMontantRecu.Text = echeanceModifier.montant_reçu.ToString();
                comboBoxBien.SelectedValue = echeanceModifier.id_bien;
                comboBoxTypeEcheance.SelectedValue = echeanceModifier.typeEchea;
            }


        }

        private void labelCloseBiens_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if(operation == "Ajouter") { 
                DialogResult result = MessageBox.Show("Voulez vous vraiment Ajouter cet Echeance ?"+
                    "Montant : " + textBoxMontant.Text +
                    "\nMontant Reçu :" + textBoxMontantRecu.Text +
                    "\nNom Bien : " + comboBoxBien.Text +
                    "\nType de Echeance :" + comboBoxTypeEcheance.Text,
                    "Information",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button3
                    );
                if (result == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SyndicConnectionStringReda"].ConnectionString);
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    string sql = "insert into echeance(montant,montant_reçu,typeEchea,id_bien) values ("
                                + textBoxMontant.Text + ","
                                + "0" + ",'"
                                + comboBoxTypeEcheance.SelectedValue.ToString().Replace("'","''") + "',"
                                + comboBoxBien.SelectedValue.ToString() + ")";
                    SqlCommand com = new SqlCommand(sql, conn);
                    com.ExecuteNonQuery();
                    com = null;

                    string[] oldValues = null;
                    string[] newValues = { textBoxMontant.Text, comboBoxTypeEcheance.SelectedValue.ToString(), comboBoxBien.SelectedValue.ToString() };

                    Helper.Log.makeLog(FormLogin.userId, DateTime.Now, "Ajouter", "Echeance", oldValues, newValues);
                    this.Close();
                }
                else if (result == DialogResult.No)
                    this.Close();

            }
            else
            {
                DialogResult result = MessageBox.Show("Voulez vous vraiment Modifier cet Echeance ?" +
                    "Montant : " + textBoxMontant.Text +
                    "\nMontant Reçu :" + textBoxMontantRecu.Text +
                    "\nNom Bien : " + comboBoxBien.Text +
                    "\nType de Echeance :" + comboBoxTypeEcheance.Text,
                    "Information",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button3
                    );
                if (result == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SyndicConnectionStringReda"].ConnectionString);
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    string sql =    " update echeance " +
                                    " set montant = " + textBoxMontant.Text.Replace(",",".") + "  ," +
                                    " montant_reçu = " + textBoxMontantRecu.Text.Replace(",", ".") + " ," +
                                    " id_bien = " + comboBoxBien.SelectedValue.ToString() +
                                    " , typeEchea = '" + comboBoxTypeEcheance.SelectedValue.ToString().Replace("'", "''") +"' "+
                                    " where id = " + textBoxIdEchea.Text;

                    SqlCommand com = new SqlCommand(sql, conn);
                    com.ExecuteNonQuery();
                    com = null;

                    this.Close();
                }
                else if (result == DialogResult.No)
                    this.Close();



            }

        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Les Données n'est pas Enregistrer , voulez vous vraiment Quitter ce Form ?", "Annulation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                labelCloseBiens_Click(sender, e);
        }

        private void buttonAddNewTypeEcheance_Click(object sender, EventArgs e)
        {
            new FormGestionTypes("echeance").ShowDialog();
            DBHelper.syncroniser("type");

            //bsTypeEcheance = DBHelper.remplir_bindingsource("typeEcheance");
            //DBHelper.remplir_ListControl(comboBoxTypeEcheance, bsTypeEcheance, "libelleType", "libelleType");


        }

        private void FormAjouterModifierEcheance_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
