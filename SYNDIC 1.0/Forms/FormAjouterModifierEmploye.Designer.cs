namespace SYNDIC_1._0.Forms
{
    partial class FormAjouterModifierEmploye
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
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.comboBoxIdVille = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonValdier = new System.Windows.Forms.Button();
            this.buttonRaz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTypeEmploye = new System.Windows.Forms.ComboBox();
            this.labelActif = new System.Windows.Forms.Label();
            this.labelTypeEmploye = new System.Windows.Forms.Label();
            this.dateTimePickerDateRecrutement = new System.Windows.Forms.DateTimePicker();
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
            this.panelHead = new System.Windows.Forms.Panel();
            this.labelCloseBiens = new System.Windows.Forms.Label();
            this.labelBiens = new System.Windows.Forms.Label();
            this.radioButtonActifTrue = new System.Windows.Forms.RadioButton();
            this.radioButtonActifFalse = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.AllowDrop = true;
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Location = new System.Drawing.Point(204, 326);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(201, 21);
            this.comboBoxVille.TabIndex = 119;
            // 
            // comboBoxIdVille
            // 
            this.comboBoxIdVille.FormattingEnabled = true;
            this.comboBoxIdVille.Location = new System.Drawing.Point(204, 326);
            this.comboBoxIdVille.Name = "comboBoxIdVille";
            this.comboBoxIdVille.Size = new System.Drawing.Size(201, 21);
            this.comboBoxIdVille.TabIndex = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAnnuler);
            this.panel1.Controls.Add(this.buttonValdier);
            this.panel1.Controls.Add(this.buttonRaz);
            this.panel1.Location = new System.Drawing.Point(74, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 74);
            this.panel1.TabIndex = 124;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(85, 35);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(118, 23);
            this.buttonAnnuler.TabIndex = 2;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
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
            // buttonRaz
            // 
            this.buttonRaz.Location = new System.Drawing.Point(160, 6);
            this.buttonRaz.Name = "buttonRaz";
            this.buttonRaz.Size = new System.Drawing.Size(118, 23);
            this.buttonRaz.TabIndex = 0;
            this.buttonRaz.Text = "Raz";
            this.buttonRaz.UseVisualStyleBackColor = true;
            this.buttonRaz.Click += new System.EventHandler(this.buttonRaz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 122;
            this.label1.Text = "Ville :";
            // 
            // comboBoxTypeEmploye
            // 
            this.comboBoxTypeEmploye.FormattingEnabled = true;
            this.comboBoxTypeEmploye.Location = new System.Drawing.Point(204, 299);
            this.comboBoxTypeEmploye.Name = "comboBoxTypeEmploye";
            this.comboBoxTypeEmploye.Size = new System.Drawing.Size(201, 21);
            this.comboBoxTypeEmploye.TabIndex = 121;
            // 
            // labelActif
            // 
            this.labelActif.AutoSize = true;
            this.labelActif.Location = new System.Drawing.Point(51, 274);
            this.labelActif.Name = "labelActif";
            this.labelActif.Size = new System.Drawing.Size(34, 13);
            this.labelActif.TabIndex = 120;
            this.labelActif.Text = "Actif :";
            // 
            // labelTypeEmploye
            // 
            this.labelTypeEmploye.AutoSize = true;
            this.labelTypeEmploye.Location = new System.Drawing.Point(49, 307);
            this.labelTypeEmploye.Name = "labelTypeEmploye";
            this.labelTypeEmploye.Size = new System.Drawing.Size(80, 13);
            this.labelTypeEmploye.TabIndex = 118;
            this.labelTypeEmploye.Text = "Type Employe :";
            // 
            // dateTimePickerDateRecrutement
            // 
            this.dateTimePickerDateRecrutement.Enabled = false;
            this.dateTimePickerDateRecrutement.Location = new System.Drawing.Point(204, 240);
            this.dateTimePickerDateRecrutement.Name = "dateTimePickerDateRecrutement";
            this.dateTimePickerDateRecrutement.Size = new System.Drawing.Size(201, 20);
            this.dateTimePickerDateRecrutement.TabIndex = 117;
            // 
            // labelDateRecrutement
            // 
            this.labelDateRecrutement.AutoSize = true;
            this.labelDateRecrutement.Location = new System.Drawing.Point(51, 247);
            this.labelDateRecrutement.Name = "labelDateRecrutement";
            this.labelDateRecrutement.Size = new System.Drawing.Size(97, 13);
            this.labelDateRecrutement.TabIndex = 116;
            this.labelDateRecrutement.Text = "Date Recrutemet  :";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(51, 218);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 115;
            this.labelEmail.Text = "Email :";
            // 
            // labelTele
            // 
            this.labelTele.AutoSize = true;
            this.labelTele.Location = new System.Drawing.Point(51, 189);
            this.labelTele.Name = "labelTele";
            this.labelTele.Size = new System.Drawing.Size(67, 13);
            this.labelTele.TabIndex = 114;
            this.labelTele.Text = "Telephone  :";
            // 
            // labelCharge
            // 
            this.labelCharge.AutoSize = true;
            this.labelCharge.Location = new System.Drawing.Point(51, 160);
            this.labelCharge.Name = "labelCharge";
            this.labelCharge.Size = new System.Drawing.Size(70, 13);
            this.labelCharge.TabIndex = 113;
            this.labelCharge.Text = "Code Postal :";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(51, 131);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(51, 13);
            this.labelAdresse.TabIndex = 112;
            this.labelAdresse.Text = "Adresse :";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(51, 106);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(49, 13);
            this.labelPrenom.TabIndex = 111;
            this.labelPrenom.Text = "Prénom :";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(51, 77);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(38, 13);
            this.labelNom.TabIndex = 110;
            this.labelNom.Text = "Nom  :";
            // 
            // textBoxTele
            // 
            this.textBoxTele.Location = new System.Drawing.Point(204, 187);
            this.textBoxTele.Name = "textBoxTele";
            this.textBoxTele.Size = new System.Drawing.Size(201, 20);
            this.textBoxTele.TabIndex = 109;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(204, 215);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(201, 20);
            this.textBoxEmail.TabIndex = 108;
            // 
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.Location = new System.Drawing.Point(204, 158);
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(201, 20);
            this.textBoxCodePostal.TabIndex = 107;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(204, 129);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(201, 20);
            this.textBoxAdresse.TabIndex = 106;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(204, 103);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(201, 20);
            this.textBoxPrenom.TabIndex = 105;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(204, 74);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(201, 20);
            this.textBoxNom.TabIndex = 104;
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.labelCloseBiens);
            this.panelHead.Controls.Add(this.labelBiens);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(444, 60);
            this.panelHead.TabIndex = 127;
            // 
            // labelCloseBiens
            // 
            this.labelCloseBiens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCloseBiens.AutoSize = true;
            this.labelCloseBiens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseBiens.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCloseBiens.Location = new System.Drawing.Point(422, 4);
            this.labelCloseBiens.Name = "labelCloseBiens";
            this.labelCloseBiens.Size = new System.Drawing.Size(18, 18);
            this.labelCloseBiens.TabIndex = 1;
            this.labelCloseBiens.Text = "X";
            this.labelCloseBiens.Click += new System.EventHandler(this.labelCloseBiens_Click);
            // 
            // labelBiens
            // 
            this.labelBiens.AutoSize = true;
            this.labelBiens.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBiens.Location = new System.Drawing.Point(172, 12);
            this.labelBiens.Name = "labelBiens";
            this.labelBiens.Size = new System.Drawing.Size(117, 30);
            this.labelBiens.TabIndex = 0;
            this.labelBiens.Text = "Employe";
            // 
            // radioButtonActifTrue
            // 
            this.radioButtonActifTrue.AutoSize = true;
            this.radioButtonActifTrue.Location = new System.Drawing.Point(213, 276);
            this.radioButtonActifTrue.Name = "radioButtonActifTrue";
            this.radioButtonActifTrue.Size = new System.Drawing.Size(47, 17);
            this.radioButtonActifTrue.TabIndex = 128;
            this.radioButtonActifTrue.TabStop = true;
            this.radioButtonActifTrue.Text = "True";
            this.radioButtonActifTrue.UseVisualStyleBackColor = true;
            // 
            // radioButtonActifFalse
            // 
            this.radioButtonActifFalse.AutoSize = true;
            this.radioButtonActifFalse.Location = new System.Drawing.Point(285, 276);
            this.radioButtonActifFalse.Name = "radioButtonActifFalse";
            this.radioButtonActifFalse.Size = new System.Drawing.Size(50, 17);
            this.radioButtonActifFalse.TabIndex = 129;
            this.radioButtonActifFalse.TabStop = true;
            this.radioButtonActifFalse.Text = "False";
            this.radioButtonActifFalse.UseVisualStyleBackColor = true;
            // 
            // FormAjouterModifierEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.radioButtonActifFalse);
            this.Controls.Add(this.radioButtonActifTrue);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.comboBoxVille);
            this.Controls.Add(this.comboBoxIdVille);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTypeEmploye);
            this.Controls.Add(this.labelActif);
            this.Controls.Add(this.labelTypeEmploye);
            this.Controls.Add(this.dateTimePickerDateRecrutement);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAjouterModifierEmploye";
            this.Text = "FormAjouterModifierEmploye";
            this.Load += new System.EventHandler(this.FormAjouterModifierEmploye_Load);
            this.panel1.ResumeLayout(false);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxVille;
        private System.Windows.Forms.ComboBox comboBoxIdVille;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonValdier;
        private System.Windows.Forms.Button buttonRaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTypeEmploye;
        private System.Windows.Forms.Label labelActif;
        private System.Windows.Forms.Label labelTypeEmploye;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateRecrutement;
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
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label labelCloseBiens;
        private System.Windows.Forms.Label labelBiens;
        private System.Windows.Forms.RadioButton radioButtonActifTrue;
        private System.Windows.Forms.RadioButton radioButtonActifFalse;
    }
}