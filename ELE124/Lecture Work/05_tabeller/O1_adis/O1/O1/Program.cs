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
            Random r = new Random();

            /* Tabell av heltall */

            int[] itab = new int[10];
            int sum = 0;
            
            for (int i = 0; i < itab.Length; i++)
            {
                itab[i] = r.Next(0, 100);
            }

            for (int i = 0; i < itab.Length; i++)
            {
                sum = sum + itab[i];
            }

            Console.Write("Summen av heltall ");

            for (int i = 0; i < itab.Length; i++)
            {
                Console.Write(itab[i].ToString() + " ");
            }
            Console.WriteLine("er lik {0}.", sum);

            /* Tabell av rektangel */

            Rektangel[] rtab = new Rektangel[10];
            double sumArealer = 0;

            for (int i = 0; i < rtab.Length; i++)
            {
                /* Genererer et tilfeldig desimaltall på 
                 * to måter bare for å demonstrere begge muligehter */
                rtab[i] = new Rektangel(r.NextDouble() * 10, r.Next(0, 1000) / 100.0); ;
            }

            for (int i = 0; i < rtab.Length; i++)
            {
                sumArealer = sumArealer + rtab[i].Areal();
            }

            Console.Write("Summen av arealer ");

            for (int i = 0; i < rtab.Length; i++)
            {
                Console.Write(rtab[i].Areal().ToString("f3") + " ");
            }
            Console.WriteLine("er lik {0}.", sumArealer);

            /* List av rektangel */

            List<Rektangel> rList = new List<Rektangel>();
            double sumArealer2 = 0;

            for (int i = 0; i < 10; i++) // bruker 10 fordi listen er tom i starten
            {
                /* Genererer et tilfeldig desimaltall på 
                 * to måter bare for å demonstrere begge muligehter */
                rList.Add(new Rektangel(r.NextDouble() * 10, r.NextDouble()*10));

                //Rektangel enRektangel = new Rektangel(r.NextDouble() * 10, r.NextDouble() * 10);
                //rList.Add(enRektangel);
            }

            for (int i = 0; i < rList.Count; i++)
            {
                sumArealer2 = sumArealer2 + rList[i].Areal();
            }

            Console.Write("Summen av arealer i listen ");

            for (int i = 0; i < rList.Count; i++)
            {
                Console.Write(rList[i].Areal().ToString("f3") + " ");
            }
            Console.WriteLine("er lik {0}.", sumArealer2);



            Console.ReadKey(true);
        }
    }
}
