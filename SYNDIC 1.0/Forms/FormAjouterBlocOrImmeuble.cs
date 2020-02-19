using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYNDIC_1._0.Forms
{
    public partial class FormAjouterBlocOrImmeuble : Form
    {
        string titre;
        DataClassesSyndicDataContext dc = new DataClassesSyndicDataContext();
        public FormAjouterBlocOrImmeuble( string _titre)
        {
            InitializeComponent();

            titre = _titre;
        }

        private void FormAjouterBlocOrImmeuble_Load(object sender, EventArgs e)
        {
            if (titre.Equals(nameof(bloc)))
            {
                panelImeuble.Visible = false;

            }

            else
            {
                panelImeuble.Visible = true;

                var src = from b in dc.blocs
                          select b;

                comboBoxBloc.DisplayMember = "nomBloc";
                comboBoxBloc.ValueMember = "id";
                comboBoxBloc.DataSource = src;
            }
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {

            if (titre.Equals(nameof(bloc)))
            {
                var src = (from r in dc.residences
                           select r).First();
                bloc b = new bloc();
                b.nomBloc = textBoxNom.Text;
                b.id_Residence = src.id;

                dc.blocs.InsertOnSubmit(b);

            }

            else
            {
                immeuble i = new immeuble();
                i.nom= textBoxNom.Text;
                i.nbrEtage = int.Parse(textBoxNbretages.Text.ToString());
                i.id_bloc=int.Parse(comboBoxBloc.SelectedValue.ToString());

                dc.immeubles.InsertOnSubmit(i);

            }

            dc.SubmitChanges();
        }

        private void buttonRaz_Click(object sender, EventArgs e)
        {
            textBoxNbretages.Clear();
            textBoxNom.Clear();
            comboBoxBloc.SelectedIndex = 0;
        }
    }
}
