
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

            textBoxResidence.Text+= "Résidence: " + src.nom+"\r\n";
            textBoxResidence.Text += "Adresse: " + src.adresse +"\r\n";
            textBoxResidence.Text += "Ville: " + src.Ville +"\r\n";
            textBoxResidence.Text += "Code Postal: " + src.codepostale;


            var src1 = from b in dc.blocs
                       select b;

            labelnbrBloc.Text = "Nombre des blocs :" + src1.Count().ToString();

            var src2 = from i in dc.immeubles
                       select i;

            labelnbrImmeuble.Text = "Nombre des immeubles :" + src2.Count().ToString();

            var src3 = from b in dc.biens
                       select b;

            labelnbrBien.Text = "Nombre des biens :" + src3.Count().ToString();

            comboBoxBloc.DisplayMember = "nomBloc";
            comboBoxBloc.ValueMember = "id";
            comboBoxBloc.DataSource = src1;

            var source = from b in dc.biens
                         join p in dc.proprietaires on b.id_proprietaire equals p.id
                         where b.id_immeuble.Equals(comboBoxImmeuble.SelectedValue)
                         select new
                         {
                             b.id,
                             Bien = b.nom,
                             Propriétaire = p.nom,
                             Jan = "",
                             Fév = "",
                             Mar = "",
                             Avr = "",
                             Mai = "",
                             Jun = "",
                             Jui = ""
                         ,
                             Aut = "",
                             Sep = "",
                             Oct = "",
                             Nov = "",
                             Dec = ""
                         };

            dataGridViewconsultations.DataSource = source;
            listBoxIdBien.DisplayMember = "id";
            listBoxIdBien.ValueMember = "id";
            listBoxIdBien.DataSource = source;

            
            dataGridViewconsultations.Columns[0].Visible = false;
            dataGridViewconsultations.AutoResizeColumns();

            comboBoxAnnee.SelectedIndex = 0;


            for (int i = 0; i < dataGridViewconsultations.Rows.Count; i++)
            {
                dataGridViewconsultations.CurrentCell = dataGridViewconsultations[1, i];

                for (int j = 3; j < 15; j++)
                {


                    var s = (
                                from b in dc.biens
                                join ec in dc.echeances on b.id equals ec.id_bien
                                where b.id.Equals(int.Parse(listBoxIdBien.SelectedValue.ToString()))
                                && ec.mois.Equals(j-2) && ec.annee.Equals(int.Parse(comboBoxAnnee.Text.ToString()))

                                select new { ec.paid }).SingleOrDefault();
                
                    if (s.paid == true)
                        dataGridViewconsultations.Rows[i].Cells[j].Style.BackColor = Color.Chocolate;
                    else
                        dataGridViewconsultations.Rows[i].Cells[j].Style.BackColor = Color.White;
                }

                //listBoxIdBien.SelectedIndex += 1;
            }

            dataGridViewconsultations.Columns[1].Width = 40;


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
            comboBoxAnnee.SelectedIndex = 0;

            var source = from b in dc.biens
                         join p in dc.proprietaires on b.id_proprietaire equals p.id
                         where b.id_immeuble.Equals(comboBoxImmeuble.SelectedValue)
                         select new { b.id,Bien = b.nom, Propriétaire = p.nom  , Jan= "",
                             Fév = "", Mar = "", Avr = "", Mai = "", Jun = "", Jui = ""
                         , Aut= "", Sep= ""  , Oct= "" , Nov= "" , Dec= "" };

            dataGridViewconsultations.DataSource = source;
            listBoxIdBien.DisplayMember = "id";
            listBoxIdBien.ValueMember = "id";
            listBoxIdBien.DataSource = source;

            dataGridViewconsultations.AutoResizeColumns();
            dataGridViewconsultations.Columns[0].Visible = false;

            try
            {
                for (int i = 0; i < dataGridViewconsultations.Rows.Count; i++)
                {
                    dataGridViewconsultations.CurrentCell = dataGridViewconsultations[1, i];

                    for (int j = 3; j < 15; j++)
                    {


                        var src = (
                                    from b in dc.biens
                                    join ec in dc.echeances on b.id equals ec.id_bien
                                    where b.id.Equals(int.Parse(listBoxIdBien.SelectedValue.ToString()))
                                    && ec.mois.Equals(j - 2) && ec.annee.Equals(int.Parse(comboBoxAnnee.Text.ToString()))

                                    select new { ec.paid }).SingleOrDefault();

                        if (src.paid == true)
                            dataGridViewconsultations.Rows[i].Cells[j].Style.BackColor = Color.Chocolate;
                        else
                            dataGridViewconsultations.Rows[i].Cells[j].Style.BackColor = Color.White;

                    }




                }
            }catch(Exception ex) { }
            dataGridViewconsultations.Columns[1].Width = 40;
        }
        

        private void buttonAjouterBloc_Click(object sender, EventArgs e)
        {
            using (var formAjouterBlocOrImmeuble = new FormAjouterBlocOrImmeuble(nameof(bloc)))
            {
                formAjouterBlocOrImmeuble.ShowDialog();
            }
            FormResidence_Load(sender, e);

        }

        private void buttonAjouterImmeuble_Click(object sender, EventArgs e)
        {
            using (var formAjouterBlocOrImmeuble = new FormAjouterBlocOrImmeuble(nameof(immeuble)))
            {
                formAjouterBlocOrImmeuble.ShowDialog();
            }

            FormResidence_Load(sender, e);
         
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

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAjouterBien_Click(object sender, EventArgs e)
        {

        }

        private void buttonAjouterImmeuble_Click_1(object sender, EventArgs e)
        {

        }

        private void labelnbrBloc_Click(object sender, EventArgs e)
        {

        }

        private void labelnbrImmeuble_Click(object sender, EventArgs e)
        {

        }

        private void labelnbrBien_Click(object sender, EventArgs e)
        {

        }

        private void buttonAjouterBloc_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonListDocs_Click(object sender, EventArgs e)
        {
            using (var formGestionDocument = new FormGestionDocument(nameof(documentProprietaire), "where 0 = 0" , 1))
            {
                formGestionDocument.ShowDialog();
            }
        }
    }

}
