namespace NumericalMethodsInCS
{
    partial class VelocityModel
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.standardButton = new System.Windows.Forms.Button();
            this.resistanceModelButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.velocityBox = new System.Windows.Forms.TextBox();
            this.maxtimeBox = new System.Windows.Forms.TextBox();
            this.bcBox = new System.Windows.Forms.TextBox();
            this.timestepBox = new System.Windows.Forms.TextBox();
            this.velocityLabel = new System.Windows.Forms.Label();
            this.bcLabel = new System.Windows.Forms.Label();
            this.timestepLabel = new System.Windows.Forms.Label();
            this.maxTimeLabel = new System.Windows.Forms.Label();
            this.velocityErrorLabel = new System.Windows.Forms.Label();
            this.bcErrorLabel = new System.Windows.Forms.Label();
            this.timestepErrorLabel = new System.Windows.Forms.Label();
            this.maxtimeErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // standardButton
            // 
            this.standardButton.Enabled = false;
            this.standardButton.Location = new System.Drawing.Point(515, 251);
            this.standardButton.Name = "standardButton";
            this.standardButton.Size = new System.Drawing.Size(129, 48);
            this.standardButton.TabIndex = 0;
            this.standardButton.Text = "Standard Model";
            this.standardButton.UseVisualStyleBackColor = true;
            this.standardButton.Click += new System.EventHandler(this.standardButton_Click);
            // 
            // resistanceModelButton
            // 
            this.resistanceModelButton.Enabled = false;
            this.resistanceModelButton.Location = new System.Drawing.Point(669, 251);
            this.resistanceModelButton.Name = "resistanceModelButton";
            this.resistanceModelButton.Size = new System.Drawing.Size(129, 48);
            this.resistanceModelButton.TabIndex = 1;
            this.resistanceModelButton.Text = "Air Resistance Model";
            this.resistanceModelButton.UseVisualStyleBackColor = true;
            this.resistanceModelButton.Click += new System.EventHandler(this.resistanceModelButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(511, 305);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(287, 64);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // chart1
            // 
            chartArea11.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chart1.Legends.Add(legend11);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(493, 587);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // velocityBox
            // 
            this.velocityBox.Location = new System.Drawing.Point(525, 59);
            this.velocityBox.Name = "velocityBox";
            this.velocityBox.Size = new System.Drawing.Size(100, 22);
            this.velocityBox.TabIndex = 4;
            this.velocityBox.Text = "0";
            this.velocityBox.TextChanged += new System.EventHandler(this.velocityBox_TextChanged);
            // 
            // maxtimeBox
            // 
            this.maxtimeBox.Location = new System.Drawing.Point(525, 194);
            this.maxtimeBox.Name = "maxtimeBox";
            this.maxtimeBox.Size = new System.Drawing.Size(100, 22);
            this.maxtimeBox.TabIndex = 5;
            this.maxtimeBox.TextChanged += new System.EventHandler(this.maxtimeBox_TextChanged);
            // 
            // bcBox
            // 
            this.bcBox.Location = new System.Drawing.Point(525, 104);
            this.bcBox.Name = "bcBox";
            this.bcBox.Size = new System.Drawing.Size(100, 22);
            this.bcBox.TabIndex = 6;
            this.bcBox.TextChanged += new System.EventHandler(this.bcBox_TextChanged);
            // 
            // timestepBox
            // 
            this.timestepBox.Location = new System.Drawing.Point(525, 149);
            this.timestepBox.Name = "timestepBox";
            this.timestepBox.Size = new System.Drawing.Size(100, 22);
            this.timestepBox.TabIndex = 7;
            this.timestepBox.TextChanged += new System.EventHandler(this.timestepBox_TextChanged);
            // 
            // velocityLabel
            // 
            this.velocityLabel.AutoSize = true;
            this.velocityLabel.Location = new System.Drawing.Point(522, 39);
            this.velocityLabel.Name = "velocityLabel";
            this.velocityLabel.Size = new System.Drawing.Size(93, 17);
            this.velocityLabel.TabIndex = 8;
            this.velocityLabel.Text = "Initial Velocity";
            // 
            // bcLabel
            // 
            this.bcLabel.AutoSize = true;
            this.bcLabel.Location = new System.Drawing.Point(522, 84);
            this.bcLabel.Name = "bcLabel";
            this.bcLabel.Size = new System.Drawing.Size(122, 17);
            this.bcLabel.TabIndex = 9;
            this.bcLabel.Text = "Ballistic Coefficent";
            // 
            // timestepLabel
            // 
            this.timestepLabel.AutoSize = true;
            this.timestepLabel.Location = new System.Drawing.Point(522, 129);
            this.timestepLabel.Name = "timestepLabel";
            this.timestepLabel.Size = new System.Drawing.Size(66, 17);
            this.timestepLabel.TabIndex = 10;
            this.timestepLabel.Text = "Timestep";
            // 
            // maxTimeLabel
            // 
            this.maxTimeLabel.AutoSize = true;
            this.maxTimeLabel.Location = new System.Drawing.Point(522, 174);
            this.maxTimeLabel.Name = "maxTimeLabel";
            this.maxTimeLabel.Size = new System.Drawing.Size(68, 17);
            this.maxTimeLabel.TabIndex = 11;
            this.maxTimeLabel.Text = "Max Time";
            // 
            // velocityErrorLabel
            // 
            this.velocityErrorLabel.AutoSize = true;
            this.velocityErrorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.velocityErrorLabel.Location = new System.Drawing.Point(632, 64);
            this.velocityErrorLabel.Name = "velocityErrorLabel";
            this.velocityErrorLabel.Size = new System.Drawing.Size(270, 17);
            this.velocityErrorLabel.TabIndex = 12;
            this.velocityErrorLabel.Text = "ERROR: Velocity must be a valid number.";
            this.velocityErrorLabel.Visible = false;
            // 
            // bcErrorLabel
            // 
            this.bcErrorLabel.AutoSize = true;
            this.bcErrorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.bcErrorLabel.Location = new System.Drawing.Point(632, 108);
            this.bcErrorLabel.Name = "bcErrorLabel";
            this.bcErrorLabel.Size = new System.Drawing.Size(242, 17);
            this.bcErrorLabel.TabIndex = 13;
            this.bcErrorLabel.Text = "ERROR: BC must be on interval (0,1)";
            this.bcErrorLabel.Visible = false;
            // 
            // timestepErrorLabel
            // 
            this.timestepErrorLabel.AutoSize = true;
            this.timestepErrorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.timestepErrorLabel.Location = new System.Drawing.Point(632, 152);
            this.timestepErrorLabel.Name = "timestepErrorLabel";
            this.timestepErrorLabel.Size = new System.Drawing.Size(292, 17);
            this.timestepErrorLabel.TabIndex = 14;
            this.timestepErrorLabel.Text = "ERROR: Timestep must be greater than zero";
            this.timestepErrorLabel.Visible = false;
            // 
            // maxtimeErrorLabel
            // 
            this.maxtimeErrorLabel.AutoSize = true;
            this.maxtimeErrorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.maxtimeErrorLabel.Location = new System.Drawing.Point(632, 198);
            this.maxtimeErrorLabel.Name = "maxtimeErrorLabel";
            this.maxtimeErrorLabel.Size = new System.Drawing.Size(289, 17);
            this.maxtimeErrorLabel.TabIndex = 15;
            this.maxtimeErrorLabel.Text = "ERROR: Max time must be greater than zero";
            this.maxtimeErrorLabel.Visible = false;
            // 
            // VelocityModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 611);
            this.Controls.Add(this.maxtimeErrorLabel);
            this.Controls.Add(this.timestepErrorLabel);
            this.Controls.Add(this.bcErrorLabel);
            this.Controls.Add(this.velocityErrorLabel);
            this.Controls.Add(this.maxTimeLabel);
            this.Controls.Add(this.timestepLabel);
            this.Controls.Add(this.bcLabel);
            this.Controls.Add(this.velocityLabel);
            this.Controls.Add(this.timestepBox);
            this.Controls.Add(this.bcBox);
            this.Controls.Add(this.maxtimeBox);
            this.Controls.Add(this.velocityBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.resistanceModelButton);
            this.Controls.Add(this.standardButton);
            this.Name = "VelocityModel";
            this.Text = "NMC#: Velocity Model";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button standardButton;
        private System.Windows.Forms.Button resistanceModelButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox velocityBox;
        private System.Windows.Forms.TextBox maxtimeBox;
        private System.Windows.Forms.TextBox bcBox;
        private System.Windows.Forms.TextBox timestepBox;
        private System.Windows.Forms.Label velocityLabel;
        private System.Windows.Forms.Label bcLabel;
        private System.Windows.Forms.Label timestepLabel;
        private System.Windows.Forms.Label maxTimeLabel;
        private System.Windows.Forms.Label velocityErrorLabel;
        private System.Windows.Forms.Label bcErrorLabel;
        private System.Windows.Forms.Label timestepErrorLabel;
        private System.Windows.Forms.Label maxtimeErrorLabel;
    }
}