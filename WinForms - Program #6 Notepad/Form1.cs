using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms___Program__6_Notepad
{
    public partial class Form1: Form
    {
        string output;
        public Form1()
        {
            InitializeComponent();
            
        }

        void SaveFile()
        {
            string fileName = "myFile.txt";
            string path = @"files\" + fileName;
            output += richTextBox1.Text;

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(output);
                sw.Close();
            }
        }

        private void SaveFile(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void ExitProgram(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
