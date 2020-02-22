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
    public partial class frmHistoriques : Form
    {
        public frmHistoriques()
        {
            InitializeComponent();
        }

        DataClassesSyndicDataContext dataContext = new DataClassesSyndicDataContext();
        string connectionString = ConfigurationManager.ConnectionStrings["SyndicConnectionStringReda"].ToString();

        private void frmHistoriques_Load(object sender, EventArgs e)
        {
            textBoxStrings.Focus();
            var data = from log in dataContext.journals
                           join user in dataContext.utilisateurs
                           on log.id_utilisateur equals user.id
                           /*join connectionTable in dataContext.connexions
                           on user.id equals connectionTable.id_utilisateur*/
                           select new
                           {
                               log.id,
                              // connectionTable.date_connexion,
                               user.typeUtilisateur,
                               user.login,
                               log.date_action,
                               log.action,
                               log.table_action,
                               log.anciennes_valeurs,
                               log.nouvelles_valeurs
                           };

            dateTimePickerHistorique.Value = DateTime.Now;
            dataGridViewHistorique.DataSource = data;
        }
        private void labelCloseHistoriques_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearchDataGridView_Click(object sender, EventArgs e)
        {
            dateTimePickerHistorique.Enabled = !textBoxStrings.hasText();

            if (!textBoxStrings.hasText() || dateTimePickerHistorique.Value == DateTime.Now)
            {
                textBoxStrings.Focus();
                return;
            }

            string filter=comboBoxFilterItems.Text; 
                if(textBoxStrings.Text=="")
                    filter= "CONVERT(date,date_action)";

            string searchedString = textBoxStrings.Text.Trim().Replace("'", "''"); 
                if(textBoxStrings.Text == "")
                   searchedString= "'"+dateTimePickerHistorique.Value.ToShortDateString()+"'";

            string query = "select j.id,u.login,u.typeUtilisateur,date_action,action,table_action,anciennes_valeurs,nouvelles_valeurs from journal j  inner join utilisateur u on u.id = j.id_utilisateur  where "+filter +" = "+ searchedString;

            // we need to add inner join connexion c on j.id_utilisateur = c.id_utilisateur 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (textBoxStrings.hasText() || dateTimePickerHistorique.Value != DateTime.Now)
                    {
                        try
                        {
                           /* command.Parameters.AddWithValue("@filter", filter);
                            command.Parameters.AddWithValue("@searchedString", searchedString);*/

                            this.Cursor = Cursors.WaitCursor;
                            command.ExecuteNonQuery();

                            DataTable dataTable = new DataTable();
                            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                            {
                                dataAdapter.Fill(dataTable);
                            }

                            dataGridViewHistorique.DataSource = dataTable;
                            this.Cursor = Cursors.Default;
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                            //MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void buttonTofirst_Click(object sender, EventArgs e)
        {
            dataGridViewHistorique.Rows[0].Selected = true;
        }

        private void buttonToPrev_Click(object sender, EventArgs e)
        {

        }

        private void buttonToNext_Click(object sender, EventArgs e)
        {

        }

        private void buttonToLast_Click(object sender, EventArgs e)
        {
            dataGridViewHistorique.Rows[dataGridViewHistorique.Rows.Count - 1].Selected = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewHistorique.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectioner une ligne pour supprimer", "Aucune ligne a ete selectioner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                int queryId = 0;
                string query = "delete j.*,c.* from journal j inner join connection c on j.id_utilisateur = c.id_utilisateur where id =@queryId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete'" + dataGridViewHistorique.SelectedRows.Count + "' rows ?", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dialogResult.Equals(DialogResult.Yes))
                    {
                        #region deleting single row
                        if (dataGridViewHistorique.SelectedRows.Count == 1)
                        {
                            try
                            {
                                int idRow = Convert.ToInt32(dataGridViewHistorique.CurrentRow.Cells[0].Value.ToString());
                                command.Parameters.AddWithValue("@queryId", idRow);
                                this.Cursor = Cursors.WaitCursor;
                                int exe = command.ExecuteNonQuery();
                                this.Cursor = Cursors.Default;
                                if (exe != 0)
                                {
                                    MessageBox.Show("item deleted successfully");
                                    return;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                return;
                            }
                        }
                        #endregion

                        //dataContext.journal.DeleteOnSubmit();
                        //foreach (DataGridViewRow row in dataGridViewHistorique.SelectedRows)
                        //{
                        //    currentIds.Add(Convert.ToInt32(row.Cells[0].Value.ToString()));

                        //    var query = dataContext.journal.Where(log => currentIds.Contains(log.id))
                        //                .Select(log => log.id).ToArray();

                        //    dataContext.journal.DeleteAllOnSubmit(query);
                        //    dataContext.SubmitChanges();
                        //}

                        #region Deleting multiple rows
                        foreach (DataGridViewRow row in dataGridViewHistorique.SelectedRows)
                        {
                            try
                            {
                                queryId = Convert.ToInt32(row.Cells[0].Value.ToString());
                                command.Parameters.AddWithValue("@queryId", queryId);
                                this.Cursor = Cursors.WaitCursor;
                                int exe = command.ExecuteNonQuery();
                                this.Cursor = Cursors.Default;
                                if (exe != 0)
                                {
                                    MessageBox.Show("items deleted successfully");
                                    return;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                return;
                            }
                        }
                        #endregion
                    }
                }
            }

            frmHistoriques_Load(sender, e);
        }

        private void frmHistoriques_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridViewHistorique.SelectedRows.Count != 0)
            {
                if (dataGridViewHistorique.Focused)
                {
                    buttonDelete.PerformClick();
                }
            }
            if (textBoxStrings.hasText() || dateTimePickerHistorique.Value != DateTime.Now)
            {
                buttonSearchDataGridView_Click(sender, e);
            }
        }

       
    }
}
