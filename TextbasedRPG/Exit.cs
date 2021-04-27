using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextbasedRPG
{
    enum Directions
    {
        North,
        East,
        South,
        West
    }

    class Exit
    {
        public Directions ExitDirection { get; set; }
        public Location GoesToLocation { get; set; }
        public List<GameObject> NeededObjects { get; set; }

        public Exit()
        {
            NeededObjects = new List<GameObject>();
        }

        public bool TestPassCondition(List<GameObject> playerInventory)
        {
            int passCount = 0;
            for (int i = 0; i < NeededObjects.Count; i++)
            {
                if(playerInventory.Contains(NeededObjects[i]))
                {
                    passCount++;
                }
            }

            if (passCount == NeededObjects.Count)
            {
                return true;
            }
            return false;
        }
    }
}
