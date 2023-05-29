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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database411DataSet2.Список_путевок". При необходимости она может быть перемещена или удалена.
            this.список_путевокTableAdapter.Fill(this.database411DataSet2.Список_путевок);
            
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
            MessageBox.Show("Заказ успешно подтвержден", "Уведомление");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заказ успешно отменен", "Уведомление");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Hide();
        }
    }
}
