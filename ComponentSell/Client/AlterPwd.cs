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
    public partial class AlterPwd : Form
    {
        public AlterPwd()
        {
            InitializeComponent();
        }

        SqlHelper sh = new SqlHelper();

        private void bt_quit_Click(object sender, EventArgs e)
        {
            if (Data.power.Equals("2"))
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

        private void bt_ok_Click(object sender, EventArgs e)
        {
            sh.CreateConnection();

            string sql1 = string.Format("select UserPwd from tb_User where UserName='{0}'", Data.username);
            SqlDataReader sdr = sh.getByReader(sql1);
            sdr.Read();
            if (sdr[0].ToString() == txt_pwd3.Text)
            {
                //修改密码
                if (txt_pwd.Text.Equals(txt_pwd2.Text) & !txt_pwd.Text.Equals(""))
                {
                    string sql2 = string.Format("update tb_User set UserPwd='{0}' where UserName='{1}'", txt_pwd.Text, Data.username);
                    int i = sh.getByScalar(sql2);
                    if (i >= 0)
                    {
                        MessageBox.Show("修改成功");
                        Login lg = new Login();
                        lg.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("修改失败");
                    }
                }
                else if (txt_pwd.Text.Equals("") || txt_pwd2.Text.Equals(""))
                {
                    MessageBox.Show("新密码不能为空");
                }
                else
                {
                    MessageBox.Show("密码输入不一致");
                }
            }
            else
            {
                MessageBox.Show("密码输入错误！");
            }

            sh.CloseConnection();
        }
    }
}
