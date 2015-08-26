using System;
using System.Text;
using System.Windows.Forms;

namespace SumOfTwo
{
    public partial class SumForm : Form
    {
        public SumForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string firstOperand = firstBox.Text;
            string secondOperand = secondBox.Text;
            if (Int32.Parse(firstOperand) >= Int32.Parse(secondOperand))
            {
                try
                {
                    var newSum = new SumAlgorithm();
                    newSum.calculateSum(Int32.Parse(firstOperand),
                        Int32.Parse(secondOperand));
                }
                catch
                {
                    MessageBox.Show("Invalid input.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input.");

            }

        }
        public void viewResult(int num1, int num2)
        {
            StringBuilder resultMessage = new StringBuilder();
            resultMessage.Append(num1.ToString());
            resultMessage.Append(num2.ToString());
            MessageBox.Show(resultMessage.ToString());

        }
    }
}