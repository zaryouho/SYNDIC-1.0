﻿namespace SYNDIC_1._0.Forms
{
    partial class FormUtilisateurs
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
            this.panelWrapper = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonModifyUser = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxConfirmePassword = new System.Windows.Forms.TextBox();
            this.labelConfirme = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelUserType = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.panelWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWrapper
            // 
            this.panelWrapper.Controls.Add(this.splitContainerMain);
            this.panelWrapper.Controls.Add(this.panelHeader);
            this.panelWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWrapper.Location = new System.Drawing.Point(0, 0);
            this.panelWrapper.Name = "panelWrapper";
            this.panelWrapper.Size = new System.Drawing.Size(800, 450);
            this.panelWrapper.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 57);
            this.panelHeader.TabIndex = 0;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 57);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.dataGridViewUsers);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.checkBoxShowPassword);
            this.splitContainerMain.Panel2.Controls.Add(this.labelUserType);
            this.splitContainerMain.Panel2.Controls.Add(this.comboBox1);
            this.splitContainerMain.Panel2.Controls.Add(this.textBoxConfirmePassword);
            this.splitContainerMain.Panel2.Controls.Add(this.labelConfirme);
            this.splitContainerMain.Panel2.Controls.Add(this.textBoxPassword);
            this.splitContainerMain.Panel2.Controls.Add(this.label2);
            this.splitContainerMain.Panel2.Controls.Add(this.textBoxLogin);
            this.splitContainerMain.Panel2.Controls.Add(this.labelLogin);
            this.splitContainerMain.Panel2.Controls.Add(this.buttonDeleteUser);
            this.splitContainerMain.Panel2.Controls.Add(this.buttonModifyUser);
            this.splitContainerMain.Panel2.Controls.Add(this.buttonAddUser);
            this.splitContainerMain.Size = new System.Drawing.Size(800, 393);
            this.splitContainerMain.SplitterDistance = 197;
            this.splitContainerMain.TabIndex = 1;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(138, 335);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(75, 23);
            this.buttonAddUser.TabIndex = 0;
            this.buttonAddUser.Text = "Ajouter utilisateur";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // buttonModifyUser
            // 
            this.buttonModifyUser.Location = new System.Drawing.Point(248, 335);
            this.buttonModifyUser.Name = "buttonModifyUser";
            this.buttonModifyUser.Size = new System.Drawing.Size(75, 23);
            this.buttonModifyUser.TabIndex = 1;
            this.buttonModifyUser.Text = "Modifier utilisateur";
            this.buttonModifyUser.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(359, 335);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteUser.TabIndex = 2;
            this.buttonDeleteUser.Text = "Supprimer utilisateur";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(143, 57);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(38, 13);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "login : ";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(185, 57);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(185, 96);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "mot de pass :";
            // 
            // textBoxConfirmePassword
            // 
            this.textBoxConfirmePassword.Location = new System.Drawing.Point(185, 138);
            this.textBoxConfirmePassword.Name = "textBoxConfirmePassword";
            this.textBoxConfirmePassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxConfirmePassword.TabIndex = 8;
            // 
            // labelConfirme
            // 
            this.labelConfirme.AutoSize = true;
            this.labelConfirme.Location = new System.Drawing.Point(63, 141);
            this.labelConfirme.Name = "labelConfirme";
            this.labelConfirme.Size = new System.Drawing.Size(116, 13);
            this.labelConfirme.TabIndex = 7;
            this.labelConfirme.Text = "confirmer mot de pass :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(185, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // labelUserType
            // 
            this.labelUserType.AutoSize = true;
            this.labelUserType.Location = new System.Drawing.Point(99, 184);
            this.labelUserType.Name = "labelUserType";
            this.labelUserType.Size = new System.Drawing.Size(80, 13);
            this.labelUserType.TabIndex = 10;
            this.labelUserType.Text = "type utilisateur :";
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(291, 140);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(122, 17);
            this.checkBoxShowPassword.TabIndex = 11;
            this.checkBoxShowPassword.Text = "Affiche mot de pass ";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(197, 393);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // FormUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelWrapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUtilisateurs";
            this.Text = "FormUtilisateurs";
            this.panelWrapper.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWrapper;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonModifyUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Label labelUserType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxConfirmePassword;
        private System.Windows.Forms.Label labelConfirme;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
    }
}