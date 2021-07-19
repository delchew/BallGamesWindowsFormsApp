using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BallsCommon;

namespace SalutePictureBox
{
    public partial class SalutePictureBoxForm : Form
    {
        private readonly Random random = new Random();
        public SalutePictureBoxForm()
        {
            InitializeComponent();
        }

        private void SalutePictureBoxForm_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < random.Next(8, 16); i++)
            {
                var ball = new SaluteBallPictureBox(this, e.X, e.Y);
                ball.StartMove();
            }
        }
    }
}
