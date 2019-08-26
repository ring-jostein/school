using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O3
{
    class O3
    {
        static void Main(string[] args)
        {
            double x1 = 0;
            double x2 = 0;
            double y1 = 0;
            double y2 = 0;
            double s = 0;

            Console.Write("Tast inn verdi for x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Tast inn verdi for y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Tast inn verdi for x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Tast inn verdi for y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            s = Math.Sqrt((Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)));

            Console.Write("Avstand mellom punktene er: {0:f2}",s);

            Console.ReadKey(true);
            
        }
    }
}
