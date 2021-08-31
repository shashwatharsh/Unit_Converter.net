using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rtb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clength_Click(object sender, EventArgs e)
        {
            double value2 = double.Parse(rtb1.Text);
            rtb2.Text = (value2 * 100).ToString();
        }
    }
}
