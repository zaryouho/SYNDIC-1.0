namespace SYNDIC_1._0.Forms
{
    partial class FormAjouterModifierSociete
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
            this.panelHead = new System.Windows.Forms.Panel();
            this.labelCloseBiens = new System.Windows.Forms.Label();
            this.labelBiens = new System.Windows.Forms.Label();
            this.labelraison_sociale = new System.Windows.Forms.Label();
            this.labelVille = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labeltel = new System.Windows.Forms.Label();
            this.labelCharge = new System.Windows.Forms.Label();
            this.labelprenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labeladress = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRaz = new System.Windows.Forms.Button();
            this.buttonValdier = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.textBoxRaison_Social = new System.Windows.Forms.TextBox();
            this.textBoxcode_Postal = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.comboBoxVille = new System.Windows.Forms.ComboBox();
            this.comboBoxIdVille = new System.Windows.Forms.ComboBox();
            this.panelHead.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.labelCloseBiens);
            this.panelHead.Controls.Add(this.labelBiens);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(439, 60);
            this.panelHead.TabIndex = 48;
            // 
            // labelCloseBiens
            // 
            this.labelCloseBiens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCloseBiens.AutoSize = true;
            this.labelCloseBiens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseBiens.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCloseBiens.Location = new System.Drawing.Point(417, 4);
            this.labelCloseBiens.Name = "labelCloseBiens";
            this.labelCloseBiens.Size = new System.Drawing.Size(18, 18);
            this.labelCloseBiens.TabIndex = 1;
            this.labelCloseBiens.Text = "X";
            this.labelCloseBiens.Click += new System.EventHandler(this.labelCloseBiens_Click);
            // 
            // labelBiens
            // 
            this.labelBiens.AutoSize = true;
            this.labelBiens.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBiens.Location = new System.Drawing.Point(172, 12);
            this.labelBiens.Name = "labelBiens";
            this.labelBiens.Size = new System.Drawing.Size(103, 30);
            this.labelBiens.TabIndex = 0;
            this.labelBiens.Text = "Societe";
            // 
            // labelraison_sociale
            // 
            this.labelraison_sociale.AutoSize = true;
            this.labelraison_sociale.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelraison_sociale.Location = new System.Drawing.Point(73, 95);
            this.labelraison_sociale.Name = "labelraison_sociale";
            this.labelraison_sociale.Size = new System.Drawing.Size(92, 17);
            this.labelraison_sociale.TabIndex = 67;
            this.labelraison_sociale.Text = "Raison Social :";
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVille.Location = new System.Drawing.Point(125, 319);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(40, 17);
            this.labelVille.TabIndex = 66;
            this.labelVille.Text = "Ville :";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(120, 287);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(45, 17);
            this.labelEmail.TabIndex = 65;
            this.labelEmail.Text = "Email :";
            // 
            // labeltel
            // 
            this.labeltel.AutoSize = true;
            this.labeltel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltel.Location = new System.Drawing.Point(89, 255);
            this.labeltel.Name = "labeltel";
            this.labeltel.Size = new System.Drawing.Size(76, 17);
            this.labeltel.TabIndex = 64;
            this.labeltel.Text = "Telephone :";
            // 
            // labelCharge
            // 
            this.labelCharge.AutoSize = true;
            this.labelCharge.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharge.Location = new System.Drawing.Point(79, 223);
            this.labelCharge.Name = "labelCharge";
            this.labelCharge.Size = new System.Drawing.Size(86, 17);
            this.labelCharge.TabIndex = 63;
            this.labelCharge.Text = "Code Postal :";
            // 
            // labelprenom
            // 
            this.labelprenom.AutoSize = true;
            this.labelprenom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprenom.Location = new System.Drawing.Point(34, 159);
            this.labelprenom.Name = "labelprenom";
            this.labelprenom.Size = new System.Drawing.Size(131, 17);
            this.labelprenom.TabIndex = 61;
            this.labelprenom.Text = "Prenom de Societe  :";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(54, 127);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(111, 17);
            this.labelNom.TabIndex = 60;
            this.labelNom.Text = "Nom de Societe :";
            // 
            // labeladress
            // 
            this.labeladress.AutoSize = true;
            this.labeladress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladress.Location = new System.Drawing.Point(101, 191);
            this.labeladress.Name = "labeladress";
            this.labeladress.Size = new System.Drawing.Size(64, 17);
            this.labeladress.TabIndex = 62;
            this.labeladress.Text = "Adresse  :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRaz);
            this.panel1.Controls.Add(this.buttonValdier);
            this.panel1.Controls.Add(this.buttonAnnuler);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(68, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 76);
            this.panel1.TabIndex = 68;
            // 
            // buttonRaz
            // 
            this.buttonRaz.Location = new System.Drawing.Point(89, 35);
            this.buttonRaz.Name = "buttonRaz";
            this.buttonRaz.Size = new System.Drawing.Size(118, 23);
            this.buttonRaz.TabIndex = 2;
            this.buttonRaz.Text = "Raz";
            this.buttonRaz.UseVisualStyleBackColor = true;
            this.buttonRaz.Click += new System.EventHandler(this.buttonRaz_Click);
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
            // textBoxRaison_Social
            // 
            this.textBoxRaison_Social.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRaison_Social.Location = new System.Drawing.Point(182, 91);
            this.textBoxRaison_Social.Name = "textBoxRaison_Social";
            this.textBoxRaison_Social.Size = new System.Drawing.Size(200, 22);
            this.textBoxRaison_Social.TabIndex = 69;
            this.textBoxRaison_Social.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged_1);
            this.textBoxRaison_Social.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRaison_Social_KeyPress);
            // 
            // textBoxcode_Postal
            // 
            this.textBoxcode_Postal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcode_Postal.Location = new System.Drawing.Point(182, 223);
            this.textBoxcode_Postal.Name = "textBoxcode_Postal";
            this.textBoxcode_Postal.Size = new System.Drawing.Size(200, 22);
            this.textBoxcode_Postal.TabIndex = 70;
            this.textBoxcode_Postal.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged_1);
            this.textBoxcode_Postal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcode_Postal_KeyPress);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(182, 191);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(200, 22);
            this.textBoxAddress.TabIndex = 71;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged_1);
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrenom.Location = new System.Drawing.Point(182, 159);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(200, 22);
            this.textBoxPrenom.TabIndex = 72;
            this.textBoxPrenom.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged_1);
            this.textBoxPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrenom_KeyPress);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(182, 127);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(200, 22);
            this.textBoxNom.TabIndex = 73;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged_1);
            this.textBoxNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrenom_KeyPress);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(182, 287);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 22);
            this.textBoxEmail.TabIndex = 74;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged_1);
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelephone.Location = new System.Drawing.Point(182, 255);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(200, 22);
            this.textBoxTelephone.TabIndex = 75;
            this.textBoxTelephone.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged_1);
            this.textBoxTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelephone_KeyPress);
            // 
            // comboBoxVille
            // 
            this.comboBoxVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVille.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVille.FormattingEnabled = true;
            this.comboBoxVille.Location = new System.Drawing.Point(182, 318);
            this.comboBoxVille.Name = "comboBoxVille";
            this.comboBoxVille.Size = new System.Drawing.Size(200, 25);
            this.comboBoxVille.TabIndex = 76;
            // 
            // comboBoxIdVille
            // 
            this.comboBoxIdVille.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIdVille.FormattingEnabled = true;
            this.comboBoxIdVille.Location = new System.Drawing.Point(182, 318);
            this.comboBoxIdVille.Name = "comboBoxIdVille";
            this.comboBoxIdVille.Size = new System.Drawing.Size(200, 25);
            this.comboBoxIdVille.TabIndex = 77;
            // 
            // FormAjouterModifierSociete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(439, 443);
            this.Controls.Add(this.comboBoxVille);
            this.Controls.Add(this.comboBoxIdVille);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxcode_Postal);
            this.Controls.Add(this.textBoxRaison_Social);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelraison_sociale);
            this.Controls.Add(this.labelVille);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labeltel);
            this.Controls.Add(this.labelCharge);
            this.Controls.Add(this.labelprenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labeladress);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAjouterModifierSociete";
            this.Text = "FormAjouterModifierSociete";
            this.Load += new System.EventHandler(this.FormAjouterModifierSociete_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrenom_KeyPress);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label labelCloseBiens;
        private System.Windows.Forms.Label labelBiens;
        private System.Windows.Forms.Label labelraison_sociale;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labeltel;
        private System.Windows.Forms.Label labelCharge;
        private System.Windows.Forms.Label labelprenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labeladress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRaz;
        private System.Windows.Forms.Button buttonValdier;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.TextBox textBoxRaison_Social;
        private System.Windows.Forms.TextBox textBoxcode_Postal;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.ComboBox comboBoxVille;
        private System.Windows.Forms.ComboBox comboBoxIdVille;
    }
}