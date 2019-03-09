using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O2
{
    class O2
    {
        static void Main(string[] args)
        {
            double R1 = 1;
            double Rnode = 0;
            double Rtot = 0;

            Console.WriteLine("Dette programmet beregner totalmotstanden av en seriekopling av parallell-koplinger.");
            Console.WriteLine("Innlesning av parallell-motstander avsluttes med R = 0.");
            Console.WriteLine("Programmet avsluttes ved å taste inn en negativ motstandsverdi");
            Console.WriteLine("");

            while (R1 > 0)
            {
                Console.Write("Skriv inn neste motstandsverdi R: ");
                try
                {
                    R1 = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception unntak)
                {
                    Console.WriteLine("Feil: " + unntak.Message);
                    R1 = -1;
                }
                if (R1 == 0)
                {
                    if (Rnode == 0)
                    {
                        Console.WriteLine("Siste node sin motstand = {0:F3} ohm", Rnode);
                        Console.WriteLine("Samlet motstand hittil = {0:F3} ohm", Rtot);
                        Console.WriteLine("");
                        R1 = 1;
                    }
                    else
                    {
                        Rnode = 1 / Rnode;
                        Rtot = Rtot + Rnode;
                        Console.WriteLine("Siste node sin motstand = {0:F3} ohm", Rnode);
                        Console.WriteLine("Samlet motstand hittil = {0:F3} ohm", Rtot);
                        Console.WriteLine("");
                        R1 = 1;
                        Rnode = 0;
                    }
                }
                else
                {
                    Rnode = Rnode + 1 / R1;
                }
            }
            Console.WriteLine("Trykk en tast for å avslutte...");
            Console.ReadKey(true);
        }
    }
}
