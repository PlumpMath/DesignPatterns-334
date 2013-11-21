using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphDrawComposite
{
    public interface IMovable
    {
        float X { get; set; }
        float Y { get; set; }
        float SpeedX { get; set; }
        float SpeedY { get; set; }
    }
}
