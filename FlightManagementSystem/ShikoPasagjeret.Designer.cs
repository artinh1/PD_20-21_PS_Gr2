
namespace FlightManagementSystem
{
    partial class ShikoPasagjeret
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
            this.dataGridViewPassengers = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ColumnPassengerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPassengerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPassengerSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeletePassenger = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassengers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPassengers
            // 
            this.dataGridViewPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPassengers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPassengerID,
            this.ColumnPassengerName,
            this.ColumnPassengerSurname,
            this.ColumnEmail,
            this.ColumnPhone});
            this.dataGridViewPassengers.Location = new System.Drawing.Point(12, 185);
            this.dataGridViewPassengers.Name = "dataGridViewPassengers";
            this.dataGridViewPassengers.RowHeadersWidth = 51;
            this.dataGridViewPassengers.RowTemplate.Height = 24;
            this.dataGridViewPassengers.Size = new System.Drawing.Size(754, 237);
            this.dataGridViewPassengers.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlightManagementSystem.Properties.Resources._1200px_AirportiPrishtines_svg;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 133);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ColumnPassengerID
            // 
            this.ColumnPassengerID.HeaderText = "ID";
            this.ColumnPassengerID.MinimumWidth = 6;
            this.ColumnPassengerID.Name = "ColumnPassengerID";
            this.ColumnPassengerID.Width = 125;
            // 
            // ColumnPassengerName
            // 
            this.ColumnPassengerName.HeaderText = "Emri";
            this.ColumnPassengerName.MinimumWidth = 6;
            this.ColumnPassengerName.Name = "ColumnPassengerName";
            this.ColumnPassengerName.Width = 125;
            // 
            // ColumnPassengerSurname
            // 
            this.ColumnPassengerSurname.HeaderText = "Mbiemri";
            this.ColumnPassengerSurname.MinimumWidth = 6;
            this.ColumnPassengerSurname.Name = "ColumnPassengerSurname";
            this.ColumnPassengerSurname.Width = 125;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.MinimumWidth = 6;
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.Width = 125;
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.HeaderText = "Tel";
            this.ColumnPhone.MinimumWidth = 6;
            this.ColumnPhone.Name = "ColumnPhone";
            this.ColumnPhone.Width = 125;
            // 
            // buttonDeletePassenger
            // 
            this.buttonDeletePassenger.Location = new System.Drawing.Point(99, 445);
            this.buttonDeletePassenger.Name = "buttonDeletePassenger";
            this.buttonDeletePassenger.Size = new System.Drawing.Size(131, 30);
            this.buttonDeletePassenger.TabIndex = 5;
            this.buttonDeletePassenger.Text = "Fshij pasagjerin";
            this.buttonDeletePassenger.UseVisualStyleBackColor = true;
            this.buttonDeletePassenger.Click += new System.EventHandler(this.buttonDeletePassenger_Click);
            // 
            // ShikoPasagjeret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 517);
            this.Controls.Add(this.buttonDeletePassenger);
            this.Controls.Add(this.dataGridViewPassengers);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ShikoPasagjeret";
            this.Text = "ShikoPasagjeret";
            this.Load += new System.EventHandler(this.ShikoPasagjeret_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassengers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewPassengers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPassengerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPassengerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPassengerSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.Button buttonDeletePassenger;
    }
}