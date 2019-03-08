namespace TipCalculator
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
            this.bill_Label = new System.Windows.Forms.Label();
            this.tip_Label = new System.Windows.Forms.Label();
            this.split_Label = new System.Windows.Forms.Label();
            this.totalTip_Label = new System.Windows.Forms.Label();
            this.totalBill_Label = new System.Windows.Forms.Label();
            this.totalPerson_Label = new System.Windows.Forms.Label();
            this.split_UpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tip_Slider = new System.Windows.Forms.TrackBar();
            this.tipValue_Label = new System.Windows.Forms.Label();
            this.totalTipAmount_Label = new System.Windows.Forms.Label();
            this.totalBillAmount_Label = new System.Windows.Forms.Label();
            this.splitAmount_Label = new System.Windows.Forms.Label();
            this.billAmount_UpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.split_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip_Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billAmount_UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // bill_Label
            // 
            this.bill_Label.AutoSize = true;
            this.bill_Label.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bill_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_Label.ForeColor = System.Drawing.Color.White;
            this.bill_Label.Location = new System.Drawing.Point(12, 39);
            this.bill_Label.Name = "bill_Label";
            this.bill_Label.Size = new System.Drawing.Size(142, 26);
            this.bill_Label.TabIndex = 0;
            this.bill_Label.Text = "Bill Amount:";
            this.bill_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tip_Label
            // 
            this.tip_Label.AutoSize = true;
            this.tip_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip_Label.ForeColor = System.Drawing.Color.White;
            this.tip_Label.Location = new System.Drawing.Point(12, 96);
            this.tip_Label.Name = "tip_Label";
            this.tip_Label.Size = new System.Drawing.Size(79, 26);
            this.tip_Label.TabIndex = 1;
            this.tip_Label.Text = "Tip %:";
            // 
            // split_Label
            // 
            this.split_Label.AutoSize = true;
            this.split_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.split_Label.ForeColor = System.Drawing.Color.White;
            this.split_Label.Location = new System.Drawing.Point(12, 213);
            this.split_Label.Name = "split_Label";
            this.split_Label.Size = new System.Drawing.Size(67, 26);
            this.split_Label.TabIndex = 2;
            this.split_Label.Text = "Split:";
            // 
            // totalTip_Label
            // 
            this.totalTip_Label.AutoSize = true;
            this.totalTip_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTip_Label.ForeColor = System.Drawing.Color.White;
            this.totalTip_Label.Location = new System.Drawing.Point(12, 269);
            this.totalTip_Label.Name = "totalTip_Label";
            this.totalTip_Label.Size = new System.Drawing.Size(100, 26);
            this.totalTip_Label.TabIndex = 3;
            this.totalTip_Label.Text = "Total Tip:";
            // 
            // totalBill_Label
            // 
            this.totalBill_Label.AutoSize = true;
            this.totalBill_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBill_Label.ForeColor = System.Drawing.Color.White;
            this.totalBill_Label.Location = new System.Drawing.Point(12, 323);
            this.totalBill_Label.Name = "totalBill_Label";
            this.totalBill_Label.Size = new System.Drawing.Size(101, 26);
            this.totalBill_Label.TabIndex = 4;
            this.totalBill_Label.Text = "Total Bill:";
            // 
            // totalPerson_Label
            // 
            this.totalPerson_Label.AutoSize = true;
            this.totalPerson_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPerson_Label.ForeColor = System.Drawing.Color.White;
            this.totalPerson_Label.Location = new System.Drawing.Point(12, 374);
            this.totalPerson_Label.Name = "totalPerson_Label";
            this.totalPerson_Label.Size = new System.Drawing.Size(155, 24);
            this.totalPerson_Label.TabIndex = 5;
            this.totalPerson_Label.Text = "Total Per Person:";
            // 
            // split_UpDown
            // 
            this.split_UpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.split_UpDown.Location = new System.Drawing.Point(94, 213);
            this.split_UpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.split_UpDown.Name = "split_UpDown";
            this.split_UpDown.Size = new System.Drawing.Size(43, 29);
            this.split_UpDown.TabIndex = 6;
            this.split_UpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.split_UpDown.ValueChanged += new System.EventHandler(this.split_UpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(166, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "$";
            // 
            // tip_Slider
            // 
            this.tip_Slider.Location = new System.Drawing.Point(17, 140);
            this.tip_Slider.Maximum = 100;
            this.tip_Slider.Name = "tip_Slider";
            this.tip_Slider.Size = new System.Drawing.Size(329, 45);
            this.tip_Slider.TabIndex = 10;
            this.tip_Slider.Value = 20;
            this.tip_Slider.Scroll += new System.EventHandler(this.tip_Slider_Scroll);
            // 
            // tipValue_Label
            // 
            this.tipValue_Label.AutoSize = true;
            this.tipValue_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipValue_Label.ForeColor = System.Drawing.Color.LimeGreen;
            this.tipValue_Label.Location = new System.Drawing.Point(108, 96);
            this.tipValue_Label.Name = "tipValue_Label";
            this.tipValue_Label.Size = new System.Drawing.Size(56, 26);
            this.tipValue_Label.TabIndex = 11;
            this.tipValue_Label.Text = "20%";
            // 
            // totalTipAmount_Label
            // 
            this.totalTipAmount_Label.AutoSize = true;
            this.totalTipAmount_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTipAmount_Label.ForeColor = System.Drawing.Color.Gold;
            this.totalTipAmount_Label.Location = new System.Drawing.Point(187, 269);
            this.totalTipAmount_Label.Name = "totalTipAmount_Label";
            this.totalTipAmount_Label.Size = new System.Drawing.Size(71, 26);
            this.totalTipAmount_Label.TabIndex = 12;
            this.totalTipAmount_Label.Text = "$0.00";
            // 
            // totalBillAmount_Label
            // 
            this.totalBillAmount_Label.AutoSize = true;
            this.totalBillAmount_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBillAmount_Label.ForeColor = System.Drawing.Color.Gold;
            this.totalBillAmount_Label.Location = new System.Drawing.Point(187, 323);
            this.totalBillAmount_Label.Name = "totalBillAmount_Label";
            this.totalBillAmount_Label.Size = new System.Drawing.Size(71, 26);
            this.totalBillAmount_Label.TabIndex = 13;
            this.totalBillAmount_Label.Text = "$0.00";
            // 
            // splitAmount_Label
            // 
            this.splitAmount_Label.AutoSize = true;
            this.splitAmount_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitAmount_Label.ForeColor = System.Drawing.Color.Gold;
            this.splitAmount_Label.Location = new System.Drawing.Point(187, 374);
            this.splitAmount_Label.Name = "splitAmount_Label";
            this.splitAmount_Label.Size = new System.Drawing.Size(71, 26);
            this.splitAmount_Label.TabIndex = 14;
            this.splitAmount_Label.Text = "$0.00";
            // 
            // billAmount_UpDown
            // 
            this.billAmount_UpDown.DecimalPlaces = 2;
            this.billAmount_UpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billAmount_UpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.billAmount_UpDown.Location = new System.Drawing.Point(192, 45);
            this.billAmount_UpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.billAmount_UpDown.Name = "billAmount_UpDown";
            this.billAmount_UpDown.Size = new System.Drawing.Size(154, 29);
            this.billAmount_UpDown.TabIndex = 15;
            this.billAmount_UpDown.ValueChanged += new System.EventHandler(this.billAmount_UpDown_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(358, 500);
            this.Controls.Add(this.billAmount_UpDown);
            this.Controls.Add(this.splitAmount_Label);
            this.Controls.Add(this.totalBillAmount_Label);
            this.Controls.Add(this.totalTipAmount_Label);
            this.Controls.Add(this.tipValue_Label);
            this.Controls.Add(this.tip_Slider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.split_UpDown);
            this.Controls.Add(this.totalPerson_Label);
            this.Controls.Add(this.totalBill_Label);
            this.Controls.Add(this.totalTip_Label);
            this.Controls.Add(this.split_Label);
            this.Controls.Add(this.tip_Label);
            this.Controls.Add(this.bill_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Tip Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.split_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip_Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billAmount_UpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bill_Label;
        private System.Windows.Forms.Label tip_Label;
        private System.Windows.Forms.Label split_Label;
        private System.Windows.Forms.Label totalTip_Label;
        private System.Windows.Forms.Label totalBill_Label;
        private System.Windows.Forms.Label totalPerson_Label;
        private System.Windows.Forms.NumericUpDown split_UpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tip_Slider;
        private System.Windows.Forms.Label tipValue_Label;
        private System.Windows.Forms.Label totalTipAmount_Label;
        private System.Windows.Forms.Label totalBillAmount_Label;
        private System.Windows.Forms.Label splitAmount_Label;
        private System.Windows.Forms.NumericUpDown billAmount_UpDown;
    }
}

