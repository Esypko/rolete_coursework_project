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
    public partial class Form3 : Form
    {

        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();
        int count = 0;
        public Form3(string str, int c)
        {
            InitializeComponent();
            textBox1.Text = str;
            string path = Environment.CurrentDirectory + "\\warehouse.accdb";
            this.cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + path + "';Persist Security Info=True";
            cmd = cn.CreateCommand();
            count = c;
        }      

        public Form3()
        {
            InitializeComponent();     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    cn.Open();
                    cmd.CommandText = "insert into Clients (_Name, _Telephone, _Addres) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                cn.Open();
                cmd.CommandText = "insert into Orders (_Name, _Count, _Price, _Telephon_Number, _Addres, _Date) values ('" + textBox1.Text + "'," + count + ", " + 4 * count + ",'" + textBox3.Text + "','" + textBox2.Text + "','" + DateTime.UtcNow.ToString() + "')";
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
