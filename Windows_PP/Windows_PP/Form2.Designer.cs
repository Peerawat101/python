
namespace Windows_PP
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.OrderBut = new System.Windows.Forms.Button();
            this.OrderListBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceListBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CalcuBut = new System.Windows.Forms.Button();
            this.ClearBut = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PayBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.MenuItems = new System.Windows.Forms.ToolStripMenuItem();
            this.รองเทาToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.อปกรณการวงToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ชื่อรายการสินค้า";
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(427, 107);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(329, 370);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 4;
            this.PictureBox.TabStop = false;
            // 
            // OrderBut
            // 
            this.OrderBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderBut.ForeColor = System.Drawing.Color.Red;
            this.OrderBut.Location = new System.Drawing.Point(778, 288);
            this.OrderBut.Name = "OrderBut";
            this.OrderBut.Size = new System.Drawing.Size(121, 60);
            this.OrderBut.TabIndex = 5;
            this.OrderBut.Text = "เลือกสินค้า";
            this.OrderBut.UseVisualStyleBackColor = true;
            this.OrderBut.Click += new System.EventHandler(this.OrderBut_Click);
            // 
            // OrderListBox
            // 
            this.OrderListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderListBox.Location = new System.Drawing.Point(905, 107);
            this.OrderListBox.Name = "OrderListBox";
            this.OrderListBox.Size = new System.Drawing.Size(240, 370);
            this.OrderListBox.TabIndex = 6;
            this.OrderListBox.Text = "";
            this.OrderListBox.TextChanged += new System.EventHandler(this.OrderListBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(908, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "รายการออเดอร์";
            // 
            // PriceListBox
            // 
            this.PriceListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceListBox.Location = new System.Drawing.Point(1159, 107);
            this.PriceListBox.Name = "PriceListBox";
            this.PriceListBox.Size = new System.Drawing.Size(174, 370);
            this.PriceListBox.TabIndex = 8;
            this.PriceListBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1154, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "ราคาสินค้า";
            // 
            // CalcuBut
            // 
            this.CalcuBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcuBut.ForeColor = System.Drawing.Color.Red;
            this.CalcuBut.Location = new System.Drawing.Point(983, 502);
            this.CalcuBut.Name = "CalcuBut";
            this.CalcuBut.Size = new System.Drawing.Size(127, 45);
            this.CalcuBut.TabIndex = 10;
            this.CalcuBut.Text = "คิดเงิน";
            this.CalcuBut.UseVisualStyleBackColor = true;
            this.CalcuBut.Click += new System.EventHandler(this.CalcuBut_Click);
            // 
            // ClearBut
            // 
            this.ClearBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBut.ForeColor = System.Drawing.Color.Red;
            this.ClearBut.Location = new System.Drawing.Point(1171, 502);
            this.ClearBut.Name = "ClearBut";
            this.ClearBut.Size = new System.Drawing.Size(127, 45);
            this.ClearBut.TabIndex = 11;
            this.ClearBut.Text = "เคลียร์สินค้า";
            this.ClearBut.UseVisualStyleBackColor = true;
            this.ClearBut.Click += new System.EventHandler(this.ClearBut_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "รวมราคาทั้งหมด :";
            // 
            // PriceBox
            // 
            this.PriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceBox.Location = new System.Drawing.Point(249, 502);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(157, 33);
            this.PriceBox.TabIndex = 14;
            this.PriceBox.Text = "";
            this.PriceBox.TextChanged += new System.EventHandler(this.PriceBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(443, 502);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "รับเงิน :";
            // 
            // PayBox
            // 
            this.PayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayBox.Location = new System.Drawing.Point(542, 502);
            this.PayBox.Name = "PayBox";
            this.PayBox.Size = new System.Drawing.Size(157, 33);
            this.PayBox.TabIndex = 16;
            this.PayBox.Text = "";
            this.PayBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PayBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(199, 562);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "เงินทอน :";
            // 
            // ResultBox
            // 
            this.ResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultBox.Location = new System.Drawing.Point(307, 562);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(200, 33);
            this.ResultBox.TabIndex = 18;
            this.ResultBox.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(778, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // MenuBar
            // 
            this.MenuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItems});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1345, 31);
            this.MenuBar.TabIndex = 21;
            this.MenuBar.Text = "MenuBar";
            this.MenuBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // MenuItems
            // 
            this.MenuItems.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.รองเทาToolStripMenuItem,
            this.อปกรณการวงToolStripMenuItem});
            this.MenuItems.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItems.Name = "MenuItems";
            this.MenuItems.Size = new System.Drawing.Size(124, 27);
            this.MenuItems.Text = "รายการสินค้า";
            // 
            // รองเทาToolStripMenuItem
            // 
            this.รองเทาToolStripMenuItem.Name = "รองเทาToolStripMenuItem";
            this.รองเทาToolStripMenuItem.Size = new System.Drawing.Size(197, 28);
            this.รองเทาToolStripMenuItem.Text = "รองเท้า";
            this.รองเทาToolStripMenuItem.Click += new System.EventHandler(this.รองเทาToolStripMenuItem_Click_1);
            // 
            // อปกรณการวงToolStripMenuItem
            // 
            this.อปกรณการวงToolStripMenuItem.Name = "อปกรณการวงToolStripMenuItem";
            this.อปกรณการวงToolStripMenuItem.Size = new System.Drawing.Size(197, 28);
            this.อปกรณการวงToolStripMenuItem.Text = "อุปกรณ์การวิ่ง";
            this.อปกรณการวงToolStripMenuItem.Click += new System.EventHandler(this.อปกรณการวงToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ไซส์ 1 us",
            "ไซส์ 2 us",
            "ไซส์ 3 us",
            "ไซส์ 4 us",
            "ไซส์ 5 us",
            "ไซส์ 6 us",
            "ไซส์ 7 us",
            "ไซส์ 8 us",
            "ไซส์ 9 us",
            "ไซส์ 10 us",
            "ไซส์ 11 us",
            "ไซส์ 12 us"});
            this.comboBox1.Location = new System.Drawing.Point(778, 236);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(357, 370);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBox2.Location = new System.Drawing.Point(778, 185);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(76, 28);
            this.comboBox2.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(443, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ภาพสินค้า";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(860, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "ชิ้น";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 583);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1217, 583);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(116, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1345, 655);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PayBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClearBut);
            this.Controls.Add(this.CalcuBut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrderListBox);
            this.Controls.Add(this.OrderBut);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button OrderBut;
        private System.Windows.Forms.RichTextBox OrderListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox PriceListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CalcuBut;
        private System.Windows.Forms.Button ClearBut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox PriceBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox PayBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox ResultBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem MenuItems;
        private System.Windows.Forms.ToolStripMenuItem รองเทาToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem อปกรณการวงToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}