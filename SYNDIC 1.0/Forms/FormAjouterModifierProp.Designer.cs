namespace SYNDIC_1._0
{
    partial class FormAjouterModifierProp
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
            this.textBoxCin = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxCodePostal = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTele = new System.Windows.Forms.TextBox();
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.labelSexe = new System.Windows.Forms.Label();
            this.labelVille = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTele = new System.Windows.Forms.Label();
            this.labelCharge = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelCin = new System.Windows.Forms.Label();
            this.comboBoxSexe = new System.Windows.Forms.ComboBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.labelCloseProprietaires = new System.Windows.Forms.Label();
            this.labelProprietaires = new System.Windows.Forms.Label();
            this.comboBoxIdVille = new System.Windows.Forms.ComboBox();
            this.comboBoxTitre = new System.Windows.Forms.ComboBox();
            this.buttonRAZ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCin
            // 
            this.textBoxCin.Location = new System.Drawing.Point(203, 73);
            this.textBoxCin.Name = "textBoxCin";
            this.textBoxCin.Size = new System.Drawing.Size(201, 20);
            this.textBoxCin.TabIndex = 1;
            this.textBoxCin.TextChanged += new System.EventHandler(this.comboBoxSexe_TextChanged);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(203, 102);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(201, 20);
            this.textBoxNom.TabIndex = 2;
            this.textBoxNom.TextChanged += new System.EventHandler(this.comboBoxSexe_TextChanged);
            this.textBoxNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrenom_KeyPress);
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(203, 131);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(201, 20);
            this.textBoxPrenom.TabIndex = 3;
            this.textBoxPrenom.TextChanged += new System.EventHandler(this.comboBoxSexe_TextChanged);
            this.textBoxPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrenom_KeyPress);
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(203, 190);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(201, 20);
            this.textBoxAdresse.TabIndex = 5;
            this.textBoxAdresse.TextChanged += new System.EventHandler(this.comboBoxSexe_TextChanged);
            // 
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.Location = new System.Drawing.Point(203, 219);
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(201, 20);
            this.textBoxCodePostal.TabIndex = 6;
            this.textBoxCodePostal.TextChanged += new System.EventHandler(this.comboBoxSexe_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(203, 277);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(201, 20);
            this.textBoxEmail.TabIndex = 7;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.comboBoxSexe_TextChanged);
            // 
            // textBoxTele
            // 
            this.textBoxTele.Location = new System.Drawing.Point(203, 248);
            this.textBoxTele.Name = "textBoxTele";
            this.textBoxTele.Size = new System.Drawing.Size(201, 20);
            this.textBoxTele.TabIndex = 8;
            this.textBoxTele.TextChanged += new System.EventHandler(this.comboBoxSexe_TextChanged);
            this.textBoxTele.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTele_KeyPress);
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Location = new System.Drawing.Point(203, 305);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(201, 21);
            this.comboBoxVille.TabIndex = 10;
            this.comboBoxVille.SelectedIndexChanged += new System.EventHandler(this.comboBoxVille_SelectedIndexChanged);
            this.comboBoxVille.TextChanged += new System.EventHandler(this.comboBoxSexe_TextChanged);
            // 
            // labelSexe
            // 
            this.labelSexe.AutoSize = true;
            this.labelSexe.Location = new System.Drawing.Point(51, 163);
            this.labelSexe.Name = "labelSexe";
            this.labelSexe.Size = new System.Drawing.Size(37, 13);
            this.labelSexe.TabIndex = 29;
            this.labelSexe.Text = "Sexe :";
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Location = new System.Drawing.Point(50, 308);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(32, 13);
            this.labelVille.TabIndex = 27;
            this.labelVille.Text = "Ville :";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(50, 279);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 26;
            this.labelEmail.Text = "Email :";
            // 
            // labelTele
            // 
            this.labelTele.AutoSize = true;
            this.labelTele.Location = new System.Drawing.Point(50, 250);
            this.labelTele.Name = "labelTele";
            this.labelTele.Size = new System.Drawing.Size(34, 13);
            this.labelTele.TabIndex = 25;
            this.labelTele.Text = "Tele :";
            // 
            // labelCharge
            // 
            this.labelCharge.AutoSize = true;
            this.labelCharge.Location = new System.Drawing.Point(50, 221);
            this.labelCharge.Name = "labelCharge";
            this.labelCharge.Size = new System.Drawing.Size(70, 13);
            this.labelCharge.TabIndex = 24;
            this.labelCharge.Text = "Code Postal :";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(50, 192);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(51, 13);
            this.labelAdresse.TabIndex = 23;
            this.labelAdresse.Text = "Adresse :";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(50, 134);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(49, 13);
            this.labelPrenom.TabIndex = 22;
            this.labelPrenom.Text = "Prénom :";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(50, 105);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(38, 13);
            this.labelNom.TabIndex = 21;
            this.labelNom.Text = "Nom  :";
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Location = new System.Drawing.Point(48, 337);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(34, 13);
            this.labelTitre.TabIndex = 30;
            this.labelTitre.Text = "Titre :";
            // 
            // labelCin
            // 
            this.labelCin.AutoSize = true;
            this.labelCin.Location = new System.Drawing.Point(51, 76);
            this.labelCin.Name = "labelCin";
            this.labelCin.Size = new System.Drawing.Size(25, 13);
            this.labelCin.TabIndex = 31;
            this.labelCin.Text = "Cin:";
            // 
            // comboBoxSexe
            // 
            this.comboBoxSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSexe.FormattingEnabled = true;
            this.comboBoxSexe.Location = new System.Drawing.Point(203, 160);
            this.comboBoxSexe.Name = "comboBoxSexe";
            this.comboBoxSexe.Size = new System.Drawing.Size(201, 21);
            this.comboBoxSexe.TabIndex = 32;
            this.comboBoxSexe.TextChanged += new System.EventHandler(this.comboBoxSexe_TextChanged);
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(51, 399);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(88, 39);
            this.buttonValider.TabIndex = 33;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(315, 399);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(88, 39);
            this.buttonAnnuler.TabIndex = 34;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // labelCloseProprietaires
            // 
            this.labelCloseProprietaires.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCloseProprietaires.AutoSize = true;
            this.labelCloseProprietaires.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseProprietaires.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCloseProprietaires.Location = new System.Drawing.Point(425, 9);
            this.labelCloseProprietaires.Name = "labelCloseProprietaires";
            this.labelCloseProprietaires.Size = new System.Drawing.Size(18, 18);
            this.labelCloseProprietaires.TabIndex = 36;
            this.labelCloseProprietaires.Text = "X";
            this.labelCloseProprietaires.Click += new System.EventHandler(this.labelCloseProprietaires_Click);
            // 
            // labelProprietaires
            // 
            this.labelProprietaires.AutoSize = true;
            this.labelProprietaires.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProprietaires.Location = new System.Drawing.Point(103, 9);
            this.labelProprietaires.Name = "labelProprietaires";
            this.labelProprietaires.Size = new System.Drawing.Size(202, 30);
            this.labelProprietaires.TabIndex = 35;
            this.labelProprietaires.Text = "Les Propriétaires";
            // 
            // comboBoxIdVille
            // 
            this.comboBoxIdVille.FormattingEnabled = true;
            this.comboBoxIdVille.Location = new System.Drawing.Point(203, 305);
            this.comboBoxIdVille.Name = "comboBoxIdVille";
            this.comboBoxIdVille.Size = new System.Drawing.Size(201, 21);
            this.comboBoxIdVille.TabIndex = 37;
            this.comboBoxIdVille.TextChanged += new System.EventHandler(this.comboBoxSexe_TextChanged);
            // 
            // comboBoxTitre
            // 
            this.comboBoxTitre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTitre.FormattingEnabled = true;
            this.comboBoxTitre.Location = new System.Drawing.Point(203, 337);
            this.comboBoxTitre.Name = "comboBoxTitre";
            this.comboBoxTitre.Size = new System.Drawing.Size(201, 21);
            this.comboBoxTitre.TabIndex = 38;
            // 
            // buttonRAZ
            // 
            this.buttonRAZ.Location = new System.Drawing.Point(183, 399);
            this.buttonRAZ.Name = "buttonRAZ";
            this.buttonRAZ.Size = new System.Drawing.Size(88, 39);
            this.buttonRAZ.TabIndex = 39;
            this.buttonRAZ.Text = "RAZ";
            this.buttonRAZ.UseVisualStyleBackColor = true;
            this.buttonRAZ.Click += new System.EventHandler(this.buttonRAZ_Click);
            // 
            // FormAjouterModifierProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.buttonRAZ);
            this.Controls.Add(this.comboBoxTitre);
            this.Controls.Add(this.labelCloseProprietaires);
            this.Controls.Add(this.labelProprietaires);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.comboBoxSexe);
            this.Controls.Add(this.labelCin);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.labelSexe);
            this.Controls.Add(this.labelVille);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTele);
            this.Controls.Add(this.labelCharge);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.comboBoxVille);
            this.Controls.Add(this.textBoxTele);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxCodePostal);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxCin);
            this.Controls.Add(this.comboBoxIdVille);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAjouterModifierProp";
            this.Text = "FormAjouterModifierProp";
            this.Load += new System.EventHandler(this.FormAjouterModifierProp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxCin;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxCodePostal;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTele;
        private System.Windows.Forms.ComboBox comboBoxVille;
        private System.Windows.Forms.Label labelSexe;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTele;
        private System.Windows.Forms.Label labelCharge;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelCin;
        private System.Windows.Forms.ComboBox comboBoxSexe;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Label labelCloseProprietaires;
        private System.Windows.Forms.Label labelProprietaires;
        private System.Windows.Forms.ComboBox comboBoxIdVille;
        private System.Windows.Forms.ComboBox comboBoxTitre;
        private System.Windows.Forms.Button buttonRAZ;
    }
}