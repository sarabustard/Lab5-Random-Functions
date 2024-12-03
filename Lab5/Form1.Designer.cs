namespace Lab5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDice1 = new System.Windows.Forms.Label();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.lblRollName = new System.Windows.Forms.Label();
            this.btnSwapNumbers = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDice2 = new System.Windows.Forms.Label();
            this.grpOneRoll = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.radOneRoll = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radRollStats = new System.Windows.Forms.RadioButton();
            this.grpMarkStats = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblFail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lstMarks = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSeed = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.grpOneRoll.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpMarkStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dice 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dice 2:";
            // 
            // lblDice1
            // 
            this.lblDice1.BackColor = System.Drawing.Color.MistyRose;
            this.lblDice1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDice1.Location = new System.Drawing.Point(82, 22);
            this.lblDice1.Name = "lblDice1";
            this.lblDice1.Size = new System.Drawing.Size(41, 27);
            this.lblDice1.TabIndex = 2;
            this.lblDice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRollDice
            // 
            this.btnRollDice.Location = new System.Drawing.Point(5, 138);
            this.btnRollDice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(81, 57);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "&Roll \r\nDice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // lblRollName
            // 
            this.lblRollName.BackColor = System.Drawing.Color.LightSalmon;
            this.lblRollName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRollName.Location = new System.Drawing.Point(107, 88);
            this.lblRollName.Name = "lblRollName";
            this.lblRollName.Size = new System.Drawing.Size(149, 27);
            this.lblRollName.TabIndex = 7;
            this.lblRollName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSwapNumbers
            // 
            this.btnSwapNumbers.Location = new System.Drawing.Point(93, 138);
            this.btnSwapNumbers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSwapNumbers.Name = "btnSwapNumbers";
            this.btnSwapNumbers.Size = new System.Drawing.Size(81, 57);
            this.btnSwapNumbers.TabIndex = 1;
            this.btnSwapNumbers.Text = "&Swap Numbers";
            this.btnSwapNumbers.UseVisualStyleBackColor = true;
            this.btnSwapNumbers.Click += new System.EventHandler(this.btnSwapNumbers_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Roll Name:";
            // 
            // lblDice2
            // 
            this.lblDice2.BackColor = System.Drawing.Color.MistyRose;
            this.lblDice2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDice2.Location = new System.Drawing.Point(82, 55);
            this.lblDice2.Name = "lblDice2";
            this.lblDice2.Size = new System.Drawing.Size(41, 27);
            this.lblDice2.TabIndex = 6;
            this.lblDice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpOneRoll
            // 
            this.grpOneRoll.Controls.Add(this.btnClear);
            this.grpOneRoll.Controls.Add(this.label1);
            this.grpOneRoll.Controls.Add(this.label2);
            this.grpOneRoll.Controls.Add(this.btnSwapNumbers);
            this.grpOneRoll.Controls.Add(this.lblDice1);
            this.grpOneRoll.Controls.Add(this.lblDice2);
            this.grpOneRoll.Controls.Add(this.lblRollName);
            this.grpOneRoll.Controls.Add(this.btnRollDice);
            this.grpOneRoll.Controls.Add(this.label7);
            this.grpOneRoll.Location = new System.Drawing.Point(8, 70);
            this.grpOneRoll.Margin = new System.Windows.Forms.Padding(2);
            this.grpOneRoll.Name = "grpOneRoll";
            this.grpOneRoll.Padding = new System.Windows.Forms.Padding(2);
            this.grpOneRoll.Size = new System.Drawing.Size(268, 203);
            this.grpOneRoll.TabIndex = 9;
            this.grpOneRoll.TabStop = false;
            this.grpOneRoll.Text = "One Roll";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(182, 138);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 57);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "&Clear \r\nOne Roll";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // radOneRoll
            // 
            this.radOneRoll.AutoSize = true;
            this.radOneRoll.Location = new System.Drawing.Point(21, 23);
            this.radOneRoll.Margin = new System.Windows.Forms.Padding(2);
            this.radOneRoll.Name = "radOneRoll";
            this.radOneRoll.Size = new System.Drawing.Size(111, 27);
            this.radOneRoll.TabIndex = 0;
            this.radOneRoll.TabStop = true;
            this.radOneRoll.Text = "One Roll";
            this.radOneRoll.UseVisualStyleBackColor = true;
            this.radOneRoll.CheckedChanged += new System.EventHandler(this.radOneRoll_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radRollStats);
            this.groupBox1.Controls.Add(this.radOneRoll);
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(608, 54);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select";
            // 
            // radRollStats
            // 
            this.radRollStats.AutoSize = true;
            this.radRollStats.Location = new System.Drawing.Point(404, 23);
            this.radRollStats.Margin = new System.Windows.Forms.Padding(2);
            this.radRollStats.Name = "radRollStats";
            this.radRollStats.Size = new System.Drawing.Size(132, 27);
            this.radRollStats.TabIndex = 1;
            this.radRollStats.TabStop = true;
            this.radRollStats.Text = "Mark Stats";
            this.radRollStats.UseVisualStyleBackColor = true;
            // 
            // grpMarkStats
            // 
            this.grpMarkStats.Controls.Add(this.btnReset);
            this.grpMarkStats.Controls.Add(this.btnGenerate);
            this.grpMarkStats.Controls.Add(this.lblFail);
            this.grpMarkStats.Controls.Add(this.lblPass);
            this.grpMarkStats.Controls.Add(this.lblAverage);
            this.grpMarkStats.Controls.Add(this.lstMarks);
            this.grpMarkStats.Controls.Add(this.label6);
            this.grpMarkStats.Controls.Add(this.label5);
            this.grpMarkStats.Controls.Add(this.label4);
            this.grpMarkStats.Controls.Add(this.chkSeed);
            this.grpMarkStats.Controls.Add(this.label3);
            this.grpMarkStats.Controls.Add(this.nudNumber);
            this.grpMarkStats.Location = new System.Drawing.Point(281, 70);
            this.grpMarkStats.Margin = new System.Windows.Forms.Padding(2);
            this.grpMarkStats.Name = "grpMarkStats";
            this.grpMarkStats.Padding = new System.Windows.Forms.Padding(2);
            this.grpMarkStats.Size = new System.Drawing.Size(334, 203);
            this.grpMarkStats.TabIndex = 12;
            this.grpMarkStats.TabStop = false;
            this.grpMarkStats.Text = "Mark Stats";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(147, 138);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 57);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "&Reset \r\nStats";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(32, 138);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(81, 57);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "&Generate Numbers";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblFail
            // 
            this.lblFail.BackColor = System.Drawing.Color.MistyRose;
            this.lblFail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFail.Location = new System.Drawing.Point(83, 76);
            this.lblFail.Name = "lblFail";
            this.lblFail.Size = new System.Drawing.Size(72, 27);
            this.lblFail.TabIndex = 12;
            this.lblFail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPass
            // 
            this.lblPass.BackColor = System.Drawing.Color.MistyRose;
            this.lblPass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPass.Location = new System.Drawing.Point(83, 46);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(72, 27);
            this.lblPass.TabIndex = 11;
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAverage
            // 
            this.lblAverage.BackColor = System.Drawing.Color.MistyRose;
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverage.Location = new System.Drawing.Point(83, 105);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(72, 27);
            this.lblAverage.TabIndex = 10;
            this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstMarks
            // 
            this.lstMarks.FormattingEnabled = true;
            this.lstMarks.ItemHeight = 23;
            this.lstMarks.Location = new System.Drawing.Point(250, 15);
            this.lstMarks.Margin = new System.Windows.Forms.Padding(2);
            this.lstMarks.Name = "lstMarks";
            this.lstMarks.Size = new System.Drawing.Size(73, 165);
            this.lstMarks.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pass:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average:";
            // 
            // chkSeed
            // 
            this.chkSeed.AutoSize = true;
            this.chkSeed.Location = new System.Drawing.Point(147, 19);
            this.chkSeed.Margin = new System.Windows.Forms.Padding(2);
            this.chkSeed.Name = "chkSeed";
            this.chkSeed.Size = new System.Drawing.Size(136, 27);
            this.chkSeed.TabIndex = 0;
            this.chkSeed.Text = "Seed Value";
            this.chkSeed.UseVisualStyleBackColor = true;
            this.chkSeed.CheckedChanged += new System.EventHandler(this.chkSeed_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Marks:";
            // 
            // nudNumber
            // 
            this.nudNumber.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumber.Location = new System.Drawing.Point(70, 19);
            this.nudNumber.Margin = new System.Windows.Forms.Padding(2);
            this.nudNumber.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudNumber.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(60, 30);
            this.nudNumber.TabIndex = 0;
            this.nudNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNumber.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AcceptButton = this.btnRollDice;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(624, 283);
            this.Controls.Add(this.grpMarkStats);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpOneRoll);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 5 by ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpOneRoll.ResumeLayout(false);
            this.grpOneRoll.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpMarkStats.ResumeLayout(false);
            this.grpMarkStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDice1;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Label lblRollName;
        private System.Windows.Forms.Button btnSwapNumbers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDice2;
        private System.Windows.Forms.GroupBox grpOneRoll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton radOneRoll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radRollStats;
        private System.Windows.Forms.GroupBox grpMarkStats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.CheckBox chkSeed;
        private System.Windows.Forms.ListBox lstMarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblFail;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGenerate;
    }
}

