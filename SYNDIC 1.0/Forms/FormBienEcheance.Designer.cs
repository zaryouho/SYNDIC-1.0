namespace SYNDIC_1._0
{
    partial class FormBienEcheance
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
            this.splitContainerBienEcheance = new System.Windows.Forms.SplitContainer();
            this.labelTypeEcheance = new System.Windows.Forms.Label();
            this.comboBoxTypeEcheance = new System.Windows.Forms.ComboBox();
            this.labelImmeuble = new System.Windows.Forms.Label();
            this.comboBoxImmeuble = new System.Windows.Forms.ComboBox();
            this.labelBloc = new System.Windows.Forms.Label();
            this.comboBoxBloc = new System.Windows.Forms.ComboBox();
            this.splitContainerBienEcheanceBody = new System.Windows.Forms.SplitContainer();
            this.comboBoxBienEcheance = new System.Windows.Forms.ComboBox();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.dataGridViewBienEcheance = new System.Windows.Forms.DataGridView();
            this.dataGridViewListeBien = new System.Windows.Forms.DataGridView();
            this.panelMontantEcheance = new System.Windows.Forms.Panel();
            this.textBoxMontantReste = new System.Windows.Forms.TextBox();
            this.labelMontantReste = new System.Windows.Forms.Label();
            this.textBoxMontantRecu = new System.Windows.Forms.TextBox();
            this.labelMontantRecu = new System.Windows.Forms.Label();
            this.textBoxMontantTotal = new System.Windows.Forms.TextBox();
            this.labelMontantTotal = new System.Windows.Forms.Label();
            this.panelBienEcheanceFooter = new System.Windows.Forms.Panel();
            this.buttonModifierEcheance = new System.Windows.Forms.Button();
            this.buttonAjouterEcheance = new System.Windows.Forms.Button();
            this.buttonSupprimerEcheance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBienEcheance)).BeginInit();
            this.splitContainerBienEcheance.Panel1.SuspendLayout();
            this.splitContainerBienEcheance.Panel2.SuspendLayout();
            this.splitContainerBienEcheance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBienEcheanceBody)).BeginInit();
            this.splitContainerBienEcheanceBody.Panel1.SuspendLayout();
            this.splitContainerBienEcheanceBody.Panel2.SuspendLayout();
            this.splitContainerBienEcheanceBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBienEcheance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeBien)).BeginInit();
            this.panelMontantEcheance.SuspendLayout();
            this.panelBienEcheanceFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerBienEcheance
            // 
            this.splitContainerBienEcheance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBienEcheance.IsSplitterFixed = true;
            this.splitContainerBienEcheance.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBienEcheance.Name = "splitContainerBienEcheance";
            this.splitContainerBienEcheance.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerBienEcheance.Panel1
            // 
            this.splitContainerBienEcheance.Panel1.Controls.Add(this.labelTypeEcheance);
            this.splitContainerBienEcheance.Panel1.Controls.Add(this.comboBoxTypeEcheance);
            this.splitContainerBienEcheance.Panel1.Controls.Add(this.labelImmeuble);
            this.splitContainerBienEcheance.Panel1.Controls.Add(this.comboBoxImmeuble);
            this.splitContainerBienEcheance.Panel1.Controls.Add(this.labelBloc);
            this.splitContainerBienEcheance.Panel1.Controls.Add(this.comboBoxBloc);
            // 
            // splitContainerBienEcheance.Panel2
            // 
            this.splitContainerBienEcheance.Panel2.Controls.Add(this.splitContainerBienEcheanceBody);
            this.splitContainerBienEcheance.Panel2.Controls.Add(this.panelBienEcheanceFooter);
            this.splitContainerBienEcheance.Size = new System.Drawing.Size(800, 450);
            this.splitContainerBienEcheance.SplitterDistance = 67;
            this.splitContainerBienEcheance.TabIndex = 0;
            // 
            // labelTypeEcheance
            // 
            this.labelTypeEcheance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTypeEcheance.AutoSize = true;
            this.labelTypeEcheance.Location = new System.Drawing.Point(513, 21);
            this.labelTypeEcheance.Name = "labelTypeEcheance";
            this.labelTypeEcheance.Size = new System.Drawing.Size(182, 13);
            this.labelTypeEcheance.TabIndex = 23;
            this.labelTypeEcheance.Text = "Selectioner Le Type de l\'Echéance : ";
            // 
            // comboBoxTypeEcheance
            // 
            this.comboBoxTypeEcheance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTypeEcheance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeEcheance.FormattingEnabled = true;
            this.comboBoxTypeEcheance.Location = new System.Drawing.Point(514, 39);
            this.comboBoxTypeEcheance.Name = "comboBoxTypeEcheance";
            this.comboBoxTypeEcheance.Size = new System.Drawing.Size(251, 21);
            this.comboBoxTypeEcheance.TabIndex = 22;
            this.comboBoxTypeEcheance.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeEcheance_SelectedIndexChanged);
            // 
            // labelImmeuble
            // 
            this.labelImmeuble.AutoSize = true;
            this.labelImmeuble.Location = new System.Drawing.Point(209, 9);
            this.labelImmeuble.Name = "labelImmeuble";
            this.labelImmeuble.Size = new System.Drawing.Size(132, 13);
            this.labelImmeuble.TabIndex = 21;
            this.labelImmeuble.Text = "Selectioner un Immeuble : ";
            // 
            // comboBoxImmeuble
            // 
            this.comboBoxImmeuble.FormattingEnabled = true;
            this.comboBoxImmeuble.Location = new System.Drawing.Point(210, 27);
            this.comboBoxImmeuble.Name = "comboBoxImmeuble";
            this.comboBoxImmeuble.Size = new System.Drawing.Size(168, 21);
            this.comboBoxImmeuble.TabIndex = 20;
            // 
            // labelBloc
            // 
            this.labelBloc.AutoSize = true;
            this.labelBloc.Location = new System.Drawing.Point(16, 9);
            this.labelBloc.Name = "labelBloc";
            this.labelBloc.Size = new System.Drawing.Size(114, 13);
            this.labelBloc.TabIndex = 19;
            this.labelBloc.Text = "Selectioner une Bloc : ";
            // 
            // comboBoxBloc
            // 
            this.comboBoxBloc.FormattingEnabled = true;
            this.comboBoxBloc.Location = new System.Drawing.Point(17, 27);
            this.comboBoxBloc.Name = "comboBoxBloc";
            this.comboBoxBloc.Size = new System.Drawing.Size(168, 21);
            this.comboBoxBloc.TabIndex = 18;
            // 
            // splitContainerBienEcheanceBody
            // 
            this.splitContainerBienEcheanceBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBienEcheanceBody.IsSplitterFixed = true;
            this.splitContainerBienEcheanceBody.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBienEcheanceBody.Name = "splitContainerBienEcheanceBody";
            // 
            // splitContainerBienEcheanceBody.Panel1
            // 
            this.splitContainerBienEcheanceBody.Panel1.Controls.Add(this.comboBoxBienEcheance);
            this.splitContainerBienEcheanceBody.Panel1.Controls.Add(this.buttonLast);
            this.splitContainerBienEcheanceBody.Panel1.Controls.Add(this.buttonPrevious);
            this.splitContainerBienEcheanceBody.Panel1.Controls.Add(this.buttonNext);
            this.splitContainerBienEcheanceBody.Panel1.Controls.Add(this.buttonFirst);
            // 
            // splitContainerBienEcheanceBody.Panel2
            // 
            this.splitContainerBienEcheanceBody.Panel2.Controls.Add(this.dataGridViewBienEcheance);
            this.splitContainerBienEcheanceBody.Panel2.Controls.Add(this.dataGridViewListeBien);
            this.splitContainerBienEcheanceBody.Panel2.Controls.Add(this.panelMontantEcheance);
            this.splitContainerBienEcheanceBody.Size = new System.Drawing.Size(800, 310);
            this.splitContainerBienEcheanceBody.SplitterDistance = 79;
            this.splitContainerBienEcheanceBody.TabIndex = 1;
            // 
            // comboBoxBienEcheance
            // 
            this.comboBoxBienEcheance.FormattingEnabled = true;
            this.comboBoxBienEcheance.Location = new System.Drawing.Point(3, 283);
            this.comboBoxBienEcheance.Name = "comboBoxBienEcheance";
            this.comboBoxBienEcheance.Size = new System.Drawing.Size(10, 21);
            this.comboBoxBienEcheance.TabIndex = 15;
            this.comboBoxBienEcheance.Visible = false;
            this.comboBoxBienEcheance.SelectedIndexChanged += new System.EventHandler(this.comboBoxBienEcheance_SelectedIndexChanged);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(19, 238);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(39, 39);
            this.buttonLast.TabIndex = 17;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(16, 96);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(39, 39);
            this.buttonPrevious.TabIndex = 15;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(19, 167);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(39, 39);
            this.buttonNext.TabIndex = 16;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(16, 25);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(39, 39);
            this.buttonFirst.TabIndex = 14;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // dataGridViewBienEcheance
            // 
            this.dataGridViewBienEcheance.AllowUserToAddRows = false;
            this.dataGridViewBienEcheance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBienEcheance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBienEcheance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBienEcheance.Location = new System.Drawing.Point(151, 0);
            this.dataGridViewBienEcheance.MultiSelect = false;
            this.dataGridViewBienEcheance.Name = "dataGridViewBienEcheance";
            this.dataGridViewBienEcheance.Size = new System.Drawing.Size(566, 262);
            this.dataGridViewBienEcheance.TabIndex = 4;
            this.dataGridViewBienEcheance.SelectionChanged += new System.EventHandler(this.dataGridViewBienEcheance_SelectionChanged);
            // 
            // dataGridViewListeBien
            // 
            this.dataGridViewListeBien.AllowUserToAddRows = false;
            this.dataGridViewListeBien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListeBien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeBien.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewListeBien.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewListeBien.MultiSelect = false;
            this.dataGridViewListeBien.Name = "dataGridViewListeBien";
            this.dataGridViewListeBien.Size = new System.Drawing.Size(151, 262);
            this.dataGridViewListeBien.TabIndex = 3;
            // 
            // panelMontantEcheance
            // 
            this.panelMontantEcheance.Controls.Add(this.textBoxMontantReste);
            this.panelMontantEcheance.Controls.Add(this.labelMontantReste);
            this.panelMontantEcheance.Controls.Add(this.textBoxMontantRecu);
            this.panelMontantEcheance.Controls.Add(this.labelMontantRecu);
            this.panelMontantEcheance.Controls.Add(this.textBoxMontantTotal);
            this.panelMontantEcheance.Controls.Add(this.labelMontantTotal);
            this.panelMontantEcheance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMontantEcheance.Location = new System.Drawing.Point(0, 262);
            this.panelMontantEcheance.Name = "panelMontantEcheance";
            this.panelMontantEcheance.Size = new System.Drawing.Size(717, 48);
            this.panelMontantEcheance.TabIndex = 2;
            // 
            // textBoxMontantReste
            // 
            this.textBoxMontantReste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMontantReste.Enabled = false;
            this.textBoxMontantReste.Location = new System.Drawing.Point(591, 15);
            this.textBoxMontantReste.Name = "textBoxMontantReste";
            this.textBoxMontantReste.Size = new System.Drawing.Size(105, 20);
            this.textBoxMontantReste.TabIndex = 5;
            // 
            // labelMontantReste
            // 
            this.labelMontantReste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMontantReste.AutoSize = true;
            this.labelMontantReste.Location = new System.Drawing.Point(497, 18);
            this.labelMontantReste.Name = "labelMontantReste";
            this.labelMontantReste.Size = new System.Drawing.Size(86, 13);
            this.labelMontantReste.TabIndex = 4;
            this.labelMontantReste.Text = "Le Reste Total  :";
            // 
            // textBoxMontantRecu
            // 
            this.textBoxMontantRecu.Enabled = false;
            this.textBoxMontantRecu.Location = new System.Drawing.Point(344, 15);
            this.textBoxMontantRecu.Name = "textBoxMontantRecu";
            this.textBoxMontantRecu.Size = new System.Drawing.Size(105, 20);
            this.textBoxMontantRecu.TabIndex = 3;
            // 
            // labelMontantRecu
            // 
            this.labelMontantRecu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelMontantRecu.AutoSize = true;
            this.labelMontantRecu.Location = new System.Drawing.Point(233, 18);
            this.labelMontantRecu.Name = "labelMontantRecu";
            this.labelMontantRecu.Size = new System.Drawing.Size(111, 13);
            this.labelMontantRecu.TabIndex = 2;
            this.labelMontantRecu.Text = "Montant Reçu Total  :";
            // 
            // textBoxMontantTotal
            // 
            this.textBoxMontantTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxMontantTotal.Enabled = false;
            this.textBoxMontantTotal.Location = new System.Drawing.Point(93, 15);
            this.textBoxMontantTotal.Name = "textBoxMontantTotal";
            this.textBoxMontantTotal.Size = new System.Drawing.Size(105, 20);
            this.textBoxMontantTotal.TabIndex = 1;
            // 
            // labelMontantTotal
            // 
            this.labelMontantTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMontantTotal.AutoSize = true;
            this.labelMontantTotal.Location = new System.Drawing.Point(5, 18);
            this.labelMontantTotal.Name = "labelMontantTotal";
            this.labelMontantTotal.Size = new System.Drawing.Size(82, 13);
            this.labelMontantTotal.TabIndex = 0;
            this.labelMontantTotal.Text = "Montant Total  :";
            // 
            // panelBienEcheanceFooter
            // 
            this.panelBienEcheanceFooter.Controls.Add(this.buttonSupprimerEcheance);
            this.panelBienEcheanceFooter.Controls.Add(this.buttonModifierEcheance);
            this.panelBienEcheanceFooter.Controls.Add(this.buttonAjouterEcheance);
            this.panelBienEcheanceFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBienEcheanceFooter.Location = new System.Drawing.Point(0, 310);
            this.panelBienEcheanceFooter.Name = "panelBienEcheanceFooter";
            this.panelBienEcheanceFooter.Size = new System.Drawing.Size(800, 69);
            this.panelBienEcheanceFooter.TabIndex = 0;
            // 
            // buttonModifierEcheance
            // 
            this.buttonModifierEcheance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModifierEcheance.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonModifierEcheance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonModifierEcheance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModifierEcheance.FlatAppearance.BorderSize = 0;
            this.buttonModifierEcheance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonModifierEcheance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonModifierEcheance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifierEcheance.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonModifierEcheance.ForeColor = System.Drawing.Color.White;
            this.buttonModifierEcheance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModifierEcheance.Location = new System.Drawing.Point(373, 11);
            this.buttonModifierEcheance.Name = "buttonModifierEcheance";
            this.buttonModifierEcheance.Size = new System.Drawing.Size(187, 42);
            this.buttonModifierEcheance.TabIndex = 14;
            this.buttonModifierEcheance.Text = "Modifier Une Echéance";
            this.buttonModifierEcheance.UseVisualStyleBackColor = false;
            // 
            // buttonAjouterEcheance
            // 
            this.buttonAjouterEcheance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjouterEcheance.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAjouterEcheance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAjouterEcheance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjouterEcheance.FlatAppearance.BorderSize = 0;
            this.buttonAjouterEcheance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonAjouterEcheance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonAjouterEcheance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterEcheance.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonAjouterEcheance.ForeColor = System.Drawing.Color.White;
            this.buttonAjouterEcheance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouterEcheance.Location = new System.Drawing.Point(593, 11);
            this.buttonAjouterEcheance.Name = "buttonAjouterEcheance";
            this.buttonAjouterEcheance.Size = new System.Drawing.Size(187, 42);
            this.buttonAjouterEcheance.TabIndex = 13;
            this.buttonAjouterEcheance.Text = "Ajouter Une Echéance";
            this.buttonAjouterEcheance.UseVisualStyleBackColor = false;
            this.buttonAjouterEcheance.Click += new System.EventHandler(this.buttonAjouterEcheance_Click);
            // 
            // buttonSupprimerEcheance
            // 
            this.buttonSupprimerEcheance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSupprimerEcheance.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSupprimerEcheance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSupprimerEcheance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSupprimerEcheance.Enabled = false;
            this.buttonSupprimerEcheance.FlatAppearance.BorderSize = 0;
            this.buttonSupprimerEcheance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonSupprimerEcheance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonSupprimerEcheance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerEcheance.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonSupprimerEcheance.ForeColor = System.Drawing.Color.White;
            this.buttonSupprimerEcheance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupprimerEcheance.Location = new System.Drawing.Point(146, 11);
            this.buttonSupprimerEcheance.Name = "buttonSupprimerEcheance";
            this.buttonSupprimerEcheance.Size = new System.Drawing.Size(195, 42);
            this.buttonSupprimerEcheance.TabIndex = 15;
            this.buttonSupprimerEcheance.Text = "Supprimer Une Echéance";
            this.buttonSupprimerEcheance.UseVisualStyleBackColor = false;
            this.buttonSupprimerEcheance.Click += new System.EventHandler(this.buttonSupprimerEcheance_Click);
            // 
            // FormBienEcheance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainerBienEcheance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBienEcheance";
            this.Text = "FormBienEcheance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBienEcheance_FormClosing);
            this.Load += new System.EventHandler(this.FormBienEcheance_Load);
            this.splitContainerBienEcheance.Panel1.ResumeLayout(false);
            this.splitContainerBienEcheance.Panel1.PerformLayout();
            this.splitContainerBienEcheance.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBienEcheance)).EndInit();
            this.splitContainerBienEcheance.ResumeLayout(false);
            this.splitContainerBienEcheanceBody.Panel1.ResumeLayout(false);
            this.splitContainerBienEcheanceBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBienEcheanceBody)).EndInit();
            this.splitContainerBienEcheanceBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBienEcheance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeBien)).EndInit();
            this.panelMontantEcheance.ResumeLayout(false);
            this.panelMontantEcheance.PerformLayout();
            this.panelBienEcheanceFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerBienEcheance;
        private System.Windows.Forms.SplitContainer splitContainerBienEcheanceBody;
        private System.Windows.Forms.Panel panelBienEcheanceFooter;
        private System.Windows.Forms.Label labelTypeEcheance;
        private System.Windows.Forms.ComboBox comboBoxTypeEcheance;
        private System.Windows.Forms.Label labelImmeuble;
        private System.Windows.Forms.ComboBox comboBoxImmeuble;
        private System.Windows.Forms.Label labelBloc;
        private System.Windows.Forms.ComboBox comboBoxBloc;
        private System.Windows.Forms.Button buttonModifierEcheance;
        private System.Windows.Forms.Button buttonAjouterEcheance;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.DataGridView dataGridViewBienEcheance;
        private System.Windows.Forms.DataGridView dataGridViewListeBien;
        private System.Windows.Forms.Panel panelMontantEcheance;
        private System.Windows.Forms.TextBox textBoxMontantReste;
        private System.Windows.Forms.Label labelMontantReste;
        private System.Windows.Forms.TextBox textBoxMontantRecu;
        private System.Windows.Forms.Label labelMontantRecu;
        private System.Windows.Forms.TextBox textBoxMontantTotal;
        private System.Windows.Forms.Label labelMontantTotal;
        private System.Windows.Forms.ComboBox comboBoxBienEcheance;
        private System.Windows.Forms.Button buttonSupprimerEcheance;
    }
}