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
            this.tabControlBiens = new System.Windows.Forms.TabControl();
            this.tabPageBiensEcheances = new System.Windows.Forms.TabPage();
            this.panelBiensEcheancesBottom = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPageBiensEchangeProprietaire = new System.Windows.Forms.TabPage();
            this.panelBiensEchangeProprietaireBottom = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPageBiensListe = new System.Windows.Forms.TabPage();
            this.panelSsBiensBottom = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewBien = new System.Windows.Forms.DataGridView();
            this.textBoxRechercher = new System.Windows.Forms.TextBox();
            this.labelRechercher = new System.Windows.Forms.Label();
            this.buttonChercher = new System.Windows.Forms.Button();
            this.comboBoxBloc = new System.Windows.Forms.ComboBox();
            this.comboBoxImmeuble = new System.Windows.Forms.ComboBox();
            this.labelBloc = new System.Windows.Forms.Label();
            this.labelImmeuble = new System.Windows.Forms.Label();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.splitContainerBiens = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanelFinanceTitle = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSsBiensEcheances = new System.Windows.Forms.Button();
            this.buttonSsBiensEchangeProprietaire = new System.Windows.Forms.Button();
            this.buttonSsBiensListe = new System.Windows.Forms.Button();
            this.panelHead.SuspendLayout();
            this.tabControlBiens.SuspendLayout();
            this.tabPageBiensEcheances.SuspendLayout();
            this.panelBiensEcheancesBottom.SuspendLayout();
            this.tabPageBiensEchangeProprietaire.SuspendLayout();
            this.panelBiensEchangeProprietaireBottom.SuspendLayout();
            this.tabPageBiensListe.SuspendLayout();
            this.panelSsBiensBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBiens)).BeginInit();
            this.splitContainerBiens.Panel1.SuspendLayout();
            this.splitContainerBiens.Panel2.SuspendLayout();
            this.splitContainerBiens.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanelFinanceTitle.SuspendLayout();
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
            this.panelHead.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHead_Paint);
            // 
            // tabControlBiens
            // 
            this.tabControlBiens.Controls.Add(this.tabPageBiensListe);
            this.tabControlBiens.Controls.Add(this.tabPageBiensEchangeProprietaire);
            this.tabControlBiens.Controls.Add(this.tabPageBiensEcheances);
            this.tabControlBiens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlBiens.Location = new System.Drawing.Point(0, 0);
            this.tabControlBiens.Name = "tabControlBiens";
            this.tabControlBiens.SelectedIndex = 0;
            this.tabControlBiens.Size = new System.Drawing.Size(759, 436);
            this.tabControlBiens.TabIndex = 11;
            // 
            // tabPageBiensEcheances
            // 
            this.tabPageBiensEcheances.Controls.Add(this.panelBiensEcheancesBottom);
            this.tabPageBiensEcheances.Location = new System.Drawing.Point(4, 22);
            this.tabPageBiensEcheances.Name = "tabPageBiensEcheances";
            this.tabPageBiensEcheances.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBiensEcheances.Size = new System.Drawing.Size(660, 326);
            this.tabPageBiensEcheances.TabIndex = 2;
            this.tabPageBiensEcheances.Text = "Echéances";
            this.tabPageBiensEcheances.UseVisualStyleBackColor = true;
            // 
            // panelBiensEcheancesBottom
            // 
            this.panelBiensEcheancesBottom.Controls.Add(this.button4);
            this.panelBiensEcheancesBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBiensEcheancesBottom.Location = new System.Drawing.Point(3, 263);
            this.panelBiensEcheancesBottom.Name = "panelBiensEcheancesBottom";
            this.panelBiensEcheancesBottom.Size = new System.Drawing.Size(654, 60);
            this.panelBiensEcheancesBottom.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(61, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 42);
            this.button4.TabIndex = 8;
            this.button4.Text = "Echéances";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // tabPageBiensEchangeProprietaire
            // 
            this.tabPageBiensEchangeProprietaire.Controls.Add(this.panelBiensEchangeProprietaireBottom);
            this.tabPageBiensEchangeProprietaire.Location = new System.Drawing.Point(4, 22);
            this.tabPageBiensEchangeProprietaire.Name = "tabPageBiensEchangeProprietaire";
            this.tabPageBiensEchangeProprietaire.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBiensEchangeProprietaire.Size = new System.Drawing.Size(660, 326);
            this.tabPageBiensEchangeProprietaire.TabIndex = 1;
            this.tabPageBiensEchangeProprietaire.Text = "Echange de propriétaire";
            this.tabPageBiensEchangeProprietaire.UseVisualStyleBackColor = true;
            // 
            // panelBiensEchangeProprietaireBottom
            // 
            this.panelBiensEchangeProprietaireBottom.Controls.Add(this.button3);
            this.panelBiensEchangeProprietaireBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBiensEchangeProprietaireBottom.Location = new System.Drawing.Point(3, 263);
            this.panelBiensEchangeProprietaireBottom.Name = "panelBiensEchangeProprietaireBottom";
            this.panelBiensEchangeProprietaireBottom.Size = new System.Drawing.Size(654, 60);
            this.panelBiensEchangeProprietaireBottom.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(61, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 42);
            this.button3.TabIndex = 8;
            this.button3.Text = "Echange de propriétaire";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // tabPageBiensListe
            // 
            this.tabPageBiensListe.Controls.Add(this.panel1);
            this.tabPageBiensListe.Controls.Add(this.dataGridViewBien);
            this.tabPageBiensListe.Controls.Add(this.panelSsBiensBottom);
            this.tabPageBiensListe.Location = new System.Drawing.Point(4, 22);
            this.tabPageBiensListe.Name = "tabPageBiensListe";
            this.tabPageBiensListe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBiensListe.Size = new System.Drawing.Size(751, 410);
            this.tabPageBiensListe.TabIndex = 0;
            this.tabPageBiensListe.Text = "Liste des biens";
            this.tabPageBiensListe.UseVisualStyleBackColor = true;
            // 
            // panelSsBiensBottom
            // 
            this.panelSsBiensBottom.Controls.Add(this.button1);
            this.panelSsBiensBottom.Controls.Add(this.buttonFirst);
            this.panelSsBiensBottom.Controls.Add(this.buttonLast);
            this.panelSsBiensBottom.Controls.Add(this.buttonPrevious);
            this.panelSsBiensBottom.Controls.Add(this.buttonNext);
            this.panelSsBiensBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSsBiensBottom.Location = new System.Drawing.Point(3, 347);
            this.panelSsBiensBottom.Name = "panelSsBiensBottom";
            this.panelSsBiensBottom.Size = new System.Drawing.Size(745, 60);
            this.panelSsBiensBottom.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(509, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Modifier le bien";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // dataGridViewBien
            // 
            this.dataGridViewBien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBien.Location = new System.Drawing.Point(45, 83);
            this.dataGridViewBien.Name = "dataGridViewBien";
            this.dataGridViewBien.ReadOnly = true;
            this.dataGridViewBien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBien.Size = new System.Drawing.Size(654, 258);
            this.dataGridViewBien.TabIndex = 11;
            // 
            // textBoxRechercher
            // 
            this.textBoxRechercher.Location = new System.Drawing.Point(16, 28);
            this.textBoxRechercher.Name = "textBoxRechercher";
            this.textBoxRechercher.Size = new System.Drawing.Size(165, 20);
            this.textBoxRechercher.TabIndex = 0;
            this.textBoxRechercher.TextChanged += new System.EventHandler(this.textBoxRechercher_TextChanged);
            this.textBoxRechercher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRechercher_KeyPress);
            // 
            // labelRechercher
            // 
            this.labelRechercher.AutoSize = true;
            this.labelRechercher.Location = new System.Drawing.Point(16, 5);
            this.labelRechercher.Name = "labelRechercher";
            this.labelRechercher.Size = new System.Drawing.Size(69, 13);
            this.labelRechercher.TabIndex = 1;
            this.labelRechercher.Text = "Rechercher :";
            // 
            // buttonChercher
            // 
            this.buttonChercher.Enabled = false;
            this.buttonChercher.Location = new System.Drawing.Point(197, 28);
            this.buttonChercher.Name = "buttonChercher";
            this.buttonChercher.Size = new System.Drawing.Size(64, 20);
            this.buttonChercher.TabIndex = 2;
            this.buttonChercher.Text = "Chercher";
            this.buttonChercher.UseVisualStyleBackColor = true;
            this.buttonChercher.Click += new System.EventHandler(this.buttonChercher_Click);
            // 
            // comboBoxBloc
            // 
            this.comboBoxBloc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxBloc.FormattingEnabled = true;
            this.comboBoxBloc.Location = new System.Drawing.Point(330, 27);
            this.comboBoxBloc.Name = "comboBoxBloc";
            this.comboBoxBloc.Size = new System.Drawing.Size(193, 21);
            this.comboBoxBloc.TabIndex = 3;
            // 
            // comboBoxImmeuble
            // 
            this.comboBoxImmeuble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxImmeuble.FormattingEnabled = true;
            this.comboBoxImmeuble.Location = new System.Drawing.Point(539, 27);
            this.comboBoxImmeuble.Name = "comboBoxImmeuble";
            this.comboBoxImmeuble.Size = new System.Drawing.Size(193, 21);
            this.comboBoxImmeuble.TabIndex = 4;
            // 
            // labelBloc
            // 
            this.labelBloc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBloc.AutoSize = true;
            this.labelBloc.Location = new System.Drawing.Point(330, 5);
            this.labelBloc.Name = "labelBloc";
            this.labelBloc.Size = new System.Drawing.Size(111, 13);
            this.labelBloc.TabIndex = 5;
            this.labelBloc.Text = "Selectioner une Bloc :";
            // 
            // labelImmeuble
            // 
            this.labelImmeuble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelImmeuble.AutoSize = true;
            this.labelImmeuble.Location = new System.Drawing.Point(539, 5);
            this.labelImmeuble.Name = "labelImmeuble";
            this.labelImmeuble.Size = new System.Drawing.Size(129, 13);
            this.labelImmeuble.TabIndex = 6;
            this.labelImmeuble.Text = "Selectioner un Immeuble :";
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(289, 3);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(30, 23);
            this.buttonFirst.TabIndex = 7;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(319, 3);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(30, 23);
            this.buttonPrevious.TabIndex = 8;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(349, 3);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(30, 23);
            this.buttonNext.TabIndex = 9;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(379, 3);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(30, 23);
            this.buttonLast.TabIndex = 10;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
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
            this.splitContainerBiens.Panel1.Controls.Add(this.tableLayoutPanelFinanceTitle);
            this.splitContainerBiens.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainerBiens_Panel1_Paint);
            // 
            // splitContainerBiens.Panel2
            // 
            this.splitContainerBiens.Panel2.Controls.Add(this.tabControlBiens);
            this.splitContainerBiens.Size = new System.Drawing.Size(759, 540);
            this.splitContainerBiens.SplitterDistance = 100;
            this.splitContainerBiens.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxBloc);
            this.panel1.Controls.Add(this.textBoxRechercher);
            this.panel1.Controls.Add(this.labelRechercher);
            this.panel1.Controls.Add(this.buttonChercher);
            this.panel1.Controls.Add(this.comboBoxImmeuble);
            this.panel1.Controls.Add(this.labelImmeuble);
            this.panel1.Controls.Add(this.labelBloc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 81);
            this.panel1.TabIndex = 12;
            // 
            // tableLayoutPanelFinanceTitle
            // 
            this.tableLayoutPanelFinanceTitle.ColumnCount = 3;
            this.tableLayoutPanelFinanceTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFinanceTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFinanceTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelFinanceTitle.Controls.Add(this.buttonSsBiensEcheances, 2, 0);
            this.tableLayoutPanelFinanceTitle.Controls.Add(this.buttonSsBiensEchangeProprietaire, 1, 0);
            this.tableLayoutPanelFinanceTitle.Controls.Add(this.buttonSsBiensListe, 0, 0);
            this.tableLayoutPanelFinanceTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelFinanceTitle.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelFinanceTitle.Name = "tableLayoutPanelFinanceTitle";
            this.tableLayoutPanelFinanceTitle.RowCount = 1;
            this.tableLayoutPanelFinanceTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFinanceTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanelFinanceTitle.Size = new System.Drawing.Size(759, 48);
            this.tableLayoutPanelFinanceTitle.TabIndex = 7;
            // 
            // buttonSsBiensEcheances
            // 
            this.buttonSsBiensEcheances.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSsBiensEcheances.BackColor = System.Drawing.Color.Blue;
            this.buttonSsBiensEcheances.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSsBiensEcheances.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSsBiensEcheances.FlatAppearance.BorderSize = 0;
            this.buttonSsBiensEcheances.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonSsBiensEcheances.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonSsBiensEcheances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSsBiensEcheances.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSsBiensEcheances.ForeColor = System.Drawing.Color.White;
            this.buttonSsBiensEcheances.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSsBiensEcheances.Location = new System.Drawing.Point(509, 3);
            this.buttonSsBiensEcheances.Name = "buttonSsBiensEcheances";
            this.buttonSsBiensEcheances.Size = new System.Drawing.Size(247, 42);
            this.buttonSsBiensEcheances.TabIndex = 6;
            this.buttonSsBiensEcheances.Text = "Echéances";
            this.buttonSsBiensEcheances.UseVisualStyleBackColor = false;
            this.buttonSsBiensEcheances.Click += new System.EventHandler(this.buttonSsBiensEcheances_Click);
            // 
            // buttonSsBiensEchangeProprietaire
            // 
            this.buttonSsBiensEchangeProprietaire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSsBiensEchangeProprietaire.BackColor = System.Drawing.Color.Blue;
            this.buttonSsBiensEchangeProprietaire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSsBiensEchangeProprietaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSsBiensEchangeProprietaire.FlatAppearance.BorderSize = 0;
            this.buttonSsBiensEchangeProprietaire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonSsBiensEchangeProprietaire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonSsBiensEchangeProprietaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSsBiensEchangeProprietaire.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSsBiensEchangeProprietaire.ForeColor = System.Drawing.Color.White;
            this.buttonSsBiensEchangeProprietaire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSsBiensEchangeProprietaire.Location = new System.Drawing.Point(256, 3);
            this.buttonSsBiensEchangeProprietaire.Name = "buttonSsBiensEchangeProprietaire";
            this.buttonSsBiensEchangeProprietaire.Size = new System.Drawing.Size(247, 42);
            this.buttonSsBiensEchangeProprietaire.TabIndex = 8;
            this.buttonSsBiensEchangeProprietaire.Text = "Echange de propriétaire";
            this.buttonSsBiensEchangeProprietaire.UseVisualStyleBackColor = false;
            this.buttonSsBiensEchangeProprietaire.Click += new System.EventHandler(this.buttonSsBiensEchangeProprietaire_Click);
            // 
            // buttonSsBiensListe
            // 
            this.buttonSsBiensListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSsBiensListe.BackColor = System.Drawing.Color.Blue;
            this.buttonSsBiensListe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSsBiensListe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSsBiensListe.FlatAppearance.BorderSize = 0;
            this.buttonSsBiensListe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.buttonSsBiensListe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonSsBiensListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSsBiensListe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSsBiensListe.ForeColor = System.Drawing.Color.White;
            this.buttonSsBiensListe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSsBiensListe.Location = new System.Drawing.Point(3, 3);
            this.buttonSsBiensListe.Name = "buttonSsBiensListe";
            this.buttonSsBiensListe.Size = new System.Drawing.Size(247, 42);
            this.buttonSsBiensListe.TabIndex = 7;
            this.buttonSsBiensListe.Text = "Liste des Biens";
            this.buttonSsBiensListe.UseVisualStyleBackColor = false;
            this.buttonSsBiensListe.Click += new System.EventHandler(this.buttonSsBiensListe_Click);
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
            this.tabControlBiens.ResumeLayout(false);
            this.tabPageBiensEcheances.ResumeLayout(false);
            this.panelBiensEcheancesBottom.ResumeLayout(false);
            this.tabPageBiensEchangeProprietaire.ResumeLayout(false);
            this.panelBiensEchangeProprietaireBottom.ResumeLayout(false);
            this.tabPageBiensListe.ResumeLayout(false);
            this.panelSsBiensBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBien)).EndInit();
            this.splitContainerBiens.Panel1.ResumeLayout(false);
            this.splitContainerBiens.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBiens)).EndInit();
            this.splitContainerBiens.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanelFinanceTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBiens;
        private System.Windows.Forms.Label labelCloseBiens;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.TabControl tabControlBiens;
        private System.Windows.Forms.TabPage tabPageBiensListe;
        private System.Windows.Forms.DataGridView dataGridViewBien;
        private System.Windows.Forms.Panel panelSsBiensBottom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPageBiensEchangeProprietaire;
        private System.Windows.Forms.Panel panelBiensEchangeProprietaireBottom;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPageBiensEcheances;
        private System.Windows.Forms.Panel panelBiensEcheancesBottom;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxRechercher;
        private System.Windows.Forms.Label labelRechercher;
        private System.Windows.Forms.Button buttonChercher;
        private System.Windows.Forms.ComboBox comboBoxBloc;
        private System.Windows.Forms.ComboBox comboBoxImmeuble;
        private System.Windows.Forms.Label labelBloc;
        private System.Windows.Forms.Label labelImmeuble;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.SplitContainer splitContainerBiens;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFinanceTitle;
        private System.Windows.Forms.Button buttonSsBiensEcheances;
        private System.Windows.Forms.Button buttonSsBiensEchangeProprietaire;
        private System.Windows.Forms.Button buttonSsBiensListe;
    }
}