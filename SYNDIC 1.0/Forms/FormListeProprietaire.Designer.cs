namespace SYNDIC_1._0
{
    partial class FormListeProprietaire
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainerListeProprietaire = new System.Windows.Forms.SplitContainer();
            this.buttonListDocs = new System.Windows.Forms.Button();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.textBoxrechercher = new System.Windows.Forms.TextBox();
            this.splitContainerListeProprietaireBody = new System.Windows.Forms.SplitContainer();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonprevious = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.dataGridViewProprietaires = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelProprietaireBottom = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAjouterProprietaire = new System.Windows.Forms.Button();
            this.buttonSupprimerProprietaire = new System.Windows.Forms.Button();
            this.buttonModifierProprietaire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerListeProprietaire)).BeginInit();
            this.splitContainerListeProprietaire.Panel1.SuspendLayout();
            this.splitContainerListeProprietaire.Panel2.SuspendLayout();
            this.splitContainerListeProprietaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerListeProprietaireBody)).BeginInit();
            this.splitContainerListeProprietaireBody.Panel1.SuspendLayout();
            this.splitContainerListeProprietaireBody.Panel2.SuspendLayout();
            this.splitContainerListeProprietaireBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProprietaires)).BeginInit();
            this.tableLayoutPanelProprietaireBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerListeProprietaire
            // 
            this.splitContainerListeProprietaire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerListeProprietaire.Location = new System.Drawing.Point(0, 0);
            this.splitContainerListeProprietaire.Name = "splitContainerListeProprietaire";
            this.splitContainerListeProprietaire.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerListeProprietaire.Panel1
            // 
            this.splitContainerListeProprietaire.Panel1.Controls.Add(this.buttonListDocs);
            this.splitContainerListeProprietaire.Panel1.Controls.Add(this.buttonRechercher);
            this.splitContainerListeProprietaire.Panel1.Controls.Add(this.textBoxrechercher);
            this.splitContainerListeProprietaire.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainerListeProprietaire_Panel1_Paint);
            // 
            // splitContainerListeProprietaire.Panel2
            // 
            this.splitContainerListeProprietaire.Panel2.Controls.Add(this.splitContainerListeProprietaireBody);
            this.splitContainerListeProprietaire.Panel2.Controls.Add(this.tableLayoutPanelProprietaireBottom);
            this.splitContainerListeProprietaire.Size = new System.Drawing.Size(800, 450);
            this.splitContainerListeProprietaire.SplitterDistance = 64;
            this.splitContainerListeProprietaire.TabIndex = 0;
            // 
            // buttonListDocs
            // 
            this.buttonListDocs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonListDocs.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonListDocs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonListDocs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonListDocs.FlatAppearance.BorderSize = 0;
            this.buttonListDocs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonListDocs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonListDocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListDocs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListDocs.ForeColor = System.Drawing.Color.White;
            this.buttonListDocs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListDocs.Location = new System.Drawing.Point(593, 12);
            this.buttonListDocs.Name = "buttonListDocs";
            this.buttonListDocs.Size = new System.Drawing.Size(195, 35);
            this.buttonListDocs.TabIndex = 2;
            this.buttonListDocs.Text = "Listes Documents";
            this.buttonListDocs.UseVisualStyleBackColor = false;
            this.buttonListDocs.Click += new System.EventHandler(this.buttonListDocs_Click);
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.buttonRechercher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.buttonRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRechercher.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRechercher.Location = new System.Drawing.Point(239, 12);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(104, 34);
            this.buttonRechercher.TabIndex = 1;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // textBoxrechercher
            // 
            this.textBoxrechercher.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxrechercher.Location = new System.Drawing.Point(25, 18);
            this.textBoxrechercher.Name = "textBoxrechercher";
            this.textBoxrechercher.Size = new System.Drawing.Size(208, 22);
            this.textBoxrechercher.TabIndex = 0;
            this.textBoxrechercher.TextChanged += new System.EventHandler(this.textBoxrechercher_TextChanged);
            // 
            // splitContainerListeProprietaireBody
            // 
            this.splitContainerListeProprietaireBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerListeProprietaireBody.Location = new System.Drawing.Point(0, 0);
            this.splitContainerListeProprietaireBody.Name = "splitContainerListeProprietaireBody";
            // 
            // splitContainerListeProprietaireBody.Panel1
            // 
            this.splitContainerListeProprietaireBody.Panel1.Controls.Add(this.buttonLast);
            this.splitContainerListeProprietaireBody.Panel1.Controls.Add(this.buttonNext);
            this.splitContainerListeProprietaireBody.Panel1.Controls.Add(this.buttonprevious);
            this.splitContainerListeProprietaireBody.Panel1.Controls.Add(this.buttonFirst);
            // 
            // splitContainerListeProprietaireBody.Panel2
            // 
            this.splitContainerListeProprietaireBody.Panel2.Controls.Add(this.dataGridViewProprietaires);
            this.splitContainerListeProprietaireBody.Size = new System.Drawing.Size(800, 327);
            this.splitContainerListeProprietaireBody.SplitterDistance = 74;
            this.splitContainerListeProprietaireBody.TabIndex = 29;
            // 
            // buttonLast
            // 
            this.buttonLast.FlatAppearance.BorderSize = 0;
            this.buttonLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast.Image = global::SYNDIC_1._0.Properties.Resources.down_chevron_2;
            this.buttonLast.Location = new System.Drawing.Point(18, 251);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(39, 39);
            this.buttonLast.TabIndex = 2;
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Image = global::SYNDIC_1._0.Properties.Resources.down_chevron_1;
            this.buttonNext.Location = new System.Drawing.Point(18, 195);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(39, 39);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonprevious
            // 
            this.buttonprevious.FlatAppearance.BorderSize = 0;
            this.buttonprevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonprevious.Image = global::SYNDIC_1._0.Properties.Resources.up_chevron_1111;
            this.buttonprevious.Location = new System.Drawing.Point(18, 83);
            this.buttonprevious.Name = "buttonprevious";
            this.buttonprevious.Size = new System.Drawing.Size(39, 39);
            this.buttonprevious.TabIndex = 1;
            this.buttonprevious.UseVisualStyleBackColor = true;
            this.buttonprevious.Click += new System.EventHandler(this.buttonprevious_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.FlatAppearance.BorderSize = 0;
            this.buttonFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFirst.Image = global::SYNDIC_1._0.Properties.Resources.up_chevron_2222;
            this.buttonFirst.Location = new System.Drawing.Point(18, 27);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(39, 39);
            this.buttonFirst.TabIndex = 3;
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // dataGridViewProprietaires
            // 
            this.dataGridViewProprietaires.AllowUserToAddRows = false;
            this.dataGridViewProprietaires.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridViewProprietaires.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewProprietaires.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewProprietaires.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProprietaires.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewProprietaires.ColumnHeadersHeight = 40;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProprietaires.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewProprietaires.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProprietaires.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewProprietaires.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProprietaires.Name = "dataGridViewProprietaires";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProprietaires.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewProprietaires.RowHeadersWidth = 25;
            this.dataGridViewProprietaires.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProprietaires.Size = new System.Drawing.Size(722, 327);
            this.dataGridViewProprietaires.TabIndex = 4;
            // 
            // tableLayoutPanelProprietaireBottom
            // 
            this.tableLayoutPanelProprietaireBottom.ColumnCount = 3;
            this.tableLayoutPanelProprietaireBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelProprietaireBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelProprietaireBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelProprietaireBottom.Controls.Add(this.buttonAjouterProprietaire, 0, 0);
            this.tableLayoutPanelProprietaireBottom.Controls.Add(this.buttonSupprimerProprietaire, 2, 0);
            this.tableLayoutPanelProprietaireBottom.Controls.Add(this.buttonModifierProprietaire, 1, 0);
            this.tableLayoutPanelProprietaireBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelProprietaireBottom.Location = new System.Drawing.Point(0, 327);
            this.tableLayoutPanelProprietaireBottom.Name = "tableLayoutPanelProprietaireBottom";
            this.tableLayoutPanelProprietaireBottom.RowCount = 1;
            this.tableLayoutPanelProprietaireBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProprietaireBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanelProprietaireBottom.Size = new System.Drawing.Size(800, 55);
            this.tableLayoutPanelProprietaireBottom.TabIndex = 28;
            // 
            // buttonAjouterProprietaire
            // 
            this.buttonAjouterProprietaire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjouterProprietaire.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAjouterProprietaire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAjouterProprietaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjouterProprietaire.FlatAppearance.BorderSize = 0;
            this.buttonAjouterProprietaire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonAjouterProprietaire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonAjouterProprietaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterProprietaire.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterProprietaire.ForeColor = System.Drawing.Color.White;
            this.buttonAjouterProprietaire.Image = global::SYNDIC_1._0.Properties.Resources.add_prop;
            this.buttonAjouterProprietaire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouterProprietaire.Location = new System.Drawing.Point(3, 3);
            this.buttonAjouterProprietaire.Name = "buttonAjouterProprietaire";
            this.buttonAjouterProprietaire.Size = new System.Drawing.Size(260, 49);
            this.buttonAjouterProprietaire.TabIndex = 0;
            this.buttonAjouterProprietaire.Text = "Ajouter Propriétaire";
            this.buttonAjouterProprietaire.UseVisualStyleBackColor = false;
            this.buttonAjouterProprietaire.Click += new System.EventHandler(this.buttonAjouterProprietaire_Click);
            // 
            // buttonSupprimerProprietaire
            // 
            this.buttonSupprimerProprietaire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSupprimerProprietaire.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSupprimerProprietaire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSupprimerProprietaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSupprimerProprietaire.FlatAppearance.BorderSize = 0;
            this.buttonSupprimerProprietaire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonSupprimerProprietaire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonSupprimerProprietaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerProprietaire.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimerProprietaire.ForeColor = System.Drawing.Color.White;
            this.buttonSupprimerProprietaire.Image = global::SYNDIC_1._0.Properties.Resources.delete;
            this.buttonSupprimerProprietaire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupprimerProprietaire.Location = new System.Drawing.Point(535, 3);
            this.buttonSupprimerProprietaire.Name = "buttonSupprimerProprietaire";
            this.buttonSupprimerProprietaire.Size = new System.Drawing.Size(262, 49);
            this.buttonSupprimerProprietaire.TabIndex = 2;
            this.buttonSupprimerProprietaire.Text = "Supprimer Propriétaire";
            this.buttonSupprimerProprietaire.UseVisualStyleBackColor = false;
            // 
            // buttonModifierProprietaire
            // 
            this.buttonModifierProprietaire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModifierProprietaire.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonModifierProprietaire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonModifierProprietaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModifierProprietaire.FlatAppearance.BorderSize = 0;
            this.buttonModifierProprietaire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonModifierProprietaire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonModifierProprietaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifierProprietaire.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifierProprietaire.ForeColor = System.Drawing.Color.White;
            this.buttonModifierProprietaire.Image = global::SYNDIC_1._0.Properties.Resources.modifier;
            this.buttonModifierProprietaire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModifierProprietaire.Location = new System.Drawing.Point(269, 3);
            this.buttonModifierProprietaire.Name = "buttonModifierProprietaire";
            this.buttonModifierProprietaire.Size = new System.Drawing.Size(260, 49);
            this.buttonModifierProprietaire.TabIndex = 1;
            this.buttonModifierProprietaire.Text = "Modifier Propriétaire";
            this.buttonModifierProprietaire.UseVisualStyleBackColor = false;
            this.buttonModifierProprietaire.Click += new System.EventHandler(this.buttonModifierProprietaire_Click);
            // 
            // FormListeProprietaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainerListeProprietaire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListeProprietaire";
            this.Text = "FormListeProprietaire";
            this.Load += new System.EventHandler(this.FormListeProprietaire_Load);
            this.splitContainerListeProprietaire.Panel1.ResumeLayout(false);
            this.splitContainerListeProprietaire.Panel1.PerformLayout();
            this.splitContainerListeProprietaire.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerListeProprietaire)).EndInit();
            this.splitContainerListeProprietaire.ResumeLayout(false);
            this.splitContainerListeProprietaireBody.Panel1.ResumeLayout(false);
            this.splitContainerListeProprietaireBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerListeProprietaireBody)).EndInit();
            this.splitContainerListeProprietaireBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProprietaires)).EndInit();
            this.tableLayoutPanelProprietaireBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerListeProprietaire;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.TextBox textBoxrechercher;
        private System.Windows.Forms.SplitContainer splitContainerListeProprietaireBody;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonprevious;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.DataGridView dataGridViewProprietaires;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProprietaireBottom;
        private System.Windows.Forms.Button buttonAjouterProprietaire;
        private System.Windows.Forms.Button buttonSupprimerProprietaire;
        private System.Windows.Forms.Button buttonModifierProprietaire;
        private System.Windows.Forms.Button buttonListDocs;
    }
}