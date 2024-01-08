namespace PMTNCBA
{
    partial class AddQ
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.monBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lTCSDLDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lTCSDLDataSet = new PMTNCBA.LTCSDLDataSet();
            this.mONTHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maCHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhThucCHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.maMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doKhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapAnADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapAnBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapAnCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapAnDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapAnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cauHoiGopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lTCSDLDataSet1 = new PMTNCBA.LTCSDLDataSet1();
            this.cauHoi_GopTableAdapter = new PMTNCBA.LTCSDLDataSet1TableAdapters.CauHoi_GopTableAdapter();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.monTableAdapter = new PMTNCBA.LTCSDLDataSetTableAdapters.MonTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKỳThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhómTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTCSDLDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTCSDLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONTHIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cauHoiGopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTCSDLDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.monBindingSource;
            this.comboBox1.DisplayMember = "MaMon";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(193, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(321, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "MaMon";
            // 
            // monBindingSource
            // 
            this.monBindingSource.DataMember = "Mon";
            this.monBindingSource.DataSource = this.lTCSDLDataSetBindingSource;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã môn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nội dung";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 99);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 66);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Đáp án_A:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(193, 197);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(321, 22);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(193, 256);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(321, 22);
            this.textBox3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Đáp án_B:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(193, 315);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(321, 22);
            this.textBox4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Đáp án_C:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(193, 378);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(321, 22);
            this.textBox5.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Đáp án_D:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Đáp án:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 51);
            this.button1.TabIndex = 20;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 51);
            this.button2.TabIndex = 21;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(478, 511);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 51);
            this.button3.TabIndex = 22;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCHDataGridViewTextBoxColumn,
            this.noiDungDataGridViewTextBoxColumn,
            this.hinhThucCHDataGridViewTextBoxColumn,
            this.hinhDataGridViewImageColumn,
            this.maMonDataGridViewTextBoxColumn,
            this.doKhoDataGridViewTextBoxColumn,
            this.dapAnADataGridViewTextBoxColumn,
            this.dapAnBDataGridViewTextBoxColumn,
            this.dapAnCDataGridViewTextBoxColumn,
            this.dapAnDDataGridViewTextBoxColumn,
            this.dapAnDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cauHoiGopBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(542, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(905, 432);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // maCHDataGridViewTextBoxColumn
            // 
            this.maCHDataGridViewTextBoxColumn.DataPropertyName = "MaCH";
            this.maCHDataGridViewTextBoxColumn.HeaderText = "MaCH";
            this.maCHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maCHDataGridViewTextBoxColumn.Name = "maCHDataGridViewTextBoxColumn";
            this.maCHDataGridViewTextBoxColumn.ReadOnly = true;
            this.maCHDataGridViewTextBoxColumn.Width = 125;
            // 
            // noiDungDataGridViewTextBoxColumn
            // 
            this.noiDungDataGridViewTextBoxColumn.DataPropertyName = "NoiDung";
            this.noiDungDataGridViewTextBoxColumn.HeaderText = "NoiDung";
            this.noiDungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noiDungDataGridViewTextBoxColumn.Name = "noiDungDataGridViewTextBoxColumn";
            this.noiDungDataGridViewTextBoxColumn.Width = 125;
            // 
            // hinhThucCHDataGridViewTextBoxColumn
            // 
            this.hinhThucCHDataGridViewTextBoxColumn.DataPropertyName = "HinhThucCH";
            this.hinhThucCHDataGridViewTextBoxColumn.HeaderText = "HinhThucCH";
            this.hinhThucCHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hinhThucCHDataGridViewTextBoxColumn.Name = "hinhThucCHDataGridViewTextBoxColumn";
            this.hinhThucCHDataGridViewTextBoxColumn.Width = 125;
            // 
            // hinhDataGridViewImageColumn
            // 
            this.hinhDataGridViewImageColumn.DataPropertyName = "Hinh";
            this.hinhDataGridViewImageColumn.HeaderText = "Hinh";
            this.hinhDataGridViewImageColumn.MinimumWidth = 6;
            this.hinhDataGridViewImageColumn.Name = "hinhDataGridViewImageColumn";
            this.hinhDataGridViewImageColumn.Width = 125;
            // 
            // maMonDataGridViewTextBoxColumn
            // 
            this.maMonDataGridViewTextBoxColumn.DataPropertyName = "MaMon";
            this.maMonDataGridViewTextBoxColumn.HeaderText = "MaMon";
            this.maMonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maMonDataGridViewTextBoxColumn.Name = "maMonDataGridViewTextBoxColumn";
            this.maMonDataGridViewTextBoxColumn.Width = 125;
            // 
            // doKhoDataGridViewTextBoxColumn
            // 
            this.doKhoDataGridViewTextBoxColumn.DataPropertyName = "DoKho";
            this.doKhoDataGridViewTextBoxColumn.HeaderText = "DoKho";
            this.doKhoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doKhoDataGridViewTextBoxColumn.Name = "doKhoDataGridViewTextBoxColumn";
            this.doKhoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dapAnADataGridViewTextBoxColumn
            // 
            this.dapAnADataGridViewTextBoxColumn.DataPropertyName = "DapAn_A";
            this.dapAnADataGridViewTextBoxColumn.HeaderText = "DapAn_A";
            this.dapAnADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dapAnADataGridViewTextBoxColumn.Name = "dapAnADataGridViewTextBoxColumn";
            this.dapAnADataGridViewTextBoxColumn.Width = 125;
            // 
            // dapAnBDataGridViewTextBoxColumn
            // 
            this.dapAnBDataGridViewTextBoxColumn.DataPropertyName = "DapAn_B";
            this.dapAnBDataGridViewTextBoxColumn.HeaderText = "DapAn_B";
            this.dapAnBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dapAnBDataGridViewTextBoxColumn.Name = "dapAnBDataGridViewTextBoxColumn";
            this.dapAnBDataGridViewTextBoxColumn.Width = 125;
            // 
            // dapAnCDataGridViewTextBoxColumn
            // 
            this.dapAnCDataGridViewTextBoxColumn.DataPropertyName = "DapAn_C";
            this.dapAnCDataGridViewTextBoxColumn.HeaderText = "DapAn_C";
            this.dapAnCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dapAnCDataGridViewTextBoxColumn.Name = "dapAnCDataGridViewTextBoxColumn";
            this.dapAnCDataGridViewTextBoxColumn.Width = 125;
            // 
            // dapAnDDataGridViewTextBoxColumn
            // 
            this.dapAnDDataGridViewTextBoxColumn.DataPropertyName = "DapAn_D";
            this.dapAnDDataGridViewTextBoxColumn.HeaderText = "DapAn_D";
            this.dapAnDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dapAnDDataGridViewTextBoxColumn.Name = "dapAnDDataGridViewTextBoxColumn";
            this.dapAnDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dapAnDataGridViewTextBoxColumn
            // 
            this.dapAnDataGridViewTextBoxColumn.DataPropertyName = "DapAn";
            this.dapAnDataGridViewTextBoxColumn.HeaderText = "DapAn";
            this.dapAnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dapAnDataGridViewTextBoxColumn.Name = "dapAnDataGridViewTextBoxColumn";
            this.dapAnDataGridViewTextBoxColumn.Width = 125;
            // 
            // cauHoiGopBindingSource
            // 
            this.cauHoiGopBindingSource.DataMember = "CauHoi_Gop";
            this.cauHoiGopBindingSource.DataSource = this.lTCSDLDataSet1;
            // 
            // lTCSDLDataSet1
            // 
            this.lTCSDLDataSet1.DataSetName = "LTCSDLDataSet1";
            this.lTCSDLDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cauHoi_GopTableAdapter
            // 
            this.cauHoi_GopTableAdapter.ClearBeforeFill = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(193, 422);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(37, 20);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "A";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(397, 422);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 20);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "B";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(193, 461);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(37, 20);
            this.radioButton3.TabIndex = 26;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "C";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(397, 461);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(38, 20);
            this.radioButton4.TabIndex = 27;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "D";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // monTableAdapter
            // 
            this.monTableAdapter.ClearBeforeFill = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(1469, 28);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            this.hệThốngToolStripMenuItem.Click += new System.EventHandler(this.hệThốngToolStripMenuItem_Click_1);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýKỳThiToolStripMenuItem,
            this.questionToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // quảnLýKỳThiToolStripMenuItem
            // 
            this.quảnLýKỳThiToolStripMenuItem.Name = "quảnLýKỳThiToolStripMenuItem";
            this.quảnLýKỳThiToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.quảnLýKỳThiToolStripMenuItem.Text = "Quản lý kỳ thi";
            this.quảnLýKỳThiToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKỳThiToolStripMenuItem_Click);
            // 
            // questionToolStripMenuItem
            // 
            this.questionToolStripMenuItem.Name = "questionToolStripMenuItem";
            this.questionToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.questionToolStripMenuItem.Text = "Question";
            this.questionToolStripMenuItem.Click += new System.EventHandler(this.questionToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            this.trợGiúpToolStripMenuItem.Click += new System.EventHandler(this.trợGiúpToolStripMenuItem_Click_1);
            // 
            // nhómTácGiảToolStripMenuItem
            // 
            this.nhómTácGiảToolStripMenuItem.Name = "nhómTácGiảToolStripMenuItem";
            this.nhómTácGiảToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.nhómTácGiảToolStripMenuItem.Text = "Nhóm tác giả";
            this.nhómTácGiảToolStripMenuItem.Click += new System.EventHandler(this.nhómTácGiảToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // AddQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 624);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "AddQ";
            this.Text = "AddQ";
            this.Load += new System.EventHandler(this.AddQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTCSDLDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTCSDLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONTHIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cauHoiGopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTCSDLDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource mONTHIBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LTCSDLDataSet lTCSDLDataSet;
        private System.Windows.Forms.BindingSource lTCSDLDataSetBindingSource;
        private LTCSDLDataSet1 lTCSDLDataSet1;
        private System.Windows.Forms.BindingSource cauHoiGopBindingSource;
        private LTCSDLDataSet1TableAdapters.CauHoi_GopTableAdapter cauHoi_GopTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhThucCHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn hinhDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dapAnADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dapAnBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dapAnCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dapAnDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dapAnDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.BindingSource monBindingSource;
        private LTCSDLDataSetTableAdapters.MonTableAdapter monTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKỳThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhómTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}