using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GameManager
    {
        private Random rand;
        public int GameWidth { get; set; }
        public int GameHeight { get; set; }
        public Point Margin { get; set; }
        public Player GamePlayer { get; set; }
        public List<Rock> Terrain { get; set; }
        public List<Monster> Monsters { get; set; }
        public bool GameWon { get; set; } = false;

        public GameManager(Point margin, int width = 20, int height = 20)
        {
            rand = new Random();
            GameWidth = width;
            GameHeight = height;

            if(margin == null)
            {
                Margin = new Point();
            }
            else
            {
                Margin = margin;
            }

            GamePlayer = new Player(new Point(Margin.X + 1, Margin.Y + GameHeight / 2), 'X');

            Terrain = new List<Rock>();
            GenerateTerrain(0.05);

            Monsters = new List<Monster>();
            SpawnMonsters(5);
        }

        public void Update(ConsoleKey key)
        {
            // PLAYER
            GamePlayer.InputKey = key;
            GamePlayer.Update();

            if (GamePlayer.Location.X <= Margin.X || GamePlayer.Location.Y <= Margin.Y || GamePlayer.Location.Y >= Margin.Y + GameHeight - 1)
            {
                GamePlayer.SetBack();
            }

            if (key == ConsoleKey.S)
            {
                ShootAt(GamePlayer.Shoot());
            }

            // Collision
            foreach (MapElement rock in Terrain)
            {
                MapElement.Collision(GamePlayer, rock);
            }
            foreach (MapElement monster in Monsters)
            {
                MapElement.Collision(GamePlayer, monster);
            }

            // MONSTERS
            foreach (Monster monster in Monsters)
            {
                monster.Update();
                if (monster.Location.X <= Margin.X || monster.Location.Y <= Margin.Y || monster.Location.Y >= Margin.Y + GameHeight - 1 || monster.Location.X >= Margin.X + GameWidth * 2 - 1)
                {
                    monster.SetBack();
                }
            }

            // Collision
            foreach (MapElement monster in Monsters)
            {
                MapElement.Collision(monster, GamePlayer);

                foreach (MapElement rock in Terrain)
                {
                    MapElement.Collision(monster, rock);
                }
            }

            if (GamePlayer.Location.X >= Margin.X + GameWidth * 2 - 1)
            {
                GameWon = true;
            }
        }

        public void Draw()
        {
            GamePlayer.Draw();

            foreach (Monster monster in Monsters)
            {
                monster.Draw();
            }
        }

        public void GenerateTerrain(double rockChance)
        {
            for (int w = Margin.X; w < Margin.X + GameWidth * 2; w++)
            {
                for (int h = Margin.Y; h < Margin.Y + GameHeight; h++)
                {
                    if(w == Margin.X || w == Margin.X + GameWidth * 2 - 1
                        || h == Margin.Y || h == Margin.Y + GameHeight - 1)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(w, h);
                        Console.Write('W');
                        Console.ResetColor();
                    }
                    else if(rand.NextDouble() < rockChance && (w % 2 == 0))
                    {
                        Rock rock = new Rock(new Point(w, h));
                        Terrain.Add(rock);
                        rock.Draw();
                    }
                    else
                    {
                        Console.SetCursorPosition(w, h);
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }

        public void SpawnMonsters(int nrMonsters)
        {
            // Divide game field in sections based on nrMonsters and place a monster randomly in each section
            int dY = GameWidth / nrMonsters;

            for (int i = 0; i < nrMonsters; i++)
            {
                Monster monster;
                // Pick a type at random
                int type = rand.Next(0, 2);
                if (type == 0)
                {
                    monster = new Monster(Point.RandomPoint(Margin.X + 1, Margin.X + GameWidth * 2 - 1, Margin.Y + 1 + i * dY, Margin.Y + dY - 1 + i * dY), 'M');
                }
                else
                {
                    monster = new RockDestroyer(Point.RandomPoint(Margin.X + 1, Margin.X + GameWidth * 2 - 1, Margin.Y + 1 + i * dY, Margin.Y + dY - 1 + i * dY), 'D');
                }

                for (int r = 0; r < Terrain.Count; r++)
                {
                    if (monster.Location.Equals(Terrain[r].Location))
                    {
                        Terrain.RemoveAt(r);
                        r--;
                    }
                }

                Monsters.Add(monster);
            }
        }

        public void ShootAt(Point target)
        {
            if(target.Equals(GamePlayer.Location))
            {
                GamePlayer.LoseHealth();
                return;
            }

            for (int i = 0; i < Terrain.Count; i++)
            {
                if (target.Equals(Terrain[i].Location))
                {
                    Terrain.RemoveAt(i);
                    Console.SetCursorPosition(target.X, target.Y);
                    Console.Write(' ');
                    return;
                }
            }
            for (int i = 0; i < Monsters.Count; i++)
            {
                if (target.Equals(Monsters[i].Location))
                {
                    Monsters.RemoveAt(i);
                    Console.SetCursorPosition(target.X, target.Y);
                    Console.Write(' ');
                    return;
                }
            }
        }
    }
}
