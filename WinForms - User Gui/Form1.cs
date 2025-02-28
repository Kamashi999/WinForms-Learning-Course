using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms___User_Gui
{
    
    public partial class Form1: Form
    {
        UserControl[] userControls;
        public Form1()
        {
            InitializeComponent();

            userControls = new UserControl[]
            {
                home1, services1, contact1
            };
            ShowContent(0);
        }

        void ShowContent (int c)
        {
            for (int i = 0; i < userControls.Length; i++)
            {
                userControls[i].Hide();
            }
            userControls[c].Show();
        }

        void menuBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string num = btn.Name.Substring(btn.Name.Length - 1);
            if(Int32.TryParse(num, out int c))
            {
                ShowContent(c - 1);
            }
        }
    }
}
