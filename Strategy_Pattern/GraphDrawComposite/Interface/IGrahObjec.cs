using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GraphDrawComposite
{
    public interface IGrahObject
    {
        IList<IGrahObject> Children { get; }
        void Draw(Graphics graphics); 
         
    }
}
