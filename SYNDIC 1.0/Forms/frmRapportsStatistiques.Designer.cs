namespace SYNDIC_1._0
{
    partial class frmRapportsStatistiques
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
            this.labelRapportsStatistiques = new System.Windows.Forms.Label();
            this.labelCloseRapportsStatistiques = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRapportsStatistiques
            // 
            this.labelRapportsStatistiques.AutoSize = true;
            this.labelRapportsStatistiques.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRapportsStatistiques.Location = new System.Drawing.Point(238, 36);
            this.labelRapportsStatistiques.Name = "labelRapportsStatistiques";
            this.labelRapportsStatistiques.Size = new System.Drawing.Size(286, 30);
            this.labelRapportsStatistiques.TabIndex = 5;
            this.labelRapportsStatistiques.Text = "Rapports et Statistiques";
            // 
            // labelCloseRapportsStatistiques
            // 
            this.labelCloseRapportsStatistiques.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCloseRapportsStatistiques.AutoSize = true;
            this.labelCloseRapportsStatistiques.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseRapportsStatistiques.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCloseRapportsStatistiques.Location = new System.Drawing.Point(770, 9);
            this.labelCloseRapportsStatistiques.Name = "labelCloseRapportsStatistiques";
            this.labelCloseRapportsStatistiques.Size = new System.Drawing.Size(18, 18);
            this.labelCloseRapportsStatistiques.TabIndex = 6;
            this.labelCloseRapportsStatistiques.Text = "X";
            this.labelCloseRapportsStatistiques.Click += new System.EventHandler(this.labelCloseRapportsStatistiques_Click);
            // 
            // frmRapportsStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCloseRapportsStatistiques);
            this.Controls.Add(this.labelRapportsStatistiques);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRapportsStatistiques";
            this.Text = "frmRapportsStatistiques";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRapportsStatistiques;
        private System.Windows.Forms.Label labelCloseRapportsStatistiques;
    }
}