using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDIVM
{
    public partial class FormMatrix : Form
    {
        public FormMatrix()
        {
            InitializeComponent();
        }

        int N = 0;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                if (e.KeyChar != 8)
                    e.KeyChar = '\0';
        }

        private void FormMatrix_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            dataGridView.Visible = false;
            labelMessage.Text = "Enter the number of equation:";
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {

            if ((N == 0) && (!textBox1.Text.Equals("")))
            {
                N = Convert.ToInt32(textBox1.Text);

                labelMessage.Text = "Enter the number of equation:";
                dataGridView.Visible = true;
                for (int i = 1; i <= N; i++)
                {
                    dataGridView.Columns.Add("", "Coeff" + i.ToString());
                    dataGridView.Rows.Add();
                }
                dataGridView.Columns.Add("", "CoeffFree");
                textBox1.Text = "";
            }
            else if (N != 0)
            {
                textBox1.Text = "";
                labelMessage.Text = "Solution:";
                double[,] matrix = new double[N, N];
                double[] vector = new double[N];

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        matrix[i, j] = Convert.ToDouble(dataGridView.Rows[i].Cells[j].Value);
                    }
                    vector[i] = Convert.ToDouble(dataGridView.Rows[i].Cells[N].Value);
                }

                if (radioButton1.Checked)
                {
                    Gauss gauss = new Gauss(matrix, vector);
                    switch (gauss.Solvematrix())
                    {
                        case 1:
                            textBox1.Text = "Matrix has no solution.";
                            break;
                        case 2:
                            textBox1.Text = "Matrix has infinitely many solutions.";
                            break;
                        default:
                            for (int i = 0; i < N; i++)
                                textBox1.Text += "x[" + Convert.ToString(i) + "] = " + Convert.ToString(gauss.answer[i]) + Environment.NewLine;
                            break;
                    }
                }
                if (radioButton2.Checked)
                {
                    if (Holetski.IsSymmetric(matrix, N))
                    {
                        double[] answer = new double[N];
                        answer = Holetski.TestSolve(matrix, vector);

                        for (int i = 0; i < N; i++)
                            textBox1.Text += "x[" + Convert.ToString(i) + "] = " + Convert.ToString(answer[i]) + Environment.NewLine;

                    }
                    else
                        textBox1.Text += "Impossible to solve by this method.";
                }
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
        }

        private void dataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                if (e.KeyChar != 8)
                    if (e.KeyChar != '.')
                        e.KeyChar = '\0';
        }
    }
}
