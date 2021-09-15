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
    public partial class DataBackup : Form
    {
        public DataBackup()
        {
            InitializeComponent();
        }
        SqlHelper sh = new SqlHelper();

        private void bt_quit_Click(object sender, EventArgs e)
        {
            Main_Em me = new Main_Em();
            me.Show();
            this.Hide();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("请输入文件名");
            }
            else
            {
                try
                {
                    string path = Application.StartupPath.ToString();
                    path = path.Substring(0, path.IndexOf("\\"));
                    String sql = @"backup database XSXT to disk ='" + path + "\\" + textBox1.Text + ".bak'";
                    sh.getByNonQuery(sql);
                    MessageBox.Show("备份成功");
                    lb_path.Text = path + "\\" + textBox1.Text + ".bak";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
