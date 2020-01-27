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

        private void OpenFormInPannel(object formChild)
        {
            if (this.panelFinanceBody.Controls.Count > 0)
                this.panelFinanceBody.Controls.RemoveAt(0);

            Form frmchild = formChild as Form;
            frmchild.TopLevel = false;
            frmchild.Dock = DockStyle.Fill;
            this.panelFinanceBody.Controls.Add(frmchild);
            this.panelFinanceBody.Tag = frmchild;
            frmchild.Show();
        }

        private void buttonSsCotisations_Click(object sender, EventArgs e)
        {

            buttonSsCotisations.BackColor = Color.Navy;
            buttonSsDepenses.BackColor = Color.Blue;
            buttonSsEcheances.BackColor = Color.Blue;
          //  OpenFormInPannel(new FormCotisation());
        }

        private void buttonSsDepenses_Click(object sender, EventArgs e)
        {

            buttonSsDepenses.BackColor = Color.Navy;
            buttonSsEcheances.BackColor = Color.Blue;
            buttonSsCotisations.BackColor = Color.Blue;
           // OpenFormInPannel(new FormDepenses());
        }

        private void buttonSsEcheances_Click(object sender, EventArgs e)
        {

            buttonSsEcheances.BackColor = Color.Navy;
            buttonSsDepenses.BackColor = Color.Blue;
            buttonSsCotisations.BackColor = Color.Blue;
            OpenFormInPannel(new FormBienEcheance());

        }

        private void frmFinances_Load(object sender, EventArgs e)
        {
            buttonSsEcheances_Click(sender, e);
        }

        private void labelCloseFinances_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
