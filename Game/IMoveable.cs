using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public enum Directions
    {
        Left = 37,
        Up = 38,
        Right = 39,
        Down = 40,
        Random = 50
    }
    interface IMoveable
    {
        public void Move(Directions direction, int distance = 1);
    }
}
