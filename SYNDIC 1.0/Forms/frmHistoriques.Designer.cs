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
            this.buttonSearchDataGridView = new System.Windows.Forms.Button();
            this.dateTimePickerHistorique = new System.Windows.Forms.DateTimePicker();
            this.labelFilterByDateTimePicker = new System.Windows.Forms.Label();
            this.comboBoxFilterItems = new System.Windows.Forms.ComboBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.textBoxStrings = new System.Windows.Forms.TextBox();
            this.labelWords = new System.Windows.Forms.Label();
            this.panelAll = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonToLast = new System.Windows.Forms.Button();
            this.buttonToNext = new System.Windows.Forms.Button();
            this.buttonToPrev = new System.Windows.Forms.Button();
            this.buttonTofirst = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorique)).BeginInit();
            this.groupBoxSearchDataGridView.SuspendLayout();
            this.panelAll.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
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
            // dataGridViewHistorique
            // 
            this.dataGridViewHistorique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistorique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHistorique.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewHistorique.Name = "dataGridViewHistorique";
            this.dataGridViewHistorique.Size = new System.Drawing.Size(709, 567);
            this.dataGridViewHistorique.TabIndex = 9;
            this.dataGridViewHistorique.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHistorique_CellContentClick);
            this.dataGridViewHistorique.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewHistorique_ColumnHeaderMouseClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(713, 13);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 26);
            this.buttonDelete.TabIndex = 10;
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
            this.groupBoxSearchDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSearchDataGridView.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSearchDataGridView.Name = "groupBoxSearchDataGridView";
            this.groupBoxSearchDataGridView.Size = new System.Drawing.Size(800, 71);
            this.groupBoxSearchDataGridView.TabIndex = 10;
            this.groupBoxSearchDataGridView.TabStop = false;
            this.groupBoxSearchDataGridView.Text = "Chercher  ";
            // 
            // buttonSearchDataGridView
            // 
            this.buttonSearchDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchDataGridView.Location = new System.Drawing.Point(707, 27);
            this.buttonSearchDataGridView.Name = "buttonSearchDataGridView";
            this.buttonSearchDataGridView.Size = new System.Drawing.Size(87, 29);
            this.buttonSearchDataGridView.TabIndex = 4;
            this.buttonSearchDataGridView.Text = "Chercher";
            this.buttonSearchDataGridView.UseVisualStyleBackColor = true;
            this.buttonSearchDataGridView.Click += new System.EventHandler(this.buttonSearchDataGridView_Click);
            // 
            // dateTimePickerHistorique
            // 
            this.dateTimePickerHistorique.CustomFormat = "dd/mm/yyyy";
            this.dateTimePickerHistorique.Location = new System.Drawing.Point(390, 29);
            this.dateTimePickerHistorique.Name = "dateTimePickerHistorique";
            this.dateTimePickerHistorique.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerHistorique.TabIndex = 3;
            this.dateTimePickerHistorique.Value = new System.DateTime(2020, 1, 26, 0, 0, 0, 0);
            // 
            // labelFilterByDateTimePicker
            // 
            this.labelFilterByDateTimePicker.AutoSize = true;
            this.labelFilterByDateTimePicker.Location = new System.Drawing.Point(315, 35);
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
            this.comboBoxFilterItems.Location = new System.Drawing.Point(208, 32);
            this.comboBoxFilterItems.Name = "comboBoxFilterItems";
            this.comboBoxFilterItems.Size = new System.Drawing.Size(101, 21);
            this.comboBoxFilterItems.TabIndex = 2;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(146, 35);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(56, 13);
            this.labelFilter.TabIndex = 2;
            this.labelFilter.Text = "Filtrer par :";
            // 
            // textBoxStrings
            // 
            this.textBoxStrings.Location = new System.Drawing.Point(42, 32);
            this.textBoxStrings.Name = "textBoxStrings";
            this.textBoxStrings.Size = new System.Drawing.Size(98, 20);
            this.textBoxStrings.TabIndex = 1;
            // 
            // labelWords
            // 
            this.labelWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelWords.AutoSize = true;
            this.labelWords.Location = new System.Drawing.Point(0, 35);
            this.labelWords.Name = "labelWords";
            this.labelWords.Size = new System.Drawing.Size(36, 13);
            this.labelWords.TabIndex = 0;
            this.labelWords.Text = "Mots :";
            // 
            // panelAll
            // 
            this.panelAll.Controls.Add(this.panelFooter);
            this.panelAll.Controls.Add(this.panel2);
            this.panelAll.Controls.Add(this.panelHeader);
            this.panelAll.Controls.Add(this.splitContainer1);
            this.panelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAll.Location = new System.Drawing.Point(0, 0);
            this.panelAll.Name = "panelAll";
            this.panelAll.Size = new System.Drawing.Size(800, 567);
            this.panelAll.TabIndex = 11;
            this.panelAll.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAll_Paint);
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.buttonDelete);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 516);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(800, 51);
            this.panelFooter.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxSearchDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 71);
            this.panel2.TabIndex = 6;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelHistoriques);
            this.panelHeader.Controls.Add(this.labelCloseHistoriques);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 65);
            this.panelHeader.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonToLast);
            this.splitContainer1.Panel1.Controls.Add(this.buttonToNext);
            this.splitContainer1.Panel1.Controls.Add(this.buttonToPrev);
            this.splitContainer1.Panel1.Controls.Add(this.buttonTofirst);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewHistorique);
            this.splitContainer1.Size = new System.Drawing.Size(800, 567);
            this.splitContainer1.SplitterDistance = 87;
            this.splitContainer1.TabIndex = 11;
            // 
            // buttonToLast
            // 
            this.buttonToLast.Location = new System.Drawing.Point(9, 366);
            this.buttonToLast.Name = "buttonToLast";
            this.buttonToLast.Size = new System.Drawing.Size(65, 48);
            this.buttonToLast.TabIndex = 8;
            this.buttonToLast.UseVisualStyleBackColor = true;
            // 
            // buttonToNext
            // 
            this.buttonToNext.Location = new System.Drawing.Point(9, 312);
            this.buttonToNext.Name = "buttonToNext";
            this.buttonToNext.Size = new System.Drawing.Size(65, 48);
            this.buttonToNext.TabIndex = 7;
            this.buttonToNext.UseVisualStyleBackColor = true;
            // 
            // buttonToPrev
            // 
            this.buttonToPrev.Location = new System.Drawing.Point(9, 258);
            this.buttonToPrev.Name = "buttonToPrev";
            this.buttonToPrev.Size = new System.Drawing.Size(65, 48);
            this.buttonToPrev.TabIndex = 6;
            this.buttonToPrev.UseVisualStyleBackColor = true;
            // 
            // buttonTofirst
            // 
            this.buttonTofirst.Location = new System.Drawing.Point(9, 204);
            this.buttonTofirst.Name = "buttonTofirst";
            this.buttonTofirst.Size = new System.Drawing.Size(65, 48);
            this.buttonTofirst.TabIndex = 5;
            this.buttonTofirst.UseVisualStyleBackColor = true;
            // 
            // frmHistoriques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.panelAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHistoriques";
            this.Text = "frmHistoriques";
            this.Load += new System.EventHandler(this.frmHistoriques_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmHistoriques_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorique)).EndInit();
            this.groupBoxSearchDataGridView.ResumeLayout(false);
            this.groupBoxSearchDataGridView.PerformLayout();
            this.panelAll.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonToLast;
        private System.Windows.Forms.Button buttonToNext;
        private System.Windows.Forms.Button buttonToPrev;
        private System.Windows.Forms.Button buttonTofirst;
    }
}