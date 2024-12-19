namespace quanlynhanvien
{
    partial class khachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(khachhang));
            this.label8 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btdong = new System.Windows.Forms.Button();
            this.msksdt = new System.Windows.Forms.MaskedTextBox();
            this.btboqua = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.dtgrvkhachhang = new System.Windows.Forms.DataGridView();
            this.txttenkhach = new System.Windows.Forms.TextBox();
            this.txtmakhach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvkhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(206, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(369, 32);
            this.label8.TabIndex = 49;
            this.label8.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(538, 84);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(109, 22);
            this.txtdiachi.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "Địa chỉ:";
            // 
            // btdong
            // 
            this.btdong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btdong.Location = new System.Drawing.Point(713, 388);
            this.btdong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btdong.Name = "btdong";
            this.btdong.Size = new System.Drawing.Size(101, 23);
            this.btdong.TabIndex = 45;
            this.btdong.Text = "Đóng";
            this.btdong.UseVisualStyleBackColor = false;
            this.btdong.Click += new System.EventHandler(this.btdong_Click);
            // 
            // msksdt
            // 
            this.msksdt.Location = new System.Drawing.Point(538, 129);
            this.msksdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msksdt.Mask = "(999) 000-0000";
            this.msksdt.Name = "msksdt";
            this.msksdt.Size = new System.Drawing.Size(109, 22);
            this.msksdt.TabIndex = 43;
            // 
            // btboqua
            // 
            this.btboqua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btboqua.Location = new System.Drawing.Point(578, 388);
            this.btboqua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btboqua.Name = "btboqua";
            this.btboqua.Size = new System.Drawing.Size(101, 23);
            this.btboqua.TabIndex = 41;
            this.btboqua.Text = "Bỏ qua";
            this.btboqua.UseVisualStyleBackColor = false;
            this.btboqua.Click += new System.EventHandler(this.btboqua_Click);
            // 
            // btluu
            // 
            this.btluu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btluu.Location = new System.Drawing.Point(442, 388);
            this.btluu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(101, 23);
            this.btluu.TabIndex = 40;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = false;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btsua
            // 
            this.btsua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btsua.Location = new System.Drawing.Point(312, 388);
            this.btsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(101, 23);
            this.btsua.TabIndex = 39;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = false;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btxoa.Location = new System.Drawing.Point(176, 388);
            this.btxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(101, 23);
            this.btxoa.TabIndex = 38;
            this.btxoa.Text = "Xoá";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btthem
            // 
            this.btthem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btthem.Location = new System.Drawing.Point(42, 388);
            this.btthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(101, 23);
            this.btthem.TabIndex = 37;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // dtgrvkhachhang
            // 
            this.dtgrvkhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvkhachhang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgrvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvkhachhang.Location = new System.Drawing.Point(82, 183);
            this.dtgrvkhachhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgrvkhachhang.Name = "dtgrvkhachhang";
            this.dtgrvkhachhang.RowHeadersWidth = 51;
            this.dtgrvkhachhang.RowTemplate.Height = 24;
            this.dtgrvkhachhang.Size = new System.Drawing.Size(686, 161);
            this.dtgrvkhachhang.TabIndex = 36;
            this.dtgrvkhachhang.Click += new System.EventHandler(this.dtgrvkhachhang_Click);
            // 
            // txttenkhach
            // 
            this.txttenkhach.Location = new System.Drawing.Point(234, 127);
            this.txttenkhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttenkhach.Name = "txttenkhach";
            this.txttenkhach.Size = new System.Drawing.Size(115, 22);
            this.txttenkhach.TabIndex = 35;
            // 
            // txtmakhach
            // 
            this.txtmakhach.Location = new System.Drawing.Point(234, 85);
            this.txtmakhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmakhach.Name = "txtmakhach";
            this.txtmakhach.Size = new System.Drawing.Size(115, 22);
            this.txtmakhach.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tên khách: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã hhách:";
            // 
            // khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(879, 455);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btdong);
            this.Controls.Add(this.msksdt);
            this.Controls.Add(this.btboqua);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.dtgrvkhachhang);
            this.Controls.Add(this.txttenkhach);
            this.Controls.Add(this.txtmakhach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "khachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.khachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvkhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btdong;
        private System.Windows.Forms.MaskedTextBox msksdt;
        private System.Windows.Forms.Button btboqua;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.DataGridView dtgrvkhachhang;
        private System.Windows.Forms.TextBox txttenkhach;
        private System.Windows.Forms.TextBox txtmakhach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}