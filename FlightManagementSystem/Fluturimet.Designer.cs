
namespace FlightManagementSystem
{
    partial class Fluturimet
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
            this.buttonViewFlights = new System.Windows.Forms.Button();
            this.labelAddFlights = new System.Windows.Forms.Label();
            this.flightID = new System.Windows.Forms.Label();
            this.labelSource = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelTakeOff = new System.Windows.Forms.Label();
            this.textBoxFlightID = new System.Windows.Forms.TextBox();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.textBoxTakeOff = new System.Windows.Forms.TextBox();
            this.buttonAddFlight = new System.Windows.Forms.Button();
            this.labelNumPassengers = new System.Windows.Forms.Label();
            this.textBoxNumPassengers = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonViewFlights
            // 
            this.buttonViewFlights.Location = new System.Drawing.Point(519, 250);
            this.buttonViewFlights.Name = "buttonViewFlights";
            this.buttonViewFlights.Size = new System.Drawing.Size(176, 30);
            this.buttonViewFlights.TabIndex = 3;
            this.buttonViewFlights.Text = "Shiko fluturimet";
            this.buttonViewFlights.UseVisualStyleBackColor = true;
            this.buttonViewFlights.Click += new System.EventHandler(this.buttonViewFlights_Click);
            // 
            // labelAddFlights
            // 
            this.labelAddFlights.AutoSize = true;
            this.labelAddFlights.Location = new System.Drawing.Point(348, 29);
            this.labelAddFlights.Name = "labelAddFlights";
            this.labelAddFlights.Size = new System.Drawing.Size(347, 17);
            this.labelAddFlights.TabIndex = 4;
            this.labelAddFlights.Text = "Shto/modifiko fluturimin (ID duhet te jete nje karakter):";
            // 
            // flightID
            // 
            this.flightID.AutoSize = true;
            this.flightID.Location = new System.Drawing.Point(447, 73);
            this.flightID.Name = "flightID";
            this.flightID.Size = new System.Drawing.Size(25, 17);
            this.flightID.TabIndex = 5;
            this.flightID.Text = "ID:";
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(377, 104);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(95, 17);
            this.labelSource.TabIndex = 6;
            this.labelSource.Text = "Vendi i nisjes:";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(383, 140);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(89, 17);
            this.labelDestination.TabIndex = 7;
            this.labelDestination.Text = "Destinacioni:";
            // 
            // labelTakeOff
            // 
            this.labelTakeOff.AutoSize = true;
            this.labelTakeOff.Location = new System.Drawing.Point(378, 175);
            this.labelTakeOff.Name = "labelTakeOff";
            this.labelTakeOff.Size = new System.Drawing.Size(94, 17);
            this.labelTakeOff.TabIndex = 8;
            this.labelTakeOff.Text = "Data e nisjes:";
            // 
            // textBoxFlightID
            // 
            this.textBoxFlightID.Location = new System.Drawing.Point(478, 73);
            this.textBoxFlightID.Name = "textBoxFlightID";
            this.textBoxFlightID.Size = new System.Drawing.Size(148, 22);
            this.textBoxFlightID.TabIndex = 9;
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(478, 104);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(148, 22);
            this.textBoxSource.TabIndex = 10;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(478, 137);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(148, 22);
            this.textBoxDestination.TabIndex = 11;
            // 
            // textBoxTakeOff
            // 
            this.textBoxTakeOff.Location = new System.Drawing.Point(478, 175);
            this.textBoxTakeOff.Name = "textBoxTakeOff";
            this.textBoxTakeOff.Size = new System.Drawing.Size(148, 22);
            this.textBoxTakeOff.TabIndex = 12;
            // 
            // buttonAddFlight
            // 
            this.buttonAddFlight.Location = new System.Drawing.Point(337, 250);
            this.buttonAddFlight.Name = "buttonAddFlight";
            this.buttonAddFlight.Size = new System.Drawing.Size(176, 30);
            this.buttonAddFlight.TabIndex = 13;
            this.buttonAddFlight.Text = "Shto fluturimin";
            this.buttonAddFlight.UseVisualStyleBackColor = true;
            this.buttonAddFlight.Click += new System.EventHandler(this.buttonAddFlight_Click);
            // 
            // labelNumPassengers
            // 
            this.labelNumPassengers.AutoSize = true;
            this.labelNumPassengers.Location = new System.Drawing.Point(334, 205);
            this.labelNumPassengers.Name = "labelNumPassengers";
            this.labelNumPassengers.Size = new System.Drawing.Size(138, 17);
            this.labelNumPassengers.TabIndex = 14;
            this.labelNumPassengers.Text = "Numri i pasagjereve:";
            // 
            // textBoxNumPassengers
            // 
            this.textBoxNumPassengers.Location = new System.Drawing.Point(478, 206);
            this.textBoxNumPassengers.Name = "textBoxNumPassengers";
            this.textBoxNumPassengers.Size = new System.Drawing.Size(148, 22);
            this.textBoxNumPassengers.TabIndex = 15;
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
            // Fluturimet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 320);
            this.Controls.Add(this.textBoxNumPassengers);
            this.Controls.Add(this.labelNumPassengers);
            this.Controls.Add(this.buttonAddFlight);
            this.Controls.Add(this.textBoxTakeOff);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.textBoxFlightID);
            this.Controls.Add(this.labelTakeOff);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.flightID);
            this.Controls.Add(this.labelAddFlights);
            this.Controls.Add(this.buttonViewFlights);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Fluturimet";
            this.Text = "Fluturimet";
            this.Load += new System.EventHandler(this.Fluturimet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonViewFlights;
        private System.Windows.Forms.Label labelAddFlights;
        private System.Windows.Forms.Label flightID;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labelTakeOff;
        private System.Windows.Forms.TextBox textBoxFlightID;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.TextBox textBoxTakeOff;
        private System.Windows.Forms.Button buttonAddFlight;
        private System.Windows.Forms.Label labelNumPassengers;
        private System.Windows.Forms.TextBox textBoxNumPassengers;
    }
}