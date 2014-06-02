namespace rolete
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add1 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.metr_count = new System.Windows.Forms.TextBox();
            this.color_length = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.Del = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Sing = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SqlQuery = new System.Windows.Forms.TextBox();
            this.Execute = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Остаток";
            // 
            // Add1
            // 
            this.Add1.Location = new System.Drawing.Point(550, 259);
            this.Add1.Name = "Add1";
            this.Add1.Size = new System.Drawing.Size(51, 23);
            this.Add1.TabIndex = 3;
            this.Add1.Text = "Add";
            this.Add1.UseVisualStyleBackColor = true;
            this.Add1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(550, 82);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 4;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(550, 117);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 5;
            // 
            // metr_count
            // 
            this.metr_count.Location = new System.Drawing.Point(550, 152);
            this.metr_count.Name = "metr_count";
            this.metr_count.Size = new System.Drawing.Size(100, 20);
            this.metr_count.TabIndex = 6;
            // 
            // color_length
            // 
            this.color_length.Location = new System.Drawing.Point(550, 188);
            this.color_length.Name = "color_length";
            this.color_length.Size = new System.Drawing.Size(100, 20);
            this.color_length.TabIndex = 7;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(550, 223);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 20);
            this.price.TabIndex = 8;
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(599, 259);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(51, 23);
            this.Del.TabIndex = 9;
            this.Del.Text = "Del";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(550, 288);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(100, 23);
            this.Update.TabIndex = 10;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(238, 27);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 20);
            this.Login.TabIndex = 11;
            this.Login.Text = "Login";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(357, 27);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 12;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // Sing
            // 
            this.Sing.Location = new System.Drawing.Point(473, 25);
            this.Sing.Name = "Sing";
            this.Sing.Size = new System.Drawing.Size(55, 23);
            this.Sing.TabIndex = 13;
            this.Sing.Text = "Sing In";
            this.Sing.UseVisualStyleBackColor = true;
            this.Sing.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(534, 25);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(53, 23);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SqlQuery
            // 
            this.SqlQuery.Location = new System.Drawing.Point(238, 54);
            this.SqlQuery.Multiline = true;
            this.SqlQuery.Name = "SqlQuery";
            this.SqlQuery.Size = new System.Drawing.Size(219, 20);
            this.SqlQuery.TabIndex = 15;
            this.SqlQuery.Text = "You own sql query";
            this.SqlQuery.Click += new System.EventHandler(this.SqlQuery_Click);
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(473, 52);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(55, 23);
            this.Execute.TabIndex = 16;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 407);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.SqlQuery);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Sing);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.price);
            this.Controls.Add(this.color_length);
            this.Controls.Add(this.metr_count);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.Add1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;         
        private System.Windows.Forms.Button Add1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox metr_count;
        private System.Windows.Forms.TextBox color_length;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Sing;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox SqlQuery;
        private System.Windows.Forms.Button Execute;
 
    }
}