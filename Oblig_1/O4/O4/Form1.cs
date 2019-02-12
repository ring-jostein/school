using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace O4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double dec16 = Convert.ToDouble(cb16.Checked);
            double dec8 = Convert.ToDouble(cb8.Checked);
            double dec4 = Convert.ToDouble(cb4.Checked);
            double dec2 = Convert.ToDouble(cb2.Checked);
            double dec1 = Convert.ToDouble(cb1.Checked);

            sum = (dec16 * Math.Pow(2, 4))+(dec8 * Math.Pow(2, 3))+(dec4 * Math.Pow(2, 2))+(dec2 * Math.Pow(2, 1))+(dec1 * Math.Pow(2, 0));

            tbresult.Text = dec16.ToString()+dec8.ToString()+dec4.ToString()+dec2.ToString()+dec1.ToString()+"b = "+sum.ToString();
        }
    }
}
