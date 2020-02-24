namespace SYNDIC_1._0
{
    partial class FormResidence
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
            this.labelResidence = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonImprimer = new System.Windows.Forms.Button();
            this.buttonListDocs = new System.Windows.Forms.Button();
            this.labelnbrBien = new System.Windows.Forms.Label();
            this.labelnbrBloc = new System.Windows.Forms.Label();
            this.labelnbrImmeuble = new System.Windows.Forms.Label();
            this.buttonAjouterBloc = new System.Windows.Forms.Button();
            this.buttonAjouterImmeuble = new System.Windows.Forms.Button();
            this.buttonAjouterBien = new System.Windows.Forms.Button();
            this.textBoxResidence = new System.Windows.Forms.TextBox();
            this.dataGridViewconsultations = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelAnnee = new System.Windows.Forms.Label();
            this.comboBoxAnnee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxImmeuble = new System.Windows.Forms.ComboBox();
            this.comboBoxBloc = new System.Windows.Forms.ComboBox();
            this.listBoxIdBien = new System.Windows.Forms.ListBox();
            this.printDocumentECbiens = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewconsultations)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelResidence
            // 
            this.labelResidence.AutoSize = true;
            this.labelResidence.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResidence.Location = new System.Drawing.Point(299, 9);
            this.labelResidence.Name = "labelResidence";
            this.labelResidence.Size = new System.Drawing.Size(173, 30);
            this.labelResidence.TabIndex = 3;
            this.labelResidence.Text = "La Résidence";
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelClose.Location = new System.Drawing.Point(782, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(18, 18);
            this.labelClose.TabIndex = 4;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelCloseDocuments_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelClose);
            this.panel1.Controls.Add(this.labelResidence);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 52);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 398);
            this.panel2.TabIndex = 6;
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
            this.splitContainer1.Panel1.Controls.Add(this.buttonImprimer);
            this.splitContainer1.Panel1.Controls.Add(this.buttonListDocs);
            this.splitContainer1.Panel1.Controls.Add(this.labelnbrBien);
            this.splitContainer1.Panel1.Controls.Add(this.labelnbrBloc);
            this.splitContainer1.Panel1.Controls.Add(this.labelnbrImmeuble);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAjouterBloc);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAjouterImmeuble);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAjouterBien);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxResidence);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewconsultations);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.listBoxIdBien);
            this.splitContainer1.Size = new System.Drawing.Size(800, 398);
            this.splitContainer1.SplitterDistance = 116;
            this.splitContainer1.TabIndex = 6;
            // 
            // buttonImprimer
            // 
            this.buttonImprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImprimer.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonImprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonImprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImprimer.FlatAppearance.BorderSize = 0;
            this.buttonImprimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonImprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimer.ForeColor = System.Drawing.Color.White;
            this.buttonImprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonImprimer.Location = new System.Drawing.Point(602, 75);
            this.buttonImprimer.Name = "buttonImprimer";
            this.buttonImprimer.Size = new System.Drawing.Size(195, 35);
            this.buttonImprimer.TabIndex = 31;
            this.buttonImprimer.Text = "Imprimer";
            this.buttonImprimer.UseVisualStyleBackColor = false;
            this.buttonImprimer.Click += new System.EventHandler(this.buttonImprimer_Click);
            // 
            // buttonListDocs
            // 
            this.buttonListDocs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonListDocs.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonListDocs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonListDocs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonListDocs.FlatAppearance.BorderSize = 0;
            this.buttonListDocs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonListDocs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonListDocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListDocs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListDocs.ForeColor = System.Drawing.Color.White;
            this.buttonListDocs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListDocs.Location = new System.Drawing.Point(602, 7);
            this.buttonListDocs.Name = "buttonListDocs";
            this.buttonListDocs.Size = new System.Drawing.Size(195, 35);
            this.buttonListDocs.TabIndex = 30;
            this.buttonListDocs.Text = "Listes Documents";
            this.buttonListDocs.UseVisualStyleBackColor = false;
            this.buttonListDocs.Click += new System.EventHandler(this.buttonListDocs_Click);
            // 
            // labelnbrBien
            // 
            this.labelnbrBien.AutoSize = true;
            this.labelnbrBien.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnbrBien.Location = new System.Drawing.Point(289, 7);
            this.labelnbrBien.Name = "labelnbrBien";
            this.labelnbrBien.Size = new System.Drawing.Size(36, 20);
            this.labelnbrBien.TabIndex = 29;
            this.labelnbrBien.Text = "xxx";
            // 
            // labelnbrBloc
            // 
            this.labelnbrBloc.AutoSize = true;
            this.labelnbrBloc.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnbrBloc.Location = new System.Drawing.Point(289, 83);
            this.labelnbrBloc.Name = "labelnbrBloc";
            this.labelnbrBloc.Size = new System.Drawing.Size(54, 20);
            this.labelnbrBloc.TabIndex = 27;
            this.labelnbrBloc.Text = "xxxxx";
            // 
            // labelnbrImmeuble
            // 
            this.labelnbrImmeuble.AutoSize = true;
            this.labelnbrImmeuble.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnbrImmeuble.Location = new System.Drawing.Point(289, 45);
            this.labelnbrImmeuble.Name = "labelnbrImmeuble";
            this.labelnbrImmeuble.Size = new System.Drawing.Size(36, 20);
            this.labelnbrImmeuble.TabIndex = 28;
            this.labelnbrImmeuble.Text = "xxx";
            // 
            // buttonAjouterBloc
            // 
            this.buttonAjouterBloc.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAjouterBloc.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterBloc.ForeColor = System.Drawing.Color.White;
            this.buttonAjouterBloc.Location = new System.Drawing.Point(473, 0);
            this.buttonAjouterBloc.Name = "buttonAjouterBloc";
            this.buttonAjouterBloc.Size = new System.Drawing.Size(55, 39);
            this.buttonAjouterBloc.TabIndex = 24;
            this.buttonAjouterBloc.Text = "...";
            this.buttonAjouterBloc.UseVisualStyleBackColor = false;
            // 
            // buttonAjouterImmeuble
            // 
            this.buttonAjouterImmeuble.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAjouterImmeuble.ForeColor = System.Drawing.Color.White;
            this.buttonAjouterImmeuble.Location = new System.Drawing.Point(473, 37);
            this.buttonAjouterImmeuble.Name = "buttonAjouterImmeuble";
            this.buttonAjouterImmeuble.Size = new System.Drawing.Size(55, 39);
            this.buttonAjouterImmeuble.TabIndex = 25;
            this.buttonAjouterImmeuble.Text = "...";
            this.buttonAjouterImmeuble.UseVisualStyleBackColor = false;
            // 
            // buttonAjouterBien
            // 
            this.buttonAjouterBien.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAjouterBien.ForeColor = System.Drawing.Color.White;
            this.buttonAjouterBien.Location = new System.Drawing.Point(473, 75);
            this.buttonAjouterBien.Name = "buttonAjouterBien";
            this.buttonAjouterBien.Size = new System.Drawing.Size(55, 39);
            this.buttonAjouterBien.TabIndex = 26;
            this.buttonAjouterBien.Text = "...";
            this.buttonAjouterBien.UseVisualStyleBackColor = false;
            // 
            // textBoxResidence
            // 
            this.textBoxResidence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResidence.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxResidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResidence.Location = new System.Drawing.Point(0, 0);
            this.textBoxResidence.Multiline = true;
            this.textBoxResidence.Name = "textBoxResidence";
            this.textBoxResidence.Size = new System.Drawing.Size(273, 116);
            this.textBoxResidence.TabIndex = 13;
            // 
            // dataGridViewconsultations
            // 
            this.dataGridViewconsultations.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewconsultations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewconsultations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewconsultations.Location = new System.Drawing.Point(0, 43);
            this.dataGridViewconsultations.Name = "dataGridViewconsultations";
            this.dataGridViewconsultations.Size = new System.Drawing.Size(800, 235);
            this.dataGridViewconsultations.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelAnnee);
            this.panel3.Controls.Add(this.comboBoxAnnee);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBoxImmeuble);
            this.panel3.Controls.Add(this.comboBoxBloc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 43);
            this.panel3.TabIndex = 5;
            // 
            // labelAnnee
            // 
            this.labelAnnee.AutoSize = true;
            this.labelAnnee.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnnee.Location = new System.Drawing.Point(494, 16);
            this.labelAnnee.Name = "labelAnnee";
            this.labelAnnee.Size = new System.Drawing.Size(53, 17);
            this.labelAnnee.TabIndex = 6;
            this.labelAnnee.Text = "Année :";
            // 
            // comboBoxAnnee
            // 
            this.comboBoxAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnnee.FormattingEnabled = true;
            this.comboBoxAnnee.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.comboBoxAnnee.Location = new System.Drawing.Point(586, 12);
            this.comboBoxAnnee.Name = "comboBoxAnnee";
            this.comboBoxAnnee.Size = new System.Drawing.Size(167, 21);
            this.comboBoxAnnee.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Immeuble :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bloc :";
            // 
            // comboBoxImmeuble
            // 
            this.comboBoxImmeuble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxImmeuble.FormattingEnabled = true;
            this.comboBoxImmeuble.Location = new System.Drawing.Point(321, 12);
            this.comboBoxImmeuble.Name = "comboBoxImmeuble";
            this.comboBoxImmeuble.Size = new System.Drawing.Size(167, 21);
            this.comboBoxImmeuble.TabIndex = 2;
            this.comboBoxImmeuble.SelectedIndexChanged += new System.EventHandler(this.comboBoxImmeuble_SelectedIndexChanged);
            // 
            // comboBoxBloc
            // 
            this.comboBoxBloc.BackColor = System.Drawing.Color.White;
            this.comboBoxBloc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBloc.FormattingEnabled = true;
            this.comboBoxBloc.Location = new System.Drawing.Point(57, 12);
            this.comboBoxBloc.Name = "comboBoxBloc";
            this.comboBoxBloc.Size = new System.Drawing.Size(167, 21);
            this.comboBoxBloc.TabIndex = 1;
            this.comboBoxBloc.SelectedIndexChanged += new System.EventHandler(this.comboBoxBloc_SelectedIndexChanged);
            // 
            // listBoxIdBien
            // 
            this.listBoxIdBien.FormattingEnabled = true;
            this.listBoxIdBien.Location = new System.Drawing.Point(112, 70);
            this.listBoxIdBien.Name = "listBoxIdBien";
            this.listBoxIdBien.Size = new System.Drawing.Size(236, 147);
            this.listBoxIdBien.TabIndex = 6;
            // 
            // printDocumentECbiens
            // 
            this.printDocumentECbiens.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentECbiens_PrintPage);
            // 
            // FormResidence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormResidence";
            this.Text = "frmDocuments";
            this.Load += new System.EventHandler(this.FormResidence_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewconsultations)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelResidence;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxImmeuble;
        private System.Windows.Forms.ComboBox comboBoxBloc;
        private System.Windows.Forms.DataGridView dataGridViewconsultations;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxResidence;
        private System.Drawing.Printing.PrintDocument printDocumentECbiens;
        private System.Windows.Forms.ListBox listBoxIdBien;
        private System.Windows.Forms.Label labelnbrBien;
        private System.Windows.Forms.Label labelnbrBloc;
        private System.Windows.Forms.Label labelnbrImmeuble;
        private System.Windows.Forms.Button buttonAjouterBloc;
        private System.Windows.Forms.Button buttonAjouterImmeuble;
        private System.Windows.Forms.Button buttonAjouterBien;
        private System.Windows.Forms.Button buttonListDocs;
        private System.Windows.Forms.Button buttonImprimer;
        private System.Windows.Forms.Label labelAnnee;
        private System.Windows.Forms.ComboBox comboBoxAnnee;
    }
}