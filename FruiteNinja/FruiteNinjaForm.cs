using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BallsCommon;

namespace FruiteNinja
{
    public partial class FruiteNinjaForm : Form
    {
        private readonly GameField gameField;
        private readonly Timer ballJumpOutTimer;
        private readonly Random random = new Random();
        private readonly int baseTimerInterval = 1800;
        private int score;
        private List<NinjaBall> ninjaBallsList;
        private readonly BufferedGraphicsContext graphicsContext;
        private readonly BufferedGraphics drawBallsBuffer;
        public FruiteNinjaForm()
        {
            InitializeComponent();
            ninjaBallsList = new List<NinjaBall>();
            graphicsContext = BufferedGraphicsManager.Current; //Двойная буфферизация графики вручную.
            drawBallsBuffer = graphicsContext.Allocate(pictureBox.CreateGraphics(), pictureBox.ClientRectangle);
            //Закрашиваем область рисования в цвет фона через буфер, чтобы потом не красилось чёрным:
            drawBallsBuffer.Graphics.FillRectangle(new SolidBrush(pictureBox.BackColor), pictureBox.ClientRectangle);
            gameField = new GameField(drawBallsBuffer, pictureBox.ClientRectangle, pictureBox.BackColor);
            ballJumpOutTimer = new Timer
            {
                Interval = baseTimerInterval,
                Enabled = false
            };
            ballJumpOutTimer.Tick += BallJumpOutTimer_Tick;
        }

        private void BallJumpOutTimer_Tick(object sender, EventArgs e)
        {
            CreateAndShootBalls();
            (sender as Timer).Interval = baseTimerInterval + random.Next(-500, 1000);
        }

        private void CreateAndShootBalls()
        {
            ninjaBallsList.Clear();
            for (int i = 0; i < random.Next(1, 4); i++)
            {
                var ballAppearPlaseX = random.Next(gameField.Borders.Width / 3, gameField.Borders.Width * 2 / 3);
                var ball = new NinjaBall(gameField, ballAppearPlaseX);
                ninjaBallsList.Add(ball);
                ball.Show();
                ball.StartMove();
            }  
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ballJumpOutTimer.Enabled = !ballJumpOutTimer.Enabled;
            if (ballJumpOutTimer.Enabled)
            {
                CreateAndShootBalls();
                pictureBox.MouseDown += PictureBox_MouseDown;
            }
            else
            {
                score = 0;
                scoreLabel.Text = score.ToString();
                pictureBox.MouseDown -= PictureBox_MouseDown;
            }
            (sender as Button).Text = ballJumpOutTimer.Enabled ? "Завершить игру" : "Начать игру";
        }


        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            foreach(var ball in ninjaBallsList)
            {
                if (ball.OnTouch(e.X, e.Y))
                {
                    ball.Explode();
                    score++;
                    scoreLabel.Text = score.ToString();
                }
            }

        }
    }
}
