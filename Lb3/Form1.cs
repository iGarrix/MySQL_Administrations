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

namespace Lb3
{
    public partial class Form1 : Form
    {
        private readonly MySqlConnectionStringBuilder ms;
        private readonly MySqlConnection con;

        public Form1()
        {
            ms = new MySqlConnectionStringBuilder
            {
                UserID = "root",
                Password = "123123123",
                Database = "sql_administration_lb1",
                Server = @"127.0.0.1"
            };
            con = new MySqlConnection(ms.ConnectionString);

            InitializeComponent();
            con.Open();
        }

        private void читачіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this.con);
            f2.ShowDialog();
        }

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this.con);
            f3.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
