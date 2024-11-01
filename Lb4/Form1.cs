using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb4
{
    public partial class Form1 : Form
    {
        private readonly MySqlConnectionStringBuilder ms;
        private readonly MySqlConnection con;
        public Form1()
        {
            InitializeComponent();
            ms = new MySqlConnectionStringBuilder();
            ms.UserID = "root";
            ms.Password = "123123123";
            ms.Database = "sql_administration_lb1";
            ms.Server = @"127.0.0.1";

            con = new MySqlConnection(ms.ConnectionString);
            con.Open();
            tabControl1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void редагуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
