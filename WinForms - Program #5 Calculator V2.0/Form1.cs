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
        bool selectingNumber;
        void ToggleToAnotherNumber()
        {
            selectingNumber = !selectingNumber;

            if (selectingNumber == true)
            {
                SelectNumberA();
            } else
            {
                SelectNumberB();
            }
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
            label2.Text += btnNumberText;
        }
        void SelectNumberA()
        {

            label1.Text += "numA";

        }
        void SelectNumberB()
        {
            label1.Text = "numB";
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
            SelectNumberA();

        }

        private void TogglingNumber(object sender, EventArgs e)
        {
            ToggleToAnotherNumber();

        }

    }
}
