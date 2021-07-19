using System;

namespace BallsCommon
{
    public class RandomMoveAndExplodeBorderReboundBall : RandomMoveAndExplodeBall
    {
        public static int CountBounds { get; private set; }
        public event EventHandler<HitEventArgs> OnHited;
        public RandomMoveAndExplodeBorderReboundBall(GameField field) : base(field)
        {
            ResetCountBounds();
        }

        public static void ResetCountBounds()
        {
            CountBounds = 0;
        }

        protected override void Go()
        {
            base.Go();
            if (centerX - radius <= gameField.Borders.Left)
            {
                vx = -vx;
                CountBounds++;
                OnHited?.Invoke(this, new HitEventArgs(HitType.Left));
            };
            if (centerX + radius >= gameField.Borders.Right)
            {
                vx = -vx;
                CountBounds++;
                OnHited?.Invoke(this, new HitEventArgs(HitType.Right));
            }
            if (centerY - radius <= gameField.Borders.Top)
            {
                vy = -vy;
                CountBounds++;
                OnHited?.Invoke(this, new HitEventArgs(HitType.Top));
            }
            if(centerY + radius >= gameField.Borders.Bottom)
            {
                vy = -vy;
                CountBounds++;
                OnHited?.Invoke(this, new HitEventArgs(HitType.Down));
            }
        }
    }
}
