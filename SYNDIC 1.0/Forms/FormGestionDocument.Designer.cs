namespace SYNDIC_1._0.Forms
{
    partial class FormGestionDocument
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
            this.dataGridViewListeDocuments = new System.Windows.Forms.DataGridView();
            this.buttonAjouterDocument = new System.Windows.Forms.Button();
            this.buttonAfficherDocument = new System.Windows.Forms.Button();
            this.buttonSupprimerDocument = new System.Windows.Forms.Button();
            this.panelHead = new System.Windows.Forms.Panel();
            this.labelHead = new System.Windows.Forms.Label();
            this.labelCloseHistoriques = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeDocuments)).BeginInit();
            this.panelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewListeDocuments
            // 
            this.dataGridViewListeDocuments.AllowUserToAddRows = false;
            this.dataGridViewListeDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListeDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeDocuments.Location = new System.Drawing.Point(12, 52);
            this.dataGridViewListeDocuments.Name = "dataGridViewListeDocuments";
            this.dataGridViewListeDocuments.Size = new System.Drawing.Size(500, 150);
            this.dataGridViewListeDocuments.TabIndex = 0;
            this.dataGridViewListeDocuments.SelectionChanged += new System.EventHandler(this.dataGridViewListeDocuments_SelectionChanged);
            // 
            // buttonAjouterDocument
            // 
            this.buttonAjouterDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjouterDocument.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAjouterDocument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAjouterDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjouterDocument.FlatAppearance.BorderSize = 0;
            this.buttonAjouterDocument.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonAjouterDocument.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonAjouterDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterDocument.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterDocument.ForeColor = System.Drawing.Color.White;
            this.buttonAjouterDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouterDocument.Location = new System.Drawing.Point(39, 223);
            this.buttonAjouterDocument.Name = "buttonAjouterDocument";
            this.buttonAjouterDocument.Size = new System.Drawing.Size(121, 58);
            this.buttonAjouterDocument.TabIndex = 11;
            this.buttonAjouterDocument.Text = "Ajouter Document";
            this.buttonAjouterDocument.UseVisualStyleBackColor = false;
            this.buttonAjouterDocument.Click += new System.EventHandler(this.buttonAjouterDocument_Click);
            // 
            // buttonAfficherDocument
            // 
            this.buttonAfficherDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAfficherDocument.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAfficherDocument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAfficherDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAfficherDocument.FlatAppearance.BorderSize = 0;
            this.buttonAfficherDocument.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonAfficherDocument.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonAfficherDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAfficherDocument.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfficherDocument.ForeColor = System.Drawing.Color.White;
            this.buttonAfficherDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAfficherDocument.Location = new System.Drawing.Point(181, 223);
            this.buttonAfficherDocument.Name = "buttonAfficherDocument";
            this.buttonAfficherDocument.Size = new System.Drawing.Size(121, 58);
            this.buttonAfficherDocument.TabIndex = 12;
            this.buttonAfficherDocument.Text = "Afficher Document";
            this.buttonAfficherDocument.UseVisualStyleBackColor = false;
            this.buttonAfficherDocument.Click += new System.EventHandler(this.buttonAfficherDocument_Click);
            // 
            // buttonSupprimerDocument
            // 
            this.buttonSupprimerDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSupprimerDocument.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSupprimerDocument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSupprimerDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSupprimerDocument.FlatAppearance.BorderSize = 0;
            this.buttonSupprimerDocument.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonSupprimerDocument.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonSupprimerDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerDocument.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimerDocument.ForeColor = System.Drawing.Color.White;
            this.buttonSupprimerDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupprimerDocument.Location = new System.Drawing.Point(381, 223);
            this.buttonSupprimerDocument.Name = "buttonSupprimerDocument";
            this.buttonSupprimerDocument.Size = new System.Drawing.Size(121, 58);
            this.buttonSupprimerDocument.TabIndex = 13;
            this.buttonSupprimerDocument.Text = "Supprimer Document";
            this.buttonSupprimerDocument.UseVisualStyleBackColor = false;
            this.buttonSupprimerDocument.Click += new System.EventHandler(this.buttonSupprimerDocument_Click);
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.labelCloseHistoriques);
            this.panelHead.Controls.Add(this.labelHead);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(527, 49);
            this.panelHead.TabIndex = 14;
            // 
            // labelHead
            // 
            this.labelHead.AutoSize = true;
            this.labelHead.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHead.Location = new System.Drawing.Point(194, 9);
            this.labelHead.Name = "labelHead";
            this.labelHead.Size = new System.Drawing.Size(77, 30);
            this.labelHead.TabIndex = 6;
            this.labelHead.Text = "HEAD";
            // 
            // labelCloseHistoriques
            // 
            this.labelCloseHistoriques.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCloseHistoriques.AutoSize = true;
            this.labelCloseHistoriques.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseHistoriques.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCloseHistoriques.Location = new System.Drawing.Point(506, 4);
            this.labelCloseHistoriques.Name = "labelCloseHistoriques";
            this.labelCloseHistoriques.Size = new System.Drawing.Size(18, 18);
            this.labelCloseHistoriques.TabIndex = 7;
            this.labelCloseHistoriques.Text = "X";
            this.labelCloseHistoriques.Click += new System.EventHandler(this.labelCloseHistoriques_Click);
            // 
            // FormGestionDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 293);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.buttonSupprimerDocument);
            this.Controls.Add(this.buttonAfficherDocument);
            this.Controls.Add(this.buttonAjouterDocument);
            this.Controls.Add(this.dataGridViewListeDocuments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionDocument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormGestionDocument";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGestionDocument_FormClosing);
            this.Load += new System.EventHandler(this.FormGestionDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeDocuments)).EndInit();
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListeDocuments;
        private System.Windows.Forms.Button buttonAjouterDocument;
        private System.Windows.Forms.Button buttonAfficherDocument;
        private System.Windows.Forms.Button buttonSupprimerDocument;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label labelHead;
        private System.Windows.Forms.Label labelCloseHistoriques;
    }
}