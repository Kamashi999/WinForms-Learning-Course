namespace WinForms___Program__2_Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numeric7 = new System.Windows.Forms.Button();
            this.numeric8 = new System.Windows.Forms.Button();
            this.numeric9 = new System.Windows.Forms.Button();
            this.numeric6 = new System.Windows.Forms.Button();
            this.numeric5 = new System.Windows.Forms.Button();
            this.numeric4 = new System.Windows.Forms.Button();
            this.numeric3 = new System.Windows.Forms.Button();
            this.numeric2 = new System.Windows.Forms.Button();
            this.numeric1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numeric7
            // 
            this.numeric7.Location = new System.Drawing.Point(292, 128);
            this.numeric7.Name = "numeric7";
            this.numeric7.Size = new System.Drawing.Size(50, 50);
            this.numeric7.TabIndex = 0;
            this.numeric7.Text = "7";
            this.numeric7.UseVisualStyleBackColor = true;
            // 
            // numeric8
            // 
            this.numeric8.Location = new System.Drawing.Point(348, 128);
            this.numeric8.Name = "numeric8";
            this.numeric8.Size = new System.Drawing.Size(50, 50);
            this.numeric8.TabIndex = 1;
            this.numeric8.Text = "8";
            this.numeric8.UseVisualStyleBackColor = true;
            // 
            // numeric9
            // 
            this.numeric9.Location = new System.Drawing.Point(404, 128);
            this.numeric9.Name = "numeric9";
            this.numeric9.Size = new System.Drawing.Size(50, 50);
            this.numeric9.TabIndex = 2;
            this.numeric9.Text = "9";
            this.numeric9.UseVisualStyleBackColor = true;
            // 
            // numeric6
            // 
            this.numeric6.Location = new System.Drawing.Point(404, 184);
            this.numeric6.Name = "numeric6";
            this.numeric6.Size = new System.Drawing.Size(50, 50);
            this.numeric6.TabIndex = 5;
            this.numeric6.Text = "6";
            this.numeric6.UseVisualStyleBackColor = true;
            // 
            // numeric5
            // 
            this.numeric5.Location = new System.Drawing.Point(348, 184);
            this.numeric5.Name = "numeric5";
            this.numeric5.Size = new System.Drawing.Size(50, 50);
            this.numeric5.TabIndex = 4;
            this.numeric5.Text = "5";
            this.numeric5.UseVisualStyleBackColor = true;
            // 
            // numeric4
            // 
            this.numeric4.Location = new System.Drawing.Point(292, 184);
            this.numeric4.Name = "numeric4";
            this.numeric4.Size = new System.Drawing.Size(50, 50);
            this.numeric4.TabIndex = 3;
            this.numeric4.Text = "4";
            this.numeric4.UseVisualStyleBackColor = true;
            // 
            // numeric3
            // 
            this.numeric3.Location = new System.Drawing.Point(404, 240);
            this.numeric3.Name = "numeric3";
            this.numeric3.Size = new System.Drawing.Size(50, 50);
            this.numeric3.TabIndex = 8;
            this.numeric3.Text = "3";
            this.numeric3.UseVisualStyleBackColor = true;
            // 
            // numeric2
            // 
            this.numeric2.Location = new System.Drawing.Point(348, 240);
            this.numeric2.Name = "numeric2";
            this.numeric2.Size = new System.Drawing.Size(50, 50);
            this.numeric2.TabIndex = 7;
            this.numeric2.Text = "2";
            this.numeric2.UseVisualStyleBackColor = true;
            // 
            // numeric1
            // 
            this.numeric1.Location = new System.Drawing.Point(292, 240);
            this.numeric1.Name = "numeric1";
            this.numeric1.Size = new System.Drawing.Size(50, 50);
            this.numeric1.TabIndex = 6;
            this.numeric1.Text = "1";
            this.numeric1.UseVisualStyleBackColor = true;
            this.numeric1.Click += new System.EventHandler(this.numeric1_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(404, 296);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(50, 60);
            this.button10.TabIndex = 11;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(348, 296);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(50, 60);
            this.addition.TabIndex = 10;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(292, 296);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(50, 60);
            this.button12.TabIndex = 9;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.numeric3);
            this.Controls.Add(this.numeric2);
            this.Controls.Add(this.numeric1);
            this.Controls.Add(this.numeric6);
            this.Controls.Add(this.numeric5);
            this.Controls.Add(this.numeric4);
            this.Controls.Add(this.numeric9);
            this.Controls.Add(this.numeric8);
            this.Controls.Add(this.numeric7);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button numeric7;
        private System.Windows.Forms.Button numeric8;
        private System.Windows.Forms.Button numeric9;
        private System.Windows.Forms.Button numeric6;
        private System.Windows.Forms.Button numeric5;
        private System.Windows.Forms.Button numeric4;
        private System.Windows.Forms.Button numeric3;
        private System.Windows.Forms.Button numeric2;
        private System.Windows.Forms.Button numeric1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label1;
    }
}

