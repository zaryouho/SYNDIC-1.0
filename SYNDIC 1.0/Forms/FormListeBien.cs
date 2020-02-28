using SYNDIC_1._0.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SYNDIC_1._0.Forms;

namespace SYNDIC_1._0
{
    public partial class FormListeBien : Form
    {
        // les Variables Global
        private BindingSource bsBien;
        private BindingSource bsBloc;
        private BindingSource bsImmeuble;
      

        public FormListeBien()
        {
            InitializeComponent();
        }

       
        public void RemplirDataGridViewBiens()
        {
            bsBien = DBHelper.remplir_bindingsource("immeuble", "id", "bien", "id_Immeuble", bsImmeuble);
            DBHelper.remplir_Grille(dataGridViewBien, bsBien);
            dataGridViewBien.Columns[0].Visible = false;
            dataGridViewBien.Columns[6].Visible = false;
            dataGridViewBien.Columns[7].Visible = false;
        }

        private void FormListeBien_Load(object sender, EventArgs e)
        {

            textBoxRechercher.Focus();
            DBHelper.ouvrirConnection("SyndicConnectionStringReda");

            DBHelper.remplir_dataset("select * from bloc", "bloc");
            DBHelper.remplir_dataset("select * from immeuble ", "immeuble");
            DBHelper.remplir_dataset("select * from bien", "bien");


            bsBloc = DBHelper.remplir_bindingsource("bloc");
            bsImmeuble = DBHelper.remplir_bindingsource("bloc", "id", "immeuble", "id_bloc", bsBloc);


            DBHelper.remplir_ListControl(comboBoxBloc, bsBloc, "nomBloc", "id");
            DBHelper.remplir_ListControl(comboBoxImmeuble, bsImmeuble, "nom", "id");

            RemplirDataGridViewBiens();
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

        private void buttonChercher_Click(object sender, EventArgs e)
        {
            string text = textBoxRechercher.Text;
            bool flag = true;
            foreach (DataGridViewRow row in dataGridViewBien.Rows)
            {
                for (int i = 0; i < row.Cells.Count - 1; i++)
                {
                    if (row.Cells[i].Value == null || i == 7 || i == 6)
                        continue;
                    if (row.Cells[i].Value.ToString().ToUpper().Contains(text.ToUpper()))
                    {
                        flag = false;
                        dataGridViewBien.CurrentCell = dataGridViewBien[1, row.Index];

                        int columnIndex = dataGridViewBien.CurrentCell.ColumnIndex;
                        string columnName = dataGridViewBien.Columns[columnIndex].Name;
                        string found = dataGridViewBien.CurrentCell.Value.ToString();

                        if (MessageBox.Show("is it ?\n" + columnName + " Bien est " + found, "question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            return;
                        else
                        {
                            break;
                        }
                    }
                }

            }
            if (!flag)
            {
                MessageBox.Show("c'est le dernier");
                return;
            }

            MessageBox.Show("Il n'y a rien");



        }

        private void buttonModifierBien_Click(object sender, EventArgs e)
        {
            if (dataGridViewBien.Rows.Count > 0)
            {
                new FormModifierBien("Modifier", Convert.ToDateTime(dataGridViewBien.CurrentRow.Cells[9].Value.ToString()), bsBien, Convert.ToInt32(dataGridViewBien.CurrentRow.Cells[7].Value.ToString()), dataGridViewBien.CurrentRow.Cells[5].Value.ToString(), Convert.ToInt32(dataGridViewBien.CurrentRow.Cells[6].Value.ToString()), Convert.ToInt32(dataGridViewBien.CurrentRow.Cells[0].Value.ToString())).ShowDialog();
                DBHelper.dataSet.Reset();
                FormListeBien_Load(sender, e);
            }
        }

        private void textBoxRechercher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonChercher.PerformClick();
            }
        }

        private void textBoxRechercher_TextChanged(object sender, EventArgs e)
        {
          
            if (textBoxRechercher.Text == "")
                buttonChercher.Enabled = false;
            else
                buttonChercher.Enabled = true;
        }

        private void buttonListDocs_Click(object sender, EventArgs e)
        {
            int current_Id = Convert.ToInt32(dataGridViewBien.CurrentRow.Cells[0].Value.ToString());
            new FormGestionDocument("documentBien", "where id_bien = " + current_Id.ToString(), current_Id).ShowDialog();

        }

        private void buttonAjouterBien_Click(object sender, EventArgs e)
        {
            new FormModifierBien("Ajouter", Convert.ToDateTime("01/01/1900"), bsBien).ShowDialog();
            DBHelper.dataSet.Reset();
            FormListeBien_Load(sender, e);
        }

        private void dataGridViewBien_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewBien.RowCount > 0)
                buttonModifierBien_Click(sender, e);
        }
    }
}
