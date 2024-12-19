namespace quanlycafen1
{
    partial class formbaocaonhaphang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formbaocaonhaphang));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbkhoang = new System.Windows.Forms.GroupBox();
            this.mskdenngay = new System.Windows.Forms.MaskedTextBox();
            this.msktungay = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdobtkhoang = new System.Windows.Forms.RadioButton();
            this.rdobtngay = new System.Windows.Forms.RadioButton();
            this.cbbncc = new System.Windows.Forms.ComboBox();
            this.cbbtensp = new System.Windows.Forms.ComboBox();
            this.cbbnhanviennhap = new System.Windows.Forms.ComboBox();
            this.bttim = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbmahdn = new System.Windows.Forms.ComboBox();
            this.txtdongianhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mskngaynhap = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgrvidcthdn = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.bthienthi = new System.Windows.Forms.Button();
            this.btin = new System.Windows.Forms.Button();
            this.dtgrvdsp = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.grbkhoang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvidcthdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvdsp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hoá đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grbkhoang);
            this.groupBox1.Controls.Add(this.rdobtkhoang);
            this.groupBox1.Controls.Add(this.rdobtngay);
            this.groupBox1.Controls.Add(this.cbbncc);
            this.groupBox1.Controls.Add(this.cbbtensp);
            this.groupBox1.Controls.Add(this.cbbnhanviennhap);
            this.groupBox1.Controls.Add(this.bttim);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbbmahdn);
            this.groupBox1.Controls.Add(this.txtdongianhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mskngaynhap);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(275, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1224, 158);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm ";
            // 
            // grbkhoang
            // 
            this.grbkhoang.Controls.Add(this.mskdenngay);
            this.grbkhoang.Controls.Add(this.msktungay);
            this.grbkhoang.Controls.Add(this.label6);
            this.grbkhoang.Controls.Add(this.label2);
            this.grbkhoang.Location = new System.Drawing.Point(798, 33);
            this.grbkhoang.Name = "grbkhoang";
            this.grbkhoang.Size = new System.Drawing.Size(420, 38);
            this.grbkhoang.TabIndex = 25;
            this.grbkhoang.TabStop = false;
            // 
            // mskdenngay
            // 
            this.mskdenngay.Location = new System.Drawing.Point(251, 10);
            this.mskdenngay.Mask = "00/00/0000";
            this.mskdenngay.Name = "mskdenngay";
            this.mskdenngay.Size = new System.Drawing.Size(152, 22);
            this.mskdenngay.TabIndex = 24;
            this.mskdenngay.ValidatingType = typeof(System.DateTime);
            // 
            // msktungay
            // 
            this.msktungay.Location = new System.Drawing.Point(56, 11);
            this.msktungay.Mask = "00/00/0000";
            this.msktungay.Name = "msktungay";
            this.msktungay.Size = new System.Drawing.Size(152, 22);
            this.msktungay.TabIndex = 21;
            this.msktungay.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Từ";
            // 
            // rdobtkhoang
            // 
            this.rdobtkhoang.AutoSize = true;
            this.rdobtkhoang.Location = new System.Drawing.Point(676, 42);
            this.rdobtkhoang.Name = "rdobtkhoang";
            this.rdobtkhoang.Size = new System.Drawing.Size(108, 20);
            this.rdobtkhoang.TabIndex = 20;
            this.rdobtkhoang.TabStop = true;
            this.rdobtkhoang.Text = "Theo khoảng";
            this.rdobtkhoang.UseVisualStyleBackColor = true;
            this.rdobtkhoang.CheckedChanged += new System.EventHandler(this.rdobtkhoang_CheckedChanged);
            // 
            // rdobtngay
            // 
            this.rdobtngay.AutoSize = true;
            this.rdobtngay.Location = new System.Drawing.Point(676, 87);
            this.rdobtngay.Name = "rdobtngay";
            this.rdobtngay.Size = new System.Drawing.Size(96, 20);
            this.rdobtngay.TabIndex = 19;
            this.rdobtngay.TabStop = true;
            this.rdobtngay.Text = "Theo ngày ";
            this.rdobtngay.UseVisualStyleBackColor = true;
            this.rdobtngay.CheckedChanged += new System.EventHandler(this.rdobtngay_CheckedChanged);
            // 
            // cbbncc
            // 
            this.cbbncc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbncc.FormattingEnabled = true;
            this.cbbncc.Location = new System.Drawing.Point(411, 33);
            this.cbbncc.Name = "cbbncc";
            this.cbbncc.Size = new System.Drawing.Size(145, 24);
            this.cbbncc.TabIndex = 18;
            // 
            // cbbtensp
            // 
            this.cbbtensp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbtensp.FormattingEnabled = true;
            this.cbbtensp.Location = new System.Drawing.Point(100, 89);
            this.cbbtensp.Name = "cbbtensp";
            this.cbbtensp.Size = new System.Drawing.Size(152, 24);
            this.cbbtensp.TabIndex = 15;
            // 
            // cbbnhanviennhap
            // 
            this.cbbnhanviennhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbnhanviennhap.FormattingEnabled = true;
            this.cbbnhanviennhap.Location = new System.Drawing.Point(411, 80);
            this.cbbnhanviennhap.Name = "cbbnhanviennhap";
            this.cbbnhanviennhap.Size = new System.Drawing.Size(152, 24);
            this.cbbnhanviennhap.TabIndex = 17;
            // 
            // bttim
            // 
            this.bttim.Location = new System.Drawing.Point(1101, 111);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(123, 41);
            this.bttim.TabIndex = 7;
            this.bttim.Text = "Tìm kiếm";
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đơn giá nhập";
            // 
            // cbbmahdn
            // 
            this.cbbmahdn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmahdn.FormattingEnabled = true;
            this.cbbmahdn.Location = new System.Drawing.Point(100, 37);
            this.cbbmahdn.Name = "cbbmahdn";
            this.cbbmahdn.Size = new System.Drawing.Size(152, 24);
            this.cbbmahdn.TabIndex = 14;
            // 
            // txtdongianhap
            // 
            this.txtdongianhap.Location = new System.Drawing.Point(411, 118);
            this.txtdongianhap.Name = "txtdongianhap";
            this.txtdongianhap.Size = new System.Drawing.Size(152, 22);
            this.txtdongianhap.TabIndex = 16;
            this.txtdongianhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdongianhap_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nhân viên nhập";
            // 
            // mskngaynhap
            // 
            this.mskngaynhap.Location = new System.Drawing.Point(854, 91);
            this.mskngaynhap.Mask = "00/00/0000";
            this.mskngaynhap.Name = "mskngaynhap";
            this.mskngaynhap.Size = new System.Drawing.Size(152, 22);
            this.mskngaynhap.TabIndex = 8;
            this.mskngaynhap.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tên nhà cung cấp";
            // 
            // dtgrvidcthdn
            // 
            this.dtgrvidcthdn.AllowUserToAddRows = false;
            this.dtgrvidcthdn.AllowUserToDeleteRows = false;
            this.dtgrvidcthdn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvidcthdn.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgrvidcthdn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvidcthdn.Location = new System.Drawing.Point(12, 314);
            this.dtgrvidcthdn.Name = "dtgrvidcthdn";
            this.dtgrvidcthdn.RowHeadersWidth = 51;
            this.dtgrvidcthdn.RowTemplate.Height = 24;
            this.dtgrvidcthdn.Size = new System.Drawing.Size(1355, 474);
            this.dtgrvidcthdn.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(768, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "BÁO CÁO NHẬP HÀNG ";
            // 
            // bthienthi
            // 
            this.bthienthi.Location = new System.Drawing.Point(1457, 793);
            this.bthienthi.Name = "bthienthi";
            this.bthienthi.Size = new System.Drawing.Size(123, 41);
            this.bthienthi.TabIndex = 6;
            this.bthienthi.Text = "Hiển Thị";
            this.bthienthi.UseVisualStyleBackColor = true;
            this.bthienthi.Click += new System.EventHandler(this.bthienthi_Click);
            // 
            // btin
            // 
            this.btin.Location = new System.Drawing.Point(1608, 793);
            this.btin.Name = "btin";
            this.btin.Size = new System.Drawing.Size(132, 41);
            this.btin.TabIndex = 7;
            this.btin.Text = "In báo cáo ";
            this.btin.UseVisualStyleBackColor = true;
            this.btin.Click += new System.EventHandler(this.btin_Click);
            // 
            // dtgrvdsp
            // 
            this.dtgrvdsp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvdsp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgrvdsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvdsp.Location = new System.Drawing.Point(1401, 314);
            this.dtgrvdsp.Name = "dtgrvdsp";
            this.dtgrvdsp.RowHeadersWidth = 51;
            this.dtgrvdsp.RowTemplate.Height = 24;
            this.dtgrvdsp.Size = new System.Drawing.Size(339, 473);
            this.dtgrvdsp.TabIndex = 8;
            // 
            // formbaocaonhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.dtgrvdsp);
            this.Controls.Add(this.btin);
            this.Controls.Add(this.bthienthi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgrvidcthdn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formbaocaonhaphang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo nhập hàng";
            this.Load += new System.EventHandler(this.formbaocaonhaphang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbkhoang.ResumeLayout(false);
            this.grbkhoang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvidcthdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvdsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgrvidcthdn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bthienthi;
        private System.Windows.Forms.Button btin;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbncc;
        private System.Windows.Forms.ComboBox cbbnhanviennhap;
        private System.Windows.Forms.TextBox txtdongianhap;
        private System.Windows.Forms.ComboBox cbbtensp;
        private System.Windows.Forms.ComboBox cbbmahdn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskngaynhap;
        private System.Windows.Forms.MaskedTextBox mskdenngay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox msktungay;
        private System.Windows.Forms.RadioButton rdobtkhoang;
        private System.Windows.Forms.RadioButton rdobtngay;
        private System.Windows.Forms.GroupBox grbkhoang;
        private System.Windows.Forms.DataGridView dtgrvdsp;
    }
}