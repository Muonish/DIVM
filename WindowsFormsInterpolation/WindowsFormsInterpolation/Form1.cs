using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace WindowsFormsInterpolation
{
    public partial class FormMain : Form
    {
        public static GraphPane pane;
        public const int N = 20;
        public double step = 0.1;
        public double[] xValues = new double[N]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 
                                                11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
     
        public double[] yValues = new double[N]{2.02, 1.98, 1.67, 1.65, 1.57, 1.42, 1.37, 1.07, 0.85, 0.48,          //var3
                                                0.35, -0.30, -0.61, -1.20, -1.39, -1.76, -2.28, -2.81, -3.57, -4.06};
       
        public FormMain()
        {
            InitializeComponent();
            pane = zedGraphControl.GraphPane; 
            pane.Title.Text = "";
            pane.XAxis.Title.Text = "X Axis";
            pane.YAxis.Title.Text = "Y Axis";
            dataGridView1.RowCount = N;
            for (int i = 0; i < N; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = Convert.ToString(xValues[i]);
                dataGridView1.Rows[i].Cells[1].Value = Convert.ToString(yValues[i]);
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pane.CurveList.Clear();
            PointPairList list = new PointPairList();

            double xmin = 1;
            double xmax = N;

            if (comboBox1.Text == "")
            { }
            else
                step = Convert.ToDouble(comboBox1.Text);

            for (int i = 0; i < N; i++)
            {
                xValues[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                yValues[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
            }
            if (radioButton1.Checked)
            {
                for (double x = xmin; x <= xmax; x += step)
                {
                    list.Add(x, Lagrange.InterpolateLagrangePolynomial(x, xValues, yValues, N));
                }
                LineItem myCurve = pane.AddCurve("Lagrange", list, Color.Blue, SymbolType.None);
            }
            if (radioButton2.Checked)
            {
                for (double x = xmin; x <= xmax; x += step)
                {
                    list.Add(x, Newton.InterpolateNewton(x, xValues, yValues, N));
                }
                LineItem myCurve = pane.AddCurve("Newton", list, Color.Red, SymbolType.None);
            }
            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (textBox1.Text == "")
            { }
            else
            {
                double x = Convert.ToDouble(textBox1.Text);

                if (radioButton1.Checked)
                {
                    textBox2.Text = Convert.ToString(Math.Round(Lagrange.InterpolateLagrangePolynomial(x, xValues, yValues, N), 2));
                }
                if (radioButton2.Checked)
                {
                    textBox2.Text = Convert.ToString(Math.Round(Newton.InterpolateNewton(x, xValues, yValues, N), 2));
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                if (e.KeyChar != 8)
                    if (e.KeyChar != ',')
                        e.KeyChar = '\0';
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                if (e.KeyChar != 8)
                    if (e.KeyChar != ',')
                        e.KeyChar = '\0';
        }

    }
}
