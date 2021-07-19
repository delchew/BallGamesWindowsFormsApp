using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BallsCommon;

namespace FruiteNinjaPictureBox
{
    public partial class FruiteNinjaPictureBoxForm : Form
    {
        private readonly Timer ballJumpOutTimer;
        private readonly Random random = new Random();
        private readonly int baseTimerInterval = 2000;
        private List<NinjaBallPictureBox> ninjaBallsList;
        public FruiteNinjaPictureBoxForm()
        {
            InitializeComponent();
            ninjaBallsList = new List<NinjaBallPictureBox>();
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
            for (int i = 0; i < random.Next(1, 6); i++)
            {
                var ballAppearPlaseX = random.Next(ClientSize.Width / 3, ClientSize.Width * 2 / 3);
                var ball = new NinjaBallPictureBox(this, ballAppearPlaseX);
                ninjaBallsList.Add(ball);
                ball.Clicked += Ball_Clicked;
                ball.StartMove();
            }
        }

        private void Ball_Clicked(object sender, EventArgs e)
        {
            scoreLabel.Text = NinjaBallPictureBox.CountBallsCaught.ToString();
        }

        private void FruiteNinjaPictureBoxForm_Shown(object sender, EventArgs e)
        {
            ballJumpOutTimer.Start();
        }
    }
}
