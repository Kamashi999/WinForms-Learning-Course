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
        public Form1()
        {
            InitializeComponent();
            a = rand.Next(0,10);
            b = rand.Next(0,10);
            randTask = rand.Next(1, 3);
            switch (randTask)
            {
                case 1:
                    label1.Text = a.ToString() + "+" + b.ToString();
                    answer = a + b;
                    break;
                case 2:
                    label1.Text = a.ToString() + "-" + b.ToString();
                    answer = a - b;
                    break;
            }
            label2.Text = answer.ToString();
        }
    }
}
