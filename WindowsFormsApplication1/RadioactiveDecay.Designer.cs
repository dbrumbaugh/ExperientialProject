namespace NumericalMethodsInCS
{
    partial class RadioactiveDecay
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartArea = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.calculateButton = new System.Windows.Forms.Button();
            this.nucleiBox = new System.Windows.Forms.TextBox();
            this.tauBox = new System.Windows.Forms.TextBox();
            this.timestepBox = new System.Windows.Forms.TextBox();
            this.nucleiLabel = new System.Windows.Forms.Label();
            this.tauLabel = new System.Windows.Forms.Label();
            this.timestepLabel = new System.Windows.Forms.Label();
            this.nucleiError = new System.Windows.Forms.Label();
            this.tauError = new System.Windows.Forms.Label();
            this.timestepError = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartArea)).BeginInit();
            this.SuspendLayout();
            // 
            // chartArea
            // 
            chartArea1.AxisX.Maximum = 10D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chartArea.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartArea.Legends.Add(legend1);
            this.chartArea.Location = new System.Drawing.Point(12, 12);
            this.chartArea.Name = "chartArea";
            this.chartArea.Size = new System.Drawing.Size(669, 553);
            this.chartArea.TabIndex = 0;
            this.chartArea.Text = "Graphical Represenation";
            title1.Name = "Title1";
            title1.Text = "Model Results View";
            this.chartArea.Titles.Add(title1);
            // 
            // calculateButton
            // 
            this.calculateButton.Enabled = false;
            this.calculateButton.Location = new System.Drawing.Point(707, 188);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(282, 53);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Add Graph";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // nucleiBox
            // 
            this.nucleiBox.Location = new System.Drawing.Point(688, 52);
            this.nucleiBox.Name = "nucleiBox";
            this.nucleiBox.Size = new System.Drawing.Size(100, 22);
            this.nucleiBox.TabIndex = 2;
            this.nucleiBox.TextChanged += new System.EventHandler(this.nucleiBox_TextChanged);
            // 
            // tauBox
            // 
            this.tauBox.Location = new System.Drawing.Point(688, 97);
            this.tauBox.Name = "tauBox";
            this.tauBox.Size = new System.Drawing.Size(100, 22);
            this.tauBox.TabIndex = 3;
            this.tauBox.TextChanged += new System.EventHandler(this.tauBox_TextChanged);
            // 
            // timestepBox
            // 
            this.timestepBox.Location = new System.Drawing.Point(688, 146);
            this.timestepBox.Name = "timestepBox";
            this.timestepBox.Size = new System.Drawing.Size(100, 22);
            this.timestepBox.TabIndex = 4;
            this.timestepBox.TextChanged += new System.EventHandler(this.timestepBox_TextChanged);
            // 
            // nucleiLabel
            // 
            this.nucleiLabel.AutoSize = true;
            this.nucleiLabel.Location = new System.Drawing.Point(685, 32);
            this.nucleiLabel.Name = "nucleiLabel";
            this.nucleiLabel.Size = new System.Drawing.Size(166, 17);
            this.nucleiLabel.TabIndex = 5;
            this.nucleiLabel.Text = "Starting number of nuclei";
            // 
            // tauLabel
            // 
            this.tauLabel.AutoSize = true;
            this.tauLabel.Location = new System.Drawing.Point(685, 77);
            this.tauLabel.Name = "tauLabel";
            this.tauLabel.Size = new System.Drawing.Size(147, 17);
            this.tauLabel.TabIndex = 6;
            this.tauLabel.Text = "Decay Constant (Tau)";
            // 
            // timestepLabel
            // 
            this.timestepLabel.AutoSize = true;
            this.timestepLabel.Location = new System.Drawing.Point(685, 126);
            this.timestepLabel.Name = "timestepLabel";
            this.timestepLabel.Size = new System.Drawing.Size(92, 17);
            this.timestepLabel.TabIndex = 7;
            this.timestepLabel.Text = "Timestep (dt)";
            // 
            // nucleiError
            // 
            this.nucleiError.AutoSize = true;
            this.nucleiError.ForeColor = System.Drawing.Color.OrangeRed;
            this.nucleiError.Location = new System.Drawing.Point(794, 52);
            this.nucleiError.Name = "nucleiError";
            this.nucleiError.Size = new System.Drawing.Size(228, 17);
            this.nucleiError.TabIndex = 8;
            this.nucleiError.Text = "ERROR: Must be a positive integer";
            this.nucleiError.Visible = false;
            // 
            // tauError
            // 
            this.tauError.AutoSize = true;
            this.tauError.ForeColor = System.Drawing.Color.OrangeRed;
            this.tauError.Location = new System.Drawing.Point(794, 97);
            this.tauError.Name = "tauError";
            this.tauError.Size = new System.Drawing.Size(175, 17);
            this.tauError.TabIndex = 9;
            this.tauError.Text = "ERROR: Must be a double";
            this.tauError.Visible = false;
            // 
            // timestepError
            // 
            this.timestepError.AutoSize = true;
            this.timestepError.ForeColor = System.Drawing.Color.OrangeRed;
            this.timestepError.Location = new System.Drawing.Point(794, 146);
            this.timestepError.Name = "timestepError";
            this.timestepError.Size = new System.Drawing.Size(175, 17);
            this.timestepError.TabIndex = 10;
            this.timestepError.Text = "ERROR: Must be a double";
            this.timestepError.Visible = false;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(707, 248);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(282, 83);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "Reset Graph";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 577);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.timestepError);
            this.Controls.Add(this.tauError);
            this.Controls.Add(this.nucleiError);
            this.Controls.Add(this.timestepLabel);
            this.Controls.Add(this.tauLabel);
            this.Controls.Add(this.nucleiLabel);
            this.Controls.Add(this.timestepBox);
            this.Controls.Add(this.tauBox);
            this.Controls.Add(this.nucleiBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.chartArea);
            this.Name = "DisplayForm";
            this.Text = "Numerical Methods in C#";
            ((System.ComponentModel.ISupportInitialize)(this.chartArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartArea;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox nucleiBox;
        private System.Windows.Forms.TextBox tauBox;
        private System.Windows.Forms.TextBox timestepBox;
        private System.Windows.Forms.Label nucleiLabel;
        private System.Windows.Forms.Label tauLabel;
        private System.Windows.Forms.Label timestepLabel;
        private System.Windows.Forms.Label nucleiError;
        private System.Windows.Forms.Label tauError;
        private System.Windows.Forms.Label timestepError;
        private System.Windows.Forms.Button resetButton;
    }
}

