using System;
using System.Collections.Generic;
using System.Text;

namespace O1
{
    class Maaler
    {
        protected int sensorID;
        protected double posX;
        protected double posY;

        public Maaler(int sID, double pX, double pY)
        {
            sensorID = sID;
            PosX = pX;
            PosY = pY;
        }

        public int SensorID
        {
            get { return sensorID; }
        }

        public double PosX
        {
            get { return posX; }
            set { posX = value; }
        }

        public double PosY
        {
            get { return posY; }
            set { posY = value; }
        }

        public override string ToString()
        {
            string svar = string.Format("{0} - {1},{2}", SensorID, PosX, PosY);
            return svar;
        }
    }
}