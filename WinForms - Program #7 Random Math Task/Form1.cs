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
        int a, b, randTask, answer, counter;
        string calculation;
        public Form1()
        {
            InitializeComponent();
            CreateCalculation();
            DisplayCalculation();
            DisplayCounter();
        }

        void CreateCalculation()
        {
            a = rand.Next(0, 10);
            b = rand.Next(0, 10);
            randTask = rand.Next(1, 4);
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
                case 3:
                    calculation = a.ToString() + "x" + b.ToString();
                    answer = a * b;
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
                AddCounter();
                DisplayCounter();
            } else
            {
                button1.ForeColor = Color.Red;
                textBox1.Text = "";
            }
            button2.Visible = true;
        }

        void CheckAnswer()
        {
            if(counter >= 2)
            {
                counter -= 2;
                label2.Text = answer.ToString();
                button2.Visible = false;
                DisplayCounter();
            }
            else
            {
                MessageBox.Show("You don't have enough points to show the answer!");
            }

        }

        void AddCounter()
        {
            counter++;
        }

        void DisplayCounter()
        {
            label3.Text = "Amount of Points: " + counter.ToString();
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
