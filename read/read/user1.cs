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
    public partial class user1 : Form
    {
        public user1()
        {
            InitializeComponent();
        }

        private void 图书查看和借阅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user11 user = new user11();
            this.Hide();
            user.ShowDialog();
            this.Show();
        }

        private void 当前借书和归还ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user12 user = new user12();
            this.Hide();
            user.ShowDialog();
            this.Show();
        }

        private void 系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user13 user = new user13();
            this.Hide();
            user.ShowDialog();
            this.Show();
        }

        private void 联系管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user14 user = new user14();
            this.Hide();
            user.ShowDialog();
            this.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
