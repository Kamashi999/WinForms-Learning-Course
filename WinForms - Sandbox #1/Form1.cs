using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms___Sandbox__1
{
    public partial class Form1: Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        void TransferMessage()
        {
            label1.Text = textBox1.Text;
        }

        void LabelNotNull()
        {
            if (label1.Text.Length == 0) {
                label1.Text = "Write something!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            TransferMessage();
            Button btn = sender as Button;
            if (checkBox1.Checked == true)
            {
                label1.BackColor = btn.BackColor;
            } else
            {
                label1.BackColor = default;
            }
            LabelNotNull();
        }
    }
}
