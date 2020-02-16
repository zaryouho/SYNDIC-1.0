namespace SYNDIC_1._0
{
    partial class FormAjouterProduit
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
            this.panelHead = new System.Windows.Forms.Panel();
            this.labelCloseDepense = new System.Windows.Forms.Label();
            this.labelNvProduit = new System.Windows.Forms.Label();
            this.panelValid = new System.Windows.Forms.Panel();
            this.dataGridViewListProduits = new System.Windows.Forms.DataGridView();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.textBoxIdProduit = new System.Windows.Forms.TextBox();
            this.labelIdProduit = new System.Windows.Forms.Label();
            this.labelProduit = new System.Windows.Forms.Label();
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            this.labelQteProduit = new System.Windows.Forms.Label();
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.labelPrix = new System.Windows.Forms.Label();
            this.textBoxQteStockProduit = new System.Windows.Forms.TextBox();
            this.panelCRUD = new System.Windows.Forms.Panel();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.textBoxCategorieProduit = new System.Windows.Forms.TextBox();
            this.panelHead.SuspendLayout();
            this.panelValid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProduits)).BeginInit();
            this.panelInputs.SuspendLayout();
            this.panelCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.labelCloseDepense);
            this.panelHead.Controls.Add(this.labelNvProduit);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(447, 60);
            this.panelHead.TabIndex = 58;
            this.panelHead.Paint += new System.Windows.Forms.PaintEventHandler(this.FormAjouterProduit_Paint);
            // 
            // labelCloseDepense
            // 
            this.labelCloseDepense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCloseDepense.AutoSize = true;
            this.labelCloseDepense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseDepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCloseDepense.Location = new System.Drawing.Point(425, 4);
            this.labelCloseDepense.Name = "labelCloseDepense";
            this.labelCloseDepense.Size = new System.Drawing.Size(18, 18);
            this.labelCloseDepense.TabIndex = 1;
            this.labelCloseDepense.Text = "X";
            this.labelCloseDepense.Click += new System.EventHandler(this.labelCloseDepense_Click);
            // 
            // labelNvProduit
            // 
            this.labelNvProduit.AutoSize = true;
            this.labelNvProduit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNvProduit.Location = new System.Drawing.Point(173, 9);
            this.labelNvProduit.Name = "labelNvProduit";
            this.labelNvProduit.Size = new System.Drawing.Size(95, 30);
            this.labelNvProduit.TabIndex = 0;
            this.labelNvProduit.Text = "Produit";
            // 
            // panelValid
            // 
            this.panelValid.Controls.Add(this.buttonAnnuler);
            this.panelValid.Controls.Add(this.buttonValider);
            this.panelValid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelValid.Location = new System.Drawing.Point(0, 482);
            this.panelValid.Name = "panelValid";
            this.panelValid.Size = new System.Drawing.Size(447, 41);
            this.panelValid.TabIndex = 59;
            this.panelValid.Paint += new System.Windows.Forms.PaintEventHandler(this.FormAjouterProduit_Paint);
            // 
            // dataGridViewListProduits
            // 
            this.dataGridViewListProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListProduits.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewListProduits.Location = new System.Drawing.Point(0, 60);
            this.dataGridViewListProduits.Name = "dataGridViewListProduits";
            this.dataGridViewListProduits.ReadOnly = true;
            this.dataGridViewListProduits.Size = new System.Drawing.Size(447, 183);
            this.dataGridViewListProduits.TabIndex = 76;
            this.dataGridViewListProduits.Paint += new System.Windows.Forms.PaintEventHandler(this.FormAjouterProduit_Paint);
            // 
            // panelInputs
            // 
            this.panelInputs.Controls.Add(this.textBoxIdProduit);
            this.panelInputs.Controls.Add(this.labelIdProduit);
            this.panelInputs.Controls.Add(this.labelProduit);
            this.panelInputs.Controls.Add(this.labelQteProduit);
            this.panelInputs.Controls.Add(this.textBoxDesignation);
            this.panelInputs.Controls.Add(this.labelPrix);
            this.panelInputs.Controls.Add(this.textBoxQteStockProduit);
            this.panelInputs.Controls.Add(this.comboBoxCategorie);
            this.panelInputs.Controls.Add(this.textBoxCategorieProduit);
            this.panelInputs.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInputs.Location = new System.Drawing.Point(0, 243);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(447, 183);
            this.panelInputs.TabIndex = 77;
            this.panelInputs.Paint += new System.Windows.Forms.PaintEventHandler(this.FormAjouterProduit_Paint);
            // 
            // textBoxIdProduit
            // 
            this.textBoxIdProduit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdProduit.Location = new System.Drawing.Point(156, 13);
            this.textBoxIdProduit.Name = "textBoxIdProduit";
            this.textBoxIdProduit.Size = new System.Drawing.Size(231, 22);
            this.textBoxIdProduit.TabIndex = 67;
            // 
            // labelIdProduit
            // 
            this.labelIdProduit.AutoSize = true;
            this.labelIdProduit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdProduit.Location = new System.Drawing.Point(74, 13);
            this.labelIdProduit.Name = "labelIdProduit";
            this.labelIdProduit.Size = new System.Drawing.Size(76, 17);
            this.labelIdProduit.TabIndex = 74;
            this.labelIdProduit.Text = "Reference :";
            // 
            // labelProduit
            // 
            this.labelProduit.AutoSize = true;
            this.labelProduit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduit.Location = new System.Drawing.Point(62, 58);
            this.labelProduit.Name = "labelProduit";
            this.labelProduit.Size = new System.Drawing.Size(88, 17);
            this.labelProduit.TabIndex = 70;
            this.labelProduit.Text = "Désignation  :";
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.Location = new System.Drawing.Point(156, 145);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(231, 25);
            this.comboBoxCategorie.TabIndex = 73;
            this.comboBoxCategorie.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategorie_SelectedIndexChanged);
            // 
            // labelQteProduit
            // 
            this.labelQteProduit.AutoSize = true;
            this.labelQteProduit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQteProduit.Location = new System.Drawing.Point(27, 103);
            this.labelQteProduit.Name = "labelQteProduit";
            this.labelQteProduit.Size = new System.Drawing.Size(123, 17);
            this.labelQteProduit.TabIndex = 66;
            this.labelQteProduit.Text = "Quantité en stock  :";
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDesignation.Location = new System.Drawing.Point(156, 57);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(231, 22);
            this.textBoxDesignation.TabIndex = 71;
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrix.Location = new System.Drawing.Point(75, 148);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(75, 17);
            this.labelPrix.TabIndex = 68;
            this.labelPrix.Text = "Catégorie :";
            // 
            // textBoxQteStockProduit
            // 
            this.textBoxQteStockProduit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQteStockProduit.Location = new System.Drawing.Point(156, 101);
            this.textBoxQteStockProduit.Name = "textBoxQteStockProduit";
            this.textBoxQteStockProduit.Size = new System.Drawing.Size(231, 22);
            this.textBoxQteStockProduit.TabIndex = 69;
            // 
            // panelCRUD
            // 
            this.panelCRUD.Controls.Add(this.buttonSupprimer);
            this.panelCRUD.Controls.Add(this.buttonModifier);
            this.panelCRUD.Controls.Add(this.buttonAjouter);
            this.panelCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCRUD.Location = new System.Drawing.Point(0, 426);
            this.panelCRUD.Name = "panelCRUD";
            this.panelCRUD.Size = new System.Drawing.Size(447, 56);
            this.panelCRUD.TabIndex = 78;
            this.panelCRUD.Paint += new System.Windows.Forms.PaintEventHandler(this.FormAjouterProduit_Paint);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.Image = global::SYNDIC_1._0.Properties.Resources.icons8_Delete_32;
            this.buttonSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupprimer.Location = new System.Drawing.Point(302, 15);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(139, 35);
            this.buttonSupprimer.TabIndex = 4;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifier.Image = global::SYNDIC_1._0.Properties.Resources.icons8_Edit_32;
            this.buttonModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModifier.Location = new System.Drawing.Point(157, 15);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(139, 35);
            this.buttonModifier.TabIndex = 3;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.Image = global::SYNDIC_1._0.Properties.Resources.icons8_Plus_32;
            this.buttonAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouter.Location = new System.Drawing.Point(12, 15);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(139, 35);
            this.buttonAjouter.TabIndex = 2;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.Image = global::SYNDIC_1._0.Properties.Resources.DeleteReddd;
            this.buttonAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnnuler.Location = new System.Drawing.Point(270, 3);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(139, 35);
            this.buttonAnnuler.TabIndex = 1;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValider.Image = global::SYNDIC_1._0.Properties.Resources.valider;
            this.buttonValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonValider.Location = new System.Drawing.Point(38, 3);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(139, 35);
            this.buttonValider.TabIndex = 0;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // textBoxCategorieProduit
            // 
            this.textBoxCategorieProduit.Enabled = false;
            this.textBoxCategorieProduit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCategorieProduit.Location = new System.Drawing.Point(157, 145);
            this.textBoxCategorieProduit.Name = "textBoxCategorieProduit";
            this.textBoxCategorieProduit.Size = new System.Drawing.Size(21, 22);
            this.textBoxCategorieProduit.TabIndex = 75;
            this.textBoxCategorieProduit.TextChanged += new System.EventHandler(this.textBoxCategorieProduit_TextChanged);
            // 
            // FormAjouterProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(447, 523);
            this.Controls.Add(this.panelCRUD);
            this.Controls.Add(this.panelInputs);
            this.Controls.Add(this.dataGridViewListProduits);
            this.Controls.Add(this.panelValid);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAjouterProduit";
            this.Text = "FormAjouterProduit";
            this.Load += new System.EventHandler(this.FormAjouterProduit_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormAjouterProduit_Paint);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panelValid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProduits)).EndInit();
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            this.panelCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label labelCloseDepense;
        private System.Windows.Forms.Label labelNvProduit;
        private System.Windows.Forms.Panel panelValid;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.DataGridView dataGridViewListProduits;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.TextBox textBoxIdProduit;
        private System.Windows.Forms.Label labelIdProduit;
        private System.Windows.Forms.Label labelProduit;
        private System.Windows.Forms.ComboBox comboBoxCategorie;
        private System.Windows.Forms.Label labelQteProduit;
        private System.Windows.Forms.TextBox textBoxDesignation;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.TextBox textBoxQteStockProduit;
        private System.Windows.Forms.Panel panelCRUD;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.TextBox textBoxCategorieProduit;
    }
}