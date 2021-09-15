using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComponentSell
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        SqlHelper sh = new SqlHelper();

        private void Employee_Load(object sender, EventArgs e)
        {
            cmb_occp.SelectedIndex = 0;
            cmb_depart.SelectedIndex = 0;
        }

        private void bt_quit_Click(object sender, EventArgs e)
        {
            Main_Em me = new Main_Em();
            Data.ID = 0;
            me.Show();
            this.Hide();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txt_name.Text = dgv.Rows[i].Cells["EmName"].Value.ToString();
                cmb_sex.Text = dgv.Rows[i].Cells["EmGender"].Value.ToString();
                txt_tel.Text = dgv.Rows[i].Cells["EmTel"].Value.ToString();
                cmb_occp.Text = dgv.Rows[i].Cells["EmType"].Value.ToString();
                cmb_depart.Text = dgv.Rows[i].Cells["EmDepart"].Value.ToString();
                txt_memo.Text = dgv.Rows[i].Cells["EmNote"].Value.ToString();
                txt_adress.Text = dgv.Rows[i].Cells["EmAdress"].Value.ToString();
                Data.ID = Convert.ToInt32(dgv.Rows[i].Cells["ID"].Value.ToString());
            }
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            string sql = "select ID,EmName,EmGender,EmTel,EmType,EmDepart,EmAdress,EmNote from tb_Employee";
            dgv.DataSource = sh.getDataBySet(sql).Tables[0];
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            sh.CreateConnection();
            string sql = string.Format("insert into tb_Employee(EmName,EmGender,EmTel,EmType,EmDepart,EmAdress,EmNote) " +
                "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                txt_name.Text, cmb_sex.Text, txt_tel.Text, cmb_occp.Text,cmb_depart.Text, txt_adress.Text, txt_memo.Text);
            int i = sh.getByNonQuery(sql);
            if (i > 0)
            {
                MessageBox.Show("添加成功");

                int p;
                if (cmb_occp.SelectedIndex == 0)
                {
                    p = 1;          //员工
                }
                else 
                {
                    p = 0;          //科长
                }

                //信息添加到登录表
                string sql2 = string.Format("insert into tb_User(UserName,UserPwd,UserPower) values('{0}','{1}','{2}')", txt_name.Text, "000", p);
                sh.getByNonQuery(sql2);

                txt_name.Text = cmb_sex.Text = txt_tel.Text = cmb_occp.Text = txt_adress.Text = txt_memo.Text = "";
                bt_search_Click(null,null);
            }
        }

        private void bt_amend_Click(object sender, EventArgs e)
        {
            sh.CreateConnection();
            if(Data.ID !=0 )
            {
                string sql = string.Format("update tb_Employee set EmName='{0}',EmGender='{1}',EmTel='{2}',EmType='{3}',EmDepart='{4}',EmAdress='{5}',EmNote='{6}' where ID='{7}'",
                    txt_name.Text, cmb_sex.Text, txt_tel.Text, cmb_occp.Text, cmb_depart.Text, txt_adress.Text, txt_memo.Text, Data.ID);
                int i = sh.getByNonQuery(sql);
                if (i > 0)
                {
                    MessageBox.Show("修改成功");
                    txt_name.Text = cmb_sex.Text = txt_tel.Text = cmb_occp.Text = txt_adress.Text = txt_memo.Text = "";
                    bt_search_Click(null, null);
                    Data.ID = 0;
                }
            }
            else
            {
                MessageBox.Show("请先选定一条信息");
            }
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            sh.CreateConnection();
            if(Data.ID !=0 )
            {
                string sql = string.Format("delete from tb_Employee where Id='{0}'", Data.ID);
                int i = sh.getByNonQuery(sql);
                if (i > 0)
                {
                    MessageBox.Show("删除成功");

                    //删除登录表对应信息
                    string sql2 = string.Format("delete from tb_User where UserName='{0}'", txt_name.Text);
                    sh.getByNonQuery(sql2);

                    txt_name.Text = cmb_sex.Text = txt_tel.Text = cmb_occp.Text = txt_adress.Text = txt_memo.Text = "";
                    bt_search_Click(null, null);
                    Data.ID = 0;
                }
            }
            else
            {
                MessageBox.Show("请先选定一条信息");
            }
        } 

    }
}
