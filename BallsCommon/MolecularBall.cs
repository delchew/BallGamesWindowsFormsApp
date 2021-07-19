using System;

namespace BallsCommon
{
    public class MolecularBall : RandomMoveBall
    {
        private GameFieldSide fieldSide;
        public GameFieldSide FieldSide
        {
            get { return fieldSide; }
            set
            {
                if (fieldSide != value)
                {
                    fieldSide = value;
                    FieldSideChanged?.Invoke(this, new StepEventArgs(FieldSide));
                }
            }
        }
        public event EventHandler<StepEventArgs> FieldSideChanged;
        public event EventHandler OnHited;

        public MolecularBall(GameField field) : base(field) 
        {
            radius = 30;
            SetFieldSide();
        }

        protected override void Go()
        {
            base.Go();
            if (centerX - radius <= gameField.Borders.Left || centerX + radius >= gameField.Borders.Right)
            {
                vx = -vx;
                OnHited?.Invoke(this, EventArgs.Empty);
            };

            if (centerY - radius <= gameField.Borders.Top || centerY + radius >= gameField.Borders.Bottom)
            {
                vy = -vy;
                OnHited?.Invoke(this, EventArgs.Empty);
            }
            SetFieldSide();
        }

        private void SetFieldSide()
        {
            if (centerX - radius > gameField.Borders.Right / 2)
            {
                FieldSide = GameFieldSide.rightSide;
            }
            else if (centerX + radius < gameField.Borders.Right / 2)
            {
                FieldSide = GameFieldSide.leftSide;
            }
        }

        public void SwitchMove()
        {
            timer.Enabled = !timer.Enabled;
        }
    }
}
