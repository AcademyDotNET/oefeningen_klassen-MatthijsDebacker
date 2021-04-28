using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GameManager
    {
        public int GameHeight { get; set; }
        public int GameWidth { get; set; }
        public Player GamePlayer { get; }
        public List<MapElement> Monsters { get; }
        public List<MapElement> TerrainElements { get; set; }

        private Random rand;

        public GameManager(Player player = null, int height = 30, int width = 30)
        {
            Monsters = new List<MapElement>();
            TerrainElements = new List<MapElement>();
            GameHeight = height;
            GameWidth = width;
            rand = new Random();

            // Player initialization
            if(player == null)
            {
                GamePlayer = new Player(new Point(1,rand.Next(0, GameHeight)), 'X');
            }
            else
            {
                GamePlayer = player;
            }

            // Basic game setup
            GenerateTerrain(0.05);
            SpawnMonsters(5);
            DrawTerrain();
        }

        private void GenerateTerrain(double rockChance)
        {
            // Based on the rockChance, add rocks on the game field
            double chance = 0;
            for (int h = 0; h < GameHeight; h++)
            {
                for (int w = 0; w < GameWidth; w++)
                {
                    chance = rand.NextDouble();
                    if(chance < rockChance && !GamePlayer.Location.Equals(new Point(w,h)))
                    {
                        TerrainElements.Add(new Rock(new Point(w, h)));
                    }
                }
            }
        }

        private void SpawnMonsters(int nrMonsters)
        {
            // Divide game field in sections based on nrMonsters and place a monster randomly in each section
            //int dX = GameWidth / nrMonsters;
            int dY = GameWidth / nrMonsters;
            // Add some distance to the section edges
            int dist = 2;

            for (int i = 0; i < nrMonsters; i++)
            {
                Monster monster;
                // Pick a type at random
                int type = rand.Next(0, 2);
                if(type == 0)
                {
                    monster = new Monster(Point.RandomPoint(dist, GameWidth - dist, dist + i * dY, dY - dist + i * dY), 'M');
                }
                else
                {
                    monster = new RockDestroyer(Point.RandomPoint(dist, GameWidth - dist, dist + i * dY, dY - dist + i * dY), 'D');
                }

                for (int r = 0; r < TerrainElements.Count; r++)
                {
                    if (monster.Location.Equals(TerrainElements[r].Location))
                    {
                        TerrainElements.RemoveAt(r);
                        r--;
                    }
                }

                Monsters.Add(monster);
            }
        }

        public void Update()
        {
            GamePlayer.Update();

        }

        public void Draw()
        {
            GamePlayer.Draw();
            foreach (MapElement monster in Monsters)
            {
                monster.Draw();
            }

            Console.SetCursorPosition(0, GameHeight);
        }

        public void DrawTerrain()
        {
            foreach (MapElement element in TerrainElements)
            {
                element.Draw();
            }
        }
    }
}
