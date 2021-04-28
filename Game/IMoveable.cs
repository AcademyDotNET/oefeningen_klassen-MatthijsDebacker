using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public enum Direction
    {
        Left = 37,
        Up = 38,
        Right = 39,
        Down = 40
    }

    public interface IMoveable
    {
        public void Move(Direction dir, int  dist = 1);
    }
}
