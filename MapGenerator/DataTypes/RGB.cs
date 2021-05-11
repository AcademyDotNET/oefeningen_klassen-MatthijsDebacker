using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapGenerator.DataTypes
{
    class RGB
    {
        private int r;

        public int R
        {
            get { return r; }
            set 
            { 
                r = Math.Clamp(value, 0, 255); 
            }
        }

        private int g;

        public int G
        {
            get { return g; }
            set 
            { 
                g = Math.Clamp(value, 0, 255); 
            }
        }

        private int b;

        public int B
        {
            get { return b; }
            set 
            { 
                b = Math.Clamp(value, 0, 255); 
            }
        }
        
        public RGB(int rIn = 0, int gIn = 0, int bIn = 0)
        {
            R = rIn;
            G = gIn;
            B = bIn;
        }

        public void SetOverFlowRGB(int rIn, int gIn, int bIn)
        {
            // R
            if (rIn > 255)
            {
                R = rIn - 255;
            }
            else if (rIn < 0)
            {
                R = rIn + 255;
            }
            else
            {
                R = rIn;
            }

            // G
            if (gIn > 255)
            {
                G = gIn - 255;
            }
            else if (gIn < 0)
            {
                G = gIn + 255;
            }
            else
            {
                G = gIn;
            }

            // B
            if (bIn > 255)
            {
                B = bIn - 255;
            }
            else if (bIn < 0)
            {
                B = bIn + 255;
            }
            else
            {
                B = bIn;
            }
        }
    }
}
