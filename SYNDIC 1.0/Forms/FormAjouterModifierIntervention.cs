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
using SYNDIC_1._0.Forms;

namespace SYNDIC_1._0
{
    public partial class FormAjouterModifierIntervention : Form
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

            string[] oldValues = null;
            string[] newValues = { textBoxDesignationDepense.Text, dateTimePickerDebutIntervention.Text, dateTimePickerFinIntervention.Text, textBoxMontantIntervention.Text };
            Helper.Log.makeLog(FormLogin.userId, DateTime.Now, "Ajouter", "Intervention",oldValues,newValues);
        }
    }
}
