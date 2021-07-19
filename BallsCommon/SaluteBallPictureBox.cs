using System.Windows.Forms;

namespace BallsCommon
{
    public class SaluteBallPictureBox : BallPictureBox
    {
        protected const float g = 1f;
        protected double saluteTime;
        protected double ballLiveTime = 700;
        public SaluteBallPictureBox(Form form, float centerX, float centerY) : base(form)
        {
            Left = (int)centerX - radius;
            Top = (int)centerY - radius;
            vx = GetNonZeroSpeed(10);
            vy = (float)(random.NextDouble() - 4) * 5;
        }

        protected override void Go()
        {
            base.Go();
            saluteTime += timer.Interval;
            if (saluteTime >= ballLiveTime + random.Next(0, 400))
            {
                Explode();
                return;
            }
            vy += g;
        }
    }
}
