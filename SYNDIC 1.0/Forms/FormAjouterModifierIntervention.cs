using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace SYNDIC_1._0
{
    public partial class FormAjouterModifierIntervention : Form
    {
        int id;
        public FormAjouterModifierIntervention(int _id)
        {
            id = _id;
            InitializeComponent();
        }

        private void labelCloseDepense_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            string sql = "insert into intervention values ('"
               + textBoxDesignationDepense.Text.Replace("'", "''") + "','"
               + dateTimePickerDebutIntervention.Text + "','" + dateTimePickerFinIntervention.Text
               + "','" + textBoxMontantIntervention.Text + "','" + id + "')";

            SqlCommand com = new SqlCommand(sql, DBHelper.connection);
            com.ExecuteNonQuery();
            com = null;
        }
    }
}
