namespace WindowsFormsApplication2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.speedBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.altSpeed3 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.altSpeed2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.altSpeed1 = new System.Windows.Forms.NumericUpDown();
            this.windBox = new System.Windows.Forms.GroupBox();
            this.altWind3 = new System.Windows.Forms.NumericUpDown();
            this.altWind2 = new System.Windows.Forms.NumericUpDown();
            this.altWind1 = new System.Windows.Forms.NumericUpDown();
            this.tempBox = new System.Windows.Forms.GroupBox();
            this.tempValue = new System.Windows.Forms.NumericUpDown();
            this.cduResults = new System.Windows.Forms.GroupBox();
            this.tempResult3 = new System.Windows.Forms.TextBox();
            this.tempResult2 = new System.Windows.Forms.TextBox();
            this.tempResult1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.windResult3 = new System.Windows.Forms.TextBox();
            this.windResult2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.windResult1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.creditBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.speedBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.altSpeed3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altSpeed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altSpeed1)).BeginInit();
            this.windBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.altWind3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altWind2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altWind1)).BeginInit();
            this.tempBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempValue)).BeginInit();
            this.cduResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "A-10C LASTE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 110);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(158, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wind Correction Values";
            // 
            // speedBox
            // 
            this.speedBox.BackColor = System.Drawing.Color.Black;
            this.speedBox.Controls.Add(this.label5);
            this.speedBox.Controls.Add(this.altSpeed3);
            this.speedBox.Controls.Add(this.label4);
            this.speedBox.Controls.Add(this.altSpeed2);
            this.speedBox.Controls.Add(this.label3);
            this.speedBox.Controls.Add(this.altSpeed1);
            this.speedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.speedBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.speedBox.Location = new System.Drawing.Point(12, 136);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(259, 112);
            this.speedBox.TabIndex = 4;
            this.speedBox.TabStop = false;
            this.speedBox.Text = "Speed (m/s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(14, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "8000m";
            // 
            // altSpeed3
            // 
            this.altSpeed3.Location = new System.Drawing.Point(156, 70);
            this.altSpeed3.Name = "altSpeed3";
            this.altSpeed3.Size = new System.Drawing.Size(56, 23);
            this.altSpeed3.TabIndex = 4;
            this.altSpeed3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(14, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "2000m";
            // 
            // altSpeed2
            // 
            this.altSpeed2.Location = new System.Drawing.Point(156, 45);
            this.altSpeed2.Name = "altSpeed2";
            this.altSpeed2.Size = new System.Drawing.Size(56, 23);
            this.altSpeed2.TabIndex = 2;
            this.altSpeed2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(14, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ground";
            // 
            // altSpeed1
            // 
            this.altSpeed1.Location = new System.Drawing.Point(156, 21);
            this.altSpeed1.Name = "altSpeed1";
            this.altSpeed1.Size = new System.Drawing.Size(56, 23);
            this.altSpeed1.TabIndex = 0;
            this.altSpeed1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // windBox
            // 
            this.windBox.BackColor = System.Drawing.Color.Black;
            this.windBox.Controls.Add(this.altWind3);
            this.windBox.Controls.Add(this.altWind2);
            this.windBox.Controls.Add(this.altWind1);
            this.windBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.windBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.windBox.Location = new System.Drawing.Point(277, 136);
            this.windBox.Name = "windBox";
            this.windBox.Size = new System.Drawing.Size(132, 112);
            this.windBox.TabIndex = 5;
            this.windBox.TabStop = false;
            this.windBox.Text = "Wind Dir (to)";
            // 
            // altWind3
            // 
            this.altWind3.Location = new System.Drawing.Point(17, 73);
            this.altWind3.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.altWind3.Name = "altWind3";
            this.altWind3.Size = new System.Drawing.Size(85, 23);
            this.altWind3.TabIndex = 2;
            this.altWind3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // altWind2
            // 
            this.altWind2.Location = new System.Drawing.Point(17, 47);
            this.altWind2.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.altWind2.Name = "altWind2";
            this.altWind2.Size = new System.Drawing.Size(85, 23);
            this.altWind2.TabIndex = 1;
            this.altWind2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // altWind1
            // 
            this.altWind1.Location = new System.Drawing.Point(17, 20);
            this.altWind1.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.altWind1.Name = "altWind1";
            this.altWind1.Size = new System.Drawing.Size(85, 23);
            this.altWind1.TabIndex = 0;
            this.altWind1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tempBox
            // 
            this.tempBox.BackColor = System.Drawing.Color.Black;
            this.tempBox.Controls.Add(this.tempValue);
            this.tempBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tempBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tempBox.Location = new System.Drawing.Point(417, 136);
            this.tempBox.Name = "tempBox";
            this.tempBox.Size = new System.Drawing.Size(132, 112);
            this.tempBox.TabIndex = 6;
            this.tempBox.TabStop = false;
            this.tempBox.Text = "Temperature (C)";
            // 
            // tempValue
            // 
            this.tempValue.Location = new System.Drawing.Point(25, 47);
            this.tempValue.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.tempValue.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.tempValue.Name = "tempValue";
            this.tempValue.Size = new System.Drawing.Size(85, 23);
            this.tempValue.TabIndex = 0;
            this.tempValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cduResults
            // 
            this.cduResults.BackColor = System.Drawing.Color.Black;
            this.cduResults.Controls.Add(this.tempResult3);
            this.cduResults.Controls.Add(this.tempResult2);
            this.cduResults.Controls.Add(this.tempResult1);
            this.cduResults.Controls.Add(this.label11);
            this.cduResults.Controls.Add(this.windResult3);
            this.cduResults.Controls.Add(this.windResult2);
            this.cduResults.Controls.Add(this.label10);
            this.cduResults.Controls.Add(this.label9);
            this.cduResults.Controls.Add(this.label8);
            this.cduResults.Controls.Add(this.label7);
            this.cduResults.Controls.Add(this.windResult1);
            this.cduResults.Controls.Add(this.label6);
            this.cduResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cduResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cduResults.Location = new System.Drawing.Point(19, 267);
            this.cduResults.Name = "cduResults";
            this.cduResults.Size = new System.Drawing.Size(520, 186);
            this.cduResults.TabIndex = 7;
            this.cduResults.TabStop = false;
            this.cduResults.Text = "CDU Input Values";
            // 
            // tempResult3
            // 
            this.tempResult3.Enabled = false;
            this.tempResult3.Location = new System.Drawing.Point(398, 117);
            this.tempResult3.Name = "tempResult3";
            this.tempResult3.Size = new System.Drawing.Size(45, 22);
            this.tempResult3.TabIndex = 11;
            this.tempResult3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tempResult2
            // 
            this.tempResult2.Enabled = false;
            this.tempResult2.Location = new System.Drawing.Point(398, 85);
            this.tempResult2.Name = "tempResult2";
            this.tempResult2.Size = new System.Drawing.Size(45, 22);
            this.tempResult2.TabIndex = 10;
            this.tempResult2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tempResult1
            // 
            this.tempResult1.Enabled = false;
            this.tempResult1.Location = new System.Drawing.Point(398, 55);
            this.tempResult1.Name = "tempResult1";
            this.tempResult1.Size = new System.Drawing.Size(45, 22);
            this.tempResult1.TabIndex = 9;
            this.tempResult1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(361, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Temperature (C)";
            // 
            // windResult3
            // 
            this.windResult3.Enabled = false;
            this.windResult3.Location = new System.Drawing.Point(212, 116);
            this.windResult3.Name = "windResult3";
            this.windResult3.Size = new System.Drawing.Size(100, 22);
            this.windResult3.TabIndex = 7;
            this.windResult3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // windResult2
            // 
            this.windResult2.Enabled = false;
            this.windResult2.Location = new System.Drawing.Point(212, 85);
            this.windResult2.Name = "windResult2";
            this.windResult2.Size = new System.Drawing.Size(100, 22);
            this.windResult2.TabIndex = 6;
            this.windResult2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(188, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "WIND(HDG/SPEED)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "26";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "07";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "00";
            // 
            // windResult1
            // 
            this.windResult1.Enabled = false;
            this.windResult1.Location = new System.Drawing.Point(212, 55);
            this.windResult1.Name = "windResult1";
            this.windResult1.Size = new System.Drawing.Size(100, 22);
            this.windResult1.TabIndex = 1;
            this.windResult1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Altitude (feet)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.BackColor = System.Drawing.Color.Black;
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.calculateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.calculateBtn.Location = new System.Drawing.Point(168, 473);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(100, 33);
            this.calculateBtn.TabIndex = 8;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = false;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.resetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetBtn.Location = new System.Drawing.Point(304, 473);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 33);
            this.resetBtn.TabIndex = 9;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // creditBtn
            // 
            this.creditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.creditBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.creditBtn.Location = new System.Drawing.Point(514, 473);
            this.creditBtn.Name = "creditBtn";
            this.creditBtn.Size = new System.Drawing.Size(35, 33);
            this.creditBtn.TabIndex = 10;
            this.creditBtn.Text = "?";
            this.creditBtn.UseVisualStyleBackColor = false;
            this.creditBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(561, 518);
            this.Controls.Add(this.creditBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.cduResults);
            this.Controls.Add(this.tempBox);
            this.Controls.Add(this.windBox);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(577, 556);
            this.MinimumSize = new System.Drawing.Size(577, 556);
            this.Name = "Form1";
            this.Text = "373vFS Wind Correction DCS A-10c";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.speedBox.ResumeLayout(false);
            this.speedBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.altSpeed3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altSpeed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altSpeed1)).EndInit();
            this.windBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.altWind3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altWind2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altWind1)).EndInit();
            this.tempBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tempValue)).EndInit();
            this.cduResults.ResumeLayout(false);
            this.cduResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox speedBox;
        private System.Windows.Forms.GroupBox windBox;
        private System.Windows.Forms.NumericUpDown altSpeed1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown altSpeed2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown altSpeed3;
        private System.Windows.Forms.NumericUpDown altWind3;
        private System.Windows.Forms.NumericUpDown altWind2;
        private System.Windows.Forms.NumericUpDown altWind1;
        private System.Windows.Forms.GroupBox tempBox;
        private System.Windows.Forms.NumericUpDown tempValue;
        private System.Windows.Forms.GroupBox cduResults;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.TextBox windResult1;
        private System.Windows.Forms.TextBox tempResult3;
        private System.Windows.Forms.TextBox tempResult2;
        private System.Windows.Forms.TextBox tempResult1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox windResult3;
        private System.Windows.Forms.TextBox windResult2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button creditBtn;

    }
}

