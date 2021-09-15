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
    public partial class DataRecovery : Form
    {
        public DataRecovery()
        {
            InitializeComponent();
        }

        SqlHelper sh = new SqlHelper();

        private void bt_choose_Click(object sender, EventArgs e)
        {
            textBox1.Text = sh.ShowFile();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            string filePath="";
            filePath = textBox1.Text;
            if (filePath.Equals(""))
            {
                MessageBox.Show("请先选择文件！");
            }
            else
            {
                try
                {
                    String sql = string.Format("use master restore database test from disk='{0}'", textBox1.Text.Trim());
                    int i = sh.getByNonQuery(sql);
                    if (i > 0)
                    {
                        MessageBox.Show("恢复成功");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bt_quit_Click(object sender, EventArgs e)
        {
            Main_Em me = new Main_Em();
            me.Show();
            this.Hide();
        }
    }
}
