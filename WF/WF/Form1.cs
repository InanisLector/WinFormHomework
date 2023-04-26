using System;
using System.Windows.Forms;

namespace WF
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void addition_Click(object sender, EventArgs e)
        {
            string output = "Wrong input";

            if (float.TryParse(inputX.Text, out float x) && float.TryParse(inputY.Text, out float y))
            {
                output = $"{x + y}";
            }

            var answer = new popout(output);
            answer.Show(this);
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            string output = "Wrong input";

            if (float.TryParse(inputX.Text, out float x) && float.TryParse(inputY.Text, out float y))
            {
                output = $"{x - y}";
            }

            var answer = new popout(output);
            answer.Show(this);
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            string output = "Wrong input";

            if (float.TryParse(inputX.Text, out float x) && float.TryParse(inputY.Text, out float y))
            {
                output = $"{x * y}";
            }

            var answer = new popout(output);
            answer.Show(this);
        }

        private void divide_Click(object sender, EventArgs e)
        {
            string output = "Wrong input";

            if (float.TryParse(inputX.Text, out float x) && float.TryParse(inputY.Text, out float y))
            {
                output = $"{x / y}";
            }

            var answer = new popout(output);
            answer.Show(this);
        }
    }
}
