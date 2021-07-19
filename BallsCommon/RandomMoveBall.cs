using System;

namespace BallsCommon
{
    public class RandomMoveBall : Ball
    {
        protected static Random random = new Random();
        public RandomMoveBall(GameField field) : base(field)
        {
            vx = GetNonZeroSpeed(8);
            vy = GetNonZeroSpeed(8);
            centerX = random.Next(radius, gameField.Borders.Right - radius);
            centerY = random.Next(radius, gameField.Borders.Bottom - radius);
        }

        protected int GetNonZeroSpeed(int max)
        {
            int speed;
            do
            {
                speed = random.Next(-max, max);
            }
            while (speed == 0);
            return speed;
        }
    }
}
