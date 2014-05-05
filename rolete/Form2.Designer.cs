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
            this.components = new System.ComponentModel.Container();
            this.skladDataSet = new rolete.skladDataSet();
            this.viewSkladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewSkladTableAdapter = new rolete.skladDataSetTableAdapters.ViewSkladTableAdapter();
            this.tableAdapterManager = new rolete.skladDataSetTableAdapters.TableAdapterManager();
            this.skladDataSet1 = new rolete.skladDataSet1();
            this.viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewTableAdapter = new rolete.skladDataSet1TableAdapters.ViewTableAdapter();
            this.tableAdapterManager1 = new rolete.skladDataSet1TableAdapters.TableAdapterManager();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.skladDataSet2 = new rolete.skladDataSet2();
            this.viewFeathersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewFeathersTableAdapter = new rolete.skladDataSet2TableAdapters.ViewFeathersTableAdapter();
            this.tableAdapterManager2 = new rolete.skladDataSet2TableAdapters.TableAdapterManager();
            this.viewMechanismBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewMechanismTableAdapter = new rolete.skladDataSet2TableAdapters.ViewMechanismTableAdapter();
            this.viewMotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewMotTableAdapter = new rolete.skladDataSet2TableAdapters.ViewMotTableAdapter();
            this.viewProfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewProfilTableAdapter = new rolete.skladDataSet2TableAdapters.ViewProfilTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSkladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFeathersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMechanismBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProfilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // skladDataSet
            // 
            this.skladDataSet.DataSetName = "skladDataSet";
            this.skladDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewSkladBindingSource
            // 
            this.viewSkladBindingSource.DataMember = "ViewSklad";
            this.viewSkladBindingSource.DataSource = this.skladDataSet;
            // 
            // viewSkladTableAdapter
            // 
            this.viewSkladTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = rolete.skladDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // skladDataSet1
            // 
            this.skladDataSet1.DataSetName = "skladDataSet1";
            this.skladDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewBindingSource
            // 
            this.viewBindingSource.DataMember = "View";
            this.viewBindingSource.DataSource = this.skladDataSet1;
            // 
            // viewTableAdapter
            // 
            this.viewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = rolete.skladDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
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
            // skladDataSet2
            // 
            this.skladDataSet2.DataSetName = "skladDataSet2";
            this.skladDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewFeathersBindingSource
            // 
            this.viewFeathersBindingSource.DataMember = "ViewFeathers";
            this.viewFeathersBindingSource.DataSource = this.skladDataSet2;
            // 
            // viewFeathersTableAdapter
            // 
            this.viewFeathersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.UpdateOrder = rolete.skladDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // viewMechanismBindingSource
            // 
            this.viewMechanismBindingSource.DataMember = "ViewMechanism";
            this.viewMechanismBindingSource.DataSource = this.skladDataSet2;
            // 
            // viewMechanismTableAdapter
            // 
            this.viewMechanismTableAdapter.ClearBeforeFill = true;
            // 
            // viewMotBindingSource
            // 
            this.viewMotBindingSource.DataMember = "ViewMot";
            this.viewMotBindingSource.DataSource = this.skladDataSet2;
            // 
            // viewMotTableAdapter
            // 
            this.viewMotTableAdapter.ClearBeforeFill = true;
            // 
            // viewProfilBindingSource
            // 
            this.viewProfilBindingSource.DataMember = "ViewProfil";
            this.viewProfilBindingSource.DataSource = this.skladDataSet2;
            // 
            // viewProfilTableAdapter
            // 
            this.viewProfilTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSkladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skladDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewFeathersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMechanismBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProfilBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private skladDataSet skladDataSet;
        private System.Windows.Forms.BindingSource viewSkladBindingSource;
        private skladDataSetTableAdapters.ViewSkladTableAdapter viewSkladTableAdapter;
        private skladDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private skladDataSet1 skladDataSet1;
        private System.Windows.Forms.BindingSource viewBindingSource;
        private skladDataSet1TableAdapters.ViewTableAdapter viewTableAdapter;
        private skladDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private skladDataSet2 skladDataSet2;
        private System.Windows.Forms.BindingSource viewFeathersBindingSource;
        private skladDataSet2TableAdapters.ViewFeathersTableAdapter viewFeathersTableAdapter;
        private skladDataSet2TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.BindingSource viewMechanismBindingSource;
        private skladDataSet2TableAdapters.ViewMechanismTableAdapter viewMechanismTableAdapter;
        private System.Windows.Forms.BindingSource viewMotBindingSource;
        private skladDataSet2TableAdapters.ViewMotTableAdapter viewMotTableAdapter;
        private System.Windows.Forms.BindingSource viewProfilBindingSource;
        private skladDataSet2TableAdapters.ViewProfilTableAdapter viewProfilTableAdapter;
    }
}