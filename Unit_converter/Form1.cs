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
            listBox1.SelectedItem = "Meter";
            listBox2.SelectedItem = "Kilometer";
        }

        private void rtb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clength_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == listBox2.SelectedItem)
            {
                rtb2.Text = double.Parse(rtb1.Text).ToString();
            }
            if (listBox1.SelectedItem == "Meter" &&listBox2.SelectedItem =="Kilometer")
            {
                rtb2.Text = (double.Parse(rtb1.Text)*0.001).ToString();
            } if (listBox1.SelectedItem == "Meter" &&listBox2.SelectedItem =="Centimeter")
            {
                rtb2.Text = (double.Parse(rtb1.Text)*100).ToString();
            } if (listBox1.SelectedItem == "Kilometer" &&listBox2.SelectedItem =="Meter")
            {
                rtb2.Text = (double.Parse(rtb1.Text)*1000).ToString();
            }

           // double value2 = double.Parse(rtb1.Text);
           // rtb2.Text = (value2 * 100).ToString();
        }
    }
}
