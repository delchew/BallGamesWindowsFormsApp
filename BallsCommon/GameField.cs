using System.Drawing;

namespace BallsCommon
{
    public class GameField
    {
        public Rectangle Borders { get; }
        public Color Color { get; }

        public BufferedGraphics DrawBallsBuffer { get; }

        public GameField(BufferedGraphics drawBallsBuffer, Rectangle borders, Color color)
        {
            DrawBallsBuffer = drawBallsBuffer;
            Borders = borders;
            Color = color;
        }

    }
}
