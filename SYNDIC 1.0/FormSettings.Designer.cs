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
            this.buttonRestore = new System.Windows.Forms.Button();
            this.buttonBackupDataBase = new System.Windows.Forms.Button();
            this.comboBoxDataBaseName = new System.Windows.Forms.ComboBox();
            this.labelDataBaseName = new System.Windows.Forms.Label();
            this.comboBoxServerName = new System.Windows.Forms.ComboBox();
            this.labelServerName = new System.Windows.Forms.Label();
            this.panelWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWrapper
            // 
            this.panelWrapper.Controls.Add(this.buttonRestore);
            this.panelWrapper.Controls.Add(this.buttonBackupDataBase);
            this.panelWrapper.Controls.Add(this.comboBoxDataBaseName);
            this.panelWrapper.Controls.Add(this.labelDataBaseName);
            this.panelWrapper.Controls.Add(this.comboBoxServerName);
            this.panelWrapper.Controls.Add(this.labelServerName);
            this.panelWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWrapper.Location = new System.Drawing.Point(0, 0);
            this.panelWrapper.Name = "panelWrapper";
            this.panelWrapper.Size = new System.Drawing.Size(800, 450);
            this.panelWrapper.TabIndex = 0;
            this.panelWrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWrapper_Paint);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Location = new System.Drawing.Point(281, 194);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(75, 23);
            this.buttonRestore.TabIndex = 5;
            this.buttonRestore.Text = "Restore ";
            this.buttonRestore.UseVisualStyleBackColor = true;
            // 
            // buttonBackupDataBase
            // 
            this.buttonBackupDataBase.Location = new System.Drawing.Point(188, 194);
            this.buttonBackupDataBase.Name = "buttonBackupDataBase";
            this.buttonBackupDataBase.Size = new System.Drawing.Size(75, 23);
            this.buttonBackupDataBase.TabIndex = 4;
            this.buttonBackupDataBase.Text = "Back up ";
            this.buttonBackupDataBase.UseVisualStyleBackColor = true;
            this.buttonBackupDataBase.Click += new System.EventHandler(this.buttonBackupDataBase_Click);
            // 
            // comboBoxDataBaseName
            // 
            this.comboBoxDataBaseName.FormattingEnabled = true;
            this.comboBoxDataBaseName.Location = new System.Drawing.Point(188, 104);
            this.comboBoxDataBaseName.Name = "comboBoxDataBaseName";
            this.comboBoxDataBaseName.Size = new System.Drawing.Size(145, 21);
            this.comboBoxDataBaseName.TabIndex = 3;
            // 
            // labelDataBaseName
            // 
            this.labelDataBaseName.AutoSize = true;
            this.labelDataBaseName.Location = new System.Drawing.Point(49, 107);
            this.labelDataBaseName.Name = "labelDataBaseName";
            this.labelDataBaseName.Size = new System.Drawing.Size(133, 13);
            this.labelDataBaseName.TabIndex = 2;
            this.labelDataBaseName.Text = "Nom du base de donnee : ";
            // 
            // comboBoxServerName
            // 
            this.comboBoxServerName.FormattingEnabled = true;
            this.comboBoxServerName.Location = new System.Drawing.Point(188, 53);
            this.comboBoxServerName.Name = "comboBoxServerName";
            this.comboBoxServerName.Size = new System.Drawing.Size(145, 21);
            this.comboBoxServerName.TabIndex = 1;
            // 
            // labelServerName
            // 
            this.labelServerName.AutoSize = true;
            this.labelServerName.Location = new System.Drawing.Point(91, 56);
            this.labelServerName.Name = "labelServerName";
            this.labelServerName.Size = new System.Drawing.Size(91, 13);
            this.labelServerName.TabIndex = 0;
            this.labelServerName.Text = "Nom de serveur : ";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelWrapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.panelWrapper.ResumeLayout(false);
            this.panelWrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWrapper;
        private System.Windows.Forms.Button buttonBackupDataBase;
        private System.Windows.Forms.ComboBox comboBoxDataBaseName;
        private System.Windows.Forms.Label labelDataBaseName;
        private System.Windows.Forms.ComboBox comboBoxServerName;
        private System.Windows.Forms.Label labelServerName;
        private System.Windows.Forms.Button buttonRestore;
    }
}