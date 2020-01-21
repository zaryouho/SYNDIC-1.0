namespace SYNDIC_1._0
{
    partial class FormAjouterModifierEcheance
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
            this.labelEcheance = new System.Windows.Forms.Label();
            this.labelMois = new System.Windows.Forms.Label();
            this.labelAnnee = new System.Windows.Forms.Label();
            this.labelMontant = new System.Windows.Forms.Label();
            this.labelMontantRecu = new System.Windows.Forms.Label();
            this.labelNomBien = new System.Windows.Forms.Label();
            this.labelTypeEcheance = new System.Windows.Forms.Label();
            this.textBoxMontant = new System.Windows.Forms.TextBox();
            this.textBoxMontantRecu = new System.Windows.Forms.TextBox();
            this.textBoxNomBien = new System.Windows.Forms.TextBox();
            this.comboBoxAnnee = new System.Windows.Forms.ComboBox();
            this.comboBoxMois = new System.Windows.Forms.ComboBox();
            this.comboBoxTypeEcheance = new System.Windows.Forms.ComboBox();
            this.buttonAddNewTypeEcheance = new System.Windows.Forms.Button();
            this.panelValid = new System.Windows.Forms.Panel();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.panelHead.SuspendLayout();
            this.panelValid.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.labelCloseBiens);
            this.panelHead.Controls.Add(this.labelEcheance);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(447, 60);
            this.panelHead.TabIndex = 4;
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
            // labelEcheance
            // 
            this.labelEcheance.AutoSize = true;
            this.labelEcheance.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEcheance.Location = new System.Drawing.Point(150, 13);
            this.labelEcheance.Name = "labelEcheance";
            this.labelEcheance.Size = new System.Drawing.Size(136, 30);
            this.labelEcheance.TabIndex = 0;
            this.labelEcheance.Text = "Echeance";
            // 
            // labelMois
            // 
            this.labelMois.AutoSize = true;
            this.labelMois.Location = new System.Drawing.Point(57, 80);
            this.labelMois.Name = "labelMois";
            this.labelMois.Size = new System.Drawing.Size(35, 13);
            this.labelMois.TabIndex = 5;
            this.labelMois.Text = "Mois :";
            // 
            // labelAnnee
            // 
            this.labelAnnee.AutoSize = true;
            this.labelAnnee.Location = new System.Drawing.Point(220, 80);
            this.labelAnnee.Name = "labelAnnee";
            this.labelAnnee.Size = new System.Drawing.Size(44, 13);
            this.labelAnnee.TabIndex = 6;
            this.labelAnnee.Text = "Année :";
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.Location = new System.Drawing.Point(57, 116);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(52, 13);
            this.labelMontant.TabIndex = 7;
            this.labelMontant.Text = "Montant :";
            // 
            // labelMontantRecu
            // 
            this.labelMontantRecu.AutoSize = true;
            this.labelMontantRecu.Location = new System.Drawing.Point(57, 152);
            this.labelMontantRecu.Name = "labelMontantRecu";
            this.labelMontantRecu.Size = new System.Drawing.Size(81, 13);
            this.labelMontantRecu.TabIndex = 8;
            this.labelMontantRecu.Text = "Montant Reçu :";
            // 
            // labelNomBien
            // 
            this.labelNomBien.AutoSize = true;
            this.labelNomBien.Location = new System.Drawing.Point(57, 188);
            this.labelNomBien.Name = "labelNomBien";
            this.labelNomBien.Size = new System.Drawing.Size(59, 13);
            this.labelNomBien.TabIndex = 9;
            this.labelNomBien.Text = "Nom Bien :";
            // 
            // labelTypeEcheance
            // 
            this.labelTypeEcheance.AutoSize = true;
            this.labelTypeEcheance.Location = new System.Drawing.Point(57, 224);
            this.labelTypeEcheance.Name = "labelTypeEcheance";
            this.labelTypeEcheance.Size = new System.Drawing.Size(89, 13);
            this.labelTypeEcheance.TabIndex = 10;
            this.labelTypeEcheance.Text = "Type Echeance :";
            // 
            // textBoxMontant
            // 
            this.textBoxMontant.Location = new System.Drawing.Point(155, 113);
            this.textBoxMontant.Name = "textBoxMontant";
            this.textBoxMontant.Size = new System.Drawing.Size(231, 20);
            this.textBoxMontant.TabIndex = 11;
            // 
            // textBoxMontantRecu
            // 
            this.textBoxMontantRecu.Location = new System.Drawing.Point(155, 149);
            this.textBoxMontantRecu.Name = "textBoxMontantRecu";
            this.textBoxMontantRecu.Size = new System.Drawing.Size(231, 20);
            this.textBoxMontantRecu.TabIndex = 12;
            // 
            // textBoxNomBien
            // 
            this.textBoxNomBien.Location = new System.Drawing.Point(155, 185);
            this.textBoxNomBien.Name = "textBoxNomBien";
            this.textBoxNomBien.Size = new System.Drawing.Size(231, 20);
            this.textBoxNomBien.TabIndex = 13;
            // 
            // comboBoxAnnee
            // 
            this.comboBoxAnnee.FormattingEnabled = true;
            this.comboBoxAnnee.Location = new System.Drawing.Point(270, 77);
            this.comboBoxAnnee.Name = "comboBoxAnnee";
            this.comboBoxAnnee.Size = new System.Drawing.Size(116, 21);
            this.comboBoxAnnee.TabIndex = 15;
            // 
            // comboBoxMois
            // 
            this.comboBoxMois.FormattingEnabled = true;
            this.comboBoxMois.Location = new System.Drawing.Point(98, 77);
            this.comboBoxMois.Name = "comboBoxMois";
            this.comboBoxMois.Size = new System.Drawing.Size(116, 21);
            this.comboBoxMois.TabIndex = 16;
            // 
            // comboBoxTypeEcheance
            // 
            this.comboBoxTypeEcheance.FormattingEnabled = true;
            this.comboBoxTypeEcheance.Location = new System.Drawing.Point(155, 221);
            this.comboBoxTypeEcheance.Name = "comboBoxTypeEcheance";
            this.comboBoxTypeEcheance.Size = new System.Drawing.Size(187, 21);
            this.comboBoxTypeEcheance.TabIndex = 17;
            // 
            // buttonAddNewTypeEcheance
            // 
            this.buttonAddNewTypeEcheance.Location = new System.Drawing.Point(348, 221);
            this.buttonAddNewTypeEcheance.Name = "buttonAddNewTypeEcheance";
            this.buttonAddNewTypeEcheance.Size = new System.Drawing.Size(38, 21);
            this.buttonAddNewTypeEcheance.TabIndex = 18;
            this.buttonAddNewTypeEcheance.Text = "...";
            this.buttonAddNewTypeEcheance.UseVisualStyleBackColor = true;
            // 
            // panelValid
            // 
            this.panelValid.Controls.Add(this.buttonAnnuler);
            this.panelValid.Controls.Add(this.buttonValider);
            this.panelValid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelValid.Location = new System.Drawing.Point(0, 258);
            this.panelValid.Name = "panelValid";
            this.panelValid.Size = new System.Drawing.Size(447, 41);
            this.panelValid.TabIndex = 19;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(270, 3);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(139, 35);
            this.buttonAnnuler.TabIndex = 1;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(38, 3);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(139, 35);
            this.buttonValider.TabIndex = 0;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // FormAjouterModifierEcheance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 299);
            this.Controls.Add(this.panelValid);
            this.Controls.Add(this.buttonAddNewTypeEcheance);
            this.Controls.Add(this.comboBoxTypeEcheance);
            this.Controls.Add(this.comboBoxMois);
            this.Controls.Add(this.comboBoxAnnee);
            this.Controls.Add(this.textBoxNomBien);
            this.Controls.Add(this.textBoxMontantRecu);
            this.Controls.Add(this.textBoxMontant);
            this.Controls.Add(this.labelTypeEcheance);
            this.Controls.Add(this.labelNomBien);
            this.Controls.Add(this.labelMontantRecu);
            this.Controls.Add(this.labelMontant);
            this.Controls.Add(this.labelAnnee);
            this.Controls.Add(this.labelMois);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAjouterModifierEcheance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAjouterEcheance";
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panelValid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label labelCloseBiens;
        private System.Windows.Forms.Label labelEcheance;
        private System.Windows.Forms.Label labelMois;
        private System.Windows.Forms.Label labelAnnee;
        private System.Windows.Forms.Label labelMontant;
        private System.Windows.Forms.Label labelMontantRecu;
        private System.Windows.Forms.Label labelNomBien;
        private System.Windows.Forms.Label labelTypeEcheance;
        private System.Windows.Forms.TextBox textBoxMontant;
        private System.Windows.Forms.TextBox textBoxMontantRecu;
        private System.Windows.Forms.TextBox textBoxNomBien;
        private System.Windows.Forms.ComboBox comboBoxAnnee;
        private System.Windows.Forms.ComboBox comboBoxMois;
        private System.Windows.Forms.ComboBox comboBoxTypeEcheance;
        private System.Windows.Forms.Button buttonAddNewTypeEcheance;
        private System.Windows.Forms.Panel panelValid;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonValider;
    }
}