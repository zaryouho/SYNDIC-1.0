namespace SYNDIC_1._0
{
    partial class FormSociete
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelProprietaires = new System.Windows.Forms.Label();
            this.labelCloseSociete = new System.Windows.Forms.Label();
            this.tableLayoutPanelSociete = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSociete = new System.Windows.Forms.Button();
            this.buttonSocieteArchive = new System.Windows.Forms.Button();
            this.buttonAjouterSociete = new System.Windows.Forms.Button();
            this.panelIN = new System.Windows.Forms.Panel();
            this.tableLayoutPanelSocieteBottom = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAjouterSSociete = new System.Windows.Forms.Button();
            this.buttonSupprimerSociete = new System.Windows.Forms.Button();
            this.buttonModifierSociete = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonprevious = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.textBoxRechercher = new System.Windows.Forms.TextBox();
            this.dataGridViewSociete = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelSociete.SuspendLayout();
            this.panelIN.SuspendLayout();
            this.tableLayoutPanelSocieteBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSociete)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.labelProprietaires, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCloseSociete, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 49);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // labelProprietaires
            // 
            this.labelProprietaires.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProprietaires.AutoSize = true;
            this.labelProprietaires.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProprietaires.Location = new System.Drawing.Point(269, 0);
            this.labelProprietaires.Name = "labelProprietaires";
            this.labelProprietaires.Size = new System.Drawing.Size(260, 49);
            this.labelProprietaires.TabIndex = 1;
            this.labelProprietaires.Text = "Les Societes";
            this.labelProprietaires.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCloseSociete
            // 
            this.labelCloseSociete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCloseSociete.AutoSize = true;
            this.labelCloseSociete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseSociete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCloseSociete.Location = new System.Drawing.Point(779, 0);
            this.labelCloseSociete.Name = "labelCloseSociete";
            this.labelCloseSociete.Size = new System.Drawing.Size(18, 18);
            this.labelCloseSociete.TabIndex = 2;
            this.labelCloseSociete.Text = "X";
            this.labelCloseSociete.Click += new System.EventHandler(this.labelCloseSociete_Click);
            // 
            // tableLayoutPanelSociete
            // 
            this.tableLayoutPanelSociete.ColumnCount = 3;
            this.tableLayoutPanelSociete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSociete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSociete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSociete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSociete.Controls.Add(this.buttonSociete, 0, 0);
            this.tableLayoutPanelSociete.Controls.Add(this.buttonSocieteArchive, 2, 0);
            this.tableLayoutPanelSociete.Controls.Add(this.buttonAjouterSociete, 1, 0);
            this.tableLayoutPanelSociete.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelSociete.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanelSociete.Name = "tableLayoutPanelSociete";
            this.tableLayoutPanelSociete.RowCount = 1;
            this.tableLayoutPanelSociete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSociete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanelSociete.Size = new System.Drawing.Size(800, 43);
            this.tableLayoutPanelSociete.TabIndex = 24;
            // 
            // buttonSociete
            // 
            this.buttonSociete.BackColor = System.Drawing.Color.Blue;
            this.buttonSociete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSociete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSociete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSociete.FlatAppearance.BorderSize = 0;
            this.buttonSociete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonSociete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonSociete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSociete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSociete.ForeColor = System.Drawing.Color.White;
            this.buttonSociete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSociete.Location = new System.Drawing.Point(3, 3);
            this.buttonSociete.Name = "buttonSociete";
            this.buttonSociete.Size = new System.Drawing.Size(260, 37);
            this.buttonSociete.TabIndex = 8;
            this.buttonSociete.Text = "Societe";
            this.buttonSociete.UseVisualStyleBackColor = false;
            // 
            // buttonSocieteArchive
            // 
            this.buttonSocieteArchive.BackColor = System.Drawing.Color.Blue;
            this.buttonSocieteArchive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSocieteArchive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSocieteArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSocieteArchive.FlatAppearance.BorderSize = 0;
            this.buttonSocieteArchive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonSocieteArchive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonSocieteArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSocieteArchive.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSocieteArchive.ForeColor = System.Drawing.Color.White;
            this.buttonSocieteArchive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSocieteArchive.Location = new System.Drawing.Point(535, 3);
            this.buttonSocieteArchive.Name = "buttonSocieteArchive";
            this.buttonSocieteArchive.Size = new System.Drawing.Size(262, 37);
            this.buttonSocieteArchive.TabIndex = 10;
            this.buttonSocieteArchive.Text = "Societe arch.";
            this.buttonSocieteArchive.UseVisualStyleBackColor = false;
            // 
            // buttonAjouterSociete
            // 
            this.buttonAjouterSociete.BackColor = System.Drawing.Color.Blue;
            this.buttonAjouterSociete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAjouterSociete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjouterSociete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAjouterSociete.FlatAppearance.BorderSize = 0;
            this.buttonAjouterSociete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonAjouterSociete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonAjouterSociete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterSociete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterSociete.ForeColor = System.Drawing.Color.White;
            this.buttonAjouterSociete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouterSociete.Location = new System.Drawing.Point(269, 3);
            this.buttonAjouterSociete.Name = "buttonAjouterSociete";
            this.buttonAjouterSociete.Size = new System.Drawing.Size(260, 37);
            this.buttonAjouterSociete.TabIndex = 9;
            this.buttonAjouterSociete.Text = "Ajouter Societe";
            this.buttonAjouterSociete.UseVisualStyleBackColor = false;
            // 
            // panelIN
            // 
            this.panelIN.Controls.Add(this.tableLayoutPanelSocieteBottom);
            this.panelIN.Controls.Add(this.buttonLast);
            this.panelIN.Controls.Add(this.buttonNext);
            this.panelIN.Controls.Add(this.buttonprevious);
            this.panelIN.Controls.Add(this.buttonFirst);
            this.panelIN.Controls.Add(this.buttonRechercher);
            this.panelIN.Controls.Add(this.textBoxRechercher);
            this.panelIN.Controls.Add(this.dataGridViewSociete);
            this.panelIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIN.Location = new System.Drawing.Point(0, 92);
            this.panelIN.Name = "panelIN";
            this.panelIN.Size = new System.Drawing.Size(800, 358);
            this.panelIN.TabIndex = 28;
            // 
            // tableLayoutPanelSocieteBottom
            // 
            this.tableLayoutPanelSocieteBottom.ColumnCount = 3;
            this.tableLayoutPanelSocieteBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSocieteBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSocieteBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSocieteBottom.Controls.Add(this.buttonAjouterSSociete, 0, 0);
            this.tableLayoutPanelSocieteBottom.Controls.Add(this.buttonSupprimerSociete, 2, 0);
            this.tableLayoutPanelSocieteBottom.Controls.Add(this.buttonModifierSociete, 1, 0);
            this.tableLayoutPanelSocieteBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelSocieteBottom.Location = new System.Drawing.Point(0, 303);
            this.tableLayoutPanelSocieteBottom.Name = "tableLayoutPanelSocieteBottom";
            this.tableLayoutPanelSocieteBottom.RowCount = 1;
            this.tableLayoutPanelSocieteBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSocieteBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanelSocieteBottom.Size = new System.Drawing.Size(800, 55);
            this.tableLayoutPanelSocieteBottom.TabIndex = 12;
            // 
            // buttonAjouterSSociete
            // 
            this.buttonAjouterSSociete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjouterSSociete.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAjouterSSociete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAjouterSSociete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjouterSSociete.FlatAppearance.BorderSize = 0;
            this.buttonAjouterSSociete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonAjouterSSociete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonAjouterSSociete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterSSociete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterSSociete.ForeColor = System.Drawing.Color.White;
            this.buttonAjouterSSociete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouterSSociete.Location = new System.Drawing.Point(3, 3);
            this.buttonAjouterSSociete.Name = "buttonAjouterSSociete";
            this.buttonAjouterSSociete.Size = new System.Drawing.Size(260, 49);
            this.buttonAjouterSSociete.TabIndex = 8;
            this.buttonAjouterSSociete.Text = "Ajouter Societe";
            this.buttonAjouterSSociete.UseVisualStyleBackColor = false;
            this.buttonAjouterSSociete.Click += new System.EventHandler(this.buttonAjouterSSociete_Click_1);
            // 
            // buttonSupprimerSociete
            // 
            this.buttonSupprimerSociete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSupprimerSociete.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSupprimerSociete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSupprimerSociete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSupprimerSociete.FlatAppearance.BorderSize = 0;
            this.buttonSupprimerSociete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonSupprimerSociete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonSupprimerSociete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerSociete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimerSociete.ForeColor = System.Drawing.Color.White;
            this.buttonSupprimerSociete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupprimerSociete.Location = new System.Drawing.Point(535, 3);
            this.buttonSupprimerSociete.Name = "buttonSupprimerSociete";
            this.buttonSupprimerSociete.Size = new System.Drawing.Size(262, 49);
            this.buttonSupprimerSociete.TabIndex = 10;
            this.buttonSupprimerSociete.Text = "Supprimer Societe";
            this.buttonSupprimerSociete.UseVisualStyleBackColor = false;
            this.buttonSupprimerSociete.Click += new System.EventHandler(this.buttonSupprimerSociete_Click);
            // 
            // buttonModifierSociete
            // 
            this.buttonModifierSociete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModifierSociete.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonModifierSociete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonModifierSociete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModifierSociete.FlatAppearance.BorderSize = 0;
            this.buttonModifierSociete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonModifierSociete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonModifierSociete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifierSociete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifierSociete.ForeColor = System.Drawing.Color.White;
            this.buttonModifierSociete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModifierSociete.Location = new System.Drawing.Point(269, 3);
            this.buttonModifierSociete.Name = "buttonModifierSociete";
            this.buttonModifierSociete.Size = new System.Drawing.Size(260, 49);
            this.buttonModifierSociete.TabIndex = 9;
            this.buttonModifierSociete.Text = "Modifier Societe";
            this.buttonModifierSociete.UseVisualStyleBackColor = false;
            this.buttonModifierSociete.Click += new System.EventHandler(this.buttonModifierSociete_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(692, 211);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(39, 31);
            this.buttonLast.TabIndex = 11;
            this.buttonLast.Text = "<<";
            this.buttonLast.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(692, 156);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(39, 31);
            this.buttonNext.TabIndex = 10;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonprevious
            // 
            this.buttonprevious.Location = new System.Drawing.Point(692, 101);
            this.buttonprevious.Name = "buttonprevious";
            this.buttonprevious.Size = new System.Drawing.Size(39, 31);
            this.buttonprevious.TabIndex = 9;
            this.buttonprevious.Text = "<";
            this.buttonprevious.UseVisualStyleBackColor = true;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(692, 46);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(39, 31);
            this.buttonFirst.TabIndex = 8;
            this.buttonFirst.Text = ">>";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(222, 20);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(98, 20);
            this.buttonRechercher.TabIndex = 7;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            // 
            // textBoxRechercher
            // 
            this.textBoxRechercher.Location = new System.Drawing.Point(14, 20);
            this.textBoxRechercher.Name = "textBoxRechercher";
            this.textBoxRechercher.Size = new System.Drawing.Size(202, 20);
            this.textBoxRechercher.TabIndex = 6;
            // 
            // dataGridViewSociete
            // 
            this.dataGridViewSociete.AllowUserToAddRows = false;
            this.dataGridViewSociete.AllowUserToDeleteRows = false;
            this.dataGridViewSociete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSociete.Location = new System.Drawing.Point(12, 46);
            this.dataGridViewSociete.Name = "dataGridViewSociete";
            this.dataGridViewSociete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSociete.Size = new System.Drawing.Size(668, 196);
            this.dataGridViewSociete.TabIndex = 5;
            // 
            // FormSociete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelIN);
            this.Controls.Add(this.tableLayoutPanelSociete);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormSociete";
            this.Text = "FormSociete";
            this.Load += new System.EventHandler(this.FormSociete_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelSociete.ResumeLayout(false);
            this.panelIN.ResumeLayout(false);
            this.panelIN.PerformLayout();
            this.tableLayoutPanelSocieteBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSociete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelProprietaires;
        private System.Windows.Forms.Label labelCloseSociete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSociete;
        private System.Windows.Forms.Button buttonSociete;
        private System.Windows.Forms.Button buttonSocieteArchive;
        private System.Windows.Forms.Button buttonAjouterSociete;
        private System.Windows.Forms.Panel panelIN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSocieteBottom;
        private System.Windows.Forms.Button buttonAjouterSSociete;
        private System.Windows.Forms.Button buttonSupprimerSociete;
        private System.Windows.Forms.Button buttonModifierSociete;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonprevious;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.TextBox textBoxRechercher;
        private System.Windows.Forms.DataGridView dataGridViewSociete;
    }
}