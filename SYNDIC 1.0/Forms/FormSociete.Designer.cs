namespace SYNDIC_1._0.Forms
{
    partial class FormSociete
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPSociete = new System.Windows.Forms.TableLayoutPanel();
            this.labelEmploye = new System.Windows.Forms.Label();
            this.labelCloseEmploye = new System.Windows.Forms.Label();
            this.tableLayoutPanelEmploye = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSociete = new System.Windows.Forms.Button();
            this.buttonSocieteArchive = new System.Windows.Forms.Button();
            this.buttonAjouterSociete = new System.Windows.Forms.Button();
            this.panelIN = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.textBoxRechercher = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonprevious = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.dataGridViewSociete = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelEmployeBottom = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAjouterSSociete = new System.Windows.Forms.Button();
            this.buttonSupprimerSociete = new System.Windows.Forms.Button();
            this.buttonModifierSociete = new System.Windows.Forms.Button();
            this.tableLayoutPSociete.SuspendLayout();
            this.tableLayoutPanelEmploye.SuspendLayout();
            this.panelIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSociete)).BeginInit();
            this.tableLayoutPanelEmployeBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPSociete
            // 
            this.tableLayoutPSociete.ColumnCount = 3;
            this.tableLayoutPSociete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPSociete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPSociete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPSociete.Controls.Add(this.labelEmploye, 1, 0);
            this.tableLayoutPSociete.Controls.Add(this.labelCloseEmploye, 2, 0);
            this.tableLayoutPSociete.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPSociete.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPSociete.Name = "tableLayoutPSociete";
            this.tableLayoutPSociete.RowCount = 1;
            this.tableLayoutPSociete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPSociete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPSociete.Size = new System.Drawing.Size(800, 49);
            this.tableLayoutPSociete.TabIndex = 4;
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
            this.labelEmploye.Text = "Les Societe";
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
            this.tableLayoutPanelEmploye.Controls.Add(this.buttonSociete, 0, 0);
            this.tableLayoutPanelEmploye.Controls.Add(this.buttonSocieteArchive, 2, 0);
            this.tableLayoutPanelEmploye.Controls.Add(this.buttonAjouterSociete, 1, 0);
            this.tableLayoutPanelEmploye.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelEmploye.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanelEmploye.Name = "tableLayoutPanelEmploye";
            this.tableLayoutPanelEmploye.RowCount = 1;
            this.tableLayoutPanelEmploye.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelEmploye.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanelEmploye.Size = new System.Drawing.Size(800, 43);
            this.tableLayoutPanelEmploye.TabIndex = 0;
            // 
            // buttonSociete
            // 
            this.buttonSociete.BackColor = System.Drawing.Color.Blue;
            this.buttonSociete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSociete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSociete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSociete.FlatAppearance.BorderSize = 0;
            this.buttonSociete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonSociete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonSociete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSociete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSociete.ForeColor = System.Drawing.Color.White;
            this.buttonSociete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSociete.Location = new System.Drawing.Point(3, 3);
            this.buttonSociete.Name = "buttonSociete";
            this.buttonSociete.Size = new System.Drawing.Size(260, 37);
            this.buttonSociete.TabIndex = 0;
            this.buttonSociete.Text = "Societe";
            this.buttonSociete.UseVisualStyleBackColor = false;
            this.buttonSociete.Click += new System.EventHandler(this.buttonSociete_Click);
            // 
            // buttonSocieteArchive
            // 
            this.buttonSocieteArchive.BackColor = System.Drawing.Color.Blue;
            this.buttonSocieteArchive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSocieteArchive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSocieteArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSocieteArchive.FlatAppearance.BorderSize = 0;
            this.buttonSocieteArchive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonSocieteArchive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonSocieteArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSocieteArchive.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSocieteArchive.ForeColor = System.Drawing.Color.White;
            this.buttonSocieteArchive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSocieteArchive.Location = new System.Drawing.Point(535, 3);
            this.buttonSocieteArchive.Name = "buttonSocieteArchive";
            this.buttonSocieteArchive.Size = new System.Drawing.Size(262, 37);
            this.buttonSocieteArchive.TabIndex = 2;
            this.buttonSocieteArchive.Text = "Societe  arch.";
            this.buttonSocieteArchive.UseVisualStyleBackColor = false;
            this.buttonSocieteArchive.Click += new System.EventHandler(this.buttonSocieteArchive_Click);
            // 
            // buttonAjouterSociete
            // 
            this.buttonAjouterSociete.BackColor = System.Drawing.Color.Blue;
            this.buttonAjouterSociete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAjouterSociete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjouterSociete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAjouterSociete.FlatAppearance.BorderSize = 0;
            this.buttonAjouterSociete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonAjouterSociete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonAjouterSociete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterSociete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterSociete.ForeColor = System.Drawing.Color.White;
            this.buttonAjouterSociete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouterSociete.Location = new System.Drawing.Point(269, 3);
            this.buttonAjouterSociete.Name = "buttonAjouterSociete";
            this.buttonAjouterSociete.Size = new System.Drawing.Size(260, 37);
            this.buttonAjouterSociete.TabIndex = 1;
            this.buttonAjouterSociete.Text = "Ajouter Societe";
            this.buttonAjouterSociete.UseVisualStyleBackColor = false;
            this.buttonAjouterSociete.Click += new System.EventHandler(this.buttonAjouterSociete_Click);
            // 
            // panelIN
            // 
            this.panelIN.Controls.Add(this.splitContainer1);
            this.panelIN.Controls.Add(this.tableLayoutPanelEmployeBottom);
            this.panelIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIN.Location = new System.Drawing.Point(0, 92);
            this.panelIN.Name = "panelIN";
            this.panelIN.Size = new System.Drawing.Size(800, 358);
            this.panelIN.TabIndex = 30;
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
            this.splitContainer1.Panel1.Controls.Add(this.buttonRechercher);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxRechercher);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 303);
            this.splitContainer1.SplitterDistance = 41;
            this.splitContainer1.TabIndex = 1;
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.buttonRechercher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.buttonRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRechercher.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRechercher.Location = new System.Drawing.Point(238, 6);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(98, 25);
            this.buttonRechercher.TabIndex = 1;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // textBoxRechercher
            // 
            this.textBoxRechercher.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRechercher.Location = new System.Drawing.Point(30, 7);
            this.textBoxRechercher.Name = "textBoxRechercher";
            this.textBoxRechercher.Size = new System.Drawing.Size(202, 22);
            this.textBoxRechercher.TabIndex = 0;
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
            this.splitContainer2.Panel2.Controls.Add(this.dataGridViewSociete);
            this.splitContainer2.Size = new System.Drawing.Size(800, 258);
            this.splitContainer2.SplitterDistance = 58;
            this.splitContainer2.TabIndex = 2;
            // 
            // buttonLast
            // 
            this.buttonLast.FlatAppearance.BorderSize = 0;
            this.buttonLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLast.Image = global::SYNDIC_1._0.Properties.Resources.down_chevron_2;
            this.buttonLast.Location = new System.Drawing.Point(10, 188);
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
            this.buttonNext.Location = new System.Drawing.Point(10, 133);
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
            this.buttonprevious.Location = new System.Drawing.Point(10, 78);
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
            this.buttonFirst.Location = new System.Drawing.Point(10, 23);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(39, 39);
            this.buttonFirst.TabIndex = 3;
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // dataGridViewSociete
            // 
            this.dataGridViewSociete.AllowUserToAddRows = false;
            this.dataGridViewSociete.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridViewSociete.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSociete.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewSociete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSociete.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSociete.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSociete.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSociete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSociete.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewSociete.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSociete.Name = "dataGridViewSociete";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSociete.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSociete.RowHeadersWidth = 25;
            this.dataGridViewSociete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSociete.Size = new System.Drawing.Size(738, 258);
            this.dataGridViewSociete.TabIndex = 13;
            // 
            // tableLayoutPanelEmployeBottom
            // 
            this.tableLayoutPanelEmployeBottom.ColumnCount = 3;
            this.tableLayoutPanelEmployeBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelEmployeBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelEmployeBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelEmployeBottom.Controls.Add(this.buttonAjouterSSociete, 0, 0);
            this.tableLayoutPanelEmployeBottom.Controls.Add(this.buttonSupprimerSociete, 2, 0);
            this.tableLayoutPanelEmployeBottom.Controls.Add(this.buttonModifierSociete, 1, 0);
            this.tableLayoutPanelEmployeBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelEmployeBottom.Location = new System.Drawing.Point(0, 303);
            this.tableLayoutPanelEmployeBottom.Name = "tableLayoutPanelEmployeBottom";
            this.tableLayoutPanelEmployeBottom.RowCount = 1;
            this.tableLayoutPanelEmployeBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelEmployeBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanelEmployeBottom.Size = new System.Drawing.Size(800, 55);
            this.tableLayoutPanelEmployeBottom.TabIndex = 3;
            // 
            // buttonAjouterSSociete
            // 
            this.buttonAjouterSSociete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjouterSSociete.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAjouterSSociete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAjouterSSociete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjouterSSociete.FlatAppearance.BorderSize = 0;
            this.buttonAjouterSSociete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonAjouterSSociete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonAjouterSSociete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterSSociete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterSSociete.ForeColor = System.Drawing.Color.White;
            this.buttonAjouterSSociete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjouterSSociete.Location = new System.Drawing.Point(3, 3);
            this.buttonAjouterSSociete.Name = "buttonAjouterSSociete";
            this.buttonAjouterSSociete.Size = new System.Drawing.Size(260, 49);
            this.buttonAjouterSSociete.TabIndex = 1;
            this.buttonAjouterSSociete.Text = "Ajouter Societe";
            this.buttonAjouterSSociete.UseVisualStyleBackColor = false;
            this.buttonAjouterSSociete.Click += new System.EventHandler(this.buttonAjouterSociete_Click);
            // 
            // buttonSupprimerSociete
            // 
            this.buttonSupprimerSociete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSupprimerSociete.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSupprimerSociete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSupprimerSociete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSupprimerSociete.FlatAppearance.BorderSize = 0;
            this.buttonSupprimerSociete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonSupprimerSociete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonSupprimerSociete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerSociete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimerSociete.ForeColor = System.Drawing.Color.White;
            this.buttonSupprimerSociete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupprimerSociete.Location = new System.Drawing.Point(535, 3);
            this.buttonSupprimerSociete.Name = "buttonSupprimerSociete";
            this.buttonSupprimerSociete.Size = new System.Drawing.Size(262, 49);
            this.buttonSupprimerSociete.TabIndex = 2;
            this.buttonSupprimerSociete.Text = "Supprimer Societe";
            this.buttonSupprimerSociete.UseVisualStyleBackColor = false;
            this.buttonSupprimerSociete.Click += new System.EventHandler(this.buttonSupprimerSociete_Click);
            // 
            // buttonModifierSociete
            // 
            this.buttonModifierSociete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModifierSociete.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonModifierSociete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonModifierSociete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModifierSociete.FlatAppearance.BorderSize = 0;
            this.buttonModifierSociete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonModifierSociete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonModifierSociete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifierSociete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifierSociete.ForeColor = System.Drawing.Color.White;
            this.buttonModifierSociete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModifierSociete.Location = new System.Drawing.Point(269, 3);
            this.buttonModifierSociete.Name = "buttonModifierSociete";
            this.buttonModifierSociete.Size = new System.Drawing.Size(260, 49);
            this.buttonModifierSociete.TabIndex = 0;
            this.buttonModifierSociete.Text = "Modifier Societe";
            this.buttonModifierSociete.UseVisualStyleBackColor = false;
            this.buttonModifierSociete.Click += new System.EventHandler(this.buttonModifierSociete_Click);
            // 
            // FormSociete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelIN);
            this.Controls.Add(this.tableLayoutPanelEmploye);
            this.Controls.Add(this.tableLayoutPSociete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSociete";
            this.Text = "FormSociete";
            this.Load += new System.EventHandler(this.FormSociete_Load);
            this.tableLayoutPSociete.ResumeLayout(false);
            this.tableLayoutPSociete.PerformLayout();
            this.tableLayoutPanelEmploye.ResumeLayout(false);
            this.panelIN.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSociete)).EndInit();
            this.tableLayoutPanelEmployeBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPSociete;
        private System.Windows.Forms.Label labelEmploye;
        private System.Windows.Forms.Label labelCloseEmploye;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEmploye;
        private System.Windows.Forms.Button buttonSociete;
        private System.Windows.Forms.Button buttonSocieteArchive;
        private System.Windows.Forms.Button buttonAjouterSociete;
        private System.Windows.Forms.Panel panelIN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEmployeBottom;
        private System.Windows.Forms.Button buttonAjouterSSociete;
        private System.Windows.Forms.Button buttonSupprimerSociete;
        private System.Windows.Forms.Button buttonModifierSociete;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.TextBox textBoxRechercher;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonprevious;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.DataGridView dataGridViewSociete;
    }
}