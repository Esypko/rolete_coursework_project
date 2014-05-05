using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace rolete
{
    public partial class Form2 : Form
    {
        //private SqlConnection con;
        //private SqlDataAdapter adap;
        //private DataSet ds;
        private DataGridView dataGridView1 = new DataGridView();
        public Form2()
        {
            try
            {
                InitializeComponent();
                this.BackColor = Color.FromArgb(30, 30, 30);
                menuStrip1.ForeColor = Color.White;
                menuStrip1.Renderer = new ToolStripProfessionalRenderer(new CustomProfessionalColors());

                this.comboBox1.Items.Add("Перья");
                this.comboBox1.Items.Add("Механизмы");
                this.comboBox1.Items.Add("Моторы");
                this.comboBox1.Items.Add("Профиля");

                this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

                this.dataGridView1.Location = new Point(this.label1.Location.X, this.label1.Location.Y + 50);
                this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;                      
                this.dataGridView1.Visible = false;

                this.Controls.Add(this.dataGridView1);

                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;                
            }
            catch (Exception ex) {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {            
            try
            {
                this.viewFeathersTableAdapter.Fill(this.skladDataSet2.ViewFeathers);
                this.viewMechanismTableAdapter.Fill(this.skladDataSet2.ViewMechanism);
                this.viewMotTableAdapter.Fill(this.skladDataSet2.ViewMot);
                this.viewProfilTableAdapter.Fill(this.skladDataSet2.ViewProfil);
            }
            catch (Exception ex){
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.Visible = true;
                if (this.comboBox1.SelectedIndex == 0)
                {                                       
                    this.dataGridView1.DataSource = this.viewFeathersBindingSource;                    
                    this.dataGridView1.Width = this.dataGridView1.ColumnCount * this.dataGridView1.Columns[0].Width;
                    this.dataGridView1.Height = (this.dataGridView1.RowCount+1) * this.dataGridView1.Rows[0].Height;
                    
                }
                if (this.comboBox1.SelectedIndex == 1) {
                    this.dataGridView1.DataSource = this.viewMechanismBindingSource;                    
                    this.dataGridView1.Width = this.dataGridView1.ColumnCount * this.dataGridView1.Columns[0].Width;
                    this.dataGridView1.Height = (this.dataGridView1.RowCount + 1) * this.dataGridView1.Rows[0].Height;

                    
                }
                if (this.comboBox1.SelectedIndex == 2) {
                    this.dataGridView1.DataSource = this.viewMotBindingSource;                    
                    this.dataGridView1.Width = this.dataGridView1.ColumnCount * this.dataGridView1.Columns[0].Width;
                    this.dataGridView1.Height = (this.dataGridView1.RowCount + 1) * this.dataGridView1.Rows[0].Height;
                    
                }
                if (this.comboBox1.SelectedIndex == 3)
                {
                    this.dataGridView1.DataSource = this.viewProfilBindingSource;                    
                    this.dataGridView1.Width = this.dataGridView1.ColumnCount * this.dataGridView1.Columns[0].Width;
                    this.dataGridView1.Height = (this.dataGridView1.RowCount + 1) * this.dataGridView1.Rows[0].Height;
                    
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error\n" + ex.Message,"Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
