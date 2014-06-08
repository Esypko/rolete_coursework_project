using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace rolete
{
    public partial class Form4 : Form
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();
        OleDbDataReader dr;
        public Form4()
        {
            InitializeComponent();
            string path = Environment.CurrentDirectory + "\\warehouse.accdb";
            this.cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + path + "';Persist Security Info=True";
            cmd = cn.CreateCommand();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd.CommandText = "select * from Orders";
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
