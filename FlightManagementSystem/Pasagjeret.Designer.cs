
namespace FlightManagementSystem
{
    partial class Pasagjeret
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
            this.labelAddPassenger = new System.Windows.Forms.Label();
            this.labelPassengerID = new System.Windows.Forms.Label();
            this.labelPassengerName = new System.Windows.Forms.Label();
            this.labelPassengerSurname = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPassengerID = new System.Windows.Forms.TextBox();
            this.textBoxPassengerName = new System.Windows.Forms.TextBox();
            this.textBoxPassengerSurname = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonAddPassenger = new System.Windows.Forms.Button();
            this.buttonViewPassengers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddPassenger
            // 
            this.labelAddPassenger.AutoSize = true;
            this.labelAddPassenger.Location = new System.Drawing.Point(400, 36);
            this.labelAddPassenger.Name = "labelAddPassenger";
            this.labelAddPassenger.Size = new System.Drawing.Size(356, 17);
            this.labelAddPassenger.TabIndex = 4;
            this.labelAddPassenger.Text = "Shto/modifiko pasagjerin (ID duhet te jete nje karakter):";
            // 
            // labelPassengerID
            // 
            this.labelPassengerID.AutoSize = true;
            this.labelPassengerID.Location = new System.Drawing.Point(485, 76);
            this.labelPassengerID.Name = "labelPassengerID";
            this.labelPassengerID.Size = new System.Drawing.Size(25, 17);
            this.labelPassengerID.TabIndex = 5;
            this.labelPassengerID.Text = "ID:";
            // 
            // labelPassengerName
            // 
            this.labelPassengerName.AutoSize = true;
            this.labelPassengerName.Location = new System.Drawing.Point(470, 106);
            this.labelPassengerName.Name = "labelPassengerName";
            this.labelPassengerName.Size = new System.Drawing.Size(40, 17);
            this.labelPassengerName.TabIndex = 6;
            this.labelPassengerName.Text = "Emri:";
            // 
            // labelPassengerSurname
            // 
            this.labelPassengerSurname.AutoSize = true;
            this.labelPassengerSurname.Location = new System.Drawing.Point(449, 137);
            this.labelPassengerSurname.Name = "labelPassengerSurname";
            this.labelPassengerSurname.Size = new System.Drawing.Size(61, 17);
            this.labelPassengerSurname.TabIndex = 7;
            this.labelPassengerSurname.Text = "Mbiemri:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(464, 169);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 17);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(478, 198);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(32, 17);
            this.labelPhone.TabIndex = 9;
            this.labelPhone.Text = "Tel:";
            // 
            // textBoxPassengerID
            // 
            this.textBoxPassengerID.Location = new System.Drawing.Point(535, 76);
            this.textBoxPassengerID.Name = "textBoxPassengerID";
            this.textBoxPassengerID.Size = new System.Drawing.Size(143, 22);
            this.textBoxPassengerID.TabIndex = 10;
            // 
            // textBoxPassengerName
            // 
            this.textBoxPassengerName.Location = new System.Drawing.Point(535, 104);
            this.textBoxPassengerName.Name = "textBoxPassengerName";
            this.textBoxPassengerName.Size = new System.Drawing.Size(143, 22);
            this.textBoxPassengerName.TabIndex = 11;
            // 
            // textBoxPassengerSurname
            // 
            this.textBoxPassengerSurname.Location = new System.Drawing.Point(535, 134);
            this.textBoxPassengerSurname.Name = "textBoxPassengerSurname";
            this.textBoxPassengerSurname.Size = new System.Drawing.Size(143, 22);
            this.textBoxPassengerSurname.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(535, 169);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(143, 22);
            this.textBoxEmail.TabIndex = 13;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(535, 198);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(143, 22);
            this.textBoxPhone.TabIndex = 14;
            // 
            // buttonAddPassenger
            // 
            this.buttonAddPassenger.Location = new System.Drawing.Point(397, 248);
            this.buttonAddPassenger.Name = "buttonAddPassenger";
            this.buttonAddPassenger.Size = new System.Drawing.Size(176, 30);
            this.buttonAddPassenger.TabIndex = 15;
            this.buttonAddPassenger.Text = "Shto pasagjerin";
            this.buttonAddPassenger.UseVisualStyleBackColor = true;
            this.buttonAddPassenger.Click += new System.EventHandler(this.buttonAddPassenger_Click);
            // 
            // buttonViewPassengers
            // 
            this.buttonViewPassengers.Location = new System.Drawing.Point(579, 248);
            this.buttonViewPassengers.Name = "buttonViewPassengers";
            this.buttonViewPassengers.Size = new System.Drawing.Size(177, 30);
            this.buttonViewPassengers.TabIndex = 16;
            this.buttonViewPassengers.Text = "Shiko pasagjeret";
            this.buttonViewPassengers.UseVisualStyleBackColor = true;
            this.buttonViewPassengers.Click += new System.EventHandler(this.buttonViewPassengers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlightManagementSystem.Properties.Resources._1200px_AirportiPrishtines_svg;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 133);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Pasagjeret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.Controls.Add(this.buttonViewPassengers);
            this.Controls.Add(this.buttonAddPassenger);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPassengerSurname);
            this.Controls.Add(this.textBoxPassengerName);
            this.Controls.Add(this.textBoxPassengerID);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPassengerSurname);
            this.Controls.Add(this.labelPassengerName);
            this.Controls.Add(this.labelPassengerID);
            this.Controls.Add(this.labelAddPassenger);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Pasagjeret";
            this.Text = "Pasagjeret";
            this.Load += new System.EventHandler(this.Pasagjeret_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAddPassenger;
        private System.Windows.Forms.Label labelPassengerID;
        private System.Windows.Forms.Label labelPassengerName;
        private System.Windows.Forms.Label labelPassengerSurname;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPassengerID;
        private System.Windows.Forms.TextBox textBoxPassengerName;
        private System.Windows.Forms.TextBox textBoxPassengerSurname;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonAddPassenger;
        private System.Windows.Forms.Button buttonViewPassengers;
    }
}