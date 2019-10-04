using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rektangel r1 = new Rektangel(3.1, 2.2);
            Rektangel r2 = new Rektangel(4, 5);
            Rektangel r3 = new Rektangel(1, 1);

            Rektangel.Farge = ConsoleColor.Red;

            r1.Tegn('#');
            Console.WriteLine();
            r2.Tegn('#');
            Console.WriteLine();
            r3.Tegn('#');
            Console.WriteLine();

            Rektangel.Farge = ConsoleColor.Blue;
            
            r1.Tegn('#');
            Console.WriteLine();
            r2.Tegn('#');
            Console.WriteLine();
            r3.Tegn('#');
            Console.WriteLine();

            Rektangel.ByttFarge(ConsoleColor.Green);

            r1.Tegn('#');
            Console.WriteLine();
            r2.Tegn('#');
            Console.WriteLine();
            r3.Tegn('#');
            Console.WriteLine();
            Console.WriteLine("Antall oprettede rekatngler: {0}", Rektangel.Antall);

            r1.Tegn('#', ConsoleColor.White);
            Console.WriteLine();
            r2.Tegn('#', ConsoleColor.White);
            Console.WriteLine();
            r3.Tegn();
            Console.WriteLine();

            Rektangel r4 = r1 + r2;

            r4.Tegn('+', ConsoleColor.Cyan);

            Rektangel r5 = r2 + r1;

            if (r4 == r5) Console.WriteLine("LIKE!");
            else Console.WriteLine("ULIKE");

            Console.ReadKey(true);
        }
    }
}
