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
            this.textBoxCin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCin.Location = new System.Drawing.Point(171, 72);
            this.textBoxCin.Name = "textBoxCin";
            this.textBoxCin.Size = new System.Drawing.Size(201, 22);
            this.textBoxCin.TabIndex = 0;
            this.textBoxCin.TextChanged += new System.EventHandler(this.comboBoxSexe_TextChanged);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(171, 101);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(201, 22);
            this.textBoxNom.TabIndex = 1;
            this.textBoxNom.TextChanged += new System.EventHandler(this.comboBoxSexe_TextChanged);
            this.textBoxNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrenom_KeyPress);
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrenom.Location = new System.Drawing.Point(171, 130);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(201, 22);
            this.textBoxPrenom.TabIndex = 2;
            this.textBoxPrenom.TextChanged += new System.EventHandler(this.comboBoxSexe_TextChanged);
            this.textBoxPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrenom_KeyPress);
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdresse.Location = new System.Drawing.Point(171, 189);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(201, 22);
            this.textBoxAdresse.TabIndex = 4;
            this.textBoxAdresse.TextChanged += new System.EventHandler(this.comboBoxSexe_TextChanged);
            // 
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodePostal.Location = new System.Drawing.Point(171, 218);
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(201, 22);
            this.textBoxCodePostal.TabIndex = 5;
            this.textBoxCodePostal.TextChanged += new System.EventHandler(this.comboBoxSexe_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(171, 276);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(201, 22);
            this.textBoxEmail.TabIndex = 7;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.comboBoxSexe_TextChanged);
            // 
            // textBoxTele
            // 
            this.textBoxTele.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTele.Location = new System.Drawing.Point(171, 247);
            this.textBoxTele.Name = "textBoxTele";
            this.textBoxTele.Size = new System.Drawing.Size(201, 22);
            this.textBoxTele.TabIndex = 6;
            this.textBoxTele.TextChanged += new System.EventHandler(this.comboBoxSexe_TextChanged);
            this.textBoxTele.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTele_KeyPress);
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVille.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Location = new System.Drawing.Point(171, 304);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(201, 25);
            this.comboBoxVille.TabIndex = 8;
            this.comboBoxVille.SelectedIndexChanged += new System.EventHandler(this.comboBoxVille_SelectedIndexChanged);
            this.comboBoxVille.TextChanged += new System.EventHandler(this.comboBoxSexe_TextChanged);
            // 
            // labelSexe
            // 
            this.labelSexe.AutoSize = true;
            this.labelSexe.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexe.Location = new System.Drawing.Point(108, 163);
            this.labelSexe.Name = "labelSexe";
            this.labelSexe.Size = new System.Drawing.Size(43, 17);
            this.labelSexe.TabIndex = 29;
            this.labelSexe.Text = "Sexe :";
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVille.Location = new System.Drawing.Point(111, 308);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(40, 17);
            this.labelVille.TabIndex = 27;
            this.labelVille.Text = "Ville :";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(106, 279);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(45, 17);
            this.labelEmail.TabIndex = 26;
            this.labelEmail.Text = "Email :";
            // 
            // labelTele
            // 
            this.labelTele.AutoSize = true;
            this.labelTele.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTele.Location = new System.Drawing.Point(113, 250);
            this.labelTele.Name = "labelTele";
            this.labelTele.Size = new System.Drawing.Size(38, 17);
            this.labelTele.TabIndex = 25;
            this.labelTele.Text = "Tele :";
            // 
            // labelCharge
            // 
            this.labelCharge.AutoSize = true;
            this.labelCharge.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharge.Location = new System.Drawing.Point(65, 221);
            this.labelCharge.Name = "labelCharge";
            this.labelCharge.Size = new System.Drawing.Size(86, 17);
            this.labelCharge.TabIndex = 24;
            this.labelCharge.Text = "Code Postal :";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresse.Location = new System.Drawing.Point(90, 192);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(61, 17);
            this.labelAdresse.TabIndex = 23;
            this.labelAdresse.Text = "Adresse :";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.Location = new System.Drawing.Point(92, 134);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(59, 17);
            this.labelPrenom.TabIndex = 22;
            this.labelPrenom.Text = "Prénom :";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(106, 105);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(45, 17);
            this.labelNom.TabIndex = 21;
            this.labelNom.Text = "Nom  :";
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(112, 337);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(39, 17);
            this.labelTitre.TabIndex = 30;
            this.labelTitre.Text = "Titre :";
            // 
            // labelCin
            // 
            this.labelCin.AutoSize = true;
            this.labelCin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCin.Location = new System.Drawing.Point(121, 76);
            this.labelCin.Name = "labelCin";
            this.labelCin.Size = new System.Drawing.Size(30, 17);
            this.labelCin.TabIndex = 31;
            this.labelCin.Text = "Cin:";
            // 
            // comboBoxSexe
            // 
            this.comboBoxSexe.BackColor = System.Drawing.Color.White;
            this.comboBoxSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSexe.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSexe.FormattingEnabled = true;
            this.comboBoxSexe.Location = new System.Drawing.Point(171, 159);
            this.comboBoxSexe.Name = "comboBoxSexe";
            this.comboBoxSexe.Size = new System.Drawing.Size(201, 25);
            this.comboBoxSexe.TabIndex = 3;
            this.comboBoxSexe.TextChanged += new System.EventHandler(this.comboBoxSexe_TextChanged);
            // 
            // buttonValider
            // 
            this.buttonValider.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValider.Image = global::SYNDIC_1._0.Properties.Resources.valider;
            this.buttonValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonValider.Location = new System.Drawing.Point(25, 399);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(149, 39);
            this.buttonValider.TabIndex = 12;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.Image = global::SYNDIC_1._0.Properties.Resources.DeleteReddd;
            this.buttonAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnnuler.Location = new System.Drawing.Point(180, 399);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(149, 39);
            this.buttonAnnuler.TabIndex = 11;
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
            this.labelCloseProprietaires.TabIndex = 13;
            this.labelCloseProprietaires.Text = "X";
            this.labelCloseProprietaires.Click += new System.EventHandler(this.labelCloseProprietaires_Click);
            // 
            // labelProprietaires
            // 
            this.labelProprietaires.AutoSize = true;
            this.labelProprietaires.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProprietaires.Location = new System.Drawing.Point(127, 9);
            this.labelProprietaires.Name = "labelProprietaires";
            this.labelProprietaires.Size = new System.Drawing.Size(181, 30);
            this.labelProprietaires.TabIndex = 35;
            this.labelProprietaires.Text = "Propriétaire(e)";
            // 
            // comboBoxIdVille
            // 
            this.comboBoxIdVille.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIdVille.FormattingEnabled = true;
            this.comboBoxIdVille.Location = new System.Drawing.Point(171, 304);
            this.comboBoxIdVille.Name = "comboBoxIdVille";
            this.comboBoxIdVille.Size = new System.Drawing.Size(201, 25);
            this.comboBoxIdVille.TabIndex = 37;
            this.comboBoxIdVille.TextChanged += new System.EventHandler(this.comboBoxSexe_TextChanged);
            // 
            // comboBoxTitre
            // 
            this.comboBoxTitre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTitre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTitre.FormattingEnabled = true;
            this.comboBoxTitre.Location = new System.Drawing.Point(171, 336);
            this.comboBoxTitre.Name = "comboBoxTitre";
            this.comboBoxTitre.Size = new System.Drawing.Size(201, 25);
            this.comboBoxTitre.TabIndex = 9;
            // 
            // buttonRAZ
            // 
            this.buttonRAZ.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRAZ.Location = new System.Drawing.Point(372, 399);
            this.buttonRAZ.Name = "buttonRAZ";
            this.buttonRAZ.Size = new System.Drawing.Size(71, 39);
            this.buttonRAZ.TabIndex = 10;
            this.buttonRAZ.Text = "RAZ";
            this.buttonRAZ.UseVisualStyleBackColor = true;
            this.buttonRAZ.Click += new System.EventHandler(this.buttonRAZ_Click);
            // 
            // FormAjouterModifierProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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