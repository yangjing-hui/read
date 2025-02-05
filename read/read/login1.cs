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
    public partial class login1 : Form
    {
        public login1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                login();
            }
            else
            {
                MessageBox.Show("输入有空项，请重新输入！");
            }
        }
        public void login()
        {
            if (user.Checked == true)
            {
                Data.Uid = textBox1.Text;
                Dao dao = new Dao();
                string sql = "SELECT * FROM t_user WHERE id='" + textBox1.Text + "' AND psw ='" + textBox2.Text + "'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    MessageBox.Show("登录成功！");
                    user1 user = new user1();
                    this.Hide();
                    user.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败！");
                }
                dao.DaoClose();
            }
            else if (admin.Checked == true)
            {
                Data.Uid = textBox1.Text;
                Dao dao = new Dao();
                string sql = "SELECT * FROM t_admin WHERE id='" + textBox1.Text + "' AND psw ='" + textBox2.Text + "'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    MessageBox.Show("登录成功！");
                    admin1 admin = new admin1();
                    this.Hide();
                    admin.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败！");
                }
                dao.DaoClose();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (user.Checked == true)
            {
                register register = new register();
                register.ShowDialog();
            }
            else if (admin.Checked == true)
            {
                MessageBox.Show("用户无法注册，请联系管理员！");
            }
        }
    }
}