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
    public partial class Conpact : Form
    {
        public Conpact()
        {
            InitializeComponent();
        }

        SqlHelper sh = new SqlHelper();

        private void ShowData() 
        {
            //合同表
            string sql1 = string.Format("select ID,CSellMan,COTime,CCheck,CList,CPrice,CStatus,CGTime,CClient,CPay from tb_Conpact where CClient='{0}'", cmb_client.Text);
            dataGridView1.DataSource = sh.getDataBySet(sql1).Tables[0];
        }

        //读取人员到cmb中
        private void Conpact_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            cmb_client.Text = Data.choose;
            string sql1 = "select EmName from tb_Employee where EmDepart='销售科'";
            SqlDataReader sdr1 = sh.getByReader(sql1);
            while (sdr1.Read())
            {
                cmb_sell.Items.Add(sdr1["EmName"].ToString());
            }
            cmb_sell.SelectedIndex = 0;

            string sql2 = "select EmName from tb_Employee where EmDepart='财务科'";
            SqlDataReader sdr2 = sh.getByReader(sql2);
            while (sdr2.Read())
            {
                cmb_check.Items.Add(sdr2["EmName"].ToString());
            }
            cmb_check.SelectedIndex = 0;

            string sql3 = "select distinct CeName from tb_Order where OrderStatu='合格订单'";
            SqlDataReader sdr3 = sh.getByReader(sql3);
            while (sdr3.Read())
            {
                cmb_client.Items.Add(sdr3["CeName"].ToString());
            }
            cmb_client.SelectedIndex = 0;

            cmb_status.SelectedIndex = 0;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                if (i >= 0)
                {
                    cmb_client.Text = dataGridView1.Rows[i].Cells["CClient"].Value.ToString();
                    txt_price.Text = dataGridView1.Rows[i].Cells["CPrice"].Value.ToString();
                    dateTimePicker2.Text = dataGridView1.Rows[i].Cells["COTime"].Value.ToString();
                    dateTimePicker1.Text = dataGridView1.Rows[i].Cells["CGTime"].Value.ToString();
                    cmb_status.Text = dataGridView1.Rows[i].Cells["CStatus"].Value.ToString();
                    cmb_sell.Text = dataGridView1.Rows[i].Cells["CSellMan"].Value.ToString();
                    cmb_check.Text = dataGridView1.Rows[i].Cells["CCheck"].Value.ToString();
                    Data.ID = Convert.ToInt32(dataGridView1.Rows[i].Cells["ID"].Value.ToString());
                }
            }
            catch (Exception ex){ 
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (cmb_client.Equals(""))
            {
                MessageBox.Show("请选择客户");
            }
            else
            {
                ShowData();
                listBox1.Items.Add(string.Format("\t{0}\t\t\t{1}", "产品名", "采购数量"));
                listBox1.Items.Add(string.Format("\t"));

                //查询订单产品名，数量
                string sql3 = string.Format("select distinct PdName,OrderNum from tb_Order where CeName='{0}' and OrderStatu='合格订单'", cmb_client.Text);
                SqlDataReader sdr3 = sh.getByReader(sql3);
                if (sdr3.HasRows)
                {
                    while (sdr3.Read())     
                    {
                        listBox1.Items.Add(string.Format("\t{0}\t\t{1}", sdr3[0].ToString(), sdr3[1].ToString()));
                        listBox1.Items.Add(string.Format("\t"));
                    }
                }
            }

            //查询订单产品名，数量
            int sumprice = 0;
            string product = null;
            string sql4 = string.Format("select PdName,OrderSum from tb_Order where CeName='{0}' and OrderStatu='合格订单'", cmb_client.Text);
            SqlDataReader sdr4 = sh.getByReader(sql4);
            if (sdr4.HasRows)
            {
                while (sdr4.Read())
                {
                    product += sdr4[0].ToString() + ",";
                    sumprice += Convert.ToInt32(sdr4[1]);
                }
            }
            Data.sumprice = sumprice;
            Data.plist = product;
            txt_price.Text = Data.sumprice.ToString()+"  CYN";
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            //查询对应信息 ：下单时间, 交付时间, 销售员, 检查员
            string sql5 = string.Format("select OrderDate,OrderDGive,OSellman,OCheckman from tb_Order where CeName='{0}' and OrderStatu='合格订单'", cmb_client.Text);
            SqlDataReader sdr5 = sh.getByReader(sql5);

            sdr5.Read();
            if (sdr5.HasRows)
            {
                string sql6 = string.Format("insert into tb_Conpact(CSellMan,CCheck,CList,CPrice,CStatus,COTime,CGTime,CClient,CPay) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                    sdr5[2].ToString(), sdr5[3].ToString(), Data.plist, Data.sumprice.ToString(), cmb_status.Text, sdr5[0].ToString(), sdr5[1].ToString(), cmb_client.Text, "未付款");
                int i = sh.getByNonQuery(sql6);
                if (i > 0)
                {
                    MessageBox.Show("合同添加成功，请尽快通知顾客交付对应款项！");
                    ShowData(); 
                }
            }
        }

        private void bt_amend_Click(object sender, EventArgs e)
        {
            string dateStr="";
            dateStr = dateTimePicker1.Text.ToString();
            dateStr = MySeal.TransTime(dateStr);

            sh.CreateConnection();
            if (Data.ID != 0)
            {
                string sql = string.Format("update tb_Conpact set CSellMan='{0}',CCheck='{1}',CPrice='{2}',CStatus='{3}',CGTime='{4}',CClient='{5}' where ID='{6}'",
                    cmb_sell.Text, cmb_check.Text, txt_price.Text, cmb_status.Text, dateStr, cmb_client.Text, Data.ID);
                int i = sh.getByNonQuery(sql);
                if (i > 0)
                {
                    MessageBox.Show("修改成功");
                    ShowData();
                    cmb_sell.Text = cmb_check.Text = txt_price.Text = cmb_client.Text ="";
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
            if (Data.ID != 0)
            {
                string sql = string.Format("delete from tb_Conpact where ID='{0}'", Data.ID);
                int i = sh.getByNonQuery(sql);
                if (i > 0)
                {
                    MessageBox.Show("删除成功");
                    ShowData();
                    cmb_sell.Text = cmb_check.Text = txt_price.Text = cmb_client.Text;
                    Data.ID = 0;
                }
            }
            else
            {
                MessageBox.Show("请先选定一条信息");
            }
        }

        private void bt_quit_Click(object sender, EventArgs e)
        {
            Main_Em me = new Main_Em();
            Data.ID = 0;
            me.Show();
            this.Hide();
        }
    }
}
