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
    public partial class FormAjouterModifierRecette : Form
    {
        private int id_Proprietaire;
        private BindingSource bsProprietaire;
        private BindingSource bsProprietaireBien;
        private BindingSource bsEcheanceBien;
        private BindingSource bsTypeRecette;
        private string operation;
        private DataClassesSyndicDataContext SyndicDataContext = new DataClassesSyndicDataContext();

        public FormAjouterModifierRecette(int _id_Proprietaire = -1, string _operation = "")
        {
            InitializeComponent();
            id_Proprietaire = _id_Proprietaire;
            operation = _operation;
        }

        private void FormAjouterModifierRecette_Load(object sender, EventArgs e)
        {
            if (id_Proprietaire != -1 && operation.Equals("Ajouter"))
            {
                MessageBox.Show(id_Proprietaire.ToString());
                labelHead.Text = "Ajouter une Recette";
                DBHelper.remplir_dataset("select b.id,b.nom as BienNom,titre,im.nom as ImNom from bien b inner join immeuble im on im.id = b.id_immeuble where id_proprietaire = " + id_Proprietaire, "Bien_Prop");
                DBHelper.remplir_dataset("select * from type where idTableType in (select id from tabletype where libelle like 'echeance')", "typeEcheance");
                DBHelper.remplir_dataset("select * from type where idTableType in (select id from tabletype where libelle like 'recette')", "typeRecette");



                bsProprietaire = DBHelper.remplir_bindingsource("Proprietaire_Recette");
                bsProprietaireBien = DBHelper.remplir_bindingsource("Bien_Prop");
                bsEcheanceBien = DBHelper.remplir_bindingsource("typeEcheance");
                bsTypeRecette = DBHelper.remplir_bindingsource("typeRecette");


                DBHelper.remplir_ListControl(comboBoxNomBien, bsProprietaireBien, "BienNom", "id");
                DBHelper.remplir_ListControl(comboBoxTypeEcheance, bsEcheanceBien, "libelleType", "libelleType");
                DBHelper.remplir_ListControl(comboBoxTypeRecette, bsTypeRecette, "libelleType", "libelleType");
                DBHelper.remplir_ListControl(comboBoxNomProprietaire, bsProprietaire, "nom_complet", "id");

                comboBoxNomProprietaire.SelectedValue = id_Proprietaire;
                comboBoxNomProprietaire.Enabled = false;

                comboBoxTypeEcheance.SelectedValue = "Frais biens";
                comboBoxTypeEcheance.Enabled = false;



            }
        }


        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Les Données n'est pas Enregistrer , voulez vous vraiment Quitter ce Form ?", "Annulation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to Add this Informations ?"
                + "\nNumero de Recette : " + textBoxNumRecu.Text
                + "\nDate de Recette : " + dateTimePickerDateRecette.Value.ToString()
                + "\nMontant de Recette : " + textBoxMontant.Text
                + "\nType de Recette : " + comboBoxTypeRecette.SelectedValue.ToString()
                + "\nNom de Propriétaire : " + comboBoxNomProprietaire.Text.ToString(),
                "Verification",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button3
             );


            if ( result == DialogResult.Yes)
            {

                int id_Cotisation;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SyndicConnectionStringReda"].ConnectionString);
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string sql = "insert into cotisation(date_recette,montant,typeRecette,id_propietaire,numRecu) values ('"
                    + dateTimePickerDateRecette.Value.ToString() + "',"
                    + textBoxMontant.Text.Replace("'", "''") + ",'"
                    + comboBoxTypeRecette.SelectedValue.ToString() + "',"
                    + comboBoxNomProprietaire.SelectedValue.ToString() + ","
                    + textBoxNumRecu.Text + ")";
                SqlCommand com = new SqlCommand(sql, conn);
                com.ExecuteNonQuery();
                com = null;
                sql = "select max(id) from cotisation";
                com = new SqlCommand(sql, conn);

                id_Cotisation = Convert.ToInt32(com.ExecuteScalar());
                com = null;




                var src = from echeance
                          in SyndicDataContext.echeance
                          where echeance.id_bien.Equals(Convert.ToInt32(comboBoxNomBien.SelectedValue))
                          select echeance;

                decimal montantRecette = Convert.ToDecimal(textBoxMontant.Text);

                foreach (echeance ech in src)
                {

                    if (ech.montant_reçu < ech.montant || ech.montant_reçu == 0)
                    {
                        MessageBox.Show(ech.montant_reçu.ToString() + "-----" + ech.mois);

                        var updateEcheance = (from echeance1
                                             in SyndicDataContext.echeance
                                              where echeance1.id.Equals(Convert.ToInt32(ech.id))
                                              select echeance1).Single();

                        if (ech.montant_reçu > 0)
                        {
                            MessageBox.Show("Montant recu > 0");

                            if (ech.montant <= montantRecette + ech.montant_reçu)
                            {
                                MessageBox.Show("Montant recu <=  montantRecette + ech.montant_reçu ");


                                montantRecette += Convert.ToDecimal(updateEcheance.montant_reçu);
                                updateEcheance.montant_reçu = ech.montant;

                                montantRecette -= Convert.ToDecimal(ech.montant);



                            }
                            else if (ech.montant > montantRecette + ech.montant_reçu)
                            {
                                MessageBox.Show("Montant >  montantRecette + ech.montant_reçu ");

                                updateEcheance.montant_reçu += montantRecette;
                                montantRecette = 0;
                            }
                        }
                        if (ech.montant_reçu == 0)
                        {
                            MessageBox.Show("Montant recu == 0");

                            if (ech.montant <= montantRecette)
                            {
                                updateEcheance.montant_reçu = ech.montant;

                                montantRecette -= Convert.ToDecimal(ech.montant);

                            }
                            else if (ech.montant > montantRecette)
                            {
                                updateEcheance.montant_reçu = montantRecette;
                                montantRecette = 0;
                            }
                        }


                        SyndicDataContext.SubmitChanges();
                        sql = "insert into cotisation_echeance values (" + id_Cotisation.ToString() + "," + updateEcheance.id.ToString() + ")";
                        com = new SqlCommand(sql, conn);
                        com.ExecuteNonQuery();

                        com = null;
                        if (montantRecette == 0)
                            break;
                    }
                }
                conn.Close();
                SyndicDataContext.Dispose();
                DBHelper.syncroniser("cotisation");
                this.Close();

            }

            if (result == DialogResult.No)
                this.Close();
        }

    }
}
