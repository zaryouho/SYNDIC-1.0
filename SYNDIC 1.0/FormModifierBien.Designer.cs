namespace SYNDIC_1._0
{
    partial class FormModifierBien
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
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxEtage = new System.Windows.Forms.TextBox();
            this.labelEtage = new System.Windows.Forms.Label();
            this.textBoxSuperficie = new System.Windows.Forms.TextBox();
            this.labelSuperficie = new System.Windows.Forms.Label();
            this.textBoxCharge = new System.Windows.Forms.TextBox();
            this.labelCharge = new System.Windows.Forms.Label();
            this.textBoxTypeBien = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxIdImmeuble = new System.Windows.Forms.TextBox();
            this.labelImmeuble = new System.Windows.Forms.Label();
            this.labelProprietaire = new System.Windows.Forms.Label();
            this.textBoxTitre = new System.Windows.Forms.TextBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddNewProprietaire = new System.Windows.Forms.Button();
            this.dateTimePickerDateAchat = new System.Windows.Forms.DateTimePicker();
            this.comboBoxProprietaire = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonValdier = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.textBoxIdProprietaire = new System.Windows.Forms.TextBox();
            this.textBoxIdBien = new System.Windows.Forms.TextBox();
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
            this.panelHead.Size = new System.Drawing.Size(447, 60);
            this.panelHead.TabIndex = 3;
            // 
            // labelCloseBiens
            // 
            this.labelCloseBiens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCloseBiens.AutoSize = true;
            this.labelCloseBiens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseBiens.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCloseBiens.Location = new System.Drawing.Point(425, 4);
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
            this.labelBiens.Size = new System.Drawing.Size(76, 30);
            this.labelBiens.TabIndex = 0;
            this.labelBiens.Text = "BIENS";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(41, 121);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(74, 13);
            this.labelNom.TabIndex = 4;
            this.labelNom.Text = "Nom de Bien :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Enabled = false;
            this.textBoxNom.Location = new System.Drawing.Point(156, 118);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(206, 20);
            this.textBoxNom.TabIndex = 5;
            // 
            // textBoxEtage
            // 
            this.textBoxEtage.Enabled = false;
            this.textBoxEtage.Location = new System.Drawing.Point(156, 150);
            this.textBoxEtage.Name = "textBoxEtage";
            this.textBoxEtage.Size = new System.Drawing.Size(206, 20);
            this.textBoxEtage.TabIndex = 7;
            // 
            // labelEtage
            // 
            this.labelEtage.AutoSize = true;
            this.labelEtage.Location = new System.Drawing.Point(41, 153);
            this.labelEtage.Name = "labelEtage";
            this.labelEtage.Size = new System.Drawing.Size(80, 13);
            this.labelEtage.TabIndex = 6;
            this.labelEtage.Text = "Etage de Bien :";
            // 
            // textBoxSuperficie
            // 
            this.textBoxSuperficie.Enabled = false;
            this.textBoxSuperficie.Location = new System.Drawing.Point(156, 182);
            this.textBoxSuperficie.Name = "textBoxSuperficie";
            this.textBoxSuperficie.Size = new System.Drawing.Size(206, 20);
            this.textBoxSuperficie.TabIndex = 9;
            // 
            // labelSuperficie
            // 
            this.labelSuperficie.AutoSize = true;
            this.labelSuperficie.Location = new System.Drawing.Point(41, 185);
            this.labelSuperficie.Name = "labelSuperficie";
            this.labelSuperficie.Size = new System.Drawing.Size(99, 13);
            this.labelSuperficie.TabIndex = 8;
            this.labelSuperficie.Text = "Superficie de Bien :";
            // 
            // textBoxCharge
            // 
            this.textBoxCharge.Enabled = false;
            this.textBoxCharge.Location = new System.Drawing.Point(156, 214);
            this.textBoxCharge.Name = "textBoxCharge";
            this.textBoxCharge.Size = new System.Drawing.Size(206, 20);
            this.textBoxCharge.TabIndex = 11;
            // 
            // labelCharge
            // 
            this.labelCharge.AutoSize = true;
            this.labelCharge.Location = new System.Drawing.Point(41, 217);
            this.labelCharge.Name = "labelCharge";
            this.labelCharge.Size = new System.Drawing.Size(86, 13);
            this.labelCharge.TabIndex = 10;
            this.labelCharge.Text = "Charge de Bien :";
            // 
            // textBoxTypeBien
            // 
            this.textBoxTypeBien.Enabled = false;
            this.textBoxTypeBien.Location = new System.Drawing.Point(156, 246);
            this.textBoxTypeBien.Name = "textBoxTypeBien";
            this.textBoxTypeBien.Size = new System.Drawing.Size(206, 20);
            this.textBoxTypeBien.TabIndex = 13;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(41, 249);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(76, 13);
            this.labelType.TabIndex = 12;
            this.labelType.Text = "Type de Bien :";
            // 
            // textBoxIdImmeuble
            // 
            this.textBoxIdImmeuble.Enabled = false;
            this.textBoxIdImmeuble.Location = new System.Drawing.Point(156, 278);
            this.textBoxIdImmeuble.Name = "textBoxIdImmeuble";
            this.textBoxIdImmeuble.Size = new System.Drawing.Size(206, 20);
            this.textBoxIdImmeuble.TabIndex = 15;
            // 
            // labelImmeuble
            // 
            this.labelImmeuble.AutoSize = true;
            this.labelImmeuble.Location = new System.Drawing.Point(41, 281);
            this.labelImmeuble.Name = "labelImmeuble";
            this.labelImmeuble.Size = new System.Drawing.Size(58, 13);
            this.labelImmeuble.TabIndex = 14;
            this.labelImmeuble.Text = "Immeuble :";
            // 
            // labelProprietaire
            // 
            this.labelProprietaire.AutoSize = true;
            this.labelProprietaire.Location = new System.Drawing.Point(41, 313);
            this.labelProprietaire.Name = "labelProprietaire";
            this.labelProprietaire.Size = new System.Drawing.Size(105, 13);
            this.labelProprietaire.TabIndex = 16;
            this.labelProprietaire.Text = "Proprietaire de Bien :";
            // 
            // textBoxTitre
            // 
            this.textBoxTitre.Enabled = false;
            this.textBoxTitre.Location = new System.Drawing.Point(156, 86);
            this.textBoxTitre.Name = "textBoxTitre";
            this.textBoxTitre.Size = new System.Drawing.Size(206, 20);
            this.textBoxTitre.TabIndex = 19;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Location = new System.Drawing.Point(41, 89);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(73, 13);
            this.labelTitre.TabIndex = 18;
            this.labelTitre.Text = "Titre de Bien :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Date d\'achat de Bien :";
            // 
            // buttonAddNewProprietaire
            // 
            this.buttonAddNewProprietaire.Location = new System.Drawing.Point(337, 310);
            this.buttonAddNewProprietaire.Name = "buttonAddNewProprietaire";
            this.buttonAddNewProprietaire.Size = new System.Drawing.Size(25, 20);
            this.buttonAddNewProprietaire.TabIndex = 21;
            this.buttonAddNewProprietaire.Text = "...";
            this.buttonAddNewProprietaire.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDateAchat
            // 
            this.dateTimePickerDateAchat.Location = new System.Drawing.Point(156, 339);
            this.dateTimePickerDateAchat.Name = "dateTimePickerDateAchat";
            this.dateTimePickerDateAchat.Size = new System.Drawing.Size(206, 20);
            this.dateTimePickerDateAchat.TabIndex = 22;
            // 
            // comboBoxProprietaire
            // 
            this.comboBoxProprietaire.FormattingEnabled = true;
            this.comboBoxProprietaire.Location = new System.Drawing.Point(156, 310);
            this.comboBoxProprietaire.Name = "comboBoxProprietaire";
            this.comboBoxProprietaire.Size = new System.Drawing.Size(175, 21);
            this.comboBoxProprietaire.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonValdier);
            this.panel1.Controls.Add(this.buttonAnnuler);
            this.panel1.Location = new System.Drawing.Point(69, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 32);
            this.panel1.TabIndex = 24;
            // 
            // buttonValdier
            // 
            this.buttonValdier.Location = new System.Drawing.Point(14, 6);
            this.buttonValdier.Name = "buttonValdier";
            this.buttonValdier.Size = new System.Drawing.Size(118, 23);
            this.buttonValdier.TabIndex = 1;
            this.buttonValdier.Text = "Valider";
            this.buttonValdier.UseVisualStyleBackColor = true;
            this.buttonValdier.Click += new System.EventHandler(this.labelCloseBiens_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(160, 6);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(118, 23);
            this.buttonAnnuler.TabIndex = 0;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.labelCloseBiens_Click);
            // 
            // textBoxIdProprietaire
            // 
            this.textBoxIdProprietaire.Location = new System.Drawing.Point(380, 427);
            this.textBoxIdProprietaire.Name = "textBoxIdProprietaire";
            this.textBoxIdProprietaire.Size = new System.Drawing.Size(63, 20);
            this.textBoxIdProprietaire.TabIndex = 25;
            this.textBoxIdProprietaire.Visible = false;
            // 
            // textBoxIdBien
            // 
            this.textBoxIdBien.Location = new System.Drawing.Point(289, 427);
            this.textBoxIdBien.Name = "textBoxIdBien";
            this.textBoxIdBien.Size = new System.Drawing.Size(73, 20);
            this.textBoxIdBien.TabIndex = 26;
            this.textBoxIdBien.Visible = false;
            // 
            // FormModifierBien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.textBoxIdBien);
            this.Controls.Add(this.textBoxIdProprietaire);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxProprietaire);
            this.Controls.Add(this.dateTimePickerDateAchat);
            this.Controls.Add(this.buttonAddNewProprietaire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitre);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.labelProprietaire);
            this.Controls.Add(this.textBoxIdImmeuble);
            this.Controls.Add(this.labelImmeuble);
            this.Controls.Add(this.textBoxTypeBien);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxCharge);
            this.Controls.Add(this.labelCharge);
            this.Controls.Add(this.textBoxSuperficie);
            this.Controls.Add(this.labelSuperficie);
            this.Controls.Add(this.textBoxEtage);
            this.Controls.Add(this.labelEtage);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormModifierBien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormModifierBien";
            this.Load += new System.EventHandler(this.FormModifierBien_Load);
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
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxEtage;
        private System.Windows.Forms.Label labelEtage;
        private System.Windows.Forms.TextBox textBoxSuperficie;
        private System.Windows.Forms.Label labelSuperficie;
        private System.Windows.Forms.TextBox textBoxCharge;
        private System.Windows.Forms.Label labelCharge;
        private System.Windows.Forms.TextBox textBoxTypeBien;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxIdImmeuble;
        private System.Windows.Forms.Label labelImmeuble;
        private System.Windows.Forms.Label labelProprietaire;
        private System.Windows.Forms.TextBox textBoxTitre;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddNewProprietaire;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateAchat;
        private System.Windows.Forms.ComboBox comboBoxProprietaire;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonValdier;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.TextBox textBoxIdProprietaire;
        private System.Windows.Forms.TextBox textBoxIdBien;
    }
}