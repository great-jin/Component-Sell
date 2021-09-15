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
    public partial class Storage : Form
    {
        public Storage()
        {
            InitializeComponent();
        }

        SqlHelper sh = new SqlHelper();

        private void Storage_Load(object sender, EventArgs e)
        {
            string sql = "select ID,PdName,SLeft,SPlan from tb_Storage";
            dgv.DataSource = sh.getDataBySet(sql).Tables[0];
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
                txt_id.Text = dgv.Rows[i].Cells["ID"].Value.ToString();
                txt_name.Text = dgv.Rows[i].Cells["PdName"].Value.ToString();
                txt_left.Text = dgv.Rows[i].Cells["SLeft"].Value.ToString();
                txt_plan.Text = dgv.Rows[i].Cells["SPlan"].Value.ToString();
                Data.ID = Convert.ToInt32(dgv.Rows[i].Cells["ID"].Value.ToString());
            }
        }

        private void txt_left_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != 13)
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }

        private void txt_plan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != 13)
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }

        private void bt_amend_Click(object sender, EventArgs e)
        {
            sh.CreateConnection();
            if (Data.ID != 0)
            {
                string sql = string.Format("update tb_Storage set SLeft='{0}',SPlan='{1}' where Id='{2}'", txt_left.Text, txt_plan.Text, txt_id.Text);
                int i = sh.getByNonQuery(sql);
                if (i > 0)
                {
                    MessageBox.Show("修改成功");
                    txt_name.Text = txt_left.Text = txt_plan.Text = "";
                    Storage_Load(null, null);
                    Data.ID = 0;
                }
            }
            else
            {
                MessageBox.Show("请先选择一条数据");
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            sh.CreateConnection();
            string sql = string.Format("insert into tb_Storage(PdName,SLeft,SPlan) values('{0}','{1}','{2}')", txt_name.Text,txt_left.Text,txt_plan.Text);
            int i = sh.getByNonQuery(sql);
            if (i > 0)
            {
                MessageBox.Show("新增成功");
                txt_name.Text = txt_left.Text = txt_plan.Text = "";
                Storage_Load(null, null);
            }
            
        }

    }
}
