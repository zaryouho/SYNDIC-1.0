using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYNDIC_1._0
{
    public partial class frmBiens : Form
    {

        // les Variables Global
        private BindingSource bsBien;
        private BindingSource bsBloc;
        private BindingSource bsImmeuble;


        public frmBiens()
        {
            InitializeComponent();
        }

        private void labelCloseBiens_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public void RemplirDataGridViewBiens()
        {
            bsBien = DBHelper.remplir_bindingsource("immeuble", "id", "bien", "id_Immeuble", bsImmeuble);
            DBHelper.remplir_Grille(dataGridViewBien, bsBien);
            dataGridViewBien.Columns[0].Visible = false;
            dataGridViewBien.Columns[6].Visible = false;
            dataGridViewBien.Columns[7].Visible = false;
        }


        private void frmBiens_Load(object sender, EventArgs e)
        {
            DBHelper.ouvrirConnection("SyndicConnectionString1");

            DBHelper.remplir_dataset("select * from bloc", "bloc");
            DBHelper.remplir_dataset("select * from immeuble ","immeuble");
            DBHelper.remplir_dataset("select * from bien", "bien");

         
            bsBloc = DBHelper.remplir_bindingsource("bloc");
            bsImmeuble = DBHelper.remplir_bindingsource("bloc","id", "immeuble","id_bloc",bsBloc);
         

            DBHelper.remplir_ListControl(comboBoxBloc, bsBloc,"nomBloc", "id");
            DBHelper.remplir_ListControl(comboBoxImmeuble, bsImmeuble,"nom", "id");

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
            
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {

            new FormModifierBien(Convert.ToInt32(dataGridViewBien.CurrentRow.Cells[7].Value.ToString()),Convert.ToDateTime(dataGridViewBien.CurrentRow.Cells[9].Value.ToString()),bsBien).ShowDialog();
            
        

            
       

        }

        private void panelHead_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainerBiens_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
