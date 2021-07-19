using System;
using System.Windows.Forms;

namespace BallsCommon
{
    public class RandomMoveAndExplodeBall : RandomMoveBall
    {
        protected int growSpeed = 10;
        protected int growsCount = 0;
        protected Timer explodeTimer;
        
        public RandomMoveAndExplodeBall(GameField field) : base(field)
        {
            radius = random.Next(15, 50);
            explodeTimer = new Timer();
            explodeTimer.Interval = 30;
            explodeTimer.Tick += ExplodeTimer_Tick;
        }

        private RandomMoveAndExplodeBall(GameField gameField, int x, int y, int radius) : base(gameField)
        {
            this.gameField = gameField;
            this.centerX = x;
            this.centerY = y;
            this.radius = radius;
        }

        public void Explode()
        {
            StopMove();
            timer.Dispose();
            explodeTimer.Start();
        }

        private void ExplodeTimer_Tick(object sender, EventArgs e)
        {
            var timer = (sender as Timer);
            var holeDiameter = growSpeed + growSpeed * growsCount;
            var hole = new RandomMoveAndExplodeBall(gameField, centerX, centerY , holeDiameter / 2);
            hole.Show(gameField.Color);
            growsCount++;

            if (growsCount > 2 * radius / growSpeed)
            {
                timer.Stop();
                timer.Dispose();
            }
        }
    }
}
