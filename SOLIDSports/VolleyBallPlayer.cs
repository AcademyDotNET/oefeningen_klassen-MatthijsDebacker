using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSports
{
    public enum Classes
    {
        First,
        Second,
        Third,
        Fourth
    }

    class VolleyBallPlayer : IBallPlayer
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public Classes Class { get; set; }
        public ILogger PlayerLogger { get; set; }

        public VolleyBallPlayer(string name, int number = 1, Classes cl = Classes.Fourth, ILogger logger = null)
        {
            Name = name;
            Number = number;
            Class = cl;
            if(logger == null)
            {
                PlayerLogger = new Logger();
            }
            else
            {
                PlayerLogger = logger;
            }
        }

        public void Pass(IBallPlayer player)
        {
            PlayerLogger.LogToConsole($"{Name} passed the ball to {((VolleyBallPlayer)player).Name}");
            Random rand = new Random();

            if(rand.Next(0,2) == 1)
            {
                ((VolleyBallPlayer)player).Catch(this);
            }
            else
            {
                ((VolleyBallPlayer)player).Drop(this);
            }
        }

        public void Catch(IBallPlayer player)
        {
            PlayerLogger.LogToConsole($"{Name} caught the ball passed by {((VolleyBallPlayer)player).Name}");
        }

        public void Drop(IBallPlayer player)
        {
            PlayerLogger.LogToConsole($"{Name} dropped the ball passed ny {((VolleyBallPlayer)player).Name}");
        }

        public void Retire()
        {
            PlayerLogger.LogToConsole($"{Name}, number {Number} retires.");
        }
    }
}
