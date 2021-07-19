namespace BiliardWindowsFormsApp
{
    partial class BiliardForm
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
            this.createBallsButton = new System.Windows.Forms.Button();
            this.catchBallsWithMouseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ballsCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.countCaughtBallsLabel = new System.Windows.Forms.Label();
            this.countMeetBordersLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.topCounterLabel = new System.Windows.Forms.Label();
            this.rightCounterLabel = new System.Windows.Forms.Label();
            this.leftCounterLabel = new System.Windows.Forms.Label();
            this.downCounterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ballsCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // createBallsButton
            // 
            this.createBallsButton.Location = new System.Drawing.Point(1080, 10);
            this.createBallsButton.Name = "createBallsButton";
            this.createBallsButton.Size = new System.Drawing.Size(110, 23);
            this.createBallsButton.TabIndex = 0;
            this.createBallsButton.Text = "Создать шары";
            this.createBallsButton.UseVisualStyleBackColor = true;
            this.createBallsButton.Click += new System.EventHandler(this.CreateBallsButton_Click);
            // 
            // catchBallsWithMouseButton
            // 
            this.catchBallsWithMouseButton.Enabled = false;
            this.catchBallsWithMouseButton.Location = new System.Drawing.Point(1080, 43);
            this.catchBallsWithMouseButton.Name = "catchBallsWithMouseButton";
            this.catchBallsWithMouseButton.Size = new System.Drawing.Size(110, 23);
            this.catchBallsWithMouseButton.TabIndex = 1;
            this.catchBallsWithMouseButton.Text = "Ловить мышью";
            this.catchBallsWithMouseButton.UseVisualStyleBackColor = true;
            this.catchBallsWithMouseButton.Click += new System.EventHandler(this.CatchBallsWithMouseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1080, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Число шаров в игре";
            // 
            // ballsCountNumericUpDown
            // 
            this.ballsCountNumericUpDown.Location = new System.Drawing.Point(1080, 97);
            this.ballsCountNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ballsCountNumericUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.ballsCountNumericUpDown.Name = "ballsCountNumericUpDown";
            this.ballsCountNumericUpDown.Size = new System.Drawing.Size(110, 20);
            this.ballsCountNumericUpDown.TabIndex = 9;
            this.ballsCountNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // countCaughtBallsLabel
            // 
            this.countCaughtBallsLabel.ForeColor = System.Drawing.Color.Blue;
            this.countCaughtBallsLabel.Location = new System.Drawing.Point(1074, 187);
            this.countCaughtBallsLabel.Name = "countCaughtBallsLabel";
            this.countCaughtBallsLabel.Size = new System.Drawing.Size(106, 39);
            this.countCaughtBallsLabel.TabIndex = 8;
            // 
            // countMeetBordersLabel
            // 
            this.countMeetBordersLabel.ForeColor = System.Drawing.Color.Red;
            this.countMeetBordersLabel.Location = new System.Drawing.Point(1080, 153);
            this.countMeetBordersLabel.Name = "countMeetBordersLabel";
            this.countMeetBordersLabel.Size = new System.Drawing.Size(110, 23);
            this.countMeetBordersLabel.TabIndex = 12;
            this.countMeetBordersLabel.Text = "0";
            this.countMeetBordersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(1080, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Число соударений:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topCounterLabel
            // 
            this.topCounterLabel.AutoSize = true;
            this.topCounterLabel.Location = new System.Drawing.Point(538, 10);
            this.topCounterLabel.Name = "topCounterLabel";
            this.topCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.topCounterLabel.TabIndex = 13;
            this.topCounterLabel.Text = "0";
            // 
            // rightCounterLabel
            // 
            this.rightCounterLabel.AutoSize = true;
            this.rightCounterLabel.Location = new System.Drawing.Point(1040, 371);
            this.rightCounterLabel.Name = "rightCounterLabel";
            this.rightCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.rightCounterLabel.TabIndex = 14;
            this.rightCounterLabel.Text = "0";
            // 
            // leftCounterLabel
            // 
            this.leftCounterLabel.AutoSize = true;
            this.leftCounterLabel.Location = new System.Drawing.Point(13, 371);
            this.leftCounterLabel.Name = "leftCounterLabel";
            this.leftCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.leftCounterLabel.TabIndex = 15;
            this.leftCounterLabel.Text = "0";
            // 
            // downCounterLabel
            // 
            this.downCounterLabel.AutoSize = true;
            this.downCounterLabel.Location = new System.Drawing.Point(538, 753);
            this.downCounterLabel.Name = "downCounterLabel";
            this.downCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.downCounterLabel.TabIndex = 16;
            this.downCounterLabel.Text = "0";
            // 
            // BiliardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 775);
            this.Controls.Add(this.downCounterLabel);
            this.Controls.Add(this.leftCounterLabel);
            this.Controls.Add(this.rightCounterLabel);
            this.Controls.Add(this.topCounterLabel);
            this.Controls.Add(this.countMeetBordersLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ballsCountNumericUpDown);
            this.Controls.Add(this.countCaughtBallsLabel);
            this.Controls.Add(this.catchBallsWithMouseButton);
            this.Controls.Add(this.createBallsButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BiliardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бильярд";
            ((System.ComponentModel.ISupportInitialize)(this.ballsCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createBallsButton;
        private System.Windows.Forms.Button catchBallsWithMouseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ballsCountNumericUpDown;
        private System.Windows.Forms.Label countCaughtBallsLabel;
        private System.Windows.Forms.Label countMeetBordersLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label topCounterLabel;
        private System.Windows.Forms.Label rightCounterLabel;
        private System.Windows.Forms.Label leftCounterLabel;
        private System.Windows.Forms.Label downCounterLabel;
    }
}

