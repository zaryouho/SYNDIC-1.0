﻿namespace SYNDIC_1._0.Forms
{
    partial class FormEmploye
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
            this.tableLayoutPEmploye = new System.Windows.Forms.TableLayoutPanel();
            this.labelEmploye = new System.Windows.Forms.Label();
            this.labelCloseEmploye = new System.Windows.Forms.Label();
            this.tableLayoutPanelEmploye = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEmploye = new System.Windows.Forms.Button();
            this.buttonEmployeArchive = new System.Windows.Forms.Button();
            this.tableLayoutPanelEmployeBottom = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAjouterSEmploye = new System.Windows.Forms.Button();
            this.buttonSupprimerEmploye = new System.Windows.Forms.Button();
            this.buttonModifierEmploye = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonListDoc = new System.Windows.Forms.Button();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.textBoxRechercher = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonprevious = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.dataGridViewEmploye = new System.Windows.Forms.DataGridView();
            this.tableLayoutPEmploye.SuspendLayout();
            this.tableLayoutPanelEmploye.SuspendLayout();
            this.tableLayoutPanelEmployeBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmploye)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPEmploye
            // 
            this.tableLayoutPEmploye.ColumnCount = 3;
            this.tableLayoutPEmploye.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPEmploye.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPEmploye.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPEmploye.Controls.Add(this.labelEmploye, 1, 0);
            this.tableLayoutPEmploye.Controls.Add(this.labelCloseEmploye, 2, 0);
            this.tableLayoutPEmploye.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPEmploye.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPEmploye.Name = "tableLayoutPEmploye";
            this.tableLayoutPEmploye.RowCount = 1;
            this.tableLayoutPEmploye.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPEmploye.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPEmploye.Size = new System.Drawing.Size(800, 49);
            this.tableLayoutPEmploye.TabIndex = 4;
            // 
            // labelEmploye
            // 
            this.labelEmploye.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmploye.AutoSize = true;
            this.labelEmploye.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmploye.Location = new System.Drawing.Point(269, 0);
            this.labelEmploye.Name = "labelEmploye";
            this.labelEmploye.Size = new System.Drawing.Size(260, 49);
            this.labelEmploye.TabIndex = 1;
            this.labelEmploye.Text = "Les Employe";
            this.labelEmploye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCloseEmploye
            // 
            this.labelCloseEmploye.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCloseEmploye.AutoSize = true;
            this.labelCloseEmploye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCloseEmploye.Location = new System.Drawing.Point(779, 0);
            this.labelCloseEmploye.Name = "labelCloseEmploye";
            this.labelCloseEmploye.Size = new System.Drawing.Size(18, 18);
            this.labelCloseEmploye.TabIndex = 2;
            this.labelCloseEmploye.Text = "X";
            // 
            // tableLayoutPanelEmploye
            // 
            this.tableLayoutPanelEmploye.ColumnCount = 3;
            this.tableLayoutPanelEmploye.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelEmploye.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelEmploye.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelEmploye.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelEmploye.Controls.Add(this.buttonEmploye, 0, 0);
            this.tableLayoutPanelEmploye.Controls.Add(this.buttonEmployeArchive, 2, 0);
            this.tableLayoutPanelEmploye.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelEmploye.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanelEmploye.Name = "tableLayoutPanelEmploye";
            this.tableLayoutPanelEmploye.RowCount = 1;
            this.tableLayoutPanelEmploye.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelEmploye.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanelEmploye.Size = new System.Drawing.Size(800, 43);
            this.tableLayoutPanelEmploye.TabIndex = 0;
            // 
            // buttonEmploye
            // 
            this.buttonEmploye.BackColor = System.Drawing.Color.Blue;
            this.buttonEmploye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEmploye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEmploye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEmploye.FlatAppearance.BorderSize = 0;
            this.buttonEmploye.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonEmploye.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmploye.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmploye.ForeColor = System.Drawing.Color.White;
            this.buttonEmploye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmploye.Location = new System.Drawing.Point(3, 3);
            this.buttonEmploye.Name = "buttonEmploye";
            this.buttonEmploye.Size = new System.Drawing.Size(260, 37);
            this.buttonEmploye.TabIndex = 0;
            this.buttonEmploye.Text = "Employé";
            this.buttonEmploye.UseVisualStyleBackColor = false;
            this.buttonEmploye.Click += new System.EventHandler(this.buttonEmploye_Click);
            // 
            // buttonEmployeArchive
            // 
            this.buttonEmployeArchive.BackColor = System.Drawing.Color.Blue;
            this.buttonEmployeArchive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEmployeArchive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEmployeArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEmployeArchive.FlatAppearance.BorderSize = 0;
            this.buttonEmployeArchive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonEmployeArchive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonEmployeArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployeArchive.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployeArchive.ForeColor = System.Drawing.Color.White;
            this.buttonEmployeArchive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployeArchive.Location = new System.Drawing.Point(535, 3);
            this.buttonEmployeArchive.Name = "buttonEmployeArchive";
            this.buttonEmployeArchive.Size = new System.Drawing.Size(262, 37);
            this.buttonEmployeArchive.TabIndex = 2;
            this.buttonEmployeArchive.Text = "Employé  arch.";
            this.buttonEmployeArchive.UseVisualStyleBackColor = false;
            this.buttonEmployeArchive.Click += new System.EventHandler(this.buttonEmployeArchive_Click);
            // 
            // tableLayoutPanelEmployeBottom
            // 
            this.tableLayoutPanelEmployeBottom.ColumnCount = 3;
            this.tableLayoutPanelEmployeBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelEmployeBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelEmployeBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelEmployeBottom.Controls.Add(this.buttonAjouterSEmploye, 0, 0);
            this.tableLayoutPanelEmployeBottom.Controls.Add(this.buttonSupprimerEmploye, 2, 0);
            this.tableLayoutPanelEmployeBottom.Controls.Add(this.buttonModifierEmploye, 1, 0);
            this.tableLayoutPanelEmployeBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelEmployeBottom.Location = new System.Drawing.Point(0, 395);
            this.tableLayoutPanelEmployeBottom.Name = "tableLayoutPanelEmployeBottom";
            this.tableLayoutPanelEmployeBottom.RowCount = 1;
            this.tableLayoutPanelEmployeBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelEmployeBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanelEmployeBottom.Size = new System.Drawing.Size(800, 55);
            this.tableLayoutPanelEmployeBottom.TabIndex = 3;
            // 
            // buttonAjouterSEmploye
            // 
            this.buttonAjouterSEmploye.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjouterSEmploye.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAjouterSEmploye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAjouterSEmploye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjouterSEmploye.FlatAppearance.BorderSize = 0;
            this.buttonAjouterSEmploye.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonAjouterSEmploye.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonAjouterSEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterSEmploye.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterSEmploye.ForeColor = System.Drawing.Color.White;
            this.buttonAjouterSEmploye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouterSEmploye.Location = new System.Drawing.Point(3, 3);
            this.buttonAjouterSEmploye.Name = "buttonAjouterSEmploye";
            this.buttonAjouterSEmploye.Size = new System.Drawing.Size(260, 49);
            this.buttonAjouterSEmploye.TabIndex = 1;
            this.buttonAjouterSEmploye.Text = "Ajouter un employé";
            this.buttonAjouterSEmploye.UseVisualStyleBackColor = false;
            this.buttonAjouterSEmploye.Click += new System.EventHandler(this.buttonAjouterEmploye_Click);
            // 
            // buttonSupprimerEmploye
            // 
            this.buttonSupprimerEmploye.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSupprimerEmploye.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSupprimerEmploye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSupprimerEmploye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSupprimerEmploye.FlatAppearance.BorderSize = 0;
            this.buttonSupprimerEmploye.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonSupprimerEmploye.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonSupprimerEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerEmploye.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimerEmploye.ForeColor = System.Drawing.Color.White;
            this.buttonSupprimerEmploye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupprimerEmploye.Location = new System.Drawing.Point(535, 3);
            this.buttonSupprimerEmploye.Name = "buttonSupprimerEmploye";
            this.buttonSupprimerEmploye.Size = new System.Drawing.Size(262, 49);
            this.buttonSupprimerEmploye.TabIndex = 2;
            this.buttonSupprimerEmploye.Text = "Supprimer l\'employé";
            this.buttonSupprimerEmploye.UseVisualStyleBackColor = false;
            this.buttonSupprimerEmploye.Click += new System.EventHandler(this.buttonSupprimerEmploye_Click);
            // 
            // buttonModifierEmploye
            // 
            this.buttonModifierEmploye.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModifierEmploye.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonModifierEmploye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonModifierEmploye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModifierEmploye.FlatAppearance.BorderSize = 0;
            this.buttonModifierEmploye.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonModifierEmploye.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonModifierEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifierEmploye.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifierEmploye.ForeColor = System.Drawing.Color.White;
            this.buttonModifierEmploye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModifierEmploye.Location = new System.Drawing.Point(269, 3);
            this.buttonModifierEmploye.Name = "buttonModifierEmploye";
            this.buttonModifierEmploye.Size = new System.Drawing.Size(260, 49);
            this.buttonModifierEmploye.TabIndex = 0;
            this.buttonModifierEmploye.Text = "Modifier l\'employé";
            this.buttonModifierEmploye.UseVisualStyleBackColor = false;
            this.buttonModifierEmploye.Click += new System.EventHandler(this.buttonModifierEmploye_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 92);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonListDoc);
            this.splitContainer1.Panel1.Controls.Add(this.buttonRechercher);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxRechercher);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 303);
            this.splitContainer1.SplitterDistance = 49;
            this.splitContainer1.TabIndex = 28;
            // 
            // buttonListDoc
            // 
            this.buttonListDoc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonListDoc.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonListDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonListDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonListDoc.FlatAppearance.BorderSize = 0;
            this.buttonListDoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonListDoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonListDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListDoc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListDoc.ForeColor = System.Drawing.Color.White;
            this.buttonListDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListDoc.Location = new System.Drawing.Point(592, 7);
            this.buttonListDoc.Name = "buttonListDoc";
            this.buttonListDoc.Size = new System.Drawing.Size(195, 35);
            this.buttonListDoc.TabIndex = 3;
            this.buttonListDoc.Text = "Liste Documents";
            this.buttonListDoc.UseVisualStyleBackColor = false;
            this.buttonListDoc.Click += new System.EventHandler(this.buttonListDocs_Click);
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRechercher.Location = new System.Drawing.Point(244, 12);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(98, 29);
            this.buttonRechercher.TabIndex = 2;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // textBoxRechercher
            // 
            this.textBoxRechercher.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRechercher.Location = new System.Drawing.Point(27, 16);
            this.textBoxRechercher.Name = "textBoxRechercher";
            this.textBoxRechercher.Size = new System.Drawing.Size(202, 22);
            this.textBoxRechercher.TabIndex = 1;
            this.textBoxRechercher.TextChanged += new System.EventHandler(this.textBoxRechercher_TextChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonLast);
            this.splitContainer2.Panel1.Controls.Add(this.buttonNext);
            this.splitContainer2.Panel1.Controls.Add(this.buttonprevious);
            this.splitContainer2.Panel1.Controls.Add(this.buttonFirst);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridViewEmploye);
            this.splitContainer2.Size = new System.Drawing.Size(800, 250);
            this.splitContainer2.SplitterDistance = 54;
            this.splitContainer2.TabIndex = 2;
            // 
            // buttonLast
            // 
            this.buttonLast.FlatAppearance.BorderSize = 0;
            this.buttonLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast.Image = global::SYNDIC_1._0.Properties.Resources.down_chevron_2;
            this.buttonLast.Location = new System.Drawing.Point(8, 192);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(39, 39);
            this.buttonLast.TabIndex = 2;
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Image = global::SYNDIC_1._0.Properties.Resources.down_chevron_1;
            this.buttonNext.Location = new System.Drawing.Point(8, 137);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(39, 39);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonprevious
            // 
            this.buttonprevious.FlatAppearance.BorderSize = 0;
            this.buttonprevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonprevious.Image = global::SYNDIC_1._0.Properties.Resources.up_chevron_1111;
            this.buttonprevious.Location = new System.Drawing.Point(8, 82);
            this.buttonprevious.Name = "buttonprevious";
            this.buttonprevious.Size = new System.Drawing.Size(39, 39);
            this.buttonprevious.TabIndex = 1;
            this.buttonprevious.UseVisualStyleBackColor = true;
            this.buttonprevious.Click += new System.EventHandler(this.buttonprevious_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.FlatAppearance.BorderSize = 0;
            this.buttonFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFirst.Image = global::SYNDIC_1._0.Properties.Resources.up_chevron_2222;
            this.buttonFirst.Location = new System.Drawing.Point(8, 27);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(39, 39);
            this.buttonFirst.TabIndex = 3;
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // dataGridViewEmploye
            // 
            this.dataGridViewEmploye.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridViewEmploye.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEmploye.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmploye.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEmploye.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmploye.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEmploye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmploye.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewEmploye.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEmploye.Name = "dataGridViewEmploye";
            this.dataGridViewEmploye.RowHeadersWidth = 25;
            this.dataGridViewEmploye.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmploye.Size = new System.Drawing.Size(742, 250);
            this.dataGridViewEmploye.TabIndex = 4;
            // 
            // FormEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tableLayoutPanelEmployeBottom);
            this.Controls.Add(this.tableLayoutPanelEmploye);
            this.Controls.Add(this.tableLayoutPEmploye);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmploye";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormEmploye_Load);
            this.tableLayoutPEmploye.ResumeLayout(false);
            this.tableLayoutPEmploye.PerformLayout();
            this.tableLayoutPanelEmploye.ResumeLayout(false);
            this.tableLayoutPanelEmployeBottom.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmploye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPEmploye;
        private System.Windows.Forms.Label labelEmploye;
        private System.Windows.Forms.Label labelCloseEmploye;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEmploye;
        private System.Windows.Forms.Button buttonEmploye;
        private System.Windows.Forms.Button buttonEmployeArchive;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEmployeBottom;
        private System.Windows.Forms.Button buttonAjouterSEmploye;
        private System.Windows.Forms.Button buttonSupprimerEmploye;
        private System.Windows.Forms.Button buttonModifierEmploye;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button buttonListDoc;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.TextBox textBoxRechercher;
        private System.Windows.Forms.DataGridView dataGridViewEmploye;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonprevious;
        private System.Windows.Forms.Button buttonFirst;
    }
}