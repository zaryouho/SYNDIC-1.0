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
            this.textBoxResidence = new System.Windows.Forms.TextBox();
            this.buttonAjouterBien = new System.Windows.Forms.Button();
            this.buttonAjouterImmeuble = new System.Windows.Forms.Button();
            this.buttonAjouterBloc = new System.Windows.Forms.Button();
            this.textBoxnbrBien = new System.Windows.Forms.TextBox();
            this.textBoxnbrImmeuble = new System.Windows.Forms.TextBox();
            this.textBoxnbrBloc = new System.Windows.Forms.TextBox();
            this.dataGridViewconsultations = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxImmeuble = new System.Windows.Forms.ComboBox();
            this.comboBoxBloc = new System.Windows.Forms.ComboBox();
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
            this.labelResidence.Text = "La Residence";
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
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonImprimer);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxResidence);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAjouterBien);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAjouterImmeuble);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAjouterBloc);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxnbrBien);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxnbrImmeuble);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxnbrBloc);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewconsultations);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(800, 398);
            this.splitContainer1.SplitterDistance = 273;
            this.splitContainer1.TabIndex = 6;
            // 
            // buttonImprimer
            // 
            this.buttonImprimer.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonImprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimer.ForeColor = System.Drawing.Color.White;
            this.buttonImprimer.Location = new System.Drawing.Point(24, 351);
            this.buttonImprimer.Name = "buttonImprimer";
            this.buttonImprimer.Size = new System.Drawing.Size(195, 35);
            this.buttonImprimer.TabIndex = 14;
            this.buttonImprimer.Text = "Imprimer";
            this.buttonImprimer.UseVisualStyleBackColor = false;
            this.buttonImprimer.Click += new System.EventHandler(this.buttonImprimer_Click);
            // 
            // textBoxResidence
            // 
            this.textBoxResidence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResidence.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxResidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResidence.Location = new System.Drawing.Point(0, 0);
            this.textBoxResidence.Multiline = true;
            this.textBoxResidence.Name = "textBoxResidence";
            this.textBoxResidence.Size = new System.Drawing.Size(273, 130);
            this.textBoxResidence.TabIndex = 13;
            // 
            // buttonAjouterBien
            // 
            this.buttonAjouterBien.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAjouterBien.ForeColor = System.Drawing.Color.White;
            this.buttonAjouterBien.Location = new System.Drawing.Point(225, 187);
            this.buttonAjouterBien.Name = "buttonAjouterBien";
            this.buttonAjouterBien.Size = new System.Drawing.Size(35, 20);
            this.buttonAjouterBien.TabIndex = 12;
            this.buttonAjouterBien.Text = "...";
            this.buttonAjouterBien.UseVisualStyleBackColor = false;
            // 
            // buttonAjouterImmeuble
            // 
            this.buttonAjouterImmeuble.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAjouterImmeuble.ForeColor = System.Drawing.Color.White;
            this.buttonAjouterImmeuble.Location = new System.Drawing.Point(225, 161);
            this.buttonAjouterImmeuble.Name = "buttonAjouterImmeuble";
            this.buttonAjouterImmeuble.Size = new System.Drawing.Size(35, 20);
            this.buttonAjouterImmeuble.TabIndex = 11;
            this.buttonAjouterImmeuble.Text = "...";
            this.buttonAjouterImmeuble.UseVisualStyleBackColor = false;
            this.buttonAjouterImmeuble.Click += new System.EventHandler(this.buttonAjouterImmeuble_Click);
            // 
            // buttonAjouterBloc
            // 
            this.buttonAjouterBloc.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAjouterBloc.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterBloc.ForeColor = System.Drawing.Color.White;
            this.buttonAjouterBloc.Location = new System.Drawing.Point(225, 136);
            this.buttonAjouterBloc.Name = "buttonAjouterBloc";
            this.buttonAjouterBloc.Size = new System.Drawing.Size(35, 20);
            this.buttonAjouterBloc.TabIndex = 10;
            this.buttonAjouterBloc.Text = "...";
            this.buttonAjouterBloc.UseVisualStyleBackColor = false;
            this.buttonAjouterBloc.Click += new System.EventHandler(this.buttonAjouterBloc_Click);
            // 
            // textBoxnbrBien
            // 
            this.textBoxnbrBien.Enabled = false;
            this.textBoxnbrBien.Location = new System.Drawing.Point(3, 188);
            this.textBoxnbrBien.Name = "textBoxnbrBien";
            this.textBoxnbrBien.Size = new System.Drawing.Size(216, 20);
            this.textBoxnbrBien.TabIndex = 9;
            // 
            // textBoxnbrImmeuble
            // 
            this.textBoxnbrImmeuble.Enabled = false;
            this.textBoxnbrImmeuble.Location = new System.Drawing.Point(3, 162);
            this.textBoxnbrImmeuble.Name = "textBoxnbrImmeuble";
            this.textBoxnbrImmeuble.Size = new System.Drawing.Size(216, 20);
            this.textBoxnbrImmeuble.TabIndex = 8;
            // 
            // textBoxnbrBloc
            // 
            this.textBoxnbrBloc.Enabled = false;
            this.textBoxnbrBloc.Location = new System.Drawing.Point(3, 136);
            this.textBoxnbrBloc.Name = "textBoxnbrBloc";
            this.textBoxnbrBloc.Size = new System.Drawing.Size(216, 20);
            this.textBoxnbrBloc.TabIndex = 7;
            // 
            // dataGridViewconsultations
            // 
            this.dataGridViewconsultations.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewconsultations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewconsultations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewconsultations.Location = new System.Drawing.Point(0, 43);
            this.dataGridViewconsultations.Name = "dataGridViewconsultations";
            this.dataGridViewconsultations.Size = new System.Drawing.Size(523, 355);
            this.dataGridViewconsultations.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBoxImmeuble);
            this.panel3.Controls.Add(this.comboBoxBloc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(523, 43);
            this.panel3.TabIndex = 5;
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
        private System.Windows.Forms.Button buttonAjouterBien;
        private System.Windows.Forms.Button buttonAjouterImmeuble;
        private System.Windows.Forms.Button buttonAjouterBloc;
        private System.Windows.Forms.TextBox textBoxnbrBien;
        private System.Windows.Forms.TextBox textBoxnbrImmeuble;
        private System.Windows.Forms.TextBox textBoxnbrBloc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxImmeuble;
        private System.Windows.Forms.ComboBox comboBoxBloc;
        private System.Windows.Forms.DataGridView dataGridViewconsultations;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxResidence;
        private System.Windows.Forms.Button buttonImprimer;
        private System.Drawing.Printing.PrintDocument printDocumentECbiens;
    }
}