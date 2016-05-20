using System;
using System.Windows.Forms;
using Calc_IVT142.OneArg;
using Calc_IVT142.TwoArg;

namespace Calc_IVT142
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Action(object sender, EventArgs e)
        {
            try
            {
                double firstArg = Convert.ToDouble(Input1.Text);
                double secondArg = Convert.ToDouble(Input2.Text);
                double result;
                ICalculator calculator = TwoArgumentsCalculatorsFactory.CreateCalculator(((Button) sender).Name);
                result = calculator.Calculate(firstArg, secondArg);
                Output.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ActionOneArg(object sender, EventArgs e)
        {
            try
            {
                double firstArg = Convert.ToDouble(Input1.Text);
                double result;
                ICalculateFunc calculator = OneArgumentCalculatorsFactory.CreateCalculator(((Button) sender).Name);
                result = calculator.CalculateFunc(firstArg);
                Output.Text = result.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }

        }

        private void Output_Click(object sender, EventArgs e)
        {

        }
    }
}
