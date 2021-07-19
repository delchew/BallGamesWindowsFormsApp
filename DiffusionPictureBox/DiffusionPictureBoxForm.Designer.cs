﻿namespace DiffusionPictureBox
{
    partial class DiffusionPictureBoxForm
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
            this.blueBallsBoundCountLabel = new System.Windows.Forms.Label();
            this.redBallsBoundCountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ballsCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gameEndAlarmLabel = new System.Windows.Forms.Label();
            this.newGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ballsCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // blueBallsBoundCountLabel
            // 
            this.blueBallsBoundCountLabel.AutoSize = true;
            this.blueBallsBoundCountLabel.ForeColor = System.Drawing.Color.Blue;
            this.blueBallsBoundCountLabel.Location = new System.Drawing.Point(872, 17);
            this.blueBallsBoundCountLabel.Name = "blueBallsBoundCountLabel";
            this.blueBallsBoundCountLabel.Size = new System.Drawing.Size(13, 13);
            this.blueBallsBoundCountLabel.TabIndex = 37;
            this.blueBallsBoundCountLabel.Text = "0";
            // 
            // redBallsBoundCountLabel
            // 
            this.redBallsBoundCountLabel.AutoSize = true;
            this.redBallsBoundCountLabel.ForeColor = System.Drawing.Color.Red;
            this.redBallsBoundCountLabel.Location = new System.Drawing.Point(660, 17);
            this.redBallsBoundCountLabel.Name = "redBallsBoundCountLabel";
            this.redBallsBoundCountLabel.Size = new System.Drawing.Size(13, 13);
            this.redBallsBoundCountLabel.TabIndex = 36;
            this.redBallsBoundCountLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(708, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Число ударов синих молекул:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Число ударов красных молекул:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Старт и стоп движения по щелчку мыши в области движения";
            // 
            // resetButton
            // 
            this.resetButton.Enabled = false;
            this.resetButton.Location = new System.Drawing.Point(143, 748);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(90, 23);
            this.resetButton.TabIndex = 32;
            this.resetButton.Text = "Сброс";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(612, 753);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Число молекул каждого цвета:";
            // 
            // ballsCountNumericUpDown
            // 
            this.ballsCountNumericUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ballsCountNumericUpDown.Location = new System.Drawing.Point(795, 748);
            this.ballsCountNumericUpDown.Maximum = new decimal(new int[] {
            20,
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
            this.ballsCountNumericUpDown.TabIndex = 30;
            this.ballsCountNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // gameEndAlarmLabel
            // 
            this.gameEndAlarmLabel.AutoSize = true;
            this.gameEndAlarmLabel.Location = new System.Drawing.Point(257, 753);
            this.gameEndAlarmLabel.Name = "gameEndAlarmLabel";
            this.gameEndAlarmLabel.Size = new System.Drawing.Size(104, 13);
            this.gameEndAlarmLabel.TabIndex = 29;
            this.gameEndAlarmLabel.Text = "gameEndAlarmLabel";
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(26, 748);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(99, 23);
            this.newGameButton.TabIndex = 28;
            this.newGameButton.Text = "Новая игра";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // DiffusionPictureBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 792);
            this.Controls.Add(this.blueBallsBoundCountLabel);
            this.Controls.Add(this.redBallsBoundCountLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ballsCountNumericUpDown);
            this.Controls.Add(this.gameEndAlarmLabel);
            this.Controls.Add(this.newGameButton);
            this.Name = "DiffusionPictureBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Диффузия";
            ((System.ComponentModel.ISupportInitialize)(this.ballsCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label blueBallsBoundCountLabel;
        private System.Windows.Forms.Label redBallsBoundCountLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ballsCountNumericUpDown;
        private System.Windows.Forms.Label gameEndAlarmLabel;
        private System.Windows.Forms.Button newGameButton;
    }
}

