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
    public partial class AlterPower : Form
    {
        public AlterPower()
        {
            InitializeComponent();
        }

        SqlHelper sh = new SqlHelper();
        SqlDataReader sdr = null;

        private void bt_quit_Click(object sender, EventArgs e)
        {
            Main_Em me = new Main_Em();
            me.Show();
            this.Hide();
        }

        private void AlterPower_Load(object sender, EventArgs e)
        {
            sh.CreateConnection();
            string sql = "select * from tb_User";
            sdr = sh.getByReader(sql);
            while (sdr.Read())
            {
                string status = sdr["UserName"].ToString();
                cmb_man.Items.Add(sdr["UserName"].ToString());
            }
            cmb_man.SelectedIndex = 0;
            cmb_power.SelectedIndex = 0;
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            int power = 0;
            string powerStr = "";
            powerStr = cmb_power.Text;
            switch (powerStr.Trim())
            {
                case "客户": power = 2; break;
                case "员工": power = 1; break;
                case "科长": power = 0; break;
            }
            string sql = string.Format("update tb_User set UserPower='{0}' where UserName='{1}'",power,cmb_man.Text);
            int i = sh.getByNonQuery(sql);
            if (i > 0)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }
    }
}
