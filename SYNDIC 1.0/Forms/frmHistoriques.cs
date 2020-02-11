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
    public partial class frmHistoriques : Form
    {
        DataClassesSyndicDataContext dataContext = new DataClassesSyndicDataContext();
        string connectionString = ConfigurationManager.ConnectionStrings["SyndicConnectionStringReda"].Name.ToString();
        
        public frmHistoriques()
        {
            InitializeComponent();
        }

        private void labelCloseHistoriques_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHistoriques_Load(object sender, EventArgs e)
        {
            var data = from log in dataContext.journals
                      join user in dataContext.utilisateurs
                      on log.id_utilisateur equals user.id
                      join connectionTable in dataContext.connexions
                      on user.id equals connectionTable.id_utilisateur
                      select new
                      {
                          log.id,
                          connectionTable.date_connexion,
                          user.typeUtilisateur,
                          log.date_action,
                          log.action,
                          log.table_action,
                          log.anciennes_valeurs,
                          log.nouvelles_valeurs
                      };
            dataGridViewHistorique.DataSource = data;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection(connectionString);
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            int rowsCount = dataGridViewHistorique.SelectedRows.Count;
            if (rowsCount == 0)
            {
                MessageBox.Show("Selectioner une ligne pour supprimer","Aucune ligne a ete selectioner",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                connection.Close();
                return;
            }

            int queryId = 0;
            string query = "delete j.*,c.* from journal j inner join connection c on j.id_utilisateur = c.id_utilisateur where id =@queryId";

            SqlCommand command = new SqlCommand();
            command = connection.CreateCommand();
            command.CommandText = query;
            
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete'"+ rowsCount +"' rows ?","Deleting...",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
            
            if (dialogResult.Equals(DialogResult.Yes))
            {
                #region deleting single row
                if (rowsCount == 1)
                {
                    try
                    {
                        int idRow = Convert.ToInt32(dataGridViewHistorique.CurrentRow.Cells[0].Value.ToString());
                        command.Parameters.AddWithValue("@queryId", idRow);
                        int exe = command.ExecuteNonQuery();
                        if (exe != 0)
                        {
                            MessageBox.Show("item deleted successfully");
                            command = null;
                            connection = null;
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        command = null;
                        connection = null;
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
                        this.Cursor = Cursors.WaitCursor;
                        queryId = Convert.ToInt32(row.Cells[0].Value.ToString());
                        command.Parameters.AddWithValue("@queryId", queryId);
                        int exe = command.ExecuteNonQuery();
                        this.Cursor = Cursors.Default;
                        if (exe != 0)
                        {
                            MessageBox.Show("items deleted successfully");
                            command = null;
                            connection = null;
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        command = null;
                        connection = null;
                    }
                } 
                #endregion
            }
            frmHistoriques_Load(sender, e);
            connection.Close();
        }

        private void buttonSearchDataGridView_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            if (connection.State != ConnectionState.Open)
            {
                connection.Open(); 
            }

            dateTimePickerHistorique.Enabled = !textBoxStrings.hasText();

            if (!textBoxStrings.hasText() || dateTimePickerHistorique.Value == DateTime.Now)
            {
                textBoxStrings.Focus();
                return;
            }

            string filter = textBoxStrings.hasText() ? comboBoxFilterItems.Text : "date_action";

            string searchedString = textBoxStrings.hasText() ? textBoxStrings.Text.Trim().Replace("'", "''") : dateTimePickerHistorique.Value.ToString();

            string query = "select (id,date_connexion,typeUtilisateur,date_action,action,table_action,anciennes_valeurs,nouvelles_valeurs) from journal j inner join connection c on j.id_utilisateur = c.id_utilisateur where @filter = @searchedString ";

            SqlCommand command = new SqlCommand();

            if (textBoxStrings.hasText() || dateTimePickerHistorique.Value != DateTime.Now)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    command = connection.CreateCommand();
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@filter", filter);
                    command.Parameters.AddWithValue("@searchedString", searchedString);
                    command.ExecuteNonQuery();
                 
                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                    {
                        dataAdapter.Fill(dataTable);
                    }

                    dataGridViewHistorique.DataSource = dataTable;
                    this.Cursor = Cursors.Default;
                }
                catch (Exception ex )
                {
                    MessageBox.Show(ex.Message);
                }

                connection = null;
            }

        }

        private void frmHistoriques_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridViewHistorique.SelectedRows.Count != 0 )
            {
                if (dataGridViewHistorique.Focused)
                {
                    buttonDelete.PerformClick();
                }
            }
            if (textBoxStrings.hasText() || dateTimePickerHistorique.Value != DateTime.Now )
            {
                buttonSearchDataGridView_Click(sender, e);
            }
        }

        private void buttonMoveToFirst_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewHistorique_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int sortColumn = 1 ;
            ListSortDirection direction = ListSortDirection.Ascending;
            if (dataGridViewHistorique.Columns[e.ColumnIndex].SortMode != DataGridViewColumnSortMode.NotSortable)
            {
                if (e.ColumnIndex == sortColumn)
                {
                    direction = direction == ListSortDirection.Ascending ? ListSortDirection.Descending : ListSortDirection.Ascending;
                }
                switch (direction)
                {
                    case ListSortDirection.Ascending:
                        dataGridViewHistorique.Sort(dataGridViewHistorique.Columns[e.ColumnIndex], ListSortDirection.Ascending);
                        break;
                    case ListSortDirection.Descending:
                        dataGridViewHistorique.Sort(dataGridViewHistorique.Columns[e.ColumnIndex], ListSortDirection.Descending);
                        break;
                }
            }
        }

        private void dataGridViewHistorique_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelAll_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
