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
        SqlConnection connection;
        SqlCommand command;

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
            var src = from log in dataContext.journals
                      join user in dataContext.utilisateurs
                      on log.id_utilisateur equals user.id
                      join connnectionTable in dataContext.connexions
                      on user.id equals connnectionTable.id_utilisateur
                      select new
                      {
                          log.id,
                          connnectionTable.date_connexion,
                          user.typeUtilisateur,
                          log.date_action,
                          log.action,
                          log.table_action,
                          log.anciennes_valeurs,
                          log.nouvelles_valeurs
                      };
            dataGridViewHistorique.DataSource = src;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            int queryId = 0;
            string query = "delete j.*,c.* from journal j inner join connection c on j.id_utilisateur = c.id_utilisateur where id =@queryId";

            command = connection.CreateCommand();
            command.CommandText = query;

            //List<int> currentIds = new List<int>();
            if (dataGridViewHistorique.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select something");
                command.Dispose();
                connection.Dispose();
                return;
            }
            
            int rowsCount = dataGridViewHistorique.SelectedRows.Count;
            
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete'"+ rowsCount +"' rows ?","Deleting...",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
            
            if (dialogResult.Equals(DialogResult.Yes))
            {
                if (rowsCount == 1)
                {
                    try
                    {
                        int idRow = Convert.ToInt32(dataGridViewHistorique.CurrentRow.Cells[0].Value.ToString());
                        command.Parameters.AddWithValue("@queryId", idRow);
                        int exe = command.ExecuteNonQuery();
                        if (exe!=0)
                        {
                            MessageBox.Show("item deleted successfully");
                            connection = null;
                            command = null;
                            return;
                        }
                    }
                    finally
                    {
                        command = null;
                        connection.Close();
                    }
                }
                
                //dataContext.journal.DeleteOnSubmit();
                //foreach (DataGridViewRow row in dataGridViewHistorique.SelectedRows)
                //{
                //    currentIds.Add(Convert.ToInt32(row.Cells[0].Value.ToString()));

                //    var query = dataContext.journal.Where(log => currentIds.Contains(log.id))
                //                .Select(log => log.id).ToArray();

                //    dataContext.journal.DeleteAllOnSubmit(query);
                //    dataContext.SubmitChanges();
                //}
                
                foreach (DataGridViewRow row in dataGridViewHistorique.SelectedRows)
                {
                    try
                    {
                        queryId = Convert.ToInt32(row.Cells[0].Value);
                        command.Parameters.AddWithValue("@queryId", queryId);
                        int exe = command.ExecuteNonQuery();
                        if (exe !=0)
                        {
                            MessageBox.Show("items deleted successfully");
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        command = null;
                        connection.Dispose();
                    }
                }
            }
            frmHistoriques_Load(sender, e);
        }

        private void buttonSearchDataGridView_Click(object sender, EventArgs e)
        {
            if (!textBoxStrings.hasText() || dateTimePickerHistorique.Value != DateTime.Now)
            {

            }
        }
    }
}
