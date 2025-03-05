using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms___Program__7_Random_Math_Task
{
    public partial class Form1: Form
    {
        Random rand = new Random();
        int a;
        int b;
        int randTask;
        int result;
        int answer;
        string calculation;
        public Form1()
        {
            InitializeComponent();
            CreateCalculation();
            DisplayCalculation();
        }

        void CreateCalculation()
        {
            a = rand.Next(0, 10);
            b = rand.Next(0, 10);
            randTask = rand.Next(1, 3);
            switch (randTask)
            {
                case 1:
                    calculation = a.ToString() + "+" + b.ToString();
                    answer = a + b;
                    break;
                case 2:
                    calculation = a.ToString() + "-" + b.ToString();
                    answer = a - b;
                    break;
            }
        }

        void DisplayCalculation()
        {
            label1.Text = calculation;
        }

        void CheckResults()
        {
            if (textBox1.Text == answer.ToString())
            {
                CreateCalculation();
                DisplayCalculation();
                textBox1.Text = "";
                button1.ForeColor = default;
            } else
            {
                button1.ForeColor = Color.Red;
                textBox1.Text = "";
            }
            button2.Visible = true;
        }

        void CheckAnswer()
        {
            label2.Text = answer.ToString();
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckResults();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }
    }
}
