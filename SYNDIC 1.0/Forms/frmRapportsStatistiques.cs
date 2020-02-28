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

namespace SYNDIC_1._0
{
    public partial class frmRapportsStatistiques : Form
    {
        decimal[] cotisation;
        decimal depence = 0;
        decimal caisse = 0;

        public frmRapportsStatistiques()
        {
            InitializeComponent();
        }

        private void labelCloseRapportsStatistiques_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRapportsStatistiques_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                using (SqlCommand command = new SqlCommand())
                {
                    for (int i = 0; i < 12; i++) 
                        {
                        command.CommandText = "";
                        command.Connection = connection;
                        command.CommandText = "select SUM(montant) from cotisation where MONTH(date_recette) is not null and MONTH(date_recette) = "+(i+1);
                        cotisation[i] = Convert.ToDecimal(command.ExecuteNonQuery());

                        }
                command.CommandText = "select SUM(montant) from depense ";
                    depence = (decimal)command.ExecuteScalar();
                }
            }
           // caisse = 1000 - depence;

            chart1.Series["Cotisation"].Points.Clear();
            chart1.Series["Cotisation"].Points.AddXY("Cotisations", cotisation);

            //chart1.Series["Depense"].Points.Clear();
            //chart1.Series["Depense"].Points.AddXY("Depences", depence);

            //chart1.Series["Caisse"].Points.Clear();
            //chart1.Series["Caisse"].Points.AddXY("Caisse", caisse);
        }

        private void labelCloseRapportsStatistiques_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
