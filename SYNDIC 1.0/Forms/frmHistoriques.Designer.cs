namespace SYNDIC_1._0
{
    partial class frmHistoriques
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
            this.labelHistoriques = new System.Windows.Forms.Label();
            this.labelCloseHistoriques = new System.Windows.Forms.Label();
            this.dataGridViewHistorique = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxSearchDataGridView = new System.Windows.Forms.GroupBox();
            this.labelWords = new System.Windows.Forms.Label();
            this.textBoxStrings = new System.Windows.Forms.TextBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.comboBoxFilterItems = new System.Windows.Forms.ComboBox();
            this.labelFilterByDateTimePicker = new System.Windows.Forms.Label();
            this.dateTimePickerHistorique = new System.Windows.Forms.DateTimePicker();
            this.buttonSearchDataGridView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorique)).BeginInit();
            this.groupBoxSearchDataGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHistoriques
            // 
            this.labelHistoriques.AutoSize = true;
            this.labelHistoriques.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHistoriques.Location = new System.Drawing.Point(297, 39);
            this.labelHistoriques.Name = "labelHistoriques";
            this.labelHistoriques.Size = new System.Drawing.Size(139, 30);
            this.labelHistoriques.TabIndex = 4;
            this.labelHistoriques.Text = "Historiques";
            // 
            // labelCloseHistoriques
            // 
            this.labelCloseHistoriques.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCloseHistoriques.AutoSize = true;
            this.labelCloseHistoriques.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseHistoriques.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCloseHistoriques.Location = new System.Drawing.Point(770, 9);
            this.labelCloseHistoriques.Name = "labelCloseHistoriques";
            this.labelCloseHistoriques.Size = new System.Drawing.Size(18, 18);
            this.labelCloseHistoriques.TabIndex = 5;
            this.labelCloseHistoriques.Text = "X";
            this.labelCloseHistoriques.Click += new System.EventHandler(this.labelCloseHistoriques_Click);
            // 
            // dataGridViewHistorique
            // 
            this.dataGridViewHistorique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistorique.Location = new System.Drawing.Point(12, 179);
            this.dataGridViewHistorique.Name = "dataGridViewHistorique";
            this.dataGridViewHistorique.Size = new System.Drawing.Size(776, 347);
            this.dataGridViewHistorique.TabIndex = 6;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(713, 532);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Supprimer";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxSearchDataGridView
            // 
            this.groupBoxSearchDataGridView.Controls.Add(this.buttonSearchDataGridView);
            this.groupBoxSearchDataGridView.Controls.Add(this.dateTimePickerHistorique);
            this.groupBoxSearchDataGridView.Controls.Add(this.labelFilterByDateTimePicker);
            this.groupBoxSearchDataGridView.Controls.Add(this.comboBoxFilterItems);
            this.groupBoxSearchDataGridView.Controls.Add(this.labelFilter);
            this.groupBoxSearchDataGridView.Controls.Add(this.textBoxStrings);
            this.groupBoxSearchDataGridView.Controls.Add(this.labelWords);
            this.groupBoxSearchDataGridView.Location = new System.Drawing.Point(12, 91);
            this.groupBoxSearchDataGridView.Name = "groupBoxSearchDataGridView";
            this.groupBoxSearchDataGridView.Size = new System.Drawing.Size(776, 65);
            this.groupBoxSearchDataGridView.TabIndex = 10;
            this.groupBoxSearchDataGridView.TabStop = false;
            this.groupBoxSearchDataGridView.Text = "Chercher  ";
            // 
            // labelWords
            // 
            this.labelWords.AutoSize = true;
            this.labelWords.Location = new System.Drawing.Point(9, 29);
            this.labelWords.Name = "labelWords";
            this.labelWords.Size = new System.Drawing.Size(36, 13);
            this.labelWords.TabIndex = 0;
            this.labelWords.Text = "Mots :";
            // 
            // textBoxStrings
            // 
            this.textBoxStrings.Location = new System.Drawing.Point(51, 26);
            this.textBoxStrings.Name = "textBoxStrings";
            this.textBoxStrings.Size = new System.Drawing.Size(105, 20);
            this.textBoxStrings.TabIndex = 1;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(174, 29);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(56, 13);
            this.labelFilter.TabIndex = 2;
            this.labelFilter.Text = "Filtrer par :";
            // 
            // comboBoxFilterItems
            // 
            this.comboBoxFilterItems.FormattingEnabled = true;
            this.comboBoxFilterItems.Items.AddRange(new object[] {
            "ID_Utiliasteur",
            "Nom_Utilisateur",
            "Action",
            "Valeur"});
            this.comboBoxFilterItems.Location = new System.Drawing.Point(236, 26);
            this.comboBoxFilterItems.Name = "comboBoxFilterItems";
            this.comboBoxFilterItems.Size = new System.Drawing.Size(99, 21);
            this.comboBoxFilterItems.TabIndex = 2;
            // 
            // labelFilterByDateTimePicker
            // 
            this.labelFilterByDateTimePicker.AutoSize = true;
            this.labelFilterByDateTimePicker.Location = new System.Drawing.Point(355, 29);
            this.labelFilterByDateTimePicker.Name = "labelFilterByDateTimePicker";
            this.labelFilterByDateTimePicker.Size = new System.Drawing.Size(69, 13);
            this.labelFilterByDateTimePicker.TabIndex = 4;
            this.labelFilterByDateTimePicker.Text = "Ou par date :";
            // 
            // dateTimePickerHistorique
            // 
            this.dateTimePickerHistorique.CustomFormat = "dd/mm/yyyy";
            this.dateTimePickerHistorique.Location = new System.Drawing.Point(430, 27);
            this.dateTimePickerHistorique.Name = "dateTimePickerHistorique";
            this.dateTimePickerHistorique.Size = new System.Drawing.Size(188, 20);
            this.dateTimePickerHistorique.TabIndex = 3;
            this.dateTimePickerHistorique.Value = new System.DateTime(2020, 1, 26, 0, 0, 0, 0);
            // 
            // buttonSearchDataGridView
            // 
            this.buttonSearchDataGridView.Location = new System.Drawing.Point(659, 24);
            this.buttonSearchDataGridView.Name = "buttonSearchDataGridView";
            this.buttonSearchDataGridView.Size = new System.Drawing.Size(87, 23);
            this.buttonSearchDataGridView.TabIndex = 5;
            this.buttonSearchDataGridView.Text = "Chercher";
            this.buttonSearchDataGridView.UseVisualStyleBackColor = true;
            this.buttonSearchDataGridView.Click += new System.EventHandler(this.buttonSearchDataGridView_Click);
            // 
            // frmHistoriques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.groupBoxSearchDataGridView);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewHistorique);
            this.Controls.Add(this.labelCloseHistoriques);
            this.Controls.Add(this.labelHistoriques);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHistoriques";
            this.Text = "frmHistoriques";
            this.Load += new System.EventHandler(this.frmHistoriques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorique)).EndInit();
            this.groupBoxSearchDataGridView.ResumeLayout(false);
            this.groupBoxSearchDataGridView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHistoriques;
        private System.Windows.Forms.Label labelCloseHistoriques;
        private System.Windows.Forms.DataGridView dataGridViewHistorique;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxSearchDataGridView;
        private System.Windows.Forms.DateTimePicker dateTimePickerHistorique;
        private System.Windows.Forms.Label labelFilterByDateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxFilterItems;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.TextBox textBoxStrings;
        private System.Windows.Forms.Label labelWords;
        private System.Windows.Forms.Button buttonSearchDataGridView;
    }
}