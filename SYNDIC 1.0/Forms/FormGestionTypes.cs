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
    public partial class FormGestionTypes : Form
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

        string type;
        BindingSource bsType;
        bool flag = false;
        int idType;

        public FormGestionTypes(string _type)
        {
            InitializeComponent();
            type = _type;
 //           bsType = _bsType;
        }


        private void valider(bool v)
        {
            panelCrud.Enabled = v;
            panelValider.Enabled = !v;
            dataGridGestionType.ReadOnly = v;


        }

        private void FormGestionTypes_Load(object sender, EventArgs e)
        {
            //Open Connection
            DBHelper.ouvrirConnection("SyndicConnectionString");
    
            // Querry 
            string query = "select * from type where idTableType in (select id from tabletype where libelle like '" + type + "')";
            DBHelper.remplir_dataset(query, "Type");

            // Remplissage de Binding source
            bsType = DBHelper.remplir_bindingsource("Type");
            
            // Remplissage DataGrid
            DBHelper.remplir_Grille(dataGridGestionType, bsType);
            valider(true);
            
            dataGridGestionType.Columns[0].Visible = false;
            dataGridGestionType.Columns[1].Visible = false;
            idType = Convert.ToInt32(dataGridGestionType.Rows[0].Cells[1].Value.ToString());
            dataGridGestionType.Columns[2].Width = 240;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            valider(false);

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            bsType.CancelEdit();
            valider(true);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            bsType.EndEdit();
            valider(true);
            flag = true;
            MessageBox.Show("l'operation a étè effectue avec succes");

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            valider(false);
            bsType.AddNew();
            dataGridGestionType.CurrentRow.Cells[1].Value = idType;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voullez vous Supprimer cet Type ?","Supprission",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2)==DialogResult.Yes )
            {

                bsType.RemoveCurrent();
                MessageBox.Show("la Supprission a étè effectue avec succes");
                flag = true;
            }
        }

        private void FormGestionTypes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag)
                DBHelper.syncroniser("type");
             
        }
    }
}
