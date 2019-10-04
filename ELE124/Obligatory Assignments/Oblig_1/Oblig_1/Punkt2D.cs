using System;
using System.Collections.Generic;
using System.Text;

namespace Oblig_1
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
                if (value > 0) x = value;
                else x = 0;
            }
        }

        private double y;
        public double Y
        {
            get { return y; }
            set
            {
                if (value > 0) y = value;
                else y = 0;
            }
        }
        public double BeregnAvstandTil(Punkt2D denAndre)
        {
            double svar = 0;
            svar = Math.Sqrt(Math.Pow((denAndre.x),2)+Math.Pow((denAndre.y),2));
            return svar;
        }

        public string DataSomStreng()
        {
            string svar = "";
            svar = "(" + x + ", " + y + ")";
            return svar;
        }

        public bool ErISammePosisjonSom(Punkt2D denAndre)
        {
            bool svar = false;
            if ((x == denAndre.x) && (y == denAndre.y)) svar = true;
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
    }
}
