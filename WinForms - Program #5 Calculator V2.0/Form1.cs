using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinForms___Program__5_Calculator_V2._0
{
    public partial class Form1: Form
    {
        List<string> numbersA; // label2
        List<string> numbersB; // label3
        string tempResult;
        bool selectingNumber = true;
        bool addition = false;
        bool subtraction = false;
        bool division = false;
        bool multiplication = false;

        public Form1()
        {
            InitializeComponent();
            ClearAllLabels();
            label4.Text = "Number A";
            label5.Text = "Number B";
            numbersA = new List<string>();
            numbersA.Add("0");
            label2.Text = numbersA[0];
            numbersB = new List<string>();
            numbersB.Add("0");
            label3.Text = numbersB[0];
        }

        void Reset()
        {
            numbersA.Clear();
            numbersA.Add("0");
            label2.Text = numbersA[0];
            numbersB.Clear();
            numbersB.Add("0");
            label3.Text = numbersB[0];
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
            int numericA = int.Parse(label2.Text);
            int numericB = int.Parse(label3.Text);
            int result = numericA + numericB;
            label1.Text = result.ToString();
        }

        void Subtraction()
        {
            int numericA = int.Parse(label2.Text);
            int numericB = int.Parse(label3.Text);
            int result = numericA - numericB;
            label1.Text = result.ToString();
        }
        void Division()
        {
            int numericA = int.Parse(label2.Text);
            int numericB = int.Parse(label3.Text);
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
            int numericA = int.Parse(label2.Text);
            int numericB = int.Parse(label3.Text);
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
                if (numbersA[0] == "0")
                {
                    numbersA.RemoveAt(0);
                }
                numbersA.Add(btnNumberText);
                label2.Text = string.Join("", numbersA);
            }
            else
            {
                if (numbersB[0] == "0")
                {
                    numbersB.RemoveAt(0);
                }
                numbersB.Add(btnNumberText);
                label3.Text = string.Join("", numbersB);
            }
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
