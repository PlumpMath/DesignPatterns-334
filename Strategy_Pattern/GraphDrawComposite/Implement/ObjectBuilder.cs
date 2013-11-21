using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GraphDrawComposite
{
    public class ObjectBuilder : GrahObject
    {
        List<IGrahObject> _list = new List<IGrahObject>();
        public override IList<IGrahObject> Children
        {
            get { return _list; }
        }
    }
}
