using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lb1
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM `books`;";
            DataTable dt = new DataTable();
            MySqlCommand com = new MySqlCommand(query, con);

            MySqlDataReader dr = com.ExecuteReader(); 

            if (dr.HasRows) 
            {
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }         
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
