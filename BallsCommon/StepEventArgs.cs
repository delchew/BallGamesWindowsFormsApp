using System;

namespace BallsCommon
{
    public class StepEventArgs : EventArgs
    {
        public GameFieldSide FieldSide { get; }
        public StepEventArgs(GameFieldSide fieldSide)
        {
            FieldSide = fieldSide;
        }
    }
}
