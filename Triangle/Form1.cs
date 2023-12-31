﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRez_Click(object sender, EventArgs e)
        {
            labelRez.Text = string.Empty;
            bool flagA = double.TryParse(textBoxA.Text, out double a);
            if (!flagA)
            {
                MessageBox.Show("Вы не ввели значение стороны A");
                textBoxA.Text = string.Empty;
                textBoxB.Text = string.Empty;
                textBoxC.Text = string.Empty;
                return;

            }
            bool flagB = double.TryParse(textBoxB.Text, out double b);
            if (!flagB)
            {
                MessageBox.Show("Вы не ввели значение стороны B");
                textBoxA.Text = string.Empty;
                textBoxB.Text = string.Empty;
                textBoxC.Text = string.Empty;
                return;

            }
            bool flagC = double.TryParse(textBoxC.Text, out double c);
            if (!flagC)
            {
                MessageBox.Show("Вы не ввели значение стороны C");
                textBoxA.Text = string.Empty;
                textBoxB.Text = string.Empty;
                textBoxC.Text = string.Empty;
                return;

            }
            if (a <= 0 || c <= 0 || b <= 0)
            {
                MessageBox.Show("Вы указали сторону, которая меньше либо равна 0!");
                textBoxA.Text = string.Empty;
                textBoxB.Text = string.Empty;
                textBoxC.Text = string.Empty;
                return;
            }


            if (a + b <= c || a + c <= b || b + c <= a)
            {
                MessageBox.Show("Одна сторона больше суммы двух других или равна ей!");
                textBoxA.Text = string.Empty;
                textBoxB.Text = string.Empty;
                textBoxC.Text = string.Empty;
                return;
            }
            if (a > 1000000 || b > 1000000 || c > 1000000)
            {
                MessageBox.Show("Вы ввели слишком большое число!");
                textBoxA.Text = string.Empty;
                textBoxB.Text = string.Empty;
                textBoxC.Text = string.Empty;
                return;
            }


            if (a == b & b == c)
            {
                labelRez.Text = "Это равносторонний треугольник";
                return;

            }
            if (a == b || b == c || a == c)
            {
                labelRez.Text = "Это равнобедренный треугольник";
                return;

            }
            if (a != b & b != c)
            {
                labelRez.Text = "Это разносторонний треугольник";
                return;
            }
        }
    }
}
