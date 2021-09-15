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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlHelper sh=new SqlHelper();

        private void bt_ok_Click(object sender, EventArgs e)
        {
            sh.CreateConnection();
            string sql = "select count(*) from tb_User where UserName=@name and UserPwd=@pwd";
            SqlParameter[] sp = new SqlParameter[] { 
                new SqlParameter("@name",txt_name.Text),
                new SqlParameter("@pwd",txt_pwd.Text)
            };
            int i = sh.getByScalar(sql, sp);
            if (i > 0)
            {
                string power;
                string sql1=string.Format("select * from tb_User where UserName='{0}' and UserPwd='{1}'",txt_name.Text,txt_pwd.Text);
                SqlDataReader sdr = sh.getByReader(sql1);
                sdr.Read();
                if (sdr.HasRows) 
                {
                    power = sdr["UserPower"].ToString();
                    Data.username = txt_name.Text;
                    Data.power = power.Trim();
                    if (power.Equals("2"))
                    {
                        Main_Ce mc = new Main_Ce();
                        mc.Show();
                        this.Hide();
                    }
                    else
                    {
                        Main_Em me = new Main_Em();
                        me.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                txt_name.Text = "";
                txt_pwd.Text = "";
                txt_name.Focus();
                MessageBox.Show("输入有误，请重新输入！");
            }
            sh.CloseConnection();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lb_register_Click(object sender, EventArgs e)
        {
            Register rs = new Register();
            rs.Show();
            this.Hide();
        }

        private void lb_destory_Click(object sender, EventArgs e)
        {
            Destory dt = new Destory();
            dt.Show();
            this.Hide();
        }

    }
}
