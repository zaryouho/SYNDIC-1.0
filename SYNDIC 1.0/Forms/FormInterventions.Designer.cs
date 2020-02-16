namespace SYNDIC_1._0
{
    partial class FormInterventions
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
            this.splitContainerInterventions = new System.Windows.Forms.SplitContainer();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.labelCloseDepense = new System.Windows.Forms.Label();
            this.textBoxRechercher = new System.Windows.Forms.TextBox();
            this.labelRechercher = new System.Windows.Forms.Label();
            this.buttonChercher = new System.Windows.Forms.Button();
            this.splitContainerBody = new System.Windows.Forms.SplitContainer();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.dataGridViewInterventions = new System.Windows.Forms.DataGridView();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.buttonAjouterIntervention = new System.Windows.Forms.Button();
            this.buttonModifierIntervention = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInterventions)).BeginInit();
            this.splitContainerInterventions.Panel1.SuspendLayout();
            this.splitContainerInterventions.Panel2.SuspendLayout();
            this.splitContainerInterventions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBody)).BeginInit();
            this.splitContainerBody.Panel1.SuspendLayout();
            this.splitContainerBody.Panel2.SuspendLayout();
            this.splitContainerBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInterventions)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerInterventions
            // 
            this.splitContainerInterventions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerInterventions.Location = new System.Drawing.Point(0, 0);
            this.splitContainerInterventions.Name = "splitContainerInterventions";
            this.splitContainerInterventions.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerInterventions.Panel1
            // 
            this.splitContainerInterventions.Panel1.Controls.Add(this.buttonRetour);
            this.splitContainerInterventions.Panel1.Controls.Add(this.labelCloseDepense);
            this.splitContainerInterventions.Panel1.Controls.Add(this.textBoxRechercher);
            this.splitContainerInterventions.Panel1.Controls.Add(this.labelRechercher);
            this.splitContainerInterventions.Panel1.Controls.Add(this.buttonChercher);
            this.splitContainerInterventions.Panel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainerInterventions.Panel2
            // 
            this.splitContainerInterventions.Panel2.Controls.Add(this.splitContainerBody);
            this.splitContainerInterventions.Panel2.Controls.Add(this.panelFooter);
            this.splitContainerInterventions.Size = new System.Drawing.Size(800, 450);
            this.splitContainerInterventions.SplitterDistance = 70;
            this.splitContainerInterventions.TabIndex = 0;
            // 
            // buttonRetour
            // 
            this.buttonRetour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRetour.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonRetour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRetour.FlatAppearance.BorderSize = 0;
            this.buttonRetour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonRetour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetour.ForeColor = System.Drawing.Color.White;
            this.buttonRetour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRetour.Location = new System.Drawing.Point(617, 28);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(133, 37);
            this.buttonRetour.TabIndex = 17;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // labelCloseDepense
            // 
            this.labelCloseDepense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCloseDepense.AutoSize = true;
            this.labelCloseDepense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseDepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCloseDepense.Location = new System.Drawing.Point(770, 6);
            this.labelCloseDepense.Name = "labelCloseDepense";
            this.labelCloseDepense.Size = new System.Drawing.Size(18, 18);
            this.labelCloseDepense.TabIndex = 16;
            this.labelCloseDepense.Text = "X";
            this.labelCloseDepense.Click += new System.EventHandler(this.labelCloseDepense_Click);
            // 
            // textBoxRechercher
            // 
            this.textBoxRechercher.Location = new System.Drawing.Point(15, 35);
            this.textBoxRechercher.Name = "textBoxRechercher";
            this.textBoxRechercher.Size = new System.Drawing.Size(217, 22);
            this.textBoxRechercher.TabIndex = 13;
            // 
            // labelRechercher
            // 
            this.labelRechercher.AutoSize = true;
            this.labelRechercher.Location = new System.Drawing.Point(12, 15);
            this.labelRechercher.Name = "labelRechercher";
            this.labelRechercher.Size = new System.Drawing.Size(83, 17);
            this.labelRechercher.TabIndex = 14;
            this.labelRechercher.Text = "Rechercher :";
            // 
            // buttonChercher
            // 
            this.buttonChercher.Enabled = false;
            this.buttonChercher.Location = new System.Drawing.Point(261, 21);
            this.buttonChercher.Name = "buttonChercher";
            this.buttonChercher.Size = new System.Drawing.Size(98, 36);
            this.buttonChercher.TabIndex = 15;
            this.buttonChercher.Text = "Chercher";
            this.buttonChercher.UseVisualStyleBackColor = true;
            // 
            // splitContainerBody
            // 
            this.splitContainerBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBody.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBody.Name = "splitContainerBody";
            // 
            // splitContainerBody.Panel1
            // 
            this.splitContainerBody.Panel1.Controls.Add(this.buttonLast);
            this.splitContainerBody.Panel1.Controls.Add(this.buttonPrevious);
            this.splitContainerBody.Panel1.Controls.Add(this.buttonNext);
            this.splitContainerBody.Panel1.Controls.Add(this.buttonFirst);
            // 
            // splitContainerBody.Panel2
            // 
            this.splitContainerBody.Panel2.Controls.Add(this.dataGridViewInterventions);
            this.splitContainerBody.Size = new System.Drawing.Size(800, 293);
            this.splitContainerBody.SplitterDistance = 57;
            this.splitContainerBody.TabIndex = 2;
            // 
            // buttonLast
            // 
            this.buttonLast.FlatAppearance.BorderSize = 0;
            this.buttonLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast.Image = global::SYNDIC_1._0.Properties.Resources.down_chevron_2;
            this.buttonLast.Location = new System.Drawing.Point(12, 233);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(39, 39);
            this.buttonLast.TabIndex = 21;
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.FlatAppearance.BorderSize = 0;
            this.buttonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevious.Image = global::SYNDIC_1._0.Properties.Resources.up_chevron_1111;
            this.buttonPrevious.Location = new System.Drawing.Point(9, 91);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(39, 39);
            this.buttonPrevious.TabIndex = 19;
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Image = global::SYNDIC_1._0.Properties.Resources.down_chevron_1;
            this.buttonNext.Location = new System.Drawing.Point(12, 162);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(39, 39);
            this.buttonNext.TabIndex = 20;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.FlatAppearance.BorderSize = 0;
            this.buttonFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFirst.Image = global::SYNDIC_1._0.Properties.Resources.up_chevron_2222;
            this.buttonFirst.Location = new System.Drawing.Point(9, 20);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(39, 39);
            this.buttonFirst.TabIndex = 18;
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // dataGridViewInterventions
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridViewInterventions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewInterventions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInterventions.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewInterventions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInterventions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewInterventions.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInterventions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewInterventions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInterventions.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewInterventions.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewInterventions.Name = "dataGridViewInterventions";
            this.dataGridViewInterventions.ReadOnly = true;
            this.dataGridViewInterventions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInterventions.Size = new System.Drawing.Size(739, 293);
            this.dataGridViewInterventions.TabIndex = 16;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.buttonAjouterIntervention);
            this.panelFooter.Controls.Add(this.buttonModifierIntervention);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 293);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(800, 83);
            this.panelFooter.TabIndex = 1;
            // 
            // buttonAjouterIntervention
            // 
            this.buttonAjouterIntervention.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjouterIntervention.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAjouterIntervention.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAjouterIntervention.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjouterIntervention.FlatAppearance.BorderSize = 0;
            this.buttonAjouterIntervention.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonAjouterIntervention.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonAjouterIntervention.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterIntervention.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterIntervention.ForeColor = System.Drawing.Color.White;
            this.buttonAjouterIntervention.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouterIntervention.Location = new System.Drawing.Point(74, 14);
            this.buttonAjouterIntervention.Name = "buttonAjouterIntervention";
            this.buttonAjouterIntervention.Size = new System.Drawing.Size(242, 53);
            this.buttonAjouterIntervention.TabIndex = 10;
            this.buttonAjouterIntervention.Text = "Ajouter Intervention";
            this.buttonAjouterIntervention.UseVisualStyleBackColor = false;
            this.buttonAjouterIntervention.Click += new System.EventHandler(this.buttonAjouterIntervention_Click);
            // 
            // buttonModifierIntervention
            // 
            this.buttonModifierIntervention.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModifierIntervention.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonModifierIntervention.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonModifierIntervention.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModifierIntervention.FlatAppearance.BorderSize = 0;
            this.buttonModifierIntervention.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonModifierIntervention.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonModifierIntervention.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifierIntervention.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifierIntervention.ForeColor = System.Drawing.Color.White;
            this.buttonModifierIntervention.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModifierIntervention.Location = new System.Drawing.Point(544, 14);
            this.buttonModifierIntervention.Name = "buttonModifierIntervention";
            this.buttonModifierIntervention.Size = new System.Drawing.Size(242, 53);
            this.buttonModifierIntervention.TabIndex = 9;
            this.buttonModifierIntervention.Text = "Modifier l\'intervention";
            this.buttonModifierIntervention.UseVisualStyleBackColor = false;
            this.buttonModifierIntervention.Click += new System.EventHandler(this.buttonModifierIntervention_Click);
            // 
            // FormInterventions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainerInterventions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInterventions";
            this.Text = "FormInterventions";
            this.Load += new System.EventHandler(this.FormInterventions_Load);
            this.splitContainerInterventions.Panel1.ResumeLayout(false);
            this.splitContainerInterventions.Panel1.PerformLayout();
            this.splitContainerInterventions.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInterventions)).EndInit();
            this.splitContainerInterventions.ResumeLayout(false);
            this.splitContainerBody.Panel1.ResumeLayout(false);
            this.splitContainerBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBody)).EndInit();
            this.splitContainerBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInterventions)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerInterventions;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Label labelCloseDepense;
        private System.Windows.Forms.TextBox textBoxRechercher;
        private System.Windows.Forms.Label labelRechercher;
        private System.Windows.Forms.Button buttonChercher;
        private System.Windows.Forms.SplitContainer splitContainerBody;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button buttonAjouterIntervention;
        private System.Windows.Forms.Button buttonModifierIntervention;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.DataGridView dataGridViewInterventions;
    }
}