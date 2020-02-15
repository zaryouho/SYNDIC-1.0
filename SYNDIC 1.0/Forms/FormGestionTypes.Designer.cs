namespace SYNDIC_1._0
{
    partial class FormGestionTypes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridGestionType = new System.Windows.Forms.DataGridView();
            this.panelCrud = new System.Windows.Forms.Panel();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.panelValider = new System.Windows.Forms.Panel();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.panelHead = new System.Windows.Forms.Panel();
            this.labelCloseDepense = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGestionType)).BeginInit();
            this.panelCrud.SuspendLayout();
            this.panelValider.SuspendLayout();
            this.panelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridGestionType
            // 
            this.dataGridGestionType.AllowUserToAddRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridGestionType.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridGestionType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridGestionType.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridGestionType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridGestionType.ColumnHeadersHeight = 40;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridGestionType.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridGestionType.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridGestionType.Location = new System.Drawing.Point(12, 33);
            this.dataGridGestionType.Name = "dataGridGestionType";
            this.dataGridGestionType.Size = new System.Drawing.Size(331, 274);
            this.dataGridGestionType.TabIndex = 0;
            // 
            // panelCrud
            // 
            this.panelCrud.Controls.Add(this.btnSupprimer);
            this.panelCrud.Controls.Add(this.btnModifier);
            this.panelCrud.Controls.Add(this.btnAjouter);
            this.panelCrud.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCrud.Location = new System.Drawing.Point(12, 313);
            this.panelCrud.Name = "panelCrud";
            this.panelCrud.Size = new System.Drawing.Size(319, 34);
            this.panelCrud.TabIndex = 6;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(225, 1);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(91, 30);
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(111, 1);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(91, 30);
            this.btnModifier.TabIndex = 5;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(3, 1);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(91, 30);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // panelValider
            // 
            this.panelValider.Controls.Add(this.btnAnnuler);
            this.panelValider.Controls.Add(this.btnValider);
            this.panelValider.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelValider.Location = new System.Drawing.Point(15, 353);
            this.panelValider.Name = "panelValider";
            this.panelValider.Size = new System.Drawing.Size(319, 39);
            this.panelValider.TabIndex = 7;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Image = global::SYNDIC_1._0.Properties.Resources.DeleteReddd;
            this.btnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnuler.Location = new System.Drawing.Point(168, 0);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(145, 33);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Image = global::SYNDIC_1._0.Properties.Resources.valider;
            this.btnValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValider.Location = new System.Drawing.Point(3, 1);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(136, 32);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.labelCloseDepense);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(357, 27);
            this.panelHead.TabIndex = 8;
            // 
            // labelCloseDepense
            // 
            this.labelCloseDepense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCloseDepense.AutoSize = true;
            this.labelCloseDepense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseDepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCloseDepense.Location = new System.Drawing.Point(336, 0);
            this.labelCloseDepense.Name = "labelCloseDepense";
            this.labelCloseDepense.Size = new System.Drawing.Size(18, 18);
            this.labelCloseDepense.TabIndex = 17;
            this.labelCloseDepense.Text = "X";
            this.labelCloseDepense.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormGestionTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(357, 398);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.panelValider);
            this.Controls.Add(this.panelCrud);
            this.Controls.Add(this.dataGridGestionType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormGestionTypes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGestionTypes_FormClosing);
            this.Load += new System.EventHandler(this.FormGestionTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGestionType)).EndInit();
            this.panelCrud.ResumeLayout(false);
            this.panelValider.ResumeLayout(false);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridGestionType;
        private System.Windows.Forms.Panel panelCrud;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Panel panelValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label labelCloseDepense;
    }
}