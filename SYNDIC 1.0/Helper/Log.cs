using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace SYNDIC_1._0.Helper
{
    public static class Log
    {
        static public int userId = 0 ;
        static public DateTime dateAction = DateTime.Now;
        static public string[] action = { "Ajouter", "Modifies", "Supprimmer" };
        static public string actionTable = string.Empty;
        static public string oldValue = string.Empty;
        static public string newValue = string.Empty;
        static string connectionString = ConfigurationManager.ConnectionStrings["SyndicConnectionStringReda"].Name.ToString();
        static SqlConnection connection = new SqlConnection(connectionString);
        /// <summary>
        /// Inserts values into database table <em>journal<em>
        /// Does not returns
        /// </summary>
        public static void createLog(int userId, DateTime dateTimeAction, string action, string actionTable, string oldValues,string newValues)
        {
            try
            {
                connection.Open();
                string query = "insert into journal values ('" + userId + "','" + dateTimeAction + "','" + action + "','" + actionTable + "','" + oldValues + "','" + newValues + "')";
                SqlCommand command = new SqlCommand(query, connection);
                int exe = command.ExecuteNonQuery();
                if (exe !=0)
                {
                    System.Windows.Forms.MessageBox.Show("Values inserted successfully");
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            connection.Dispose();
        }
    }
}
