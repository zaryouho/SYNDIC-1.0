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
            this.dataGridViewProprietaires = new System.Windows.Forms.DataGridView();
            this.textBoxrechercher = new System.Windows.Forms.TextBox();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonprevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.panelIN = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProprietaires)).BeginInit();
            this.panelIN.SuspendLayout();
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
            this.labelCloseProprietaires.Location = new System.Drawing.Point(729, 9);
            this.labelCloseProprietaires.Name = "labelCloseProprietaires";
            this.labelCloseProprietaires.Size = new System.Drawing.Size(18, 18);
            this.labelCloseProprietaires.TabIndex = 2;
            this.labelCloseProprietaires.Text = "X";
            this.labelCloseProprietaires.Click += new System.EventHandler(this.labelCloseProprietaires_Click);
            // 
            // dataGridViewProprietaires
            // 
            this.dataGridViewProprietaires.AllowUserToAddRows = false;
            this.dataGridViewProprietaires.AllowUserToDeleteRows = false;
            this.dataGridViewProprietaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProprietaires.Location = new System.Drawing.Point(12, 46);
            this.dataGridViewProprietaires.Name = "dataGridViewProprietaires";
            this.dataGridViewProprietaires.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProprietaires.Size = new System.Drawing.Size(668, 196);
            this.dataGridViewProprietaires.TabIndex = 5;
            this.dataGridViewProprietaires.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProprietaires_CellContentClick);
            // 
            // textBoxrechercher
            // 
            this.textBoxrechercher.Location = new System.Drawing.Point(14, 20);
            this.textBoxrechercher.Name = "textBoxrechercher";
            this.textBoxrechercher.Size = new System.Drawing.Size(202, 20);
            this.textBoxrechercher.TabIndex = 6;
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(222, 20);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(98, 20);
            this.buttonRechercher.TabIndex = 7;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(692, 46);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(39, 31);
            this.buttonFirst.TabIndex = 8;
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonprevious
            // 
            this.buttonprevious.Location = new System.Drawing.Point(692, 101);
            this.buttonprevious.Name = "buttonprevious";
            this.buttonprevious.Size = new System.Drawing.Size(39, 31);
            this.buttonprevious.TabIndex = 9;
            this.buttonprevious.UseVisualStyleBackColor = true;
            this.buttonprevious.Click += new System.EventHandler(this.buttonprevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(692, 156);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(39, 31);
            this.buttonNext.TabIndex = 10;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(692, 211);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(39, 31);
            this.buttonLast.TabIndex = 11;
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(14, 248);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(75, 35);
            this.buttonAjouter.TabIndex = 12;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(309, 248);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(75, 35);
            this.buttonModifier.TabIndex = 13;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(604, 248);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(75, 35);
            this.buttonSupprimer.TabIndex = 14;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // panelIN
            // 
            this.panelIN.Controls.Add(this.buttonSupprimer);
            this.panelIN.Controls.Add(this.buttonModifier);
            this.panelIN.Controls.Add(this.buttonAjouter);
            this.panelIN.Controls.Add(this.buttonLast);
            this.panelIN.Controls.Add(this.buttonNext);
            this.panelIN.Controls.Add(this.buttonprevious);
            this.panelIN.Controls.Add(this.buttonFirst);
            this.panelIN.Controls.Add(this.buttonRechercher);
            this.panelIN.Controls.Add(this.textBoxrechercher);
            this.panelIN.Controls.Add(this.dataGridViewProprietaires);
            this.panelIN.Location = new System.Drawing.Point(16, 84);
            this.panelIN.Name = "panelIN";
            this.panelIN.Size = new System.Drawing.Size(739, 317);
            this.panelIN.TabIndex = 15;
            // 
            // frmProprietaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 600);
            this.Controls.Add(this.panelIN);
            this.Controls.Add(this.labelCloseProprietaires);
            this.Controls.Add(this.labelProprietaires);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProprietaires";
            this.Text = "frmProprietaires";
            this.Load += new System.EventHandler(this.frmProprietaires_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProprietaires)).EndInit();
            this.panelIN.ResumeLayout(false);
            this.panelIN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProprietaires;
        private System.Windows.Forms.Label labelCloseProprietaires;
        private System.Windows.Forms.DataGridView dataGridViewProprietaires;
        private System.Windows.Forms.TextBox textBoxrechercher;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonprevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Panel panelIN;
    }
}