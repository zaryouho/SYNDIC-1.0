namespace SYNDIC_1._0
{
    partial class frmHistoriques
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
            this.labelHistoriques = new System.Windows.Forms.Label();
            this.labelCloseHistoriques = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHistoriques
            // 
            this.labelHistoriques.AutoSize = true;
            this.labelHistoriques.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHistoriques.Location = new System.Drawing.Point(297, 39);
            this.labelHistoriques.Name = "labelHistoriques";
            this.labelHistoriques.Size = new System.Drawing.Size(139, 30);
            this.labelHistoriques.TabIndex = 4;
            this.labelHistoriques.Text = "Historiques";
            // 
            // labelCloseHistoriques
            // 
            this.labelCloseHistoriques.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCloseHistoriques.AutoSize = true;
            this.labelCloseHistoriques.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseHistoriques.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCloseHistoriques.Location = new System.Drawing.Point(770, 9);
            this.labelCloseHistoriques.Name = "labelCloseHistoriques";
            this.labelCloseHistoriques.Size = new System.Drawing.Size(18, 18);
            this.labelCloseHistoriques.TabIndex = 5;
            this.labelCloseHistoriques.Text = "X";
            this.labelCloseHistoriques.Click += new System.EventHandler(this.labelCloseHistoriques_Click);
            // 
            // frmHistoriques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCloseHistoriques);
            this.Controls.Add(this.labelHistoriques);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHistoriques";
            this.Text = "frmHistoriques";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHistoriques;
        private System.Windows.Forms.Label labelCloseHistoriques;
    }
}