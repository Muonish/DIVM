using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Integr_Diff
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            textBoxA1.Text = textBoxA2.Text = "1";
            textBoxB1.Text = textBoxB2.Text = "4";
            textBoxX.Text = "2,5";
            textBoxE.Text = "0,00001";
        }

        private void buttonSplines_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";
            if (textBoxX.Text == "" || textBoxA1.Text == "" || textBoxB1.Text == "")
                MessageBox.Show("Fill all the fields!");
            else
            {
                if (textBoxX.Text == "0")
                    MessageBox.Show("Impossible to calculate! Dividing by zero!");
                else
                {
                    if (Convert.ToDouble(textBoxX.Text) > Convert.ToDouble(textBoxB1.Text) || Convert.ToDouble(textBoxX.Text) < Convert.ToDouble(textBoxA1.Text))
                        MessageBox.Show("Invalid value of x!");
                    else
                    {
                        if (Convert.ToDouble(textBoxX.Text) < 0)
                            MessageBox.Show("Impossible to calculate! Negative value of the logarithm!");
                        else
                        {
                            DiffSplines Splines = new DiffSplines();
                            Splines.Spline(Convert.ToDouble(textBoxA1.Text),
                                           Convert.ToDouble(textBoxB1.Text) + 0.001,
                                           Convert.ToDouble(textBoxX.Text));
                            labelResult.Text = "f '(x) = " + Convert.ToString(Math.Round(Splines.firstDifferential, 4)) + "\n" +
                                               "f \"(x) = " + Convert.ToString(Math.Round(Splines.secondDifferential, 4));
                        }
                    }
                }
            }
        }

        private void textBoxA1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                if (e.KeyChar != 8)
                    if (e.KeyChar != ',')
                        if (e.KeyChar != '-')
                            e.KeyChar = '\0';
        }

        private void buttonSimpson_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";
            if (textBoxE.Text == "" || textBoxA2.Text == "" || textBoxB2.Text == "")
                MessageBox.Show("Fill all the fields!");
            else
            {
                Integration Integral = new Integration();
                double result = Integral.Simpson(Convert.ToDouble(textBoxA2.Text),
                                                    Convert.ToDouble(textBoxB2.Text),
                                                    Convert.ToDouble(textBoxE.Text));
                if (result == 0) 
                    labelResult.Text = "Try to change the interval\nof integration." ;
                else
                    labelResult.Text = "F(b) - F(a) = " + Convert.ToString(Math.Round(result, 4));      
            }
        }

        private void buttonGauss_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";
            if (textBoxE.Text == "" || textBoxA2.Text == "" || textBoxB2.Text == "")
                MessageBox.Show("Fill all the fields!");
            else
            {   
                Integration Integral = new Integration();
                double result = Integral.Gauss(Convert.ToDouble(textBoxA2.Text),
                                               Convert.ToDouble(textBoxB2.Text),
                                               Convert.ToDouble(textBoxE.Text));
                if (result == 0)
                    labelResult.Text = "Try to change the interval\nof integration.";
                else
                    labelResult.Text = "F(b) - F(a) = " + Convert.ToString(Math.Round(result, 4));
            }
        }
    }
}
