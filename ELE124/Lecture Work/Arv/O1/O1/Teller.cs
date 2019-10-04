using System;
using System.Collections.Generic;
using System.Text;

namespace O1
{
    class Teller : Maaler
    {
        int antall;

        public Teller(int sID, double pX, double pY) : base(sID, pX, pY)
        {
            antall = 0;
        }

        public double Antall
        {
            get { return antall; }
        }

        public void Reset()
        {
            antall = 0;
        }

        public int Passering()
        {
            antall++;
            return antall;
        }
    }
}
