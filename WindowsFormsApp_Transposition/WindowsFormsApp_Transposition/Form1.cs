using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Transposition
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            labelN.BackColor = Color.Transparent;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int n = 0;

            textBoxOutput.Text = String.Empty;

            if (comboBoxN.Text != String.Empty)
                n = Int32.Parse(comboBoxN.Text);
            var revlex = new RevLex(n, this);
        }

        private void comboBoxN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                if (e.KeyChar != 8)
                    e.KeyChar = '\0';
        }
    }
}
