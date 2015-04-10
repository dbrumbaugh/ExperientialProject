namespace NumericalMethodsInCS
{
    partial class LandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            this.decayButton = new System.Windows.Forms.Button();
            this.projectileButton = new System.Windows.Forms.Button();
            this.velocityButton = new System.Windows.Forms.Button();
            this.mainpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // decayButton
            // 
            this.decayButton.Location = new System.Drawing.Point(7, 51);
            this.decayButton.Name = "decayButton";
            this.decayButton.Size = new System.Drawing.Size(215, 74);
            this.decayButton.TabIndex = 0;
            this.decayButton.Text = "Radioactive Decay";
            this.decayButton.UseVisualStyleBackColor = true;
            this.decayButton.Click += new System.EventHandler(this.decayButton_Click);
            // 
            // projectileButton
            // 
            this.projectileButton.Location = new System.Drawing.Point(7, 131);
            this.projectileButton.Name = "projectileButton";
            this.projectileButton.Size = new System.Drawing.Size(215, 74);
            this.projectileButton.TabIndex = 1;
            this.projectileButton.Text = "Projectile Motion";
            this.projectileButton.UseVisualStyleBackColor = true;
            this.projectileButton.Click += new System.EventHandler(this.projectileButton_Click);
            // 
            // velocityButton
            // 
            this.velocityButton.Location = new System.Drawing.Point(7, 211);
            this.velocityButton.Name = "velocityButton";
            this.velocityButton.Size = new System.Drawing.Size(215, 74);
            this.velocityButton.TabIndex = 2;
            this.velocityButton.Text = "Velocity Model";
            this.velocityButton.UseVisualStyleBackColor = true;
            this.velocityButton.Click += new System.EventHandler(this.velocityButton_Click);
            // 
            // mainpictureBox
            // 
            this.mainpictureBox.Image = global::NumericalMethodsInCS.Properties.Resources.main;
            this.mainpictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("mainpictureBox.InitialImage")));
            this.mainpictureBox.Location = new System.Drawing.Point(242, 12);
            this.mainpictureBox.Name = "mainpictureBox";
            this.mainpictureBox.Size = new System.Drawing.Size(266, 273);
            this.mainpictureBox.TabIndex = 3;
            this.mainpictureBox.TabStop = false;
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 297);
            this.Controls.Add(this.mainpictureBox);
            this.Controls.Add(this.velocityButton);
            this.Controls.Add(this.projectileButton);
            this.Controls.Add(this.decayButton);
            this.Name = "LandingPage";
            this.Text = "Numerical Methods in C#";
            ((System.ComponentModel.ISupportInitialize)(this.mainpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button decayButton;
        private System.Windows.Forms.Button projectileButton;
        private System.Windows.Forms.Button velocityButton;
        private System.Windows.Forms.PictureBox mainpictureBox;
    }
}