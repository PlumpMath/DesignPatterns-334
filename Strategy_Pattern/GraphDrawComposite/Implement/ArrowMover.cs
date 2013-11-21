using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphDrawComposite
{
    public class ArrowMover
    {
        List<IMovable> _movableList = new List<IMovable>();
        public List<IMovable> MovableList { get { return _movableList; } }
        public void Move(Direction direction)
        {
            foreach (IMovable movable in MovableList)
            {
                switch (direction)
                {
                    case Direction.Left:
                        movable.X -= SpeedStrategy.Speed;
                        break;
                    case Direction.Right:
                        movable.X += SpeedStrategy.Speed;
                        break;
                    default:
                        break;
                }
            }
        }
        public IMoverStrategy SpeedStrategy { get; set; }
    }

}
