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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        SqlHelper sh = new SqlHelper();

        private void Register_Load(object sender, EventArgs e)
        {
            cmb_sex.SelectedIndex = 0;
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            string name="";
            string gender = "";
            string pwd = "";
            string pwd2 = "";

            name = txt_name.Text;
            gender = cmb_sex.Text;
            pwd = txt_pwd.Text;
            pwd2 = txt_pwd2.Text;

            if (!name.Equals(""))
            {

                //查询是否用户名是否存在
                string sql1 = string.Format("select * from tb_User where UserName='{0}'", txt_name.Text);
                SqlDataReader sdr1 = sh.getByReader(sql1);
                sdr1.Read();
                if (!sdr1.HasRows)
                {
                    if (pwd.Equals(pwd2) & !gender.Equals("") & !pwd.Equals("") & !pwd2.Equals(""))
                    {
                        string sql2 = string.Format("insert into tb_User(UserName,UserPwd,UserPower) values('{0}','{1}','{2}')", name, pwd, 2);
                        int i = sh.getByNonQuery(sql2);

                        if (i >= 0 && MessageBox.Show("注册成功,立即登录", "提示", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            //信息添加到信用表
                            string sql3 = string.Format("insert into tb_Credit(CdName,CdGender,CdNew,CdDebt) values('{0}','{1}','{2}','{3}')", name, gender, "是", "否");
                            sh.getByNonQuery(sql3);

                            //信息添加到客户表
                            string sql4 = string.Format("insert into tb_Client(CeName,CeGender) values('{0}','{1}')", name, gender);
                            sh.getByNonQuery(sql4);

                            Login lg = new Login();
                            lg.Show();
                            this.Hide();
                        }
                    }
                    else if (pwd.Equals(""))
                    {
                        MessageBox.Show("密码不能为空");
                        txt_name.Text = txt_pwd.Text = txt_pwd2.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("密码不一致");
                        txt_name.Text = txt_pwd.Text = txt_pwd2.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("用户名已存在");
                    txt_name.Text = txt_pwd.Text = txt_pwd2.Text = "";
                }
            }
            else
            {
                MessageBox.Show("用户名不能为空");
                txt_name.Text = txt_pwd.Text = txt_pwd2.Text = "";
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
