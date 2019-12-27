namespace SYNDIC_1._0
{
    partial class frmMenuOfficiel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuOfficiel));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.BarreTitulaire = new System.Windows.Forms.Panel();
            this.btnMinimized = new System.Windows.Forms.PictureBox();
            this.btnMaximized = new System.Windows.Forms.PictureBox();
            this.btnRestaure = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnSlideBar = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.BarreTitulaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlideBar)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 650);
            this.MenuVertical.TabIndex = 0;
            // 
            // BarreTitulaire
            // 
            this.BarreTitulaire.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BarreTitulaire.Controls.Add(this.btnMinimized);
            this.BarreTitulaire.Controls.Add(this.btnMaximized);
            this.BarreTitulaire.Controls.Add(this.btnRestaure);
            this.BarreTitulaire.Controls.Add(this.btnClose);
            this.BarreTitulaire.Controls.Add(this.btnSlideBar);
            this.BarreTitulaire.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarreTitulaire.Location = new System.Drawing.Point(250, 0);
            this.BarreTitulaire.Name = "BarreTitulaire";
            this.BarreTitulaire.Size = new System.Drawing.Size(1050, 50);
            this.BarreTitulaire.TabIndex = 1;
            this.BarreTitulaire.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarreTitulaire_MouseDown);
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimized.Image")));
            this.btnMinimized.Location = new System.Drawing.Point(968, 8);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(18, 18);
            this.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimized.TabIndex = 4;
            this.btnMinimized.TabStop = false;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximized.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximized.Image")));
            this.btnMaximized.Location = new System.Drawing.Point(992, 8);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.Size = new System.Drawing.Size(20, 20);
            this.btnMaximized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaximized.TabIndex = 3;
            this.btnMaximized.TabStop = false;
            this.btnMaximized.Click += new System.EventHandler(this.btnMaximized_Click);
            // 
            // btnRestaure
            // 
            this.btnRestaure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaure.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaure.Image")));
            this.btnRestaure.Location = new System.Drawing.Point(992, 8);
            this.btnRestaure.Name = "btnRestaure";
            this.btnRestaure.Size = new System.Drawing.Size(18, 18);
            this.btnRestaure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRestaure.TabIndex = 2;
            this.btnRestaure.TabStop = false;
            this.btnRestaure.Visible = false;
            this.btnRestaure.Click += new System.EventHandler(this.btnRestaure_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1018, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSlideBar
            // 
            this.btnSlideBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlideBar.Image = ((System.Drawing.Image)(resources.GetObject("btnSlideBar.Image")));
            this.btnSlideBar.Location = new System.Drawing.Point(5, 7);
            this.btnSlideBar.Name = "btnSlideBar";
            this.btnSlideBar.Size = new System.Drawing.Size(35, 35);
            this.btnSlideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSlideBar.TabIndex = 0;
            this.btnSlideBar.TabStop = false;
            this.btnSlideBar.Click += new System.EventHandler(this.btnSlideBar_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(250, 50);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1050, 600);
            this.panelContainer.TabIndex = 2;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // frmMenuOfficiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.BarreTitulaire);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuOfficiel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuOfficiel";
            this.BarreTitulaire.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlideBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel BarreTitulaire;
        private System.Windows.Forms.PictureBox btnSlideBar;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox btnMinimized;
        private System.Windows.Forms.PictureBox btnMaximized;
        private System.Windows.Forms.PictureBox btnRestaure;
        private System.Windows.Forms.PictureBox btnClose;
    }
}

