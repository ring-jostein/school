using System;
using System.Collections.Generic;

namespace O1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Maaler> mList = new List<Maaler>();

            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                if (r.Next(0,2) == 0)
                {
                    Temperaturmaaler t = new Temperaturmaaler(i, i, i);
                    mList.Add(t);
                }
                else
                {
                    Teller c = new Teller(i, i, i);
                    mList.Add(c);
                }
            }

            foreach (Maaler m in mList)
            {
                int antall = r.Next(0, 5);
                if (m is Temperaturmaaler)
                {
                    Temperaturmaaler t = m as Temperaturmaaler;
                    for (int i = 0; i < antall; i++) { t.Maal(); }
                }
                else if (m is Teller)
                {
                    Teller c = m as Teller;
                    for (int i = 0; i < antall; i++) { c.Passering(); }
                }
            }

            Console.WriteLine("Sensorer: ");
            foreach (Maaler m in mList)
            {
                Console.Write(m.GetType().Name + " ");
                Console.WriteLine(m.ToString());

                if (m is Temperaturmaaler)
                {
                    Temperaturmaaler t = m as Temperaturmaaler;
                    Console.WriteLine("Nåværende verdi: " + t.Temperatur);
                }
                else if (m is Teller)
                {
                    Teller c = m as Teller;
                    Console.WriteLine("Nåværende verdi: " + c.Antall);
                }
            }

            Console.ReadKey(true);
        }
    }
}
