using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BallsCommon;

namespace BallsSalute
{
    public partial class SaluteForm : Form
    {
        private readonly GameField gameField;
        private readonly Random random;
        private readonly BufferedGraphicsContext graphicsContext;
        private readonly BufferedGraphics drawBallsBuffer;
        public SaluteForm()
        {
            InitializeComponent();
            graphicsContext = BufferedGraphicsManager.Current; //Двойная буфферизация графики вручную.
            drawBallsBuffer = graphicsContext.Allocate(CreateGraphics(), ClientRectangle);
            //Закрашиваем область рисования в цвет фона через буфер, чтобы потом не красилось чёрным:
            drawBallsBuffer.Graphics.FillRectangle(new SolidBrush(BackColor), ClientRectangle);
            gameField = new GameField(drawBallsBuffer, ClientRectangle, BackColor);
            random = new Random();
        }

        private void SaluteForm_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < random.Next(10, 16); i++)
            {
                var ball = new RandomColorJumpingExplodeBall(gameField, e.X, e.Y);
                ball.Show();
                ball.StartMove();

            }

        }
    }
}
