using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O1
{
    class Rektangel
    {
        public Rektangel()
        {
            Bredde = 0;
            Lengde = 0;
        }

        public Rektangel(double initBredde, double initLengde)
        {
            Bredde = initBredde;
            Lengde = initLengde;
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

        public double Areal()
        {
            return Bredde * Lengde;
        }

        public void Tegn(char fyll)
        {
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
