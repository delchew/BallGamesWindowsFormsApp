using System;
using System.Drawing;

namespace BallsCommon
{
    public class RandomColorJumpingExplodeBall : RandomMoveAndExplodeBall
    {
        protected const double g = 9.8;
        protected readonly double v;
        protected readonly double angle;
        protected double saluteTime;
        protected double t = 1;
        private readonly Color[] ballsColors =
        {
            Color.LightBlue,
            Color.IndianRed,
            Color.LawnGreen,
            Color.OrangeRed,
            Color.Violet,
            Color.Pink,
            Color.LemonChiffon,
            Color.Aquamarine,
            Color.Yellow
        };
        
        public RandomColorJumpingExplodeBall(GameField gameField, int centerX, int centerY) : base(gameField)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            radius = random.Next(10, 30);
            vx = GetNonZeroSpeed(6);
            vy = random.Next(-20, -15);
            color = GetRandomColor();
            v = Math.Sqrt(vx * vx + vy * vy);
            angle = Math.Acos(vx / v);
            saluteTime = 0;
        }

        private Color GetRandomColor()
        {
            return ballsColors[random.Next(0, ballsColors.Length)];
        }

        protected override void Go()
        {
            saluteTime += timer.Interval;
            t += 0.3;
            if(saluteTime >= 400 + random.Next(-100, 200))
            {
                Explode();
                return;
            }
            centerX += (int)(v * Math.Cos(angle) * t);
            centerY -= (int)(v * Math.Sin(angle) * t - g * t * t / 2);

        }
    }
}
