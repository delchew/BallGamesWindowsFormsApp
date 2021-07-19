using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallsCommon
{
    public class Ball
    {
        protected GameField gameField;
        protected Color color = Color.Blue;
        protected int vx = 1;
        protected int vy = 1;
        protected int centerX = 150;
        protected int centerY = 150;
        protected int radius = 35;
        protected Timer timer;

        public Ball(GameField field)
        {
            gameField = field;
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        public void Show()
        {
            Draw(new SolidBrush(color));
        }

        public void StartMove()
        {
            timer.Start();
        }

        public void StopMove()
        {
            timer.Stop();
        }

        public bool OnTouch(int x, int y)
        {
            return Math.Pow((this.centerX - x), 2) + Math.Pow((this.centerY - y), 2) <= radius * radius;
        }

        protected void Show(Color color)
        {
            Draw(new SolidBrush(color));
        }

        protected void Move()
        {
            Clear();
            Go();
            Show(color);
        }

        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;
        }

        private void Clear()
        {
            Draw(new SolidBrush(gameField.Color));
        }

        private void Draw(Brush brush)
        {
            var rectangle = new Rectangle(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            gameField.DrawBallsBuffer.Graphics.FillEllipse(brush, rectangle);
            gameField.DrawBallsBuffer.Render();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }
    }
}
