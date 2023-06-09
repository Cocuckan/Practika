﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practika
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Получение размера экрана
            Screen screen = Screen.PrimaryScreen;
            int screenWidth = screen.Bounds.Width;
            int screenHeight = screen.Bounds.Height;

            // Расчет координат для центрирования окна
            int windowWidth = this.Width;
            int windowHeight = this.Height;
            int posX = (screenWidth - windowWidth) / 2;
            int posY = (screenHeight - windowHeight) / 2;

            // Установка позиции окна
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(posX, posY);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form3 form2 = new Form3();

            form2.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form4 form2 = new Form4();

            form2.Show();
            this.Hide();
        }
    }
}
