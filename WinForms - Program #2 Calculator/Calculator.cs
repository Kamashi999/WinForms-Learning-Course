using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms___Program__2_Calculator
{
    public partial class Calculator: Form
    {
        void Reset()
        {
            string a = "0";
            string b = "0";
        }

        bool reset = false;

        string numEqual;
        string a, b;
        bool nextNumber = true;
        bool add = false;
        bool minus = false;
        public Calculator()
        {
            InitializeComponent();
            label3.Text = a;
            label4.Text = b;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            nextNumber = false;
            minus = true;
        }

        private void addition_Click(object sender, EventArgs e)
        {
            nextNumber = false;
            add = true;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            while (add)
            {
                int numA = int.Parse(a);
                int numB = int.Parse(b);
                int result = numA + numB;
                label1.Text = result.ToString();
                add = false;
                label3.Text = "0";
                label4.Text = "0";
                nextNumber = true;
                
            }
            while (minus)
            {
                int numA = int.Parse(a);
                int numB = int.Parse(b);
                int result = numA - numB;
                label1.Text = result.ToString();
                minus = false;
                label3.Text = "0";
                label4.Text = "0";
                nextNumber = true;
                
            }

        }

        private void numeric1_Click(object sender, EventArgs e)
        {
            if (nextNumber == true)
            {
                a += "1";
                label3.Text = a;
            }
            else
            {
                b += "1";
                label4.Text = b;
            }
        }

        private void numeric2_Click(object sender, EventArgs e)
        {
            if (nextNumber == true)
            {
                a += "2";
                label3.Text = a;
            } else
            {
                b += "2";
                label4.Text = b;
            }
        }

        private void numeric3_Click(object sender, EventArgs e)
        {
            if (nextNumber == true)
            {
                a += "3";
                label3.Text = a;
            }
            else
            {
                b += "3";
                label4.Text = b;
            }
        }

        private void numeric4_Click(object sender, EventArgs e)
        {
            if (nextNumber == true)
            {
                a += "4";
                label3.Text = a;
            }
            else
            {
                b += "4";
                label4.Text = b;
            }
        }

        private void numeric5_Click(object sender, EventArgs e)
        {
            if (nextNumber == true)
            {
                a += "5";
                label3.Text = a;
            }
            else
            {
                b += "5";
                label4.Text = b;
            }
        }

        private void numeric6_Click(object sender, EventArgs e)
        {
            if (nextNumber == true)
            {
                a += "6";
                label3.Text = a;
            }
            else
            {
                b += "6";
                label4.Text = b;
            }
        }

        private void numeric7_Click(object sender, EventArgs e)
        {
            if (nextNumber == true)
            {
                a += "7";
                label3.Text = a;
            }
            else
            {
                b += "7";
                label4.Text = b;
            }
        }

        private void numeric8_Click(object sender, EventArgs e)
        {
            if (nextNumber == true)
            {
                a += "8";
                label3.Text = a;
            }
            else
            {
                b += "8";
                label4.Text = b;
            }
        }

        private void numeric9_Click(object sender, EventArgs e)
        {
            if (nextNumber == true)
            {
                a += "9";
                label3.Text = a;
            }
            else
            {
                b += "9";
                label4.Text = b;
            }
        }


        private void numeric0_Click(object sender, EventArgs e)
        {
            if (nextNumber == true)
            {
                a += "0";
                label3.Text = a;
            }
            else
            {
                b += "0";
                label4.Text = b;
            }
        }

    }
}
