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
            //Deklarasjoner
            double x = 0;
            double x1 = 0;
            double x2 = 0;
            double a = 0;
            double b = 0;
            double c = 0;
            double rot = 0;
            double imagi = 0;

            Console.WriteLine("Programmet bruker abc-formelen for å løse en andregradslikning.");

            //Innlesning
            try
            {
                Console.Write("Tast inn verdi for a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Tast inn verdi for b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Tast inn verdi for c: ");
                c = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception unntak)
            {
                Console.WriteLine("Feil: " + unntak.Message);
                a = 0;
                b = 0;
                c = 0;
            }
            //Utregning

            //Sjekk for om likningen har uendelig/ingen løsning og om den er en annengradslikning
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Likningen har uendelig mange løsninger.");
                    }
                    else
                    {
                        Console.WriteLine("Likningen har ingen løsninger.");
                    }
                }
                else //Likningen er en førstegradslikning
                {
                    x = -c / b;
                    Console.WriteLine("x = {0:F3}", x);
                }
            }
            //Likningen er en annengradslikning
            else
            {
                rot = (Math.Pow(b, 2) - 4 * a * c);

                if (rot == 0) //Likningen gir en dobbeltbrøk
                {
                    x = -b / 2 * a;
                    Console.WriteLine("x = {0:F3}", x);
                }
                else if (rot < 0) //Likningen gir to løsninger med komplekse tall
                {
                    rot = rot * -1;
                    imagi = (Math.Sqrt(rot)) / 2 * a;
                    x = -b / 2 * a;
                    Console.WriteLine("x1 = {0:F3} + {1:F3}i og x2 = {0:F3} - {1:F3}i", x, imagi);
                }
                else //Likningen gir to løsninger
                {
                    x1 = (-b - Math.Sqrt(rot)) / 2 * a;
                    x2 = (-b + Math.Sqrt(rot)) / 2 * a;
                    Console.WriteLine("x1 = {0:F3} og x2 = {1:F3}", x1, x2);
                }
            }
            //Avslutt
            Console.WriteLine(" ");
            Console.WriteLine("Trykk inn en tast for å avslutte...");
            Console.ReadKey(true);
        }
    }
}
