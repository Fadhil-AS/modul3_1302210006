using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1302210006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbox.Text == "0") { 
                txtbox.Text = "0";
            } else
            {
                txtbox.Text += "0";
            }
        }

        private void btn1_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbox.Text == "0")
            {
                txtbox.Text = "1";
            }
            else
            {
                txtbox.Text += "1";
            }
        }

        private void btn2_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbox.Text == "0")
            {
                txtbox.Text = "2";
            }
            else
            {
                txtbox.Text += "2";
            }
        }

        private void btn3_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbox.Text == "0")
            {
                txtbox.Text = "3";
            }
            else
            {
                txtbox.Text += "3";
            }
        }

        private void btn4_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbox.Text == "0")
            {
                txtbox.Text = "4";
            }
            else
            {
                txtbox.Text += "4";
            }
        }

        private void btn5_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbox.Text == "0")
            {
                txtbox.Text = "5";
            }
            else
            {
                txtbox.Text += "5";
            }
        }

        private void btn6_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbox.Text == "0")
            {
                txtbox.Text = "6";
            }
            else
            {
                txtbox.Text += "6";
            }
        }

        private void btn7_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbox.Text == "0")
            {
                txtbox.Text = "7";
            }
            else
            {
                txtbox.Text += "7";
            }
        }

        private void btn8_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbox.Text == "0")
            {
                txtbox.Text = "8";
            }
            else
            {
                txtbox.Text += "8";
            }
        }

        private void btn9_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbox.Text == "0")
            {
                txtbox.Text = "9";
            }
            else
            {
                txtbox.Text += "9";
            }
        }

        private void btnPlus_MouseClick(object sender, MouseEventArgs e)
        {
            var arr = txtbox.Text.ToCharArray();
            if (arr[arr.Length - 1] != '+')
            {
                txtbox.Text += "+"; 
            }
            
        }

        private void btnRess_MouseClick(object sender, MouseEventArgs e)
        {
            var arrRess = txtbox.Text.ToCharArray();
            if (arrRess[arrRess.Length - 1] != '+')
            {
                var arr = txtbox.Text.Split('+');
                var x = 0;
                for (var i = 0; i < arr.Length; i++) {
                    x += Convert.ToInt32(arr[i]);
                }
                txtbox.Text = x.ToString();
            }
        }

        private void s(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            
        }

        private void txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }
    }
}
