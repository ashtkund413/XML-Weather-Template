namespace XMLWeather
{
    partial class ForecastScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.min1 = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.max1 = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.min2 = new System.Windows.Forms.Label();
            this.currenttemp = new System.Windows.Forms.Label();
            this.max2 = new System.Windows.Forms.Label();
            this.current = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(272, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 61;
            this.label3.Text = "Today";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // min1
            // 
            this.min1.BackColor = System.Drawing.Color.White;
            this.min1.Location = new System.Drawing.Point(342, 73);
            this.min1.Name = "min1";
            this.min1.Size = new System.Drawing.Size(42, 16);
            this.min1.TabIndex = 48;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(390, 71);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(90, 13);
            this.minLabel.TabIndex = 46;
            this.minLabel.Text = " Min Temperature";
            // 
            // max1
            // 
            this.max1.BackColor = System.Drawing.Color.White;
            this.max1.Location = new System.Drawing.Point(209, 71);
            this.max1.Name = "max1";
            this.max1.Size = new System.Drawing.Size(45, 15);
            this.max1.TabIndex = 45;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(113, 71);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(90, 13);
            this.maxLabel.TabIndex = 44;
            this.maxLabel.Text = "Max Temperature";
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.ForeColor = System.Drawing.Color.White;
            this.date1.Location = new System.Drawing.Point(290, 28);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(30, 13);
            this.date1.TabIndex = 64;
            this.date1.Text = "Date";
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.ForeColor = System.Drawing.Color.White;
            this.date2.Location = new System.Drawing.Point(290, 28);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(30, 13);
            this.date2.TabIndex = 69;
            this.date2.Text = "Date";
            // 
            // min2
            // 
            this.min2.BackColor = System.Drawing.Color.White;
            this.min2.Location = new System.Drawing.Point(251, 210);
            this.min2.Name = "min2";
            this.min2.Size = new System.Drawing.Size(95, 82);
            this.min2.TabIndex = 68;
            // 
            // currenttemp
            // 
            this.currenttemp.AutoSize = true;
            this.currenttemp.ForeColor = System.Drawing.Color.White;
            this.currenttemp.Location = new System.Drawing.Point(146, 244);
            this.currenttemp.Name = "currenttemp";
            this.currenttemp.Size = new System.Drawing.Size(99, 13);
            this.currenttemp.TabIndex = 67;
            this.currenttemp.Text = "current temperature";
            // 
            // max2
            // 
            this.max2.BackColor = System.Drawing.Color.White;
            this.max2.Location = new System.Drawing.Point(251, 87);
            this.max2.Name = "max2";
            this.max2.Size = new System.Drawing.Size(94, 87);
            this.max2.TabIndex = 66;
            // 
            // current
            // 
            this.current.AutoSize = true;
            this.current.ForeColor = System.Drawing.Color.White;
            this.current.Location = new System.Drawing.Point(280, 174);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(40, 13);
            this.current.TabIndex = 65;
            this.current.Text = "current";
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.date2);
            this.Controls.Add(this.min2);
            this.Controls.Add(this.currenttemp);
            this.Controls.Add(this.max2);
            this.Controls.Add(this.current);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.min1);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.max1);
            this.Controls.Add(this.maxLabel);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(645, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label min1;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label max1;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label min2;
        private System.Windows.Forms.Label currenttemp;
        private System.Windows.Forms.Label max2;
        private System.Windows.Forms.Label current;
    }
}
