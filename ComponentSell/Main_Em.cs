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
    public partial class Main_Em : Form
    {
        public Main_Em()
        {
            InitializeComponent();
        }

        public string name = "";
        public string power = "";
        SqlHelper sh = new SqlHelper();

        private void Main_Em_Load(object sender, EventArgs e)
        {
            power = Data.power;
            switch (power.Trim())
            {
                case "0": t4.Text = "科长"; 
                    break;
                case "1": t4.Text = "员工";
                    tsm2.Enabled = false;
                    tsm3_power.Enabled = false;
                    tsm4.Enabled = false;
                    bt_sign.Enabled = false;
                    break;
            }
            t2.Text = Data.username;
            t6.Text = DateTime.Now.ToLongTimeString();
        }

        private void Main_Em_Activated(object sender, EventArgs e)
        {
            listView1.Clear();
            int day;
            string dateNow = "";
            string sql = "select * from tb_Conpact";
            SqlDataReader sdr = sh.getByReader(sql);
            while (sdr.Read())
            {
                //获取系统时间
                dateNow = System.DateTime.Now.ToString("D");
                day = MySeal.CountDate(dateNow, sdr["CGTime"].ToString());

                string status = sdr["CStatus"].ToString();
                if (status.Trim().Equals("待交付"))
                {
                    if (day < 3)
                    {
                        //感叹号，提醒生产
                        listView1.Items.Add(sdr["CClient"].ToString(), 2);
                        day = 4;
                    }
                    else {
                        //红图，进行中
                        listView1.Items.Add(sdr["CClient"].ToString(), 1);
                    }
                }
                else {
                    //灰图，已结束
                    listView1.Items.Add(sdr["CClient"].ToString(), 0);
                }
            }
        }

        private void cms_check_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                string choose = listView1.SelectedItems[0].Text;
                Data.choose = choose;
                CheckConpact c = new CheckConpact();
                c.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("请选择合同");
            }
        }

        //完成合同
        private void cms_done_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                string choose = listView1.SelectedItems[0].Text;

                string sql2 = string.Format("select CPay from tb_Conpact where CClient='{0}'", choose);
                SqlDataReader sdr2 = sh.getByReader(sql2);
                sdr2.Read();
                if (sdr2[0].ToString().Equals("已付款"))
                {
                    string sql = string.Format("update tb_Conpact set CStatus='已交付' where CClient='{0}'", choose);
                    int i = sh.getByNonQuery(sql);
                    if (i > 0)
                    {
                        MessageBox.Show("完成");
                        Main_Em_Activated(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("顾客未付款，请通知支付款项");
                }
            }
            else
            {
                MessageBox.Show("请选择合同");
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            string status = "";
            string choose = listView1.SelectedItems[0].Text;
            string sql = string.Format("select CStatus from tb_Conpact where CClient='{0}'", choose);
            SqlDataReader sdr = sh.getByReader(sql);
            sdr.Read();
            if (sdr.HasRows)
            {
                status = sdr[0].ToString();
            }
            if (status.Trim() == "已交付")
            {
                cms.Items[1].Enabled = false;
            }
        }

        private void tsm5_calculate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void tsm5_note_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void tsm4_backup_Click(object sender, EventArgs e)
        {
            DataBackup db = new DataBackup();
            db.Show();
            this.Hide();
        }

        private void tsm4_recovery_Click(object sender, EventArgs e)
        {
            DataRecovery db = new DataRecovery();
            db.Show();
            this.Hide();
        }

        private void tsm3_lock_Click(object sender, EventArgs e)
        {
            Lock lk = new Lock();
            lk.Show();
            this.Hide();
        }

        private void tsm3_pwd_Click(object sender, EventArgs e)
        {
            AlterPwd apw = new AlterPwd();
            apw.Show();
            this.Hide();
        }

        private void tsm3_power_Click(object sender, EventArgs e)
        {
            AlterPower apo = new AlterPower();
            apo.Show();
            this.Hide();
        }

        private void ts2_man_Click(object sender, EventArgs e)
        {
            Employee ey = new Employee();
            ey.Show();
            this.Hide();
        }

        private void ts2_client_Click(object sender, EventArgs e)
        {
            Client cl = new Client();
            cl.Show();
            this.Hide();
        }

        private void bt_order_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            od.Show();
            this.Hide();
        }

        private void bt_check_Click(object sender, EventArgs e)
        {
            CheckOrder co = new CheckOrder();
            co.Show();
            this.Hide();
        }

        private void bt_sign_Click(object sender, EventArgs e)
        {
            Conpact cp = new Conpact();
            cp.Show();
            this.Hide();
        }

        private void bt_storage_Click(object sender, EventArgs e)
        {
            Storage st = new Storage();
            st.Show();
            this.Hide();
        }

        private void bt_quit_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
