﻿using System;
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
                labelAjouter.Text += " Bloc";
                this.Height = 185;
            }

            else
            {
                panelImeuble.Visible = true;
                labelAjouter.Text += " Immeuble";
                this.Height = 255;

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
            this.Close();
        }

        private void buttonRaz_Click(object sender, EventArgs e)
        {
            textBoxNbretages.Clear();
            textBoxNom.Clear();
            comboBoxBloc.SelectedIndex = 0;
        }

        private void labelCloseDocuments_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar!=(char)Keys.Back && e.KeyChar!=' ')
                e.Handled = true;
        }

        private void textBoxNbretages_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            if (titre.Equals(nameof(bloc)))
            {
                if (textBoxNom.Text == "")
                    buttonValider.Enabled = false;
                else
                    buttonValider.Enabled = true;
            }
            else
            {
                if (textBoxNom.Text == "" || textBoxNbretages.Text=="")
                    buttonValider.Enabled = false;
                else
                    buttonValider.Enabled = true;
            }

        }

        
    }
}
