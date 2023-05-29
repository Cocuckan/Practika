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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database411DataSet21.Список_путевок". При необходимости она может быть перемещена или удалена.
            this.список_путевокTableAdapter1.Fill(this.database411DataSet21.Список_путевок);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database411DataSet2.Список_путевок". При необходимости она может быть перемещена или удалена.
            this.список_путевокTableAdapter1.Fill(this.database411DataSet2.Список_путевок);

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

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заказ успешно создан"," Уведомления");
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
