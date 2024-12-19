namespace quanlycaphe.Forms
{
    partial class sanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sanpham));
            this.btnhienthi = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.lblmasanpham = new System.Windows.Forms.Label();
            this.lbltensanpham = new System.Windows.Forms.Label();
            this.lblmaloai = new System.Windows.Forms.Label();
            this.lblgianhap = new System.Windows.Forms.Label();
            this.lblgiaban = new System.Windows.Forms.Label();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.lblmacongdung = new System.Windows.Forms.Label();
            this.lblhinhanh = new System.Windows.Forms.Label();
            this.txtmasanpham = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.txtgianhap = new System.Windows.Forms.TextBox();
            this.txttensanpham = new System.Windows.Forms.TextBox();
            this.txthinhanh = new System.Windows.Forms.TextBox();
            this.cbomaloai = new System.Windows.Forms.ComboBox();
            this.cbomacongdung = new System.Windows.Forms.ComboBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.pichinhanh = new System.Windows.Forms.PictureBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pichinhanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnhienthi
            // 
            this.btnhienthi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnhienthi.Location = new System.Drawing.Point(947, 685);
            this.btnhienthi.Margin = new System.Windows.Forms.Padding(4);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(93, 33);
            this.btnhienthi.TabIndex = 39;
            this.btnhienthi.Text = "Hiển thị";
            this.btnhienthi.UseVisualStyleBackColor = false;
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
            // 
            // btndong
            // 
            this.btndong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndong.Location = new System.Drawing.Point(1078, 685);
            this.btndong.Margin = new System.Windows.Forms.Padding(4);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(95, 33);
            this.btndong.TabIndex = 38;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = false;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnboqua.Location = new System.Drawing.Point(692, 684);
            this.btnboqua.Margin = new System.Windows.Forms.Padding(4);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(93, 33);
            this.btnboqua.TabIndex = 37;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = false;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnluu.Location = new System.Drawing.Point(584, 685);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(85, 33);
            this.btnluu.TabIndex = 36;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsua.Location = new System.Drawing.Point(449, 685);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(104, 33);
            this.btnsua.TabIndex = 35;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnxoa.Location = new System.Drawing.Point(314, 685);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(103, 33);
            this.btnxoa.TabIndex = 34;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnthem.Location = new System.Drawing.Point(170, 685);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(109, 33);
            this.btnthem.TabIndex = 33;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // lblmasanpham
            // 
            this.lblmasanpham.AutoSize = true;
            this.lblmasanpham.Location = new System.Drawing.Point(15, 39);
            this.lblmasanpham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmasanpham.Name = "lblmasanpham";
            this.lblmasanpham.Size = new System.Drawing.Size(91, 16);
            this.lblmasanpham.TabIndex = 40;
            this.lblmasanpham.Text = "Mã sản phẩm:";
            // 
            // lbltensanpham
            // 
            this.lbltensanpham.AutoSize = true;
            this.lbltensanpham.Location = new System.Drawing.Point(10, 82);
            this.lbltensanpham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltensanpham.Name = "lbltensanpham";
            this.lbltensanpham.Size = new System.Drawing.Size(96, 16);
            this.lbltensanpham.TabIndex = 41;
            this.lbltensanpham.Text = "Tên sản phẩm:";
            // 
            // lblmaloai
            // 
            this.lblmaloai.AutoSize = true;
            this.lblmaloai.Location = new System.Drawing.Point(46, 127);
            this.lblmaloai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmaloai.Name = "lblmaloai";
            this.lblmaloai.Size = new System.Drawing.Size(54, 16);
            this.lblmaloai.TabIndex = 42;
            this.lblmaloai.Text = "Mã loại:";
            // 
            // lblgianhap
            // 
            this.lblgianhap.AutoSize = true;
            this.lblgianhap.Location = new System.Drawing.Point(15, 176);
            this.lblgianhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgianhap.Name = "lblgianhap";
            this.lblgianhap.Size = new System.Drawing.Size(89, 16);
            this.lblgianhap.TabIndex = 43;
            this.lblgianhap.Text = "Đơn giá nhập:";
            // 
            // lblgiaban
            // 
            this.lblgiaban.AutoSize = true;
            this.lblgiaban.Location = new System.Drawing.Point(23, 222);
            this.lblgiaban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgiaban.Name = "lblgiaban";
            this.lblgiaban.Size = new System.Drawing.Size(82, 16);
            this.lblgiaban.TabIndex = 44;
            this.lblgiaban.Text = "Đơn giá bán:";
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.Location = new System.Drawing.Point(37, 276);
            this.lblsoluong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(63, 16);
            this.lblsoluong.TabIndex = 45;
            this.lblsoluong.Text = "Số lượng:";
            // 
            // lblmacongdung
            // 
            this.lblmacongdung.AutoSize = true;
            this.lblmacongdung.Location = new System.Drawing.Point(9, 324);
            this.lblmacongdung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmacongdung.Name = "lblmacongdung";
            this.lblmacongdung.Size = new System.Drawing.Size(95, 16);
            this.lblmacongdung.TabIndex = 46;
            this.lblmacongdung.Text = "Mã công dụng:";
            // 
            // lblhinhanh
            // 
            this.lblhinhanh.AutoSize = true;
            this.lblhinhanh.Location = new System.Drawing.Point(496, 106);
            this.lblhinhanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhinhanh.Name = "lblhinhanh";
            this.lblhinhanh.Size = new System.Drawing.Size(33, 16);
            this.lblhinhanh.TabIndex = 47;
            this.lblhinhanh.Text = "Ảnh:";
            // 
            // txtmasanpham
            // 
            this.txtmasanpham.Location = new System.Drawing.Point(118, 35);
            this.txtmasanpham.Margin = new System.Windows.Forms.Padding(4);
            this.txtmasanpham.Name = "txtmasanpham";
            this.txtmasanpham.Size = new System.Drawing.Size(132, 22);
            this.txtmasanpham.TabIndex = 48;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(118, 272);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(4);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(132, 22);
            this.txtsoluong.TabIndex = 49;
            // 
            // txtgiaban
            // 
            this.txtgiaban.Location = new System.Drawing.Point(118, 218);
            this.txtgiaban.Margin = new System.Windows.Forms.Padding(4);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(132, 22);
            this.txtgiaban.TabIndex = 50;
            // 
            // txtgianhap
            // 
            this.txtgianhap.Location = new System.Drawing.Point(118, 173);
            this.txtgianhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtgianhap.Name = "txtgianhap";
            this.txtgianhap.Size = new System.Drawing.Size(132, 22);
            this.txtgianhap.TabIndex = 51;
            // 
            // txttensanpham
            // 
            this.txttensanpham.Location = new System.Drawing.Point(118, 78);
            this.txttensanpham.Margin = new System.Windows.Forms.Padding(4);
            this.txttensanpham.Name = "txttensanpham";
            this.txttensanpham.Size = new System.Drawing.Size(132, 22);
            this.txttensanpham.TabIndex = 52;
            // 
            // txthinhanh
            // 
            this.txthinhanh.Location = new System.Drawing.Point(549, 100);
            this.txthinhanh.Margin = new System.Windows.Forms.Padding(4);
            this.txthinhanh.Name = "txthinhanh";
            this.txthinhanh.Size = new System.Drawing.Size(309, 22);
            this.txthinhanh.TabIndex = 53;
            // 
            // cbomaloai
            // 
            this.cbomaloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomaloai.FormattingEnabled = true;
            this.cbomaloai.Location = new System.Drawing.Point(118, 124);
            this.cbomaloai.Margin = new System.Windows.Forms.Padding(4);
            this.cbomaloai.Name = "cbomaloai";
            this.cbomaloai.Size = new System.Drawing.Size(211, 24);
            this.cbomaloai.TabIndex = 54;
            // 
            // cbomacongdung
            // 
            this.cbomacongdung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomacongdung.FormattingEnabled = true;
            this.cbomacongdung.Location = new System.Drawing.Point(118, 324);
            this.cbomacongdung.Margin = new System.Windows.Forms.Padding(4);
            this.cbomacongdung.Name = "cbomacongdung";
            this.cbomacongdung.Size = new System.Drawing.Size(215, 24);
            this.cbomacongdung.TabIndex = 55;
            // 
            // btnopen
            // 
            this.btnopen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnopen.Location = new System.Drawing.Point(672, 131);
            this.btnopen.Margin = new System.Windows.Forms.Padding(4);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(73, 28);
            this.btnopen.TabIndex = 56;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = false;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // pichinhanh
            // 
            this.pichinhanh.Location = new System.Drawing.Point(7, 13);
            this.pichinhanh.Margin = new System.Windows.Forms.Padding(4);
            this.pichinhanh.Name = "pichinhanh";
            this.pichinhanh.Size = new System.Drawing.Size(502, 283);
            this.pichinhanh.TabIndex = 57;
            this.pichinhanh.TabStop = false;
            this.pichinhanh.Click += new System.EventHandler(this.pichinhanh_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(152, 441);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.Size = new System.Drawing.Size(1102, 235);
            this.DataGridView.TabIndex = 58;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntimkiem.Location = new System.Drawing.Point(819, 684);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(100, 33);
            this.btntimkiem.TabIndex = 59;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 43);
            this.label1.TabIndex = 60;
            this.label1.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pichinhanh);
            this.groupBox1.Location = new System.Drawing.Point(893, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 304);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hình ảnh ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbomaloai);
            this.groupBox2.Controls.Add(this.lblmasanpham);
            this.groupBox2.Controls.Add(this.lbltensanpham);
            this.groupBox2.Controls.Add(this.lblmaloai);
            this.groupBox2.Controls.Add(this.lblgianhap);
            this.groupBox2.Controls.Add(this.lblgiaban);
            this.groupBox2.Controls.Add(this.cbomacongdung);
            this.groupBox2.Controls.Add(this.lblsoluong);
            this.groupBox2.Controls.Add(this.lblmacongdung);
            this.groupBox2.Controls.Add(this.txtmasanpham);
            this.groupBox2.Controls.Add(this.txttensanpham);
            this.groupBox2.Controls.Add(this.txtsoluong);
            this.groupBox2.Controls.Add(this.txtgianhap);
            this.groupBox2.Controls.Add(this.txtgiaban);
            this.groupBox2.Location = new System.Drawing.Point(84, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 373);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm ";
            // 
            // sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1410, 878);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.txthinhanh);
            this.Controls.Add(this.lblhinhanh);
            this.Controls.Add(this.btnhienthi);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "sanpham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.sanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pichinhanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label lblmasanpham;
        private System.Windows.Forms.Label lbltensanpham;
        private System.Windows.Forms.Label lblmaloai;
        private System.Windows.Forms.Label lblgianhap;
        private System.Windows.Forms.Label lblgiaban;
        private System.Windows.Forms.Label lblsoluong;
        private System.Windows.Forms.Label lblmacongdung;
        private System.Windows.Forms.Label lblhinhanh;
        private System.Windows.Forms.TextBox txtmasanpham;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.TextBox txtgianhap;
        private System.Windows.Forms.TextBox txttensanpham;
        private System.Windows.Forms.TextBox txthinhanh;
        private System.Windows.Forms.ComboBox cbomaloai;
        private System.Windows.Forms.ComboBox cbomacongdung;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.PictureBox pichinhanh;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}