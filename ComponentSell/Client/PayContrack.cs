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
    public partial class PayContrack : Form
    {
        public PayContrack()
        {
            InitializeComponent();
        }

        SqlHelper sh = new SqlHelper();

        private void PayContrack_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(string.Format("{0}\t\t{1}\t\t{2}", "产品名", "采购数量", "单价"));
            listBox1.Items.Add(string.Format("\t"));

            //查询订单产品名，数量
            string sql1 = string.Format("select PdName,OrderNum,PdPrice from tb_Order where CeName='{0}' and OrderStatu='合格订单'", Data.username);
            SqlDataReader sdr1 = sh.getByReader(sql1);
            if (sdr1.HasRows)
            {
                //显示到ListBox
                while (sdr1.Read())
                {
                    listBox1.Items.Add(string.Format("{0}\t\t{1}\t\t{2}", sdr1[0].ToString(), sdr1[1].ToString(), sdr1[2].ToString()));
                    listBox1.Items.Add(string.Format("\t"));
                }
            }

            string sql2 = string.Format("select Cpay from tb_Conpact where CClient='{0}'",Data.username);
            SqlDataReader sdr2 = sh.getByReader(sql2);
            sdr2.Read();
            if (sdr2.HasRows)
            {
                if (sdr2[0].ToString().Equals("未付款"))
                {
                    //查询订单数量
                    int sumprice = 0;
                    string sql3 = string.Format("select OrderSum from tb_Order where CeName='{0}' and OrderStatu='合格订单'", Data.username);
                    SqlDataReader sdr3 = sh.getByReader(sql3);
                    if (sdr3.HasRows)
                    {
                        while (sdr3.Read())
                        {
                            sumprice += Convert.ToInt32(sdr3[0]);
                        }
                    }
                    lb_count.Text = sumprice.ToString();
                    Data.sumprice = sumprice;
                }
                else
                {
                    MessageBox.Show("您的账单已付清");
                    txt_recieve.Enabled = false;
                    bt_pay.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("您的订单还尚未处理");
                txt_recieve.Enabled = false;
                bt_pay.Enabled = false;
            }
        }

        private void bt_pay_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_recieve.Text) > Data.sumprice)
            {
                lb_charge.Text = (Convert.ToInt32(txt_recieve.Text) - Data.sumprice).ToString();
                string sql4 = string.Format("update tb_Conpact set CPay='已付款' where CClient='{0}'", Data.username);
                int i = sh.getByNonQuery(sql4);
                if (i > 0) 
                {
                    MessageBox.Show("支付成功");
                    lb_count.Text = lb_charge.Text = "";
                    txt_recieve.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("金额不能小于消费金额");
            }
        }

        private void txt_recieve_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_recieve.Text) > Data.sumprice)
            {
                lb_charge.Text = (Convert.ToInt32(txt_recieve.Text) - Data.sumprice).ToString();
            }
           
        }

        private void txt_recieve_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != 13)
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }

        private void bt_quit_Click(object sender, EventArgs e)
        {
            Main_Ce mc = new Main_Ce();
            mc.Show();
            this.Hide();
        }
    }
}
