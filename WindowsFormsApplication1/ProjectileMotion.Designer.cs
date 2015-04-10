namespace NumericalMethodsInCS
{
    partial class ProjectileMotion
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartArea = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.velocityBox = new System.Windows.Forms.TextBox();
            this.angleBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateResistanceButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.bcBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.velocityErrorLabel = new System.Windows.Forms.Label();
            this.angleErrorLabel = new System.Windows.Forms.Label();
            this.bcErrorLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timestepErrorLabel = new System.Windows.Forms.Label();
            this.timestepBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartArea)).BeginInit();
            this.SuspendLayout();
            // 
            // chartArea
            // 
            chartArea2.Name = "ChartArea1";
            this.chartArea.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartArea.Legends.Add(legend2);
            this.chartArea.Location = new System.Drawing.Point(12, 12);
            this.chartArea.Name = "chartArea";
            this.chartArea.Size = new System.Drawing.Size(522, 525);
            this.chartArea.TabIndex = 0;
            this.chartArea.Text = "Projectile Motion";
            // 
            // calculateButton
            // 
            this.calculateButton.Enabled = false;
            this.calculateButton.Location = new System.Drawing.Point(752, 263);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(170, 62);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Graph Trajectory";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Initial Velocity";
            // 
            // velocityBox
            // 
            this.velocityBox.Location = new System.Drawing.Point(540, 72);
            this.velocityBox.Name = "velocityBox";
            this.velocityBox.Size = new System.Drawing.Size(100, 22);
            this.velocityBox.TabIndex = 3;
            this.velocityBox.TextChanged += new System.EventHandler(this.velocityBox_TextChanged);
            // 
            // angleBox
            // 
            this.angleBox.Location = new System.Drawing.Point(540, 117);
            this.angleBox.Name = "angleBox";
            this.angleBox.Size = new System.Drawing.Size(100, 22);
            this.angleBox.TabIndex = 4;
            this.angleBox.TextChanged += new System.EventHandler(this.angleBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Angle of throw";
            // 
            // calculateResistanceButton
            // 
            this.calculateResistanceButton.Enabled = false;
            this.calculateResistanceButton.Location = new System.Drawing.Point(540, 263);
            this.calculateResistanceButton.Name = "calculateResistanceButton";
            this.calculateResistanceButton.Size = new System.Drawing.Size(170, 62);
            this.calculateResistanceButton.TabIndex = 6;
            this.calculateResistanceButton.Text = "Graph w/ Air Resistance";
            this.calculateResistanceButton.UseVisualStyleBackColor = true;
            this.calculateResistanceButton.Click += new System.EventHandler(this.calculateResistanceButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(543, 331);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(379, 77);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset Chart Area";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // bcBox
            // 
            this.bcBox.Location = new System.Drawing.Point(540, 162);
            this.bcBox.Name = "bcBox";
            this.bcBox.Size = new System.Drawing.Size(100, 22);
            this.bcBox.TabIndex = 8;
            this.bcBox.TextChanged += new System.EventHandler(this.bcBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ballistic Coefficent";
            // 
            // velocityErrorLabel
            // 
            this.velocityErrorLabel.AutoSize = true;
            this.velocityErrorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.velocityErrorLabel.Location = new System.Drawing.Point(646, 72);
            this.velocityErrorLabel.Name = "velocityErrorLabel";
            this.velocityErrorLabel.Size = new System.Drawing.Size(263, 17);
            this.velocityErrorLabel.TabIndex = 10;
            this.velocityErrorLabel.Text = "ERROR: Velocity must be greater than 0";
            this.velocityErrorLabel.Visible = false;
            // 
            // angleErrorLabel
            // 
            this.angleErrorLabel.AutoSize = true;
            this.angleErrorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.angleErrorLabel.Location = new System.Drawing.Point(646, 117);
            this.angleErrorLabel.Name = "angleErrorLabel";
            this.angleErrorLabel.Size = new System.Drawing.Size(267, 17);
            this.angleErrorLabel.TabIndex = 11;
            this.angleErrorLabel.Text = "ERROR: Angle must be on interval (0,90]";
            this.angleErrorLabel.Visible = false;
            // 
            // bcErrorLabel
            // 
            this.bcErrorLabel.AutoSize = true;
            this.bcErrorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.bcErrorLabel.Location = new System.Drawing.Point(646, 162);
            this.bcErrorLabel.Name = "bcErrorLabel";
            this.bcErrorLabel.Size = new System.Drawing.Size(232, 17);
            this.bcErrorLabel.TabIndex = 12;
            this.bcErrorLabel.Text = "ERROR: BC must be greater than 0";
            this.bcErrorLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Timestep";
            // 
            // timestepErrorLabel
            // 
            this.timestepErrorLabel.AutoSize = true;
            this.timestepErrorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.timestepErrorLabel.Location = new System.Drawing.Point(646, 207);
            this.timestepErrorLabel.Name = "timestepErrorLabel";
            this.timestepErrorLabel.Size = new System.Drawing.Size(276, 17);
            this.timestepErrorLabel.TabIndex = 14;
            this.timestepErrorLabel.Text = "ERROR: Timestep must be greater than 0.";
            this.timestepErrorLabel.Visible = false;
            // 
            // timestepBox
            // 
            this.timestepBox.Location = new System.Drawing.Point(540, 207);
            this.timestepBox.Name = "timestepBox";
            this.timestepBox.Size = new System.Drawing.Size(100, 22);
            this.timestepBox.TabIndex = 15;
            this.timestepBox.TextChanged += new System.EventHandler(this.timestepBox_TextChanged);
            // 
            // ProjectileMotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 549);
            this.Controls.Add(this.timestepBox);
            this.Controls.Add(this.timestepErrorLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bcErrorLabel);
            this.Controls.Add(this.angleErrorLabel);
            this.Controls.Add(this.velocityErrorLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bcBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calculateResistanceButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.angleBox);
            this.Controls.Add(this.velocityBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.chartArea);
            this.Name = "ProjectileMotion";
            this.Text = "NMC#: Projectile Motion";
            ((System.ComponentModel.ISupportInitialize)(this.chartArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartArea;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox velocityBox;
        private System.Windows.Forms.TextBox angleBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateResistanceButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox bcBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label velocityErrorLabel;
        private System.Windows.Forms.Label angleErrorLabel;
        private System.Windows.Forms.Label bcErrorLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label timestepErrorLabel;
        private System.Windows.Forms.TextBox timestepBox;
    }
}