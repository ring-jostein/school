using System;
using System.Collections.Generic;
using System.Text;

namespace Oblig_1
{
    struct Punkt2DS
    {

        public Punkt2DS(double initX, double initY)
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

        public double BeregnAvstandTil(Punkt2DS denAndre)
        {
            double svar = 0;
            svar = Math.Sqrt(Math.Pow((denAndre.x), 2) + Math.Pow((denAndre.y), 2));
            return svar;
        }

        public string DataSomStreng()
        {
            string svar = "";
            svar = "(" + x + ", " + y + ")";
            return svar;
        }

        public bool ErISammePosisjonSom(Punkt2DS denAndre)
        {
            bool svar = false;
            if ((x == denAndre.x) && (y == denAndre.y)) svar = true;
            return svar;
        }

        public Punkt2DS FinnMellompunkt(Punkt2DS denAndre)
        {
            Punkt2DS svar = new Punkt2DS();

            svar.x = (denAndre.x + x) / 2;
            svar.y = (denAndre.y + y) / 2;

            return svar;
        }

        public bool LiggerPaaSammeLinjeSom(Punkt2DS denAndre, Punkt2DS denTredje)
        {
            bool svar = false;
            if (((y - denAndre.y) * (x - denTredje.x)) == ((y - denTredje.y) * (x - denAndre.x))) svar = true;
            return svar;
        }
    }
}
