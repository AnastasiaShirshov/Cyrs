using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string ConnStr = @"Data Source=DESKTOP-SE05980\SQL1;Initial Catalog=""база данных курсача ауф!"";Integrated Security=True";
            SqlConnection dbConnection = new SqlConnection(ConnStr);
            dbConnection.Open();//открываем соединение
            bool success = false;
            try
            {
                const string comand = "Select 42 From [Avtorizaci] WHERE Login=@Login AND Parol = @Parol";
            SqlCommand check = new SqlCommand(comand, dbConnection);
                check.Parameters.AddWithValue("@Login", textBox1.Text);
                check.Parameters.AddWithValue("@Parol", textBox2.Text);
                using (SqlDataReader dataReader = check.ExecuteReader())
                {
                    success = dataReader.Read();
                }
            }
            finally
            {
                //Закрываем соединение с БД
                dbConnection.Close();
            }
            if (success)
            {              
                MessageBox.Show("Все верно- Проходите");

                Glavnoe f = new Glavnoe();
                f.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }

        }
    }
}
