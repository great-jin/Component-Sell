using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ComponentSell
{
    class SqlHelper
    {
        public string strcon = "data source=GREAT;initial catalog=XSXT;integrated security=true";

        SqlConnection con;
        SqlDataAdapter sda;
        DataSet ds;
        DataTable dt;
        SqlCommand cmd;
        SqlDataReader sdr;

        public SqlConnection CreateConnection()
        {
            con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public DataTable getDataByTable(string sql)
        {
            CreateConnection();
            cmd = new SqlCommand(sql, con);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            CloseConnection();
            return dt;
        }

        public DataSet getDataBySet(string sql)
        {
            CreateConnection();
            cmd = new SqlCommand(sql, con);
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public int getByScalar(string sql)
        {
            CreateConnection();
            cmd = new SqlCommand(sql, con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            return i;
        }

        public int getByScalar(string sql, SqlParameter[] sp)
        {
            CreateConnection();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddRange(sp);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            return i;
        }

        public int getByNonQuery(string sql)
        {
            CreateConnection();
            cmd = new SqlCommand(sql, con);
            int i = Convert.ToInt32(cmd.ExecuteNonQuery());
            CloseConnection();
            return i;
        }

        public SqlDataReader getByReader(string sql)
        {
            CreateConnection();
            cmd = new SqlCommand(sql, con);
            sdr = cmd.ExecuteReader();
            return sdr;
        }

        public string ShowFile()
        {
            string path = " ";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "所有文件(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
            }
            return path;
        }
    }
}
