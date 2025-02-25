using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms___Program__4_ToDoList
{

    public partial class Form1: Form
    {
        private bool isDarkTheme = false;
        void ToggleTheme()
        {
            if (isDarkTheme)
            {
                // Jasny motyw
                this.BackColor = Color.White;
                button1.BackColor = Color.LightGray;
                button2.BackColor = Color.LightGray;
                button3.BackColor = Color.LightGray;
                button4.BackColor = Color.LightGray;
                richTextBox1.BackColor = Color.White;
                checkedListBox1.BackColor = Color.White;
                textBox1.BackColor = Color.White;

                // Ciemny tekst dla lepszej widoczności
                button1.ForeColor = Color.Black;
                button2.ForeColor = Color.Black;
                button3.ForeColor = Color.Black;
                button4.ForeColor = Color.Black;
                richTextBox1.ForeColor = Color.Black;
                checkedListBox1.ForeColor = Color.Black;
                textBox1.ForeColor = Color.Black;
            }
            else
            {
                // Ciemny motyw
                this.BackColor = Color.FromArgb(50, 50, 60);
                button1.BackColor = Color.FromArgb(89, 95, 110);
                button2.BackColor = Color.FromArgb(89, 95, 110);
                button3.BackColor = Color.FromArgb(89, 95, 110);
                button4.BackColor = Color.FromArgb(89, 95, 110);
                richTextBox1.BackColor = Color.FromArgb(117, 121, 133);
                checkedListBox1.BackColor = Color.FromArgb(117, 121, 133);
                textBox1.BackColor = Color.FromArgb(117, 121, 133);

                // Jasny tekst dla lepszej widoczności
                button1.ForeColor = Color.White;
                button2.ForeColor = Color.White;
                button3.ForeColor = Color.White;
                button4.ForeColor = Color.White;
                richTextBox1.ForeColor = Color.White;
                checkedListBox1.ForeColor = Color.White;
                textBox1.ForeColor = Color.White;
            }

            isDarkTheme = !isDarkTheme;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                checkedListBox1.Items.Add(richTextBox1.Text);
                richTextBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)

        {
            bool IsValidIndex(int indexBool)
            {
                return indexBool >= 0 && indexBool < checkedListBox1.Items.Count;
            }

            if (int.TryParse(textBox1.Text, out int index) && IsValidIndex(index - 1))
            {
                
                checkedListBox1.Items.RemoveAt(index - 1);
                textBox1.Clear();
            } else
            {
                MessageBox.Show("Niepoprawny indeks!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToggleTheme();
        }


    }
}

