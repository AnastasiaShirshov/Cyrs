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
    public partial class Zacaz : Form
    {
        int r = 0, s, p;
        public Zacaz()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string NomerZakaza = textBox1.Text.ToString();
            string KodKlienta = textBox8.Text.ToString();
            string Seria = textBox7.Text.ToString();
            string Kol = textBox3.Text.ToString();
            string SPrise = textBox6.Text.ToString();
            string Prise = textBox5.Text.ToString();
            string KodSotrudnika = textBox4.Text.ToString();
            string Dostavka = textBox2.Text.ToString();



            string ConnStr = @"Data Source=DESKTOP-SE05980\SQL1;Initial Catalog=""база данных курсача ауф!"";Integrated Security=True";

            SqlConnection dbConnection = new SqlConnection(ConnStr);
            dbConnection.Open();
            string query = "INSERT INTO ZACAZ VALUES ('" + NomerZakaza + "','" + KodKlienta + "', '" + Seria + "','" + Kol + "','" + SPrise + "','" + Prise + "','" + KodSotrudnika + "','" + Dostavka + "')";

            SqlCommand dbCommand = new SqlCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)

                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");

            else

                MessageBox.Show("Данные добавлены!", "Внимание!");

            dbConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Zacaz_Load(object sender, EventArgs e)
        {

        }
    }
}
