﻿namespace SYNDIC_1._0
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
            this.buttonSearchDataGridView = new System.Windows.Forms.Button();
            this.dateTimePickerHistorique = new System.Windows.Forms.DateTimePicker();
            this.labelFilterByDateTimePicker = new System.Windows.Forms.Label();
            this.comboBoxFilterItems = new System.Windows.Forms.ComboBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.textBoxStrings = new System.Windows.Forms.TextBox();
            this.labelWords = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelNavigationButtons = new System.Windows.Forms.Panel();
            this.buttonMoveToLast = new System.Windows.Forms.Button();
            this.buttonMoveToNext = new System.Windows.Forms.Button();
            this.buttonMoveToPrev = new System.Windows.Forms.Button();
            this.buttonMoveToFirst = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorique)).BeginInit();
            this.groupBoxSearchDataGridView.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelNavigationButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHistoriques
            // 
            this.labelHistoriques.AutoSize = true;
            this.labelHistoriques.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHistoriques.Location = new System.Drawing.Point(297, 21);
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
            this.dataGridViewHistorique.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHistorique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistorique.Location = new System.Drawing.Point(94, 134);
            this.dataGridViewHistorique.Name = "dataGridViewHistorique";
            this.dataGridViewHistorique.Size = new System.Drawing.Size(694, 392);
            this.dataGridViewHistorique.TabIndex = 9;
            this.dataGridViewHistorique.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewHistorique_ColumnHeaderMouseClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(713, 532);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Supprimer";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxSearchDataGridView
            // 
            this.groupBoxSearchDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearchDataGridView.Controls.Add(this.buttonSearchDataGridView);
            this.groupBoxSearchDataGridView.Controls.Add(this.dateTimePickerHistorique);
            this.groupBoxSearchDataGridView.Controls.Add(this.labelFilterByDateTimePicker);
            this.groupBoxSearchDataGridView.Controls.Add(this.comboBoxFilterItems);
            this.groupBoxSearchDataGridView.Controls.Add(this.labelFilter);
            this.groupBoxSearchDataGridView.Controls.Add(this.textBoxStrings);
            this.groupBoxSearchDataGridView.Controls.Add(this.labelWords);
            this.groupBoxSearchDataGridView.Location = new System.Drawing.Point(3, 8);
            this.groupBoxSearchDataGridView.Name = "groupBoxSearchDataGridView";
            this.groupBoxSearchDataGridView.Size = new System.Drawing.Size(770, 63);
            this.groupBoxSearchDataGridView.TabIndex = 10;
            this.groupBoxSearchDataGridView.TabStop = false;
            this.groupBoxSearchDataGridView.Text = "Chercher  ";
            // 
            // buttonSearchDataGridView
            // 
            this.buttonSearchDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchDataGridView.Location = new System.Drawing.Point(677, 27);
            this.buttonSearchDataGridView.Name = "buttonSearchDataGridView";
            this.buttonSearchDataGridView.Size = new System.Drawing.Size(87, 21);
            this.buttonSearchDataGridView.TabIndex = 4;
            this.buttonSearchDataGridView.Text = "Chercher";
            this.buttonSearchDataGridView.UseVisualStyleBackColor = true;
            this.buttonSearchDataGridView.Click += new System.EventHandler(this.buttonSearchDataGridView_Click);
            // 
            // dateTimePickerHistorique
            // 
            this.dateTimePickerHistorique.CustomFormat = "dd/mm/yyyy";
            this.dateTimePickerHistorique.Location = new System.Drawing.Point(397, 27);
            this.dateTimePickerHistorique.Name = "dateTimePickerHistorique";
            this.dateTimePickerHistorique.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerHistorique.TabIndex = 3;
            this.dateTimePickerHistorique.Value = new System.DateTime(2020, 1, 26, 0, 0, 0, 0);
            // 
            // labelFilterByDateTimePicker
            // 
            this.labelFilterByDateTimePicker.AutoSize = true;
            this.labelFilterByDateTimePicker.Location = new System.Drawing.Point(322, 29);
            this.labelFilterByDateTimePicker.Name = "labelFilterByDateTimePicker";
            this.labelFilterByDateTimePicker.Size = new System.Drawing.Size(69, 13);
            this.labelFilterByDateTimePicker.TabIndex = 4;
            this.labelFilterByDateTimePicker.Text = "Ou par date :";
            // 
            // comboBoxFilterItems
            // 
            this.comboBoxFilterItems.FormattingEnabled = true;
            this.comboBoxFilterItems.Items.AddRange(new object[] {
            "ID_Utiliasteur",
            "Nom_Utilisateur",
            "Action",
            "Valeur"});
            this.comboBoxFilterItems.Location = new System.Drawing.Point(208, 26);
            this.comboBoxFilterItems.Name = "comboBoxFilterItems";
            this.comboBoxFilterItems.Size = new System.Drawing.Size(101, 21);
            this.comboBoxFilterItems.TabIndex = 2;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(146, 29);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(56, 13);
            this.labelFilter.TabIndex = 2;
            this.labelFilter.Text = "Filtrer par :";
            // 
            // textBoxStrings
            // 
            this.textBoxStrings.Location = new System.Drawing.Point(42, 26);
            this.textBoxStrings.Name = "textBoxStrings";
            this.textBoxStrings.Size = new System.Drawing.Size(98, 20);
            this.textBoxStrings.TabIndex = 1;
            // 
            // labelWords
            // 
            this.labelWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelWords.AutoSize = true;
            this.labelWords.Location = new System.Drawing.Point(0, 29);
            this.labelWords.Name = "labelWords";
            this.labelWords.Size = new System.Drawing.Size(36, 13);
            this.labelWords.TabIndex = 0;
            this.labelWords.Text = "Mots :";
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.Controls.Add(this.groupBoxSearchDataGridView);
            this.panelHeader.Location = new System.Drawing.Point(12, 54);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(776, 74);
            this.panelHeader.TabIndex = 11;
            // 
            // panelNavigationButtons
            // 
            this.panelNavigationButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNavigationButtons.Controls.Add(this.buttonMoveToLast);
            this.panelNavigationButtons.Controls.Add(this.buttonMoveToNext);
            this.panelNavigationButtons.Controls.Add(this.buttonMoveToPrev);
            this.panelNavigationButtons.Controls.Add(this.buttonMoveToFirst);
            this.panelNavigationButtons.Location = new System.Drawing.Point(15, 134);
            this.panelNavigationButtons.Name = "panelNavigationButtons";
            this.panelNavigationButtons.Size = new System.Drawing.Size(67, 392);
            this.panelNavigationButtons.TabIndex = 12;
            // 
            // buttonMoveToLast
            // 
            this.buttonMoveToLast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveToLast.Location = new System.Drawing.Point(3, 271);
            this.buttonMoveToLast.Name = "buttonMoveToLast";
            this.buttonMoveToLast.Size = new System.Drawing.Size(61, 55);
            this.buttonMoveToLast.TabIndex = 8;
            this.buttonMoveToLast.Text = ">>";
            this.buttonMoveToLast.UseVisualStyleBackColor = true;
            // 
            // buttonMoveToNext
            // 
            this.buttonMoveToNext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveToNext.Location = new System.Drawing.Point(3, 210);
            this.buttonMoveToNext.Name = "buttonMoveToNext";
            this.buttonMoveToNext.Size = new System.Drawing.Size(61, 55);
            this.buttonMoveToNext.TabIndex = 7;
            this.buttonMoveToNext.Text = ">";
            this.buttonMoveToNext.UseVisualStyleBackColor = true;
            // 
            // buttonMoveToPrev
            // 
            this.buttonMoveToPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveToPrev.Location = new System.Drawing.Point(3, 114);
            this.buttonMoveToPrev.Name = "buttonMoveToPrev";
            this.buttonMoveToPrev.Size = new System.Drawing.Size(61, 55);
            this.buttonMoveToPrev.TabIndex = 6;
            this.buttonMoveToPrev.Text = "<";
            this.buttonMoveToPrev.UseVisualStyleBackColor = true;
            // 
            // buttonMoveToFirst
            // 
            this.buttonMoveToFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveToFirst.Location = new System.Drawing.Point(3, 53);
            this.buttonMoveToFirst.Name = "buttonMoveToFirst";
            this.buttonMoveToFirst.Size = new System.Drawing.Size(61, 55);
            this.buttonMoveToFirst.TabIndex = 5;
            this.buttonMoveToFirst.Text = "<<";
            this.buttonMoveToFirst.UseVisualStyleBackColor = true;
            this.buttonMoveToFirst.Click += new System.EventHandler(this.buttonMoveToFirst_Click);
            // 
            // frmHistoriques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.panelNavigationButtons);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewHistorique);
            this.Controls.Add(this.labelCloseHistoriques);
            this.Controls.Add(this.labelHistoriques);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHistoriques";
            this.Text = "frmHistoriques";
            this.Load += new System.EventHandler(this.frmHistoriques_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmHistoriques_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorique)).EndInit();
            this.groupBoxSearchDataGridView.ResumeLayout(false);
            this.groupBoxSearchDataGridView.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelNavigationButtons.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelNavigationButtons;
        private System.Windows.Forms.Button buttonMoveToLast;
        private System.Windows.Forms.Button buttonMoveToNext;
        private System.Windows.Forms.Button buttonMoveToPrev;
        private System.Windows.Forms.Button buttonMoveToFirst;
    }
}