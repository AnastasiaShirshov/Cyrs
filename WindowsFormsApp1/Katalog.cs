using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Katalog : Form
    {
        public Katalog()
        {
            InitializeComponent();
        }

        private void Katalog_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_база_данных_курсача_ауф_DataSet3.Seria". При необходимости она может быть перемещена или удалена.
            this.seriaTableAdapter.Fill(this._база_данных_курсача_ауф_DataSet3.Seria);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_база_данных_курсача_ауф_DataSet2.Tovars". При необходимости она может быть перемещена или удалена.
            this.tovarsTableAdapter.Fill(this._база_данных_курсача_ауф_DataSet2.Tovars);

        }
    }
}
