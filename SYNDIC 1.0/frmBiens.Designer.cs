namespace SYNDIC_1._0
{
    partial class frmBiens
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
            this.labelBiens = new System.Windows.Forms.Label();
            this.labelCloseBiens = new System.Windows.Forms.Label();
            this.panelHead = new System.Windows.Forms.Panel();
            this.splitContainerBiens = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelFinanceTitle = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSsBiensEcheances = new System.Windows.Forms.Button();
            this.buttonSsBiensEchangeProprietaire = new System.Windows.Forms.Button();
            this.buttonSsBiensListe = new System.Windows.Forms.Button();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBiens)).BeginInit();
            this.splitContainerBiens.Panel1.SuspendLayout();
            this.splitContainerBiens.SuspendLayout();
            this.tableLayoutPanelFinanceTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBiens
            // 
            this.labelBiens.AutoSize = true;
            this.labelBiens.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBiens.Location = new System.Drawing.Point(368, 15);
            this.labelBiens.Name = "labelBiens";
            this.labelBiens.Size = new System.Drawing.Size(76, 30);
            this.labelBiens.TabIndex = 0;
            this.labelBiens.Text = "BIENS";
            // 
            // labelCloseBiens
            // 
            this.labelCloseBiens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCloseBiens.AutoSize = true;
            this.labelCloseBiens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseBiens.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCloseBiens.Location = new System.Drawing.Point(737, 4);
            this.labelCloseBiens.Name = "labelCloseBiens";
            this.labelCloseBiens.Size = new System.Drawing.Size(18, 18);
            this.labelCloseBiens.TabIndex = 1;
            this.labelCloseBiens.Text = "X";
            this.labelCloseBiens.Click += new System.EventHandler(this.labelCloseBiens_Click);
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.labelCloseBiens);
            this.panelHead.Controls.Add(this.labelBiens);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(759, 60);
            this.panelHead.TabIndex = 2;
            // 
            // splitContainerBiens
            // 
            this.splitContainerBiens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBiens.IsSplitterFixed = true;
            this.splitContainerBiens.Location = new System.Drawing.Point(0, 60);
            this.splitContainerBiens.Name = "splitContainerBiens";
            this.splitContainerBiens.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerBiens.Panel1
            // 
            this.splitContainerBiens.Panel1.Controls.Add(this.tableLayoutPanelFinanceTitle);
            this.splitContainerBiens.Size = new System.Drawing.Size(759, 540);
            this.splitContainerBiens.SplitterDistance = 58;
            this.splitContainerBiens.TabIndex = 3;
            // 
            // tableLayoutPanelFinanceTitle
            // 
            this.tableLayoutPanelFinanceTitle.ColumnCount = 3;
            this.tableLayoutPanelFinanceTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFinanceTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFinanceTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFinanceTitle.Controls.Add(this.buttonSsBiensEcheances, 2, 0);
            this.tableLayoutPanelFinanceTitle.Controls.Add(this.buttonSsBiensEchangeProprietaire, 1, 0);
            this.tableLayoutPanelFinanceTitle.Controls.Add(this.buttonSsBiensListe, 0, 0);
            this.tableLayoutPanelFinanceTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelFinanceTitle.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelFinanceTitle.Name = "tableLayoutPanelFinanceTitle";
            this.tableLayoutPanelFinanceTitle.RowCount = 1;
            this.tableLayoutPanelFinanceTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFinanceTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanelFinanceTitle.Size = new System.Drawing.Size(759, 48);
            this.tableLayoutPanelFinanceTitle.TabIndex = 7;
            // 
            // buttonSsBiensEcheances
            // 
            this.buttonSsBiensEcheances.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSsBiensEcheances.BackColor = System.Drawing.Color.Blue;
            this.buttonSsBiensEcheances.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSsBiensEcheances.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSsBiensEcheances.FlatAppearance.BorderSize = 0;
            this.buttonSsBiensEcheances.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonSsBiensEcheances.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonSsBiensEcheances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSsBiensEcheances.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSsBiensEcheances.ForeColor = System.Drawing.Color.White;
            this.buttonSsBiensEcheances.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSsBiensEcheances.Location = new System.Drawing.Point(509, 3);
            this.buttonSsBiensEcheances.Name = "buttonSsBiensEcheances";
            this.buttonSsBiensEcheances.Size = new System.Drawing.Size(247, 42);
            this.buttonSsBiensEcheances.TabIndex = 6;
            this.buttonSsBiensEcheances.Text = "Echéances";
            this.buttonSsBiensEcheances.UseVisualStyleBackColor = false;
            this.buttonSsBiensEcheances.Click += new System.EventHandler(this.buttonSsBiensEcheances_Click);
            // 
            // buttonSsBiensEchangeProprietaire
            // 
            this.buttonSsBiensEchangeProprietaire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSsBiensEchangeProprietaire.BackColor = System.Drawing.Color.Blue;
            this.buttonSsBiensEchangeProprietaire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSsBiensEchangeProprietaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSsBiensEchangeProprietaire.FlatAppearance.BorderSize = 0;
            this.buttonSsBiensEchangeProprietaire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonSsBiensEchangeProprietaire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonSsBiensEchangeProprietaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSsBiensEchangeProprietaire.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSsBiensEchangeProprietaire.ForeColor = System.Drawing.Color.White;
            this.buttonSsBiensEchangeProprietaire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSsBiensEchangeProprietaire.Location = new System.Drawing.Point(256, 3);
            this.buttonSsBiensEchangeProprietaire.Name = "buttonSsBiensEchangeProprietaire";
            this.buttonSsBiensEchangeProprietaire.Size = new System.Drawing.Size(247, 42);
            this.buttonSsBiensEchangeProprietaire.TabIndex = 8;
            this.buttonSsBiensEchangeProprietaire.Text = "Echange de propriétaire";
            this.buttonSsBiensEchangeProprietaire.UseVisualStyleBackColor = false;
            this.buttonSsBiensEchangeProprietaire.Click += new System.EventHandler(this.buttonSsBiensEchangeProprietaire_Click);
            // 
            // buttonSsBiensListe
            // 
            this.buttonSsBiensListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSsBiensListe.BackColor = System.Drawing.Color.Blue;
            this.buttonSsBiensListe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSsBiensListe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSsBiensListe.FlatAppearance.BorderSize = 0;
            this.buttonSsBiensListe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonSsBiensListe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonSsBiensListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSsBiensListe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSsBiensListe.ForeColor = System.Drawing.Color.White;
            this.buttonSsBiensListe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSsBiensListe.Location = new System.Drawing.Point(3, 3);
            this.buttonSsBiensListe.Name = "buttonSsBiensListe";
            this.buttonSsBiensListe.Size = new System.Drawing.Size(247, 42);
            this.buttonSsBiensListe.TabIndex = 7;
            this.buttonSsBiensListe.Text = "Liste des Biens";
            this.buttonSsBiensListe.UseVisualStyleBackColor = false;
            this.buttonSsBiensListe.Click += new System.EventHandler(this.buttonSsBiensListe_Click);
            // 
            // frmBiens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 600);
            this.Controls.Add(this.splitContainerBiens);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBiens";
            this.Text = "frmBiens";
            this.Load += new System.EventHandler(this.frmBiens_Load);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.splitContainerBiens.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBiens)).EndInit();
            this.splitContainerBiens.ResumeLayout(false);
            this.tableLayoutPanelFinanceTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBiens;
        private System.Windows.Forms.Label labelCloseBiens;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.SplitContainer splitContainerBiens;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFinanceTitle;
        private System.Windows.Forms.Button buttonSsBiensEcheances;
        private System.Windows.Forms.Button buttonSsBiensEchangeProprietaire;
        private System.Windows.Forms.Button buttonSsBiensListe;
    }
}