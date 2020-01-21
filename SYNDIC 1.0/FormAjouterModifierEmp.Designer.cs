namespace SYNDIC_1._0
{
    partial class FormAjouterModifierEmp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonValdier = new System.Windows.Forms.Button();
            this.comboBoxActif = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTypeEmploye = new System.Windows.Forms.ComboBox();
            this.labelActif = new System.Windows.Forms.Label();
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.labelTypeEmploye = new System.Windows.Forms.Label();
            this.dateTimePickerDateRecrutement = new System.Windows.Forms.DateTimePicker();
            this.labelProprietaires = new System.Windows.Forms.Label();
            this.labelDateRecrutement = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTele = new System.Windows.Forms.Label();
            this.labelCharge = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxTele = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxCodePostal = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.comboBoxIdVille = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(160, 6);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(118, 23);
            this.buttonAnnuler.TabIndex = 0;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonValdier);
            this.panel1.Controls.Add(this.buttonAnnuler);
            this.panel1.Location = new System.Drawing.Point(66, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 32);
            this.panel1.TabIndex = 102;
            // 
            // buttonValdier
            // 
            this.buttonValdier.Location = new System.Drawing.Point(14, 6);
            this.buttonValdier.Name = "buttonValdier";
            this.buttonValdier.Size = new System.Drawing.Size(118, 23);
            this.buttonValdier.TabIndex = 1;
            this.buttonValdier.Text = "Valider";
            this.buttonValdier.UseVisualStyleBackColor = true;
            this.buttonValdier.Click += new System.EventHandler(this.buttonValdier_Click);
            // 
            // comboBoxActif
            // 
            this.comboBoxActif.Enabled = false;
            this.comboBoxActif.FormattingEnabled = true;
            this.comboBoxActif.Location = new System.Drawing.Point(177, 281);
            this.comboBoxActif.Name = "comboBoxActif";
            this.comboBoxActif.Size = new System.Drawing.Size(201, 21);
            this.comboBoxActif.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Ville :";
            // 
            // comboBoxTypeEmploye
            // 
            this.comboBoxTypeEmploye.FormattingEnabled = true;
            this.comboBoxTypeEmploye.Location = new System.Drawing.Point(177, 314);
            this.comboBoxTypeEmploye.Name = "comboBoxTypeEmploye";
            this.comboBoxTypeEmploye.Size = new System.Drawing.Size(201, 21);
            this.comboBoxTypeEmploye.TabIndex = 97;
            // 
            // labelActif
            // 
            this.labelActif.AutoSize = true;
            this.labelActif.Location = new System.Drawing.Point(24, 289);
            this.labelActif.Name = "labelActif";
            this.labelActif.Size = new System.Drawing.Size(34, 13);
            this.labelActif.TabIndex = 96;
            this.labelActif.Text = "Actif :";
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.AllowDrop = true;
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Location = new System.Drawing.Point(177, 341);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(201, 21);
            this.comboBoxVille.TabIndex = 95;
            this.comboBoxVille.SelectedIndexChanged += new System.EventHandler(this.comboBoxVille_SelectedIndexChanged);
            // 
            // labelTypeEmploye
            // 
            this.labelTypeEmploye.AutoSize = true;
            this.labelTypeEmploye.Location = new System.Drawing.Point(22, 322);
            this.labelTypeEmploye.Name = "labelTypeEmploye";
            this.labelTypeEmploye.Size = new System.Drawing.Size(80, 13);
            this.labelTypeEmploye.TabIndex = 94;
            this.labelTypeEmploye.Text = "Type Employe :";
            // 
            // dateTimePickerDateRecrutement
            // 
            this.dateTimePickerDateRecrutement.Enabled = false;
            this.dateTimePickerDateRecrutement.Location = new System.Drawing.Point(177, 255);
            this.dateTimePickerDateRecrutement.Name = "dateTimePickerDateRecrutement";
            this.dateTimePickerDateRecrutement.Size = new System.Drawing.Size(201, 20);
            this.dateTimePickerDateRecrutement.TabIndex = 93;
            // 
            // labelProprietaires
            // 
            this.labelProprietaires.AutoSize = true;
            this.labelProprietaires.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProprietaires.Location = new System.Drawing.Point(117, 17);
            this.labelProprietaires.Name = "labelProprietaires";
            this.labelProprietaires.Size = new System.Drawing.Size(171, 30);
            this.labelProprietaires.TabIndex = 92;
            this.labelProprietaires.Text = "Les Employes";
            // 
            // labelDateRecrutement
            // 
            this.labelDateRecrutement.AutoSize = true;
            this.labelDateRecrutement.Location = new System.Drawing.Point(24, 262);
            this.labelDateRecrutement.Name = "labelDateRecrutement";
            this.labelDateRecrutement.Size = new System.Drawing.Size(97, 13);
            this.labelDateRecrutement.TabIndex = 91;
            this.labelDateRecrutement.Text = "Date Recrutemet  :";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(24, 233);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 90;
            this.labelEmail.Text = "Email :";
            // 
            // labelTele
            // 
            this.labelTele.AutoSize = true;
            this.labelTele.Location = new System.Drawing.Point(24, 204);
            this.labelTele.Name = "labelTele";
            this.labelTele.Size = new System.Drawing.Size(67, 13);
            this.labelTele.TabIndex = 89;
            this.labelTele.Text = "Telephone  :";
            // 
            // labelCharge
            // 
            this.labelCharge.AutoSize = true;
            this.labelCharge.Location = new System.Drawing.Point(24, 175);
            this.labelCharge.Name = "labelCharge";
            this.labelCharge.Size = new System.Drawing.Size(70, 13);
            this.labelCharge.TabIndex = 88;
            this.labelCharge.Text = "Code Postal :";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(24, 146);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(51, 13);
            this.labelAdresse.TabIndex = 87;
            this.labelAdresse.Text = "Adresse :";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(24, 121);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(49, 13);
            this.labelPrenom.TabIndex = 86;
            this.labelPrenom.Text = "Prénom :";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(24, 92);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(38, 13);
            this.labelNom.TabIndex = 85;
            this.labelNom.Text = "Nom  :";
            // 
            // textBoxTele
            // 
            this.textBoxTele.Location = new System.Drawing.Point(177, 202);
            this.textBoxTele.Name = "textBoxTele";
            this.textBoxTele.Size = new System.Drawing.Size(201, 20);
            this.textBoxTele.TabIndex = 84;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(177, 230);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(201, 20);
            this.textBoxEmail.TabIndex = 83;
            // 
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.Location = new System.Drawing.Point(177, 173);
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(201, 20);
            this.textBoxCodePostal.TabIndex = 82;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(177, 144);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(201, 20);
            this.textBoxAdresse.TabIndex = 81;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(177, 118);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(201, 20);
            this.textBoxPrenom.TabIndex = 80;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(177, 89);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(201, 20);
            this.textBoxNom.TabIndex = 79;
            // 
            // comboBoxIdVille
            // 
            this.comboBoxIdVille.FormattingEnabled = true;
            this.comboBoxIdVille.Location = new System.Drawing.Point(177, 341);
            this.comboBoxIdVille.Name = "comboBoxIdVille";
            this.comboBoxIdVille.Size = new System.Drawing.Size(201, 21);
            this.comboBoxIdVille.TabIndex = 103;
            // 
            // FormAjouterModifierEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.comboBoxVille);
            this.Controls.Add(this.comboBoxIdVille);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxActif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTypeEmploye);
            this.Controls.Add(this.labelActif);
            this.Controls.Add(this.labelTypeEmploye);
            this.Controls.Add(this.dateTimePickerDateRecrutement);
            this.Controls.Add(this.labelProprietaires);
            this.Controls.Add(this.labelDateRecrutement);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTele);
            this.Controls.Add(this.labelCharge);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxTele);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxCodePostal);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Name = "FormAjouterModifierEmp";
            this.Text = "FormAjouterModifierEmp";
            this.Load += new System.EventHandler(this.FormAjouterModifierEmp_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonValdier;
        private System.Windows.Forms.ComboBox comboBoxActif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTypeEmploye;
        private System.Windows.Forms.Label labelActif;
        private System.Windows.Forms.ComboBox comboBoxVille;
        private System.Windows.Forms.Label labelTypeEmploye;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateRecrutement;
        private System.Windows.Forms.Label labelProprietaires;
        private System.Windows.Forms.Label labelDateRecrutement;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTele;
        private System.Windows.Forms.Label labelCharge;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxTele;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxCodePostal;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.ComboBox comboBoxIdVille;
    }
}