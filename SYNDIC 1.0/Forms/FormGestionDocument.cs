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
            DBHelper.ouvrirConnection("SyndicConnectionStringReda");
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
            using (var save = new SaveFileDialog())
            {
                save.Title = "Saving File";
                save.Filter = "Pdf Files| *.pdf";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    var fileName = save.FileName;

                    var d = DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", "");
                    var n = new Random();
                    var i = n.Next().ToString();

                    var ext = Path.GetExtension(fileName);

                    var newName = d + n + i + ext;

                    File.Copy(fileName, "documents/" + newName);

                    bsDocument.AddNew();

                    dataGridViewListeDocuments.CurrentRow.Cells[3].Value = id.ToString();
                    dataGridViewListeDocuments.CurrentRow.Cells[2].Value = Application.StartupPath + "/documents/" + newName;
                    dataGridViewListeDocuments.CurrentRow.Cells[1].Value = Path.GetFileName(fileName);

                    string[] newValues = { Path.GetFileName(fileName),id.ToString() };
                

                    bsDocument.EndEdit();

                    DBHelper.syncroniser(table);

                    if (DBHelper.dataSet.Tables.Contains(table))
                        DBHelper.dataSet.Tables.Remove(table);

                     

                    string[] oldValues = { "", "" };
                    Helper.Log.makeLog(FormLogin.userId, DateTime.Now, "Ajouter", table ,oldValues , newValues);
                    FormGestionDocument_Load(sender, e);
                }
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
                
                var fichier = dataGridViewListeDocuments.CurrentRow.Cells[2].Value.ToString();
                MessageBox.Show(fichier);
                System.Diagnostics.Process.Start(@fichier);

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void buttonSupprimerDocument_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewListeDocuments.CurrentRow.Index != -1)
                {
                    if (DialogResult.Yes == MessageBox.Show("Voulez vous vraiment supprimer ce document ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        string[] newValues = { "", "" };
                        string[] oldValues = { dataGridViewListeDocuments.CurrentRow.Cells[0].ToString(), dataGridViewListeDocuments.CurrentRow.Cells[1].ToString(), dataGridViewListeDocuments.CurrentRow.Cells[2].ToString(), dataGridViewListeDocuments.CurrentRow.Cells[3].ToString() };
                        Helper.Log.makeLog(FormLogin.userId, DateTime.Now, "Ajouter", table, oldValues, newValues);

                        var fichier = dataGridViewListeDocuments.CurrentRow.Cells[2].Value.ToString();

                        File.Delete(fichier);
                        bsDocument.RemoveCurrent();
                        DBHelper.syncroniser(table);

                    }
                }
            }

            catch (Exception)
            {
                throw;
            }
        }
    }
}
