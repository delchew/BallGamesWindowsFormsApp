using BallsCommon.Properties;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BallsCommon
{
    public class BallPictureBox : PictureBox
    {
        protected Form form;
        protected Timer timer;
        protected Timer explodeTimer;
        protected static Random random = new Random();
        protected static Image[] ballsImages =
        {
            Resources.blueBall,
            Resources.darkGreenBall,
            Resources.darkOrangeBall,
            Resources.darkViioletBall,
            Resources.greenBall,
            Resources.lightBlueBall,
            Resources.limeBall,
            Resources.orangeBall,
            Resources.pinkBall,
            Resources.redBall,
            Resources.violetBall,
            Resources.yellowBall
        };
        protected float vx;
        protected float vy;
        protected int radius = 35;

        public BallPictureBox(Form form)
        {
            this.form = form;
            Left = radius;
            Top = radius;
            vx = GetNonZeroSpeed(6);
            vy = GetNonZeroSpeed(6);
            Width = 2 * radius;
            Height = 2 * radius;
            Image = ballsImages[random.Next(0, ballsImages.Length)];
            SizeMode = PictureBoxSizeMode.StretchImage;

            var graphicsPath = BuildTransparencyPath();
            Region = new Region(graphicsPath);

            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;

            explodeTimer = new Timer();
            explodeTimer.Interval = 500;
            explodeTimer.Tick += ExplodeTimer_Tick;

            form.Controls.Add(this);
        }

        public void StartMove()
        {
            timer.Start();
        }

        public void StopMove()
        {
            timer.Stop();
        }

        public void Explode()
        {
            StopMove();
            timer.Dispose();
            Image = Resources.explode;
            explodeTimer.Start();
        }

        public bool IsMoving()
        {
            return timer.Enabled;
        }

        protected virtual void Go()
        {
            Left += (int)vx;
            Top += (int)vy; 
            if (this.OutOfBoard())
            {
                StopMove();
                timer.Dispose();
                explodeTimer.Dispose();
                this.Dispose();
            }
        }

        protected float GetNonZeroSpeed(int max)
        {
            float speed;
            do
            {
                speed = (float)(random.NextDouble() - 0.5 ) * 2 * max;
            }
            while (speed == 0);
            return speed;
        }

        protected bool OutOfBoard()
        {
            return Location.X + 2 * radius < 0 || Location.X > form.ClientSize.Width ||
                Location.Y + 2 * radius < 0 || Location.Y > form.ClientSize.Height;
        }

        private GraphicsPath BuildTransparencyPath()
        {
            var bitmap = new Bitmap(Image, Width, Height);
            var graphicsPath = new GraphicsPath();
            var mask = bitmap.GetPixel(0, 0);

            for (int x = 0; x <= bitmap.Width - 1; x++)
            {
                for (int y = 0; y <= bitmap.Height - 1; y++)
                {
                    if (!bitmap.GetPixel(x, y).Equals(mask))
                    {
                        graphicsPath.AddRectangle(new Rectangle(x, y, 1, 1));
                    }
                }
            }
            bitmap.Dispose();
            return graphicsPath;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Go();
        }

        private void ExplodeTimer_Tick(object sender, EventArgs e)
        {
            Image = null;
            explodeTimer.Stop();
            explodeTimer.Dispose();
            Dispose();
        }
    }
}
