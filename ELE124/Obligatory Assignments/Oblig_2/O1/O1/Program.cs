using System;
using System.Collections.Generic;

namespace O1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Punkt2D.MaksX = 79;
            Punkt2D.MaksY = 15;
            int antallfem = 0;
            double sumnabopunkter = 0;
            int antalltrenabopunkter = 0;

            List<Punkt2D> pList = new List<Punkt2D>(1000);

            for (int i = 0; i < 1000; i++)
            {
                pList.Add(new Punkt2D(r.Next(Convert.ToInt32(Punkt2D.MaksX)), r.Next(Convert.ToInt32(Punkt2D.MaksY))));
            }

            Punkt2D X = new Punkt2D(5, 5);


            for (int i = 0; i < pList.Count; i++)
            {
                int a = Convert.ToInt32(pList[i].X);
                int b = Convert.ToInt32(pList[i].Y);
                Console.SetCursorPosition(a,b);
                Console.Write("X");

                if (pList[i] == X) antallfem++;

                if (i < pList.Count-1) sumnabopunkter += pList[i].BeregnAvstandTil(pList[i + 1]);

                if ((i > 1) && (i < pList.Count-2))
                {
                    if (pList[i].LiggerPaaSammeLinjeSom(pList[i - 1], pList[i + 1])) antalltrenabopunkter++;
                }
            }
            Console.SetCursorPosition(0, 15);
            Console.WriteLine("Antall forekomster av punkt (5,5) er: {0}", antallfem);
            Console.WriteLine("Summen av alle avstander mellom to nabopunkter er: {0:f2}", sumnabopunkter);
            Console.WriteLine("Antall forekomster av tre nabopunkter på linje er: {0}", antalltrenabopunkter);

            Console.ReadKey(true);
        }
    }
}
