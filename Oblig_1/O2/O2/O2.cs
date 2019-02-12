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
            double farenheit = 0;

            while (true)
            {
                Console.Write("Oppgi en temperatur i Farenheit: ");

                if (!double.TryParse(Console.ReadLine(), out farenheit))
                {
                    Console.WriteLine();
                    Console.WriteLine("Ugyldig verdi.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    double celcius = ((farenheit - 32) * 5 / 9);

                    Console.WriteLine("Farenheit\tCelcius");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine((farenheit - 2) + "\t\t" + (Math.Round(celcius - 2, 2)));
                    Console.WriteLine((farenheit - 1) + "\t\t" + (Math.Round(celcius - 1, 2)));
                    Console.WriteLine(farenheit + "\t\t" + (Math.Round(celcius, 2)));
                    Console.WriteLine((farenheit + 1) + "\t\t" + (Math.Round(celcius + 1, 2)));
                    Console.WriteLine((farenheit + 2) + "\t\t" + (Math.Round(celcius + 2, 2)));
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Trykk en tast for å avslutte");
            Console.ReadKey(true);
        }
    }
}
