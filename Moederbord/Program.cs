using System;
using System.Collections.Generic;

namespace Moederbord
{
    class Program
    {
        static void Main(string[] args)
        {
            Motherboard motherBoard = new Motherboard();
            motherBoard.TestMotherboard();

            motherBoard.CPUSlot = new CPU();
            motherBoard.PCISlot = new PCI();
            motherBoard.ISASlot = new ISA();
            motherBoard.Power = new PowerSupply();
            List<RAM> ramSlots = new List<RAM>();
            ramSlots.Add(new RAM());
            ramSlots.Add(new RAM());
            motherBoard.RAMSlots = ramSlots;

            motherBoard.TestMotherboard();
        }
    }
}
