namespace SYNDIC_1._0.Forms
{
    partial class FormProprietairesArchive
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainerListeProprietaireBody = new System.Windows.Forms.SplitContainer();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonprevious = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.dataGridViewProprietaires = new System.Windows.Forms.DataGridView();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.textBoxrechercher = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerListeProprietaireBody)).BeginInit();
            this.splitContainerListeProprietaireBody.Panel1.SuspendLayout();
            this.splitContainerListeProprietaireBody.Panel2.SuspendLayout();
            this.splitContainerListeProprietaireBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProprietaires)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonRechercher);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxrechercher);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainerListeProprietaireBody);
            this.splitContainer1.Size = new System.Drawing.Size(784, 411);
            this.splitContainer1.SplitterDistance = 58;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainerListeProprietaireBody
            // 
            this.splitContainerListeProprietaireBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerListeProprietaireBody.Location = new System.Drawing.Point(0, 0);
            this.splitContainerListeProprietaireBody.Name = "splitContainerListeProprietaireBody";
            // 
            // splitContainerListeProprietaireBody.Panel1
            // 
            this.splitContainerListeProprietaireBody.Panel1.Controls.Add(this.buttonLast);
            this.splitContainerListeProprietaireBody.Panel1.Controls.Add(this.buttonNext);
            this.splitContainerListeProprietaireBody.Panel1.Controls.Add(this.buttonprevious);
            this.splitContainerListeProprietaireBody.Panel1.Controls.Add(this.buttonFirst);
            // 
            // splitContainerListeProprietaireBody.Panel2
            // 
            this.splitContainerListeProprietaireBody.Panel2.Controls.Add(this.dataGridViewProprietaires);
            this.splitContainerListeProprietaireBody.Size = new System.Drawing.Size(784, 349);
            this.splitContainerListeProprietaireBody.SplitterDistance = 72;
            this.splitContainerListeProprietaireBody.TabIndex = 31;
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(18, 230);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(39, 31);
            this.buttonLast.TabIndex = 30;
            this.buttonLast.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(18, 175);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(39, 31);
            this.buttonNext.TabIndex = 29;
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonprevious
            // 
            this.buttonprevious.Location = new System.Drawing.Point(18, 120);
            this.buttonprevious.Name = "buttonprevious";
            this.buttonprevious.Size = new System.Drawing.Size(39, 31);
            this.buttonprevious.TabIndex = 28;
            this.buttonprevious.UseVisualStyleBackColor = true;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(18, 65);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(39, 31);
            this.buttonFirst.TabIndex = 27;
            this.buttonFirst.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProprietaires
            // 
            this.dataGridViewProprietaires.AllowUserToAddRows = false;
            this.dataGridViewProprietaires.AllowUserToDeleteRows = false;
            this.dataGridViewProprietaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProprietaires.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProprietaires.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProprietaires.Name = "dataGridViewProprietaires";
            this.dataGridViewProprietaires.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProprietaires.Size = new System.Drawing.Size(708, 349);
            this.dataGridViewProprietaires.TabIndex = 21;
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(247, 22);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(98, 20);
            this.buttonRechercher.TabIndex = 26;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            // 
            // textBoxrechercher
            // 
            this.textBoxrechercher.Location = new System.Drawing.Point(18, 22);
            this.textBoxrechercher.Name = "textBoxrechercher";
            this.textBoxrechercher.Size = new System.Drawing.Size(202, 20);
            this.textBoxrechercher.TabIndex = 25;
            // 
            // FormProprietairesArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProprietairesArchive";
            this.Text = "FormProprietairesArchive";
            this.Load += new System.EventHandler(this.FormProprietairesArchive_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainerListeProprietaireBody.Panel1.ResumeLayout(false);
            this.splitContainerListeProprietaireBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerListeProprietaireBody)).EndInit();
            this.splitContainerListeProprietaireBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProprietaires)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainerListeProprietaireBody;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonprevious;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.DataGridView dataGridViewProprietaires;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.TextBox textBoxrechercher;
    }
}