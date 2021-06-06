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
    public partial class Form2 : Form
    {
        string userid = Program.userid;
        bool menutype = true;
        string name, price,part,aa,allamount;
        List<string> size = new List<string> { "size 5 us", "size 6 us", "size 7 us", "size 8 us", "size 9 us", "size 10 us", "size 10.5 us", "size 11 us", "size 11.5 us", "size 12 us" };
        private MySqlConnection databaseConnection()//ลิ้งกับdata base
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=stock_project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void showdata(string table)//shoes or equipment
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT id,name,price,amount  FROM {table} ";// table จะเปลี่ยนตามที่เรากด คือ จะเป็น shoes หรือ equipment

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        private void showhis()//shoes or equipment
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT name,price,amount  FROM history WHERE status=\"unpay\"AND userid=\"{userid}\" ";//เราจะshow สินค้าที่เราเลือกสินค้าไว้ใน datagrid view

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
        }
        public Form2()
        {
            InitializeComponent();
        }
        private void CalcuBut_Click(object sender, EventArgs e)//4
        {
            int price = int.Parse(PriceBox.Text);//ราคารวม
            int pay = int.Parse(PayBox.Text);//ราคาจ่าย
            int result;
            result = pay - price;//เงินทอน
            ResultBox.Text = result.ToString();
            MessageBox.Show("ขอบคุณที่ใช้บริการครับ");
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"UPDATE history SET status=\"pay\"WHERE status=\"unpay\"AND userid=\"{userid}\"";
            cmd.ExecuteNonQuery();
            if(menutype==true)
            {
                showdata("shoes");
            }
            else
            {
                showdata("equipment_1");
            }
            showhis();
            reset();
        }
        private void reset()
        {
            setallprice();
            PayBox.Text = "";
            ResultBox.Text = "";
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            PictureBox.Image = null;
        }

        private void ClearBut_Click(object sender, EventArgs e)//5
        {
            reset();
        }

        private void OrderBut_Click(object sender, EventArgs e)//3
        {
            int amount = int.Parse(comboBox2.SelectedItem.ToString());//เปลี่ยนcombox2เป็นintจำนวนชิ้น
            int newamount = Convert.ToInt32(allamount) - amount;
            int total = Convert.ToInt32(price) * amount;
            if (menutype == false)//อุปกรณ์
            {
                MySqlConnection conn = databaseConnection();
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"INSERT INTO history(userid,name,price,amount,status) VALUES(\"{userid}\",\"{name}\",\"{total}\",\"{comboBox2.Text}\",\"unpay\")";//datagridview ซ้ายไปขวา
                int row=cmd.ExecuteNonQuery();
                if(row>0)
                {
                    MySqlConnection conn2 = databaseConnection();
                    conn2.Open();
                    MySqlCommand cmd2 = conn2.CreateCommand();
                    cmd2.CommandText = $"UPDATE equipment_1 SET amount=\"{newamount}\"WHERE name=\"{name}\"";//อัพเดทจำนวนสินค้าในคลัง
                    cmd2.ExecuteNonQuery();
                }
            } 
            else//รองเท้า
            {
                MySqlConnection conn = databaseConnection();
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"INSERT INTO history(userid,name,price,amount,status) VALUES(\"{userid}\",\"{name+comboBox1.Text}\",\"{total}\",\"{comboBox2.Text}\",\"unpay\")";//datagridview ซ้ายไปขวา
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MySqlConnection conn2 = databaseConnection();
                    conn2.Open();
                    MySqlCommand cmd2 = conn2.CreateCommand();
                    cmd2.CommandText = $"UPDATE shoes SET amount=\"{newamount}\"WHERE name=\"{name}\"";//อัพเดทจำนวนสินค้าในคลัง
                    cmd2.ExecuteNonQuery();
                }
            }
            setallprice();
            showhis();
        }

        private void setallprice()
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT SUM(price) FROM history WHERE userid=\"{userid}\"AND status=\"unpay\"";
            object total = cmd.ExecuteScalar();
            if (Convert.ToString(total) =="")//ถ้าว่างprice box เป็น0
            {
                PriceBox.Text = "0";
            }
            else
            {
                PriceBox.Text = Convert.ToString(total);//ถ้าไม่ว่างเอาจรงตามเงื่อนไขทั้งหมดมาบวกกันแล้วเก็ยไว้ในpricebox
            }
            
        }
    
        private void รองเทาToolStripMenuItem_Click_1(object sender, EventArgs e)//1
        {
            menutype = true;//กดรองท้าจะเลือกใช่data base shoes
            showdata("shoes");
            comboBox1.Show();
        }

        private void อปกรณการวงToolStripMenuItem_Click(object sender, EventArgs e)//1
        {
            menutype = false;//กดอุปกรณ์เลือกใช่data equipment
            showdata("equipment_1");
            comboBox1.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }

        private void PayBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//ไม่สามารถพิมพ์ตัวอักษรลงใน box นี้ได้
        }

        private void button1_Click(object sender, EventArgs e)//ประวัติการซื้อ
        {
            this.Hide();
            Form4 fm = new Form4();
            fm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)//ออกจากระบบ
        {
            Form1 a = new Form1();
            this.Hide();
            a.Show();
        }
        private void setsize()//reset size รองเท้า
        {
            for (int i = 0; i < size.Count; i++)
            {
                comboBox1.Items.Add(size[i]);
            }
        }

        private void Form2_Load(object sender, EventArgs e)//รายการซื้อปัจจุบัน
        {
            showhis();
            setallprice();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//2 show picture onlyyy
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            if (menutype == true) {  aa = "shoes"; }
            else if (menutype == false){  aa = "equipment_1"; }
            dataGridView1.CurrentRow.Selected = true;// กดคลิ๊กได้
            name = dataGridView1.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            price = dataGridView1.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
            allamount = dataGridView1.Rows[e.RowIndex].Cells["amount"].FormattedValue.ToString();
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT Picture_part FROM {aa} WHERE name =\"{name}\"";// เปลี่ยน ชื่อไปเรื่อยๆที่เราคลิ๊ก
            MySqlDataReader da = cmd.ExecuteReader();
            if (da.Read())// ถ้ามันมีรูปในdata base ให้มา show ในนี้
            {
                part = da.GetValue(0).ToString();// ส่วนนี้ไปดึงไฟล์รูปเราแล้วมาเปลี่ยน part ให้เรามาใช้ได้
                PictureBox.ImageLocation = part;// show picture
            }
            for (int i = 1; i <= Convert.ToInt32(allamount);i++)//จำนวนชิ้นที่ให้เราเลือกก็จะหายไปด้วย
            {
                comboBox2.Items.Add(i);
            }
            setsize();
        }
    }
}
