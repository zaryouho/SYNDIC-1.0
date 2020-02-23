namespace SYNDIC_1._0
{
    partial class FormListeBien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainerListeBien = new System.Windows.Forms.SplitContainer();
            this.comboBoxBloc = new System.Windows.Forms.ComboBox();
            this.textBoxRechercher = new System.Windows.Forms.TextBox();
            this.labelRechercher = new System.Windows.Forms.Label();
            this.buttonChercher = new System.Windows.Forms.Button();
            this.comboBoxImmeuble = new System.Windows.Forms.ComboBox();
            this.labelImmeuble = new System.Windows.Forms.Label();
            this.labelBloc = new System.Windows.Forms.Label();
            this.splitContainerBody = new System.Windows.Forms.SplitContainer();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.dataGridViewBien = new System.Windows.Forms.DataGridView();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.buttonAjouterBien = new System.Windows.Forms.Button();
            this.buttonListDocs = new System.Windows.Forms.Button();
            this.buttonModifierBien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerListeBien)).BeginInit();
            this.splitContainerListeBien.Panel1.SuspendLayout();
            this.splitContainerListeBien.Panel2.SuspendLayout();
            this.splitContainerListeBien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBody)).BeginInit();
            this.splitContainerBody.Panel1.SuspendLayout();
            this.splitContainerBody.Panel2.SuspendLayout();
            this.splitContainerBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBien)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerListeBien
            // 
            this.splitContainerListeBien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerListeBien.Location = new System.Drawing.Point(0, 0);
            this.splitContainerListeBien.Name = "splitContainerListeBien";
            this.splitContainerListeBien.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerListeBien.Panel1
            // 
            this.splitContainerListeBien.Panel1.Controls.Add(this.comboBoxBloc);
            this.splitContainerListeBien.Panel1.Controls.Add(this.textBoxRechercher);
            this.splitContainerListeBien.Panel1.Controls.Add(this.labelRechercher);
            this.splitContainerListeBien.Panel1.Controls.Add(this.buttonChercher);
            this.splitContainerListeBien.Panel1.Controls.Add(this.comboBoxImmeuble);
            this.splitContainerListeBien.Panel1.Controls.Add(this.labelImmeuble);
            this.splitContainerListeBien.Panel1.Controls.Add(this.labelBloc);
            // 
            // splitContainerListeBien.Panel2
            // 
            this.splitContainerListeBien.Panel2.Controls.Add(this.splitContainerBody);
            this.splitContainerListeBien.Panel2.Controls.Add(this.panelFooter);
            this.splitContainerListeBien.Size = new System.Drawing.Size(800, 450);
            this.splitContainerListeBien.SplitterDistance = 77;
            this.splitContainerListeBien.TabIndex = 0;
            // 
            // comboBoxBloc
            // 
            this.comboBoxBloc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBloc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBloc.FormattingEnabled = true;
            this.comboBoxBloc.Location = new System.Drawing.Point(357, 32);
            this.comboBoxBloc.Name = "comboBoxBloc";
            this.comboBoxBloc.Size = new System.Drawing.Size(193, 25);
            this.comboBoxBloc.TabIndex = 2;
            // 
            // textBoxRechercher
            // 
            this.textBoxRechercher.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRechercher.Location = new System.Drawing.Point(12, 35);
            this.textBoxRechercher.Name = "textBoxRechercher";
            this.textBoxRechercher.Size = new System.Drawing.Size(165, 22);
            this.textBoxRechercher.TabIndex = 0;
            this.textBoxRechercher.TextChanged += new System.EventHandler(this.textBoxRechercher_TextChanged);
            this.textBoxRechercher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRechercher_KeyPress);
            // 
            // labelRechercher
            // 
            this.labelRechercher.AutoSize = true;
            this.labelRechercher.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRechercher.Location = new System.Drawing.Point(12, 12);
            this.labelRechercher.Name = "labelRechercher";
            this.labelRechercher.Size = new System.Drawing.Size(83, 17);
            this.labelRechercher.TabIndex = 0;
            this.labelRechercher.Text = "Rechercher :";
            // 
            // buttonChercher
            // 
            this.buttonChercher.Enabled = false;
            this.buttonChercher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.buttonChercher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.buttonChercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChercher.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChercher.Location = new System.Drawing.Point(183, 29);
            this.buttonChercher.Name = "buttonChercher";
            this.buttonChercher.Size = new System.Drawing.Size(100, 28);
            this.buttonChercher.TabIndex = 1;
            this.buttonChercher.Text = "Rechercher";
            this.buttonChercher.UseVisualStyleBackColor = true;
            this.buttonChercher.Click += new System.EventHandler(this.buttonChercher_Click);
            // 
            // comboBoxImmeuble
            // 
            this.comboBoxImmeuble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxImmeuble.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxImmeuble.FormattingEnabled = true;
            this.comboBoxImmeuble.Location = new System.Drawing.Point(593, 32);
            this.comboBoxImmeuble.Name = "comboBoxImmeuble";
            this.comboBoxImmeuble.Size = new System.Drawing.Size(193, 25);
            this.comboBoxImmeuble.TabIndex = 3;
            // 
            // labelImmeuble
            // 
            this.labelImmeuble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelImmeuble.AutoSize = true;
            this.labelImmeuble.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImmeuble.Location = new System.Drawing.Point(593, 12);
            this.labelImmeuble.Name = "labelImmeuble";
            this.labelImmeuble.Size = new System.Drawing.Size(162, 17);
            this.labelImmeuble.TabIndex = 13;
            this.labelImmeuble.Text = "Selectioner un Immeuble :";
            // 
            // labelBloc
            // 
            this.labelBloc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBloc.AutoSize = true;
            this.labelBloc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBloc.Location = new System.Drawing.Point(357, 12);
            this.labelBloc.Name = "labelBloc";
            this.labelBloc.Size = new System.Drawing.Size(129, 17);
            this.labelBloc.TabIndex = 12;
            this.labelBloc.Text = "Selectioner un Bloc :";
            // 
            // splitContainerBody
            // 
            this.splitContainerBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBody.IsSplitterFixed = true;
            this.splitContainerBody.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBody.Name = "splitContainerBody";
            // 
            // splitContainerBody.Panel1
            // 
            this.splitContainerBody.Panel1.Controls.Add(this.buttonLast);
            this.splitContainerBody.Panel1.Controls.Add(this.buttonPrevious);
            this.splitContainerBody.Panel1.Controls.Add(this.buttonNext);
            this.splitContainerBody.Panel1.Controls.Add(this.buttonFirst);
            // 
            // splitContainerBody.Panel2
            // 
            this.splitContainerBody.Panel2.Controls.Add(this.dataGridViewBien);
            this.splitContainerBody.Size = new System.Drawing.Size(800, 286);
            this.splitContainerBody.SplitterDistance = 70;
            this.splitContainerBody.TabIndex = 0;
            // 
            // buttonLast
            // 
            this.buttonLast.BackColor = System.Drawing.Color.Transparent;
            this.buttonLast.FlatAppearance.BorderSize = 0;
            this.buttonLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast.Image = global::SYNDIC_1._0.Properties.Resources.down_chevron_2;
            this.buttonLast.Location = new System.Drawing.Point(17, 230);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(39, 39);
            this.buttonLast.TabIndex = 6;
            this.buttonLast.UseVisualStyleBackColor = false;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrevious.FlatAppearance.BorderSize = 0;
            this.buttonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevious.Image = global::SYNDIC_1._0.Properties.Resources.up_chevron_1111;
            this.buttonPrevious.Location = new System.Drawing.Point(14, 88);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(39, 39);
            this.buttonPrevious.TabIndex = 5;
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Transparent;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Image = global::SYNDIC_1._0.Properties.Resources.down_chevron_1;
            this.buttonNext.Location = new System.Drawing.Point(17, 159);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(39, 39);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.BackColor = System.Drawing.Color.Transparent;
            this.buttonFirst.FlatAppearance.BorderSize = 0;
            this.buttonFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFirst.Image = global::SYNDIC_1._0.Properties.Resources.up_chevron_2222;
            this.buttonFirst.Location = new System.Drawing.Point(14, 17);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(39, 39);
            this.buttonFirst.TabIndex = 7;
            this.buttonFirst.UseVisualStyleBackColor = false;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // dataGridViewBien
            // 
            this.dataGridViewBien.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridViewBien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewBien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBien.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewBien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewBien.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBien.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewBien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBien.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewBien.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBien.Name = "dataGridViewBien";
            this.dataGridViewBien.ReadOnly = true;
            this.dataGridViewBien.RowHeadersWidth = 25;
            this.dataGridViewBien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBien.Size = new System.Drawing.Size(726, 286);
            this.dataGridViewBien.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.buttonAjouterBien);
            this.panelFooter.Controls.Add(this.buttonListDocs);
            this.panelFooter.Controls.Add(this.buttonModifierBien);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 286);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(800, 83);
            this.panelFooter.TabIndex = 2;
            // 
            // buttonAjouterBien
            // 
            this.buttonAjouterBien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjouterBien.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAjouterBien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAjouterBien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjouterBien.FlatAppearance.BorderSize = 0;
            this.buttonAjouterBien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonAjouterBien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonAjouterBien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterBien.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterBien.ForeColor = System.Drawing.Color.White;
            this.buttonAjouterBien.Image = global::SYNDIC_1._0.Properties.Resources.icons8_Plus_32;
            this.buttonAjouterBien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouterBien.Location = new System.Drawing.Point(376, 14);
            this.buttonAjouterBien.Name = "buttonAjouterBien";
            this.buttonAjouterBien.Size = new System.Drawing.Size(194, 53);

            this.buttonAjouterBien.TabIndex = 9;
            this.buttonAjouterBien.Text = "Ajouter le bien";

            this.buttonAjouterBien.UseVisualStyleBackColor = false;
            this.buttonAjouterBien.Click += new System.EventHandler(this.buttonAjouterBien_Click);
            // 
            // buttonListDocs
            // 
            this.buttonListDocs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonListDocs.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonListDocs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonListDocs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonListDocs.FlatAppearance.BorderSize = 0;
            this.buttonListDocs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonListDocs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonListDocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListDocs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListDocs.ForeColor = System.Drawing.Color.White;
            this.buttonListDocs.Image = global::SYNDIC_1._0.Properties.Resources.liste2;
            this.buttonListDocs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListDocs.Location = new System.Drawing.Point(17, 14);
            this.buttonListDocs.Name = "buttonListDocs";
            this.buttonListDocs.Size = new System.Drawing.Size(224, 53);

            this.buttonListDocs.TabIndex = 10;
            this.buttonListDocs.Text = "Listes Documents";

            this.buttonListDocs.UseVisualStyleBackColor = false;
            this.buttonListDocs.Click += new System.EventHandler(this.buttonListDocs_Click);
            // 
            // buttonModifierBien
            // 
            this.buttonModifierBien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModifierBien.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonModifierBien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonModifierBien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModifierBien.FlatAppearance.BorderSize = 0;
            this.buttonModifierBien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonModifierBien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonModifierBien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifierBien.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifierBien.ForeColor = System.Drawing.Color.White;
            this.buttonModifierBien.Image = global::SYNDIC_1._0.Properties.Resources.modifier;
            this.buttonModifierBien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModifierBien.Location = new System.Drawing.Point(578, 14);
            this.buttonModifierBien.Name = "buttonModifierBien";
            this.buttonModifierBien.Size = new System.Drawing.Size(208, 53);
            this.buttonModifierBien.TabIndex = 8;
            this.buttonModifierBien.Text = "Modifier le bien";
            this.buttonModifierBien.UseVisualStyleBackColor = false;
            this.buttonModifierBien.Click += new System.EventHandler(this.buttonModifierBien_Click);
            // 
            // FormListeBien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainerListeBien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListeBien";
            this.Text = "FormListeBien";
            this.Load += new System.EventHandler(this.FormListeBien_Load);
            this.splitContainerListeBien.Panel1.ResumeLayout(false);
            this.splitContainerListeBien.Panel1.PerformLayout();
            this.splitContainerListeBien.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerListeBien)).EndInit();
            this.splitContainerListeBien.ResumeLayout(false);
            this.splitContainerBody.Panel1.ResumeLayout(false);
            this.splitContainerBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBody)).EndInit();
            this.splitContainerBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBien)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerListeBien;
        private System.Windows.Forms.SplitContainer splitContainerBody;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.ComboBox comboBoxBloc;
        private System.Windows.Forms.TextBox textBoxRechercher;
        private System.Windows.Forms.Label labelRechercher;
        private System.Windows.Forms.Button buttonChercher;
        private System.Windows.Forms.ComboBox comboBoxImmeuble;
        private System.Windows.Forms.Label labelImmeuble;
        private System.Windows.Forms.Label labelBloc;
        private System.Windows.Forms.DataGridView dataGridViewBien;
        private System.Windows.Forms.Button buttonModifierBien;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonListDocs;
        private System.Windows.Forms.Button buttonAjouterBien;
    }
}