using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYNDIC_1._0
{
    public partial class frmFinances : Form
    {
        public frmFinances()
        {
            InitializeComponent();
        }

        private void buttonSsCotisations_Click(object sender, EventArgs e)
        {
            tabControlFinancesEcheances.SelectedTab = tabPageFinancesCotisations;
            buttonSsCotisations.BackColor = Color.Navy;
            buttonSsDepenses.BackColor = Color.Blue;
            buttonSsEcheances.BackColor = Color.Blue;
        }

        private void buttonSsDepenses_Click(object sender, EventArgs e)
        {
            tabControlFinancesEcheances.SelectedTab = tabPageFinancesDepenses;
            buttonSsDepenses.BackColor = Color.Navy;
            buttonSsEcheances.BackColor = Color.Blue;
            buttonSsCotisations.BackColor = Color.Blue;
        }

        private void buttonSsEcheances_Click(object sender, EventArgs e)
        {
            tabControlFinancesEcheances.SelectedTab = tabPageFinancesEcheances;
            buttonSsEcheances.BackColor = Color.Navy;
            buttonSsDepenses.BackColor = Color.Blue;
            buttonSsCotisations.BackColor = Color.Blue;
        }

        private void frmFinances_Load(object sender, EventArgs e)
        {
            buttonSsCotisations.BackColor = Color.Navy;
        }

        private void labelCloseFinances_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
