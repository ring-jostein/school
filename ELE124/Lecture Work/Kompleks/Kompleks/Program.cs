using System;

namespace O6
{
    class Program
    {
        static void Main(string[] args)
        {
            Kompleks k1 = new Kompleks();

            Kompleks k2 = new Kompleks(4, 3);

            Kompleks k3 = new Kompleks(2, 1);

            Console.WriteLine("Abs av k2 er {0}.", k2.Abs());

            Kompleks k4 = k2.LeggTil(k3);

            Kompleks k5 = k2.MultipliserMed(k3);

            Kompleks k6 = new Kompleks(-3, -5);

            Console.WriteLine(k1.UtskriftKartesisk());
            Console.WriteLine(k2.UtskriftKartesisk());
            Console.WriteLine(k3.UtskriftKartesisk());
            Console.WriteLine(k4.UtskriftKartesisk());
            Console.WriteLine(k5.UtskriftKartesisk());
            Console.WriteLine(k6.UtskriftKartesisk());
            Console.WriteLine(k5.KompleksKonjugert().UtskriftKartesisk());

            Console.WriteLine(k1.UtskriftPolar());
            Console.WriteLine(k2.UtskriftPolar());
            Console.WriteLine(k3.UtskriftPolar());
            Console.WriteLine(k4.UtskriftPolar());
            Console.WriteLine(k5.UtskriftPolar());
            Console.WriteLine(k6.UtskriftPolar());
            Console.WriteLine(k5.KompleksKonjugert().UtskriftPolar());

            Console.WriteLine(new Kompleks(1, 0).UtskriftPolar()); // denne bør gi r = 1, theta = 0
            Console.WriteLine(new Kompleks(0, 1).UtskriftPolar()); // denne bør gi r = 1, theta = PI/2

            Console.ReadKey();
        }
    }
}
