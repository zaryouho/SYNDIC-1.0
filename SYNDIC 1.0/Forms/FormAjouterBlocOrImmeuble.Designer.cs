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
            this.panelAJouterBLOCorImmeuble = new System.Windows.Forms.Panel();
            this.panelImeuble = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelnbretages = new System.Windows.Forms.Label();
            this.comboBoxBloc = new System.Windows.Forms.ComboBox();
            this.textBoxNbretages = new System.Windows.Forms.TextBox();
            this.buttonRaz = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.labelCloseDocuments = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.panelAJouterBLOCorImmeuble.SuspendLayout();
            this.panelImeuble.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAJouterBLOCorImmeuble
            // 
            this.panelAJouterBLOCorImmeuble.Controls.Add(this.panelImeuble);
            this.panelAJouterBLOCorImmeuble.Controls.Add(this.buttonRaz);
            this.panelAJouterBLOCorImmeuble.Controls.Add(this.buttonValider);
            this.panelAJouterBLOCorImmeuble.Controls.Add(this.labelCloseDocuments);
            this.panelAJouterBLOCorImmeuble.Controls.Add(this.labelNom);
            this.panelAJouterBLOCorImmeuble.Controls.Add(this.textBoxNom);
            this.panelAJouterBLOCorImmeuble.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAJouterBLOCorImmeuble.Location = new System.Drawing.Point(0, 0);
            this.panelAJouterBLOCorImmeuble.Name = "panelAJouterBLOCorImmeuble";
            this.panelAJouterBLOCorImmeuble.Size = new System.Drawing.Size(353, 220);
            this.panelAJouterBLOCorImmeuble.TabIndex = 14;
            this.panelAJouterBLOCorImmeuble.Visible = false;
            // 
            // panelImeuble
            // 
            this.panelImeuble.Controls.Add(this.label3);
            this.panelImeuble.Controls.Add(this.labelnbretages);
            this.panelImeuble.Controls.Add(this.comboBoxBloc);
            this.panelImeuble.Controls.Add(this.textBoxNbretages);
            this.panelImeuble.Location = new System.Drawing.Point(11, 88);
            this.panelImeuble.Name = "panelImeuble";
            this.panelImeuble.Size = new System.Drawing.Size(341, 88);
            this.panelImeuble.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bloc :";
            // 
            // labelnbretages
            // 
            this.labelnbretages.AutoSize = true;
            this.labelnbretages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnbretages.Location = new System.Drawing.Point(1, 14);
            this.labelnbretages.Name = "labelnbretages";
            this.labelnbretages.Size = new System.Drawing.Size(141, 17);
            this.labelnbretages.TabIndex = 5;
            this.labelnbretages.Text = "Nombre des Etages :";
            // 
            // comboBoxBloc
            // 
            this.comboBoxBloc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBloc.FormattingEnabled = true;
            this.comboBoxBloc.Location = new System.Drawing.Point(148, 56);
            this.comboBoxBloc.Name = "comboBoxBloc";
            this.comboBoxBloc.Size = new System.Drawing.Size(182, 21);
            this.comboBoxBloc.TabIndex = 2;
            // 
            // textBoxNbretages
            // 
            this.textBoxNbretages.Location = new System.Drawing.Point(148, 11);
            this.textBoxNbretages.Name = "textBoxNbretages";
            this.textBoxNbretages.Size = new System.Drawing.Size(182, 20);
            this.textBoxNbretages.TabIndex = 1;
            // 
            // buttonRaz
            // 
            this.buttonRaz.Location = new System.Drawing.Point(202, 185);
            this.buttonRaz.Name = "buttonRaz";
            this.buttonRaz.Size = new System.Drawing.Size(75, 23);
            this.buttonRaz.TabIndex = 16;
            this.buttonRaz.Text = "RAZ";
            this.buttonRaz.UseVisualStyleBackColor = true;
            this.buttonRaz.Click += new System.EventHandler(this.buttonRaz_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(50, 185);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 15;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // labelCloseDocuments
            // 
            this.labelCloseDocuments.AutoSize = true;
            this.labelCloseDocuments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseDocuments.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelCloseDocuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCloseDocuments.Location = new System.Drawing.Point(335, 0);
            this.labelCloseDocuments.Name = "labelCloseDocuments";
            this.labelCloseDocuments.Size = new System.Drawing.Size(18, 18);
            this.labelCloseDocuments.TabIndex = 7;
            this.labelCloseDocuments.Text = "X";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(47, 54);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(45, 17);
            this.labelNom.TabIndex = 4;
            this.labelNom.Text = "Nom :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(159, 51);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(182, 20);
            this.textBoxNom.TabIndex = 0;
            // 
            // FormAjouterBlocOrImmeuble
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(353, 220);
            this.Controls.Add(this.panelAJouterBLOCorImmeuble);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAjouterBlocOrImmeuble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAjouterBlocOrImmeuble";
            this.Load += new System.EventHandler(this.FormAjouterBlocOrImmeuble_Load);
            this.panelAJouterBLOCorImmeuble.ResumeLayout(false);
            this.panelAJouterBLOCorImmeuble.PerformLayout();
            this.panelImeuble.ResumeLayout(false);
            this.panelImeuble.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAJouterBLOCorImmeuble;
        private System.Windows.Forms.ComboBox comboBoxBloc;
        private System.Windows.Forms.TextBox textBoxNbretages;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelnbretages;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelCloseDocuments;
        private System.Windows.Forms.Panel panelImeuble;
        private System.Windows.Forms.Button buttonRaz;
        private System.Windows.Forms.Button buttonValider;
    }
}