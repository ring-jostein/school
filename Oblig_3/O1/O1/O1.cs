using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O1
{
    class O1
    {
        static void Main(string[] args)
        {
            //Deklarasjon
            string mangeord = "eple appelsin drue yoghurt kiwi";
            int index = 0;
            string etord = "";

            //Beregning
            while (index > -1)
            {
                index = mangeord.IndexOf(" ");
                if (index > -1)
                {
                    etord = etord + mangeord.Substring(0, index) + ", ";
                    mangeord = mangeord.Remove(0, index + 1);
                }
                else
                {
                    etord = etord + mangeord;
                }
            }
            Console.WriteLine(etord);
            Console.ReadKey(true);
        }
    }
}
