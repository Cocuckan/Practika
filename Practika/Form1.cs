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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Practika
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }


        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

            
        }
        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {


            string username = textBox1.Text;
            string password = maskedTextBox1.Text;
           
                    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Ошибка при входе в аккаунт", "Ошибка");
            }
            else if ((username != "Администратор" || password != "1") &&
                     (username != "Агенство" || password != "2")) 
            {

            
                MessageBox.Show("Неправильно введено имя пользователя или пароль", "Ошибка");
            }
            else
            {
                if (username == "Администратор" && password == "1")
                {
                    Form5 form = new Form5();
                    form.Show();
                    this.Hide();
                   
                }
                else if (username == "Агенство" && password == "2")
                {
                    Form2 mainForm = new Form2();
                    mainForm.Show();
                    this.Hide();
                    
                }

            }
        }
        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
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
    

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

       
    }
}