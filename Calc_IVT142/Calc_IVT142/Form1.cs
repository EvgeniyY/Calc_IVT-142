using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_IVT142
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstArg=Convert.ToDouble(Input1.Text);
            double secondArg = Convert.ToDouble(Input2.Text);
            double result = firstArg + secondArg;
            
            Output.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double firstArg = Convert.ToDouble(Input1.Text);
            double secondArg = Convert.ToDouble(Input2.Text);
            double result = firstArg - secondArg;

            Output.Text = result.ToString();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            double firstArg = Convert.ToDouble(Input1.Text);
            double secondArg = Convert.ToDouble(Input2.Text);
            double result = firstArg * secondArg;

            Output.Text = result.ToString();
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            double firstArg = Convert.ToDouble(Input1.Text);
            double secondArg = Convert.ToDouble(Input2.Text);
            double result = firstArg / secondArg;

            Output.Text = result.ToString();
        }
    }
}
