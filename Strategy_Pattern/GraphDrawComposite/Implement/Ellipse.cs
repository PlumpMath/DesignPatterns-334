using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GraphDrawComposite
{
    public class Ellipse : GrahObject, IMovable
    {
        public Ellipse(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public float X { get; set; }
        public float Y { get; set; }

        public float SpeedX { get; set; } 
        public float SpeedY { get; set; }

        private List<IGrahObject> _child = new List<IGrahObject>();

        protected override void DrawSelft(Graphics g)
        {
            g.FillEllipse(Brushes.Black, this.X, this.Y, 10, 10);
        }

        public override IList<IGrahObject> Children
        {
            get { return _child; }
        }



    }

}
