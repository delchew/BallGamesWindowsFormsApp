using System;

namespace BallsCommon
{
    public class RandomMoveAndExplodeBorderExplodeBall : RandomMoveAndExplodeBall
    {
        public event EventHandler OnHited;
        public RandomMoveAndExplodeBorderExplodeBall(GameField field) : base(field)
        {

        }

        protected override void Go()
        {
            base.Go();
            if (centerX - radius <= gameField.Borders.Left || centerX + radius >= gameField.Borders.Right ||
                centerY - radius <= gameField.Borders.Top ||centerY + radius >= gameField.Borders.Bottom)
            {
                Explode();
                OnHited?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}