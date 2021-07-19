using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BallsCommon;

namespace DiffusionPictureBox
{
    public partial class DiffusionPictureBoxForm : Form
    {
        private int redBallsBoundsCount;
        private int blueBallsBoundsCount;

        private readonly List<MolecularBallPictureBox> ballsList;
        public DiffusionPictureBoxForm()
        {
            InitializeComponent();
            ballsList = new List<MolecularBallPictureBox>();
            ResetBallBoundsCount();
        }

        private void Form_Click(object sender, EventArgs e)
        {
            SwitchMoveAllBalls();
        }

        private void SwitchMoveAllBalls()
        {
            foreach (var ball in ballsList)
            {
                if (ball.IsMoving()) ball.StopMove();
                else ball.StartMove();
            }
        }

        private void Ball_OnStep(object sender, StepEventArgs e)
        {
            if (BallsInBalance())
            {
                SwitchMoveAllBalls();
                Click -= Form_Click;
                resetButton.Enabled = true;
                gameEndAlarmLabel.Text = "Шары в равновесии!";
                gameEndAlarmLabel.ForeColor = Color.White;
                gameEndAlarmLabel.BackColor = Color.Red;
            }
        }

        private bool BallsInBalance()
        {
            var countRedBalls = 0;
            var countBlueBalls = 0;
            foreach (var ball in ballsList)
            {
                if (ball.FieldSide == GameFieldSide.rightSide)
                {
                    if (ball is RedMolecularBallPictureBox)
                    {
                        countRedBalls++;
                    }
                    else
                    {
                        countBlueBalls++;
                    }
                }
            }
            return countRedBalls == ballsList.Count / 4 && countBlueBalls == ballsList.Count / 4;
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            ballsCountNumericUpDown.Enabled = false;
            for (int i = 0; i < ballsCountNumericUpDown.Value; i++)
            {
                var redBall = new RedMolecularBallPictureBox(this);
                redBall.OnHited += Ball_OnBorderRebound;
                redBall.FieldSideChanged += Ball_OnStep;
                ballsList.Add(redBall);
                var blueBall = new BlueMolecularBallPictureBox(this);
                blueBall.OnHited += Ball_OnBorderRebound;
                blueBall.FieldSideChanged += Ball_OnStep;
                ballsList.Add(blueBall);

            }
            (sender as Button).Enabled = false;
            foreach (var ball in ballsList)
            {
                Controls.Add(ball);
            }
            Click += Form_Click;
        }

        private void Ball_OnBorderRebound(object sender, EventArgs e)
        {
            if (sender is RedMolecularBallPictureBox)
            {
                redBallsBoundsCount++;
                redBallsBoundCountLabel.Text = redBallsBoundsCount.ToString();
            }
            else
            {
                blueBallsBoundsCount++;
                blueBallsBoundCountLabel.Text = blueBallsBoundsCount.ToString();
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetBallBoundsCount();
            (sender as Button).Enabled = false;
            newGameButton.Enabled = true;
            ballsCountNumericUpDown.Enabled = true;
            gameEndAlarmLabel.Text = string.Empty;
        }

        private void ResetBallBoundsCount()
        {
            foreach (var ball in ballsList)
            {
                ball.Explode();
                Controls.Remove(ball);
            }
            ballsList.Clear();
            redBallsBoundsCount = blueBallsBoundsCount = 0;
            redBallsBoundCountLabel.Text = redBallsBoundsCount.ToString();
            blueBallsBoundCountLabel.Text = blueBallsBoundsCount.ToString();
        }
    }
}
