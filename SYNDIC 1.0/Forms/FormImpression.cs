using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace SYNDIC_1._0.Forms
{
    public partial class FormImpression : Form
    {
        ReportClass r;
        string filter;
        public FormImpression(ReportClass _r, string _filter = "")
        {
            InitializeComponent();
            r = _r;
            filter = _filter;
        }

        private void FormImpression_Load(object sender, EventArgs e)
        {
            crystalReportViewer.ReportSource = r;
            crystalReportViewer.SelectionFormula = filter;
        }

        private void FormImpression_Load_1(object sender, EventArgs e)
        {

        }
    }
}
