using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalspelMetOvererving
{
    class Vector2
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector2(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool CheckZero()
        {
            if (X == 0 && Y == 0)
            {
                return true;
            }
            return false;
        }
    }

    class Ball
    {
        public int X { get { return x; } }
        public int Y { get { return y; } }
        public int Size { get { return size; } }
        public Vector2 Force
        {
            get
            {
                return force;
            }
            set 
            { 
                force = value; 
            }
        }

        private int x = 0;
        private int y = 0;
        private int size = 0;
        protected int vx = 0;
        protected int vy = 0;
        protected Vector2 force;
        protected char drawChar = 'O';
        protected ConsoleColor drawColor = ConsoleColor.Red;
        protected List<Vector2> trailPositions;

        public Ball(int xin, int yin, int vxin, int vyin, char drawCharIn = 'O', int sizeIn = 0, int trailSize = 0)
        {
            x = xin;
            y = yin;
            vx = vxin;
            vy = vyin;
            drawChar = drawCharIn;
            size = (int)Math.Floor(Math.Clamp(sizeIn, 0, 5) / 2.0);

            force = new Vector2(0, 0);
            trailPositions = new List<Vector2>();
            for (int i = 0; i < trailSize; i++)
            {
                trailPositions.Add(new Vector2(xin, yin));
            }
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

            // Apply force if there is any
            if(!force.CheckZero())
            {
                vx += force.X;
                vy += force.Y;
            }

            if(trailPositions.Count > 0)
            {
                trailPositions.RemoveAt(0);
                trailPositions.Add(new Vector2(x, y));
            }
        }
        public void Draw()
        {
            Console.ForegroundColor = drawColor;

            if(trailPositions.Count > 0)
            {
                foreach (Vector2 pos in trailPositions)
                {
                    Console.SetCursorPosition(pos.X, pos.Y);
                    Console.Write(drawChar);
                }
            }

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
            ball1.vx += ball2.vx;
            ball1.vy += ball2.vy;
        }
    }
}
