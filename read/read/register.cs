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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string name = textBox2.Text;
            string sex = textBox3.Text;
            string psw = textBox4.Text;
            string repsw = textBox5.Text;

            // 示例：简单的验证
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(sex)|| string.IsNullOrEmpty(psw)|| string.IsNullOrEmpty(repsw))
            {
                MessageBox.Show("请填写所有字段", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (psw != repsw)
            {
                MessageBox.Show("确认密码错误，请重新填写", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (sex != "男" && sex != "女")
            {
                MessageBox.Show("请设置正常的性别！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Dao dao = new Dao();
                string sql = $"INSERT INTO t_user VALUES('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}')";
                
                if (dao.Execute(sql) > 0) 
                {
                    MessageBox.Show("注册成功，请返回登录");
                }
                else
                {
                    MessageBox.Show("注册失败！");
                }
                dao.DaoClose();
            }
            
        }
    }
}
