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
    public partial class Form3 : Form
    {
        private readonly MySqlConnection con;
        public Form3(MySqlConnection c)
        {
            InitializeComponent();
            this.con = c;
            fill_grid("SELECT * FROM `books`;", dataGridView1);
        }

        private void fill_grid(string q, DataGridView d) // процедура заповнення сітки даними запиту, мусить бути приватною, щоб не конфліктувати з іншими формами
        { 
            DataTable dt = new DataTable();
            if (con.State.ToString() != "Open") con.Open();
            MySqlCommand com = new MySqlCommand(q, con);
            MySqlDataReader dr = com.ExecuteReader(); //Виконання із поверненням кузультатів запиту
            dt.Load(dr);
            d.DataSource = dt;
            dr.Close();
        }



        private void run_query(string q) //виконання запиту без повернення результатів, повиння бути приватною, щоб не конфліктувала з іншими формами
        {
            if (con.State.ToString() != "Open") con.Open();
            MySqlCommand com = new MySqlCommand(q, con);
            com.ExecuteNonQuery(); //Виконання без повернення результатів запиту
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = textBox1.Text + "";
            fill_grid("SELECT * FROM `books` WHERE `Name` LIKE '%" + s + "%';", dataGridView1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string s = textBox2.Text + "";
            fill_grid("SELECT * FROM `books` WHERE `Author` LIKE '%" + s + "%';", dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox3.Text + "";
            string author = textBox4.Text + "";
            string data = textBox5.Text + "";
            run_query("INSERT INTO `books` VALUES (NULL,'" + name + "','" + author + "','" + data + "');");
            fill_grid("SELECT * FROM `books`;", dataGridView1);

            textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBox6.Text; string author = textBox7.Text; string data = textBox8.Text;
            string id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["id"].Value + "";
            data = Convert.ToDateTime(data).ToString("yyyy-MM-dd");
            run_query("UPDATE `books` SET `Name`='" + name + "',`Author`='" + author + "',`Data`='" + data + "' WHERE `id`=" + id + ";");
            fill_grid("SELECT * FROM `books`;", dataGridView1);
            button5_Click(this, null);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox6.Text = ""; textBox7.Text = ""; textBox8.Text = "";
            tabControl1.SelectedIndex = 0;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value + ""; //дізнаємось ідентифікатор
            if (id != "")
            {
                run_query("DELETE FROM `books` WHERE `Id`=" + id + ";");// виконуємо запит
                fill_grid("SELECT * FROM `books`;", dataGridView1); // оновлюємо дані на сітці
            }
        }

        private void редагуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Name"].Value + "";
            textBox7.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Author"].Value + "";
            textBox8.Text = Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Data"].Value + "").ToString("dd.MM.yyyy");//форматуємо дату, так як в типі DATETIME зберігається і дата і час, який нам не потрібний, ми відріжемо від дати години, хвилини та секунди (00:00:00)
            tabControl1.SelectedIndex = 1;
        }
    }
}
