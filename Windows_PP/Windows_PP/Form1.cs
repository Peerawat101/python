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

namespace Windows_PP
{
    public partial class Form1 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=stock_project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM uname WHERE user ='" + textBox1.Text + "'AND pass ='" + textBox2.Text + "'";

            MySqlDataReader row = cmd.ExecuteReader();
            if (row.Read())
            {
                MessageBox.Show("เข้าสู่ระบบสำเร็จ");
                Form2 a = new Form2();
                this.Hide();
                a.Show();
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้งาน หรือ รหัสผ่านไม่ถูกต้อง");
            }
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            this.Hide();
            a.Show();
        }
    }
}
