using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace rolete
{

    public partial class Form1 : Form
    {
        private bool mouseDown              = false;
        private Point mouseLocation;
        private myGroupBox groupBox1        = new myGroupBox();
        private myGroupBox groupBox2        = new myGroupBox();
        private myGroupBox groupBox3        = new myGroupBox();
        private int startTextBoxLocation    = 0;
        private int maxHeight               = 440;
        private int minHeight               = 220;
        private int AW_HEIGHT               = 1;
        private Form2 form2                 = new Form2();
        public Form1()
        {
            try
            {
                InitializeComponent();

                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

                this.menuStrip1.ForeColor = Color.White;
                this.menuStrip1.Renderer = new ToolStripProfessionalRenderer(new CustomProfessionalColors());
                // Create a groupBox;
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                this.groupBox1.Location = new Point(5, 40);
                this.groupBox1.Height = 50;
                this.groupBox1.Width = this.Width - 10;
                this.groupBox1.Visible = true;
                this.groupBox1.BorderColor = Color.FromArgb(85, 85, 85);
                this.groupBox1.ForeColor = Color.WhiteSmoke;
                this.groupBox1.Text = "Размеры ";
                this.Controls.Add(this.groupBox1);
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                this.groupBox2.Location = new Point(this.label1.Location.X, this.label6.Location.Y + Math.Abs(this.label1.Location.Y - this.label2.Location.Y));
                this.groupBox2.Height = this.groupBox1.Height;
                this.groupBox2.Width = this.groupBox1.Width / 2;
                this.groupBox2.Visible = true;
                this.groupBox2.BorderColor = Color.FromArgb(85, 85, 85);
                this.groupBox2.ForeColor = Color.WhiteSmoke;
                this.groupBox2.Text = "Направляющая ";
                this.Controls.Add(this.groupBox2);
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------
                this.groupBox3.Location = new Point(this.label7.Location.X, this.label7.Location.Y + Math.Abs(this.label1.Location.Y - this.label2.Location.Y));
                this.groupBox3.Height = this.groupBox1.Height;
                this.groupBox3.Width = this.label7.Width + this.comboBox3.Width + (int)this.GetDifferense(this.label7.Location, this.comboBox3.Location);
                this.groupBox3.Visible = true;
                this.groupBox3.BorderColor = Color.FromArgb(85, 85, 85);
                this.groupBox3.ForeColor = Color.WhiteSmoke;
                this.groupBox3.Text = "Для ручного типа управления  ";
                this.Controls.Add(this.groupBox3);
                //------------------------------------------------------------------------------------------------------------------------------------------------------------------

                this.startTextBoxLocation = this.textBox1.Location.X;
            }
            catch(Exception ex) {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double GetDifferense(Point first, Point second) {
            return Math.Sqrt(Math.Pow(first.X - second.X, 2.0) + Math.Pow(second.Y - first.Y, 2.0));
        }
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int xLocation;
                int yLocation;

                xLocation = -e.X - SystemInformation.BorderSize.Width;
                yLocation = -e.Y - SystemInformation.BorderSize.Height;

                this.mouseLocation = new Point(xLocation, yLocation);

                this.mouseDown = true;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseDown) {
                Point location = Control.MousePosition;

                location.Offset(this.mouseLocation.X, this.mouseLocation.Y);
                this.Location = location;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.mouseDown = false;
        }

        private void asdasdToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked) {
                int AnimatedSpeed = 2;
                while ((this.textBox1.Location.X + this.textBox1.Width) > 0) {
                    Timer t = new Timer();
                    t.Interval = 10;
                    t.Start();
                    t.Stop();

                    this.textBox1.Location  = new Point(this.textBox1.Location.X - AnimatedSpeed, this.textBox1.Location.Y);
                    this.textBox2.Location  = new Point(this.textBox2.Location.X - AnimatedSpeed, this.textBox2.Location.Y);
                    this.textBox3.Location  = new Point(this.textBox3.Location.X - AnimatedSpeed, this.textBox3.Location.Y);
                    this.label1.Location    = new Point(this.label1.Location.X - AnimatedSpeed, this.label1.Location.Y);
                    this.label2.Location    = new Point(this.label2.Location.X - AnimatedSpeed, this.label2.Location.Y);
                    this.label3.Location    = new Point(this.label3.Location.X - AnimatedSpeed, this.label3.Location.Y);

                    t.Dispose();
                }

                while (this.Height > this.minHeight) {
                    Timer t = new Timer();
                    t.Interval = 10;
                    t.Start();
                    t.Stop();

                    this.Height -= this.AW_HEIGHT;

                    t.Dispose();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                int AnimatedSpeed = 1;
                while (this.Height < this.maxHeight)
                {
                    Timer t = new Timer();
                    t.Interval = 10;
                    t.Start();
                    t.Stop();

                    this.Height += this.AW_HEIGHT;

                    t.Dispose();
                }
                while (this.textBox1.Location.X != this.startTextBoxLocation)
                {
                    Timer t = new Timer();
                    t.Interval = 10;
                    t.Start();
                    t.Stop();

                    this.textBox1.Location  = new Point(this.textBox1.Location.X + AnimatedSpeed, this.textBox1.Location.Y);
                    this.textBox2.Location  = new Point(this.textBox2.Location.X + AnimatedSpeed, this.textBox2.Location.Y);
                    this.textBox3.Location  = new Point(this.textBox3.Location.X + AnimatedSpeed, this.textBox3.Location.Y);
                    this.label1.Location    = new Point(this.label1.Location.X + AnimatedSpeed, this.label1.Location.Y);
                    this.label2.Location    = new Point(this.label2.Location.X + AnimatedSpeed, this.label2.Location.Y);
                    this.label3.Location    = new Point(this.label3.Location.X + AnimatedSpeed, this.label3.Location.Y);

                    t.Dispose();
                }
                
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void asdasdToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                try
                {
                    this.form2 = new Form2();
                }
                catch (Exception ex) { 
                    //if form2 was created than fine;
                }
                form2.Visible = true;
                form2.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            }
            catch (Exception ex) {
                MessageBox.Show("Error\n"+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
        }

        private void sSSSSSSSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Move(object sender, EventArgs e)
        {
            form2.Location = new Point(this.Location.X + this.Width, this.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    class CustomProfessionalColors : ProfessionalColorTable
    {
        
        public override Color MenuItemBorder
        {
            get
            {
                return Color.FromArgb(85, 85, 85);
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return Color.FromArgb(85, 85, 85);
            }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return Color.FromArgb(85, 85, 85);
            }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return Color.FromArgb(85, 85, 85);
            }
        }
        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return Color.Black;
            }
        }

        public override Color MenuItemPressedGradientMiddle
        {
            get
            {
                return Color.Black;
            }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return Color.Black;
            }
        }
        public override Color MenuStripGradientBegin
        {
            get
            {
                return Color.FromArgb(30,30,30);
            }
        }
        public override Color MenuStripGradientEnd
        {
            get
            {
                return Color.FromArgb(30,30,30);
            }
        }
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return Color.Black;
            }
        }
        public override Color MenuBorder
        {
            get
            {
                return Color.FromArgb(85, 85, 85);
            }
        }
    }
    public class myGroupBox : GroupBox
    {
        private Color borderColor;

        public Color BorderColor
        {
            get { return this.borderColor; }
            set { this.borderColor = value; }
        }

        public myGroupBox()
        {
            this.borderColor = Color.Black;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Size tSize = TextRenderer.MeasureText(this.Text, this.Font);

            Rectangle borderRect = e.ClipRectangle;
            borderRect.Y += tSize.Height / 2;
            borderRect.Height -= tSize.Height / 2;
            ControlPaint.DrawBorder(e.Graphics, borderRect, this.borderColor, ButtonBorderStyle.Solid);

            Rectangle textRect = e.ClipRectangle;
            textRect.X += 6;
            textRect.Width = tSize.Width;
            textRect.Height = tSize.Height;
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), textRect);
            e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), textRect);
        }
    }
}
