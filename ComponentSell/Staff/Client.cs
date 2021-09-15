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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        SqlHelper sh = new SqlHelper();

        private void bt_quit_Click(object sender, EventArgs e)
        {
            Main_Em me = new Main_Em();
            Data.ID = 0;
            me.Show();
            this.Hide();
        }

        private void bt_seach_Click(object sender, EventArgs e)
        {
            string sql = "select ID,CeName,CeGender,CeTel,CdAdress,CeNote from tb_Client";
            dgv.DataSource = sh.getDataBySet(sql).Tables[0];
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txt_name.Text = dgv.Rows[i].Cells["CeName"].Value.ToString();
                cmb_sex.Text = dgv.Rows[i].Cells["CeGender"].Value.ToString();
                txt_tel.Text = dgv.Rows[i].Cells["CeTel"].Value.ToString();
                txt_adress.Text = dgv.Rows[i].Cells["CdAdress"].Value.ToString();
                txt_memo.Text = dgv.Rows[i].Cells["CeNote"].Value.ToString();
                Data.ID = Convert.ToInt32(dgv.Rows[i].Cells["ID"].Value.ToString());
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            sh.CreateConnection();
            string sql = string.Format("insert into tb_Client(CeName,CeGender,CeTel,CdAdress,CeNote)" +
                "values('{0}','{1}','{2}','{3}','{4}')",
                txt_name.Text,cmb_sex.Text,txt_tel.Text,txt_adress.Text,txt_memo.Text);
            int i = sh.getByNonQuery(sql);
            if (i > 0)
            {
                MessageBox.Show("添加成功");

                //信息添加到登录表
                string sql2 = string.Format("insert into tb_User(UserName,UserPwd,UserPower) values('{0}','{1}','{2}')", txt_name.Text, "000", 2);
                sh.getByNonQuery(sql2);

                //信息添加到信用表
                string sql3 = string.Format("insert into tb_Credit(CdName,CdGender,CdNew,CdDebt) values('{0}','{1}','{2}','{3}')", txt_name.Text, cmb_sex.Text, "是","否");
                sh.getByNonQuery(sql3);

                txt_name.Text = cmb_sex.Text = txt_tel.Text = txt_adress.Text = txt_memo.Text = "";
                bt_seach_Click(null,null);
            }
        }

        private void bt_amend_Click(object sender, EventArgs e)
        {
            sh.CreateConnection();
            if (Data.ID != 0)
            {
                string sql = string.Format("update tb_Client set CeName='{0}',CeGender='{1}',CeTel='{2}',CdAdress='{3}',CeNote='{4}' where Id='{5}'",
                txt_name.Text, cmb_sex.Text, txt_tel.Text, txt_adress.Text, txt_memo.Text, Data.ID);
                int i = sh.getByNonQuery(sql);
                if (i > 0)
                {
                    MessageBox.Show("修改成功");
                    txt_name.Text = cmb_sex.Text = txt_tel.Text = txt_adress.Text = txt_memo.Text = "";
                    bt_seach_Click(null, null);
                    Data.ID = 0;
                }
            }
            else {
                MessageBox.Show("请先选定一条信息");
            }
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            sh.CreateConnection();
            if (Data.ID != 0)
            {
                string sql = string.Format("delete from tb_Client where Id='{0}'", Data.ID);
                int i = sh.getByNonQuery(sql);
                if (i > 0)
                {
                    MessageBox.Show("删除成功");

                    //删除登录表对应信息
                    string sql2 = string.Format("delete from tb_User where UserName='{0}'", txt_name.Text);
                    sh.getByNonQuery(sql2);

                    //删除信用表对应信息
                    string sql3 = string.Format("delete from tb_Credit where CdName='{0}'", txt_name.Text);
                    sh.getByNonQuery(sql3);

                    txt_name.Text = cmb_sex.Text = txt_tel.Text = txt_adress.Text = txt_memo.Text = "";
                    bt_seach_Click(null, null);
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
