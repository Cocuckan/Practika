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
    public partial class Form8 : Form
    {
        

        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private bool isField1Filled = false;
        private void button1_Click(object sender, EventArgs e)
        {
            string Text = @"^[а-яА-Я"" «» ]{2,}$";
            string chisla = @"^[0-9]+$";
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

                                    Close();
                                }
                            }
                        }
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string chisla = @"^[0-9]+$";
            string input7 = textBox7.Text;

            if(!Regex.IsMatch(input7, chisla))
            {
                errorProvider7.SetError(textBox7, "Поле должно быть заполнено!");
            }
            else
            {
                errorProvider7.SetError(textBox7, "");

                MessageBox.Show("Путевка успешно удалена", "Уведомление");
            }

            
        }

        

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            isField1Filled = !string.IsNullOrEmpty(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            isField1Filled = !string.IsNullOrEmpty(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            isField1Filled = !string.IsNullOrEmpty(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            isField1Filled = !string.IsNullOrEmpty(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            isField1Filled = !string.IsNullOrEmpty(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            isField1Filled = !string.IsNullOrEmpty(textBox6.Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            isField1Filled = !string.IsNullOrEmpty(textBox7.Text);
        }

       

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
