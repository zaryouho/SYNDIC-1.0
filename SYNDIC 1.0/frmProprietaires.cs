using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYNDIC_1._0
{
    public partial class frmProprietaires : Form
    {
        DataClassesSyndicDataContext syndicDataContext = new DataClassesSyndicDataContext();
        char op = 'A';
        static int i = 0;
        proprietaire p = new proprietaire();
        public frmProprietaires()
        {
            InitializeComponent();
        }

        private void labelCloseProprietaires_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void dataGridViewProprietaires_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmProprietaires_Load(object sender, EventArgs e)
        {
            DBHelper.ouvrirConnection("SyndicConnectionString1");
            var src = from p in syndicDataContext.proprietaire
                      select p;

            

            dataGridViewProprietaires.DataSource = src;
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            //dataGridViewProprietaires.ClearSelection();
            //dataGridViewProprietaires.Rows[0].Selected = true;

            dataGridViewProprietaires.CurrentCell = dataGridViewProprietaires[0,0];
            
        }

       

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            op = 'A';
            using (var formAjouterModifierProp = new FormAjouterModifierProp(new proprietaire(), op))
            {
                formAjouterModifierProp.ShowDialog();
            }
            frmProprietaires_Load(sender, e);
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {

            op = 'M';

            p.id = int.Parse(dataGridViewProprietaires.CurrentRow.Cells[0].Value.ToString());
            p.nom = dataGridViewProprietaires.CurrentRow.Cells[1].Value.ToString();
            p.prenom = dataGridViewProprietaires.CurrentRow.Cells[2].Value.ToString();
            p.adresse = dataGridViewProprietaires.CurrentRow.Cells[3].Value.ToString();
            p.code_postal =int.Parse( dataGridViewProprietaires.CurrentRow.Cells[4].Value.ToString());
            p.tel = dataGridViewProprietaires.CurrentRow.Cells[5].Value.ToString();
            p.email = dataGridViewProprietaires.CurrentRow.Cells[6].Value.ToString();
            p.id_ville = int.Parse(dataGridViewProprietaires.CurrentRow.Cells[7].Value.ToString());
            p.Sexe= dataGridViewProprietaires.CurrentRow.Cells[8].Value.ToString();
            p.Titre = dataGridViewProprietaires.CurrentRow.Cells[9].Value.ToString();
            p.CIN = dataGridViewProprietaires.CurrentRow.Cells[10].Value.ToString();

            
            using (var formAjouterModifierProp = new FormAjouterModifierProp(p, op))
            {
                formAjouterModifierProp.ShowDialog();
              
            }
            frmProprietaires_Load(sender, e);
            dataGridViewProprietaires.CurrentCell = dataGridViewProprietaires[0, i];

          
        }

        private void buttonprevious_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                
                i--;
                dataGridViewProprietaires.CurrentCell = dataGridViewProprietaires[0, i];

            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (i < dataGridViewProprietaires.RowCount - 1)
            {
                i++;
                dataGridViewProprietaires.CurrentCell = dataGridViewProprietaires[0, i];
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            
            i=dataGridViewProprietaires.RowCount-1;
            dataGridViewProprietaires.CurrentCell = dataGridViewProprietaires[0,i] ;
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            var question = MessageBox.Show("Voullez vous supprimer cet proprietaire ?", "Information", MessageBoxButtons.YesNo);
            if (question == DialogResult.No)
                return;
            if (question == DialogResult.Yes)
            {
                p.id = int.Parse(dataGridViewProprietaires.CurrentRow.Cells[0].Value.ToString());
              
                var prop = (from pr in syndicDataContext.proprietaire
                            where pr.id.Equals(p.id)
                            select pr).Single();

                syndicDataContext.proprietaire.DeleteOnSubmit(prop);
                syndicDataContext.SubmitChanges();

                this.frmProprietaires_Load(sender , e);
            }
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
           
            
           // DBHelper.ouvrirConnection("SyndicConnectionString1");
           // var sql = "SELECT * from PROPRIETAIRE ";

           //string filter = " where ";
           //string[] t = textBoxrechercher.Text.Split(' ');
           //for (int i = 0; i < t.Length; i++)
           // {

           //     filter += "  CIN like '%" + t[i].Replace("'", "''") + "%' or NOM like '%" + t[i].Replace("'", "''") + "%' or ADRESSE like '%" + t[i].Replace("'", "''") + "%' or TITRE like '%" + t[i].Replace("'", "''") + "%' or SEXE like '%" + t[i].Replace("'", "''") + "%' or EMAIL like '%" + t[i].Replace("'", "''") + "%' or TEL like '%" + t[i].Replace("'", "''") + "%' or CODE_POSTAL like '%" + t[i].Replace("'", "''") + "%' or PRENOM like '%" + t[i].Replace("'", "''") + "%' ";

           //    if (i < t.Length - 1) filter += " or ";

           // }

           // dataGridViewProprietaires.Rows.Clear();

           // using (SqlCommand com = new SqlCommand(sql,DBHelper.cn))
           // {
           //     SqlDataReader dr = com.ExecuteReader();
           //     dataGridViewProprietaires.DataBindings.Clear();
                

           //     while (dr.Read())
           //     {
           //         dataGridViewProprietaires.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString());



           //     }

           //     dr.Close();


           //    DBHelper.fermerConnection();
            
        }
    }
}
