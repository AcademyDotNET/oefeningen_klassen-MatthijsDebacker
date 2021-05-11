using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapGenerator.DataTypes
{
    abstract class Vector
    {
        public abstract void Normalize();

        public abstract double GetLength();

        public abstract void Flip();
    }
}
