using System;

namespace BallsCommon
{
    public class HitEventArgs : EventArgs
    {
        public HitType Type { get; }
        public HitEventArgs(HitType type)
        {
            Type = type;
        }
    }
}
