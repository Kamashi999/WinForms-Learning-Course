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
        bool selectingNumber;
        bool addition = false;
        bool subtraction = false;

        void Reset()
        {
            numA = "";
            numB = "";
            ClearAllLabels();
            selectingNumber = false;
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

        void Substraction()
        {
            int numericA = int.Parse(numA);
            int numericB = int.Parse(numB);
            int result = numericA - numericB;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonNumber(sender);

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

        private void Substraction(object sender, EventArgs e)
        {
            ToggleToAnotherNumber();
            subtraction = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (addition == true)
            {
                Addition();
                addition = false;
            }
            else if (subtraction == true)
            {
                Substraction();
                subtraction = false;
            }
        }

        private void Restart(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
