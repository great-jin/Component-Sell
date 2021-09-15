using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ComponentSell
{
    public partial class Lock : Form
    {
        public Lock()
        {
            InitializeComponent();
        }

        SqlHelper sh = new SqlHelper();

        private void button1_Click(object sender, EventArgs e)
        {
            sh.CreateConnection();
            string sql = string.Format("select UserPwd from tb_User where UserName='{0}'", Data.username);
            SqlDataReader sdr = sh.getByReader(sql);
            sdr.Read();
            if (sdr[0].ToString() == textBox1.Text)
            {
                Main_Em me = new Main_Em();
                me.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("输入错误！");
            }
        }
    }
}
