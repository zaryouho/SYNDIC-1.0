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
        static public DateTime dateTimeAction = DateTime.Now;
        static public string action = string.Empty;
        static public string actionTable = string.Empty;
        static public string oldValues = string.Empty;
        static public string newValues = string.Empty;
        static string connectionString = ConfigurationManager.ConnectionStrings["SyndicConnectionStringReda"].ConnectionString;
        
        /// <summary>
        /// Inserts values into database table <em>journal<em>
        /// Does not returns
        /// </summary>
        public static void createLog(int userId, DateTime dateTimeAction, string action, string actionTable, string oldValues,string newValues)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

                string query = " insert into journal values (@userId ,@dateTimeAction ,@action ,@actionTable,@oldValues ,@newValues )";
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@dateAction", dateTimeAction);
                    command.Parameters.AddWithValue("@action", action);
                    command.Parameters.AddWithValue("@actionTable", actionTable);
                    command.Parameters.AddWithValue("@oldValues", oldValues);
                    command.Parameters.AddWithValue("@newValue", newValues);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        System.Windows.Forms.MessageBox.Show(e.Message);
                    }
                }

            }
            
        }
    }
}
