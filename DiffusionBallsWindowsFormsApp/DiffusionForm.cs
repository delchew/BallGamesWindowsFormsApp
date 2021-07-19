using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BallsCommon;

namespace DiffusionBallsWindowsFormsApp
{
    public partial class DiffusionForm : Form
    {
        private int redBallsBoundsCount;
        private int blueBallsBoundsCount;

        private readonly List<MolecularBall> ballsList;
        private readonly GameField gameField;
        private readonly BufferedGraphicsContext graphicsContext;
        private readonly BufferedGraphics drawBallsBuffer;
        public DiffusionForm()
        {
            InitializeComponent();
            gameEndAlarmLabel.Text = string.Empty;
            ballsList = new List<MolecularBall>();
            graphicsContext = BufferedGraphicsManager.Current; //Двойная буфферизация графики вручную.
            drawBallsBuffer = graphicsContext.Allocate(pictureBox.CreateGraphics(), pictureBox.ClientRectangle);
            ResetBallBoundsCount();
            gameField = new GameField(drawBallsBuffer, pictureBox.ClientRectangle, BackColor); 
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            SwitchMoveAllBalls();
        }

        private void SwitchMoveAllBalls()
        {
            foreach (var ball in ballsList)
            {
                ball.SwitchMove();
            }
        }

        private void Ball_OnStep(object sender, StepEventArgs e)
        {
            DrawSplitterLine(drawBallsBuffer.Graphics);
            if (BallsInBalance())
            {
                SwitchMoveAllBalls();
                pictureBox.Click -= PictureBox_Click;
                ballsList.Clear();
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
            foreach(var ball in ballsList)
            {
                if (ball.FieldSide == GameFieldSide.rightSide)
                {
                    if (ball is RedMolecularBall)
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

        private void DiffusionForm_Paint(object sender, PaintEventArgs e)
        {
            DrawSplitterLine(e.Graphics);
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            DrawSplitterLine(gameField.DrawBallsBuffer.Graphics);
            pictureBox.Click += PictureBox_Click;
            ballsCountNumericUpDown.Enabled = false;
            for (int i = 0; i < ballsCountNumericUpDown.Value; i++)
            {
                var redBall = new RedMolecularBall(gameField);
                redBall.OnHited += Ball_OnBorderRebound;
                redBall.FieldSideChanged += Ball_OnStep;
                ballsList.Add(redBall);
                var blueBall = new BlueMolecularBall(gameField);
                blueBall.OnHited += Ball_OnBorderRebound;
                blueBall.FieldSideChanged += Ball_OnStep;
                ballsList.Add(blueBall);
            }
            (sender as Button).Enabled = false;
            foreach (var ball in ballsList)
            {
                ball.Show();
            }
        }

        private void Ball_OnBorderRebound(object sender, EventArgs e)
        {
            if(sender is RedMolecularBall)
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
            pictureBox.Invalidate();

        }

        private void ResetBallBoundsCount()
        {
            drawBallsBuffer.Graphics.FillRectangle(new SolidBrush(pictureBox.BackColor), pictureBox.ClientRectangle);
            redBallsBoundsCount = blueBallsBoundsCount =  0;
            redBallsBoundCountLabel.Text = redBallsBoundsCount.ToString();
            blueBallsBoundCountLabel.Text = blueBallsBoundsCount.ToString();
        }

        private void DrawSplitterLine(Graphics graphics)
        {
            graphics.DrawLine(new Pen(new SolidBrush(Color.DarkGray)),
                pictureBox.Width / 2, 0, pictureBox.Width / 2, pictureBox.Height);
        }
    }
}
