﻿using System;
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
    public partial class ZacazSpisok : Form
    {
        public ZacazSpisok()
        {
            InitializeComponent();
        }

        private void ZacazSpisok_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_база_данных_курсача_ауф_DataSet.ZACAZ". При необходимости она может быть перемещена или удалена.
            this.zACAZTableAdapter.Fill(this._база_данных_курсача_ауф_DataSet.ZACAZ);

        }
    }
}
