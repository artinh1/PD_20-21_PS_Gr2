
namespace FlightManagementSystem
{
    partial class ShikoFluturimet
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
            this.dataGridFlights = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takeOffDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPassengersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDeleteRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFlights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFlights
            // 
            this.dataGridFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFlights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.SourceColumn,
            this.DestinationColumn,
            this.takeOffDateColumn,
            this.NumPassengersColumn});
            this.dataGridFlights.Location = new System.Drawing.Point(12, 151);
            this.dataGridFlights.Name = "dataGridFlights";
            this.dataGridFlights.ReadOnly = true;
            this.dataGridFlights.RowHeadersWidth = 51;
            this.dataGridFlights.RowTemplate.Height = 24;
            this.dataGridFlights.Size = new System.Drawing.Size(741, 265);
            this.dataGridFlights.TabIndex = 4;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MinimumWidth = 6;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Width = 125;
            // 
            // SourceColumn
            // 
            this.SourceColumn.HeaderText = "Vendi i nisjes";
            this.SourceColumn.MinimumWidth = 6;
            this.SourceColumn.Name = "SourceColumn";
            this.SourceColumn.ReadOnly = true;
            this.SourceColumn.Width = 125;
            // 
            // DestinationColumn
            // 
            this.DestinationColumn.HeaderText = "Destinacioni";
            this.DestinationColumn.MinimumWidth = 6;
            this.DestinationColumn.Name = "DestinationColumn";
            this.DestinationColumn.ReadOnly = true;
            this.DestinationColumn.Width = 125;
            // 
            // takeOffDateColumn
            // 
            this.takeOffDateColumn.HeaderText = "Data e nisjes";
            this.takeOffDateColumn.MinimumWidth = 6;
            this.takeOffDateColumn.Name = "takeOffDateColumn";
            this.takeOffDateColumn.ReadOnly = true;
            this.takeOffDateColumn.Width = 125;
            // 
            // NumPassengersColumn
            // 
            this.NumPassengersColumn.HeaderText = "Numri i pasagjereve";
            this.NumPassengersColumn.MinimumWidth = 6;
            this.NumPassengersColumn.Name = "NumPassengersColumn";
            this.NumPassengersColumn.ReadOnly = true;
            this.NumPassengersColumn.Width = 125;
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
            // buttonDeleteRecord
            // 
            this.buttonDeleteRecord.Location = new System.Drawing.Point(301, 431);
            this.buttonDeleteRecord.Name = "buttonDeleteRecord";
            this.buttonDeleteRecord.Size = new System.Drawing.Size(158, 30);
            this.buttonDeleteRecord.TabIndex = 5;
            this.buttonDeleteRecord.Text = "Fshij fluturimin";
            this.buttonDeleteRecord.UseVisualStyleBackColor = true;
            this.buttonDeleteRecord.Click += new System.EventHandler(this.buttonDeleteRecord_Click);
            // 
            // ShikoFluturimet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 587);
            this.Controls.Add(this.buttonDeleteRecord);
            this.Controls.Add(this.dataGridFlights);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ShikoFluturimet";
            this.Text = "ShikoFluturimet";
            this.Load += new System.EventHandler(this.ShikoFluturimet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFlights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridFlights;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn takeOffDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPassengersColumn;
        private System.Windows.Forms.Button buttonDeleteRecord;
    }
}