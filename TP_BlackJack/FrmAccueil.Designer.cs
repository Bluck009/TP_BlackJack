﻿
namespace TP_BlackJack
{
    partial class FrmAccueil
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
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblNom = new System.Windows.Forms.Label();
            txtNom = new System.Windows.Forms.TextBox();
            lblDateNaissance = new System.Windows.Forms.Label();
            txtDateNaissance = new System.Windows.Forms.TextBox();
            btnAjouter = new System.Windows.Forms.Button();
            lblNombreBots = new System.Windows.Forms.Label();
            cmbNombreBots = new System.Windows.Forms.ComboBox();
            btnCommencer = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(395, 169);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(53, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email :";
            lblEmail.Click += lblEmail_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(454, 169);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(144, 27);
            txtEmail.TabIndex = 1;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new System.Drawing.Point(395, 212);
            lblNom.Name = "lblNom";
            lblNom.Size = new System.Drawing.Size(45, 20);
            lblNom.TabIndex = 2;
            lblNom.Text = "Nom:";
            // 
            // txtNom
            // 
            txtNom.Location = new System.Drawing.Point(454, 212);
            txtNom.Name = "txtNom";
            txtNom.Size = new System.Drawing.Size(144, 27);
            txtNom.TabIndex = 3;
            txtNom.TextChanged += txtNom_TextChanged;
            // 
            // lblDateNaissance
            // 
            lblDateNaissance.AutoSize = true;
            lblDateNaissance.Location = new System.Drawing.Point(395, 254);
            lblDateNaissance.Name = "lblDateNaissance";
            lblDateNaissance.Size = new System.Drawing.Size(111, 20);
            lblDateNaissance.TabIndex = 4;
            lblDateNaissance.Text = "Date naissance:";
            // 
            // txtDateNaissance
            // 
            txtDateNaissance.Location = new System.Drawing.Point(512, 254);
            txtDateNaissance.Name = "txtDateNaissance";
            txtDateNaissance.Size = new System.Drawing.Size(86, 27);
            txtDateNaissance.TabIndex = 5;
            txtDateNaissance.TextChanged += txtDateNaissance_TextChanged;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new System.Drawing.Point(640, 236);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new System.Drawing.Size(94, 29);
            btnAjouter.TabIndex = 6;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // lblNombreBots
            // 
            lblNombreBots.AutoSize = true;
            lblNombreBots.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNombreBots.Location = new System.Drawing.Point(395, 324);
            lblNombreBots.Name = "lblNombreBots";
            lblNombreBots.Size = new System.Drawing.Size(179, 28);
            lblNombreBots.TabIndex = 7;
            lblNombreBots.Text = "Nombre de bot(s)";
            // 
            // cmbNombreBots
            // 
            cmbNombreBots.BackColor = System.Drawing.SystemColors.ScrollBar;
            cmbNombreBots.FormattingEnabled = true;
            cmbNombreBots.Location = new System.Drawing.Point(583, 328);
            cmbNombreBots.Name = "cmbNombreBots";
            cmbNombreBots.Size = new System.Drawing.Size(151, 28);
            cmbNombreBots.TabIndex = 8;
            cmbNombreBots.SelectedIndexChanged += cmbNombreBots_SelectedIndexChanged;
            // 
            // btnCommencer
            // 
            btnCommencer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCommencer.Location = new System.Drawing.Point(395, 382);
            btnCommencer.Name = "btnCommencer";
            btnCommencer.Size = new System.Drawing.Size(339, 56);
            btnCommencer.TabIndex = 9;
            btnCommencer.Text = "Commencer la partie";
            btnCommencer.UseVisualStyleBackColor = true;
            // 
            // FrmAccueil
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnCommencer);
            Controls.Add(cmbNombreBots);
            Controls.Add(lblNombreBots);
            Controls.Add(btnAjouter);
            Controls.Add(txtDateNaissance);
            Controls.Add(lblDateNaissance);
            Controls.Add(txtNom);
            Controls.Add(lblNom);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Name = "FrmAccueil";
            Text = "FormAccueil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.TextBox txtDateNaissance;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblNombreBots;
        private System.Windows.Forms.ComboBox cmbNombreBots;
        private System.Windows.Forms.Button btnCommencer;
    }
}