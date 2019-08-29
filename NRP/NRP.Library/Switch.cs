using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRP.Library
{
    [Flags]
    enum Switch
    {
        Off = 0,
        Left = 1,
        Middle = 2,
        Right = 4,
        LeftMiddle = Left | Middle,
        RightMiddle = Right | Middle,
        LeftMiddleRight = Left | Middle | Right,
        All = LeftMiddleRight
    }
}
