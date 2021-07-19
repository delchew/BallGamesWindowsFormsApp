using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BallsCommon;

namespace BiliardWindowsFormsApp
{
    public partial class BiliardForm : Form
    {
        private readonly List<RandomMoveAndExplodeBorderReboundBall> ballsList;
        private int countCaughtBalls;
        private readonly GameField gameField;
        private readonly int offset = 5;
        private int topCount = 0;
        private int downCount = 0;
        private int leftCount = 0;
        private int rightCount = 0;
        private readonly BufferedGraphicsContext graphicsContext;
        private readonly BufferedGraphics drawBallsBuffer;

        public BiliardForm()
        {
            InitializeComponent();
            ballsList = new List<RandomMoveAndExplodeBorderReboundBall>();
            var fieldBorders = new Rectangle(0, 0, ClientSize.Width - createBallsButton.Width - 2 * offset, ClientSize.Height);
            graphicsContext = BufferedGraphicsManager.Current; //Двойная буфферизация графики вручную.
            drawBallsBuffer = graphicsContext.Allocate(CreateGraphics(), fieldBorders);
            //Закрашиваем область рисования в цвет фона через буфер, чтобы потом не красилось чёрным:
            drawBallsBuffer.Graphics.FillRectangle(new SolidBrush(BackColor), fieldBorders);
            gameField = new GameField(drawBallsBuffer, fieldBorders, BackColor);
        }

        private void CreateBallsButton_Click(object sender, EventArgs e)
        {
            countCaughtBalls = 0;
            RandomMoveAndExplodeBorderReboundBall.ResetCountBounds();
            countMeetBordersLabel.Text = "0";
            countCaughtBallsLabel.Text = string.Empty;
            (sender as Button).Enabled = false;
            ballsCountNumericUpDown.Enabled = false;
            catchBallsWithMouseButton.Enabled = true;
            for (int i = 0; i < ballsCountNumericUpDown.Value; i++)
            {
                var ball = new RandomMoveAndExplodeBorderReboundBall(gameField);
                ball.OnHited += Ball_OnBorderRebound;
                ballsList.Add(ball);
                ball.Show();
            }
        }

        private void Ball_OnBorderRebound(object sender, HitEventArgs e)
        {
            countMeetBordersLabel.Text = RandomMoveAndExplodeBorderReboundBall.CountBounds.ToString();
            switch (e.Type)
            {
                case HitType.Top:
                    topCount++;
                    break;
                case HitType.Down:
                    downCount++;
                    break;
                case HitType.Left:
                    leftCount++;
                    break;
                case HitType.Right:
                    rightCount++;
                    break;
            }
            topCounterLabel.Text = topCount.ToString();
            downCounterLabel.Text = downCount.ToString();
            leftCounterLabel.Text = leftCount.ToString();
            rightCounterLabel.Text = rightCount.ToString();
        }

        private void StartMoveBalls()
        {
            foreach (var ball in ballsList)
            {
                ball.StartMove();
            }
        }

        private void CatchBallsWithMouseButton_Click(object sender, System.EventArgs e)
        {
            MouseDown += Form_MouseDown;
            (sender as Button).Enabled = false;
            StartMoveBalls();
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            var clickedBalls = new List<RandomMoveAndExplodeBorderReboundBall>();
            foreach (var ball in ballsList)
            {
                if (ball.OnTouch(e.X, e.Y))
                {
                    clickedBalls.Add(ball);
                    ball.Explode();
                }
            }
            foreach (var ball in clickedBalls)
            {
                ballsList.Remove(ball);
                countCaughtBalls++;
                ShowCaughtBallsCount();
            }
            if (ballsList.Count == 0)
            {
                createBallsButton.Enabled = true;
                ballsCountNumericUpDown.Enabled = true;
                catchBallsWithMouseButton.Enabled = false;
                ShowCaughtBallsCount();
                MouseDown -= Form_MouseDown;
            }
        }

        private void ShowCaughtBallsCount()
        {
            string ballWord = " шаров.";
            if (countCaughtBalls == 1) ballWord = " шар.";
            else if (countCaughtBalls > 1 && countCaughtBalls < 5) ballWord = " шара.";
            countCaughtBallsLabel.Text = "Вы поймали " + Environment.NewLine + countCaughtBalls + ballWord;
        }
    }
}
