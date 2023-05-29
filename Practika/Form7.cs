using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practika
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        // Объявляем переменную для отслеживания статуса заполнения полей
        private bool isField1Filled = false;
        private void Form7_Load(object sender, EventArgs e)
        {
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

       

        private void button2_Click(object sender, EventArgs e)
        {
            string Text = @"^[а-яА-Я]{2,}$";
            string chisla = @"^[0-40000]{2,}$";
            string Data = @"^[0-31].+[0-12].+[0000-2023]+-[0-31].+[0-12].+[0000-2023]{2,}$";
            string input = textBox1.Text;
            string input2 = textBox2.Text;
            string input3 = textBox3.Text;
            string input4 = textBox4.Text;
            string input5 = textBox5.Text;
            string input6 = textBox6.Text;

            if (!Regex.IsMatch(input, chisla))
            {
                errorProvider1.SetError(textBox1, "Поле должно быть заполнено!");
                return;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");


                if (!Regex.IsMatch(input2, Text))
                {
                    errorProvider2.SetError(textBox2, "Поле должно быть заполнено!");
                }
                else
                {
                    errorProvider2.SetError(textBox2, "");

                    if (!Regex.IsMatch(input3, Data))
                    {
                        errorProvider3.SetError(textBox3, "Поле должно быть заполнено!");
                    }
                    else
                    {
                        errorProvider3.SetError(textBox3, "");

                        if (!Regex.IsMatch(input4, chisla))
                        {
                            errorProvider4.SetError(textBox4, "Поле должно быть заполнено!");
                        }
                        else
                        {
                            errorProvider4.SetError(textBox4, "");

                            if (!Regex.IsMatch(input5, chisla))
                            {
                                errorProvider5.SetError(textBox5, "Поле должно быть заполнено!");
                            }
                            else
                            {
                                errorProvider5.SetError(textBox5, "");

                                if (!Regex.IsMatch(input6, Text))
                                {
                                    errorProvider6.SetError(textBox6, "Поле должно быть заполнено!");
                                }
                                else
                                {
                                    errorProvider6.SetError(textBox6, "");

                                    MessageBox.Show("Путевка успешно создана", "Уведомление");
                                }

                            }

                        }
                    }
                }
            }
        }



    
                

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            isField1Filled = !string.IsNullOrEmpty(textBox1.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            isField1Filled = !string.IsNullOrEmpty(textBox3.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            isField1Filled = !string.IsNullOrEmpty(textBox2.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            isField1Filled = !string.IsNullOrEmpty(textBox4.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            isField1Filled = !string.IsNullOrEmpty(textBox6.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            isField1Filled = !string.IsNullOrEmpty(textBox5.Text);
        }
    }
}
