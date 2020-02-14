namespace SYNDIC_1._0
{
    partial class FormAjouterModifierDepense
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
            this.labelCloseDepense = new System.Windows.Forms.Label();
            this.labelDepense = new System.Windows.Forms.Label();
            this.panelValid = new System.Windows.Forms.Panel();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.textBoxTypeDocument = new System.Windows.Forms.TextBox();
            this.labelTypeDocument = new System.Windows.Forms.Label();
            this.textBoxNumDocument = new System.Windows.Forms.TextBox();
            this.comboBoxEmploye = new System.Windows.Forms.ComboBox();
            this.comboBoxSociete = new System.Windows.Forms.ComboBox();
            this.comboBoxTypeDepense = new System.Windows.Forms.ComboBox();
            this.labelNumDocument = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelSociete = new System.Windows.Forms.Label();
            this.labelEmploye = new System.Windows.Forms.Label();
            this.textBoxMontant = new System.Windows.Forms.TextBox();
            this.labelMontant = new System.Windows.Forms.Label();
            this.labelDateDepense = new System.Windows.Forms.Label();
            this.dateTimePickerDepense = new System.Windows.Forms.DateTimePicker();
            this.textBoxDesignationDepense = new System.Windows.Forms.TextBox();
            this.labelDesignationDepense = new System.Windows.Forms.Label();
            this.panelHead.SuspendLayout();
            this.panelValid.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.labelCloseDepense);
            this.panelHead.Controls.Add(this.labelDepense);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(447, 60);
            this.panelHead.TabIndex = 21;
            // 
            // labelCloseDepense
            // 
            this.labelCloseDepense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCloseDepense.AutoSize = true;
            this.labelCloseDepense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseDepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCloseDepense.Location = new System.Drawing.Point(425, 4);
            this.labelCloseDepense.Name = "labelCloseDepense";
            this.labelCloseDepense.Size = new System.Drawing.Size(18, 18);
            this.labelCloseDepense.TabIndex = 1;
            this.labelCloseDepense.Text = "X";
            this.labelCloseDepense.Click += new System.EventHandler(this.labelCloseDepense_Click);
            // 
            // labelDepense
            // 
            this.labelDepense.AutoSize = true;
            this.labelDepense.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepense.Location = new System.Drawing.Point(150, 13);
            this.labelDepense.Name = "labelDepense";
            this.labelDepense.Size = new System.Drawing.Size(120, 30);
            this.labelDepense.TabIndex = 0;
            this.labelDepense.Text = "Dépense";
            // 
            // panelValid
            // 
            this.panelValid.Controls.Add(this.buttonAnnuler);
            this.panelValid.Controls.Add(this.buttonValider);
            this.panelValid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelValid.Location = new System.Drawing.Point(0, 413);
            this.panelValid.Name = "panelValid";
            this.panelValid.Size = new System.Drawing.Size(447, 41);
            this.panelValid.TabIndex = 22;
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
            this.buttonValider.Enabled = false;
            this.buttonValider.Location = new System.Drawing.Point(38, 3);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(139, 35);
            this.buttonValider.TabIndex = 0;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // textBoxTypeDocument
            // 
            this.textBoxTypeDocument.Location = new System.Drawing.Point(161, 342);
            this.textBoxTypeDocument.Name = "textBoxTypeDocument";
            this.textBoxTypeDocument.Size = new System.Drawing.Size(231, 20);
            this.textBoxTypeDocument.TabIndex = 53;
            // 
            // labelTypeDocument
            // 
            this.labelTypeDocument.AutoSize = true;
            this.labelTypeDocument.Location = new System.Drawing.Point(54, 349);
            this.labelTypeDocument.Name = "labelTypeDocument";
            this.labelTypeDocument.Size = new System.Drawing.Size(102, 13);
            this.labelTypeDocument.TabIndex = 52;
            this.labelTypeDocument.Text = "Type de document :";
            // 
            // textBoxNumDocument
            // 
            this.textBoxNumDocument.Location = new System.Drawing.Point(161, 306);
            this.textBoxNumDocument.Name = "textBoxNumDocument";
            this.textBoxNumDocument.Size = new System.Drawing.Size(231, 20);
            this.textBoxNumDocument.TabIndex = 51;
            this.textBoxNumDocument.TextChanged += new System.EventHandler(this.textBoxMontant_TextChanged);
            this.textBoxNumDocument.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumDocument_KeyPress);
            // 
            // comboBoxEmploye
            // 
            this.comboBoxEmploye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmploye.FormattingEnabled = true;
            this.comboBoxEmploye.Location = new System.Drawing.Point(162, 195);
            this.comboBoxEmploye.Name = "comboBoxEmploye";
            this.comboBoxEmploye.Size = new System.Drawing.Size(229, 21);
            this.comboBoxEmploye.TabIndex = 50;
            // 
            // comboBoxSociete
            // 
            this.comboBoxSociete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSociete.FormattingEnabled = true;
            this.comboBoxSociete.Location = new System.Drawing.Point(161, 232);
            this.comboBoxSociete.Name = "comboBoxSociete";
            this.comboBoxSociete.Size = new System.Drawing.Size(231, 21);
            this.comboBoxSociete.TabIndex = 49;
            // 
            // comboBoxTypeDepense
            // 
            this.comboBoxTypeDepense.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeDepense.FormattingEnabled = true;
            this.comboBoxTypeDepense.Location = new System.Drawing.Point(162, 269);
            this.comboBoxTypeDepense.Name = "comboBoxTypeDepense";
            this.comboBoxTypeDepense.Size = new System.Drawing.Size(229, 21);
            this.comboBoxTypeDepense.TabIndex = 48;
            // 
            // labelNumDocument
            // 
            this.labelNumDocument.AutoSize = true;
            this.labelNumDocument.Location = new System.Drawing.Point(54, 312);
            this.labelNumDocument.Name = "labelNumDocument";
            this.labelNumDocument.Size = new System.Drawing.Size(90, 13);
            this.labelNumDocument.TabIndex = 47;
            this.labelNumDocument.Text = "N° de document :";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(54, 275);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(96, 13);
            this.labelType.TabIndex = 46;
            this.labelType.Text = "Type de dépense :";
            // 
            // labelSociete
            // 
            this.labelSociete.AutoSize = true;
            this.labelSociete.Location = new System.Drawing.Point(54, 238);
            this.labelSociete.Name = "labelSociete";
            this.labelSociete.Size = new System.Drawing.Size(49, 13);
            this.labelSociete.TabIndex = 45;
            this.labelSociete.Text = "Société :";
            // 
            // labelEmploye
            // 
            this.labelEmploye.AutoSize = true;
            this.labelEmploye.Location = new System.Drawing.Point(54, 201);
            this.labelEmploye.Name = "labelEmploye";
            this.labelEmploye.Size = new System.Drawing.Size(65, 13);
            this.labelEmploye.TabIndex = 44;
            this.labelEmploye.Text = "Employé(e) :";
            // 
            // textBoxMontant
            // 
            this.textBoxMontant.Location = new System.Drawing.Point(161, 159);
            this.textBoxMontant.Name = "textBoxMontant";
            this.textBoxMontant.Size = new System.Drawing.Size(231, 20);
            this.textBoxMontant.TabIndex = 43;
            this.textBoxMontant.TextChanged += new System.EventHandler(this.textBoxMontant_TextChanged);
            this.textBoxMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMontant_KeyPress);
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.Location = new System.Drawing.Point(54, 164);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(52, 13);
            this.labelMontant.TabIndex = 42;
            this.labelMontant.Text = "Montant :";
            // 
            // labelDateDepense
            // 
            this.labelDateDepense.AutoSize = true;
            this.labelDateDepense.Location = new System.Drawing.Point(54, 127);
            this.labelDateDepense.Name = "labelDateDepense";
            this.labelDateDepense.Size = new System.Drawing.Size(36, 13);
            this.labelDateDepense.TabIndex = 41;
            this.labelDateDepense.Text = "Date :";
            // 
            // dateTimePickerDepense
            // 
            this.dateTimePickerDepense.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDepense.Location = new System.Drawing.Point(161, 123);
            this.dateTimePickerDepense.Name = "dateTimePickerDepense";
            this.dateTimePickerDepense.Size = new System.Drawing.Size(231, 20);
            this.dateTimePickerDepense.TabIndex = 40;
            // 
            // textBoxDesignationDepense
            // 
            this.textBoxDesignationDepense.Location = new System.Drawing.Point(161, 87);
            this.textBoxDesignationDepense.Name = "textBoxDesignationDepense";
            this.textBoxDesignationDepense.Size = new System.Drawing.Size(231, 20);
            this.textBoxDesignationDepense.TabIndex = 39;
            this.textBoxDesignationDepense.TextChanged += new System.EventHandler(this.textBoxMontant_TextChanged);
            this.textBoxDesignationDepense.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDesignationDepense_KeyPress);
            // 
            // labelDesignationDepense
            // 
            this.labelDesignationDepense.AutoSize = true;
            this.labelDesignationDepense.Location = new System.Drawing.Point(54, 90);
            this.labelDesignationDepense.Name = "labelDesignationDepense";
            this.labelDesignationDepense.Size = new System.Drawing.Size(69, 13);
            this.labelDesignationDepense.TabIndex = 38;
            this.labelDesignationDepense.Text = "Désignation :";
            // 
            // FormAjouterModifierDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 454);
            this.Controls.Add(this.textBoxTypeDocument);
            this.Controls.Add(this.labelTypeDocument);
            this.Controls.Add(this.textBoxNumDocument);
            this.Controls.Add(this.comboBoxEmploye);
            this.Controls.Add(this.comboBoxSociete);
            this.Controls.Add(this.comboBoxTypeDepense);
            this.Controls.Add(this.labelNumDocument);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelSociete);
            this.Controls.Add(this.labelEmploye);
            this.Controls.Add(this.textBoxMontant);
            this.Controls.Add(this.labelMontant);
            this.Controls.Add(this.labelDateDepense);
            this.Controls.Add(this.dateTimePickerDepense);
            this.Controls.Add(this.textBoxDesignationDepense);
            this.Controls.Add(this.labelDesignationDepense);
            this.Controls.Add(this.panelValid);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAjouterModifierDepense";
            this.Text = "FormAjouterModifierDepense";
            this.Load += new System.EventHandler(this.FormAjouterModifierDepense_Load);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panelValid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label labelCloseDepense;
        private System.Windows.Forms.Label labelDepense;
        private System.Windows.Forms.Panel panelValid;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.TextBox textBoxTypeDocument;
        private System.Windows.Forms.Label labelTypeDocument;
        private System.Windows.Forms.TextBox textBoxNumDocument;
        private System.Windows.Forms.ComboBox comboBoxEmploye;
        private System.Windows.Forms.ComboBox comboBoxSociete;
        private System.Windows.Forms.ComboBox comboBoxTypeDepense;
        private System.Windows.Forms.Label labelNumDocument;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelSociete;
        private System.Windows.Forms.Label labelEmploye;
        private System.Windows.Forms.TextBox textBoxMontant;
        private System.Windows.Forms.Label labelMontant;
        private System.Windows.Forms.Label labelDateDepense;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepense;
        private System.Windows.Forms.TextBox textBoxDesignationDepense;
        private System.Windows.Forms.Label labelDesignationDepense;
    }
}