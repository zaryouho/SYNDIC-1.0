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
    public partial class frmDocuments : Form
    {
        public frmDocuments()
        {
            InitializeComponent();
        }

        private void labelCloseDocuments_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
