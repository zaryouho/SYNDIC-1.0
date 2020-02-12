using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SYNDIC_1._0.Forms
{
    public partial class FormAjouterModifierRecette : Form
    {
        private int id_Proprietaire;
        private BindingSource bsProprietaire;
        private BindingSource bsProprietaireBien;
        private BindingSource bsEcheanceBien;
        private BindingSource bsTypeRecette;
        private BindingSource bsEcheanceCotisation;
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
                DBHelper.remplir_dataset("select b.id,b.nom + ' ' + b.titre as BienNom,im.nom as ImNom from bien b inner join immeuble im on im.id = b.id_immeuble where id_proprietaire = " + id_Proprietaire.ToString(), "Bien_Prop");
                DBHelper.remplir_dataset("select * from type where idTableType in (select id from tabletype where libelle like 'echeance')", "typeEcheance");
                DBHelper.remplir_dataset("select * from type where idTableType in (select id from tabletype where libelle like 'recette')", "typeRecette");
                DBHelper.remplir_dataset("select e.id,e.montant,e.typeEchea,e.montant - e.montant_reçu as reste, e.id_bien, e.annee from echeance e inner join bien b on b.id = e.id_bien where b.id_proprietaire = " + id_Proprietaire.ToString() + " and e.typeEchea not like 'Frais biens' and e.montant>e.montant_reçu", "echeanceCotisation");

                bsProprietaire = DBHelper.remplir_bindingsource("Proprietaire_Recette");
                bsProprietaireBien = DBHelper.remplir_bindingsource("Bien_Prop");
                bsEcheanceBien = DBHelper.remplir_bindingsource("typeEcheance");
                bsTypeRecette = DBHelper.remplir_bindingsource("typeRecette");
                bsEcheanceCotisation = DBHelper.remplir_bindingsource("echeanceCotisation");

                DBHelper.remplir_ListControl(comboBoxNomBien, bsProprietaireBien, "BienNom", "id");
                DBHelper.remplir_ListControl(comboBoxTypeEcheance, bsEcheanceBien, "libelleType", "libelleType");
                DBHelper.remplir_ListControl(comboBoxTypeRecette, bsTypeRecette, "libelleType", "libelleType");
                DBHelper.remplir_ListControl(comboBoxNomProprietaire, bsProprietaire, "nom_complet", "id");
                DBHelper.remplir_Grille(dataGridViewListEcheance, bsEcheanceCotisation);

                comboBoxNomProprietaire.SelectedValue = id_Proprietaire;
                comboBoxNomProprietaire.Enabled = false;

                comboBoxTypeEcheance.SelectedValue = "Frais biens";

                dataGridViewListEcheance.Columns[0].Visible = false;
            }
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

            if (result == DialogResult.Yes)
            {
                int id_Cotisation;
                decimal montantRecette = Convert.ToDecimal(textBoxMontant.Text);

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SyndicConnectionStringReda"].ConnectionString);
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand com;
                string sql = "insert into cotisation(date_recette,montant,typeRecette,id_propietaire,numRecu) values ('"
                    + dateTimePickerDateRecette.Value.ToString() + "',"
                    + textBoxMontant.Text.Replace("'", "''") + ",'"
                    + comboBoxTypeRecette.SelectedValue.ToString() + "',"
                    + comboBoxNomProprietaire.SelectedValue.ToString() + ","
                    + textBoxNumRecu.Text + ")";

                com = new SqlCommand(sql, conn);
                com.ExecuteNonQuery();
                com = null;
                sql = "select max(id) from cotisation";
                com = new SqlCommand(sql, conn);

                id_Cotisation = Convert.ToInt32(com.ExecuteScalar());
                com = null;

                if (comboBoxTypeEcheance.Text == "Frais biens")
                {
                    var src = from echeance
                              in SyndicDataContext.echeances
                              where echeance.id_bien.Equals(Convert.ToInt32(comboBoxNomBien.SelectedValue))
                              select echeance;

                    foreach (echeance ech in src)
                    {
                        if (ech.montant_reçu < ech.montant || ech.montant_reçu == 0)
                        {
                            MessageBox.Show(ech.montant_reçu.ToString() + "-----" + ech.mois);

                            var updateEcheance = (from echeance1
                                                 in SyndicDataContext.echeances
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
                    DBHelper.syncroniser(nameof(cotisation));
                    this.Close();
                }
                else
                {
                    try
                    {
                        var echeance1 = (from echeance
                                         in SyndicDataContext.echeances
                                         where echeance.id.Equals(Convert.ToInt32(dataGridViewListEcheance.CurrentRow.Cells[0].Value.ToString()))
                                         select echeance).Single();

                        if (echeance1.montant_reçu + montantRecette > echeance1.montant)
                            throw new Exception("Le Montant de Recette est superieur de le Montant d'Echeance s'il vous plaît modifier le monatnt de Recette");

                        echeance1.montant_reçu += montantRecette;

                        SyndicDataContext.SubmitChanges();

                        sql = "insert into cotisation_echeance values (" + id_Cotisation.ToString() + "," + dataGridViewListEcheance.CurrentRow.Cells[0].Value.ToString() + ")";
                        using (com = new SqlCommand(sql, conn))
                        {
                            com.ExecuteNonQuery();
                            DBHelper.syncroniser(nameof(cotisation));
                            this.Close();
                        }
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            if (result == DialogResult.No)
                this.Close();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Les Données n'est pas Enregistrer , voulez vous vraiment Quitter ce Form ?", "Annulation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void comboBoxIdEcheance_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBoxTypeEcheance.SelectedValue.Equals( "Frais biens"))
            //{
            //    panelIdEcheance.Visible = false;
            //    return;
            //}
            //panelIdEcheance.Visible = true;
        }

        private void comboBoxTypeEcheance_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTypeEcheance.SelectedValue.Equals("Frais biens"))
                {
                    panelIdEcheance.Visible = false;
                    return;
                }
                panelIdEcheance.Visible = true;
            }
            catch (Exception )
            {
                throw;
            }
        }

        private void comboBoxNomBien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bsEcheanceCotisation.Filter = "id_bien = " + comboBoxNomBien.SelectedValue.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void buttonAddNewTypeEcheance_Click(object sender, EventArgs e)
        {
            using (var formGestionTypes = new FormGestionTypes(nameof(echeance)))
            {
                formGestionTypes.ShowDialog();
                DBHelper.syncroniser("type");
            }
        }

        private void buttonAjouterDocument_Click(object sender, EventArgs e)
        {
            /*SaveFileDialog save = new SaveFileDialog();
            save.Title = "Saving File";
            save.Filter = "Pdf Files| *.pdf";
            if(save.ShowDialog() == DialogResult.OK)
            {
                string fileName = save.FileName;
            }*/
        }
    }
}