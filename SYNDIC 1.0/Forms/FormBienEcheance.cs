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
    public partial class FormBienEcheance : Form
    {
        //les variable globale
        private BindingSource bsBien;
        private BindingSource bsBloc;
        private BindingSource bsImmeuble;
        private BindingSource bsEcheance;
        private BindingSource bsTypeEcheance;
        //private DataClassesSyndicDataContext syndicDataContext;

        public FormBienEcheance()
        {
            InitializeComponent();
        }

        private void FormBienEcheance_Load(object sender, EventArgs e)
        {
            comboBoxBloc.Focus();
            DBHelper.ouvrirConnection("SyndicConnectionStringReda");

            DBHelper.remplir_dataset("select * from bloc", "bloc");
            DBHelper.remplir_dataset("select * from immeuble ", "immeuble");


            DBHelper.remplir_dataset("select id, nom +" + "' - '" + "+titre as [Nom Bien et Titre],id_Immeuble from bien", "bien_Echeance");
            DBHelper.remplir_dataset("select * from Echeance order by id_bien,annee,mois", "Echeance");
            DBHelper.remplir_dataset("select * from type where idTableType in (select id from tabletype where libelle like 'echeance')", "typeEcheance");


            bsBloc = DBHelper.remplir_bindingsource("bloc");
            bsImmeuble = DBHelper.remplir_bindingsource("bloc", "id", "immeuble", "id_bloc", bsBloc);
            
            DBHelper.remplir_ListControl(comboBoxBloc, bsBloc, "nomBloc", "id");
            DBHelper.remplir_ListControl(comboBoxImmeuble, bsImmeuble, "nom", "id");

            bsBien = DBHelper.remplir_bindingsource("immeuble", "id", "bien_Echeance", "id_Immeuble", bsImmeuble);
            DBHelper.remplir_Grille(dataGridViewListeBien, bsBien);
            dataGridViewListeBien.Columns[0].Visible = false;
            dataGridViewListeBien.Columns[2].Visible = false;


            bsEcheance = DBHelper.remplir_bindingsource("bien_Echeance", "id", "Echeance", "id_bien", bsBien);
            DBHelper.remplir_Grille(dataGridViewBienEcheance, bsEcheance);
            dataGridViewBienEcheance.Columns[0].Visible = false;
            dataGridViewBienEcheance.Columns[5].Visible = false;


            bsTypeEcheance = DBHelper.remplir_bindingsource("typeEcheance");
            DBHelper.remplir_ListControl(comboBoxTypeEcheance, bsTypeEcheance, "libelleType", "libelleType");

            comboBoxTypeEcheance.SelectedValue = "Touts";
            comboBoxBienEcheance.DisplayMember = "id";
            comboBoxBienEcheance.ValueMember = "id";
            comboBoxBienEcheance.DataSource = bsBien;


            comboBoxTypeEcheance.SelectedValue = "Frais biens";
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            bsBien.MoveFirst();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            bsBien.MoveLast();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            bsBien.MoveNext();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            bsBien.MovePrevious();
        }

        private void comboBoxTypeEcheance_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = comboBoxTypeEcheance.Text;

            if (filter.Equals("Touts"))
                filter = "";
            
            bsEcheance.Filter = "TypeEchea like '%" + filter.Replace("'", "''") + "%'";
            if (filter.Equals("Frais biens"))
            {
                buttonSupprimerEcheance.Enabled = false;
                buttonModifierEcheance.Enabled = false;
                filter = null;
                panelMontantEcheance.Visible = true;
                dataGridViewBienEcheance.Columns[1].Visible = true;
                dataGridViewBienEcheance.Columns[2].Visible = true;
                return;
            }
            buttonSupprimerEcheance.Enabled = true;
            buttonModifierEcheance.Enabled = true;
            panelMontantEcheance.Visible = false ;
            dataGridViewBienEcheance.Columns[1].Visible = false;
            dataGridViewBienEcheance.Columns[2].Visible = false;
            filter = null;
        }

        private void dataGridViewBienEcheance_SelectionChanged(object sender, EventArgs e)
        {
             /*double montantTotal = 0, montantRecu = 0;
             foreach(DataGridViewRow row in dataGridViewBienEcheance.Rows)
                  montantRecu += Convert.ToDouble(row.Cells[4].Value.ToString());


             montantTotal = Convert.ToDouble(dataGridViewBienEcheance.Rows[0].Cells[3].Value)*12;

            
             if (dataGridViewBienEcheance.Rows.Count > 0)
             {
                 textBoxMontantTotal.Text = montantTotal.ToString();
                 textBoxMontantRecu.Text = montantRecu.ToString();
                 textBoxMontantReste.Text = (montantTotal - montantRecu).ToString();
             }*/
            /* double montantTotal = 0, montantRecu = 0;

             SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["SyndicConnectionString"].ConnectionString);
             if(sqlConnection.State != ConnectionState.Open)
                 sqlConnection.Open();
             MessageBox.Show(dataGridViewListeBien.CurrentRow.Cells[0].Value.ToString());
             string sql = "select sum(montant_reçu) as total from echeance where id_bien = " + dataGridViewListeBien.CurrentRow.Cells[0].Value.ToString()+" group by id_bien";
             SqlCommand com = new SqlCommand(sql, sqlConnection);
             SqlDataReader dr = com.ExecuteReader();
             dr.Read();
             montantRecu = Convert.ToDouble(dr["total"].ToString());
             dr.Close();
             dr = null;
             com = null;

            
             textBoxMontantTotal.Text = montantTotal.ToString();
             textBoxMontantRecu.Text = montantRecu.ToString();
             textBoxMontantReste.Text = (montantTotal - montantRecu).ToString();
            */
             



        }

        

        private void comboBoxBienEcheance_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                double montantTotal = 0, montantRecu = 0;

                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["SyndicConnectionStringReda"].ConnectionString);
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();

                string sql = "select sum(montant_reçu) as total_Recu , sum(montant) as total from echeance where id_bien = " + comboBoxBienEcheance.SelectedValue.ToString() + " group by id_bien";

                SqlCommand com = new SqlCommand(sql, sqlConnection);
                SqlDataReader dr = com.ExecuteReader();

                dr.Read();
                montantRecu = Convert.ToDouble(dr["total_Recu"].ToString());
                montantTotal = Convert.ToDouble(dr["total"].ToString());
                dr.Close();

                dr = null;
                com = null;


                textBoxMontantTotal.Text = montantTotal.ToString();
                textBoxMontantRecu.Text = montantRecu.ToString();
                textBoxMontantReste.Text = (montantTotal - montantRecu).ToString();
            }
            catch(Exception) { }
        }

        private void buttonAjouterEcheance_Click(object sender, EventArgs e)
        {
            new FormAjouterModifierEcheance("Ajouter",bsBien).ShowDialog();
            DBHelper.dataSet.Reset();

            FormBienEcheance_Load(sender, e);
            
        }

        private void buttonSupprimerEcheance_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous vraiment Ajouter cet Echeance ?"+
                "Montant : " + dataGridViewBienEcheance.CurrentRow.Cells[3].Value.ToString() +
                "\nMontant Reçu :" + dataGridViewBienEcheance.CurrentRow.Cells[4].Value.ToString() +
                "\nNom Bien : " + dataGridViewListeBien.CurrentRow.Cells[1].Value.ToString() +
                "\nType de Echeance :" + dataGridViewBienEcheance.CurrentRow.Cells[5].Value.ToString(),
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
                );
            if (result == DialogResult.Yes)
            {
                bsEcheance.RemoveCurrent();
                DBHelper.syncroniser("Echeance");
            }
        }

        private void FormBienEcheance_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void buttonModifierEcheance_Click(object sender, EventArgs e)
        {
            echeance echeance = new echeance();
            
            echeance.id = Convert.ToInt32(dataGridViewBienEcheance.CurrentRow.Cells[0].Value.ToString());
            echeance.montant = Convert.ToDecimal(dataGridViewBienEcheance.CurrentRow.Cells[3].Value.ToString());
            echeance.montant_reçu = Convert.ToDecimal(dataGridViewBienEcheance.CurrentRow.Cells[4].Value.ToString());
            echeance.id_bien = Convert.ToInt32(dataGridViewBienEcheance.CurrentRow.Cells[5].Value.ToString());
            echeance.typeEchea = dataGridViewBienEcheance.CurrentRow.Cells[6].Value.ToString();
            
            new FormAjouterModifierEcheance("Modifier",bsBien,echeance).ShowDialog();
            DBHelper.dataSet.Reset();

            FormBienEcheance_Load(sender, e);
        }

        private void dataGridViewBienEcheance_DoubleClick(object sender, EventArgs e)
        {
            if(comboBoxTypeEcheance.SelectedValue.ToString() != "Frais biens")
                buttonModifierEcheance_Click(sender, e);
        }

        private void comboBoxBloc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}