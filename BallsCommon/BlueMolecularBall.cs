using System.Drawing;

namespace BallsCommon
{
    public class BlueMolecularBall : MolecularBall
    {
        public BlueMolecularBall(GameField field) : base(field)
        {
            color = Color.BlueViolet;
            centerX = random.Next(radius + gameField.Borders.Right / 2, gameField.Borders.Right - radius);
        }
    }
}
