using System;
using System.Collections.Generic;

namespace BalspelMetOvererving
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.WindowHeight = 50;
            Console.WindowWidth = 60;

            List<Ball> enemies = new List<Ball>();
            enemies.Add(new Ball(4, 4, 1, 0));
            enemies.Add(new Ball(40, 4, 0, 1));
            enemies.Add(new Ball(4, 40, 1, 1));
            PlayerBall player = new PlayerBall(10, 10, 0, 0, 'X', 3);
            while (true)
            {

                //Console.Clear();

                //Ball
                foreach (Ball ball in enemies)
                {
                    ball.Update();
                    ball.Draw();
                }

                //SpelerBall
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    player.ChangeVelocity(key);
                }

                player.Update();
                player.Draw();

                //Check collisions
                foreach (Ball ball in enemies)
                {

                    if (Ball.CheckHit(ball, player))
                    {
                        Console.Clear();
                        Console.WriteLine("Gewonnen!");
                        Console.ReadLine();
                    }
                }

                for (int i = 0; i < enemies.Count; i++)
                {
                    for (int j = 0; j < enemies.Count; j++)
                    {
                        if(i != j)
                        {
                            Ball.CheckHit(enemies[i], enemies[j], true);
                        }
                    }
                }

                System.Threading.Thread.Sleep(30);
            }
        }
    }
}
