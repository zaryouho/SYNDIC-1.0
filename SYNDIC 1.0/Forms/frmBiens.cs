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
    public partial class frmBiens : Form
    {

        private int c = 0;
        

        private void OpenFormInPannel(object formChild)
        {
            if (this.splitContainerBiens.Panel2.Controls.Count > 0)
                this.splitContainerBiens.Panel2.Controls.RemoveAt(0);

            Form frmchild = formChild as Form;
            frmchild.TopLevel = false;
            frmchild.Dock = DockStyle.Fill;
            this.splitContainerBiens.Panel2.Controls.Add(frmchild);
            this.splitContainerBiens.Panel2.Tag = frmchild;
            frmchild.Show();
        }

        public frmBiens()
        {
            InitializeComponent();
        }

        private void labelCloseBiens_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmBiens_Load(object sender, EventArgs e)
        {
            buttonSsBiensListe.Focus();
            buttonSsBiensListe.BackColor = Color.Navy;
            buttonSsBiensListe_Click(sender, e);
            

        }

        private void buttonSsBiensListe_Click(object sender, EventArgs e)
        {
          
            buttonSsBiensListe.BackColor = Color.Navy;
            buttonSsBiensEcheances.BackColor = Color.Blue;
           
            OpenFormInPannel(new FormListeBien());
        }

        private void buttonSsBiensEchangeProprietaire_Click(object sender, EventArgs e)
        {
          
            buttonSsBiensListe.BackColor = Color.Blue;
            buttonSsBiensEcheances.BackColor = Color.Blue;
          
        }

        private void buttonSsBiensEcheances_Click(object sender, EventArgs e)
        {
           
            buttonSsBiensListe.BackColor = Color.Blue;
            buttonSsBiensEcheances.BackColor = Color.Navy;
          
            OpenFormInPannel(new FormBienEcheance());
            
        }
    }
}
