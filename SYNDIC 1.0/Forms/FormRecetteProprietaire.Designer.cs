namespace SYNDIC_1._0.Forms
{
    partial class FormRecetteProprietaire
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecetteProprietaire));
            this.splitContainerRecetteProprietaire = new System.Windows.Forms.SplitContainer();
            this.buttonListDocs = new System.Windows.Forms.Button();
            this.buttonImprimerRecette = new System.Windows.Forms.Button();
            this.labelListeProprietaire = new System.Windows.Forms.Label();
            this.comboBoxProprietaire = new System.Windows.Forms.ComboBox();
            this.splitContainerRecette = new System.Windows.Forms.SplitContainer();
            this.dataGridViewRecette = new System.Windows.Forms.DataGridView();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonAjouterRecette = new System.Windows.Forms.Button();
            this.buttonSupprimerRecette = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecetteProprietaire)).BeginInit();
            this.splitContainerRecetteProprietaire.Panel1.SuspendLayout();
            this.splitContainerRecetteProprietaire.Panel2.SuspendLayout();
            this.splitContainerRecetteProprietaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecette)).BeginInit();
            this.splitContainerRecette.Panel1.SuspendLayout();
            this.splitContainerRecette.Panel2.SuspendLayout();
            this.splitContainerRecette.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecette)).BeginInit();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerRecetteProprietaire
            // 
            this.splitContainerRecetteProprietaire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRecetteProprietaire.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRecetteProprietaire.Name = "splitContainerRecetteProprietaire";
            this.splitContainerRecetteProprietaire.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRecetteProprietaire.Panel1
            // 
            this.splitContainerRecetteProprietaire.Panel1.Controls.Add(this.buttonListDocs);
            this.splitContainerRecetteProprietaire.Panel1.Controls.Add(this.buttonImprimerRecette);
            this.splitContainerRecetteProprietaire.Panel1.Controls.Add(this.labelListeProprietaire);
            this.splitContainerRecetteProprietaire.Panel1.Controls.Add(this.comboBoxProprietaire);
            // 
            // splitContainerRecetteProprietaire.Panel2
            // 
            this.splitContainerRecetteProprietaire.Panel2.Controls.Add(this.splitContainerRecette);
            this.splitContainerRecetteProprietaire.Size = new System.Drawing.Size(800, 450);
            this.splitContainerRecetteProprietaire.SplitterDistance = 68;
            this.splitContainerRecetteProprietaire.TabIndex = 0;
            // 
            // buttonListDocs
            // 
            this.buttonListDocs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.buttonListDocs.Location = new System.Drawing.Point(393, 26);
            this.buttonListDocs.Name = "buttonListDocs";
            this.buttonListDocs.Size = new System.Drawing.Size(195, 35);
            this.buttonListDocs.TabIndex = 1;
            this.buttonListDocs.Text = "Listes Documents";
            this.buttonListDocs.UseVisualStyleBackColor = false;
            this.buttonListDocs.Click += new System.EventHandler(this.buttonListDocs_Click);
            // 
            // buttonImprimerRecette
            // 
            this.buttonImprimerRecette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImprimerRecette.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonImprimerRecette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonImprimerRecette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImprimerRecette.FlatAppearance.BorderSize = 0;
            this.buttonImprimerRecette.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonImprimerRecette.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonImprimerRecette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimerRecette.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimerRecette.ForeColor = System.Drawing.Color.White;
            this.buttonImprimerRecette.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonImprimerRecette.Location = new System.Drawing.Point(609, 26);
            this.buttonImprimerRecette.Name = "buttonImprimerRecette";
            this.buttonImprimerRecette.Size = new System.Drawing.Size(182, 35);
            this.buttonImprimerRecette.TabIndex = 2;
            this.buttonImprimerRecette.Text = "Imprimer Recette";
            this.buttonImprimerRecette.UseVisualStyleBackColor = false;
            this.buttonImprimerRecette.Click += new System.EventHandler(this.buttonImprimerRecette_Click);
            // 
            // labelListeProprietaire
            // 
            this.labelListeProprietaire.AutoSize = true;
            this.labelListeProprietaire.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListeProprietaire.Location = new System.Drawing.Point(15, 11);
            this.labelListeProprietaire.Name = "labelListeProprietaire";
            this.labelListeProprietaire.Size = new System.Drawing.Size(106, 17);
            this.labelListeProprietaire.TabIndex = 3;
            this.labelListeProprietaire.Text = "Les Propriétaire :";
            // 
            // comboBoxProprietaire
            // 
            this.comboBoxProprietaire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProprietaire.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProprietaire.FormattingEnabled = true;
            this.comboBoxProprietaire.Location = new System.Drawing.Point(12, 33);
            this.comboBoxProprietaire.Name = "comboBoxProprietaire";
            this.comboBoxProprietaire.Size = new System.Drawing.Size(297, 25);
            this.comboBoxProprietaire.TabIndex = 0;
            // 
            // splitContainerRecette
            // 
            this.splitContainerRecette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRecette.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRecette.Name = "splitContainerRecette";
            this.splitContainerRecette.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRecette.Panel1
            // 
            this.splitContainerRecette.Panel1.Controls.Add(this.dataGridViewRecette);
            this.splitContainerRecette.Panel1.Controls.Add(this.panelNavigation);
            // 
            // splitContainerRecette.Panel2
            // 
            this.splitContainerRecette.Panel2.Controls.Add(this.buttonAjouterRecette);
            this.splitContainerRecette.Panel2.Controls.Add(this.buttonSupprimerRecette);
            this.splitContainerRecette.Size = new System.Drawing.Size(800, 378);
            this.splitContainerRecette.SplitterDistance = 302;
            this.splitContainerRecette.TabIndex = 0;
            // 
            // dataGridViewRecette
            // 
            this.dataGridViewRecette.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridViewRecette.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRecette.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecette.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewRecette.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRecette.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRecette.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRecette.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRecette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRecette.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewRecette.Location = new System.Drawing.Point(57, 0);
            this.dataGridViewRecette.Name = "dataGridViewRecette";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRecette.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewRecette.RowHeadersWidth = 25;
            this.dataGridViewRecette.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRecette.Size = new System.Drawing.Size(743, 302);
            this.dataGridViewRecette.TabIndex = 5;
            // 
            // panelNavigation
            // 
            this.panelNavigation.Controls.Add(this.buttonLast);
            this.panelNavigation.Controls.Add(this.buttonPrevious);
            this.panelNavigation.Controls.Add(this.buttonNext);
            this.panelNavigation.Controls.Add(this.buttonFirst);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(57, 302);
            this.panelNavigation.TabIndex = 3;
            // 
            // buttonLast
            // 
            this.buttonLast.BackColor = System.Drawing.Color.Transparent;
            this.buttonLast.FlatAppearance.BorderSize = 0;
            this.buttonLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast.Image = global::SYNDIC_1._0.Properties.Resources.down_chevron_2;
            this.buttonLast.Location = new System.Drawing.Point(8, 234);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(39, 39);
            this.buttonLast.TabIndex = 3;
            this.buttonLast.UseVisualStyleBackColor = false;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrevious.FlatAppearance.BorderSize = 0;
            this.buttonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevious.Image = global::SYNDIC_1._0.Properties.Resources.up_chevron_1111;
            this.buttonPrevious.Location = new System.Drawing.Point(8, 92);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(39, 39);
            this.buttonPrevious.TabIndex = 2;
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Transparent;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Image = global::SYNDIC_1._0.Properties.Resources.down_chevron_1;
            this.buttonNext.Location = new System.Drawing.Point(8, 163);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(39, 39);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.BackColor = System.Drawing.Color.Transparent;
            this.buttonFirst.FlatAppearance.BorderSize = 0;
            this.buttonFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFirst.Image = global::SYNDIC_1._0.Properties.Resources.up_chevron_2222;
            this.buttonFirst.Location = new System.Drawing.Point(8, 21);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(39, 39);
            this.buttonFirst.TabIndex = 4;
            this.buttonFirst.UseVisualStyleBackColor = false;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonAjouterRecette
            // 
            this.buttonAjouterRecette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjouterRecette.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAjouterRecette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAjouterRecette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjouterRecette.FlatAppearance.BorderSize = 0;
            this.buttonAjouterRecette.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonAjouterRecette.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonAjouterRecette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterRecette.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterRecette.ForeColor = System.Drawing.Color.White;
            this.buttonAjouterRecette.Image = ((System.Drawing.Image)(resources.GetObject("buttonAjouterRecette.Image")));
            this.buttonAjouterRecette.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouterRecette.Location = new System.Drawing.Point(269, 10);
            this.buttonAjouterRecette.Name = "buttonAjouterRecette";
            this.buttonAjouterRecette.Size = new System.Drawing.Size(260, 53);
            this.buttonAjouterRecette.TabIndex = 1;
            this.buttonAjouterRecette.Text = "Ajouter Recette";
            this.buttonAjouterRecette.UseVisualStyleBackColor = false;
            this.buttonAjouterRecette.Click += new System.EventHandler(this.buttonAjouterRecette_Click);
            // 
            // buttonSupprimerRecette
            // 
            this.buttonSupprimerRecette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSupprimerRecette.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSupprimerRecette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSupprimerRecette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSupprimerRecette.FlatAppearance.BorderSize = 0;
            this.buttonSupprimerRecette.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonSupprimerRecette.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonSupprimerRecette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerRecette.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimerRecette.ForeColor = System.Drawing.Color.White;
            this.buttonSupprimerRecette.Image = global::SYNDIC_1._0.Properties.Resources.delete;
            this.buttonSupprimerRecette.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupprimerRecette.Location = new System.Drawing.Point(535, 10);
            this.buttonSupprimerRecette.Name = "buttonSupprimerRecette";
            this.buttonSupprimerRecette.Size = new System.Drawing.Size(262, 53);
            this.buttonSupprimerRecette.TabIndex = 2;
            this.buttonSupprimerRecette.Text = "Supprimer Recette";
            this.buttonSupprimerRecette.UseVisualStyleBackColor = false;
            this.buttonSupprimerRecette.Click += new System.EventHandler(this.buttonSupprimerRecette_Click);
            // 
            // FormRecetteProprietaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainerRecetteProprietaire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRecetteProprietaire";
            this.Text = "FormRecetteProprietaire";
            this.Load += new System.EventHandler(this.FormRecetteProprietaire_Load);
            this.splitContainerRecetteProprietaire.Panel1.ResumeLayout(false);
            this.splitContainerRecetteProprietaire.Panel1.PerformLayout();
            this.splitContainerRecetteProprietaire.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecetteProprietaire)).EndInit();
            this.splitContainerRecetteProprietaire.ResumeLayout(false);
            this.splitContainerRecette.Panel1.ResumeLayout(false);
            this.splitContainerRecette.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecette)).EndInit();
            this.splitContainerRecette.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecette)).EndInit();
            this.panelNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerRecetteProprietaire;
        private System.Windows.Forms.Button buttonImprimerRecette;
        private System.Windows.Forms.Label labelListeProprietaire;
        private System.Windows.Forms.ComboBox comboBoxProprietaire;
        private System.Windows.Forms.SplitContainer splitContainerRecette;
        private System.Windows.Forms.DataGridView dataGridViewRecette;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonAjouterRecette;
        private System.Windows.Forms.Button buttonSupprimerRecette;
        private System.Windows.Forms.Button buttonListDocs;
    }
}