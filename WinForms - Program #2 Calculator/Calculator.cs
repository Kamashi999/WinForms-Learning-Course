using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms___Program__2_Calculator
{
    public partial class Calculator: Form
    {
        
        public Calculator()
        {
            InitializeComponent();
        }

        private void numeric1_Click(object sender, EventArgs e)
        {
            string numeric = "1";
            label1.Text = numeric;
            int a = 1;
        }

    }
}
