using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O6
{
    class Kompleks
    {
        private double re;
        private double im;
        public double Re
        {
            get { return re; }
            private set { re = value; }
        }
        public double Im
        {
            get { return im; }
            private set { im = value; }
        }
        public Kompleks()
        {
            Re = 0;
            Im = 0;
        }
        public Kompleks(double initRe, double initIm)
        {
            Re = initRe;
            Im = initIm;
        }

        public double Abs()
        {
            double svar = Re * Re + Im * Im;
            svar = Math.Sqrt(svar);
            return svar;
        }

        public Kompleks LeggTil(Kompleks denAndre)
        {
            Kompleks svar = new Kompleks();
            svar.Re = Re + denAndre.Re;
            svar.Im = Im + denAndre.Im;
            return svar;
        }

        public Kompleks MultipliserMed(Kompleks denAndre)
        {
            Kompleks svar = new Kompleks();
            svar.Re = (Re * denAndre.Re) - (Im * denAndre.Im);
            svar.Im = (Re * denAndre.Im) + (denAndre.Re * Im);
            return svar;
        }

        public string UtskriftKartesisk()
        {
            string svar = Re.ToString();

            svar = svar + " ";
            if (Im > 0) svar = svar + "+ ";
            else if (Im < 0) svar = svar + "- ";

            if (Im != 0)
            {
                svar = svar + Math.Abs(Im).ToString();
                svar = svar + "i";
            }

            return svar;
        }

        public Kompleks KompleksKonjugert()
        {
            Kompleks svar = new Kompleks(Re, -Im);
            return svar;
        }

        public string UtskriftPolar()
        {
            string svar = "(";
            double r = Abs(); // sqrt(Re*Re + Im*Im)
            double t = Math.Atan2(Im, Re);
            svar = svar + r.ToString() + "," + t.ToString() + ")";
            return svar;
        }
    } // av class Kompleks
}
