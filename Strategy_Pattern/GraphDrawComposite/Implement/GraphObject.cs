using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GraphDrawComposite
{
    public abstract class GrahObject : IGrahObject
    {
        public abstract IList<IGrahObject> Children { get; }

        public void Draw(Graphics graphics)
        {
            DrawSelft(graphics);
            foreach (IGrahObject child in Children)
            {
                child.Draw(graphics);
            }
        }

        protected virtual void DrawSelft(Graphics g) { }
         
    }
}
