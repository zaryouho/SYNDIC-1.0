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
            this.splitContainerListeProprietaire = new System.Windows.Forms.SplitContainer();
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
            this.splitContainerListeProprietaire.Panel1.Controls.Add(this.buttonRechercher);
            this.splitContainerListeProprietaire.Panel1.Controls.Add(this.textBoxrechercher);
            // 
            // splitContainerListeProprietaire.Panel2
            // 
            this.splitContainerListeProprietaire.Panel2.Controls.Add(this.splitContainerListeProprietaireBody);
            this.splitContainerListeProprietaire.Panel2.Controls.Add(this.tableLayoutPanelProprietaireBottom);
            this.splitContainerListeProprietaire.Size = new System.Drawing.Size(800, 450);
            this.splitContainerListeProprietaire.SplitterDistance = 64;
            this.splitContainerListeProprietaire.TabIndex = 0;
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(229, 26);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(98, 20);
            this.buttonRechercher.TabIndex = 24;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // textBoxrechercher
            // 
            this.textBoxrechercher.Location = new System.Drawing.Point(21, 26);
            this.textBoxrechercher.Name = "textBoxrechercher";
            this.textBoxrechercher.Size = new System.Drawing.Size(202, 20);
            this.textBoxrechercher.TabIndex = 23;
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
            this.buttonLast.Location = new System.Drawing.Point(18, 230);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(39, 31);
            this.buttonLast.TabIndex = 30;
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(18, 175);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(39, 31);
            this.buttonNext.TabIndex = 29;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonprevious
            // 
            this.buttonprevious.Location = new System.Drawing.Point(18, 120);
            this.buttonprevious.Name = "buttonprevious";
            this.buttonprevious.Size = new System.Drawing.Size(39, 31);
            this.buttonprevious.TabIndex = 28;
            this.buttonprevious.UseVisualStyleBackColor = true;
            this.buttonprevious.Click += new System.EventHandler(this.buttonprevious_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(18, 65);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(39, 31);
            this.buttonFirst.TabIndex = 27;
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // dataGridViewProprietaires
            // 
            this.dataGridViewProprietaires.AllowUserToAddRows = false;
            this.dataGridViewProprietaires.AllowUserToDeleteRows = false;
            this.dataGridViewProprietaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProprietaires.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProprietaires.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProprietaires.Name = "dataGridViewProprietaires";
            this.dataGridViewProprietaires.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProprietaires.Size = new System.Drawing.Size(722, 327);
            this.dataGridViewProprietaires.TabIndex = 21;
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
            this.buttonAjouterProprietaire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouterProprietaire.Location = new System.Drawing.Point(3, 3);
            this.buttonAjouterProprietaire.Name = "buttonAjouterProprietaire";
            this.buttonAjouterProprietaire.Size = new System.Drawing.Size(260, 49);
            this.buttonAjouterProprietaire.TabIndex = 8;
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
            this.buttonSupprimerProprietaire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupprimerProprietaire.Location = new System.Drawing.Point(535, 3);
            this.buttonSupprimerProprietaire.Name = "buttonSupprimerProprietaire";
            this.buttonSupprimerProprietaire.Size = new System.Drawing.Size(262, 49);
            this.buttonSupprimerProprietaire.TabIndex = 10;
            this.buttonSupprimerProprietaire.Text = "Supprimer Propriétaire";
            this.buttonSupprimerProprietaire.UseVisualStyleBackColor = false;
            this.buttonSupprimerProprietaire.Click += new System.EventHandler(this.buttonSupprimerProprietaire_Click);
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
            this.buttonModifierProprietaire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModifierProprietaire.Location = new System.Drawing.Point(269, 3);
            this.buttonModifierProprietaire.Name = "buttonModifierProprietaire";
            this.buttonModifierProprietaire.Size = new System.Drawing.Size(260, 49);
            this.buttonModifierProprietaire.TabIndex = 9;
            this.buttonModifierProprietaire.Text = "Modifier Propriétaire";
            this.buttonModifierProprietaire.UseVisualStyleBackColor = false;
            this.buttonModifierProprietaire.Click += new System.EventHandler(this.buttonModifierProprietaire_Click);
            // 
            // FormListeProprietaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}