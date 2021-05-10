using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSports
{
    class MatchSimulator
    {
        List<IBallPlayer> Players { get; set; }
        public ILogger SimLogger { get; set; }

        public MatchSimulator(int nrOfPlayers, ILogger logger = null)
        {
            if(logger == null)
            {
                SimLogger = new Logger();
            }
            else
            {
                SimLogger = logger;
            }
            
            for (int i = 0; i < nrOfPlayers; i++)
            {
                Players.Add(new VolleyBallPlayer($"Player{i}", i + 1, Classes.Fourth, SimLogger));
            }
        }

        public void PlayMatch(int time)
        {

        }

        public void CreateTeam()
        {

        }
    }
}
