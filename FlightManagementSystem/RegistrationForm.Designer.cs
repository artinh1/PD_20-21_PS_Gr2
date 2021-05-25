
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagementSystem
{
    partial class RegistrationForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxUserReg = new System.Windows.Forms.TextBox();
            this.textBoxPasswordReg = new System.Windows.Forms.TextBox();
            this.buttonRegister2 = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlightManagementSystem.Properties.Resources._1200px_AirportiPrishtines_svg;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 183);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(336, 127);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(42, 17);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "User:";
            // 
            // textBoxUserReg
            // 
            this.textBoxUserReg.Location = new System.Drawing.Point(384, 127);
            this.textBoxUserReg.Name = "textBoxUserReg";
            this.textBoxUserReg.Size = new System.Drawing.Size(138, 22);
            this.textBoxUserReg.TabIndex = 4;
            // 
            // textBoxPasswordReg
            // 
            this.textBoxPasswordReg.Location = new System.Drawing.Point(384, 155);
            this.textBoxPasswordReg.Name = "textBoxPasswordReg";
            this.textBoxPasswordReg.Size = new System.Drawing.Size(138, 22);
            this.textBoxPasswordReg.TabIndex = 5;
            // 
            // buttonRegister2
            // 
            this.buttonRegister2.Location = new System.Drawing.Point(403, 194);
            this.buttonRegister2.Name = "buttonRegister2";
            this.buttonRegister2.Size = new System.Drawing.Size(103, 23);
            this.buttonRegister2.TabIndex = 7;
            this.buttonRegister2.Text = "Regjistrohu";
            this.buttonRegister2.UseVisualStyleBackColor = true;
            this.buttonRegister2.Click += new System.EventHandler(this.buttonRegister2_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(301, 158);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(77, 17);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Fjalekalimi:";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 316);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.buttonRegister2);
            this.Controls.Add(this.textBoxPasswordReg);
            this.Controls.Add(this.textBoxUserReg);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxUserReg;
        private System.Windows.Forms.TextBox textBoxPasswordReg;
        private System.Windows.Forms.Button buttonRegister2;
        private System.Windows.Forms.Label labelPassword;

       
    }
}