namespace SYNDIC_1._0.Forms
{
    partial class FormAjouterBlocOrImmeuble
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
            this.labelCloseDocuments = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.buttonRaz = new System.Windows.Forms.Button();
            this.labelNom = new System.Windows.Forms.Label();
            this.panelImeuble = new System.Windows.Forms.Panel();
            this.labelnbretages = new System.Windows.Forms.Label();
            this.comboBoxBloc = new System.Windows.Forms.ComboBox();
            this.textBoxNbretages = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAjouter = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelImeuble.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCloseDocuments
            // 
            this.labelCloseDocuments.AutoSize = true;
            this.labelCloseDocuments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseDocuments.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelCloseDocuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCloseDocuments.Location = new System.Drawing.Point(370, 0);
            this.labelCloseDocuments.Name = "labelCloseDocuments";
            this.labelCloseDocuments.Size = new System.Drawing.Size(18, 18);
            this.labelCloseDocuments.TabIndex = 20;
            this.labelCloseDocuments.Text = "X";
            this.labelCloseDocuments.Click += new System.EventHandler(this.labelCloseDocuments_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.Enabled = false;
            this.buttonValider.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValider.Location = new System.Drawing.Point(64, 218);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(108, 23);
            this.buttonValider.TabIndex = 21;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(180, 87);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(182, 22);
            this.textBoxNom.TabIndex = 18;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            this.textBoxNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNom_KeyPress);
            // 
            // buttonRaz
            // 
            this.buttonRaz.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRaz.Location = new System.Drawing.Point(230, 218);
            this.buttonRaz.Name = "buttonRaz";
            this.buttonRaz.Size = new System.Drawing.Size(132, 23);
            this.buttonRaz.TabIndex = 22;
            this.buttonRaz.Text = "Vider les champs";
            this.buttonRaz.UseVisualStyleBackColor = true;
            this.buttonRaz.Click += new System.EventHandler(this.buttonRaz_Click);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(121, 87);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(51, 20);
            this.labelNom.TabIndex = 19;
            this.labelNom.Text = "Nom :";
            // 
            // panelImeuble
            // 
            this.panelImeuble.Controls.Add(this.labelnbretages);
            this.panelImeuble.Controls.Add(this.comboBoxBloc);
            this.panelImeuble.Controls.Add(this.textBoxNbretages);
            this.panelImeuble.Controls.Add(this.label3);
            this.panelImeuble.Location = new System.Drawing.Point(12, 121);
            this.panelImeuble.Name = "panelImeuble";
            this.panelImeuble.Size = new System.Drawing.Size(364, 88);
            this.panelImeuble.TabIndex = 23;
            // 
            // labelnbretages
            // 
            this.labelnbretages.AutoSize = true;
            this.labelnbretages.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnbretages.Location = new System.Drawing.Point(1, 11);
            this.labelnbretages.Name = "labelnbretages";
            this.labelnbretages.Size = new System.Drawing.Size(161, 20);
            this.labelnbretages.TabIndex = 5;
            this.labelnbretages.Text = "Nombre des étages :";
            // 
            // comboBoxBloc
            // 
            this.comboBoxBloc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBloc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBloc.FormattingEnabled = true;
            this.comboBoxBloc.Location = new System.Drawing.Point(168, 53);
            this.comboBoxBloc.Name = "comboBoxBloc";
            this.comboBoxBloc.Size = new System.Drawing.Size(182, 25);
            this.comboBoxBloc.TabIndex = 2;
            // 
            // textBoxNbretages
            // 
            this.textBoxNbretages.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNbretages.Location = new System.Drawing.Point(168, 11);
            this.textBoxNbretages.Name = "textBoxNbretages";
            this.textBoxNbretages.Size = new System.Drawing.Size(182, 22);
            this.textBoxNbretages.TabIndex = 1;
            this.textBoxNbretages.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            this.textBoxNbretages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNbretages_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bloc :";
            // 
            // labelAjouter
            // 
            this.labelAjouter.AutoSize = true;
            this.labelAjouter.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAjouter.Location = new System.Drawing.Point(149, 9);
            this.labelAjouter.Name = "labelAjouter";
            this.labelAjouter.Size = new System.Drawing.Size(97, 30);
            this.labelAjouter.TabIndex = 24;
            this.labelAjouter.Text = "Ajouter";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.labelAjouter);
            this.panelContainer.Controls.Add(this.labelCloseDocuments);
            this.panelContainer.Controls.Add(this.buttonValider);
            this.panelContainer.Controls.Add(this.textBoxNom);
            this.panelContainer.Controls.Add(this.buttonRaz);
            this.panelContainer.Controls.Add(this.labelNom);
            this.panelContainer.Controls.Add(this.panelImeuble);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(388, 252);
            this.panelContainer.TabIndex = 25;
            // 
            // FormAjouterBlocOrImmeuble
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(388, 252);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAjouterBlocOrImmeuble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAjouterBlocOrImmeuble";
            this.Load += new System.EventHandler(this.FormAjouterBlocOrImmeuble_Load);
            this.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            this.panelImeuble.ResumeLayout(false);
            this.panelImeuble.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCloseDocuments;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Button buttonRaz;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Panel panelImeuble;
        private System.Windows.Forms.Label labelnbretages;
        private System.Windows.Forms.ComboBox comboBoxBloc;
        private System.Windows.Forms.TextBox textBoxNbretages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAjouter;
        private System.Windows.Forms.Panel panelContainer;
    }
}