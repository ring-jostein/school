using System;
using System.Collections.Generic;
using System.Text;

namespace O1
{
    class Temperaturmaaler : Maaler
    {
        double temperatur;

        public Temperaturmaaler (int sID, double pX, double pY) : base(sID, pX, pY)
        {
            temperatur = 0;
        }

        public double Temperatur
        {
            get { return temperatur; }
        }

        public double Maal()
        {
            Random r = new Random();
            temperatur =+ (r.NextDouble() * 4) - 2;
            return temperatur;
        }
    }
}
