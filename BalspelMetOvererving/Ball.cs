using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalspelMetOvererving
{
    class Ball
    {
        public int X { get { return x; } }
        public int Y { get { return y; } }
        public int Size { get { return size; } }
        private int x = 0;
        private int y = 0;
        private int size = 0;
        protected int vx = 0;
        protected int vy = 0;
        protected char drawChar = 'O';
        protected ConsoleColor drawColor = ConsoleColor.Red;

        public Ball(int xin, int yin, int vxin, int vyin, char drawCharIn = 'O', int sizeIn = 0)
        {
            x = xin;
            y = yin;
            vx = vxin;
            vy = vyin;
            drawChar = drawCharIn;
            size = (int)Math.Floor(Math.Clamp(sizeIn, 0, 5) / 2.0);
        }

        public void Update()
        {
            Console.SetCursorPosition(x, y);
            for (int i = -size; i <= size; i++)
            {
                for (int j = -size; j <= size; j++)
                {
                    Console.SetCursorPosition(x + i, y + j);
                    Console.Write(' ');
                }
            }

            x += vx;
            y += vy;
            if (x >= Console.WindowWidth - size || x < 0 + size)
            {
                vx *= -1;
                x += vx;
            }
            if (y >= Console.WindowHeight - size || y < 0 + size)
            {
                vy *= -1;
                y += vy;
            }
        }
        public void Draw()
        {
            Console.ForegroundColor = drawColor;
            for (int i = -size; i <= size ; i++)
            {
                for (int j = -size; j <= size; j++)
                {
                    Console.SetCursorPosition(x + i, y + j);
                    Console.Write(drawChar);
                }
            }

            Console.ResetColor();
        }

        static public bool CheckHit(Ball ball1, Ball ball2, bool collide = false)
        {
            int distX = Math.Abs(ball1.X - ball2.X);
            int distY = Math.Abs(ball1.Y - ball2.Y);
            if((distX <= ball1.Size || distX <= ball2.Size) && (distY <= ball1.Size || distY <= ball2.Size))
            {
                if(collide)
                {
                    Collide(ball1, ball2);
                }
                return true;
            }

            return false;
        }

        static public void Collide(Ball ball1, Ball ball2)
        {
            // Gets negated instantly for now
            ball1.vx *= -1;
            ball1.vy *= -1;
            ball2.vx *= -1;
            ball2.vy *= -1;
        }
    }
}
