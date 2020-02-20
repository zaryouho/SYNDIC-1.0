using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SYNDIC_1._0.Forms;

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
        string operation;
        private BindingSource bsType;
        private string type;
        private int id_immeuble; 

        public FormModifierBien(string _operation, DateTime _dateAchat_current, BindingSource _bsBien = null, int _id_current = -1, string _type = "", int _id_immeuble = -1)
        {
            InitializeComponent();
            id_Proprietaire = _id_current;
            dateAchat = _dateAchat_current;
            bsBien = _bsBien;
            operation = _operation;
            type = _type;
            id_immeuble = _id_immeuble;
        }

        private void enabled(bool v)
        {
            buttonAddNewTypeBien.Enabled = v;
            buttonAjouterImmeuble.Enabled = v;
            comboBoxTypeBien.Enabled = v;
            textBoxTitre.Enabled = v;
            textBoxNom.Enabled = v;
            textBoxEtage.Enabled = v;
            textBoxSuperficie.Enabled = v;
            textBoxCharge.Enabled = v;
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

            DBHelper.ouvrirConnection("SyndicConnectionStringReda");

            DBHelper.remplir_dataset("select nom+' '+prenom as nomComplet,id from Proprietaire", "proprietairePourComboBox");
            bsProprietaire = DBHelper.remplir_bindingsource("proprietairePourComboBox");
            
            DBHelper.remplir_dataset("select * from Type where idTableType in (select id from tabletype where libelle like 'bien')", "typebienAjouterModifier");
            bsType = DBHelper.remplir_bindingsource("typebienAjouterModifier");

            DBHelper.remplir_ListControl(comboBoxTypeBien, bsType, "libelleType", "libelleType");
            DBHelper.remplir_ListControl(comboBoxProprietaire, bsProprietaire, "nomComplet", "id");

            var immeubles = from imm in syndicDataContext.immeubles
                            select imm;

            
            comboBoxListeImmeuble.ValueMember = "id";
            comboBoxListeImmeuble.DisplayMember = "nom";
            comboBoxListeImmeuble.DataSource = immeubles;


            if (operation == "Modifier")
            {
                comboBoxProprietaire.SelectedValue = Convert.ToInt32(id_Proprietaire);
                comboBoxListeImmeuble.SelectedValue = id_immeuble;
                comboBoxTypeBien.SelectedValue = type;
                enabled(false);
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
            }
            else
            {
                enabled(true);
                comboBoxProprietaire_SelectedIndexChanged(sender, e);
                comboBoxTypeBien_SelectedIndexChanged(sender, e);
                comboBoxListeImmeuble_SelectedIndexChanged(sender, e);
            }

            //textBoxIdBien.DataBindings.Add("text", bsBien, "id");
            //textBoxTitre.DataBindings.Add("text", bsBien, "titre");
            //textBoxNom.DataBindings.Add("text", bsBien, "Nom");
            //textBoxEtage.DataBindings.Add("text", bsBien, "Etage");
            //textBoxSuperficie.DataBindings.Add("text", bsBien, "Superficie");
            //textBoxCharge.DataBindings.Add("text", bsBien, "charges");
            //textBoxTypeBien.DataBindings.Add("text", bsBien, "TypeBien");
            //textBoxIdImmeuble.DataBindings.Add("text", bsBien, "id_Immeuble");
            //textBoxIdProprietaire.DataBindings.Add("text", bsBien, "id_Proprietaire");
            //dateTimePickerDateAchat.DataBindings.Add("text", bsBien, "dateAchat");
                


             np = comboBoxProprietaire.Text.Split(' ');


        }

        private void labelCloseBiens_Click(object sender, EventArgs e)
        {
            // Affecter la valeur d'Id de Proprietaire
            //textBoxIdProprietaire.Text = comboBoxProprietaire.SelectedValue.ToString();

            if (textBoxIdProprietaire.Text == "")
                textBoxIdProprietaire.Text = "-1";


            // tester si il y a des Modification
            if (id_Proprietaire != Convert.ToInt32(textBoxIdProprietaire.Text) || dateAchat.ToShortDateString() != dateTimePickerDateAchat.Value.ToShortDateString())
            {
                
                DialogResult question = MessageBox.Show("Voullez vous Enregistrer les nouveaux Données ?", "Information", MessageBoxButtons.YesNoCancel);
                if (question == DialogResult.Cancel)
                    return;
                else if (question == DialogResult.Yes)
                {
                    if (operation == "Modifier" && id_Proprietaire != Convert.ToInt32(textBoxIdProprietaire.Text)) { 
                        var src = (from p in syndicDataContext.proprietaires
                                   where p.id.Equals(Convert.ToInt32(comboBoxProprietaire.SelectedValue.ToString()))
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
                    }
                    else if (operation == "Ajouter")
                    {
                        string querry= "insert into bien values('"+textBoxNom.Text+
                            "'," + textBoxEtage.Text +
                            " ," + textBoxSuperficie.Text +
                            " ," + textBoxCharge.Text +
                            " ,'" + textBoxTypeBien.Text+
                            "'," + textBoxIdImmeuble.Text+
                            " ," + textBoxIdProprietaire.Text+
                            " ,'" + textBoxTitre.Text+
                            "','"+dateTimePickerDateAchat.Value.ToShortDateString()+
                            "')";
                        SqlCommand Command = new SqlCommand(querry, DBHelper.connection);
                        Command.ExecuteNonQuery();

                    }
                   


                    bsBien.EndEdit();
                    DBHelper.syncroniser("bien");




                }
                else if (question == DialogResult.No) { 
                    bsBien.CancelEdit();
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

                DBHelper.syncroniser("proprietairePourComboBox");
                DBHelper.dataSet.Tables.Remove("proprietairePourComboBox");
                bsProprietaire.DataSource = null;
                comboBoxProprietaire.DataSource = null;
                
                DBHelper.remplir_dataset("select nom+' '+prenom as nomComplet,id from Proprietaire", "proprietairePourComboBox");
                bsProprietaire = DBHelper.remplir_bindingsource("proprietairePourComboBox");
                DBHelper.remplir_ListControl(comboBoxProprietaire, bsProprietaire, "nomComplet", "id");
            }
        }

        private void comboBoxProprietaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxProprietaire.SelectedValue!=null)
                textBoxIdProprietaire.Text = comboBoxProprietaire.SelectedValue.ToString();
        }

        private void buttonAjouterImmeuble_Click(object sender, EventArgs e)
        {
            new FormAjouterBlocOrImmeuble("Immeuble").ShowDialog();
            comboBoxListeImmeuble.DataSource = null;
            comboBoxListeImmeuble.Items.Clear();
            comboBoxListeImmeuble.Text = "";
            var immeubles = from imm in syndicDataContext.immeubles
                            select imm;


            comboBoxListeImmeuble.ValueMember = "id";
            comboBoxListeImmeuble.DisplayMember = "nom";
            comboBoxListeImmeuble.DataSource = immeubles;
        }

        private void buttonAddNewTypeBien_Click(object sender, EventArgs e)
        {
            using (var formGestionTypes = new FormGestionTypes(nameof(bien)))
            {
                formGestionTypes.ShowDialog();
                DBHelper.syncroniser("typebienAjouterModifier");
                DBHelper.dataSet.Tables.Remove("typebienAjouterModifier");
                bsType.DataSource = null;
                comboBoxTypeBien.DataSource = null;
                DBHelper.remplir_dataset("select * from Type where idTableType in (select id from tabletype where libelle like 'bien')", "typebienAjouterModifier");
                bsType = DBHelper.remplir_bindingsource("typebienAjouterModifier");

                DBHelper.remplir_ListControl(comboBoxTypeBien, bsType, "libelleType", "libelleType");
            }
        }

        private void comboBoxTypeBien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxTypeBien.Text = comboBoxTypeBien.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void comboBoxListeImmeuble_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxIdImmeuble.Text = comboBoxListeImmeuble.SelectedValue.ToString();
            }
            catch (Exception) { }
        }
    }
}
