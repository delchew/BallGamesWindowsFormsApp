using BallsCommon.Properties;
using System.Windows.Forms;

namespace BallsCommon
{
    public class BlueMolecularBallPictureBox : MolecularBallPictureBox
    {
        public BlueMolecularBallPictureBox(Form form) : base(form)
        {
            Image = Resources.blueBall;
            Left = random.Next(form.ClientSize.Width / 2, form.ClientSize.Width - 2 * radius);
        }
    }
}
