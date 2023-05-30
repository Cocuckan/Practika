using System;
using System.Drawing;
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
             this.список_путевокTableAdapter1.Fill(this.database411DataSet2.Список_путевок);
            Screen screen = Screen.PrimaryScreen;
            int screenWidth = screen.Bounds.Width;
            int screenHeight = screen.Bounds.Height;


            int windowWidth = this.Width;
            int windowHeight = this.Height;
            int posX = (screenWidth - windowWidth) / 2;
            int posY = (screenHeight - windowHeight) / 2;


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
