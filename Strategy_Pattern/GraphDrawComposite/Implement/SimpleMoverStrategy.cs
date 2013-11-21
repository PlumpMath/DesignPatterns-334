using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphDrawComposite.Implement
{
    public class SimpleMoverStrategy : IMoverStrategy
    {
        public float Speed
        {
            get { return 1; }
        }
    }
}
