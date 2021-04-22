using System;

namespace Ziekenhuis
{
    class Program
    {
        static void Main(string[] args)
        {
            InsuredPatient iPatient = new InsuredPatient("Insured Patient 1", 12);
            Patient patient = new Patient("Patient 2", 12);

            iPatient.ShowInfo();
            patient.ShowInfo();
        }
    }
}
