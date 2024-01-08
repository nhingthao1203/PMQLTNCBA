namespace PMTNCBA
{
    partial class SelectCourse
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kyThiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lTCSDLDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lTCSDLDataSet = new PMTNCBA.LTCSDLDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.monBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.kyThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kyThiTableAdapter = new PMTNCBA.LTCSDLDataSetTableAdapters.KyThiTableAdapter();
            this.lTCSDLDataSet1 = new PMTNCBA.LTCSDLDataSet1();
            this.lTCSDLDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKKQKTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketQuaTableAdapter = new PMTNCBA.LTCSDLDataSetTableAdapters.KetQuaTableAdapter();
            this.kyThiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kyThiBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopTableAdapter = new PMTNCBA.LTCSDLDataSetTableAdapters.LopTableAdapter();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaTableAdapter = new PMTNCBA.LTCSDLDataSetTableAdapters.KhoaTableAdapter();
            this.monTableAdapter = new PMTNCBA.LTCSDLDataSetTableAdapters.MonTableAdapter();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhómTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.kyThiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTCSDLDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTCSDLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyThiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTCSDLDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTCSDLDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKKQKTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyThiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyThiBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Môn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kỳ thi:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.kyThiBindingSource1;
            this.comboBox1.DisplayMember = "TenKT";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(255, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 24);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.ValueMember = "TenKT";
            // 
            // kyThiBindingSource1
            // 
            this.kyThiBindingSource1.DataMember = "KyThi";
            this.kyThiBindingSource1.DataSource = this.lTCSDLDataSetBindingSource;
            // 
            // lTCSDLDataSetBindingSource
            // 
            this.lTCSDLDataSetBindingSource.DataSource = this.lTCSDLDataSet;
            this.lTCSDLDataSetBindingSource.Position = 0;
            // 
            // lTCSDLDataSet
            // 
            this.lTCSDLDataSet.DataSetName = "LTCSDLDataSet";
            this.lTCSDLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.monBindingSource;
            this.comboBox2.DisplayMember = "MaMon";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(255, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(274, 24);
            this.comboBox2.TabIndex = 22;
            this.comboBox2.ValueMember = "MaMon";
            // 
            // monBindingSource
            // 
            this.monBindingSource.DataMember = "Mon";
            this.monBindingSource.DataSource = this.lTCSDLDataSetBindingSource;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Đối tượng:";
            // 
            // kyThiBindingSource
            // 
            this.kyThiBindingSource.DataMember = "KyThi";
            this.kyThiBindingSource.DataSource = this.lTCSDLDataSet;
            // 
            // kyThiTableAdapter
            // 
            this.kyThiTableAdapter.ClearBeforeFill = true;
            // 
            // lTCSDLDataSet1
            // 
            this.lTCSDLDataSet1.DataSetName = "LTCSDLDataSet1";
            this.lTCSDLDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lTCSDLDataSet1BindingSource
            // 
            this.lTCSDLDataSet1BindingSource.DataSource = this.lTCSDLDataSet1;
            this.lTCSDLDataSet1BindingSource.Position = 0;
            // 
            // fKKQKTBindingSource
            // 
            this.fKKQKTBindingSource.DataMember = "FK_KQ_KT";
            this.fKKQKTBindingSource.DataSource = this.kyThiBindingSource;
            // 
            // ketQuaTableAdapter
            // 
            this.ketQuaTableAdapter.ClearBeforeFill = true;
            // 
            // kyThiBindingSource2
            // 
            this.kyThiBindingSource2.DataMember = "KyThi";
            this.kyThiBindingSource2.DataSource = this.lTCSDLDataSetBindingSource;
            // 
            // kyThiBindingSource3
            // 
            this.kyThiBindingSource3.DataMember = "KyThi";
            this.kyThiBindingSource3.DataSource = this.lTCSDLDataSetBindingSource;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.lTCSDLDataSetBindingSource;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.lTCSDLDataSetBindingSource;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // monTableAdapter
            // 
            this.monTableAdapter.ClearBeforeFill = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(255, 120);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 26);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Lớp 10";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(255, 164);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 26);
            this.radioButton2.TabIndex = 32;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Lớp 11";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(255, 207);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(86, 26);
            this.radioButton3.TabIndex = 33;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Lớp 12";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(192, 279);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 48);
            this.button4.TabIndex = 34;
            this.button4.Text = "Start Exam";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.trợGiúpToolStripMenuItem,
            this.nhómTácGiảToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 28);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            this.hệThốngToolStripMenuItem.Click += new System.EventHandler(this.hệThốngToolStripMenuItem_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // nhómTácGiảToolStripMenuItem
            // 
            this.nhómTácGiảToolStripMenuItem.Name = "nhómTácGiảToolStripMenuItem";
            this.nhómTácGiảToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.nhómTácGiảToolStripMenuItem.Text = "Nhóm tác giả";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // SelectCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 393);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SelectCourse";
            this.Text = "CoursePage";
            this.Load += new System.EventHandler(this.SelectCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kyThiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTCSDLDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTCSDLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyThiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTCSDLDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTCSDLDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKKQKTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyThiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyThiBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private LTCSDLDataSet lTCSDLDataSet;
        private System.Windows.Forms.BindingSource kyThiBindingSource;
        private LTCSDLDataSetTableAdapters.KyThiTableAdapter kyThiTableAdapter;
        private System.Windows.Forms.BindingSource lTCSDLDataSet1BindingSource;
        private LTCSDLDataSet1 lTCSDLDataSet1;
        private System.Windows.Forms.BindingSource fKKQKTBindingSource;
        private LTCSDLDataSetTableAdapters.KetQuaTableAdapter ketQuaTableAdapter;
        private System.Windows.Forms.BindingSource kyThiBindingSource1;
        private System.Windows.Forms.BindingSource lTCSDLDataSetBindingSource;
        private System.Windows.Forms.BindingSource kyThiBindingSource2;
        private System.Windows.Forms.BindingSource kyThiBindingSource3;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private LTCSDLDataSetTableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private LTCSDLDataSetTableAdapters.KhoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.BindingSource monBindingSource;
        private LTCSDLDataSetTableAdapters.MonTableAdapter monTableAdapter;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhómTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}