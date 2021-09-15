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
    public partial class Main_Ce : Form
    {
        public Main_Ce()
        {
            InitializeComponent();
        }

        SqlHelper sh = new SqlHelper();

        private void Main_Ce_Load(object sender, EventArgs e)
        {
            ts2.Text = Data.username;
            ts4.Text = DateTime.Now.ToLongTimeString();
        }

        private void bt_order_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            od.Show();
            this.Hide();
        }

        private void bt_amend_Click(object sender, EventArgs e)
        {
            AlterPwd apw = new AlterPwd();
            apw.Show();
            this.Hide();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void bt_pay_Click(object sender, EventArgs e)
        {
            PayContrack pc = new PayContrack();
            pc.Show();
            this.Hide();
        }
    }
}
