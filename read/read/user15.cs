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
    public partial class user15 : Form
    {
        public user15()
        {
            InitializeComponent();
        }

        private void user15_Load(object sender, EventArgs e)
        {
            Table();
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空控件中的所有数据（旧数据）
            Dao dao = new Dao();
            string sql = $"SELECT * FROM t_connect WHERE id='{Data.Uid}'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[1].ToString(), dc[2].ToString(), dc[3].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
    }
}
