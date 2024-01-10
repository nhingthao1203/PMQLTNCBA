namespace PMTNCBA
{
    partial class DatLich
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
            this.lTCSDLDataSet = new PMTNCBA.LTCSDLDataSet();
            this.baoCaoLoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baoCaoLoiTableAdapter = new PMTNCBA.LTCSDLDataSetTableAdapters.BaoCaoLoiTableAdapter();
            this.baoCaoLoiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lTCSDLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoLoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoLoiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.baoCaoLoiBindingSource1;
            this.comboBox1.DisplayMember = "Loai";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(223, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(427, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // lTCSDLDataSet
            // 
            this.lTCSDLDataSet.DataSetName = "LTCSDLDataSet";
            this.lTCSDLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baoCaoLoiBindingSource
            // 
            this.baoCaoLoiBindingSource.DataMember = "BaoCaoLoi";
            this.baoCaoLoiBindingSource.DataSource = this.lTCSDLDataSet;
            // 
            // baoCaoLoiTableAdapter
            // 
            this.baoCaoLoiTableAdapter.ClearBeforeFill = true;
            // 
            // baoCaoLoiBindingSource1
            // 
            this.baoCaoLoiBindingSource1.DataMember = "BaoCaoLoi";
            this.baoCaoLoiBindingSource1.DataSource = this.lTCSDLDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại lỗi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mô tả:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(223, 113);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(427, 47);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã sinh viên:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(223, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(427, 30);
            this.textBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(263, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 61);
            this.button1.TabIndex = 7;
            this.button1.Text = "Gửi báo lỗi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DatLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "DatLich";
            this.Text = "Báo Lỗi";
            this.Load += new System.EventHandler(this.DatLich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lTCSDLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoLoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoLoiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private LTCSDLDataSet lTCSDLDataSet;
        private System.Windows.Forms.BindingSource baoCaoLoiBindingSource;
        private LTCSDLDataSetTableAdapters.BaoCaoLoiTableAdapter baoCaoLoiTableAdapter;
        private System.Windows.Forms.BindingSource baoCaoLoiBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}