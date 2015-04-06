namespace WindowsFormsApplication1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartArea = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.velocityBox = new System.Windows.Forms.TextBox();
            this.angleBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateResistanceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartArea)).BeginInit();
            this.SuspendLayout();
            // 
            // chartArea
            // 
            chartArea1.Name = "ChartArea1";
            this.chartArea.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartArea.Legends.Add(legend1);
            this.chartArea.Location = new System.Drawing.Point(12, 12);
            this.chartArea.Name = "chartArea";
            this.chartArea.Size = new System.Drawing.Size(522, 525);
            this.chartArea.TabIndex = 0;
            this.chartArea.Text = "Projectile Motion";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(543, 225);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(170, 59);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Graph Trajectory";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Initial Velocity";
            // 
            // velocityBox
            // 
            this.velocityBox.Location = new System.Drawing.Point(543, 72);
            this.velocityBox.Name = "velocityBox";
            this.velocityBox.Size = new System.Drawing.Size(100, 22);
            this.velocityBox.TabIndex = 3;
            // 
            // angleBox
            // 
            this.angleBox.Location = new System.Drawing.Point(543, 133);
            this.angleBox.Name = "angleBox";
            this.angleBox.Size = new System.Drawing.Size(100, 22);
            this.angleBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Angle of throw";
            // 
            // calculateResistanceButton
            // 
            this.calculateResistanceButton.Location = new System.Drawing.Point(543, 291);
            this.calculateResistanceButton.Name = "calculateResistanceButton";
            this.calculateResistanceButton.Size = new System.Drawing.Size(170, 62);
            this.calculateResistanceButton.TabIndex = 6;
            this.calculateResistanceButton.Text = "Graph w/ Air Resistance";
            this.calculateResistanceButton.UseVisualStyleBackColor = true;
            this.calculateResistanceButton.Click += new System.EventHandler(this.calculateResistanceButton_Click);
            // 
            // ProjectileMotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 549);
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
    }
}