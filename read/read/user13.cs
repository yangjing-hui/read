using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace read
{
    public partial class user13 : Form
    {
        public user13()
        {
            InitializeComponent();
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空控件中的所有数据（旧数据）
            Dao dao = new Dao();
            string sql = "SELECT * FROM t_book";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user11 user = new user11();
            this.Hide();
            user.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空控件中的所有数据（旧数据）
            Dao dao = new Dao();
            string sql = $"SELECT * FROM t_book WHERE name LIKE '%{textBox2.Text}%'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
            textBox2.Clear();
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int number = int.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            if (number < 1)
            {
                MessageBox.Show("库存不足，请联系管理员！");
            }
            else
            {
                string sql = $"INSERT INTO t_lend ([uid],bid ,[datetime]) VALUES('{Data.Uid}','{id}',GETDATE());UPDATE t_book SET number =number -1 WHERE id ='{id}'";
                Dao dao = new Dao();
                if (dao.Execute(sql) > 1)
                {
                    MessageBox.Show($"用户{Data.Uid}成功借出图书{id}！");
                    Table();
                }
            }
        }

        private void user13_Load(object sender, EventArgs e)
        {
            Table();
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
 