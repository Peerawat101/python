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
        bool menutype = true;
        string name, price,part,aa;
        int allprice;
        private MySqlConnection databaseConnection()// 
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
            cmd.CommandText = $"SELECT id,name,price  FROM {table} ";// table จะเปลี่ยนตามที่เรากด คือ จะเป็น shoes หรือ equipment

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "รายการสินค้า")
            {
                foreach (ToolStripMenuItem dropDownItem in MenuItems.DropDownItems)
                {
                    dropDownItem.Click += new EventHandler(dropDownItem_Click);
                }
            }
        }

        
        private void dropDownItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CalcuBut_Click(object sender, EventArgs e)//4
        {
            int price = int.Parse(PriceBox.Text);
            int pay = int.Parse(PayBox.Text);
            int result;
            result = pay - price;
            ResultBox.Text = result.ToString();
            MessageBox.Show("ขอบคุณที่ใช้บริการครับ");
            OrderListBox.Clear();
            PriceListBox.Clear();
        }

        private void ClearBut_Click(object sender, EventArgs e)//5
        {
            PriceBox.Text = "0";
            PayBox.Text = "";
            ResultBox.Text = "";
            OrderListBox.Clear();
            PriceListBox.Clear();
            PictureBox.Image = null;
        }

        private void OrderBut_Click(object sender, EventArgs e)//3
        {
            if (menutype == false)//อุปกรณ์
            {
                OrderListBox.AppendText(name + comboBox2.SelectedItem.ToString() + " ชิ้น\n");
            } 
            else//รองเท้า
            {
                OrderListBox.AppendText(name + comboBox1.SelectedItem.ToString()+ comboBox2.SelectedItem.ToString() + " ชิ้น\n");
            }
            int amount = int.Parse(comboBox2.SelectedItem.ToString());// 96 97 เก็บค่าตัวแปรหลักจาก combo box
            int total = Convert.ToInt32(price) * amount;
            PriceListBox.AppendText(total + " บาท\n");// box ราคาสินค้า
            allprice += (total);// + ราคาสินค้า เรื่อยๆ
            PriceBox.Text = allprice.ToString();// ราคารวมทั้งหมดมาบวกกัน
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void รองเทาToolStripMenuItem_Click_1(object sender, EventArgs e)//1
        {
            menutype = true;
            showdata("shoes");
            comboBox1.Show();
        }

        private void อปกรณการวงToolStripMenuItem_Click(object sender, EventArgs e)//1
        {
            menutype = false;
            showdata("equipment_1");
            comboBox1.Hide();
        }
        private void PriceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }

        private void PayBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.Show();
        }

        private void OrderListBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//2 show picture onlyyy
        {
            if (menutype == true) {  aa = "shoes"; }
            else if (menutype == false){  aa = "equipment_1"; }
            dataGridView1.CurrentRow.Selected = true;// กดคลิ๊กได้
            name = dataGridView1.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            price = dataGridView1.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT Picture_part FROM {aa} WHERE name =\"{name}\"";// ปลี่ยน ชื่อไปเรื่อยๆที่เราคลิ๊ก
            MySqlDataReader da = cmd.ExecuteReader();
            if (da.Read())// ถ้ามันมีรูปในdata base ให้มา show ในนี้
            {
                part = da.GetValue(0).ToString();// ส่วนนี้ไปดึงไฟล์รูปเราแล้วมาเปลี่ยน part ให้เรามาใช้ได้
                PictureBox.ImageLocation = part;// show picture
            }
        }
    }
}
