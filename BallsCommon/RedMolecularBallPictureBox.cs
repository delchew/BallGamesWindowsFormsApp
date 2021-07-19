using BallsCommon.Properties;
using System.Windows.Forms;

namespace BallsCommon
{
    public class RedMolecularBallPictureBox : MolecularBallPictureBox
    {
        public RedMolecularBallPictureBox(Form form) : base(form)
        {
            Image = Resources.redBall;
            Left = random.Next(0, form.ClientSize.Width / 2 - 2 * radius);
        }
    }
}
