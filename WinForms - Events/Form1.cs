using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms___Events
{
    public partial class Form1: Form
    {
        private int num = 0;
        int paintCounter = 0;
        public Form1()
        {
            InitializeComponent();
            
            foreach (Button btn in groupBox1.Controls.OfType<Button>())
            {
                // .Click to event a to po += to event handler
                btn.Click += btnGroup_Click;
            }
        }

        // wewnątrz zmiennej sender, będziemy dostawać różne info na temat obiektu którego tyczył sie event
        // np mamy button1_Click, to w sender będzie info na temat tego przycisku, w zmiennej e, znajdziemy 
        // w jaki sposób ten event został wywołany.
        private void button1_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            

            
            if (e.Button == MouseButtons.Left)
            {
                
                label1.Text = "You clicked LMB";
                label3.Text = num.ToString();
                num++;
            }
            else if (e.Button == MouseButtons.Right)
            {
                
                label1.Text = "You clicked RMB";
                label3.Text = num.ToString();
                num++;
            }
            else return;
            
        }

        //Aby automatycznie stworzyć skrypt do jednego przycisku, ale aby zmieniał, np 1 parametr w zależności
        // od klikniętego buttona. Wystarczy użyć zmiennej sender, która ma zapisane info na temat przycisku.
        private void btnGroup_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            label2.Text = btn.Name;
            label2.BackColor = btn.BackColor;
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            paintCounter++;
            label4.Text = paintCounter.ToString();
        }
    }
}
