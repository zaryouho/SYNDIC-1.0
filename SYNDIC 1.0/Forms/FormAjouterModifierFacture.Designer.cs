namespace SYNDIC_1._0
{
    partial class FormAjouterModifierFacture
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
            this.labelFacture = new System.Windows.Forms.Label();
            this.panelValid = new System.Windows.Forms.Panel();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAjouterProduit = new System.Windows.Forms.Button();
            this.comboBoxProduit = new System.Windows.Forms.ComboBox();
            this.labelProduit = new System.Windows.Forms.Label();
            this.textBoxPrixProduit = new System.Windows.Forms.TextBox();
            this.labelPrix = new System.Windows.Forms.Label();
            this.textBoxQteProduit = new System.Windows.Forms.TextBox();
            this.labelQteProduit = new System.Windows.Forms.Label();
            this.comboBoxidProduit = new System.Windows.Forms.ComboBox();
            this.panelHead.SuspendLayout();
            this.panelValid.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.labelCloseDepense);
            this.panelHead.Controls.Add(this.labelFacture);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(447, 60);
            this.panelHead.TabIndex = 47;
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
            // labelFacture
            // 
            this.labelFacture.AutoSize = true;
            this.labelFacture.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacture.Location = new System.Drawing.Point(173, 9);
            this.labelFacture.Name = "labelFacture";
            this.labelFacture.Size = new System.Drawing.Size(103, 30);
            this.labelFacture.TabIndex = 0;
            this.labelFacture.Text = "Facture";
            // 
            // panelValid
            // 
            this.panelValid.Controls.Add(this.buttonAnnuler);
            this.panelValid.Controls.Add(this.buttonValider);
            this.panelValid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelValid.Location = new System.Drawing.Point(0, 246);
            this.panelValid.Name = "panelValid";
            this.panelValid.Size = new System.Drawing.Size(447, 41);
            this.panelValid.TabIndex = 48;
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
            // buttonAjouterProduit
            // 
            this.buttonAjouterProduit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterProduit.Location = new System.Drawing.Point(353, 89);
            this.buttonAjouterProduit.Name = "buttonAjouterProduit";
            this.buttonAjouterProduit.Size = new System.Drawing.Size(51, 23);
            this.buttonAjouterProduit.TabIndex = 63;
            this.buttonAjouterProduit.Text = "...";
            this.buttonAjouterProduit.UseVisualStyleBackColor = true;
            this.buttonAjouterProduit.Click += new System.EventHandler(this.buttonAjouterProduit_Click);
            // 
            // comboBoxProduit
            // 
            this.comboBoxProduit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProduit.FormattingEnabled = true;
            this.comboBoxProduit.Location = new System.Drawing.Point(115, 86);
            this.comboBoxProduit.Name = "comboBoxProduit";
            this.comboBoxProduit.Size = new System.Drawing.Size(231, 25);
            this.comboBoxProduit.TabIndex = 62;
            this.comboBoxProduit.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduit_SelectedIndexChanged);
            this.comboBoxProduit.Click += new System.EventHandler(this.comboBoxProduit_SelectedIndexChanged);
            // 
            // labelProduit
            // 
            this.labelProduit.AutoSize = true;
            this.labelProduit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduit.Location = new System.Drawing.Point(44, 91);
            this.labelProduit.Name = "labelProduit";
            this.labelProduit.Size = new System.Drawing.Size(59, 17);
            this.labelProduit.TabIndex = 61;
            this.labelProduit.Text = "Produit  :";
            // 
            // textBoxPrixProduit
            // 
            this.textBoxPrixProduit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrixProduit.Location = new System.Drawing.Point(115, 182);
            this.textBoxPrixProduit.Name = "textBoxPrixProduit";
            this.textBoxPrixProduit.Size = new System.Drawing.Size(231, 22);
            this.textBoxPrixProduit.TabIndex = 60;
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrix.Location = new System.Drawing.Point(69, 182);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(34, 17);
            this.labelPrix.TabIndex = 59;
            this.labelPrix.Text = "Prix :";
            // 
            // textBoxQteProduit
            // 
            this.textBoxQteProduit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQteProduit.Location = new System.Drawing.Point(115, 133);
            this.textBoxQteProduit.Name = "textBoxQteProduit";
            this.textBoxQteProduit.Size = new System.Drawing.Size(231, 22);
            this.textBoxQteProduit.TabIndex = 58;
            // 
            // labelQteProduit
            // 
            this.labelQteProduit.AutoSize = true;
            this.labelQteProduit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQteProduit.Location = new System.Drawing.Point(33, 133);
            this.labelQteProduit.Name = "labelQteProduit";
            this.labelQteProduit.Size = new System.Drawing.Size(70, 17);
            this.labelQteProduit.TabIndex = 57;
            this.labelQteProduit.Text = "Quantité  :";
            // 
            // comboBoxidProduit
            // 
            this.comboBoxidProduit.Enabled = false;
            this.comboBoxidProduit.FormattingEnabled = true;
            this.comboBoxidProduit.Location = new System.Drawing.Point(115, 87);
            this.comboBoxidProduit.Name = "comboBoxidProduit";
            this.comboBoxidProduit.Size = new System.Drawing.Size(15, 21);
            this.comboBoxidProduit.TabIndex = 65;
            // 
            // FormAjouterModifierFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(447, 287);
            this.Controls.Add(this.buttonAjouterProduit);
            this.Controls.Add(this.comboBoxProduit);
            this.Controls.Add(this.labelProduit);
            this.Controls.Add(this.textBoxPrixProduit);
            this.Controls.Add(this.labelPrix);
            this.Controls.Add(this.textBoxQteProduit);
            this.Controls.Add(this.labelQteProduit);
            this.Controls.Add(this.panelValid);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.comboBoxidProduit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAjouterModifierFacture";
            this.Text = "FormAjouterModifierFacture";
            this.Load += new System.EventHandler(this.FormAjouterModifierFacture_Load);
            this.Click += new System.EventHandler(this.FormAjouterModifierFacture_Load);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panelValid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label labelCloseDepense;
        private System.Windows.Forms.Label labelFacture;
        private System.Windows.Forms.Panel panelValid;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAjouterProduit;
        private System.Windows.Forms.ComboBox comboBoxProduit;
        private System.Windows.Forms.Label labelProduit;
        private System.Windows.Forms.TextBox textBoxPrixProduit;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.TextBox textBoxQteProduit;
        private System.Windows.Forms.Label labelQteProduit;
        private System.Windows.Forms.ComboBox comboBoxidProduit;
    }
}