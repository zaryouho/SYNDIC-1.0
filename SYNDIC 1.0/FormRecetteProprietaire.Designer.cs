namespace SYNDIC_1._0
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewRecette = new System.Windows.Forms.DataGridView();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonAjouterRecette = new System.Windows.Forms.Button();
            this.buttonSupprimerRecette = new System.Windows.Forms.Button();
            this.buttonModifierRecette = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecetteProprietaire)).BeginInit();
            this.splitContainerRecetteProprietaire.Panel1.SuspendLayout();
            this.splitContainerRecetteProprietaire.Panel2.SuspendLayout();
            this.splitContainerRecetteProprietaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainerRecetteProprietaire.Panel1.Controls.Add(this.buttonImprimerRecette);
            this.splitContainerRecetteProprietaire.Panel1.Controls.Add(this.labelListeProprietaire);
            this.splitContainerRecetteProprietaire.Panel1.Controls.Add(this.comboBoxProprietaire);
            // 
            // splitContainerRecetteProprietaire.Panel2
            // 
            this.splitContainerRecetteProprietaire.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainerRecetteProprietaire.Size = new System.Drawing.Size(800, 450);
            this.splitContainerRecetteProprietaire.SplitterDistance = 69;
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
            this.buttonImprimerRecette.Location = new System.Drawing.Point(610, 27);
            this.buttonImprimerRecette.Name = "buttonImprimerRecette";
            this.buttonImprimerRecette.Size = new System.Drawing.Size(182, 35);
            this.buttonImprimerRecette.TabIndex = 14;
            this.buttonImprimerRecette.Text = "Imprimer Recette";
            this.buttonImprimerRecette.UseVisualStyleBackColor = false;
            // 
            // labelListeProprietaire
            // 
            this.labelListeProprietaire.AutoSize = true;
            this.labelListeProprietaire.Location = new System.Drawing.Point(14, 16);
            this.labelListeProprietaire.Name = "labelListeProprietaire";
            this.labelListeProprietaire.Size = new System.Drawing.Size(86, 13);
            this.labelListeProprietaire.TabIndex = 1;
            this.labelListeProprietaire.Text = "Les Propriétaire :";
            // 
            // comboBoxProprietaire
            // 
            this.comboBoxProprietaire.FormattingEnabled = true;
            this.comboBoxProprietaire.Location = new System.Drawing.Point(17, 32);
            this.comboBoxProprietaire.Name = "comboBoxProprietaire";
            this.comboBoxProprietaire.Size = new System.Drawing.Size(297, 21);
            this.comboBoxProprietaire.TabIndex = 0;
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
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewRecette);
            this.splitContainer1.Panel1.Controls.Add(this.panelNavigation);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonAjouterRecette);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSupprimerRecette);
            this.splitContainer1.Panel2.Controls.Add(this.buttonModifierRecette);
            this.splitContainer1.Size = new System.Drawing.Size(800, 377);
            this.splitContainer1.SplitterDistance = 302;
            this.splitContainer1.TabIndex = 0;
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
            this.dataGridViewRecette.TabIndex = 3;
            this.dataGridViewRecette.DoubleClick += new System.EventHandler(this.dataGridViewRecette_DoubleClick);
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
            this.panelNavigation.TabIndex = 2;
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(11, 234);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(39, 39);
            this.buttonLast.TabIndex = 21;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(8, 92);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(39, 39);
            this.buttonPrevious.TabIndex = 19;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(11, 163);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(39, 39);
            this.buttonNext.TabIndex = 20;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(8, 21);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(39, 39);
            this.buttonFirst.TabIndex = 18;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
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
            this.buttonAjouterRecette.Location = new System.Drawing.Point(3, 11);
            this.buttonAjouterRecette.Name = "buttonAjouterRecette";
            this.buttonAjouterRecette.Size = new System.Drawing.Size(260, 49);
            this.buttonAjouterRecette.TabIndex = 11;
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
            this.buttonSupprimerRecette.Location = new System.Drawing.Point(535, 11);
            this.buttonSupprimerRecette.Name = "buttonSupprimerRecette";
            this.buttonSupprimerRecette.Size = new System.Drawing.Size(262, 49);
            this.buttonSupprimerRecette.TabIndex = 13;
            this.buttonSupprimerRecette.Text = "Supprimer Recette";
            this.buttonSupprimerRecette.UseVisualStyleBackColor = false;
            this.buttonSupprimerRecette.Click += new System.EventHandler(this.buttonSupprimerRecette_Click);
            // 
            // buttonModifierRecette
            // 
            this.buttonModifierRecette.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModifierRecette.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonModifierRecette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonModifierRecette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModifierRecette.FlatAppearance.BorderSize = 0;
            this.buttonModifierRecette.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonModifierRecette.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonModifierRecette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifierRecette.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifierRecette.ForeColor = System.Drawing.Color.White;
            this.buttonModifierRecette.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModifierRecette.Location = new System.Drawing.Point(269, 11);
            this.buttonModifierRecette.Name = "buttonModifierRecette";
            this.buttonModifierRecette.Size = new System.Drawing.Size(260, 49);
            this.buttonModifierRecette.TabIndex = 12;
            this.buttonModifierRecette.Text = "Modifier Recette";
            this.buttonModifierRecette.UseVisualStyleBackColor = false;
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecette)).EndInit();
            this.panelNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerRecetteProprietaire;
        private System.Windows.Forms.Label labelListeProprietaire;
        private System.Windows.Forms.ComboBox comboBoxProprietaire;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewRecette;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonAjouterRecette;
        private System.Windows.Forms.Button buttonSupprimerRecette;
        private System.Windows.Forms.Button buttonImprimerRecette;
        private System.Windows.Forms.Button buttonModifierRecette;
    }
}