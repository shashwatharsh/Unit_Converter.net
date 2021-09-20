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
            lengthp.Visible = true;
            listBox1tmp.SelectedItem = "Celsius";
            listBox2tmp.SelectedItem = "Kelvin";

        }

      //  private void rtb1_TextChanged(object sender, EventArgs e)
        //{

//        }

        private void clength_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == listBox2.SelectedItem)
            {
                rtb2.Text = double.Parse(rtb1.Text).ToString();
            }
            if (listBox1.SelectedItem.ToString() == "Meter" &&listBox2.SelectedItem.ToString() == "Kilometer")
            {
                rtb2.Text = (double.Parse(rtb1.Text)*0.001).ToString();
            } if (listBox1.SelectedItem.ToString() == "Meter" &&listBox2.SelectedItem.ToString() == "Centimeter")
            {
                rtb2.Text = (double.Parse(rtb1.Text)*100).ToString();
            } if (listBox1.SelectedItem.ToString() == "Meter" &&listBox2.SelectedItem.ToString() == "Mile")
            {
                rtb2.Text = (double.Parse(rtb1.Text)/1609).ToString();
            }if (listBox1.SelectedItem.ToString() == "Meter" &&listBox2.SelectedItem.ToString() == "Yard")
            {
                rtb2.Text = (double.Parse(rtb1.Text)*1.094).ToString();
            }if (listBox1.SelectedItem.ToString() == "Meter" &&listBox2.SelectedItem.ToString() == "Inch")
            {
                rtb2.Text = (double.Parse(rtb1.Text)*39.37).ToString();
            }if (listBox1.SelectedItem.ToString() == "Meter" &&listBox2.SelectedItem.ToString() == "Foot")
            {
                rtb2.Text = (double.Parse(rtb1.Text)*3.281).ToString();
            } if (listBox1.SelectedItem.ToString() == "Kilometer" &&listBox2.SelectedItem.ToString() == "Meter")
            {
                rtb2.Text = (double.Parse(rtb1.Text)*1000).ToString();
            }
            if (listBox1.SelectedItem.ToString() == "Kilometer" && listBox2.SelectedItem.ToString() == "Centimeter")
            {
                rtb2.Text = (double.Parse(rtb1.Text) * 100000).ToString();
            }
            if (listBox1.SelectedItem.ToString() == "Kilometer" && listBox2.SelectedItem.ToString() == "Mile")
            {
                rtb2.Text = (double.Parse(rtb1.Text) / 1.609).ToString();
            }
            if (listBox1.SelectedItem.ToString() == "Kilometer" && listBox2.SelectedItem.ToString() == "Yard")
            {
                rtb2.Text = (double.Parse(rtb1.Text) * 1094 ).ToString();
            }
            if (listBox1.SelectedItem.ToString() == "Kilometer" && listBox2.SelectedItem.ToString() == "Inch")
            {
                rtb2.Text = (double.Parse(rtb1.Text) * 39370).ToString();
            }
            if (listBox1.SelectedItem.ToString() == "Kilometer" && listBox2.SelectedItem.ToString() == "Foot")
            {
                rtb2.Text = (double.Parse(rtb1.Text) * 3281).ToString();
            }
            if (listBox1.SelectedItem.ToString() == "Centimeter" && listBox2.SelectedItem.ToString() == "Meter")
            {
                rtb2.Text = (double.Parse(rtb1.Text) * 0.01).ToString();
            }
            if (listBox1.SelectedItem.ToString() == "Centimeter" && listBox2.SelectedItem.ToString() == "Kilometer")
            {
                rtb2.Text = (double.Parse(rtb1.Text) / 100000 ).ToString();
            } if (listBox1.SelectedItem.ToString() == "Centimeter" && listBox2.SelectedItem.ToString() == "Mile")
            {
                rtb2.Text = (double.Parse(rtb1.Text) / 160934).ToString();
            }
            if (listBox1.SelectedItem.ToString() == "Centimeter" && listBox2.SelectedItem.ToString() == "Yard")
            {
                rtb2.Text = (double.Parse(rtb1.Text) / 91.44 ).ToString();
            }if (listBox1.SelectedItem.ToString() == "Centimeter" && listBox2.SelectedItem.ToString() == "Foot")
            {
                rtb2.Text = (double.Parse(rtb1.Text) / 30.48  ).ToString();
            }if (listBox1.SelectedItem.ToString() == "Centimeter" && listBox2.SelectedItem.ToString() == "Inch")
            {
                rtb2.Text = (double.Parse(rtb1.Text) / 2.54).ToString();
            }if (listBox1.SelectedItem.ToString() == "Mile" && listBox2.SelectedItem.ToString() == "Meter")
            {
                rtb2.Text = (double.Parse(rtb1.Text) * 1609).ToString();
            }if (listBox1.SelectedItem.ToString() == "Mile" && listBox2.SelectedItem.ToString() == "Kilometer")
            {
                rtb2.Text = (double.Parse(rtb1.Text) * 1.609).ToString();
            }if (listBox1.SelectedItem.ToString() == "Mile" && listBox2.SelectedItem.ToString() == "Centimeter")
            {
                rtb2.Text = (double.Parse(rtb1.Text) * 160934).ToString();
            }if (listBox1.SelectedItem.ToString() == "Mile" && listBox2.SelectedItem.ToString() == "Inch")
            {
                rtb2.Text = (double.Parse(rtb1.Text) * 63360).ToString();
            }if (listBox1.SelectedItem.ToString() == "Mile" && listBox2.SelectedItem.ToString() == "Yard")
            {
                rtb2.Text = (double.Parse(rtb1.Text) * 1760).ToString();
            }if (listBox1.SelectedItem.ToString() == "Mile" && listBox2.SelectedItem.ToString() == "Feet")
            {
                rtb2.Text = (double.Parse(rtb1.Text) * 5280).ToString();
            }if (listBox1.SelectedItem.ToString() == "Yard" && listBox2.SelectedItem.ToString() == "Meter")
            {
                rtb2.Text = (double.Parse(rtb1.Text) / 1.094).ToString();
            }if (listBox1.SelectedItem.ToString() == "Yard" && listBox2.SelectedItem.ToString() == "Kilometer")
            {
                rtb2.Text = (double.Parse(rtb1.Text) / 1094).ToString();
            }if (listBox1.SelectedItem.ToString() == "Yard" && listBox2.SelectedItem.ToString() == "Centimeter")
            {
                rtb2.Text = (double.Parse(rtb1.Text) * 91.44).ToString();
            }if (listBox1.SelectedItem.ToString() == "Yard" && listBox2.SelectedItem.ToString() == "Mile")
            {
                rtb2.Text = (double.Parse(rtb1.Text) / 1760).ToString();
            }if (listBox1.SelectedItem.ToString() == "Yard" && listBox2.SelectedItem.ToString() == "Foot")
            {
                rtb2.Text = (double.Parse(rtb1.Text) * 3).ToString();
            }if (listBox1.SelectedItem.ToString() == "Yard" && listBox2.SelectedItem.ToString() == "Inch")
            {
                rtb2.Text = (double.Parse(rtb1.Text) * 36).ToString();
            }if (listBox1.SelectedItem.ToString() == "Foot" && listBox2.SelectedItem.ToString() == "Meter")
            {
                rtb2.Text = (double.Parse(rtb1.Text) / 3.281).ToString();
            }if (listBox1.SelectedItem.ToString() == "Foot" && listBox2.SelectedItem.ToString() == "Kilometer")
            {
                rtb2.Text = (double.Parse(rtb1.Text) / 3281).ToString();
            }if (listBox1.SelectedItem.ToString() == "Foot" && listBox2.SelectedItem.ToString() == "Centimeter")
            {
                rtb2.Text = (double.Parse(rtb1.Text) * 30.48).ToString();
            }
            // double value2 = double.Parse(rtb1.Text);
            // rtb2.Text = (value2 * 100).ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            m.Text = listBox1.SelectedItem.ToString();
            m.Text = listBox1.SelectedItem.ToString();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cm.Text = listBox2.SelectedItem.ToString();
        }

        private void lengthConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lengthp.Visible = true;
            tempraturet.Visible = false;
        }

       /* private void clength_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == listBox2.SelectedItem)
            {
                rtb2.Text = double.Parse(rtb1.Text).ToString();
            }
            if (listBox1.SelectedItem.ToString() == "Meter" && listBox2.SelectedItem.ToString() == "Kilometer")
            {
                rtb2.Text = (double.Parse(rtb1.Text) * 0.001).ToString();
            }
            if (listBox1.SelectedItem.ToString() == "Meter" && listBox2.SelectedItem.ToString() == "Centimeter")
            {
                rtb2.Text = (double.Parse(rtb1.Text) * 100).ToString();
            }
            if (listBox1.SelectedItem.ToString() == "Meter" && listBox2.SelectedItem.ToString() == "Mile")
            {
                rtb2.Text = (double.Parse(rtb1.Text) / 1609).ToString();
            }
            if (listBox1.SelectedItem.ToString() == "Meter" && listBox2.SelectedItem.ToString() == "Yard")
            {
                rtb2.Text = (double.Parse(rtb1.Text) * 1.094).ToString();
            }
            if (listBox1.SelectedItem.ToString() == "Meter" && listBox2.SelectedItem.ToString() == "Inch")
            {
                rtb2.Text = (double.Parse(rtb1.Text) * 39.37).ToString();
            }
        }*/
        
        private void tempratureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lengthp.Visible = false;
            tempraturet.Visible = true;
        }

        private void listBox1tmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            ftmp.Text = listBox1tmp.SelectedItem.ToString();
        }

        private void listBox2tmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            ctmp.Text = listBox2tmp.SelectedItem.ToString();
        }

        private void tmpmain_Click(object sender, EventArgs e)
        {
            if(listBox2tmp.SelectedItem == listBox1tmp.SelectedItem)
            {
                txttmp2.Text = txttmp1.Text;
            }
            if (listBox1tmp.SelectedItem.ToString() == "Celsius" && listBox2tmp.SelectedItem.ToString() == "Kelvin")
            {
                txttmp2.Text = (double.Parse(txttmp1.Text) + 273.15).ToString();

            } 
            if (listBox1tmp.SelectedItem.ToString() == "Celsius" && listBox2tmp.SelectedItem.ToString() == "Fahrenheit")
            {
                txttmp2.Text = ((double.Parse(txttmp1.Text) * (9.0/ 5.0)) + 32.0).ToString();
            }
            if (listBox1tmp.SelectedItem.ToString() == "Fahrenheit" && listBox2tmp.SelectedItem.ToString() == "Celsius")
            {
                txttmp2.Text = ((double.Parse(txttmp1.Text) -  32.0) * (9.0 / 5.0)).ToString();
            }if (listBox1tmp.SelectedItem.ToString() == "Fahrenheit" && listBox2tmp.SelectedItem.ToString() == "Kelvin")
            {
                txttmp2.Text = (((double.Parse(txttmp1.Text)-32.0) * (5.0/9.0)) + 273.15).ToString();
            }if (listBox1tmp.SelectedItem.ToString() == "Kelvin" && listBox2tmp.SelectedItem.ToString() == "Fahrenheit")
            {
                txttmp2.Text = ((double.Parse(txttmp1.Text) - 273.15) * (9.0 / 5.0) + 32.0).ToString();
            }if (listBox1tmp.SelectedItem.ToString() == "Kelvin" && listBox2tmp.SelectedItem.ToString() == "Celsius")
            {
                txttmp2.Text = ((double.Parse(txttmp1.Text)) -  273.15).ToString();
            }
        }
    }
}
