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
    public partial class Form3 : Form
    {
        private MySqlConnection databaseConnection()//เชื่อมต่อdata base
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=stock_project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//check ว่ามีผู้สมัครนี้อยู่ใน data base หรือไม่
        {
            if (checkUser()==true)
            {
                MessageBox.Show("มีผู้สมัครนี้อยู่แล้ว", "สมัครสมาชิกล้มเหลว", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtPasstwo.Text = "";
                txtUsername.Focus();
            }
            else if (txtUsername.Text == "" || txtPassword.Text == "" || txtPasstwo.Text == "")//ถ้ามีช่องว่างก็จะแจ้งเตืนว่าสมัครสมาชิกล้มเหลว
            {
                MessageBox.Show("มีช่องว่าง", "สมัครสมาชิกล้มเหลว", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtPasstwo.Text)//พาสกับคอนเฟริ์มพาสเหมือนกันก็ใชh try catch
            {
                    try
                    {
                        MySqlConnection conn = databaseConnection();

                        string sql = "INSERT INTO uname(user,pass) VALUES('" + txtUsername.Text + "','" + txtPassword.Text + "')";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        conn.Close();
                        if (rows > 0)//ถ้า insert สำเร็จก็ให้ทุกช่องว่างเปล่า
                        {
                            txtUsername.Text = "";
                            txtPassword.Text = "";
                            txtPasstwo.Text = "";
                            MessageBox.Show("สมัครสมาชิก สำเร็จ", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form1 a = new Form1();
                            this.Hide();
                            a.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                
            }
            else//ถ้าpasswordกับคอนเฟริมไม่ตรงกันก็แสดงอันนี้
            {
                MessageBox.Show("รหัสผ่านไม่ตรงกัน, ลองใหม่อีกครั้ง", "สมัครสมาชิกล้มเหลว", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtPasstwo.Text = "";
                txtPassword.Focus();
            }
        }
        public Boolean checkUser()//chech user ว่ามีไหนdata base หรือยัง
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=stock_project";
            MySqlConnection conn = new MySqlConnection(connectionString);
            string username = txtUsername.Text;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM uname WHERE user = @user", conn);

            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)//ถ้ามีชื่อuserอยู่แล้วจะเข้าifแรก
            {
                return true;
            }
            else//ถ้าfalse หรือ ไม่มีชื่อ user จะเข้า if สอง
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.Show();
        }
    }
}
