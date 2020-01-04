namespace SYNDIC_1._0
{
    partial class frmFinances
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
            this.labelFinances = new System.Windows.Forms.Label();
            this.labelCloseFinances = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFinances
            // 
            this.labelFinances.AutoSize = true;
            this.labelFinances.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinances.Location = new System.Drawing.Point(308, 30);
            this.labelFinances.Name = "labelFinances";
            this.labelFinances.Size = new System.Drawing.Size(119, 30);
            this.labelFinances.TabIndex = 2;
            this.labelFinances.Text = "Finances";

            // 
            // labelCloseFinances
            // 
            this.labelCloseFinances.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCloseFinances.AutoSize = true;
            this.labelCloseFinances.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseFinances.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCloseFinances.Location = new System.Drawing.Point(770, 9);
            this.labelCloseFinances.Name = "labelCloseFinances";
            this.labelCloseFinances.Size = new System.Drawing.Size(18, 18);
            this.labelCloseFinances.TabIndex = 3;
            this.labelCloseFinances.Text = "X";
            // 
            // frmFinances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCloseFinances);
            this.Controls.Add(this.labelFinances);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFinances";
            this.Text = "frmFinances";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFinances;
        private System.Windows.Forms.Label labelCloseFinances;
    }
}