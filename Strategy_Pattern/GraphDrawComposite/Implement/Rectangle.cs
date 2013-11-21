using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GraphDrawComposite
{
    public class Rectangle : GrahObject, IMovable
    {
        public Rectangle(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public float X { get; set; }
        public float Y { get; set; }
        public float SpeedX { get; set; }
        public float SpeedY { get; set; }

        private List<IGrahObject> _list = new List<IGrahObject>();

        public override IList<IGrahObject> Children
        {
            get { return _list; }
        }

        protected override void DrawSelft(Graphics g)
        {
            g.FillRectangle(Brushes.Red, this.X, this.Y, 50, 30);
        }




    }

}
