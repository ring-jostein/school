using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O3
{
    class Kompleks
    {
        private double re;
        public double Re
        {
            get
            {
                return re;
            }
            set
            {
                re = value;
            }
        }
        private double im;

        public double Im
        {
            get
            {
                return im;
            }
            set
            {
                im = value;
            }
        }
        public Kompleks() : this(0, 0) //setter Re og Im til null
        {
        }
        public Kompleks(double initRe, double initIm)
        {
            Re = initRe;
            Im = initIm;
        }

        public double abs()
        {
            double svar = this.Re * this.Re + this.Im * this.Im;
            svar = Math.Sqrt(svar);
            return svar;
        }


        //OPERATORER
        public static Kompleks operator +(Kompleks a, Kompleks b)
        {
            Kompleks c = new Kompleks();
            c.Re = a.Re + b.Re;
            c.Im = a.Im + b.Im;
            return c;
        }
        public static Kompleks operator *(Kompleks a, Kompleks b)
        {
            Kompleks c = new Kompleks();
            c.Re = a.Re * b.Re - a.Im * b.Im;
            c.Im = a.Re * b.Im + b.Re * a.Im;
            return c;
        }

        public static Kompleks operator -(Kompleks a, Kompleks b)
        {
            Kompleks c = new Kompleks();
            c.Re = a.Re - b.Re;
            c.Im = a.Im - b.Im;
            return c;
        }

        public static bool operator ==(Kompleks a, Kompleks b)
        {
            bool svar = false;
            if ((a.Re == b.Re) && (a.Im == b.Im))
            {
                svar = true;
            }
            return svar;
        }

        public static bool operator !=(Kompleks a, Kompleks b)
        {
            bool svar = false;
            if ((a.Re != b.Re) || (a.Im != b.Im))
            {
                svar = true;
            }
            return svar;
        }

        public static Kompleks operator /(Kompleks a, Kompleks b)
        {
            Kompleks c = new Kompleks();
            c = a * b.Invers();
            return c;
        }

        public Kompleks Invers()
        {
            Kompleks svar = new Kompleks();
            svar.Re = Re / ((Re * Re) + (Im * Im));
            svar.Im = -Im / ((Re * Re) + (Im * Im));
            return svar;
        }

        public string SkrivSomKartesisk()
        {
            string svar = "(";
            if (Re != 0)
                svar = svar + Re.ToString() + " ";
            if (Im >= 0 && Re != 0)
                svar = svar + "+ ";
            else if (Im < 0 && Re != 0)
                svar = svar + "- ";

            svar = svar + Math.Abs(Im).ToString() + "i";

            if (Re == 0 && Im == 0)
            {
                svar = svar + "0";
            }
            svar = svar + ")";
            return svar;
        }

        public string SkrivSomPolar()
        {


            string svar = "(";
            // grader (char): '\x00B0' 
            svar = svar + (Math.Sqrt(Re * Re + Im * Im)) + ", " + Math.Atan2(Im, Re).ToString();
            svar = svar + ")";
            return svar;
        }

        public Kompleks KompleksKonjugert()
        {
            Kompleks Konjugert = new Kompleks(Re, -Im);
            return Konjugert;
        }
    }
}
