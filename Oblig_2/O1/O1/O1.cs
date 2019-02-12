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
            int a1, a2;
            char operasjon;                                                 
            int resultat;                                                   //Skrevet inn, se kommentar linje 32
            Console.WriteLine("Oppgi to heltall!");                         //Skrivefeil "writeLine"
            Console.Write("Tall 1: ");                                      //Skrivefeil "WriTe"
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tall 2: ");
            a2 = Convert.ToInt32(Console.ReadLine());                       //a2 er allerede definert som int, må bruke Convert.ToInt32, ikke ToDouble
            Console.WriteLine("Oppgi ønsket matematisk operasjon!");        //Skrivefeil Writeline
            Console.Write("Operasjon [+,*]:");
            operasjon = Convert.ToChar(Console.ReadLine());
            if (operasjon == '+')                                           //for å sammenlikne tegn må man skrive inn to likhetstegn
            {
                resultat = a1 + a2;
                Console.Write(a1.ToString() + " + " + a2.ToString());
                Console.WriteLine(" = " + resultat.ToString());
            }                                                  
            else if (operasjon == '*')                                      //erstattet " med ' for å definere * som et tegn
            {
                resultat = a1 * a2;                                         //resultat er ikke definert i koden, legger den til i linje 15. fjernet ' fra '*' for å definere det som operasjonen multiplikasjon
                Console.Write("{0} * {1}", a1, a2);
                Console.WriteLine(" = {0}", resultat);
            }
            else                                                            //else kan ikke være før else if, flyttet den til etter else if-blokken
            {
                Console.WriteLine("Ugyldig operasjon oppgitt!");
            }
            Console.WriteLine("Trykk en tast for å avslutte ...");
            Console.ReadKey(true);
        }
    }
}
