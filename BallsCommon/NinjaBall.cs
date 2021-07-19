using System;

namespace BallsCommon
{
    public class NinjaBall : RandomColorJumpingExplodeBall
    {
        public NinjaBall(GameField field, int ballAppearPlaseX) : base(field, ballAppearPlaseX, field.Borders.Bottom)
        {
            centerX = ballAppearPlaseX;
            radius = random.Next(40, 60);
            vx = random.Next(-3, 3);
            vy = random.Next(-15, -5);
            timer.Interval = 18;
        }

        protected override void Go()
        {
            saluteTime += timer.Interval;
            t += 0.17;
            centerX += (int)(v * Math.Cos(angle) * t);
            centerY -= (int)(v * Math.Sin(angle) * t - g * t * t / 2);
            if(centerY - radius > gameField.Borders.Bottom)
            {
                StopMove();
            }
        }
    }
}
