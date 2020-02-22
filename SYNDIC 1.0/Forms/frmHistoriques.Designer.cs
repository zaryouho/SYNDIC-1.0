namespace SYNDIC_1._0.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxSearchDataGridView = new System.Windows.Forms.GroupBox();
            this.buttonSearchDataGridView = new System.Windows.Forms.Button();
            this.dateTimePickerHistorique = new System.Windows.Forms.DateTimePicker();
            this.labelFilterByDateTimePicker = new System.Windows.Forms.Label();
            this.comboBoxFilterItems = new System.Windows.Forms.ComboBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.textBoxStrings = new System.Windows.Forms.TextBox();
            this.labelWords = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHistoriques = new System.Windows.Forms.Label();
            this.labelCloseHistoriques = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonToLast = new System.Windows.Forms.Button();
            this.buttonToNext = new System.Windows.Forms.Button();
            this.buttonTofirst = new System.Windows.Forms.Button();
            this.buttonToPrev = new System.Windows.Forms.Button();
            this.dataGridViewHistorique = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxSearchDataGridView.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorique)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxSearchDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.panelHeader);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 116;
            this.splitContainer1.TabIndex = 0;
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
            this.groupBoxSearchDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxSearchDataGridView.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearchDataGridView.Location = new System.Drawing.Point(0, 45);
            this.groupBoxSearchDataGridView.Name = "groupBoxSearchDataGridView";
            this.groupBoxSearchDataGridView.Size = new System.Drawing.Size(800, 71);
            this.groupBoxSearchDataGridView.TabIndex = 0;
            this.groupBoxSearchDataGridView.TabStop = false;
            this.groupBoxSearchDataGridView.Text = "Chercher  ";
            // 
            // buttonSearchDataGridView
            // 
            this.buttonSearchDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchDataGridView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.buttonSearchDataGridView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.buttonSearchDataGridView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchDataGridView.Location = new System.Drawing.Point(707, 23);
            this.buttonSearchDataGridView.Name = "buttonSearchDataGridView";
            this.buttonSearchDataGridView.Size = new System.Drawing.Size(87, 29);
            this.buttonSearchDataGridView.TabIndex = 3;
            this.buttonSearchDataGridView.Text = "Chercher";
            this.buttonSearchDataGridView.UseVisualStyleBackColor = true;
            this.buttonSearchDataGridView.Click += new System.EventHandler(this.buttonSearchDataGridView_Click);
            // 
            // dateTimePickerHistorique
            // 
            this.dateTimePickerHistorique.CustomFormat = "dd/mm/yyyy";
            this.dateTimePickerHistorique.Location = new System.Drawing.Point(375, 38);
            this.dateTimePickerHistorique.Name = "dateTimePickerHistorique";
            this.dateTimePickerHistorique.Size = new System.Drawing.Size(219, 22);
            this.dateTimePickerHistorique.TabIndex = 2;
            this.dateTimePickerHistorique.Value = new System.DateTime(2020, 1, 26, 0, 0, 0, 0);
            // 
            // labelFilterByDateTimePicker
            // 
            this.labelFilterByDateTimePicker.AutoSize = true;
            this.labelFilterByDateTimePicker.Location = new System.Drawing.Point(372, 18);
            this.labelFilterByDateTimePicker.Name = "labelFilterByDateTimePicker";
            this.labelFilterByDateTimePicker.Size = new System.Drawing.Size(86, 17);
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
            this.comboBoxFilterItems.Location = new System.Drawing.Point(208, 40);
            this.comboBoxFilterItems.Name = "comboBoxFilterItems";
            this.comboBoxFilterItems.Size = new System.Drawing.Size(101, 25);
            this.comboBoxFilterItems.TabIndex = 1;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(205, 18);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(70, 17);
            this.labelFilter.TabIndex = 2;
            this.labelFilter.Text = "Filtrer par :";
            // 
            // textBoxStrings
            // 
            this.textBoxStrings.Location = new System.Drawing.Point(72, 38);
            this.textBoxStrings.Name = "textBoxStrings";
            this.textBoxStrings.Size = new System.Drawing.Size(98, 22);
            this.textBoxStrings.TabIndex = 0;
            // 
            // labelWords
            // 
            this.labelWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelWords.AutoSize = true;
            this.labelWords.Location = new System.Drawing.Point(69, 18);
            this.labelWords.Name = "labelWords";
            this.labelWords.Size = new System.Drawing.Size(43, 17);
            this.labelWords.TabIndex = 0;
            this.labelWords.Text = "Mots :";
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelHistoriques);
            this.panelHeader.Controls.Add(this.labelCloseHistoriques);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 65);
            this.panelHeader.TabIndex = 14;
            // 
            // labelHistoriques
            // 
            this.labelHistoriques.AutoSize = true;
            this.labelHistoriques.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHistoriques.Location = new System.Drawing.Point(332, 9);
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
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonToLast);
            this.splitContainer2.Panel1.Controls.Add(this.buttonToNext);
            this.splitContainer2.Panel1.Controls.Add(this.buttonTofirst);
            this.splitContainer2.Panel1.Controls.Add(this.buttonToPrev);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridViewHistorique);
            this.splitContainer2.Size = new System.Drawing.Size(800, 276);
            this.splitContainer2.SplitterDistance = 67;
            this.splitContainer2.TabIndex = 1;
            // 
            // buttonToLast
            // 
            this.buttonToLast.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonToLast.FlatAppearance.BorderSize = 0;
            this.buttonToLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToLast.Image = global::SYNDIC_1._0.Properties.Resources.down_chevron_2;
            this.buttonToLast.Location = new System.Drawing.Point(14, 224);
            this.buttonToLast.Name = "buttonToLast";
            this.buttonToLast.Size = new System.Drawing.Size(39, 39);
            this.buttonToLast.TabIndex = 2;
            this.buttonToLast.UseVisualStyleBackColor = true;
            this.buttonToLast.Click += new System.EventHandler(this.buttonToLast_Click);
            // 
            // buttonToNext
            // 
            this.buttonToNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonToNext.FlatAppearance.BorderSize = 0;
            this.buttonToNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToNext.Image = global::SYNDIC_1._0.Properties.Resources.down_chevron_1;
            this.buttonToNext.Location = new System.Drawing.Point(14, 170);
            this.buttonToNext.Name = "buttonToNext";
            this.buttonToNext.Size = new System.Drawing.Size(39, 39);
            this.buttonToNext.TabIndex = 0;
            this.buttonToNext.UseVisualStyleBackColor = true;
            this.buttonToNext.Click += new System.EventHandler(this.buttonToNext_Click);
            // 
            // buttonTofirst
            // 
            this.buttonTofirst.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonTofirst.FlatAppearance.BorderSize = 0;
            this.buttonTofirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTofirst.Image = global::SYNDIC_1._0.Properties.Resources.up_chevron_2222;
            this.buttonTofirst.Location = new System.Drawing.Point(14, 10);
            this.buttonTofirst.Name = "buttonTofirst";
            this.buttonTofirst.Size = new System.Drawing.Size(39, 39);
            this.buttonTofirst.TabIndex = 3;
            this.buttonTofirst.UseVisualStyleBackColor = true;
            this.buttonTofirst.Click += new System.EventHandler(this.buttonTofirst_Click);
            // 
            // buttonToPrev
            // 
            this.buttonToPrev.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonToPrev.FlatAppearance.BorderSize = 0;
            this.buttonToPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToPrev.Image = global::SYNDIC_1._0.Properties.Resources.up_chevron_1111;
            this.buttonToPrev.Location = new System.Drawing.Point(14, 64);
            this.buttonToPrev.Name = "buttonToPrev";
            this.buttonToPrev.Size = new System.Drawing.Size(39, 39);
            this.buttonToPrev.TabIndex = 1;
            this.buttonToPrev.UseVisualStyleBackColor = true;
            this.buttonToPrev.Click += new System.EventHandler(this.buttonToPrev_Click);
            // 
            // dataGridViewHistorique
            // 
            this.dataGridViewHistorique.AllowUserToAddRows = false;
            this.dataGridViewHistorique.AllowUserToDeleteRows = false;
            this.dataGridViewHistorique.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistorique.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHistorique.ColumnHeadersHeight = 40;
            this.dataGridViewHistorique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHistorique.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewHistorique.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewHistorique.Name = "dataGridViewHistorique";
            this.dataGridViewHistorique.RowHeadersWidth = 25;
            this.dataGridViewHistorique.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHistorique.Size = new System.Drawing.Size(729, 276);
            this.dataGridViewHistorique.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 54);
            this.panel1.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(701, 13);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(87, 29);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Supprimer";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // frmHistoriques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHistoriques";
            this.Text = "frmHistoriques";
            this.Load += new System.EventHandler(this.frmHistoriques_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmHistoriques_KeyPress);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxSearchDataGridView.ResumeLayout(false);
            this.groupBoxSearchDataGridView.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorique)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHistoriques;
        private System.Windows.Forms.Label labelCloseHistoriques;
        private System.Windows.Forms.GroupBox groupBoxSearchDataGridView;
        private System.Windows.Forms.Button buttonSearchDataGridView;
        private System.Windows.Forms.DateTimePicker dateTimePickerHistorique;
        private System.Windows.Forms.Label labelFilterByDateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxFilterItems;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.TextBox textBoxStrings;
        private System.Windows.Forms.Label labelWords;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewHistorique;
        private System.Windows.Forms.Button buttonToLast;
        private System.Windows.Forms.Button buttonToNext;
        private System.Windows.Forms.Button buttonTofirst;
        private System.Windows.Forms.Button buttonToPrev;
    }
}