using System;
using System.Collections.Generic;
using System.Text;

namespace O1
{
    class Punkt2D
    {
        public Punkt2D() {}

        public Punkt2D(double initX, double initY)
        {
           x = initX;
           y = initY;
        }

        private double x;
        public double X
        {
            get { return x; }
            set
            {
                if (value < 0) x = 0;
                else if (value > maksX) x = maksX;
                else x = value;
            }
        }

        private double y;
        public double Y
        {
            get { return y; }
            set
            {
                if (value < 0) y = 0;
                else if (value > maksY) y = maksY;
                else y = value;
            }
        }

        private static double maksX = 10;
        public static double MaksX
        {
            get { return maksX; }
            set
            {
                if (value < 1) maksX = 1;
                else maksX = value;
            }
        }

        private static double maksY = 10;
        public static double MaksY
        {
            get { return maksY; }
            set
            {
                if (value < 1) maksY = 1;
                else maksY = value;
            }
        }

        public double BeregnAvstandTil(Punkt2D denAndre)
        {
            double svar = 0;
            svar = Math.Sqrt((Math.Pow(Math.Abs(denAndre.x-this.x),2))+(Math.Pow(Math.Abs(denAndre.y-this.y),2)));
            return svar;
        }

        public string DataSomStreng()
        {
            string svar = "";
            svar = "(" + x + ", " + y + ")";
            return svar;
        } 
        
        public Punkt2D FinnMellompunkt(Punkt2D denAndre)
        {
            Punkt2D svar = new Punkt2D();

            svar.x = (denAndre.x + x) / 2;
            svar.y = (denAndre.y + y) / 2;

            return svar;
        }

        public bool LiggerPaaSammeLinjeSom(Punkt2D denAndre, Punkt2D denTredje)
        {
            bool svar = false;
            if (((y - denAndre.y) * (x - denTredje.x)) == ((y - denTredje.y) * (x - denAndre.x))) svar = true;
            return svar;
        }

        public static bool operator == (Punkt2D a, Punkt2D b)
        {
            bool svar = false;
            if ((a.x == b.x) && (a.y == b.y)) svar = true;
            return svar;

        }

        public static bool operator != (Punkt2D a, Punkt2D b)
        {
            bool svar = false;
            if ((a.x != b.x) || (a.y != b.y)) svar = true;
            return svar;
        }

        public double AvstandFraOrigo()
        {
            double svar = 0;
            svar = Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
            return svar;
        }
    }
}
