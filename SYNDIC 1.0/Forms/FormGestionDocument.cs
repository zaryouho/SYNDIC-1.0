using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYNDIC_1._0.Forms
{
    public partial class FormGestionDocument : Form
    {
        string table;
        string condition;
        int id;
        BindingSource bsDocument;

        public FormGestionDocument(string _table = "",string _condition ="",int _id = -1)
        {
            InitializeComponent();
            table = _table;
            condition = _condition;
            id = _id;
        }

        private void FormGestionDocument_Load(object sender, EventArgs e)
        {
            DBHelper.remplir_dataset("select * from " + table+" "+condition, table);
            
            bsDocument = DBHelper.remplir_bindingsource(table);

            DBHelper.remplir_Grille(dataGridViewListeDocuments, bsDocument);

            dataGridViewListeDocuments.Columns[0].Visible = false;
            dataGridViewListeDocuments.Columns[2].Visible = false;
            dataGridViewListeDocuments.Columns[3].Visible = false;


        }

        private void labelCloseHistoriques_Click(object sender, EventArgs e)
        {
            DBHelper.syncroniser(table);

            if (DBHelper.dataSet.Tables.Contains(table))
                DBHelper.dataSet.Tables.Remove(table);


            this.Close();

        }

        private void buttonAjouterDocument_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Saving File";
            save.Filter = "Pdf Files| *.pdf";
            if (save.ShowDialog() == DialogResult.OK)
            {
                string fileName = save.FileName;
                
                string d = DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", "");
                Random n = new Random();
                string i = n.Next().ToString();

                string ext = Path.GetExtension(fileName);

                string newName = d + n + i + ext;

                File.Copy(fileName, "documents/"+ newName);

                bsDocument.AddNew();
               
                dataGridViewListeDocuments.CurrentRow.Cells[3].Value = id.ToString();
                dataGridViewListeDocuments.CurrentRow.Cells[2].Value = Application.StartupPath + "/documents/" + newName;
                dataGridViewListeDocuments.CurrentRow.Cells[1].Value = Path.GetFileName(fileName);

                bsDocument.EndEdit();
                
                DBHelper.syncroniser(table);

                if (DBHelper.dataSet.Tables.Contains(table))
                    DBHelper.dataSet.Tables.Remove(table);

                FormGestionDocument_Load(sender, e);
            }

        }

        private void FormGestionDocument_FormClosing(object sender, FormClosingEventArgs e)
        {
            //try
            //{
            //    if (DBHelper.dataSet.Tables.Contains(table))
            //        DBHelper.dataSet.Tables.Remove(table);
            //    this.Close();
            //}catch(Exception ee) { }
        }

        private void dataGridViewListeDocuments_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewListeDocuments.Rows.Count > 0)
            {
                buttonAfficherDocument.Enabled = true;
                return;
            }
            buttonAfficherDocument.Enabled = false;
        }

        private void buttonAfficherDocument_Click(object sender, EventArgs e)
        {
            try
            {
                string fichier = dataGridViewListeDocuments.CurrentRow.Cells[2].Value.ToString();
                MessageBox.Show(fichier);
                System.Diagnostics.Process.Start(@fichier);

            }catch(Exception ee) { }
        }

        private void buttonSupprimerDocument_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewListeDocuments.CurrentRow.Index != -1)
                {
                    if (DialogResult.Yes == MessageBox.Show("Voulez vous vraiment supprimer cet Document ?", "Supprission", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        string fichier = dataGridViewListeDocuments.CurrentRow.Cells[2].Value.ToString();

                        File.Delete(fichier);
                        bsDocument.RemoveCurrent();
                        DBHelper.syncroniser(table);

                    }
                }
            }catch(Exception ee) { }
        }
    }
}
