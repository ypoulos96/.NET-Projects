namespace Poulos_Assign6
{
    partial class Form1
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
            this.exitButton = new System.Windows.Forms.Button();
            this.graph1Button = new System.Windows.Forms.Button();
            this.graph2Button = new System.Windows.Forms.Button();
            this.graph3Button = new System.Windows.Forms.Button();
            this.graph4Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(139, 146);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 28);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // graph1Button
            // 
            this.graph1Button.Location = new System.Drawing.Point(18, 88);
            this.graph1Button.Name = "graph1Button";
            this.graph1Button.Size = new System.Drawing.Size(75, 23);
            this.graph1Button.TabIndex = 1;
            this.graph1Button.Text = "Pie Chart";
            this.graph1Button.UseVisualStyleBackColor = true;
            this.graph1Button.Click += new System.EventHandler(this.graph1Button_Click);
            // 
            // graph2Button
            // 
            this.graph2Button.Location = new System.Drawing.Point(99, 88);
            this.graph2Button.Name = "graph2Button";
            this.graph2Button.Size = new System.Drawing.Size(75, 23);
            this.graph2Button.TabIndex = 2;
            this.graph2Button.Text = "Bar Graph";
            this.graph2Button.UseVisualStyleBackColor = true;
            this.graph2Button.Click += new System.EventHandler(this.graph2Button_Click);
            // 
            // graph3Button
            // 
            this.graph3Button.Location = new System.Drawing.Point(180, 88);
            this.graph3Button.Name = "graph3Button";
            this.graph3Button.Size = new System.Drawing.Size(75, 23);
            this.graph3Button.TabIndex = 3;
            this.graph3Button.Text = "Line Graph";
            this.graph3Button.UseVisualStyleBackColor = true;
            this.graph3Button.Click += new System.EventHandler(this.graph3Button_Click);
            // 
            // graph4Button
            // 
            this.graph4Button.Location = new System.Drawing.Point(261, 88);
            this.graph4Button.Name = "graph4Button";
            this.graph4Button.Size = new System.Drawing.Size(80, 23);
            this.graph4Button.TabIndex = 4;
            this.graph4Button.Text = "Bubble Chart";
            this.graph4Button.UseVisualStyleBackColor = true;
            this.graph4Button.Click += new System.EventHandler(this.graph4Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select a button to view the corresponding chart .\r\nCHOOSE WISELY!!!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 196);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.graph4Button);
            this.Controls.Add(this.graph3Button);
            this.Controls.Add(this.graph2Button);
            this.Controls.Add(this.graph1Button);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button graph1Button;
        private System.Windows.Forms.Button graph2Button;
        private System.Windows.Forms.Button graph3Button;
        private System.Windows.Forms.Button graph4Button;
        private System.Windows.Forms.Label label1;
    }
}

