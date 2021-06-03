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
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=stock_project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtPasstwo.Text == "")
            {
                MessageBox.Show("Some Fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtPasstwo.Text)
            {
                    try
                    {
                        MySqlConnection conn = databaseConnection();

                        string sql = "INSERT INTO uname(user,pass) VALUES('" + txtUsername.Text + "','" + txtPassword.Text + "')";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        conn.Close();
                        if (rows > 0)
                        {
                            txtUsername.Text = "";
                            txtPassword.Text = "";
                            txtPasstwo.Text = "";
                            MessageBox.Show("Register Complete", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form1 a = new Form1();
                            this.Hide();
                            a.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("This UserName Already Taken", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                
            }
            else
            {
                MessageBox.Show("Password does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtPasstwo.Text = "";
                txtPassword.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }

        private void txtPasstwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.Show();
        }
    }
}
