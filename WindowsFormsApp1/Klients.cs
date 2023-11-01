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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Klients : Form
    {
        int r = 0, s, p;
        public Klients()
        {
            InitializeComponent();
        }

        public void MyExecuteNonQuery(string SqlText)
        {
            SqlConnection cn;
            SqlCommand cmd;
            string ConnStr = @"Data Source=DESKTOP-SE05980\SQL1;Initial Catalog=""база данных курсача ауф!"";Integrated Security=True";
            cn = new SqlConnection(ConnStr);
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = SqlText;
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string KodKlienta = textBox1.Text.ToString();
            string Name = textBox8.Text.ToString();
            string Telephone = textBox7.Text.ToString();
            string Skidka = textBox3.Text.ToString();
            string Adres = textBox2.Text.ToString();

            string ConnStr = @"Data Source=DESKTOP-SE05980\SQL1;Initial Catalog=""база данных курсача ауф!"";Integrated Security=True";

            SqlConnection dbConnection = new SqlConnection(ConnStr);
            dbConnection.Open();
            string query = "INSERT INTO Klients VALUES (" + KodKlienta + ",'" + Name + "', '" + Telephone + "', '" + Skidka + "', '" + Adres + "')";

            SqlCommand dbCommand = new SqlCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)

                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");

            else

                MessageBox.Show("Данные добавлены!", "Внимание!");


            dbConnection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
string KodKlienta = textBox1.Text.ToString();
            //создаем соединение
            string ConnStr = @"Data Source=DESKTOP-SE05980\SQL1;Initial Catalog=""база данных курсача ауф!"";Integrated Security=True";
            SqlConnection dbConnection = new SqlConnection(ConnStr);

            // Выполняем запрос к базе данных

            dbConnection.Open();//открываем соединение

            string query = "DELETE FROM Klients WHERE KodKlienta=" + KodKlienta;//строка запроса
            SqlCommand dbCommand = new SqlCommand(query, dbConnection);//команда

            //Выполняем запрос
            if (dbCommand.ExecuteNonQuery() != 1)

                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");

            else

                MessageBox.Show("Данные удалены!", "Внимание");

            //Закрываем соединение с БД

            dbConnection.Close();
        }

        private void Klients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_база_данных_курсача_ауф_DataSet1.Klients". При необходимости она может быть перемещена или удалена.
            this.klientsTableAdapter.Fill(this._база_данных_курсача_ауф_DataSet1.Klients);

        }

       

    }
}
