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
            this.SuspendLayout();
            // 
            // labelBiens
            // 
            this.labelBiens.AutoSize = true;
            this.labelBiens.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBiens.Location = new System.Drawing.Point(336, 26);
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
            this.labelCloseBiens.Location = new System.Drawing.Point(770, 9);
            this.labelCloseBiens.Name = "labelCloseBiens";
            this.labelCloseBiens.Size = new System.Drawing.Size(18, 18);
            this.labelCloseBiens.TabIndex = 1;
            this.labelCloseBiens.Text = "X";
            this.labelCloseBiens.Click += new System.EventHandler(this.labelCloseBiens_Click);
            // 
            // frmBiens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCloseBiens);
            this.Controls.Add(this.labelBiens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBiens";
            this.Text = "frmBiens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBiens;
        private System.Windows.Forms.Label labelCloseBiens;
    }
}