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
    public partial class FormInterventions : Form
    {
        BindingSource bsIntervention;
        int id;
        public FormInterventions(BindingSource _bsintervention, int _id)
        {
            bsIntervention = _bsintervention;
            id = _id;
            InitializeComponent();
        }

        private void FormInterventions_Load(object sender, EventArgs e)
        {
            DBHelper.remplir_Grille(dataGridViewInterventions, bsIntervention);
        }

        private void labelCloseDepense_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAjouterIntervention_Click(object sender, EventArgs e)
        {
            new FormAjouterModifierIntervention(id).ShowDialog();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            bsIntervention.MoveNext();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            bsIntervention.MoveLast();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            bsIntervention.MovePrevious();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            bsIntervention.MoveFirst();
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
