﻿namespace SYNDIC_1._0
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
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.textBoxCategorieProduit = new System.Windows.Forms.TextBox();
            this.labelPrix = new System.Windows.Forms.Label();
            this.textBoxQteStckProduit = new System.Windows.Forms.TextBox();
            this.labelQteProduit = new System.Windows.Forms.Label();
            this.labelProduit = new System.Windows.Forms.Label();
            this.panelHead.SuspendLayout();
            this.panelValid.SuspendLayout();
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
            this.labelNvProduit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panelValid.Location = new System.Drawing.Point(0, 246);
            this.panelValid.Name = "panelValid";
            this.panelValid.Size = new System.Drawing.Size(447, 41);
            this.panelValid.TabIndex = 59;
            // 
            // buttonAnnuler
            // 
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
            this.buttonValider.Location = new System.Drawing.Point(38, 3);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(139, 35);
            this.buttonValider.TabIndex = 0;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(371, 78);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(63, 20);
            this.textBoxID.TabIndex = 72;
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.Location = new System.Drawing.Point(128, 93);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(231, 20);
            this.textBoxDesignation.TabIndex = 71;
            // 
            // textBoxCategorieProduit
            // 
            this.textBoxCategorieProduit.Location = new System.Drawing.Point(128, 188);
            this.textBoxCategorieProduit.Name = "textBoxCategorieProduit";
            this.textBoxCategorieProduit.Size = new System.Drawing.Size(231, 20);
            this.textBoxCategorieProduit.TabIndex = 69;
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Location = new System.Drawing.Point(56, 191);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(58, 13);
            this.labelPrix.TabIndex = 68;
            this.labelPrix.Text = "Catégorie :";
            // 
            // textBoxQteStckProduit
            // 
            this.textBoxQteStckProduit.Location = new System.Drawing.Point(128, 139);
            this.textBoxQteStckProduit.Name = "textBoxQteStckProduit";
            this.textBoxQteStckProduit.Size = new System.Drawing.Size(231, 20);
            this.textBoxQteStckProduit.TabIndex = 67;
            // 
            // labelQteProduit
            // 
            this.labelQteProduit.AutoSize = true;
            this.labelQteProduit.Location = new System.Drawing.Point(12, 142);
            this.labelQteProduit.Name = "labelQteProduit";
            this.labelQteProduit.Size = new System.Drawing.Size(100, 13);
            this.labelQteProduit.TabIndex = 66;
            this.labelQteProduit.Text = "Quantité en stock  :";
            // 
            // labelProduit
            // 
            this.labelProduit.AutoSize = true;
            this.labelProduit.Location = new System.Drawing.Point(40, 96);
            this.labelProduit.Name = "labelProduit";
            this.labelProduit.Size = new System.Drawing.Size(72, 13);
            this.labelProduit.TabIndex = 70;
            this.labelProduit.Text = "Désignation  :";
            // 
            // FormAjouterProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 287);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxDesignation);
            this.Controls.Add(this.textBoxCategorieProduit);
            this.Controls.Add(this.labelPrix);
            this.Controls.Add(this.textBoxQteStckProduit);
            this.Controls.Add(this.labelQteProduit);
            this.Controls.Add(this.labelProduit);
            this.Controls.Add(this.panelValid);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAjouterProduit";
            this.Text = "FormAjouterProduit";
            this.Load += new System.EventHandler(this.FormAjouterProduit_Load);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panelValid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label labelCloseDepense;
        private System.Windows.Forms.Label labelNvProduit;
        private System.Windows.Forms.Panel panelValid;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxDesignation;
        private System.Windows.Forms.TextBox textBoxCategorieProduit;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.TextBox textBoxQteStckProduit;
        private System.Windows.Forms.Label labelQteProduit;
        private System.Windows.Forms.Label labelProduit;
    }
}