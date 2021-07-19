using System;
using System.Windows.Forms;

namespace BallsCommon
{
    public class NinjaBallPictureBox : BallPictureBox
    {
        public static int CountBallsCaught {get; private set;}
        protected const float g = 1f;
        public event EventHandler<EventArgs> Clicked;
        public NinjaBallPictureBox(Form form, float ballAppearPlaseX) : base(form)
        {
            Left = (int)ballAppearPlaseX - radius;
            Top = form.ClientSize.Height;
            radius = random.Next(40, 60);
            timer.Interval = 18;
            vx = GetNonZeroSpeed(10);
            vy = (float)(random.NextDouble() - 5) * 6;
            MouseDown += NinjaBallPictureBox_MouseDown;
        }

        private void NinjaBallPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Explode();
            CountBallsCaught++;
            Clicked?.Invoke(this, EventArgs.Empty);
        }

        protected override void Go()
        {
            base.Go();
            vy += g;
        }
        
    }
}
