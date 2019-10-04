using System;
using System.Collections.Generic;

namespace O1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] itab = new int[10];
            int sum = 0;
            Random r = new Random();

            Console.Write("Summen av tallene ");
            for (int i = 0; i < itab.Length; i++)
            {
                itab[i] = r.Next(0, 100);
                sum = sum + itab[i];
                Console.Write(itab[i].ToString() + " ");
            }
            Console.WriteLine("er lik {0}.", sum);

            /* Tabell av rektangeler */
            Rektangel[] rtab = new Rektangel[10];
            double arealsum = 0;

            Console.Write("Summen av arealene ");
            for (int i = 0; i < rtab.Length; i++)
            {
                rtab[i] = new Rektangel(r.NextDouble()*10, r.NextDouble()*10);
                arealsum += rtab[i].Areal();
                Console.Write(rtab[i].Areal().ToString("f3") + " ");
            }
            Console.WriteLine("er lik {0:f3}.", arealsum);

            /* Liste av rektangeler */
            List <Rektangel> rList = new List <Rektangel> (10);

            for (int i = 0; i < 10; i++)
            {
                rList.Add()
            }


            Console.ReadKey(true);
        }
    }
}
