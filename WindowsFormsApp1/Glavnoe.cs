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
    public partial class Glavnoe : Form
    {
        public Glavnoe()
        {
            InitializeComponent();
        }

        private void Glavnoe_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zacaz f = new Zacaz();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZacazSpisok r = new ZacazSpisok();
            r.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Klients t = new Klients();
            t.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Katalog w = new Katalog();
            w.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
