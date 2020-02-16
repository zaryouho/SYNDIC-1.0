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
    public partial class FormDepenses : Form
    {
        // les Variables Global
        private BindingSource bsDepense, bsDepenseRemarque, bsDepenseDocuments;
        string button = "";

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            bsDepense.MoveFirst();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            bsDepense.MoveLast();
        }

        private void comboBoxTypeDepense_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string filter = comboBoxTypeDepense.Text;
            //if (filter == "Touts")
            //    filter = "";
            //bsDepense.Filter = string.Format("typeDepense like '%" + filter + "%'");
            comboBoxids_SelectedIndexChanged(sender, e);
        }

        private void radioButtonEmploye_CheckedChanged(object sender, EventArgs e)
        {



            comboBoxQui.Items.Clear();
            comboBoxQui.Text = "";


            comboBoxids.Items.Clear();
            comboBoxids.Text = "";



            if (radioButtonSociete.Checked)
            {
                SqlCommand sqlCommandSociete = new SqlCommand("select nom,id from societe", DBHelper.connection);
                SqlDataReader sqlDataReaderSociete = sqlCommandSociete.ExecuteReader();

                while (sqlDataReaderSociete.Read())
                {
                    comboBoxQui.Items.Add(sqlDataReaderSociete["nom"]);
                    comboBoxids.Items.Add(sqlDataReaderSociete["id"]);
                }
                sqlCommandSociete = null;
                sqlDataReaderSociete.Close();
            }

            else if (radioButtonEmploye.Checked)
            {


                SqlCommand sqlCommandEmploye = new SqlCommand("select CONCAT(nom,' ',prenom) as nom,id from employe", DBHelper.connection);
                SqlDataReader sqlDataReaderEmploye = sqlCommandEmploye.ExecuteReader();
                while (sqlDataReaderEmploye.Read())
                {
                    comboBoxQui.Items.Add(sqlDataReaderEmploye["nom"]);
                    comboBoxids.Items.Add(sqlDataReaderEmploye["id"]);


                }
                sqlCommandEmploye = null;
                sqlDataReaderEmploye.Close();
            }
            else if (radioButtonAutre.Checked)
            {
                bsDepense.Filter = "id_entreprise = null and id_employe = null";
            }
            else if (radioButtonALL.Checked)
            {

                //bsDepense.Filter = "";
                comboBoxQui.Items.Clear();
                comboBoxQui.Text = "";


                comboBoxids.Items.Clear();
                comboBoxids.Text = "";
            }

            if (comboBoxQui.Items.Count > 0)
                comboBoxQui.SelectedIndex = 0;

            comboBoxids_SelectedIndexChanged(sender, e);
        }

        private void buttonAjouterDepense_Click(object sender, EventArgs e)
        {
            button = "Ajouter";
            new FormAjouterModifierDepense(button).ShowDialog();
            DBHelper.dataSet.Reset();

            FormDepenses_Load(sender, e);
        }

        private void buttonAfficherInterventions_Click(object sender, EventArgs e)
        {
            if (dataGridViewDepenses.CurrentRow == null)
            {
                MessageBox.Show("Séléctioner une dépense d'abord !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            new FormInterventions(Convert.ToInt32(dataGridViewDepenses.CurrentRow.Cells[0].Value.ToString())).ShowDialog();

        }

        private void labelCloseDepense_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModifierDepense_Click(object sender, EventArgs e)
        {
            button = "Modifier";
            depense depenseModifier = new depense();

            if (dataGridViewDepenses.CurrentRow.Cells[4].Value.ToString() != "")
                depenseModifier.id_employe = Convert.ToInt32(dataGridViewDepenses.CurrentRow.Cells[4].Value.ToString());

            if (dataGridViewDepenses.CurrentRow.Cells[5].Value.ToString() != "")
                depenseModifier.id_entreprise = Convert.ToInt32(dataGridViewDepenses.CurrentRow.Cells[5].Value.ToString());


            depenseModifier.id = Convert.ToInt32(dataGridViewDepenses.CurrentRow.Cells[0].Value.ToString());
            depenseModifier.designation = dataGridViewDepenses.CurrentRow.Cells[1].Value.ToString();
            depenseModifier.date_depense = Convert.ToDateTime(dataGridViewDepenses.CurrentRow.Cells[2].Value.ToString());
            depenseModifier.montant = Convert.ToDecimal(dataGridViewDepenses.CurrentRow.Cells[3].Value.ToString());
            depenseModifier.typeDepense = dataGridViewDepenses.CurrentRow.Cells[6].Value.ToString();

            if (dataGridViewDepenses.CurrentRow.Cells[7].Value.ToString() != "")
                depenseModifier.numDocument = Convert.ToInt32(dataGridViewDepenses.CurrentRow.Cells[7].Value.ToString());
            if (dataGridViewDepenses.CurrentRow.Cells[8].Value.ToString() != "")
                depenseModifier.typeDocument = dataGridViewDepenses.CurrentRow.Cells[8].Value.ToString();


            new FormAjouterModifierDepense(button, depenseModifier).ShowDialog();
            DBHelper.dataSet.Reset();

            FormDepenses_Load(sender, e);


        }

        private void comboBoxQui_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxQui.SelectedIndex != -1)
                comboBoxids.SelectedIndex = comboBoxQui.SelectedIndex;
        }

        private void comboBoxids_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = comboBoxTypeDepense.Text;
            if (filter == "Touts")
                filter = "";

            if (radioButtonEmploye.Checked)
                bsDepense.Filter = string.Format("id_employe = " + comboBoxids.Text + " and typeDepense like '%" + filter + "%'");

            else if (radioButtonSociete.Checked)
                bsDepense.Filter = string.Format("id_entreprise = " + comboBoxids.Text + " and typeDepense like '%" + filter + "%'");

            else if (radioButtonALL.Checked)
            {
                bsDepense.Filter = string.Format("typeDepense like '%" + filter + "%'");
            }


        }

        private void buttonAfficherFactures_Click(object sender, EventArgs e)
        {
            if (dataGridViewDepenses.CurrentRow == null)
            {
                MessageBox.Show("Selectioner une dépense d'abord !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            new FormFacture(Convert.ToInt32(dataGridViewDepenses.CurrentRow.Cells[0].Value.ToString())).ShowDialog();

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            bsDepense.MoveNext();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            bsDepense.MovePrevious();
        }

        public FormDepenses()
        {
            InitializeComponent();
        }

        public void RemplirDataGridViewDepenses()
        {
            // bsDepense = DBHelper.remplir_bindingsource("depense","id","intervention","id_depense", bsDepense);
            DBHelper.remplir_Grille(dataGridViewDepenses, bsDepense);
            dataGridViewDepenses.Columns[0].Visible = false;
            dataGridViewDepenses.Columns[4].Visible = false;
            dataGridViewDepenses.Columns[5].Visible = false;
            dataGridViewDepenses.Columns[7].Visible = false;
            dataGridViewDepenses.Columns[8].Visible = false;
        }

        private void FormDepenses_Load(object sender, EventArgs e)
        {
            DBHelper.ouvrirConnection("SyndicConnectionStringReda");
            DBHelper.remplir_dataset("select * from depense", "depense");
            DBHelper.remplir_dataset("select * from remarqueDepnse", "remarqueDepnse");
            DBHelper.remplir_dataset("select * from documentDepense", "documentDepense");



            bsDepense = DBHelper.remplir_bindingsource("depense");

            bsDepenseRemarque = DBHelper.remplir_bindingsource("depense", "id", "remarqueDepnse", "id_depense", bsDepense);
            bsDepenseDocuments = DBHelper.remplir_bindingsource("depense", "id", "documentDepense", "id_depense", bsDepense);

            RemplirDataGridViewDepenses();
            dataGridViewDepenses.Rows[0].Selected = true;

            //DBHelper.cn.Open();
            DBHelper.ouvrirConnection("SyndicConnectionStringReda");
            SqlCommand sqlCommandDepense = new SqlCommand("select distinct typeDepense from depense", DBHelper.connection);

            SqlDataReader sqlDataReaderDepense = sqlCommandDepense.ExecuteReader();

            while (sqlDataReaderDepense.Read())
            {
                comboBoxTypeDepense.Items.Add(sqlDataReaderDepense["typeDepense"]);
            }
            comboBoxTypeDepense.Items.Add("Touts");
            sqlDataReaderDepense.Close();
            sqlCommandDepense = null;

            radioButtonALL.Checked = true;

            comboBoxTypeDepense.Text = "Touts";


        }
    }
}
