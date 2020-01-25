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
    public partial class FormRecetteProprietaire : Form
    {
        // Les Varuables Global
        private BindingSource bsProprietaire;
        private BindingSource bsRecette;
        private DataClassesSyndicDataContext SyndicDataContext = new DataClassesSyndicDataContext();

        public FormRecetteProprietaire()
        {
            InitializeComponent();
        }

       
        private void FormRecetteProprietaire_Load(object sender, EventArgs e)
        {
            DBHelper.remplir_dataset("select nom + ' ' + prenom as Nom_Complet,id from proprietaire where id in (select distinct id_proprietaire from bien)", "Proprietaire_Recette");
            DBHelper.remplir_dataset("select * from cotisation where id_propietaire in (select distinct id_proprietaire from bien)", "cotisation");


            bsProprietaire = DBHelper.remplir_bindingsource("Proprietaire_Recette");
            bsRecette = DBHelper.remplir_bindingsource("Proprietaire_Recette", "id", "cotisation", "id_propietaire", bsProprietaire);

            DBHelper.remplir_ListControl(comboBoxProprietaire, bsProprietaire, "Nom_Complet", "id");
            DBHelper.remplir_Grille(dataGridViewRecette, bsRecette);

            dataGridViewRecette.Columns[0].Visible = false;
            dataGridViewRecette.Columns[5].Visible = false;
        }



        private void buttonFirst_Click(object sender, EventArgs e)
        {
            bsRecette.MoveFirst();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            bsRecette.MovePrevious();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            bsRecette.MoveNext();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            bsRecette.MoveLast();
        }

        private void buttonAjouterRecette_Click(object sender, EventArgs e)
        {
            int id_proprietaire = Convert.ToInt32(comboBoxProprietaire.SelectedValue);
            new FormAjouterModifierRecette(id_proprietaire, "Ajouter").ShowDialog();
            DBHelper.dataSet.Reset();

            FormRecetteProprietaire_Load(sender, e);
            comboBoxProprietaire.SelectedValue = id_proprietaire;
        }

        private void buttonSupprimerRecette_Click(object sender, EventArgs e)
        {
            var echeances = from echeance in SyndicDataContext.echeance
                            join cotisation_echeance in SyndicDataContext.cotisation_echeance
                            on echeance.id equals cotisation_echeance.id_echeance
                            where cotisation_echeance.id_recette.Equals(Convert.ToInt32(dataGridViewRecette.CurrentRow.Cells[0].Value.ToString()))
                            select echeance;



            foreach (echeance ech in echeances)
            {





            }
        }
    }
}
