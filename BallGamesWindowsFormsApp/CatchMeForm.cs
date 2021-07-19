using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using BallsCommon;

namespace BallGamesWindowsFormsApp
{
    public partial class CatchMeForm : Form
    {
        private readonly List<RandomMoveAndExplodeBorderExplodeBall> ballsList;
        private int countCaughtBalls;
        private readonly GameField gameField;
        private readonly int offset = 5;
        private readonly BufferedGraphicsContext graphicsContext;
        private readonly BufferedGraphics drawBallsBuffer;

        public CatchMeForm()
        {
            InitializeComponent();
            ballsList = new List<RandomMoveAndExplodeBorderExplodeBall>();
            var fieldBorders = new Rectangle(0, 0, ClientSize.Width - сreateBallsButton.Width - 2 * offset, ClientSize.Height);
            graphicsContext = BufferedGraphicsManager.Current; //Двойная буфферизация графики вручную.
            drawBallsBuffer = graphicsContext.Allocate(CreateGraphics(), fieldBorders);
            //Закрашиваем область рисования в цвет фона через буфер, чтобы потом не красилось чёрным:
            drawBallsBuffer.Graphics.FillRectangle(new SolidBrush(BackColor), fieldBorders);
            gameField = new GameField(drawBallsBuffer, fieldBorders, BackColor);
        }

        private void CreateBallsButton_Click(object sender, EventArgs e)
        {
            countCaughtBalls = 0;
            countCaughtBallsLabel.Text = string.Empty;
            (sender as Button).Enabled = false;
            ballsCountNumericUpDown.Enabled = false;
            catchBallsWithButtonButton.Enabled = true;
            catchBallsWithMouseButton.Enabled = true;
            explodeBallsButton.Enabled = true;
            for (int i = 0; i < ballsCountNumericUpDown.Value; i++)
            {
                var ball = new RandomMoveAndExplodeBorderExplodeBall(gameField);
                ball.OnHited += Ball_OnExplode;
                ballsList.Add(ball);
                ball.Show();
            }
        }

        private void Ball_OnExplode(object sender, EventArgs e)
        {
            ballsList.Remove(sender as RandomMoveAndExplodeBorderExplodeBall);
            if (ballsList.Count == 0)
            {
                сreateBallsButton.Enabled = true;
                ballsCountNumericUpDown.Enabled = true;
                explodeBallsButton.Enabled = false;
                catchBallsWithButtonButton.Enabled = false;
                catchBallsWithMouseButton.Enabled = false;
                catchButton.Enabled = false;
                ShowCaughtBallsCount();
            }
        }

        private void StartCatchingByButtonButton_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            catchButton.Enabled = true;
            explodeBallsButton.Enabled = false;
            catchBallsWithMouseButton.Enabled = false;
            StartMoveBalls();
        }

        private void StartCatchingByMouseButton_Click(object sender, EventArgs e)
        {
            MouseDown += Form_MouseDown;
            (sender as Button).Enabled = false;
            catchBallsWithButtonButton.Enabled = false;
            catchButton.Enabled = false;
            explodeBallsButton.Enabled = false;
            StartMoveBalls();
        }

        private void ExplodeBallsButton_Click(object sender, EventArgs e)
        {
            countCaughtBallsLabel.Text = string.Empty;
            (sender as Button).Enabled = false;
            сreateBallsButton.Enabled = true;
            ballsCountNumericUpDown.Enabled = true;
            catchBallsWithMouseButton.Enabled = false;
            catchBallsWithButtonButton.Enabled = false;

            foreach (var ball in ballsList)
            {
                ball.Explode();
            }
            ballsList.Clear();
        }

        private void CatchBallsButton_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            explodeBallsButton.Enabled = true;
            foreach (var ball in ballsList)
            {
                ball.StopMove();
            }
            countCaughtBalls = ballsList.Count;
            ShowCaughtBallsCount();
        }


        private void StartMoveBalls()
        {
            foreach (var ball in ballsList)
            {
                ball.StartMove();
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            var clickedBalls = new List<RandomMoveAndExplodeBorderExplodeBall>();
            foreach (var ball in ballsList)
            {
                if (ball.OnTouch(e.X, e.Y))
                {
                    clickedBalls.Add(ball);
                    ball.Explode();
                }
            }
            countCaughtBalls += clickedBalls.Count;
            foreach (var ball in clickedBalls)
            {
                ballsList.Remove(ball);
            }
            ShowCaughtBallsCount();
            if (ballsList.Count == 0)
            {
                сreateBallsButton.Enabled = true;
                ballsCountNumericUpDown.Enabled = true;
                explodeBallsButton.Enabled = false;
                catchBallsWithButtonButton.Enabled = false;
                catchBallsWithMouseButton.Enabled = false;
                catchButton.Enabled = false;
                ShowCaughtBallsCount();
                MouseDown -= Form_MouseDown;
            }
        }
        protected void ShowCaughtBallsCount()
        {
            string ballWord = " шаров.";
            if (countCaughtBalls == 1) ballWord = " шар.";
            else if (countCaughtBalls > 1 && countCaughtBalls < 5) ballWord = " шара.";
            countCaughtBallsLabel.Text = "Вы поймали " + Environment.NewLine + countCaughtBalls + ballWord;
        }
    }
}
