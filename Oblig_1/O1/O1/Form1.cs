using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace O1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAvslutt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegnom_Click(object sender, EventArgs e)
        {
            double farenheit = 0;

            if (!double.TryParse(tbFarenheit.Text,out farenheit))
            {
                MessageBox.Show("Ugyldig input. Skriv inn et desimaltall", "Ugyldig verdi");
            }
            else
            {
                double celcius = Math.Round((farenheit - 32) * 5 / 9, 2);
                tbCelcius.Text = celcius.ToString();
            }
        }

        private void buttonFjerndata_Click(object sender, EventArgs e)
        {
            tbFarenheit.Text = String.Empty;
            tbCelcius.Text = String.Empty;
        }
    }
}
