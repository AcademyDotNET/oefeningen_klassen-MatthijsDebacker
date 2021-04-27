using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMaker
{
    class CouchElement : FurnitureElement
    {
        public CouchElement()
        {
            Price = 100.0;
            DrawChar = '+';
            UnitSize = 2;
        }

        public CouchElement(Point locationIn, double priceIn, char drawCharIn, int unitSizeIn = 2) : base(locationIn, priceIn, drawCharIn, unitSizeIn)
        {
        }
    }
}
