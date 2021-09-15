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
    public partial class Destory : Form
    {
        public Destory()
        {
            InitializeComponent();
        }

        SqlHelper sh = new SqlHelper();

        private void bt_ok_Click(object sender, EventArgs e)
        {
            string name="";
            string pwd = "";
            name = txt_name.Text;
            pwd = txt_pwd.Text;

            if (!name.Equals("") & !pwd.Equals(""))
            {
                //查询是否用户名是否存在
                string sql1 = string.Format("select * from tb_User where UserName='{0}'", txt_name.Text);
                SqlDataReader sdr1 = sh.getByReader(sql1);
                sdr1.Read();

                if (sdr1.HasRows)
                {
                    string sql2 = string.Format("select UserPwd from tb_User where UserName='{0}'", name);
                    SqlDataReader sdr2 = sh.getByReader(sql2);
                    sdr2.Read();
                    //密码无误删除信息
                    if (sdr2[0].ToString() == pwd)
                    {
                        string sql3 = string.Format("delete from tb_User where UserName='{0}'", name);
                        int i = sh.getByNonQuery(sql3);
                        if (i >= 0)
                        {
                            MessageBox.Show("注销成功");
                            txt_name.Text = txt_pwd.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("密码错误，注销失败");
                        txt_name.Text = txt_pwd.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("用户名不存在");
                    txt_name.Text = txt_pwd.Text = "";
                }
            }
            else if (name.Equals(""))
            {
                MessageBox.Show("用户名不能为空");
                txt_name.Text = txt_pwd.Text = "";
            }
            else
            {
                MessageBox.Show("密码不能为空");
                txt_name.Text = txt_pwd.Text = "";
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
