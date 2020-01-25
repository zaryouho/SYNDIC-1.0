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
        private BindingSource bsTypeEcheance;
        private BindingSource bsBien;


        public FormAjouterModifierEcheance(BindingSource _bsBien = null)
        {
            InitializeComponent();
            bsBien = _bsBien;
        }


        private void FormAjouterModifierEcheance_Load(object sender, EventArgs e)
        {
            string query = "select * from type where idTableType in (select id from tabletype where libelle like 'echeance')";
            DBHelper.remplir_dataset(query, "Type");

            bsTypeEcheance = DBHelper.remplir_bindingsource("Type");


            DBHelper.remplir_ListControl(comboBoxTypeEcheance, bsTypeEcheance, "libelleType", "libelleType");
            bsTypeEcheance.Filter = "libelleType not like 'Frais biens'";

            DBHelper.remplir_ListControl(comboBoxBien, bsBien, "Nom Bien et Titre", "id");



        }

        private void labelCloseBiens_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
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

                this.Close();
            }
            else if (result == DialogResult.No)
                this.Close();



        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {

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
