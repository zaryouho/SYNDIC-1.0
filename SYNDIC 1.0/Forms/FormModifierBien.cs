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
    public partial class FormModifierBien : Form
    {

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private int id_Proprietaire;
        private DateTime dateAchat;
        private BindingSource bsProprietaire;
        private BindingSource bsBien;
        DataClassesSyndicDataContext syndicDataContext = new DataClassesSyndicDataContext();
        string[] np;
        public FormModifierBien(int _id_current, DateTime _dateAchat_current,BindingSource _bsBien=null)
        {
            InitializeComponent();
            id_Proprietaire = _id_current;
            dateAchat = _dateAchat_current;
            bsBien = _bsBien;
        }

        private void FormModifierBien_Load(object sender, EventArgs e)
        {
            
                
                

                // remplissage de ComboBox des Proprietaires
                /*var src = from prop
                          in syndicDataContext.proprietaire
                          select new { prop.id,nomComplet = prop.nom+" "+prop.prenom  };


                comboBoxProprietaire.ValueMember = "id";
                comboBoxProprietaire.DisplayMember = "nomComplet";
                comboBoxProprietaire.DataSource = src;


                // initialization
                var currentProprietaire = (from prop
                          in syndicDataContext.proprietaire
                          where prop.id.Equals(Convert.ToInt32( currentRow.Cells[7].Value.ToString()))
                          select new { nomComplet = prop.nom + " " + prop.prenom }).Single();


                textBoxTitre.Text = currentRow.Cells[8].Value.ToString();
                textBoxNom.Text = currentRow.Cells[1].Value.ToString();
                textBoxEtage.Text = currentRow.Cells[2].Value.ToString();
                textBoxSuperficie.Text = currentRow.Cells[3].Value.ToString();
                textBoxCharge.Text = currentRow.Cells[4].Value.ToString();
                textBoxTypeBien.Text = currentRow.Cells[5].Value.ToString();
                textBoxIdImmeuble.Text = currentRow.Cells[6].Value.ToString();
                comboBoxProprietaire.Text = currentProprietaire.nomComplet;
                dateTimePickerDateAchat.Value = Convert.ToDateTime(currentRow.Cells[9].Value.ToString());*/

                DBHelper.remplir_dataset("select nom+' '+prenom as nomComplet,id from Proprietaire", "proprietairePourComboBox");
                bsProprietaire = DBHelper.remplir_bindingsource("proprietairePourComboBox");
                


                comboBoxProprietaire.ValueMember = "id";
                comboBoxProprietaire.DisplayMember = "nomComplet";
                comboBoxProprietaire.DataSource = bsProprietaire;

                comboBoxProprietaire.SelectedValue = Convert.ToInt32(id_Proprietaire);

                textBoxIdBien.DataBindings.Add("text", bsBien, "id");
                textBoxTitre.DataBindings.Add("text", bsBien, "titre");
                textBoxNom.DataBindings.Add("text", bsBien, "Nom");
                textBoxEtage.DataBindings.Add("text", bsBien, "Etage");
                textBoxSuperficie.DataBindings.Add("text", bsBien, "Superficie");
                textBoxCharge.DataBindings.Add("text", bsBien, "charges");
                textBoxTypeBien.DataBindings.Add("text", bsBien, "TypeBien");
                textBoxIdImmeuble.DataBindings.Add("text", bsBien, "id_Immeuble");
                textBoxIdProprietaire.DataBindings.Add("text", bsBien, "id_Proprietaire");
                dateTimePickerDateAchat.DataBindings.Add("text", bsBien, "dateAchat");


             np = comboBoxProprietaire.Text.Split(' ');


        }

        private void labelCloseBiens_Click(object sender, EventArgs e)
        {
            // Affecter la valeur d'Id de Proprietaire
            textBoxIdProprietaire.Text = comboBoxProprietaire.SelectedValue.ToString();
            
            // tester si il y a des Modification
           

            if (id_Proprietaire != Convert.ToInt32(textBoxIdProprietaire.Text) || dateAchat != dateTimePickerDateAchat.Value)
            {
                DialogResult question = MessageBox.Show("Voullez vous Enregistrer les nouveaux Données ?", "Information", MessageBoxButtons.YesNoCancel);
                if (question == DialogResult.Cancel)
                    return;
                if(question == DialogResult.Yes)
                {
                    /*    var editedBien = (from bien
                          in syndicDataContext.bien
                           where bien.id.Equals(Convert.ToInt32(currentRow.Cells[0].Value.ToString()))
                           select bien).Single();
                          

                    syndicDataContext.SubmitChanges();
                    */

                   
                    var src = (from p in syndicDataContext.proprietaires
                               where p.prenom.Equals(np[1]) && p.nom.Equals(np[0])
                               select p).Single();

                    ProprietaireArchive pa = new ProprietaireArchive();

                    pa.cin = src.CIN;
                    pa.titre = src.Titre;
                    pa.sexe = src.Sexe;
                    pa.id_ville = src.id_ville;
                    pa.email = src.email;
                    pa.tele = src.tel;
                    pa.code_postal = src.code_postal;
                    pa.adresse = src.adresse;
                    pa.prenom = src.prenom;
                    pa.nom = src.nom;
                    pa.bien = int.Parse(textBoxNom.Text);
                    pa.immeuble = int.Parse(textBoxIdImmeuble.Text);
                    pa.dateVente = dateTimePickerDateAchat.Value;

                    syndicDataContext.ProprietaireArchives.InsertOnSubmit(pa);
                    syndicDataContext.SubmitChanges();


                    bsBien.EndEdit();
                    DBHelper.syncroniser("bien");




                }

            }


            this.Close();
        }

        private void buttonAddNewProprietaire_Click(object sender, EventArgs e)
        {
            using (var formAjouterModifierProp = new FormAjouterModifierProp(new proprietaire(), 'A'))
            {
                formAjouterModifierProp.ShowDialog();
            }
        }

        private void comboBoxProprietaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxIdProprietaire.Text = comboBoxProprietaire.SelectedValue.ToString();
        }
    }
}
