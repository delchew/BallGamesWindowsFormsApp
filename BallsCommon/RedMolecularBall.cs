using System.Drawing;

namespace BallsCommon
{
    public class RedMolecularBall : MolecularBall
    {
        public RedMolecularBall(GameField field) : base(field)
        {
            color = Color.OrangeRed;
            centerX = random.Next(radius, gameField.Borders.Right / 2 - radius);
        }
    }
}
