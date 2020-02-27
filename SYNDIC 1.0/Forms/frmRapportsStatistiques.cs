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
        decimal cotisation = 0;
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
                    command.Connection = connection;
                    command.CommandText = "select SUM(montant) from cotisation";
                    cotisation = (decimal) command.ExecuteScalar();
                    command.CommandText = "select SUM(montant) from depense ";
                    depence = (decimal)command.ExecuteScalar();
                }
            }
            caisse = cotisation - depence;

            chart1.Series["Cotisation"].Points.AddXY("Cotisations", cotisation);

            chart1.Series["Depence"].Points.AddXY("Depences", depence);

            chart1.Series["Caisse"].Points.AddXY("Caisse", caisse);
        }
    }
}
