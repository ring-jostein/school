using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace O3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnavslutt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnregn_Click(object sender, EventArgs e)
        {
            //Deklarasjoner
            double x = 0;
            double x1 = 0;
            double x2 = 0;
            double a = 0;
            double b = 0;
            double c = 0;
            double rot = 0;
            double imagi = 0;

            //Innlesning
            if (!double.TryParse(tba.Text,out a))
            {
                MessageBox.Show("Ugyldig verdi for a. Skriv inn et desimaltall.", "Ugyldig verdi for a");
            }
            if (!double.TryParse(tbb.Text, out b))
            {
                MessageBox.Show("Ugyldig verdi for b. Skriv inn et desimaltall.", "Ugyldig verdi for b");
            }
            if (!double.TryParse(tbc.Text, out c))
            {
                MessageBox.Show("Ugyldig verdi for c. Skriv inn et desimaltall.", "Ugyldig verdi for c");
            }
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        tbsvar.Text = "Likningen har uendelig mange løsninger.";
                    }
                    else
                    {
                        tbsvar.Text = "Likningen har ingen løsninger.";
                    }
                }
                else //Likningen er en førstegradslikning
                {
                    x = -c / b;
                    tbsvar.Text = "En løsning: x = " + x.ToString("F3");
                }

            }
            //Likningen er en annengradslikning
            else
            {
                rot = (Math.Pow(b, 2) - 4 * a * c);

                if (rot == 0) //Likningen gir en dobbeltbrøk
                {
                    x = -b / 2 * a;
                    tbsvar.Text = "En løsning: x = " + x.ToString("F3");
                }
                else if (rot < 0) //Likningen gir to løsninger med komplekse tall
                {
                    rot = rot * -1;
                    imagi = (Math.Sqrt(rot)) / 2 * a;
                    x = -b / 2 * a;
                    //Console.WriteLine("x1 = {0:F3} + {1:F3}i og x2 = {0:F3} - {1:F3}i", x, imagi);
                    tbsvar.Text = "To løsninger: x1 = " + x.ToString("F3") + " + " + imagi.ToString("F3") + "i og x2 = " + x.ToString("F3") + " - " + imagi.ToString("F3") + "i";
                }
                else //Likningen gir to løsninger
                {
                    x1 = (-b - Math.Sqrt(rot)) / 2 * a;
                    x2 = (-b + Math.Sqrt(rot)) / 2 * a;
                    //Console.WriteLine("x1 = {0:F3} og x2 = {1:F3}", x1, x2);
                    tbsvar.Text = "To løsninger: x1 = " + x1.ToString("F3") + " og x2 = " + x2.ToString("F3");
                }
            }
        }
    }
}
