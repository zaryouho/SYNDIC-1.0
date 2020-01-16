namespace SYNDIC_1._0
{
    partial class frmDocuments
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
            this.labelDocuments = new System.Windows.Forms.Label();
            this.labelCloseDocuments = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDocuments
            // 
            this.labelDocuments.AutoSize = true;
            this.labelDocuments.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDocuments.Location = new System.Drawing.Point(291, 41);
            this.labelDocuments.Name = "labelDocuments";
            this.labelDocuments.Size = new System.Drawing.Size(195, 30);
            this.labelDocuments.TabIndex = 3;
            this.labelDocuments.Text = "Les Documents";
            // 
            // labelCloseDocuments
            // 
            this.labelCloseDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCloseDocuments.AutoSize = true;
            this.labelCloseDocuments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseDocuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCloseDocuments.Location = new System.Drawing.Point(770, 9);
            this.labelCloseDocuments.Name = "labelCloseDocuments";
            this.labelCloseDocuments.Size = new System.Drawing.Size(18, 18);
            this.labelCloseDocuments.TabIndex = 4;
            this.labelCloseDocuments.Text = "X";
            this.labelCloseDocuments.Click += new System.EventHandler(this.labelCloseDocuments_Click);
            // 
            // frmDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCloseDocuments);
            this.Controls.Add(this.labelDocuments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDocuments";
            this.Text = "frmDocuments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDocuments;
        private System.Windows.Forms.Label labelCloseDocuments;
    }
}