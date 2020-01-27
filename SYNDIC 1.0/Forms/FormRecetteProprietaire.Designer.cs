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
            this.splitContainerRecetteProprietaire = new System.Windows.Forms.SplitContainer();
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
            this.buttonListDocs = new System.Windows.Forms.Button();
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
            // buttonImprimerRecette
            // 
            this.buttonImprimerRecette.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.buttonImprimerRecette.TabIndex = 15;
            this.buttonImprimerRecette.Text = "Imprimer Recette";
            this.buttonImprimerRecette.UseVisualStyleBackColor = false;
            // 
            // labelListeProprietaire
            // 
            this.labelListeProprietaire.AutoSize = true;
            this.labelListeProprietaire.Location = new System.Drawing.Point(9, 13);
            this.labelListeProprietaire.Name = "labelListeProprietaire";
            this.labelListeProprietaire.Size = new System.Drawing.Size(86, 13);
            this.labelListeProprietaire.TabIndex = 3;
            this.labelListeProprietaire.Text = "Les Propriétaire :";
            // 
            // comboBoxProprietaire
            // 
            this.comboBoxProprietaire.FormattingEnabled = true;
            this.comboBoxProprietaire.Location = new System.Drawing.Point(12, 29);
            this.comboBoxProprietaire.Name = "comboBoxProprietaire";
            this.comboBoxProprietaire.Size = new System.Drawing.Size(297, 21);
            this.comboBoxProprietaire.TabIndex = 2;
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
            this.dataGridViewRecette.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecette.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRecette.Location = new System.Drawing.Point(57, 0);
            this.dataGridViewRecette.Name = "dataGridViewRecette";
            this.dataGridViewRecette.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRecette.Size = new System.Drawing.Size(743, 302);
            this.dataGridViewRecette.TabIndex = 4;
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
            this.buttonLast.Location = new System.Drawing.Point(11, 234);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(39, 39);
            this.buttonLast.TabIndex = 21;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(8, 92);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(39, 39);
            this.buttonPrevious.TabIndex = 19;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(11, 163);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(39, 39);
            this.buttonNext.TabIndex = 20;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(8, 21);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(39, 39);
            this.buttonFirst.TabIndex = 18;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonAjouterRecette
            // 
            this.buttonAjouterRecette.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjouterRecette.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAjouterRecette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAjouterRecette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjouterRecette.FlatAppearance.BorderSize = 0;
            this.buttonAjouterRecette.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonAjouterRecette.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonAjouterRecette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterRecette.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterRecette.ForeColor = System.Drawing.Color.White;
            this.buttonAjouterRecette.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouterRecette.Location = new System.Drawing.Point(269, 10);
            this.buttonAjouterRecette.Name = "buttonAjouterRecette";
            this.buttonAjouterRecette.Size = new System.Drawing.Size(260, 53);
            this.buttonAjouterRecette.TabIndex = 14;
            this.buttonAjouterRecette.Text = "Ajouter Recette";
            this.buttonAjouterRecette.UseVisualStyleBackColor = false;
            this.buttonAjouterRecette.Click += new System.EventHandler(this.buttonAjouterRecette_Click);
            // 
            // buttonSupprimerRecette
            // 
            this.buttonSupprimerRecette.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSupprimerRecette.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSupprimerRecette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSupprimerRecette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSupprimerRecette.FlatAppearance.BorderSize = 0;
            this.buttonSupprimerRecette.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonSupprimerRecette.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonSupprimerRecette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerRecette.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimerRecette.ForeColor = System.Drawing.Color.White;
            this.buttonSupprimerRecette.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupprimerRecette.Location = new System.Drawing.Point(535, 10);
            this.buttonSupprimerRecette.Name = "buttonSupprimerRecette";
            this.buttonSupprimerRecette.Size = new System.Drawing.Size(262, 53);
            this.buttonSupprimerRecette.TabIndex = 16;
            this.buttonSupprimerRecette.Text = "Supprimer Recette";
            this.buttonSupprimerRecette.UseVisualStyleBackColor = false;
            this.buttonSupprimerRecette.Click += new System.EventHandler(this.buttonSupprimerRecette_Click);
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
            this.buttonListDocs.Location = new System.Drawing.Point(398, 26);
            this.buttonListDocs.Name = "buttonListDocs";
            this.buttonListDocs.Size = new System.Drawing.Size(195, 35);
            this.buttonListDocs.TabIndex = 17;
            this.buttonListDocs.Text = "Listes Documents";
            this.buttonListDocs.UseVisualStyleBackColor = false;
            this.buttonListDocs.Click += new System.EventHandler(this.buttonListDocs_Click);
            // 
            // FormRecetteProprietaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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