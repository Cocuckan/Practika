using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practika
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        internal void ShowButtonsAdmin()
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.Show();
            this.Hide();
        }
    }
}
