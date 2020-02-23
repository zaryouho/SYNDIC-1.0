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

namespace SYNDIC_1._0.Forms
{
    public partial class FormRecetteProprietaire : Form
    {
        // Les Varuables Global
        private BindingSource bsProprietaire;
        private BindingSource bsRecette;
        private DataClassesSyndicDataContext SyndicDataContext = new DataClassesSyndicDataContext();

        public FormRecetteProprietaire()
        {
            InitializeComponent();
        }


        private void FormRecetteProprietaire_Load(object sender, EventArgs e)
        {
            comboBoxProprietaire.Focus();
            DBHelper.ouvrirConnection("SyndicConnectionStringReda");

            DBHelper.remplir_dataset("select nom + ' ' + prenom as Nom_Complet,id from proprietaire where id in (select distinct id_proprietaire from bien)", "Proprietaire_Recette");
            DBHelper.remplir_dataset("select * from cotisation where id_propietaire in (select distinct id_proprietaire from bien)", "cotisation");


            bsProprietaire = DBHelper.remplir_bindingsource("Proprietaire_Recette");
            bsRecette = DBHelper.remplir_bindingsource("Proprietaire_Recette", "id", "cotisation", "id_propietaire", bsProprietaire);

            DBHelper.remplir_ListControl(comboBoxProprietaire, bsProprietaire, "Nom_Complet", "id");
            DBHelper.remplir_Grille(dataGridViewRecette, bsRecette);

            dataGridViewRecette.Columns[0].Visible = false;
            dataGridViewRecette.Columns[5].Visible = false;
        }



        private void buttonFirst_Click(object sender, EventArgs e)
        {
            bsRecette.MoveFirst();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            bsRecette.MovePrevious();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            bsRecette.MoveNext();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            bsRecette.MoveLast();
        }

        private void buttonAjouterRecette_Click(object sender, EventArgs e)
        {
            int id_proprietaire = Convert.ToInt32(comboBoxProprietaire.SelectedValue);
            new FormAjouterModifierRecette(id_proprietaire, "Ajouter").ShowDialog();
            DBHelper.dataSet.Reset();

            FormRecetteProprietaire_Load(sender, e);
            comboBoxProprietaire.SelectedValue = id_proprietaire;
        }

        private void buttonSupprimerRecette_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Voulez vous supprimer cette Recette ?"
                + "\nNuméro de Recette : " + dataGridViewRecette.CurrentRow.Cells[6].Value.ToString()
                + "\nDate de Recette : " + dataGridViewRecette.CurrentRow.Cells[1].Value.ToString()
                + "\nMontant de Recette : " + dataGridViewRecette.CurrentRow.Cells[2].Value.ToString()
                + "\nType de Recette : " + dataGridViewRecette.CurrentRow.Cells[4].Value.ToString()
                + "\nNom de Propriétaire : " + comboBoxProprietaire.Text.ToString(),
                "Verification",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button3
             );
            if (result == DialogResult.Yes)
            {
                var echeances = from echeance in SyndicDataContext.echeances
                                join cotisation_echeance in SyndicDataContext.cotisation_echeances
                                on echeance.id equals cotisation_echeance.id_echeance
                                where cotisation_echeance.id_recette.Equals(Convert.ToInt32(dataGridViewRecette.CurrentRow.Cells[0].Value.ToString()))
                                orderby echeance.id descending
                                select echeance;

                decimal montant_recette = Convert.ToDecimal(dataGridViewRecette.CurrentRow.Cells[2].Value);
                int id_Recette = Convert.ToInt32(dataGridViewRecette.CurrentRow.Cells[0].Value);
                
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SyndicConnectionStringReda"].ConnectionString);
                
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                string sql;
                SqlCommand com;

                foreach (echeance ech in echeances)
                {
                    if (ech.montant_reçu - montant_recette >= 0)
                    {
                        ech.montant_reçu -= montant_recette;
                        montant_recette = 0;

                    }
                    else if (ech.montant_reçu - montant_recette < 0)
                    {
                        montant_recette -= Convert.ToDecimal(ech.montant_reçu);
                        ech.montant_reçu = 0;

                    }

                    SyndicDataContext.SubmitChanges();
                    
                    if (montant_recette == 0)
                        break;
                
                }

                sql = "delete from cotisation_echeance where id_recette = " + id_Recette.ToString();
                com = new SqlCommand(sql, conn);
                com.ExecuteNonQuery();
                com = null;

                bsRecette.RemoveCurrent();
                sql = "delete from cotisation where id = " + id_Recette.ToString();
                com = new SqlCommand(sql, conn);
                com.ExecuteNonQuery();

                com = null;
                conn.Close();

            }
        }

        private void buttonListDocs_Click(object sender, EventArgs e)
        {
            int current_Id = Convert.ToInt32(dataGridViewRecette.CurrentRow.Cells[0].Value.ToString());
            new FormGestionDocument("documentCotisation","where idRecette = "+current_Id.ToString(),current_Id).ShowDialog();
        }

        private void buttonImprimerRecette_Click(object sender, EventArgs e)
        {
            crystalR.Reçu recu = new crystalR.Reçu();
            recu.SetDatabaseLogon("sa", "123456");
            string filter = "{cotisation.id} = " + dataGridViewRecette.CurrentRow.Cells[0].Value.ToString();
            FormImpression imprimer = new FormImpression(recu, filter);
            imprimer.ShowDialog();
        }
    }
}
