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
            this.groupBoxBackup = new System.Windows.Forms.GroupBox();
            this.radioButtonMonthlyBackup = new System.Windows.Forms.RadioButton();
            this.radioButtonWeeklyBackup = new System.Windows.Forms.RadioButton();
            this.radioButtonDailyBackup = new System.Windows.Forms.RadioButton();
            this.buttonRestoreFromExternalDrive = new System.Windows.Forms.Button();
            this.checkBoxAutoBackup = new System.Windows.Forms.CheckBox();
            this.buttonBackuptoExternalDrive = new System.Windows.Forms.Button();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.buttonBackupDataBase = new System.Windows.Forms.Button();
            this.comboBoxDataBaseName = new System.Windows.Forms.ComboBox();
            this.labelDataBaseName = new System.Windows.Forms.Label();
            this.comboBoxServerName = new System.Windows.Forms.ComboBox();
            this.labelServerName = new System.Windows.Forms.Label();
            this.panelBackgroundWorkerContainer = new System.Windows.Forms.Panel();
            this.buttonStartBackgroundWorker = new System.Windows.Forms.Button();
            this.buttonCancelBackgroundWorker = new System.Windows.Forms.Button();
            this.progressBarBackgroundWorker = new System.Windows.Forms.ProgressBar();
            this.labelResultPercentage = new System.Windows.Forms.Label();
            this.backgroundWorkerBackup = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerRestore = new System.ComponentModel.BackgroundWorker();
            this.panelWrapper.SuspendLayout();
            this.groupBoxBackup.SuspendLayout();
            this.panelBackgroundWorkerContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWrapper
            // 
            this.panelWrapper.Controls.Add(this.panelBackgroundWorkerContainer);
            this.panelWrapper.Controls.Add(this.groupBoxBackup);
            this.panelWrapper.Controls.Add(this.buttonRestoreFromExternalDrive);
            this.panelWrapper.Controls.Add(this.checkBoxAutoBackup);
            this.panelWrapper.Controls.Add(this.buttonBackuptoExternalDrive);
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
            // groupBoxBackup
            // 
            this.groupBoxBackup.Controls.Add(this.radioButtonMonthlyBackup);
            this.groupBoxBackup.Controls.Add(this.radioButtonWeeklyBackup);
            this.groupBoxBackup.Controls.Add(this.radioButtonDailyBackup);
            this.groupBoxBackup.Location = new System.Drawing.Point(188, 316);
            this.groupBoxBackup.Name = "groupBoxBackup";
            this.groupBoxBackup.Size = new System.Drawing.Size(156, 93);
            this.groupBoxBackup.TabIndex = 10;
            this.groupBoxBackup.TabStop = false;
            // 
            // radioButtonMonthlyBackup
            // 
            this.radioButtonMonthlyBackup.AutoSize = true;
            this.radioButtonMonthlyBackup.Location = new System.Drawing.Point(6, 69);
            this.radioButtonMonthlyBackup.Name = "radioButtonMonthlyBackup";
            this.radioButtonMonthlyBackup.Size = new System.Drawing.Size(62, 17);
            this.radioButtonMonthlyBackup.TabIndex = 11;
            this.radioButtonMonthlyBackup.TabStop = true;
            this.radioButtonMonthlyBackup.Text = "Monthly";
            this.radioButtonMonthlyBackup.UseVisualStyleBackColor = true;
            // 
            // radioButtonWeeklyBackup
            // 
            this.radioButtonWeeklyBackup.AutoSize = true;
            this.radioButtonWeeklyBackup.Location = new System.Drawing.Point(6, 46);
            this.radioButtonWeeklyBackup.Name = "radioButtonWeeklyBackup";
            this.radioButtonWeeklyBackup.Size = new System.Drawing.Size(61, 17);
            this.radioButtonWeeklyBackup.TabIndex = 10;
            this.radioButtonWeeklyBackup.TabStop = true;
            this.radioButtonWeeklyBackup.Text = "Weekly";
            this.radioButtonWeeklyBackup.UseVisualStyleBackColor = true;
            // 
            // radioButtonDailyBackup
            // 
            this.radioButtonDailyBackup.AutoSize = true;
            this.radioButtonDailyBackup.Location = new System.Drawing.Point(6, 23);
            this.radioButtonDailyBackup.Name = "radioButtonDailyBackup";
            this.radioButtonDailyBackup.Size = new System.Drawing.Size(48, 17);
            this.radioButtonDailyBackup.TabIndex = 9;
            this.radioButtonDailyBackup.TabStop = true;
            this.radioButtonDailyBackup.Text = "Daily";
            this.radioButtonDailyBackup.UseVisualStyleBackColor = true;
            // 
            // buttonRestoreFromExternalDrive
            // 
            this.buttonRestoreFromExternalDrive.Location = new System.Drawing.Point(188, 264);
            this.buttonRestoreFromExternalDrive.Name = "buttonRestoreFromExternalDrive";
            this.buttonRestoreFromExternalDrive.Size = new System.Drawing.Size(155, 23);
            this.buttonRestoreFromExternalDrive.TabIndex = 7;
            this.buttonRestoreFromExternalDrive.Text = "Restore from external drive";
            this.buttonRestoreFromExternalDrive.UseVisualStyleBackColor = true;
            this.buttonRestoreFromExternalDrive.Click += new System.EventHandler(this.buttonRestoreFromExternalDrive_Click);
            // 
            // checkBoxAutoBackup
            // 
            this.checkBoxAutoBackup.AutoSize = true;
            this.checkBoxAutoBackup.Location = new System.Drawing.Point(208, 301);
            this.checkBoxAutoBackup.Name = "checkBoxAutoBackup";
            this.checkBoxAutoBackup.Size = new System.Drawing.Size(86, 17);
            this.checkBoxAutoBackup.TabIndex = 8;
            this.checkBoxAutoBackup.Text = "auto backup";
            this.checkBoxAutoBackup.UseVisualStyleBackColor = true;
            this.checkBoxAutoBackup.CheckedChanged += new System.EventHandler(this.checkBoxAutoBackup_CheckedChanged);
            // 
            // buttonBackuptoExternalDrive
            // 
            this.buttonBackuptoExternalDrive.Location = new System.Drawing.Point(188, 235);
            this.buttonBackuptoExternalDrive.Name = "buttonBackuptoExternalDrive";
            this.buttonBackuptoExternalDrive.Size = new System.Drawing.Size(155, 23);
            this.buttonBackuptoExternalDrive.TabIndex = 6;
            this.buttonBackuptoExternalDrive.Text = "Back up to external drive";
            this.buttonBackuptoExternalDrive.UseVisualStyleBackColor = true;
            this.buttonBackuptoExternalDrive.Click += new System.EventHandler(this.buttonBackuptoExternalDrive_Click);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Location = new System.Drawing.Point(269, 194);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(75, 23);
            this.buttonRestore.TabIndex = 5;
            this.buttonRestore.Text = "Restore ";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
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
            // panelBackgroundWorkerContainer
            // 
            this.panelBackgroundWorkerContainer.Controls.Add(this.labelResultPercentage);
            this.panelBackgroundWorkerContainer.Controls.Add(this.progressBarBackgroundWorker);
            this.panelBackgroundWorkerContainer.Controls.Add(this.buttonCancelBackgroundWorker);
            this.panelBackgroundWorkerContainer.Controls.Add(this.buttonStartBackgroundWorker);
            this.panelBackgroundWorkerContainer.Location = new System.Drawing.Point(376, 235);
            this.panelBackgroundWorkerContainer.Name = "panelBackgroundWorkerContainer";
            this.panelBackgroundWorkerContainer.Size = new System.Drawing.Size(194, 121);
            this.panelBackgroundWorkerContainer.TabIndex = 11;
            // 
            // buttonStartBackgroundWorker
            // 
            this.buttonStartBackgroundWorker.Location = new System.Drawing.Point(12, 12);
            this.buttonStartBackgroundWorker.Name = "buttonStartBackgroundWorker";
            this.buttonStartBackgroundWorker.Size = new System.Drawing.Size(75, 23);
            this.buttonStartBackgroundWorker.TabIndex = 0;
            this.buttonStartBackgroundWorker.Text = "Start";
            this.buttonStartBackgroundWorker.UseVisualStyleBackColor = true;
            // 
            // buttonCancelBackgroundWorker
            // 
            this.buttonCancelBackgroundWorker.Location = new System.Drawing.Point(106, 12);
            this.buttonCancelBackgroundWorker.Name = "buttonCancelBackgroundWorker";
            this.buttonCancelBackgroundWorker.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelBackgroundWorker.TabIndex = 1;
            this.buttonCancelBackgroundWorker.Text = "Cancel";
            this.buttonCancelBackgroundWorker.UseVisualStyleBackColor = true;
            // 
            // progressBarBackgroundWorker
            // 
            this.progressBarBackgroundWorker.Location = new System.Drawing.Point(12, 49);
            this.progressBarBackgroundWorker.Name = "progressBarBackgroundWorker";
            this.progressBarBackgroundWorker.Size = new System.Drawing.Size(169, 23);
            this.progressBarBackgroundWorker.TabIndex = 2;
            // 
            // labelResultPercentage
            // 
            this.labelResultPercentage.AutoSize = true;
            this.labelResultPercentage.Location = new System.Drawing.Point(77, 87);
            this.labelResultPercentage.Name = "labelResultPercentage";
            this.labelResultPercentage.Size = new System.Drawing.Size(35, 13);
            this.labelResultPercentage.TabIndex = 3;
            this.labelResultPercentage.Text = "label1";
            // 
            // backgroundWorkerBackup
            // 
            this.backgroundWorkerBackup.WorkerReportsProgress = true;
            this.backgroundWorkerBackup.WorkerSupportsCancellation = true;
            this.backgroundWorkerBackup.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerBackup_DoWork);
            // 
            // backgroundWorkerRestore
            // 
            this.backgroundWorkerRestore.WorkerReportsProgress = true;
            this.backgroundWorkerRestore.WorkerSupportsCancellation = true;
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
            this.groupBoxBackup.ResumeLayout(false);
            this.groupBoxBackup.PerformLayout();
            this.panelBackgroundWorkerContainer.ResumeLayout(false);
            this.panelBackgroundWorkerContainer.PerformLayout();
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
        private System.Windows.Forms.Button buttonBackuptoExternalDrive;
        private System.Windows.Forms.Button buttonRestoreFromExternalDrive;
        private System.Windows.Forms.GroupBox groupBoxBackup;
        private System.Windows.Forms.RadioButton radioButtonMonthlyBackup;
        private System.Windows.Forms.RadioButton radioButtonWeeklyBackup;
        private System.Windows.Forms.RadioButton radioButtonDailyBackup;
        private System.Windows.Forms.CheckBox checkBoxAutoBackup;
        private System.Windows.Forms.Panel panelBackgroundWorkerContainer;
        private System.Windows.Forms.Label labelResultPercentage;
        private System.Windows.Forms.ProgressBar progressBarBackgroundWorker;
        private System.Windows.Forms.Button buttonCancelBackgroundWorker;
        private System.Windows.Forms.Button buttonStartBackgroundWorker;
        private System.ComponentModel.BackgroundWorker backgroundWorkerBackup;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRestore;
    }
}