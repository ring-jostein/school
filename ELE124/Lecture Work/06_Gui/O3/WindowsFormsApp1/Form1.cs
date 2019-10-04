using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace O3
{
    public partial class Form1 : Form
    {
        Color tbColor;
        Color tbWrongColor;

        public Form1()
        {
            InitializeComponent();

            tbColor = tbarg1re.BackColor;
            tbWrongColor = Color.Red;
        }

        private void BtnPluss_Click(object sender, EventArgs e)
        {
            Kompleks arg1 = LesArgument1();
            Kompleks arg2 = LesArgument2();
            Kompleks res = arg1 + arg2;

            tbresre.Text = res.Re.ToString();
            tbresim.Text = res.Im.ToString();

            string loggdata = string.Format("{0} + {1} = {2}", 
                arg1.SkrivSomKartesisk(), arg2.SkrivSomKartesisk(), res.SkrivSomKartesisk());

            lbLogg.Items.Add(loggdata);
        }

        private Kompleks LesArgument1()
        {
            Kompleks svar = null;

            double re = 0;

            try
            {
                re = Convert.ToDouble(tbarg1re.Text);
            }
            catch (Exception unntak)
            {

                MessageBox.Show("Feil " + unntak.Message);
                tbarg1re.BackColor = tbWrongColor;
            }

            double im = 0;

            try
            {
                im = Convert.ToDouble(tbarg1im.Text);
            }
            catch (Exception unntak)
            {

                MessageBox.Show("Feil " + unntak.Message);
                tbarg1im.BackColor = tbWrongColor;
            }

            svar = new Kompleks(re, im);

            return svar;
        }
        private Kompleks LesArgument2()
        {
            Kompleks svar = null;

            double re = 0;

            try
            {
                re = Convert.ToDouble(tbarg2re.Text);
            }
            catch (Exception unntak)
            {

                MessageBox.Show("Feil " + unntak.Message);
                tbarg2re.BackColor = tbWrongColor;
            }

            double im = 0;

            try
            {
                im = Convert.ToDouble(tbarg2im.Text);
            }
            catch (Exception unntak)
            {

                MessageBox.Show("Feil " + unntak.Message);
                tbarg2im.BackColor = tbWrongColor;
            }

            svar = new Kompleks(re, im);

            return svar;
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            Kompleks arg1 = LesArgument1();
            Kompleks arg2 = LesArgument2();
            Kompleks res = arg1 - arg2;

            tbresre.Text = res.Re.ToString();
            tbresim.Text = res.Im.ToString();

            string loggdata = string.Format("{0} - {1} = {2}",
                arg1.SkrivSomKartesisk(), arg2.SkrivSomKartesisk(), res.SkrivSomKartesisk());

            lbLogg.Items.Add(loggdata);
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            Kompleks arg1 = LesArgument1();
            Kompleks arg2 = LesArgument2();
            Kompleks res = arg1 * arg2;

            tbresre.Text = res.Re.ToString();
            tbresim.Text = res.Im.ToString();

            string loggdata = string.Format("{0} * {1} = {2}",
                arg1.SkrivSomKartesisk(), arg2.SkrivSomKartesisk(), res.SkrivSomKartesisk());

            lbLogg.Items.Add(loggdata);
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            Kompleks arg1 = LesArgument1();
            Kompleks arg2 = LesArgument2();
            Kompleks res = arg1 / arg2;

            tbresre.Text = res.Re.ToString();
            tbresim.Text = res.Im.ToString();

            string loggdata = string.Format("{0} / {1} = {2}",
                arg1.SkrivSomKartesisk(), arg2.SkrivSomKartesisk(), res.SkrivSomKartesisk());

            lbLogg.Items.Add(loggdata);
        }

        private void BtnInv_Click(object sender, EventArgs e)
        {
            Kompleks arg1 = LesArgument1();
            Kompleks res = arg1.Invers();

            tbresre.Text = res.Re.ToString();
            tbresim.Text = res.Im.ToString();

            string loggdata = string.Format("Inv{0} = {1}",
                arg1.SkrivSomKartesisk(), res.SkrivSomKartesisk());

            lbLogg.Items.Add(loggdata);
        }

        private void BtnAbs_Click(object sender, EventArgs e)
        {
            Kompleks arg1 = LesArgument1();
            double res = arg1.abs();

            tbresre.Text = res.ToString();
            tbresim.Text = "0";

            string loggdata = string.Format("Abs{0} = {1}",
                arg1.SkrivSomKartesisk(), res.ToString());

            lbLogg.Items.Add(loggdata);
        }

        private void Tbarg1re_TextChanged(object sender, EventArgs e)
        {
            tbarg1re.BackColor = tbColor;
        }

        private void Tbarg1im_TextChanged(object sender, EventArgs e)
        {
            tbarg1im.BackColor = tbColor;
        }

        private void Tbarg2re_TextChanged(object sender, EventArgs e)
        {
            tbarg2re.BackColor = tbColor;
        }

        private void Tbarg2im_TextChanged(object sender, EventArgs e)
        {
            tbarg2im.BackColor = tbColor;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = File.CreateText("logg.txt");

            for (int i = 0; i < lbLogg.Items.Count; i++)
            {
                sw.WriteLine(lbLogg.Items[i].ToString());
            }
            sw.Close();
        }
    }
}
