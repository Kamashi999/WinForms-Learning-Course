﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronBarCode;

namespace WinForms___Introduction
{
    public partial class Form1: Form
    {
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
            QRCodeWriter.CreateQrCode("https://google.com/", 500, QRCodeWriter.QrErrorCorrectionLevel.Medium).SaveAsPng("MyQR.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
        }
    }
}
