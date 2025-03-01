using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms___Program__5_Calculator_V2._0
{
    public partial class Form1: Form
    {
        string numA;
        string numB;
        string tempResult;
        bool selectingNumber = true;
        bool addition = false;
        bool subtraction = false;
        bool division = false;
        bool multiplication = false;
        
        void Reset()
        {
            numA = "";
            numB = "";
            ClearAllLabels();
            selectingNumber = true;
            label4.Text = "Number A";
            label5.Text = "Number B";
        }

        void ToggleToAnotherNumber()
        {
            selectingNumber = !selectingNumber;
        }

        void Addition()
        {
            int numericA = int.Parse(numA);
            int numericB = int.Parse(numB);
            int result = numericA + numericB;
            label1.Text = result.ToString();
        }

        void Subtraction()
        {
            int numericA = int.Parse(numA);
            int numericB = int.Parse(numB);
            int result = numericA - numericB;
            label1.Text = result.ToString();
        }
        void Division()
        {
            int numericA = int.Parse(numA);
            int numericB = int.Parse(numB);
            if (numericA == 0 || numericB == 0)
            {
                label1.Text = "You can't devide by 0!";
            }
            else
            {
                int result = numericA / numericB;
                label1.Text = result.ToString();
            }
        }
        void Multiplication()
        {
            int numericA = int.Parse(numA);
            int numericB = int.Parse(numB);
            int result = numericA * numericB;
            label1.Text = result.ToString();
        }

        void ClearAllLabels()
        {
            foreach (Control L in Controls)
            {
                if (L is Label)
                {
                    L.Text = "";
                }
            }
        }
        void ButtonNumber(object sender)
        {
            Button btn = sender as Button;
            string btnNumberText = btn.Name.Substring(btn.Name.Length - 1);
            int btnNumber = int.Parse(btnNumberText);

            if (selectingNumber)
            {
                numA += btnNumberText;
                label2.Text = numA;
            }
            else
            {
                numB += btnNumberText;
                label3.Text = numB;
            }
        }

        public Form1()
        {
            InitializeComponent();
            ClearAllLabels();
            label4.Text = "Number A";
            label5.Text = "Number B";
        }
        private void ButtonNumber(object sender, EventArgs e)
        {
            ButtonNumber(sender);
        }

        private void TogglingNumber(object sender, EventArgs e)
        {
            ToggleToAnotherNumber();
            addition = true;
        }

        private void Subtraction(object sender, EventArgs e)
        {
            ToggleToAnotherNumber();
            subtraction = true;
        }

        private void Division(object sender, EventArgs e)
        {
            ToggleToAnotherNumber();
            division = true;
        }
        private void Multiplication(object sender, EventArgs e)
        {
            ToggleToAnotherNumber();
            multiplication = true;
        }

        private void EqualsBtn(object sender, EventArgs e)
        {
            if (addition == true)
            {
                Addition();
                addition = false;
            }
            else if (subtraction == true)
            {
                Subtraction();
                subtraction = false;
            } else if (division == true)
            {
                Division();
                division = false;
            } else if (multiplication == true)
            {
                Multiplication();
                multiplication = false;
            }
            tempResult = label1.Text;
            Reset();
            label1.Text = tempResult;
        }

        private void Restart(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
