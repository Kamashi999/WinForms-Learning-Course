using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinForms___Toolbox
{
    public partial class Form1: Form
    {
        List<Control> ctList = new List<Control>();

        public Form1()
        {
            InitializeComponent();
            button1.Text = "bnt1";
            label1.BackColor = Color.Red;

            AddToList(ctList);
            ChangeMyControls();
            label1.Text = DisplayListNames(ctList);
        }

        void AddToList(List<Control> myList)
        {
            foreach (Control c in groupBox1.Controls)
            {
                myList.Add(c);
            }
        }

        string DisplayListNames(List<Control> myList)
        {
            string listNames = "";
            foreach (Control c in myList)
            {
                listNames += c.Name + " ";
            }
            return listNames;
        }

        void ChangeMyControls()
        {
            foreach(Control c in groupBox1.Controls)
            {
                c.BackColor = Color.Green;
            }
        }
    }
}
