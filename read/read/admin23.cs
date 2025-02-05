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
    public partial class admin23 : Form
    {
        public admin23()
        {
            InitializeComponent();
        }

        private void admin23_Load(object sender, EventArgs e)
        {
            Table();
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString()+"和"+ dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空控件中的所有数据（旧数据）
            Dao dao = new Dao();
            string sql = "SELECT * FROM t_connect";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin2 admin = new admin2();
            admin.ShowDialog();
            string sql = $"UPDATE t_connect SET state='已处理' WHERE id='{dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}' AND bid='{dataGridView1.SelectedRows[0].Cells[1].Value.ToString()}' AND message='{dataGridView1.SelectedRows[0].Cells[2].Value.ToString()}'";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
            Table();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = $"UPDATE t_connect SET state='驳回' WHERE id='{dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}' AND bid='{dataGridView1.SelectedRows[0].Cells[1].Value.ToString()}' AND message='{dataGridView1.SelectedRows[0].Cells[2].Value.ToString()}'";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("驳回成功！");
            }
            else
            {
                MessageBox.Show("驳回失败！");
            }
            Table();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
