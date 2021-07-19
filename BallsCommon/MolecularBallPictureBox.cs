using System;
using System.Windows.Forms;

namespace BallsCommon
{
    public class MolecularBallPictureBox : BallPictureBox
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
        public MolecularBallPictureBox(Form form) : base (form)
        {
            Left = random.Next(0, form.ClientSize.Width - 2 * radius);
            Top = random.Next(0, form.ClientSize.Height - 2 * radius);
            SetFieldSide();
        }

        protected override void Go()
        {
            base.Go();
            if (Left <= 0 || Left + 2 * radius >= form.ClientSize.Width)
            {
                vx = -vx;
                OnHited?.Invoke(this, EventArgs.Empty);
            };

            if (Top <= 0 || Top + 2 * radius >= form.ClientSize.Height)
            {
                vy = -vy;
                OnHited?.Invoke(this, EventArgs.Empty);
            }
            SetFieldSide();
        }

        private void SetFieldSide()
        {
            if (Left > form.ClientSize.Width / 2)
            {
                FieldSide = GameFieldSide.rightSide;
            }
            else if (Left + 2 * radius < form.ClientSize.Width / 2)
            {
                FieldSide = GameFieldSide.leftSide;
            }
        }
    }
}
