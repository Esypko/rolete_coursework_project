using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace rolete
{
    public partial class Form2 : Form
    {
        //obj to work with database
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbConnection cn = new OleDbConnection();
        private OleDbDataReader dr;
        private DataTable dt;

        // table to fill
        private DataGridView dataGridView1 = new DataGridView();

        // caption
        private Label _id = new Label();
        private Label _name = new Label();
        private Label _metr_count = new Label();
        private Label _colot_length = new Label();
        private Label _price = new Label();

        //Last selected index
        private int lastSelectedIndex = 0;
        // Set animated speed
        private int AnimatedSpeed = 1;
        //------------------------------
        private int lastLocationY = 0;
        private int lastLocationX = 0;
        public Form2()
        {
            try
            {
                InitializeComponent();
                this.BackColor = Color.FromArgb(30, 30, 30);
                menuStrip1.ForeColor = Color.White;
                menuStrip1.Renderer = new ToolStripProfessionalRenderer(new CustomProfessionalColors());
                //-------------------------------------------------------------------------------------------
                this.comboBox1.Items.Add("Перья");
                this.comboBox1.Items.Add("Механизмы");
                this.comboBox1.Items.Add("Материалы");
                this.comboBox1.Items.Add("Профиля");
               
                this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                //-------------------------------------------------------------------------------------------
                this.dataGridView1.Location = new Point(this.label1.Location.X, this.label1.Location.Y + 50);
                this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;                 
                this.dataGridView1.Visible = false;
                //-------------------------------------------------------------------------------------------
                //add new item to controls
                this.Controls.Add(this.dataGridView1);
                this.Controls.Add(_id);
                this.Controls.Add(_name);
                this.Controls.Add(_metr_count);
                this.Controls.Add(_colot_length);
                this.Controls.Add(_price);
                //-------------------------------------Dissemble form border style---------------------------
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                //-------------------------------------------------------------------------------------------
                //---------------------set labels location---------------------------------------------------
                _id.Location            = new Point(id.Location.X + id.Width + 20, id.Location.Y + id.Height/6);
                _name.Location          = new Point(name.Location.X + name.Width + 20, name.Location.Y + name.Height/6);
                _metr_count.Location    = new Point(metr_count.Location.X + metr_count.Width + 20, metr_count.Location.Y + metr_count.Height/6);
                _colot_length.Location  = new Point(color_length.Location.X + color_length.Width + 20, color_length.Location.Y + color_length.Height/6);
                _price.Location         = new Point(price.Location.X + price.Width + 20, price.Location.Y + price.Height/6);
                //-------------------------------------------------------------------------------------------
                //-------------------------set labels name---------------------------------------------------
                _id.Text            = "ID";
                _name.Text          = "Feathers";
                _metr_count.Text    = "Meters";
                _colot_length.Text  = "Color";
                _price.Text         = "Price";
                //-------------------------------------------------------------------------------------------
                //------------------------------------Set labels color---------------------------------------
                _id.ForeColor = _name.ForeColor = _metr_count.ForeColor = _colot_length.ForeColor = _price.ForeColor = Color.WhiteSmoke;
                //-------------------------------------------------------------------------------------------
                //------------------------------------Set visible to lables----------------------------------
                _id.Visible             = true;
                _name.Visible           = true;
                _metr_count.Visible     = true;
                _colot_length.Visible   = true;
                _price.Visible          = true;
                //-------------------------------------------------------------------------------------------
            }
            catch (Exception ex) {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // //-------------------------------------Set connection string------------------------------------------------------
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                this.cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\оо\Documents\GitHub\rolete_coursework_project\rolete\warehouse.accdb;Persist Security Info=True";
                this.cmd.Connection = cn;
                this.comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex){
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           

        }
        //-------------------------------------------------------------------------------------------
        // load data with sql command
        private void loaddata(string command) {
            cmd.CommandText = null;
            cmd.CommandText = command;
            cn.Open();            
        }
        //-------------------------------------------------------------------------------------------
        // add data to DataReader
        private void DataReader() {
            try
            {
                this.dt = new DataTable();
                this.dr = this.cmd.ExecuteReader();
                dt.Clear();
                dt.Load(dr);              
                this.dataGridView1.DataSource = dt;                                
                dr.Close();
                cn.Close();
            }

            // if somthing wrong then close connection and show error
            catch (Exception ex) {
                this.cn.Close();
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-------------------------------------------------------------------------------------------
        // clear datagridview 
        private void ClearData() {
            try
            {
                this.dt = new DataTable();
                this.dt.Clear();
                if (this.dataGridView1.DataSource != null)
                    this.dataGridView1.DataSource = dt;
                this.dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-------------------------------------------------------------------------------------------
        // resize datagridview depens of data
        private void ResizeData() {
            this.dataGridView1.Width = this.dataGridView1.ColumnCount * this.dataGridView1.Columns[2].Width;
            if (dataGridView1.Height > 400)
                this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            else
                this.dataGridView1.Height = this.dataGridView1.RowCount * this.dataGridView1.Rows[0].Height;
        }
        //-------------------------------------------------------------------------------------------
        // close form2
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-------------------------------------------------------------------------------------------
        // show load data on datagridview (depend of selected index)
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.Visible = true;
                // view feathers
                if (this.comboBox1.SelectedIndex == 0)
                {                                        
                    loaddata("select * from Feathers");
                    ClearData();
                    DataReader();
                    ResizeData();
                    ChangeControlsPosition(comboBox1.SelectedIndex);
                    lastSelectedIndex = comboBox1.SelectedIndex;
                }
                // view mechanism
                if (this.comboBox1.SelectedIndex == 1) {                   
                    loaddata("select * from Mechanism");
                    ClearData();
                    DataReader();
                    ResizeData();
                    ChangeControlsPosition(comboBox1.SelectedIndex);
                    lastSelectedIndex = comboBox1.SelectedIndex;
                }
                // view materials
                if (this.comboBox1.SelectedIndex == 2) {                   
                    loaddata("select * from Expendable_Materials");
                    ClearData();
                    DataReader();
                    ResizeData();
                    ChangeControlsPosition(comboBox1.SelectedIndex);
                    lastSelectedIndex = comboBox1.SelectedIndex;
                }
                // view shape
                if (this.comboBox1.SelectedIndex == 3)
                {                    
                    loaddata("select * from Shape");
                    ClearData();
                    DataReader();
                    ResizeData();
                    ChangeControlsPosition(comboBox1.SelectedIndex);
                    lastSelectedIndex = comboBox1.SelectedIndex;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error\n" + ex.Message,"Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-------------------------------------------------------------------------------------------
        // add data to selected table
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //add data to Feathers
                if (this.comboBox1.SelectedIndex == 0)
                {
                    if (this.id.Text != "" && this.name.Text != "" && this.metr_count.Text != "" && this.color_length.Text != "" && price.Text != "")
                    {
                        string q = "insert into Feathers (_ID, _Name, _Meters, _Color, _Price) values (" + id.Text + ",'" + name.Text + "'," + metr_count.Text + "'," + color_length.Text + ", "+price.Text+")";
                        AddData(q);
                    }
                }
                //add data to mechanism
                if (this.comboBox1.SelectedIndex == 1) {
                    if (id.Text != "" && name.Text != "" && metr_count.Text != "" && color_length.Text != "" && price.Text != "") {
                        string q = "insert into Mechanism (_ID, _Name, _Count, _Length, _Price) values ("+id.Text+",'"+name.Text+"',"+metr_count.Text+", "+color_length.Text+","+price.Text+")";
                        AddData(q);
                    }
                }
                //add data to material
                if (this.comboBox1.SelectedIndex == 2) {
                    if (id.Text != "" && name.Text != "" && metr_count.Text != "" && price.Text != "") {
                        string q = "insert into Expendable_Materials (_ID, _Name, _Count, _Price) values ("+id.Text+",'"+name.Text+"',"+metr_count.Text+","+price.Text+")";
                        AddData(q);
                    }
                }
                //add data to shape
                if (this.comboBox1.SelectedIndex == 3) {
                    if (id.Text != "" && name.Text != "" && metr_count.Text != "" && color_length.Text != "" && price.Text != "") {
                        string q = "insert into Shape (_ID, _Name, _Meters, _Color, _Price) values (" + id.Text + ",'" + name.Text + "'," + metr_count.Text + "'," + color_length.Text + ", " + price.Text + ")";
                        AddData(q);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-------------------------------------------------------------------------------------------
        // sql add
        private void AddData(string q) {
            this.cn.Open();
            cmd.CommandText = q;
            cmd.ExecuteNonQuery();
            DataReader();
            cn.Close();
            
        }
        //--------------------------Timer------------------------------------------------------------
        private void _Timer() {
            Timer t = new Timer();
            t.Interval = 10;
            t.Start();
            t.Stop();
            t.Dispose();
        }
        //-------------------------------------------------------------------------------------------
        //---------------------Change controls position depend on combo box selected index-----------
        private void ChangeControlsPosition(int SelectedIndex) {
            switch (SelectedIndex) {
                case 0: FeatersSelected();              break;
                case 1: MechanismSelected();            break;
                case 2: ExpendableMaterialsSelected();  break;
                case 3: ShapeSelected();                break;
            }
        }
        //-------------------------------------------------------------------------------------------
        //----------------------------------Function which chenge controls position------------------
        //-------------------------------------------------------------------------------------------

        //-------------------------------------Feathers selected-------------------------------------
        private void FeatersSelected() {
            if (lastSelectedIndex == 0) { 
                // nothing to do
            }
            else if (lastSelectedIndex == 1) { //lastSelectedItem == Mechanism
                int startLocationX = _metr_count.Location.X;

                while (_metr_count.Location.X < this.Width)
                {
                    _metr_count.Location = new Point(_metr_count.Location.X + AnimatedSpeed, _metr_count.Location.Y);
                    _Timer();
                }
                _metr_count.Text = "Meters";
                while (_metr_count.Location.X != startLocationX)
                {
                    _metr_count.Location = new Point(_metr_count.Location.X - AnimatedSpeed, _metr_count.Location.Y);
                    _Timer();
                }

                startLocationX = _colot_length.Location.X;
                while (_colot_length.Location.X < this.Width)
                {
                    _colot_length.Location = new Point(_colot_length.Location.X + AnimatedSpeed, _colot_length.Location.Y);
                    _Timer();
                }
                _colot_length.Text = "Color";
                while (_colot_length.Location.X != startLocationX)
                {
                    _colot_length.Location = new Point(_colot_length.Location.X - AnimatedSpeed, _colot_length.Location.Y);
                    _Timer();
                }
            }
            else if (lastSelectedIndex == 2) { //lastSelectedItem == Expendable_Materials
                lastLocationX = _name.Location.X;

                while (_name.Location.X < this.Width)
                {
                    _name.Location = new Point(_name.Location.X + AnimatedSpeed, _name.Location.Y);
                    _Timer();
                }

                _name.Text = "Feathers";

                while (_name.Location.X != lastLocationX)
                {
                    _name.Location = new Point(_name.Location.X - AnimatedSpeed, _name.Location.Y);
                    _Timer();
                }

                lastLocationX = _metr_count.Location.X;

                while (_metr_count.Location.X < this.Width) {
                    _metr_count.Location = new Point(_metr_count.Location.X + AnimatedSpeed, _metr_count.Location.Y);
                    _Timer();
                }

                _metr_count.Text = "Meters";

                while (_metr_count.Location.X != lastLocationX) {
                    _metr_count.Location = new Point(_metr_count.Location.X - AnimatedSpeed, _metr_count.Location.Y);
                    _Timer();
                }

                lastLocationX = _colot_length.Location.X;

                while (_colot_length.Location.X < this.Width) {
                    _colot_length.Location = new Point(_colot_length.Location.X + AnimatedSpeed, _colot_length.Location.Y);
                    _Timer();
                }

                _colot_length.Text = "Color";

                while (_colot_length.Location.X != lastLocationX)
                {
                    _colot_length.Location = new Point(_colot_length.Location.X - AnimatedSpeed, _colot_length.Location.Y);
                    _Timer();
                }

                while (price.Location.X != id.Location.X)
                {
                    _price.Location = new Point(_price.Location.X - AnimatedSpeed, _price.Location.Y);
                    price.Location = new Point(price.Location.X - AnimatedSpeed, price.Location.Y);
                    _Timer();
                }
            }
            else if (lastSelectedIndex == 3) {
                lastLocationX = _name.Location.X;

                while (_name.Location.X < this.Width) {
                    _name.Location = new Point(_name.Location.X + AnimatedSpeed, _name.Location.Y);
                    _Timer();
                }

                _name.Text = "Feathers";

                while (_name.Location.X != lastLocationX) {
                    _name.Location = new Point(_name.Location.X - AnimatedSpeed, _name.Location.Y);
                    _Timer();
                }
            }
        }
        //-------------------------------------------------------------------------------------------
        //--------------------------------------Mechanism selected-----------------------------------
        private void MechanismSelected() {
            if (lastSelectedIndex == 0)
            {
                int startLocationX = _metr_count.Location.X;

                while (_metr_count.Location.X <= this.Width) {
                    _metr_count.Location = new Point(_metr_count.Location.X + AnimatedSpeed, _metr_count.Location.Y);
                    _Timer();
                }
                _metr_count.Text = "Count";
                while (_metr_count.Location.X != startLocationX) {
                    _metr_count.Location = new Point(_metr_count.Location.X - AnimatedSpeed, _metr_count.Location.Y);
                    _Timer();
                }

                startLocationX = _colot_length.Location.X;
                while (_colot_length.Location.X < this.Width) {
                    _colot_length.Location = new Point(_colot_length.Location.X + AnimatedSpeed, _colot_length.Location.Y);
                    _Timer();
                }
                _colot_length.Text = "Length";
                while (_colot_length.Location.X != startLocationX) {
                    _colot_length.Location = new Point(_colot_length.Location.X - AnimatedSpeed, _colot_length.Location.Y);
                    _Timer();
                }
            }
            else if (lastSelectedIndex == 1)
            {
                // nothing to do
            }
            else if (lastSelectedIndex == 2)
            {
                lastLocationX = _name.Location.X;

                while (_name.Location.X < this.Width) {
                    _name.Location = new Point(_name.Location.X + AnimatedSpeed, _name.Location.Y);
                    _Timer();
                }

                _name.Text = "Mechanism";

                while (_name.Location.X != lastLocationX) {
                    _name.Location = new Point(_name.Location.X - AnimatedSpeed, _name.Location.Y);
                    _Timer();
                }

                lastLocationX = _colot_length.Location.X;

                while (_colot_length.Location.X < this.Width) {
                    _colot_length.Location = new Point(_colot_length.Location.X + AnimatedSpeed, _colot_length.Location.Y);
                    _Timer();
                }

                _colot_length.Text = "Length";

                while (_colot_length.Location.X != lastLocationX)
                {
                    _colot_length.Location = new Point(_colot_length.Location.X - AnimatedSpeed, _colot_length.Location.Y);
                    _Timer();
                }

                while (price.Location.X != id.Location.X) {
                    _price.Location = new Point(_price.Location.X - AnimatedSpeed, _price.Location.Y);
                    price.Location = new Point(price.Location.X - AnimatedSpeed, price.Location.Y);
                    _Timer();
                }
            }
            else if (lastSelectedIndex == 3)
            {
                lastLocationX = _name.Location.X;

                while (_name.Location.X < this.Width)
                {
                    _name.Location = new Point(_name.Location.X + AnimatedSpeed, _name.Location.Y);
                    _Timer();
                }

                _name.Text = "Mechanism";

                while (_name.Location.X != lastLocationX)
                {
                    _name.Location = new Point(_name.Location.X - AnimatedSpeed, _name.Location.Y);
                    _Timer();
                }

                lastLocationX = _metr_count.Location.X;

                while (_metr_count.Location.X < this.Width)
                {
                    _metr_count.Location = new Point(_metr_count.Location.X + AnimatedSpeed, _metr_count.Location.Y);
                    _Timer();
                }

                _metr_count.Text = "Count";

                while (_metr_count.Location.X != lastLocationX)
                {
                    _metr_count.Location = new Point(_metr_count.Location.X - AnimatedSpeed, _metr_count.Location.Y);
                    _Timer();
                }

                lastLocationX = _colot_length.Location.X;

                while (_colot_length.Location.X < this.Width)
                {
                    _colot_length.Location = new Point(_colot_length.Location.X + AnimatedSpeed, _colot_length.Location.Y);
                    _Timer();
                }

                _colot_length.Text = "Length";

                while (_colot_length.Location.X != lastLocationX)
                {
                    _colot_length.Location = new Point(_colot_length.Location.X - AnimatedSpeed, _colot_length.Location.Y);
                    _Timer();
                }

            }
        }
        //-------------------------------------------------------------------------------------------
        //-----------------------------------Expendable Materials selected---------------------------
        private void ExpendableMaterialsSelected() {
            if (lastSelectedIndex == 0)
            {
                int startLocationX = _name.Location.X;

                 while (_name.Location.X < this.Width) {
                    _name.Location = new Point(_name.Location.X + AnimatedSpeed, _name.Location.Y);
                    _Timer();
                }

                _name.Text = "Materials";

                while (_name.Location.X != startLocationX) {
                    _name.Location = new Point(_name.Location.X - AnimatedSpeed, _name.Location.Y);
                    _Timer();
                }

                startLocationX = _metr_count.Location.X;

                 while (_metr_count.Location.X < this.Width) {
                    _metr_count.Location = new Point(_metr_count.Location.X + AnimatedSpeed, _metr_count.Location.Y);
                    _Timer();
                }

                _metr_count.Text = "Count";

                while (_metr_count.Location.X != startLocationX) {
                    _metr_count.Location = new Point(_metr_count.Location.X - AnimatedSpeed, _metr_count.Location.Y);
                    _Timer();
                }               

                startLocationX = _colot_length.Location.X;

                while (_colot_length.Location.X < this.Width) {
                    _colot_length.Location = new Point(_colot_length.Location.X + AnimatedSpeed, _colot_length.Location.Y);
                    _Timer();
                }

                _colot_length.Text = "Price";

                while (_colot_length.Location.X != startLocationX)
                {
                    _colot_length.Location = new Point(_colot_length.Location.X - AnimatedSpeed, _colot_length.Location.Y);
                    _Timer();
                }
                while (price.Location.X  < this.Width) {
                    _price.Location = new Point(_price.Location.X + AnimatedSpeed, _price.Location.Y);
                    price.Location = new Point(price.Location.X + AnimatedSpeed, price.Location.Y);
                    _Timer();
                }
               
            }
            else if (lastSelectedIndex == 1)
            {
                int startLocationX = _name.Location.X;

                while (_name.Location.X < this.Width)
                {
                    _name.Location = new Point(_name.Location.X + AnimatedSpeed, _name.Location.Y);
                    _Timer();
                }

                _name.Text = "Materials";

                while (_name.Location.X != startLocationX)
                {
                    _name.Location = new Point(_name.Location.X - AnimatedSpeed, _name.Location.Y);
                    _Timer();
                }

                startLocationX = _metr_count.Location.X;

                while (_metr_count.Location.X < this.Width)
                {
                    _metr_count.Location = new Point(_metr_count.Location.X + AnimatedSpeed, _metr_count.Location.Y);
                    _Timer();
                }

                _metr_count.Text = "Count";

                while (_metr_count.Location.X != startLocationX)
                {
                    _metr_count.Location = new Point(_metr_count.Location.X - AnimatedSpeed, _metr_count.Location.Y);
                    _Timer();
                }

                startLocationX = _colot_length.Location.X;

                while (_colot_length.Location.X < this.Width)
                {
                    _colot_length.Location = new Point(_colot_length.Location.X + AnimatedSpeed, _colot_length.Location.Y);
                    _Timer();
                }

                _colot_length.Text = "Price";

                while (_colot_length.Location.X != startLocationX)
                {
                    _colot_length.Location = new Point(_colot_length.Location.X - AnimatedSpeed, _colot_length.Location.Y);
                    _Timer();
                }
                while (price.Location.X < this.Width)
                {
                    _price.Location = new Point(_price.Location.X + AnimatedSpeed, _price.Location.Y);
                    price.Location = new Point(price.Location.X + AnimatedSpeed, price.Location.Y);
                    _Timer();
                }
            }
            else if (lastSelectedIndex == 2)
            {
                //nothing to do
            }
            else if (lastSelectedIndex == 3)
            {
                int startLocationX = _name.Location.X;

                while (_name.Location.X < this.Width)
                {
                    _name.Location = new Point(_name.Location.X + AnimatedSpeed, _name.Location.Y);
                    _Timer();
                }

                _name.Text = "Materials";

                while (_name.Location.X != startLocationX)
                {
                    _name.Location = new Point(_name.Location.X - AnimatedSpeed, _name.Location.Y);
                    _Timer();
                }

                startLocationX = _metr_count.Location.X;

                while (_metr_count.Location.X < this.Width)
                {
                    _metr_count.Location = new Point(_metr_count.Location.X + AnimatedSpeed, _metr_count.Location.Y);
                    _Timer();
                }

                _metr_count.Text = "Count";

                while (_metr_count.Location.X != startLocationX)
                {
                    _metr_count.Location = new Point(_metr_count.Location.X - AnimatedSpeed, _metr_count.Location.Y);
                    _Timer();
                }

                startLocationX = _colot_length.Location.X;

                while (_colot_length.Location.X < this.Width)
                {
                    _colot_length.Location = new Point(_colot_length.Location.X + AnimatedSpeed, _colot_length.Location.Y);
                    _Timer();
                }

                _colot_length.Text = "Price";

                while (_colot_length.Location.X != startLocationX)
                {
                    _colot_length.Location = new Point(_colot_length.Location.X - AnimatedSpeed, _colot_length.Location.Y);
                    _Timer();
                }
                while (price.Location.X < this.Width)
                {
                    _price.Location = new Point(_price.Location.X + AnimatedSpeed, _price.Location.Y);
                    price.Location = new Point(price.Location.X + AnimatedSpeed, price.Location.Y);
                    _Timer();
                }
            }
        }
        //-------------------------------------------------------------------------------------------
        //------------------------------------Shape selected-----------------------------------------
        private void ShapeSelected() {
            if (lastSelectedIndex == 0)
            {
                lastLocationX = _name.Location.X;

                while (_name.Location.X < this.Width)
                {
                    _name.Location = new Point(_name.Location.X + AnimatedSpeed, _name.Location.Y);
                    _Timer();
                }

                _name.Text = "Shape";

                while (_name.Location.X != lastLocationX)
                {
                    _name.Location = new Point(_name.Location.X - AnimatedSpeed, _name.Location.Y);
                    _Timer();
                }
            }
            else if (lastSelectedIndex == 1)
            {
                lastLocationX = _name.Location.X;

                while (_name.Location.X < this.Width)
                {
                    _name.Location = new Point(_name.Location.X + AnimatedSpeed, _name.Location.Y);
                    _Timer();
                }

                _name.Text = "Shape";

                while (_name.Location.X != lastLocationX)
                {
                    _name.Location = new Point(_name.Location.X - AnimatedSpeed, _name.Location.Y);
                    _Timer();
                }

                lastLocationX = _metr_count.Location.X;

                while (_metr_count.Location.X < this.Width)
                {
                    _metr_count.Location = new Point(_metr_count.Location.X + AnimatedSpeed, _metr_count.Location.Y);
                    _Timer();
                }

                _metr_count.Text = "Meters";

                while (_metr_count.Location.X != lastLocationX)
                {
                    _metr_count.Location = new Point(_metr_count.Location.X - AnimatedSpeed, _metr_count.Location.Y);
                    _Timer();
                }

                lastLocationX = _colot_length.Location.X;

                while (_colot_length.Location.X < this.Width)
                {
                    _colot_length.Location = new Point(_colot_length.Location.X + AnimatedSpeed, _colot_length.Location.Y);
                    _Timer();
                }

                _colot_length.Text = "Color";

                while (_colot_length.Location.X != lastLocationX)
                {
                    _colot_length.Location = new Point(_colot_length.Location.X - AnimatedSpeed, _colot_length.Location.Y);
                    _Timer();
                }
            }
            else if (lastSelectedIndex == 2)
            {
                lastLocationX = _name.Location.X;

                while (_name.Location.X < this.Width)
                {
                    _name.Location = new Point(_name.Location.X + AnimatedSpeed, _name.Location.Y);
                    _Timer();
                }

                _name.Text = "Shape";

                while (_name.Location.X != lastLocationX)
                {
                    _name.Location = new Point(_name.Location.X - AnimatedSpeed, _name.Location.Y);
                    _Timer();
                }

                lastLocationX = _metr_count.Location.X;

                while (_metr_count.Location.X < this.Width)
                {
                    _metr_count.Location = new Point(_metr_count.Location.X + AnimatedSpeed, _metr_count.Location.Y);
                    _Timer();
                }

                _metr_count.Text = "Meters";

                while (_metr_count.Location.X != lastLocationX)
                {
                    _metr_count.Location = new Point(_metr_count.Location.X - AnimatedSpeed, _metr_count.Location.Y);
                    _Timer();
                }

                lastLocationX = _colot_length.Location.X;

                while (_colot_length.Location.X < this.Width)
                {
                    _colot_length.Location = new Point(_colot_length.Location.X + AnimatedSpeed, _colot_length.Location.Y);
                    _Timer();
                }

                _colot_length.Text = "Color";

                while (_colot_length.Location.X != lastLocationX)
                {
                    _colot_length.Location = new Point(_colot_length.Location.X - AnimatedSpeed, _colot_length.Location.Y);
                    _Timer();
                }

                while (price.Location.X != id.Location.X)
                {
                    _price.Location = new Point(_price.Location.X - AnimatedSpeed, _price.Location.Y);
                    price.Location = new Point(price.Location.X - AnimatedSpeed, price.Location.Y);
                    _Timer();
                }
            }
            else if (lastSelectedIndex == 3)
            {
                //nothing to do
            }
        }
    }
}
