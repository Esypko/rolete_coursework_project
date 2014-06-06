using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rolete
{
    public partial class Form3 : Form
    {
        
        public string[] arr = new string[2];

        public Form3()
        {
            InitializeComponent();


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(arr[0]=="")
            {
                label1.Text = "Address";
                arr[0] = textBox1.Text;
                
            }
            if (arr[0] != "" && arr[1] == "")
                {
                    label1.Text = "Telephone";
                    arr[1] = textBox1.Text;
                this.Hide();
                }
            
        }
    }
}
