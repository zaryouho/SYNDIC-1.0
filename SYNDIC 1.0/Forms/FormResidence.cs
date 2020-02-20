using SYNDIC_1._0.Forms;
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
    public partial class FormResidence : Form
    {

        DataClassesSyndicDataContext dc = new DataClassesSyndicDataContext();

        string[] months = { "Jan", "Fév", "Mar", "Avr", "Mai", "Juin", "Jui", "Aout", "Sep", "Oct", "Nov", "Déc" };
        public FormResidence()
        {
            InitializeComponent();
        }

        private void labelCloseDocuments_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormResidence_Load(object sender, EventArgs e)
        {
            var src = (from r in dc.residences
                       join v in dc.villes
                       on r.id_ville equals v.id
                       select new { r.nom, r.adresse, r.codepostale, Ville = v.nom }).First();

            textBoxResidence.Text+= "Residence: " + src.nom+"\r\n";
            textBoxResidence.Text += "Adresse: " + src.adresse +"\r\n";
            textBoxResidence.Text += "Ville: " + src.Ville +"\r\n";
            textBoxResidence.Text += "Code Postal: " + src.codepostale;


            var src1 = from b in dc.blocs
                       select b;

            textBoxnbrBloc.Text = "Nombre des blocs :" + src1.Count().ToString();

            var src2 = from i in dc.immeubles
                       select i;

            textBoxnbrImmeuble.Text = "Nombre des immeubles :" + src2.Count().ToString();

            var src3 = from b in dc.biens
                       select b;

            textBoxnbrBien.Text = "Nombre des biens :" + src3.Count().ToString();

            comboBoxBloc.DisplayMember = "nomBloc";
            comboBoxBloc.ValueMember = "id";
            comboBoxBloc.DataSource = src1;


            var source = from b in dc.biens
                         join p in dc.proprietaires on b.id_proprietaire equals p.id
                         where b.id_immeuble.Equals(comboBoxImmeuble.SelectedValue)
                         select new { Bien = b.nom,Propriétaire = p.nom  };

            dataGridViewconsultations.DataSource = source;

            for (int i = 0; i < 12; i++)
            {

                var ck = new DataGridViewTextBoxColumn();
                ck.Name = months[i];
                ck.HeaderText = months[i];
                ck.Width = 50;
                ck.ReadOnly = true;
                dataGridViewconsultations.Columns.Add(ck);

            }

            dataGridViewconsultations.AutoResizeColumns();
        }

        private void comboBoxBloc_SelectedIndexChanged(object sender, EventArgs e)
        {

   
            var src = from b in dc.blocs
                      join i in dc.immeubles on b.id equals i.id_bloc
                      where i.id_bloc.Equals(comboBoxBloc.SelectedValue)
                      select new { i.id, i.nom };

            comboBoxImmeuble.DisplayMember = "nom";

            comboBoxImmeuble.ValueMember = "id";
            comboBoxImmeuble.DataSource = src;




        }

        private void comboBoxImmeuble_SelectedIndexChanged(object sender, EventArgs e)
        {
            var source = from b in dc.biens
                         join p in dc.proprietaires on b.id_proprietaire equals p.id
                         where b.id_immeuble.Equals(comboBoxImmeuble.SelectedValue)
                         select new { Bien = b.nom, Propriétaire = p.nom };

            dataGridViewconsultations.DataSource = source;

            for (int i = 0; i < 12; i++)
            {

                var ck = new DataGridViewTextBoxColumn();
                ck.Name = months[i];
                ck.HeaderText = months[i];
                ck.Width = 50;
                ck.ReadOnly = true;
                dataGridViewconsultations.Columns.Add(ck);

            }

            dataGridViewconsultations.AutoResizeColumns();


            //for (int i = 0; i < dataGridViewconsultations.Rows.Count - 1; i++)
            //{
   

            //    for (int j = 0; j < 12; j++)
            //    {

            //        var src = (
            //                   from b in dc.biens
            //                   join ec in dc.echeances on b.id equals ec.id_bien
            //                   where b.id.Equals(dataGridViewconsultations.Rows[i].Cells[0].Value.ToString())
            //                   && ec.mois.Equals(j + 1) && ec.annee.Equals(DateTime.Today.Year)
            //                     && b.id.Equals(comboBoxImmeuble.SelectedValue)
            //                   select new { ec.paid }).SingleOrDefault();

            //        if (src.paid == true)
            //            dataGridViewconsultations.Rows[i].Cells[j + 2].Style.BackColor = Color.Black;

                //}
            //}


        }

        private void buttonAjouterBloc_Click(object sender, EventArgs e)
        {
            using (var formAjouterBlocOrImmeuble = new FormAjouterBlocOrImmeuble(nameof(bloc)))
            {
                formAjouterBlocOrImmeuble.ShowDialog();
            }

            var source = from b in dc.biens
                         join p in dc.proprietaires on b.id_proprietaire equals p.id
                         where b.id_immeuble.Equals(comboBoxImmeuble.SelectedValue)
                         select new { Bien = b.nom, Propriétaire = p.nom };

            dataGridViewconsultations.DataSource = source;

            for (int i = 0; i < 12; i++)
            {

                var ck = new DataGridViewTextBoxColumn();
                ck.Name = months[i];
                ck.HeaderText = months[i];
                ck.Width = 50;
                ck.ReadOnly = true;
                dataGridViewconsultations.Columns.Add(ck);

            }

            dataGridViewconsultations.AutoResizeColumns();
        }

        private void buttonAjouterImmeuble_Click(object sender, EventArgs e)
        {
            using (var formAjouterBlocOrImmeuble = new FormAjouterBlocOrImmeuble(nameof(immeuble)))
            {
                formAjouterBlocOrImmeuble.ShowDialog();
            }

            var source = from b in dc.biens
                         join p in dc.proprietaires on b.id_proprietaire equals p.id
                         where b.id_immeuble.Equals(comboBoxImmeuble.SelectedValue)
                         select new { Bien = b.nom, Propriétaire = p.nom };

            dataGridViewconsultations.DataSource = source;

            for (int i = 0; i < 12; i++)
            {

                var ck = new DataGridViewTextBoxColumn();
                ck.Name = months[i];
                ck.HeaderText = months[i];
                ck.Width = 50;
                ck.ReadOnly = true;
                dataGridViewconsultations.Columns.Add(ck);

            }

            dataGridViewconsultations.AutoResizeColumns();
        }

        private void printDocumentECbiens_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(dataGridViewconsultations.Width, dataGridViewconsultations.Height);
            dataGridViewconsultations.DrawToBitmap(bm, new Rectangle(0, 0, dataGridViewconsultations.Width,dataGridViewconsultations.Height));
            e.Graphics.DrawImage(bm, 0, 0);

        }

        private void buttonImprimer_Click(object sender, EventArgs e)
        {
            printDocumentECbiens.Print();
        }
    }

}
