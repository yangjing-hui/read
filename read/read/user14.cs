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
    public partial class user14 : Form
    {
        public user14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string message = textBox2.Text;

            // 示例：简单的验证
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(message))
            {
                MessageBox.Show("请填写所有字段", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Dao dao = new Dao();
                string sql = $"INSERT INTO t_connect VALUES('{Data.Uid}','{textBox1.Text}','{textBox2.Text}','审核中')";

                if (dao.Execute(sql) > 0)
                {
                    MessageBox.Show("提交成功！");
                }
                else
                {
                    MessageBox.Show("提交失败！");
                }
                dao.DaoClose();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user15 user = new user15();
            this.Hide();
            user.ShowDialog();
            this.Show();
        }
    }
}
