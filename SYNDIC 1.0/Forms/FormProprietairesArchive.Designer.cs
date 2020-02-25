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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.textBoxrechercher = new System.Windows.Forms.TextBox();
            this.splitContainerListeProprietaireBody = new System.Windows.Forms.SplitContainer();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonprevious = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.dataGridViewProprietaires = new System.Windows.Forms.DataGridView();
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
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainerListeProprietaireBody);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(784, 411);
            this.splitContainer1.SplitterDistance = 58;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.buttonRechercher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.buttonRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRechercher.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRechercher.Location = new System.Drawing.Point(247, 12);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(108, 30);
            this.buttonRechercher.TabIndex = 1;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            // 
            // textBoxrechercher
            // 
            this.textBoxrechercher.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxrechercher.Location = new System.Drawing.Point(18, 22);
            this.textBoxrechercher.Name = "textBoxrechercher";
            this.textBoxrechercher.Size = new System.Drawing.Size(212, 22);
            this.textBoxrechercher.TabIndex = 0;
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
            this.splitContainerListeProprietaireBody.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainerListeProprietaireBody.Panel2
            // 
            this.splitContainerListeProprietaireBody.Panel2.Controls.Add(this.dataGridViewProprietaires);
            this.splitContainerListeProprietaireBody.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainerListeProprietaireBody.Size = new System.Drawing.Size(784, 349);
            this.splitContainerListeProprietaireBody.SplitterDistance = 72;
            this.splitContainerListeProprietaireBody.TabIndex = 31;
            // 
            // buttonLast
            // 
            this.buttonLast.FlatAppearance.BorderSize = 0;
            this.buttonLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast.Image = global::SYNDIC_1._0.Properties.Resources.down_chevron_2;
            this.buttonLast.Location = new System.Drawing.Point(18, 258);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(39, 39);
            this.buttonLast.TabIndex = 4;
            this.buttonLast.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Image = global::SYNDIC_1._0.Properties.Resources.down_chevron_1;
            this.buttonNext.Location = new System.Drawing.Point(18, 203);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(39, 39);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonprevious
            // 
            this.buttonprevious.FlatAppearance.BorderSize = 0;
            this.buttonprevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonprevious.Image = global::SYNDIC_1._0.Properties.Resources.up_chevron_1111;
            this.buttonprevious.Location = new System.Drawing.Point(18, 96);
            this.buttonprevious.Name = "buttonprevious";
            this.buttonprevious.Size = new System.Drawing.Size(39, 39);
            this.buttonprevious.TabIndex = 3;
            this.buttonprevious.UseVisualStyleBackColor = true;
            // 
            // buttonFirst
            // 
            this.buttonFirst.FlatAppearance.BorderSize = 0;
            this.buttonFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFirst.Image = global::SYNDIC_1._0.Properties.Resources.up_chevron_2222;
            this.buttonFirst.Location = new System.Drawing.Point(18, 41);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(39, 39);
            this.buttonFirst.TabIndex = 5;
            this.buttonFirst.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProprietaires
            // 
            this.dataGridViewProprietaires.AllowUserToAddRows = false;
            this.dataGridViewProprietaires.AllowUserToDeleteRows = false;
            this.dataGridViewProprietaires.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewProprietaires.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProprietaires.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProprietaires.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProprietaires.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProprietaires.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProprietaires.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewProprietaires.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProprietaires.Name = "dataGridViewProprietaires";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProprietaires.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProprietaires.RowHeadersWidth = 25;
            this.dataGridViewProprietaires.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProprietaires.Size = new System.Drawing.Size(708, 349);
            this.dataGridViewProprietaires.TabIndex = 6;
            // 
            // FormProprietairesArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProprietairesArchive";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
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