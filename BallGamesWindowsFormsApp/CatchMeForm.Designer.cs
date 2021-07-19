namespace BallGamesWindowsFormsApp
{
    partial class CatchMeForm
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
            this.сreateBallsButton = new System.Windows.Forms.Button();
            this.catchBallsWithButtonButton = new System.Windows.Forms.Button();
            this.catchBallsWithMouseButton = new System.Windows.Forms.Button();
            this.explodeBallsButton = new System.Windows.Forms.Button();
            this.catchButton = new System.Windows.Forms.Button();
            this.countCaughtBallsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ballsCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ballsCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // сreateBallsButton
            // 
            this.сreateBallsButton.Location = new System.Drawing.Point(782, 3);
            this.сreateBallsButton.Name = "сreateBallsButton";
            this.сreateBallsButton.Size = new System.Drawing.Size(110, 23);
            this.сreateBallsButton.TabIndex = 0;
            this.сreateBallsButton.Text = "Создать шары";
            this.сreateBallsButton.UseVisualStyleBackColor = true;
            this.сreateBallsButton.Click += new System.EventHandler(this.CreateBallsButton_Click);
            // 
            // catchBallsWithButtonButton
            // 
            this.catchBallsWithButtonButton.Enabled = false;
            this.catchBallsWithButtonButton.Location = new System.Drawing.Point(780, 33);
            this.catchBallsWithButtonButton.Name = "catchBallsWithButtonButton";
            this.catchBallsWithButtonButton.Size = new System.Drawing.Size(110, 23);
            this.catchBallsWithButtonButton.TabIndex = 1;
            this.catchBallsWithButtonButton.Text = "Ловить кнопкой";
            this.catchBallsWithButtonButton.UseVisualStyleBackColor = true;
            this.catchBallsWithButtonButton.Click += new System.EventHandler(this.StartCatchingByButtonButton_Click);
            // 
            // catchBallsWithMouseButton
            // 
            this.catchBallsWithMouseButton.Enabled = false;
            this.catchBallsWithMouseButton.Location = new System.Drawing.Point(780, 63);
            this.catchBallsWithMouseButton.Name = "catchBallsWithMouseButton";
            this.catchBallsWithMouseButton.Size = new System.Drawing.Size(110, 23);
            this.catchBallsWithMouseButton.TabIndex = 2;
            this.catchBallsWithMouseButton.Text = "Ловить мышью";
            this.catchBallsWithMouseButton.UseVisualStyleBackColor = true;
            this.catchBallsWithMouseButton.Click += new System.EventHandler(this.StartCatchingByMouseButton_Click);
            // 
            // explodeBallsButton
            // 
            this.explodeBallsButton.Enabled = false;
            this.explodeBallsButton.Location = new System.Drawing.Point(780, 93);
            this.explodeBallsButton.Name = "explodeBallsButton";
            this.explodeBallsButton.Size = new System.Drawing.Size(110, 23);
            this.explodeBallsButton.TabIndex = 3;
            this.explodeBallsButton.Text = "Лопнуть шары";
            this.explodeBallsButton.UseVisualStyleBackColor = true;
            this.explodeBallsButton.Click += new System.EventHandler(this.ExplodeBallsButton_Click);
            // 
            // catchButton
            // 
            this.catchButton.Enabled = false;
            this.catchButton.Location = new System.Drawing.Point(780, 123);
            this.catchButton.Name = "catchButton";
            this.catchButton.Size = new System.Drawing.Size(110, 23);
            this.catchButton.TabIndex = 4;
            this.catchButton.Text = "Поймать шары";
            this.catchButton.UseVisualStyleBackColor = true;
            this.catchButton.Click += new System.EventHandler(this.CatchBallsButton_Click);
            // 
            // countCaughtBallsLabel
            // 
            this.countCaughtBallsLabel.ForeColor = System.Drawing.Color.Blue;
            this.countCaughtBallsLabel.Location = new System.Drawing.Point(780, 214);
            this.countCaughtBallsLabel.Name = "countCaughtBallsLabel";
            this.countCaughtBallsLabel.Size = new System.Drawing.Size(108, 39);
            this.countCaughtBallsLabel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(780, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Число шаров в игре";
            // 
            // ballsCountNumericUpDown
            // 
            this.ballsCountNumericUpDown.Location = new System.Drawing.Point(780, 180);
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
            this.ballsCountNumericUpDown.TabIndex = 6;
            this.ballsCountNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // CatchMeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 575);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ballsCountNumericUpDown);
            this.Controls.Add(this.countCaughtBallsLabel);
            this.Controls.Add(this.catchButton);
            this.Controls.Add(this.explodeBallsButton);
            this.Controls.Add(this.catchBallsWithMouseButton);
            this.Controls.Add(this.catchBallsWithButtonButton);
            this.Controls.Add(this.сreateBallsButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CatchMeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поймай меня";
            ((System.ComponentModel.ISupportInitialize)(this.ballsCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button сreateBallsButton;
        private System.Windows.Forms.Button catchBallsWithButtonButton;
        private System.Windows.Forms.Button catchBallsWithMouseButton;
        private System.Windows.Forms.Button explodeBallsButton;
        private System.Windows.Forms.Button catchButton;
        private System.Windows.Forms.Label countCaughtBallsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ballsCountNumericUpDown;
    }
}

