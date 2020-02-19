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
using SYNDIC_1._0.Forms;


namespace SYNDIC_1._0
{
    public partial class FormAjouterProduit : Form
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

        BindingSource bsProduit;
        BindingSource bsCategorie;
        string button;
        string[] oldValues = {"","","","" };

        public FormAjouterProduit()
        {
            InitializeComponent();

        }

        private void enabled(bool v)
        {
            panelCRUD.Enabled = !v;
            panelInputs.Enabled = v;
            panelValid.Enabled = v;


        }

        private void FormAjouterProduit_Load(object sender, EventArgs e)
        {
            DBHelper.ouvrirConnection("SyndicConnectionStringReda");
            
            DBHelper.remplir_dataset("select libelleType from Type where idTableType in( select id from TableType where libelle like 'categorie' )", "categorieProduit");
            bsCategorie = DBHelper.remplir_bindingsource("categorieProduit");

            DBHelper.remplir_ListControl(comboBoxCategorie, bsCategorie, "libelleType", "libelleType");

            DBHelper.remplir_dataset("select * from produit", "produit");
            bsProduit = DBHelper.remplir_bindingsource("produit");

            DBHelper.remplir_Grille(dataGridViewListProduits, bsProduit);

            enabled(false);

            textBoxDesignation.DataBindings.Add("text", bsProduit, "designation");
            textBoxQteStockProduit.DataBindings.Add("text", bsProduit, "qteStock");
            textBoxCategorieProduit.DataBindings.Add("text", bsProduit, "categorie");
            textBoxIdProduit.DataBindings.Add("text", bsProduit, "id"); 

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous vraiment Enregistrer ces Information ?"
                 + "\nReference : " + textBoxIdProduit.Text
                 + "\nDesignation : " + textBoxDesignation.Text
                 + "\nqteStock : " + textBoxQteStockProduit.Text
                 + "\nCategorie : " + comboBoxCategorie.Text
                 , "Ajouter", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bsProduit.EndEdit();
                DBHelper.syncroniser("produit");

                if (button == "Ajouter") 
                {
                    string[] empty = { "", "", "", "" };
                    oldValues = empty;
                
                }

                string[] newValues = { textBoxDesignation.Text, textBoxIdProduit.Text, textBoxQteStockProduit.Text, textBoxIdProduit.Text };
                Helper.Log.makeLog(FormLogin.userId, DateTime.Now, "Ajouter", "Produit", oldValues,newValues);
                enabled(false);
            }
            else if (result == DialogResult.No)
            {
                bsProduit.CancelEdit();
                enabled(false);
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            bsProduit.CancelEdit();
            enabled(false);
        }

        private void labelCloseDepense_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAjouterProduit_Paint(object sender, PaintEventArgs e)
        {
            
            
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
            Color.Black, 2, ButtonBorderStyle.Solid,
            this.BackColor, 5, ButtonBorderStyle.Solid,
            this.BackColor, 5, ButtonBorderStyle.Solid,
            this.BackColor, 5, ButtonBorderStyle.Solid);

        }

        private void textBoxCategorieProduit_TextChanged(object sender, EventArgs e)
        {
            if (panelCRUD.Enabled)
                comboBoxCategorie.Text = textBoxCategorieProduit.Text;
        }

        private void comboBoxCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCategorieProduit.Text = comboBoxCategorie.SelectedValue.ToString();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            enabled(true);
            bsProduit.AddNew();
            button = "Ajouter";
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            enabled(true);
            button = "Modifier";
            
            oldValues[0] = textBoxDesignation.Text;
            oldValues[1] = textBoxIdProduit.Text;
            oldValues[2] = textBoxQteStockProduit.Text;
            oldValues[3] = textBoxIdProduit.Text;
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous vraiment supprimer ces Information ?"
                 + "\nReference : " + textBoxIdProduit.Text
                 + "\nDesignation : " + textBoxDesignation.Text
                 + "\nqteStock : " + textBoxQteStockProduit.Text
                 + "\nCategorie : " + comboBoxCategorie.Text
                 , "Ajouter", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                bsProduit.RemoveCurrent();
                DBHelper.syncroniser("produit");
            }
        }

        private void textBoxDesignation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)) && e.KeyChar!=' ')
                e.Handled = true;
        }

        private void textBoxQteStockProduit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)(Keys.Back)))
                e.Handled = true;
        }

        private void textBoxIdProduit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)(Keys.Back)))
                e.Handled = true;
        }
    }
}
