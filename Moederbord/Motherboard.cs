using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moederbord
{
    class Motherboard
    {
        public CPU CPUSlot { get; set; }
        public PCI PCISlot { get; set; }
        public ISA ISASlot { get; set; }
        public PowerSupply Power { get; set; }

        private List<RAM> ramSlots = new List<RAM>();
        public List<RAM> RAMSlots
        {
            get
            {
                return ramSlots;
            }
            set
            {
                if (value.Count >= 2 && value.Count <= 4)
                {
                    ramSlots = value;
                }
            }
        }

        public void TestMotherboard()
        {
            Console.WriteLine("The following components are still empty:");
            if (CPUSlot == null)
            {
                Console.WriteLine("CPU");
            }
            if (PCISlot == null)
            {
                Console.WriteLine("PCI");
            }
            if (ISASlot == null)
            {
                Console.WriteLine("ISA");
            }
            if (Power == null)
            {
                Console.WriteLine("Power Supply");
            }
            if(ramSlots.Count == 0)
            {
                Console.WriteLine("RAM");
            }
        }
    }
}
