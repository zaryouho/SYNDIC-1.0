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
        static string connectionString = ConfigurationManager.ConnectionStrings["SyndicConnectionStringReda"].ConnectionString;

        public enum actions
        {
            Ajouter, Modifer,Supprimer
        };

        /// <summary>
        /// Inserts values into database table <em>journal<em>
        /// Does not returns
        /// </summary>
        public static void makeLog(int userId, DateTime dateTimeAction, string action, string actionTable, string oldValues ,string newValues)
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
                //              dateTimeAction = DateTime.Now;
                // DateTime date = DateTime.Now;
                string query = " insert into journal(id_utilisateur,action,table_action,anciennes_valeurs,nouvelles_valeurs) values (@userId,@action ,@actionTable,@anciennes_valeurs ,@nouvelles_valeurs )";

                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    dateTimeAction = DateTime.Now;
                    command.Parameters.AddWithValue("@userId", userId);
                 //   command.Parameters.AddWithValue("@dateAction", dateTimeAction);
                    command.Parameters.AddWithValue("@action", action);
                    command.Parameters.AddWithValue("@actionTable", actionTable);
                    command.Parameters.AddWithValue("@anciennes_valeurs", oldValues);
                    command.Parameters.AddWithValue("@nouvelles_valeurs", newValues);

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
        /// <summary>
        /// Overloading the makeLog method with the ability to take multiple parameters as an input type of list of strings
        /// and inserts values into database table <em>journal<em>
        /// The size of the two lists must match otherwise throws an error 
        /// </summary>
        /// <param name="oldValues">List of strings</param>
        /// <param name="newValues">List of strings</param>
        public static void makeLog(int userId, DateTime dateTimeAction, string action, string actionTable, string[] oldValues , string[] newValues )
        {
            // To be deleted after testing

            //if (oldValues.Length != newValues.Length )
            //{
                //throw new Exception("Doesnt match !!");
            //}
            // To be deleted after testing
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

                string query = " insert into journal(id_utilisateur,action,table_action,anciennes_valeurs,nouvelles_valeurs) values (@userId,@action ,@actionTable,@anciennes_valeurs ,@nouvelles_valeurs )";
                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                  //  command.Parameters.AddWithValue("@dateAction", dateTimeAction);
                    command.Parameters.AddWithValue("@action", action);
                    command.Parameters.AddWithValue("@actionTable", actionTable);

                    string anciennes_valeurs = string.Join(" - ", oldValues.ToArray());
                    string nouvelles_valeurs = string.Join(" - ", newValues.ToArray());
                    
                    command.Parameters.AddWithValue("@anciennes_valeurs", anciennes_valeurs);
                    command.Parameters.AddWithValue("@nouvelles_valeurs", nouvelles_valeurs);
                    
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
