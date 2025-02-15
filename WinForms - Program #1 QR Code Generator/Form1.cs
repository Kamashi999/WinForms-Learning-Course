using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronBarCode;

namespace WinForms___Program__1_QR_Code_Generator
{
    public partial class Form1: Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        int num = 0;
        void Generate()
        {
            string text = textBox1.Text;
            if (text.Length == 0) return;
            string path = "MyQR" + num + ".png";
            QRCodeWriter.CreateQrCode($"{text}", 250, QRCodeWriter.QrErrorCorrectionLevel.Medium).SaveAsPng(path);
            pictureBox1.Image = Image.FromFile(path);
            num++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Generate();
        }
    }
}
