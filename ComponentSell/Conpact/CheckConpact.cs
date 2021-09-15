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
    public partial class CheckConpact : Form
    {
        public CheckConpact()
        {
            InitializeComponent();
        }

        SqlHelper sh = new SqlHelper();

        private void CheckConpact_Load(object sender, EventArgs e)
        {
            //显示信息到ListBox
            string sql = string.Format("select CClient,CList,CPrice,COTime,CGTime,CStatus,CPay,CSellMan,CCheck from tb_Conpact where CClient='{0}'", Data.choose);
            SqlDataReader sdr = sh.getByReader(sql);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    listBox1.Items.Add(string.Format("\t\t"));
                    listBox1.Items.Add(string.Format("\t\t\t\t合同信息表"));
                    listBox1.Items.Add(string.Format("\t\t"));
                    listBox1.Items.Add(string.Format("\t\t"));
                    listBox1.Items.Add(string.Format("\t{0}\t{1}", "顾    客：", sdr[0].ToString()));
                    listBox1.Items.Add(string.Format("\t\t"));
                    listBox1.Items.Add(string.Format("\t{0}\t{1}", "所购产品：", sdr[1].ToString()));
                    listBox1.Items.Add(string.Format("\t\t"));
                    listBox1.Items.Add(string.Format("\t{0}\t{1}", "总    价：", sdr[2].ToString()));
                    listBox1.Items.Add(string.Format("\t\t"));
                    listBox1.Items.Add(string.Format("\t{0}\t{1}", "购买日期：", sdr[3].ToString()));
                    listBox1.Items.Add(string.Format("\t\t"));
                    listBox1.Items.Add(string.Format("\t{0}\t{1}", "交付时间：", sdr[4].ToString()));
                    listBox1.Items.Add(string.Format("\t\t"));
                    listBox1.Items.Add(string.Format("\t{0}\t{1}", "合同状态：", sdr[5].ToString()));
                    listBox1.Items.Add(string.Format("\t\t"));
                    listBox1.Items.Add(string.Format("\t{0}\t{1}", "支付情况：", sdr[6].ToString()));
                    listBox1.Items.Add(string.Format("\t\t"));
                    listBox1.Items.Add(string.Format("\t{0}\t{1}", "销 售 员：", sdr[7].ToString()));
                    listBox1.Items.Add(string.Format("\t\t"));
                    listBox1.Items.Add(string.Format("\t{0}\t{1}", "审 批 员：", sdr[8].ToString()));
                    listBox1.Items.Add(string.Format("\t\t"));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main_Em me = new Main_Em();
            me.Show();
            this.Hide();
        }
    }
}
