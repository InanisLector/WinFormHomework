using System;
using System.Windows.Forms;

namespace WF
{
    public partial class popout : Form
    {
        public popout(string output)
        {
            InitializeComponent();
            label1.Text = output;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
