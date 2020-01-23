namespace SYNDIC_1._0.Forms
{
    partial class FormSplachScreen
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
            this.pictureBoxLogoHolder = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoHolder)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogoHolder
            // 
            this.pictureBoxLogoHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxLogoHolder.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogoHolder.Name = "pictureBoxLogoHolder";
            this.pictureBoxLogoHolder.Size = new System.Drawing.Size(499, 334);
            this.pictureBoxLogoHolder.TabIndex = 0;
            this.pictureBoxLogoHolder.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 354);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(475, 23);
            this.progressBar.TabIndex = 1;
            // 
            // FormSplachScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 389);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pictureBoxLogoHolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSplachScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSplachScreen";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoHolder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogoHolder;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}