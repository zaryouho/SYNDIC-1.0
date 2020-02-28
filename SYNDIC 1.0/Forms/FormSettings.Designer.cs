namespace SYNDIC_1._0
{
    partial class FormSettings
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
            this.panelWrapper = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRestoreFromExternalDrive = new System.Windows.Forms.Button();
            this.buttonBackuptoExternalDrive = new System.Windows.Forms.Button();
            this.comboBoxDataBaseName = new System.Windows.Forms.ComboBox();
            this.labelDataBaseName = new System.Windows.Forms.Label();
            this.comboBoxServerName = new System.Windows.Forms.ComboBox();
            this.labelServerName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelResidence = new System.Windows.Forms.Label();
            this.panelWrapper.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWrapper
            // 
            this.panelWrapper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWrapper.Controls.Add(this.panel2);
            this.panelWrapper.Controls.Add(this.panel1);
            this.panelWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWrapper.Location = new System.Drawing.Point(0, 0);
            this.panelWrapper.Name = "panelWrapper";
            this.panelWrapper.Size = new System.Drawing.Size(800, 450);
            this.panelWrapper.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonRestoreFromExternalDrive);
            this.panel2.Controls.Add(this.buttonBackuptoExternalDrive);
            this.panel2.Controls.Add(this.comboBoxDataBaseName);
            this.panel2.Controls.Add(this.labelDataBaseName);
            this.panel2.Controls.Add(this.comboBoxServerName);
            this.panel2.Controls.Add(this.labelServerName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 396);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Restaurer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sauvegarder";
            // 
            // buttonRestoreFromExternalDrive
            // 
            this.buttonRestoreFromExternalDrive.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestoreFromExternalDrive.Image = global::SYNDIC_1._0.Properties.Resources.restorePNG;
            this.buttonRestoreFromExternalDrive.Location = new System.Drawing.Point(498, 217);
            this.buttonRestoreFromExternalDrive.Name = "buttonRestoreFromExternalDrive";
            this.buttonRestoreFromExternalDrive.Size = new System.Drawing.Size(147, 94);
            this.buttonRestoreFromExternalDrive.TabIndex = 15;
            this.buttonRestoreFromExternalDrive.UseVisualStyleBackColor = true;
            this.buttonRestoreFromExternalDrive.Visible = false;
            this.buttonRestoreFromExternalDrive.Click += new System.EventHandler(this.buttonRestoreFromExternalDrive_Click);
            // 
            // buttonBackuptoExternalDrive
            // 
            this.buttonBackuptoExternalDrive.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackuptoExternalDrive.Image = global::SYNDIC_1._0.Properties.Resources.backupPNG;
            this.buttonBackuptoExternalDrive.Location = new System.Drawing.Point(153, 217);
            this.buttonBackuptoExternalDrive.Name = "buttonBackuptoExternalDrive";
            this.buttonBackuptoExternalDrive.Size = new System.Drawing.Size(147, 93);
            this.buttonBackuptoExternalDrive.TabIndex = 14;
            this.buttonBackuptoExternalDrive.UseVisualStyleBackColor = true;
            this.buttonBackuptoExternalDrive.Click += new System.EventHandler(this.buttonBackuptoExternalDrive_Click);
            // 
            // comboBoxDataBaseName
            // 
            this.comboBoxDataBaseName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDataBaseName.FormattingEnabled = true;
            this.comboBoxDataBaseName.Location = new System.Drawing.Point(309, 118);
            this.comboBoxDataBaseName.Name = "comboBoxDataBaseName";
            this.comboBoxDataBaseName.Size = new System.Drawing.Size(287, 25);
            this.comboBoxDataBaseName.TabIndex = 13;
            // 
            // labelDataBaseName
            // 
            this.labelDataBaseName.AutoSize = true;
            this.labelDataBaseName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataBaseName.Location = new System.Drawing.Point(120, 121);
            this.labelDataBaseName.Name = "labelDataBaseName";
            this.labelDataBaseName.Size = new System.Drawing.Size(183, 17);
            this.labelDataBaseName.TabIndex = 12;
            this.labelDataBaseName.Text = "Nom de la base de données : ";
            // 
            // comboBoxServerName
            // 
            this.comboBoxServerName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxServerName.FormattingEnabled = true;
            this.comboBoxServerName.Location = new System.Drawing.Point(309, 67);
            this.comboBoxServerName.Name = "comboBoxServerName";
            this.comboBoxServerName.Size = new System.Drawing.Size(287, 25);
            this.comboBoxServerName.TabIndex = 11;
            // 
            // labelServerName
            // 
            this.labelServerName.AutoSize = true;
            this.labelServerName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServerName.Location = new System.Drawing.Point(192, 70);
            this.labelServerName.Name = "labelServerName";
            this.labelServerName.Size = new System.Drawing.Size(111, 17);
            this.labelServerName.TabIndex = 10;
            this.labelServerName.Text = "Nom de serveur : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelClose);
            this.panel1.Controls.Add(this.labelResidence);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 52);
            this.panel1.TabIndex = 10;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelClose.Location = new System.Drawing.Point(780, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(18, 18);
            this.labelClose.TabIndex = 4;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // labelResidence
            // 
            this.labelResidence.AutoSize = true;
            this.labelResidence.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResidence.Location = new System.Drawing.Point(323, 8);
            this.labelResidence.Name = "labelResidence";
            this.labelResidence.Size = new System.Drawing.Size(147, 30);
            this.labelResidence.TabIndex = 3;
            this.labelResidence.Text = "Paramètres";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelWrapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.panelWrapper.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWrapper;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelResidence;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRestoreFromExternalDrive;
        private System.Windows.Forms.Button buttonBackuptoExternalDrive;
        private System.Windows.Forms.ComboBox comboBoxDataBaseName;
        private System.Windows.Forms.Label labelDataBaseName;
        private System.Windows.Forms.ComboBox comboBoxServerName;
        private System.Windows.Forms.Label labelServerName;
    }
}