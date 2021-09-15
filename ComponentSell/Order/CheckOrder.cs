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
    public partial class CheckOrder : Form
    {
        public CheckOrder()
        {
            InitializeComponent();
        }

        SqlHelper sh = new SqlHelper();

        public void ShowData()
        {
            string sql1 = string.Format("select PdName,PdPrice,OrderNum,OrderSum,OrderDate,OrderDGive,OrderStatu,OCheckman,ID from tb_Order where CeName='{0}'", txt_name.Text);
            dgv.DataSource = sh.getDataBySet(sql1).Tables[0];
        }

        private void CheckOrder_Load(object sender, EventArgs e)
        {
            //读取客户姓名前台
            string sql1 = "select CeName from tb_Client";
            SqlDataReader sdr1 = sh.getByReader(sql1);
            while (sdr1.Read())
            {
                txt_name.Items.Add(sdr1["CeName"].ToString());
            }
            txt_name.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql1 = string.Format("select PdName,PdPrice,OrderNum,OrderSum,OrderDate,OrderDGive,OrderStatu,OCheckman,ID from tb_Order where CeName='{0}'", txt_name.Text);
            SqlDataReader sdr2 = sh.getByReader(sql1);
            sdr2.Read();
            if (!sdr2.HasRows)
            {
                //未查询到客户
                MessageBox.Show("未查询到该顾客信息");
                dgv.DataSource = sh.getDataBySet(sql1).Tables[0];
                lb_new.Text = "";
                lb_debt.Text = "";
                lb_advice.Text = "";
                listBox1.Items.Clear();
            }
            else
            {
                //查询到客户
                ShowData();
                listBox1.Items.Clear();
                if (!txt_name.Text.Equals(""))
                {
                    //查询客户信贷情况
                    string sql2 = string.Format("select CdNew,CdDebt from tb_Credit where CdName='{0}'", txt_name.Text);
                    SqlDataReader sdr1 = sh.getByReader(sql2);
                    sdr1.Read();
                    if (sdr1.HasRows)
                    {
                        lb_new.Text = sdr1[0].ToString();
                        lb_debt.Text = sdr1[1].ToString();

                        if (lb_debt.Text.Equals("否"))
                        {
                            lb_advice.Text = "同意订单";
                        }
                        else
                        {
                            lb_advice.Text = "拒绝订单";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请输入顾客名称");
                }

                listBox1.Items.Add(string.Format("{0}\t\t\t{1}\t\t{2}", "产品名", "库  存", "是否超出"));
                listBox1.Items.Add(string.Format("\t\t"));

                //查询订单产品名，数量
                string sql3 = string.Format("select distinct PdName,OrderNum from tb_Order where CeName='{0}'", txt_name.Text);
                SqlDataReader sdr3 = sh.getByReader(sql3);

                if (sdr3.HasRows)
                {
                    while (sdr3.Read())
                    {
                        //查询对应产品库存量
                        string sql4 = string.Format("select SLeft from tb_Storage where PdName='{0}'", sdr3[0].ToString());
                        SqlDataReader sdr4 = sh.getByReader(sql4);

                        while (sdr4.Read())
                        {
                            string str = "";
                            int order = Convert.ToInt32(sdr3[1]);
                            double plan = Convert.ToInt32(sdr4[0]) * 1.3;       //生产计划

                            if (plan >= order)
                            {
                                str = "否";
                            }
                            else
                            {
                                str = "是";
                            }
                            listBox1.Items.Add(string.Format("{0}\t\t{1}\t\t{2}", sdr3[0].ToString(), sdr4[0].ToString(), str));
                            listBox1.Items.Add(string.Format("\t\t"));
                        }
                    }
                }
            }
        }

        private void bt_amend_Click(object sender, EventArgs e)
        {
            sh.CreateConnection();
            string sql1 = string.Format("update tb_Order set OrderStatu='{0}',OCheckman='{1}' where Id='{2}'", cmb_status.Text,Data.username, txt_id.Text);
            int i = sh.getByNonQuery(sql1);
            if (i > 0)
            {
                MessageBox.Show("修改成功");

                //修改库存
                if (cmb_status.Text.Equals("合格订单"))
                {
                    //查询产品名和采购数量
                    string sql2 = string.Format("select PdName,OrderNum from tb_Order where ID='{0}'", txt_id.Text);
                    SqlDataReader sdr2 = sh.getByReader(sql2);
                    sdr2.Read();

                    //查询对应产品库存数
                    string sql3 = string.Format("select SLeft from tb_Storage where PdName='{0}'", sdr2[0].ToString());
                    SqlDataReader sdr3 = sh.getByReader(sql3);
                    sdr3.Read();

                    //修改对应库存：库存－采购
                    int left;
                    left = Convert.ToInt32(sdr3[0].ToString()) - Convert.ToInt32(sdr2[1].ToString());
                    string sql4 = string.Format("update tb_Storage set SLeft='{0}' where PdName='{1}'", left, sdr2[0].ToString());
                    sh.getByNonQuery(sql4);
                }

                cmb_status.Text = txt_id.Text = "";
                ShowData();
            }
        }

        private void bt_quit_Click(object sender, EventArgs e)
        {
            Main_Em me = new Main_Em();
            Data.ID = 0;
            me.Show();
            this.Close();
        }
        
    }
}
