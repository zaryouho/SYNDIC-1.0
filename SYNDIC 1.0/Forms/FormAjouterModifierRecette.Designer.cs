﻿namespace SYNDIC_1._0.Forms
{
    partial class FormAjouterModifierRecette
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
            this.splitContainerRecetteInfo = new System.Windows.Forms.SplitContainer();
            this.labelHead = new System.Windows.Forms.Label();
            this.buttonAddNewTypeEcheance = new System.Windows.Forms.Button();
            this.panelIdEcheance = new System.Windows.Forms.Panel();
            this.dataGridViewListEcheance = new System.Windows.Forms.DataGridView();
            this.comboBoxTypeEcheance = new System.Windows.Forms.ComboBox();
            this.comboBoxNomBien = new System.Windows.Forms.ComboBox();
            this.labelInfoBien = new System.Windows.Forms.Label();
            this.labelTypeEcheance = new System.Windows.Forms.Label();
            this.labelNomBien = new System.Windows.Forms.Label();
            this.panelValider = new System.Windows.Forms.Panel();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.panelRecetteInfo = new System.Windows.Forms.Panel();
            this.comboBoxNomProprietaire = new System.Windows.Forms.ComboBox();
            this.comboBoxTypeRecette = new System.Windows.Forms.ComboBox();
            this.labelNomProprietaire = new System.Windows.Forms.Label();
            this.labelInfoRecette = new System.Windows.Forms.Label();
            this.textBoxNumRecu = new System.Windows.Forms.TextBox();
            this.textBoxMontant = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateRecette = new System.Windows.Forms.DateTimePicker();
            this.labelNumRecu = new System.Windows.Forms.Label();
            this.labelTypeRecette = new System.Windows.Forms.Label();
            this.labelMontant = new System.Windows.Forms.Label();
            this.labelDateRecette = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecetteInfo)).BeginInit();
            this.splitContainerRecetteInfo.Panel1.SuspendLayout();
            this.splitContainerRecetteInfo.Panel2.SuspendLayout();
            this.splitContainerRecetteInfo.SuspendLayout();
            this.panelIdEcheance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListEcheance)).BeginInit();
            this.panelValider.SuspendLayout();
            this.panelRecetteInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerRecetteInfo
            // 
            this.splitContainerRecetteInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRecetteInfo.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRecetteInfo.Name = "splitContainerRecetteInfo";
            this.splitContainerRecetteInfo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRecetteInfo.Panel1
            // 
            this.splitContainerRecetteInfo.Panel1.Controls.Add(this.labelHead);
            // 
            // splitContainerRecetteInfo.Panel2
            // 
            this.splitContainerRecetteInfo.Panel2.Controls.Add(this.buttonAddNewTypeEcheance);
            this.splitContainerRecetteInfo.Panel2.Controls.Add(this.panelIdEcheance);
            this.splitContainerRecetteInfo.Panel2.Controls.Add(this.comboBoxTypeEcheance);
            this.splitContainerRecetteInfo.Panel2.Controls.Add(this.comboBoxNomBien);
            this.splitContainerRecetteInfo.Panel2.Controls.Add(this.labelInfoBien);
            this.splitContainerRecetteInfo.Panel2.Controls.Add(this.labelTypeEcheance);
            this.splitContainerRecetteInfo.Panel2.Controls.Add(this.labelNomBien);
            this.splitContainerRecetteInfo.Panel2.Controls.Add(this.panelValider);
            this.splitContainerRecetteInfo.Panel2.Controls.Add(this.panelRecetteInfo);
            this.splitContainerRecetteInfo.Size = new System.Drawing.Size(800, 341);
            this.splitContainerRecetteInfo.SplitterDistance = 61;
            this.splitContainerRecetteInfo.TabIndex = 0;
            // 
            // labelHead
            // 
            this.labelHead.AutoSize = true;
            this.labelHead.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHead.Location = new System.Drawing.Point(323, 9);
            this.labelHead.Name = "labelHead";
            this.labelHead.Size = new System.Drawing.Size(108, 30);
            this.labelHead.TabIndex = 5;
            this.labelHead.Text = "Recette";
            // 
            // buttonAddNewTypeEcheance
            // 
            this.buttonAddNewTypeEcheance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewTypeEcheance.Location = new System.Drawing.Point(715, 96);
            this.buttonAddNewTypeEcheance.Name = "buttonAddNewTypeEcheance";
            this.buttonAddNewTypeEcheance.Size = new System.Drawing.Size(32, 25);
            this.buttonAddNewTypeEcheance.TabIndex = 23;
            this.buttonAddNewTypeEcheance.Text = "...";
            this.buttonAddNewTypeEcheance.UseVisualStyleBackColor = true;
            this.buttonAddNewTypeEcheance.Click += new System.EventHandler(this.buttonAddNewTypeEcheance_Click);
            // 
            // panelIdEcheance
            // 
            this.panelIdEcheance.Controls.Add(this.dataGridViewListEcheance);
            this.panelIdEcheance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIdEcheance.Location = new System.Drawing.Point(378, 146);
            this.panelIdEcheance.Name = "panelIdEcheance";
            this.panelIdEcheance.Size = new System.Drawing.Size(422, 76);
            this.panelIdEcheance.TabIndex = 22;
            // 
            // dataGridViewListEcheance
            // 
            this.dataGridViewListEcheance.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridViewListEcheance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewListEcheance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListEcheance.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListEcheance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewListEcheance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListEcheance.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewListEcheance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListEcheance.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewListEcheance.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewListEcheance.Name = "dataGridViewListEcheance";
            this.dataGridViewListEcheance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListEcheance.Size = new System.Drawing.Size(422, 76);
            this.dataGridViewListEcheance.TabIndex = 0;
            // 
            // comboBoxTypeEcheance
            // 
            this.comboBoxTypeEcheance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeEcheance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTypeEcheance.FormattingEnabled = true;
            this.comboBoxTypeEcheance.Location = new System.Drawing.Point(533, 96);
            this.comboBoxTypeEcheance.Name = "comboBoxTypeEcheance";
            this.comboBoxTypeEcheance.Size = new System.Drawing.Size(176, 25);
            this.comboBoxTypeEcheance.TabIndex = 21;
            this.comboBoxTypeEcheance.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeEcheance_SelectedIndexChanged);
            // 
            // comboBoxNomBien
            // 
            this.comboBoxNomBien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNomBien.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNomBien.FormattingEnabled = true;
            this.comboBoxNomBien.Location = new System.Drawing.Point(533, 61);
            this.comboBoxNomBien.Name = "comboBoxNomBien";
            this.comboBoxNomBien.Size = new System.Drawing.Size(214, 25);
            this.comboBoxNomBien.TabIndex = 20;
            this.comboBoxNomBien.SelectedIndexChanged += new System.EventHandler(this.comboBoxNomBien_SelectedIndexChanged);
            // 
            // labelInfoBien
            // 
            this.labelInfoBien.AutoSize = true;
            this.labelInfoBien.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoBien.Location = new System.Drawing.Point(545, 17);
            this.labelInfoBien.Name = "labelInfoBien";
            this.labelInfoBien.Size = new System.Drawing.Size(134, 17);
            this.labelInfoBien.TabIndex = 19;
            this.labelInfoBien.Text = "Information de Bien";
            // 
            // labelTypeEcheance
            // 
            this.labelTypeEcheance.AutoSize = true;
            this.labelTypeEcheance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeEcheance.Location = new System.Drawing.Point(402, 99);
            this.labelTypeEcheance.Name = "labelTypeEcheance";
            this.labelTypeEcheance.Size = new System.Drawing.Size(116, 17);
            this.labelTypeEcheance.TabIndex = 18;
            this.labelTypeEcheance.Text = "Type d\'échéance :";
            // 
            // labelNomBien
            // 
            this.labelNomBien.AutoSize = true;
            this.labelNomBien.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomBien.Location = new System.Drawing.Point(427, 64);
            this.labelNomBien.Name = "labelNomBien";
            this.labelNomBien.Size = new System.Drawing.Size(89, 17);
            this.labelNomBien.TabIndex = 17;
            this.labelNomBien.Text = "Nom de Bien :";
            // 
            // panelValider
            // 
            this.panelValider.Controls.Add(this.buttonAnnuler);
            this.panelValider.Controls.Add(this.buttonValider);
            this.panelValider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelValider.Location = new System.Drawing.Point(378, 222);
            this.panelValider.Name = "panelValider";
            this.panelValider.Size = new System.Drawing.Size(422, 54);
            this.panelValider.TabIndex = 16;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnnuler.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnnuler.FlatAppearance.BorderSize = 0;
            this.buttonAnnuler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.ForeColor = System.Drawing.Color.White;
            this.buttonAnnuler.Image = global::SYNDIC_1._0.Properties.Resources.DeleteReddd;
            this.buttonAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnnuler.Location = new System.Drawing.Point(229, 8);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(165, 34);
            this.buttonAnnuler.TabIndex = 13;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonValider.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonValider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonValider.Enabled = false;
            this.buttonValider.FlatAppearance.BorderSize = 0;
            this.buttonValider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonValider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonValider.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValider.ForeColor = System.Drawing.Color.White;
            this.buttonValider.Image = global::SYNDIC_1._0.Properties.Resources.valider;
            this.buttonValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonValider.Location = new System.Drawing.Point(24, 8);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(165, 34);
            this.buttonValider.TabIndex = 12;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = false;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // panelRecetteInfo
            // 
            this.panelRecetteInfo.Controls.Add(this.comboBoxNomProprietaire);
            this.panelRecetteInfo.Controls.Add(this.comboBoxTypeRecette);
            this.panelRecetteInfo.Controls.Add(this.labelNomProprietaire);
            this.panelRecetteInfo.Controls.Add(this.labelInfoRecette);
            this.panelRecetteInfo.Controls.Add(this.textBoxNumRecu);
            this.panelRecetteInfo.Controls.Add(this.textBoxMontant);
            this.panelRecetteInfo.Controls.Add(this.dateTimePickerDateRecette);
            this.panelRecetteInfo.Controls.Add(this.labelNumRecu);
            this.panelRecetteInfo.Controls.Add(this.labelTypeRecette);
            this.panelRecetteInfo.Controls.Add(this.labelMontant);
            this.panelRecetteInfo.Controls.Add(this.labelDateRecette);
            this.panelRecetteInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRecetteInfo.Location = new System.Drawing.Point(0, 0);
            this.panelRecetteInfo.Name = "panelRecetteInfo";
            this.panelRecetteInfo.Size = new System.Drawing.Size(378, 276);
            this.panelRecetteInfo.TabIndex = 1;
            // 
            // comboBoxNomProprietaire
            // 
            this.comboBoxNomProprietaire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNomProprietaire.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNomProprietaire.FormattingEnabled = true;
            this.comboBoxNomProprietaire.Location = new System.Drawing.Point(165, 44);
            this.comboBoxNomProprietaire.Name = "comboBoxNomProprietaire";
            this.comboBoxNomProprietaire.Size = new System.Drawing.Size(200, 25);
            this.comboBoxNomProprietaire.TabIndex = 15;
            // 
            // comboBoxTypeRecette
            // 
            this.comboBoxTypeRecette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeRecette.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTypeRecette.FormattingEnabled = true;
            this.comboBoxTypeRecette.Location = new System.Drawing.Point(165, 143);
            this.comboBoxTypeRecette.Name = "comboBoxTypeRecette";
            this.comboBoxTypeRecette.Size = new System.Drawing.Size(200, 25);
            this.comboBoxTypeRecette.TabIndex = 14;
            // 
            // labelNomProprietaire
            // 
            this.labelNomProprietaire.AutoSize = true;
            this.labelNomProprietaire.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomProprietaire.Location = new System.Drawing.Point(12, 47);
            this.labelNomProprietaire.Name = "labelNomProprietaire";
            this.labelNomProprietaire.Size = new System.Drawing.Size(134, 17);
            this.labelNomProprietaire.TabIndex = 12;
            this.labelNomProprietaire.Text = "Nom de Propriétaire :";
            // 
            // labelInfoRecette
            // 
            this.labelInfoRecette.AutoSize = true;
            this.labelInfoRecette.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoRecette.Location = new System.Drawing.Point(115, 17);
            this.labelInfoRecette.Name = "labelInfoRecette";
            this.labelInfoRecette.Size = new System.Drawing.Size(158, 17);
            this.labelInfoRecette.TabIndex = 11;
            this.labelInfoRecette.Text = "Information de Recette";
            // 
            // textBoxNumRecu
            // 
            this.textBoxNumRecu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumRecu.Location = new System.Drawing.Point(165, 176);
            this.textBoxNumRecu.Name = "textBoxNumRecu";
            this.textBoxNumRecu.Size = new System.Drawing.Size(200, 22);
            this.textBoxNumRecu.TabIndex = 7;
            this.textBoxNumRecu.TextChanged += new System.EventHandler(this.textBoxNumRecu_TextChanged);
            this.textBoxNumRecu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumRecu_KeyPress);
            // 
            // textBoxMontant
            // 
            this.textBoxMontant.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMontant.Location = new System.Drawing.Point(165, 110);
            this.textBoxMontant.Name = "textBoxMontant";
            this.textBoxMontant.Size = new System.Drawing.Size(200, 22);
            this.textBoxMontant.TabIndex = 5;
            this.textBoxMontant.TextChanged += new System.EventHandler(this.textBoxNumRecu_TextChanged);
            this.textBoxMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMontant_KeyPress);
            // 
            // dateTimePickerDateRecette
            // 
            this.dateTimePickerDateRecette.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateRecette.Location = new System.Drawing.Point(165, 77);
            this.dateTimePickerDateRecette.Name = "dateTimePickerDateRecette";
            this.dateTimePickerDateRecette.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDateRecette.TabIndex = 4;
            // 
            // labelNumRecu
            // 
            this.labelNumRecu.AutoSize = true;
            this.labelNumRecu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumRecu.Location = new System.Drawing.Point(85, 179);
            this.labelNumRecu.Name = "labelNumRecu";
            this.labelNumRecu.Size = new System.Drawing.Size(61, 17);
            this.labelNumRecu.TabIndex = 3;
            this.labelNumRecu.Text = "N° Reçu :";
            // 
            // labelTypeRecette
            // 
            this.labelTypeRecette.AutoSize = true;
            this.labelTypeRecette.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeRecette.Location = new System.Drawing.Point(34, 146);
            this.labelTypeRecette.Name = "labelTypeRecette";
            this.labelTypeRecette.Size = new System.Drawing.Size(112, 17);
            this.labelTypeRecette.TabIndex = 2;
            this.labelTypeRecette.Text = "Type de Recette :";
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontant.Location = new System.Drawing.Point(81, 113);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(65, 17);
            this.labelMontant.TabIndex = 1;
            this.labelMontant.Text = "Montant :";
            // 
            // labelDateRecette
            // 
            this.labelDateRecette.AutoSize = true;
            this.labelDateRecette.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateRecette.Location = new System.Drawing.Point(31, 80);
            this.labelDateRecette.Name = "labelDateRecette";
            this.labelDateRecette.Size = new System.Drawing.Size(115, 17);
            this.labelDateRecette.TabIndex = 0;
            this.labelDateRecette.Text = "Date de Recette :";
            // 
            // FormAjouterModifierRecette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 341);
            this.Controls.Add(this.splitContainerRecetteInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAjouterModifierRecette";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAjouterModifierRecette";
            this.Load += new System.EventHandler(this.FormAjouterModifierRecette_Load);
            this.TextChanged += new System.EventHandler(this.textBoxNumRecu_TextChanged);
            this.splitContainerRecetteInfo.Panel1.ResumeLayout(false);
            this.splitContainerRecetteInfo.Panel1.PerformLayout();
            this.splitContainerRecetteInfo.Panel2.ResumeLayout(false);
            this.splitContainerRecetteInfo.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecetteInfo)).EndInit();
            this.splitContainerRecetteInfo.ResumeLayout(false);
            this.panelIdEcheance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListEcheance)).EndInit();
            this.panelValider.ResumeLayout(false);
            this.panelRecetteInfo.ResumeLayout(false);
            this.panelRecetteInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerRecetteInfo;
        private System.Windows.Forms.Label labelHead;
        private System.Windows.Forms.ComboBox comboBoxTypeEcheance;
        private System.Windows.Forms.ComboBox comboBoxNomBien;
        private System.Windows.Forms.Label labelInfoBien;
        private System.Windows.Forms.Label labelTypeEcheance;
        private System.Windows.Forms.Label labelNomBien;
        private System.Windows.Forms.Panel panelValider;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Panel panelRecetteInfo;
        private System.Windows.Forms.ComboBox comboBoxNomProprietaire;
        private System.Windows.Forms.ComboBox comboBoxTypeRecette;
        private System.Windows.Forms.Label labelNomProprietaire;
        private System.Windows.Forms.Label labelInfoRecette;
        private System.Windows.Forms.TextBox textBoxNumRecu;
        private System.Windows.Forms.TextBox textBoxMontant;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateRecette;
        private System.Windows.Forms.Label labelNumRecu;
        private System.Windows.Forms.Label labelTypeRecette;
        private System.Windows.Forms.Label labelMontant;
        private System.Windows.Forms.Label labelDateRecette;
        private System.Windows.Forms.Panel panelIdEcheance;
        private System.Windows.Forms.DataGridView dataGridViewListEcheance;
        private System.Windows.Forms.Button buttonAddNewTypeEcheance;
    }
}