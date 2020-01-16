namespace SYNDIC_1._0
{
    partial class frmBiens
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
            this.labelBiens = new System.Windows.Forms.Label();
            this.labelCloseBiens = new System.Windows.Forms.Label();
            this.panelHead = new System.Windows.Forms.Panel();
            this.splitContainerBiens = new System.Windows.Forms.SplitContainer();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.labelImmeuble = new System.Windows.Forms.Label();
            this.labelBloc = new System.Windows.Forms.Label();
            this.comboBoxImmeuble = new System.Windows.Forms.ComboBox();
            this.comboBoxBloc = new System.Windows.Forms.ComboBox();
            this.buttonChercher = new System.Windows.Forms.Button();
            this.labelRechercher = new System.Windows.Forms.Label();
            this.textBoxRechercher = new System.Windows.Forms.TextBox();
            this.dataGridViewBien = new System.Windows.Forms.DataGridView();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBiens)).BeginInit();
            this.splitContainerBiens.Panel1.SuspendLayout();
            this.splitContainerBiens.Panel2.SuspendLayout();
            this.splitContainerBiens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBien)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBiens
            // 
            this.labelBiens.AutoSize = true;
            this.labelBiens.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBiens.Location = new System.Drawing.Point(368, 15);
            this.labelBiens.Name = "labelBiens";
            this.labelBiens.Size = new System.Drawing.Size(76, 30);
            this.labelBiens.TabIndex = 0;
            this.labelBiens.Text = "BIENS";
            // 
            // labelCloseBiens
            // 
            this.labelCloseBiens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCloseBiens.AutoSize = true;
            this.labelCloseBiens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseBiens.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCloseBiens.Location = new System.Drawing.Point(737, 4);
            this.labelCloseBiens.Name = "labelCloseBiens";
            this.labelCloseBiens.Size = new System.Drawing.Size(18, 18);
            this.labelCloseBiens.TabIndex = 1;
            this.labelCloseBiens.Text = "X";
            this.labelCloseBiens.Click += new System.EventHandler(this.labelCloseBiens_Click);
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.labelCloseBiens);
            this.panelHead.Controls.Add(this.labelBiens);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(759, 60);
            this.panelHead.TabIndex = 2;
            // 
            // splitContainerBiens
            // 
            this.splitContainerBiens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBiens.Location = new System.Drawing.Point(0, 60);
            this.splitContainerBiens.Name = "splitContainerBiens";
            this.splitContainerBiens.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerBiens.Panel1
            // 
            this.splitContainerBiens.Panel1.Controls.Add(this.buttonModifier);
            this.splitContainerBiens.Panel1.Controls.Add(this.buttonLast);
            this.splitContainerBiens.Panel1.Controls.Add(this.buttonNext);
            this.splitContainerBiens.Panel1.Controls.Add(this.buttonPrevious);
            this.splitContainerBiens.Panel1.Controls.Add(this.buttonFirst);
            this.splitContainerBiens.Panel1.Controls.Add(this.labelImmeuble);
            this.splitContainerBiens.Panel1.Controls.Add(this.labelBloc);
            this.splitContainerBiens.Panel1.Controls.Add(this.comboBoxImmeuble);
            this.splitContainerBiens.Panel1.Controls.Add(this.comboBoxBloc);
            this.splitContainerBiens.Panel1.Controls.Add(this.buttonChercher);
            this.splitContainerBiens.Panel1.Controls.Add(this.labelRechercher);
            this.splitContainerBiens.Panel1.Controls.Add(this.textBoxRechercher);
            // 
            // splitContainerBiens.Panel2
            // 
            this.splitContainerBiens.Panel2.Controls.Add(this.dataGridViewBien);
            this.splitContainerBiens.Size = new System.Drawing.Size(759, 540);
            this.splitContainerBiens.SplitterDistance = 100;
            this.splitContainerBiens.TabIndex = 3;
            // 
            // buttonModifier
            // 
            this.buttonModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModifier.Location = new System.Drawing.Point(581, 67);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(161, 23);
            this.buttonModifier.TabIndex = 11;
            this.buttonModifier.Text = "Modifier Le Bien";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(126, 67);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(30, 23);
            this.buttonLast.TabIndex = 10;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(96, 67);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(30, 23);
            this.buttonNext.TabIndex = 9;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(66, 67);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(30, 23);
            this.buttonPrevious.TabIndex = 8;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(36, 67);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(30, 23);
            this.buttonFirst.TabIndex = 7;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // labelImmeuble
            // 
            this.labelImmeuble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelImmeuble.AutoSize = true;
            this.labelImmeuble.Location = new System.Drawing.Point(547, 8);
            this.labelImmeuble.Name = "labelImmeuble";
            this.labelImmeuble.Size = new System.Drawing.Size(129, 13);
            this.labelImmeuble.TabIndex = 6;
            this.labelImmeuble.Text = "Selectioner un Immeuble :";
            // 
            // labelBloc
            // 
            this.labelBloc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBloc.AutoSize = true;
            this.labelBloc.Location = new System.Drawing.Point(338, 8);
            this.labelBloc.Name = "labelBloc";
            this.labelBloc.Size = new System.Drawing.Size(111, 13);
            this.labelBloc.TabIndex = 5;
            this.labelBloc.Text = "Selectioner une Bloc :";
            // 
            // comboBoxImmeuble
            // 
            this.comboBoxImmeuble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxImmeuble.FormattingEnabled = true;
            this.comboBoxImmeuble.Location = new System.Drawing.Point(547, 30);
            this.comboBoxImmeuble.Name = "comboBoxImmeuble";
            this.comboBoxImmeuble.Size = new System.Drawing.Size(193, 21);
            this.comboBoxImmeuble.TabIndex = 4;
            // 
            // comboBoxBloc
            // 
            this.comboBoxBloc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxBloc.FormattingEnabled = true;
            this.comboBoxBloc.Location = new System.Drawing.Point(338, 30);
            this.comboBoxBloc.Name = "comboBoxBloc";
            this.comboBoxBloc.Size = new System.Drawing.Size(193, 21);
            this.comboBoxBloc.TabIndex = 3;
            // 
            // buttonChercher
            // 
            this.buttonChercher.Enabled = false;
            this.buttonChercher.Location = new System.Drawing.Point(205, 31);
            this.buttonChercher.Name = "buttonChercher";
            this.buttonChercher.Size = new System.Drawing.Size(64, 20);
            this.buttonChercher.TabIndex = 2;
            this.buttonChercher.Text = "Chercher";
            this.buttonChercher.UseVisualStyleBackColor = true;
            this.buttonChercher.Click += new System.EventHandler(this.buttonChercher_Click);
            // 
            // labelRechercher
            // 
            this.labelRechercher.AutoSize = true;
            this.labelRechercher.Location = new System.Drawing.Point(24, 8);
            this.labelRechercher.Name = "labelRechercher";
            this.labelRechercher.Size = new System.Drawing.Size(69, 13);
            this.labelRechercher.TabIndex = 1;
            this.labelRechercher.Text = "Rechercher :";
            // 
            // textBoxRechercher
            // 
            this.textBoxRechercher.Location = new System.Drawing.Point(24, 31);
            this.textBoxRechercher.Name = "textBoxRechercher";
            this.textBoxRechercher.Size = new System.Drawing.Size(165, 20);
            this.textBoxRechercher.TabIndex = 0;
            this.textBoxRechercher.TextChanged += new System.EventHandler(this.textBoxRechercher_TextChanged);
            this.textBoxRechercher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRechercher_KeyPress);
            // 
            // dataGridViewBien
            // 
            this.dataGridViewBien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBien.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBien.Name = "dataGridViewBien";
            this.dataGridViewBien.ReadOnly = true;
            this.dataGridViewBien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBien.Size = new System.Drawing.Size(759, 436);
            this.dataGridViewBien.TabIndex = 2;
            this.dataGridViewBien.DoubleClick += new System.EventHandler(this.buttonModifier_Click);
            // 
            // frmBiens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 600);
            this.Controls.Add(this.splitContainerBiens);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBiens";
            this.Text = "frmBiens";
            this.Load += new System.EventHandler(this.frmBiens_Load);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.splitContainerBiens.Panel1.ResumeLayout(false);
            this.splitContainerBiens.Panel1.PerformLayout();
            this.splitContainerBiens.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBiens)).EndInit();
            this.splitContainerBiens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBiens;
        private System.Windows.Forms.Label labelCloseBiens;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.SplitContainer splitContainerBiens;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Label labelImmeuble;
        private System.Windows.Forms.Label labelBloc;
        private System.Windows.Forms.ComboBox comboBoxImmeuble;
        private System.Windows.Forms.ComboBox comboBoxBloc;
        private System.Windows.Forms.Button buttonChercher;
        private System.Windows.Forms.Label labelRechercher;
        private System.Windows.Forms.TextBox textBoxRechercher;
        private System.Windows.Forms.DataGridView dataGridViewBien;
    }
}