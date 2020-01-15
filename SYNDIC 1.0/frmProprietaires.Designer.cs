namespace SYNDIC_1._0
{
    partial class frmProprietaires
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
            this.labelProprietaires = new System.Windows.Forms.Label();
            this.labelCloseProprietaires = new System.Windows.Forms.Label();
            this.btnCRUDType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelProprietaires
            // 
            this.labelProprietaires.AutoSize = true;
            this.labelProprietaires.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProprietaires.Location = new System.Drawing.Point(268, 36);
            this.labelProprietaires.Name = "labelProprietaires";
            this.labelProprietaires.Size = new System.Drawing.Size(202, 30);
            this.labelProprietaires.TabIndex = 1;
            this.labelProprietaires.Text = "Les Propriétaires";
            // 
            // labelCloseProprietaires
            // 
            this.labelCloseProprietaires.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCloseProprietaires.AutoSize = true;
            this.labelCloseProprietaires.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseProprietaires.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCloseProprietaires.Location = new System.Drawing.Point(770, 9);
            this.labelCloseProprietaires.Name = "labelCloseProprietaires";
            this.labelCloseProprietaires.Size = new System.Drawing.Size(18, 18);
            this.labelCloseProprietaires.TabIndex = 2;
            this.labelCloseProprietaires.Text = "X";
            this.labelCloseProprietaires.Click += new System.EventHandler(this.labelCloseProprietaires_Click);
            // 
            // btnCRUDType
            // 
            this.btnCRUDType.Location = new System.Drawing.Point(96, 374);
            this.btnCRUDType.Name = "btnCRUDType";
            this.btnCRUDType.Size = new System.Drawing.Size(75, 23);
            this.btnCRUDType.TabIndex = 4;
            this.btnCRUDType.Text = "Type";
            this.btnCRUDType.UseVisualStyleBackColor = true;
            this.btnCRUDType.Click += new System.EventHandler(this.btnCRUDType_Click);
            // 
            // frmProprietaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCRUDType);
            this.Controls.Add(this.labelCloseProprietaires);
            this.Controls.Add(this.labelProprietaires);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProprietaires";
            this.Text = "frmProprietaires";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProprietaires;
        private System.Windows.Forms.Label labelCloseProprietaires;
        private System.Windows.Forms.Button btnCRUDType;
    }
}