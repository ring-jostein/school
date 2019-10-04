using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O1
{
    class Rektangel
    {
        static ConsoleColor farge;
        public static int Antall;
      
        ~Rektangel()
        {
            Antall--;
        }


        public Rektangel()
        {
            Bredde = 0;
            Lengde = 0;
            Antall++;
        }

        public Rektangel(double initBredde, double initLengde)
        {
            Bredde = initBredde;
            Lengde = initLengde;
            Antall++;
        }


        private double bredde;
        public double Bredde
        {
            get { return bredde; }
            set
            {
                if (value < 0) bredde = 0;
                else bredde = value;
            }
        }

        private double lengde;
        public double Lengde
        {
            get { return lengde; }
            set
            {
                if (value < 0) lengde = 0;
                else lengde = value;
            }
        }

        public static ConsoleColor Farge
        {
            get { return farge; }
            set { farge = value; }
        }
        static Rektangel()
        {
            Farge = ConsoleColor.Yellow;
        }
        // Alternativ statisk metode
        public static void ByttFarge(ConsoleColor nyfarge)
        {
            Farge = nyfarge;
        }

        public double Areal()
        {
            return Bredde * Lengde;
        }

        public void Tegn(char fyll)
        {
            ConsoleColor opprinneligFarge = Console.ForegroundColor;
            Console.ForegroundColor = Farge;

            int rader = Convert.ToInt32(Math.Round(Lengde));
            int kolonner = Convert.ToInt32(Math.Round(Bredde));

            for (int i = 0; i < rader; i++)
            {
                for (int j = 0; j < kolonner; j++)
                {
                    Console.Write(fyll);
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = opprinneligFarge;
        }

        public void Tegn(char fyll, ConsoleColor bakgrunnsfarge)
        {
            ConsoleColor opprinneligFarge = Console.BackgroundColor;
            Console.BackgroundColor = bakgrunnsfarge;

            Tegn(fyll);

            Console.BackgroundColor = opprinneligFarge;
        }

        public void Tegn()
        {
            Tegn('*');
        }

        public static bool operator <(Rektangel a, Rektangel b)
        {
            bool svar = false;
            if (a.Areal() < b.Areal()) svar = true;
            return svar;
        }

        public static bool operator >(Rektangel a, Rektangel b)
        {
            bool svar = false;
            if (a.Areal() > b.Areal()) svar = true;
            return svar;
        }

        public static Rektangel operator +(Rektangel a, Rektangel b)
        {
            Rektangel svar = new Rektangel();
            svar.Lengde = a.Lengde + b.Lengde;
            svar.Bredde = a.Bredde + b.Bredde;
            return svar;
        }


        public static bool operator ==(Rektangel a, Rektangel b)
        {
            bool svar = false;
            if (a.Areal() == b.Areal()) svar = true;
            return svar;
        }

        public static bool operator !=(Rektangel a, Rektangel b)
        {
            bool svar = false;
            if (a.Areal() != b.Areal()) svar = true;
            return svar;
        }

        public void LesDimensjoner()
        {
            Console.Write("Oppgi bredde: ");
            Bredde = LesEtTall();
            Console.Write("Oppgi lengde: ");
            Lengde = LesEtTall();
        }
        private double LesEtTall()
        {
            double svar = 0;
            bool inputOK = false;
            while (inputOK == false) // while(!inputOK)
            {
                try
                {
                    svar = Convert.ToDouble(Console.ReadLine());
                    inputOK = true;
                }
                catch (Exception unntak)
                {
                    Console.WriteLine("Feil! " + unntak.Message);
                }
            }
            return svar;
        }

        public bool ErStorreEnn(Rektangel denAndre)
        {
            bool svar = false;
            if (Areal() > denAndre.Areal()) svar = true;
            return svar;
        }
    }
}
