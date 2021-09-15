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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        SqlHelper sh = new SqlHelper();
        SqlDataReader sdr;

        public void ShowDate()
        {
            string sql = string.Format("select PdName,PdPrice,OrderNum,OrderSum,OrderDate,OrderDGive,OderNote,Osellman,ID" +
                " from tb_Order where CeName='{0}'", Data.username);
            dataGridView1.DataSource = sh.getDataBySet(sql).Tables[0];
        }

        private void Order_Load(object sender, EventArgs e)
        {
            ShowDate();

            //显示所有产品类型
            string sql1 = "select distinct PdType from tb_Product";
            sdr = sh.getByReader(sql1);

            while (sdr.Read())
            {
                if (sdr.HasRows)
                {
                    //显示对应产品
                    TreeNode tn = treeView1.Nodes.Add(sdr[0].ToString());
                    string sql2 = string.Format("select * from tb_Product where PdType='{0}'", sdr[0].ToString());
                    SqlDataReader sdr2 = null;
                    sdr2 = sh.getByReader(sql2);
                    while (sdr2.Read())
                    {
                        tn.Nodes.Add(sdr2["PdName"].ToString());
                    }
                }
            }

            string sql3 = "select EmName from tb_Employee where EmDepart='销售科'";
            SqlDataReader sdr3 = sh.getByReader(sql3);
            while (sdr3.Read())
            {
                cmb_sell.Items.Add(sdr3["EmName"].ToString());
            }
            cmb_sell.SelectedIndex = 0;
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string name = treeView1.SelectedNode.Text;
                string sql = string.Format("select * from tb_Product where PdName='{0}'", name);
                sdr = sh.getByReader(sql);
                sdr.Read();
                txt_name.Text = name;
                txt_price.Text = sdr["PdPrice"].ToString();
                if (txt_num.Text.Equals(""))
                { }
                else
                {
                    txt_sum.Text = (Convert.ToInt32(txt_price.Text) * Convert.ToInt32(txt_num.Text)).ToString();
                }
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }

        private void txt_num_TextChanged(object sender, EventArgs e)
        {
            if (txt_num.Text.Equals(""))
            {
                MessageBox.Show("请输入数字");
            }
            else
            {
                if (Convert.ToInt32(txt_num.Text) < 1)
                {
                    MessageBox.Show("数量不能小于1");
                }
                txt_sum.Text = (Convert.ToInt32(txt_price.Text) * Convert.ToInt32(txt_num.Text)).ToString();
            }
        }

        private void txt_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != 13)
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }

        private void bt_quit_Click(object sender, EventArgs e)
        {
            //退出判断回到哪个页面
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txt_name.Text = dataGridView1.Rows[i].Cells["PdName"].Value.ToString();
                txt_price.Text = dataGridView1.Rows[i].Cells["PdPrice"].Value.ToString();
                txt_num.Text = dataGridView1.Rows[i].Cells["OrderNum"].Value.ToString();
                txt_sum.Text = dataGridView1.Rows[i].Cells["OrderSum"].Value.ToString();
                ordertime.Text = dataGridView1.Rows[i].Cells["OrderDate"].Value.ToString();
                givetime.Text = dataGridView1.Rows[i].Cells["OrderDGive"].Value.ToString();
                txt_note.Text = dataGridView1.Rows[i].Cells["OderNote"].Value.ToString();
                Data.ID = Convert.ToInt32(dataGridView1.Rows[i].Cells["ID"].Value.ToString());
            }
        }

        private void bt_insert_Click(object sender, EventArgs e)
        {
            //转换时间格式
            string timeOrder = ordertime.Text.ToString();
            string timeGive = givetime.Text.ToString();
            timeOrder = MySeal.TransTime(timeOrder);
            timeGive = MySeal.TransTime(timeGive);

            sh.CreateConnection();
            string sql = string.Format("insert into tb_Order(PdName,PdPrice,OrderNum,OrderSum,OrderStatu,OrderDate,OrderDGive,OderNote,CeName,Osellman) " +
                "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                txt_name.Text, txt_price.Text, txt_num.Text, txt_sum.Text, "未审核", timeOrder, timeGive, txt_note.Text, Data.username, cmb_sell.Text);
            int i = sh.getByNonQuery(sql);
            if (i > 0) {
                MessageBox.Show("下单成功");
                txt_name.Text = txt_price.Text = txt_sum.Text = givetime.Text = givetime.Text = txt_note.Text = "";
                ShowDate();
            }
        }

        private void bt_alter_Click(object sender, EventArgs e)
        {
            //转换时间格式
            string timeOrder = ordertime.Text.ToString();
            string timeGive = givetime.Text.ToString();
            timeOrder = MySeal.TransTime(timeOrder);
            timeGive = MySeal.TransTime(timeGive);

            sh.CreateConnection();
            if (Data.ID != 0)
            {
                string orderTime = System.DateTime.Now.ToString("G");
                string sql = string.Format("update tb_Order set OrderNum='{0}',OrderSum='{1}',OrderDate='{2}',OrderDGive='{3}',Osellman='{4}',OderNote='{5}' where ID='{6}'",
                    txt_num.Text, txt_sum.Text, timeOrder, timeGive, cmb_sell.Text, txt_note.Text, Data.ID);
                int i = sh.getByNonQuery(sql);
                if (i > 0)
                {
                    MessageBox.Show("修改成功");
                    txt_name.Text = txt_price.Text = txt_sum.Text = givetime.Text = givetime.Text = txt_note.Text = "";
                    ShowDate();
                    Data.ID = 0;
                }
            }
            else {
                MessageBox.Show("请选择一条信息");
            }
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            sh.CreateConnection();
            if (Data.ID != 0)
            {
                string orderTime = System.DateTime.Now.ToString("G");
                string sql = string.Format("delete from tb_Order where ID='{0}'", Data.ID);
                int i = sh.getByNonQuery(sql);
                if (i > 0)
                {
                    MessageBox.Show("删除成功");
                    txt_name.Text = txt_price.Text = txt_sum.Text = orderTime = givetime.Text = txt_note.Text = "";
                    ShowDate();
                    Data.ID = 0;
                }
            }
            else
            {
                MessageBox.Show("请选择一条信息");
            }
        }

    }
}
