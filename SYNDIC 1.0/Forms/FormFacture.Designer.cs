namespace SYNDIC_1._0
{
    partial class FormFacture
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
            this.splitContainerFactures = new System.Windows.Forms.SplitContainer();
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
            this.dataGridViewFactures = new System.Windows.Forms.DataGridView();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.buttonAjouterFacture = new System.Windows.Forms.Button();
            this.buttonModifierIntervention = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFactures)).BeginInit();
            this.splitContainerFactures.Panel1.SuspendLayout();
            this.splitContainerFactures.Panel2.SuspendLayout();
            this.splitContainerFactures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBody)).BeginInit();
            this.splitContainerBody.Panel1.SuspendLayout();
            this.splitContainerBody.Panel2.SuspendLayout();
            this.splitContainerBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactures)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerFactures
            // 
            this.splitContainerFactures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFactures.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFactures.Name = "splitContainerFactures";
            this.splitContainerFactures.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerFactures.Panel1
            // 
            this.splitContainerFactures.Panel1.Controls.Add(this.buttonRetour);
            this.splitContainerFactures.Panel1.Controls.Add(this.labelCloseDepense);
            this.splitContainerFactures.Panel1.Controls.Add(this.textBoxRechercher);
            this.splitContainerFactures.Panel1.Controls.Add(this.labelRechercher);
            this.splitContainerFactures.Panel1.Controls.Add(this.buttonChercher);
            // 
            // splitContainerFactures.Panel2
            // 
            this.splitContainerFactures.Panel2.Controls.Add(this.splitContainerBody);
            this.splitContainerFactures.Panel2.Controls.Add(this.panelFooter);
            this.splitContainerFactures.Size = new System.Drawing.Size(800, 450);
            this.splitContainerFactures.SplitterDistance = 73;
            this.splitContainerFactures.TabIndex = 0;
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
            this.buttonRetour.Location = new System.Drawing.Point(653, 29);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(133, 37);
            this.buttonRetour.TabIndex = 17;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            // 
            // labelCloseDepense
            // 
            this.labelCloseDepense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCloseDepense.AutoSize = true;
            this.labelCloseDepense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseDepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCloseDepense.Location = new System.Drawing.Point(778, 3);
            this.labelCloseDepense.Name = "labelCloseDepense";
            this.labelCloseDepense.Size = new System.Drawing.Size(18, 18);
            this.labelCloseDepense.TabIndex = 16;
            this.labelCloseDepense.Text = "X";
            this.labelCloseDepense.Click += new System.EventHandler(this.labelCloseDepense_Click);
            // 
            // textBoxRechercher
            // 
            this.textBoxRechercher.Location = new System.Drawing.Point(12, 25);
            this.textBoxRechercher.Name = "textBoxRechercher";
            this.textBoxRechercher.Size = new System.Drawing.Size(217, 20);
            this.textBoxRechercher.TabIndex = 13;
            // 
            // labelRechercher
            // 
            this.labelRechercher.AutoSize = true;
            this.labelRechercher.Location = new System.Drawing.Point(12, 8);
            this.labelRechercher.Name = "labelRechercher";
            this.labelRechercher.Size = new System.Drawing.Size(69, 13);
            this.labelRechercher.TabIndex = 14;
            this.labelRechercher.Text = "Rechercher :";
            // 
            // buttonChercher
            // 
            this.buttonChercher.Enabled = false;
            this.buttonChercher.Location = new System.Drawing.Point(252, 25);
            this.buttonChercher.Name = "buttonChercher";
            this.buttonChercher.Size = new System.Drawing.Size(64, 20);
            this.buttonChercher.TabIndex = 15;
            this.buttonChercher.Text = "Chercher";
            this.buttonChercher.UseVisualStyleBackColor = true;
            // 
            // splitContainerBody
            // 
            this.splitContainerBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBody.IsSplitterFixed = true;
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
            this.splitContainerBody.Panel2.Controls.Add(this.dataGridViewFactures);
            this.splitContainerBody.Size = new System.Drawing.Size(800, 290);
            this.splitContainerBody.TabIndex = 2;
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(7, 232);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(39, 39);
            this.buttonLast.TabIndex = 21;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(4, 90);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(39, 39);
            this.buttonPrevious.TabIndex = 19;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(7, 161);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(39, 39);
            this.buttonNext.TabIndex = 20;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(4, 19);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(39, 39);
            this.buttonFirst.TabIndex = 18;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFactures
            // 
            this.dataGridViewFactures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFactures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFactures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFactures.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFactures.Name = "dataGridViewFactures";
            this.dataGridViewFactures.ReadOnly = true;
            this.dataGridViewFactures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFactures.Size = new System.Drawing.Size(746, 290);
            this.dataGridViewFactures.TabIndex = 16;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.buttonAjouterFacture);
            this.panelFooter.Controls.Add(this.buttonModifierIntervention);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 290);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(800, 83);
            this.panelFooter.TabIndex = 1;
            // 
            // buttonAjouterFacture
            // 
            this.buttonAjouterFacture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjouterFacture.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAjouterFacture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAjouterFacture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjouterFacture.FlatAppearance.BorderSize = 0;
            this.buttonAjouterFacture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonAjouterFacture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonAjouterFacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterFacture.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterFacture.ForeColor = System.Drawing.Color.White;
            this.buttonAjouterFacture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouterFacture.Location = new System.Drawing.Point(74, 14);
            this.buttonAjouterFacture.Name = "buttonAjouterFacture";
            this.buttonAjouterFacture.Size = new System.Drawing.Size(242, 53);
            this.buttonAjouterFacture.TabIndex = 10;
            this.buttonAjouterFacture.Text = "Ajouter Facture";
            this.buttonAjouterFacture.UseVisualStyleBackColor = false;
            this.buttonAjouterFacture.Click += new System.EventHandler(this.buttonAjouterFacture_Click);
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
            this.buttonModifierIntervention.Text = "Modifier la facture";
            this.buttonModifierIntervention.UseVisualStyleBackColor = false;
            // 
            // FormFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainerFactures);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFacture";
            this.Text = "FormFacture";
            this.Load += new System.EventHandler(this.FormFacture_Load);
            this.splitContainerFactures.Panel1.ResumeLayout(false);
            this.splitContainerFactures.Panel1.PerformLayout();
            this.splitContainerFactures.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFactures)).EndInit();
            this.splitContainerFactures.ResumeLayout(false);
            this.splitContainerBody.Panel1.ResumeLayout(false);
            this.splitContainerBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBody)).EndInit();
            this.splitContainerBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactures)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerFactures;
        private System.Windows.Forms.SplitContainer splitContainerBody;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button buttonAjouterFacture;
        private System.Windows.Forms.Button buttonModifierIntervention;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Label labelCloseDepense;
        private System.Windows.Forms.TextBox textBoxRechercher;
        private System.Windows.Forms.Label labelRechercher;
        private System.Windows.Forms.Button buttonChercher;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.DataGridView dataGridViewFactures;
    }
}