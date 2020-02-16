namespace SYNDIC_1._0
{
    partial class FormAjouterModifierIntervention
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
            this.labelIntervention = new System.Windows.Forms.Label();
            this.panelValid = new System.Windows.Forms.Panel();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.labelDateFinIntervention = new System.Windows.Forms.Label();
            this.dateTimePickerFinIntervention = new System.Windows.Forms.DateTimePicker();
            this.textBoxMontantIntervention = new System.Windows.Forms.TextBox();
            this.labelMontant = new System.Windows.Forms.Label();
            this.labelDateDebutIntervention = new System.Windows.Forms.Label();
            this.textBoxDesignationDepense = new System.Windows.Forms.TextBox();
            this.labelDesignationDepense = new System.Windows.Forms.Label();
            this.dateTimePickerDebutIntervention = new System.Windows.Forms.DateTimePicker();
            this.comboBoxIdDepense = new System.Windows.Forms.ComboBox();
            this.labelidDepense = new System.Windows.Forms.Label();
            this.panelHead.SuspendLayout();
            this.panelValid.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.labelCloseDepense);
            this.panelHead.Controls.Add(this.labelIntervention);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(447, 60);
            this.panelHead.TabIndex = 37;
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
            // labelIntervention
            // 
            this.labelIntervention.AutoSize = true;
            this.labelIntervention.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntervention.Location = new System.Drawing.Point(150, 13);
            this.labelIntervention.Name = "labelIntervention";
            this.labelIntervention.Size = new System.Drawing.Size(156, 30);
            this.labelIntervention.TabIndex = 0;
            this.labelIntervention.Text = "Intervention";
            // 
            // panelValid
            // 
            this.panelValid.Controls.Add(this.buttonAnnuler);
            this.panelValid.Controls.Add(this.buttonValider);
            this.panelValid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelValid.Location = new System.Drawing.Point(0, 269);
            this.panelValid.Name = "panelValid";
            this.panelValid.Size = new System.Drawing.Size(447, 41);
            this.panelValid.TabIndex = 38;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.Image = global::SYNDIC_1._0.Properties.Resources.DeleteReddd;
            this.buttonAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.buttonValider.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValider.Image = global::SYNDIC_1._0.Properties.Resources.valider;
            this.buttonValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonValider.Location = new System.Drawing.Point(38, 3);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(139, 35);
            this.buttonValider.TabIndex = 0;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // labelDateFinIntervention
            // 
            this.labelDateFinIntervention.AutoSize = true;
            this.labelDateFinIntervention.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFinIntervention.Location = new System.Drawing.Point(61, 162);
            this.labelDateFinIntervention.Name = "labelDateFinIntervention";
            this.labelDateFinIntervention.Size = new System.Drawing.Size(61, 17);
            this.labelDateFinIntervention.TabIndex = 53;
            this.labelDateFinIntervention.Text = "Date fin :";
            // 
            // dateTimePickerFinIntervention
            // 
            this.dateTimePickerFinIntervention.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFinIntervention.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFinIntervention.Location = new System.Drawing.Point(157, 157);
            this.dateTimePickerFinIntervention.Name = "dateTimePickerFinIntervention";
            this.dateTimePickerFinIntervention.Size = new System.Drawing.Size(231, 22);
            this.dateTimePickerFinIntervention.TabIndex = 52;
            this.dateTimePickerFinIntervention.ValueChanged += new System.EventHandler(this.dateTimePickerFinIntervention_ValueChanged);
            // 
            // textBoxMontantIntervention
            // 
            this.textBoxMontantIntervention.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMontantIntervention.Location = new System.Drawing.Point(157, 195);
            this.textBoxMontantIntervention.Name = "textBoxMontantIntervention";
            this.textBoxMontantIntervention.Size = new System.Drawing.Size(231, 22);
            this.textBoxMontantIntervention.TabIndex = 51;
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontant.Location = new System.Drawing.Point(57, 201);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(65, 17);
            this.labelMontant.TabIndex = 50;
            this.labelMontant.Text = "Montant :";
            // 
            // labelDateDebutIntervention
            // 
            this.labelDateDebutIntervention.AutoSize = true;
            this.labelDateDebutIntervention.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateDebutIntervention.Location = new System.Drawing.Point(39, 123);
            this.labelDateDebutIntervention.Name = "labelDateDebutIntervention";
            this.labelDateDebutIntervention.Size = new System.Drawing.Size(83, 17);
            this.labelDateDebutIntervention.TabIndex = 49;
            this.labelDateDebutIntervention.Text = "Date début :";
            // 
            // textBoxDesignationDepense
            // 
            this.textBoxDesignationDepense.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDesignationDepense.Location = new System.Drawing.Point(157, 81);
            this.textBoxDesignationDepense.Name = "textBoxDesignationDepense";
            this.textBoxDesignationDepense.Size = new System.Drawing.Size(231, 22);
            this.textBoxDesignationDepense.TabIndex = 47;
            // 
            // labelDesignationDepense
            // 
            this.labelDesignationDepense.AutoSize = true;
            this.labelDesignationDepense.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesignationDepense.Location = new System.Drawing.Point(37, 84);
            this.labelDesignationDepense.Name = "labelDesignationDepense";
            this.labelDesignationDepense.Size = new System.Drawing.Size(85, 17);
            this.labelDesignationDepense.TabIndex = 46;
            this.labelDesignationDepense.Text = "Désignation :";
            // 
            // dateTimePickerDebutIntervention
            // 
            this.dateTimePickerDebutIntervention.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDebutIntervention.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDebutIntervention.Location = new System.Drawing.Point(157, 119);
            this.dateTimePickerDebutIntervention.Name = "dateTimePickerDebutIntervention";
            this.dateTimePickerDebutIntervention.Size = new System.Drawing.Size(231, 22);
            this.dateTimePickerDebutIntervention.TabIndex = 48;
            this.dateTimePickerDebutIntervention.ValueChanged += new System.EventHandler(this.dateTimePickerFinIntervention_ValueChanged);
            // 
            // comboBoxIdDepense
            // 
            this.comboBoxIdDepense.FormattingEnabled = true;
            this.comboBoxIdDepense.Location = new System.Drawing.Point(155, 233);
            this.comboBoxIdDepense.Name = "comboBoxIdDepense";
            this.comboBoxIdDepense.Size = new System.Drawing.Size(233, 21);
            this.comboBoxIdDepense.TabIndex = 57;
            // 
            // labelidDepense
            // 
            this.labelidDepense.AutoSize = true;
            this.labelidDepense.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidDepense.Location = new System.Drawing.Point(55, 234);
            this.labelidDepense.Name = "labelidDepense";
            this.labelidDepense.Size = new System.Drawing.Size(67, 17);
            this.labelidDepense.TabIndex = 58;
            this.labelidDepense.Text = "Depense :";
            // 
            // FormAjouterModifierIntervention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(447, 310);
            this.Controls.Add(this.labelidDepense);
            this.Controls.Add(this.comboBoxIdDepense);
            this.Controls.Add(this.labelDateFinIntervention);
            this.Controls.Add(this.dateTimePickerFinIntervention);
            this.Controls.Add(this.textBoxMontantIntervention);
            this.Controls.Add(this.labelMontant);
            this.Controls.Add(this.labelDateDebutIntervention);
            this.Controls.Add(this.textBoxDesignationDepense);
            this.Controls.Add(this.labelDesignationDepense);
            this.Controls.Add(this.dateTimePickerDebutIntervention);
            this.Controls.Add(this.panelValid);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAjouterModifierIntervention";
            this.Text = "FormAjouterModifierIntervention";
            this.Load += new System.EventHandler(this.FormAjouterModifierIntervention_Load);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panelValid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label labelCloseDepense;
        private System.Windows.Forms.Label labelIntervention;
        private System.Windows.Forms.Panel panelValid;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Label labelDateFinIntervention;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinIntervention;
        private System.Windows.Forms.TextBox textBoxMontantIntervention;
        private System.Windows.Forms.Label labelMontant;
        private System.Windows.Forms.Label labelDateDebutIntervention;
        private System.Windows.Forms.TextBox textBoxDesignationDepense;
        private System.Windows.Forms.Label labelDesignationDepense;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebutIntervention;
        private System.Windows.Forms.ComboBox comboBoxIdDepense;
        private System.Windows.Forms.Label labelidDepense;
    }
}