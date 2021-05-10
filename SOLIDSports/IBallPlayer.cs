using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSports
{
    interface IBallPlayer
    {
        public void Pass(IBallPlayer player);
        public void Catch(IBallPlayer player);
        public void Drop(IBallPlayer player);

        public void Retire();
    }
}
