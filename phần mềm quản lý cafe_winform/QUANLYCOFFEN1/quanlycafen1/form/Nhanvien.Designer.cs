namespace quanlycafen1
{
    partial class Nhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nhanvien));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.dtgrvnhanvien = new System.Windows.Forms.DataGridView();
            this.btthem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btboqua = new System.Windows.Forms.Button();
            this.mskngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.msksdt = new System.Windows.Forms.MaskedTextBox();
            this.cbbque = new System.Windows.Forms.ComboBox();
            this.btxoaa = new System.Windows.Forms.Button();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdogit = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã quê: ";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(325, 92);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(141, 22);
            this.txtmanv.TabIndex = 7;
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(326, 127);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(140, 22);
            this.txttennv.TabIndex = 8;
            // 
            // dtgrvnhanvien
            // 
            this.dtgrvnhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvnhanvien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgrvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvnhanvien.Location = new System.Drawing.Point(52, 262);
            this.dtgrvnhanvien.Name = "dtgrvnhanvien";
            this.dtgrvnhanvien.RowHeadersWidth = 51;
            this.dtgrvnhanvien.RowTemplate.Height = 24;
            this.dtgrvnhanvien.Size = new System.Drawing.Size(1115, 208);
            this.dtgrvnhanvien.TabIndex = 13;
            this.dtgrvnhanvien.Click += new System.EventHandler(this.dtgrvnhanvien_Click);
            // 
            // btthem
            // 
            this.btthem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btthem.Location = new System.Drawing.Point(192, 491);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(101, 23);
            this.btthem.TabIndex = 14;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btxoa
            // 
            this.btxoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btxoa.Location = new System.Drawing.Point(319, 491);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(101, 23);
            this.btxoa.TabIndex = 15;
            this.btxoa.Text = "Xoá";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btsua.Location = new System.Drawing.Point(455, 491);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(101, 23);
            this.btsua.TabIndex = 16;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = false;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btluu
            // 
            this.btluu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btluu.Location = new System.Drawing.Point(602, 491);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(101, 23);
            this.btluu.TabIndex = 17;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = false;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btboqua
            // 
            this.btboqua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btboqua.Location = new System.Drawing.Point(732, 491);
            this.btboqua.Name = "btboqua";
            this.btboqua.Size = new System.Drawing.Size(101, 23);
            this.btboqua.TabIndex = 18;
            this.btboqua.Text = "Bỏ qua";
            this.btboqua.UseVisualStyleBackColor = false;
            this.btboqua.Click += new System.EventHandler(this.btboqua_Click);
            // 
            // mskngaysinh
            // 
            this.mskngaysinh.Location = new System.Drawing.Point(635, 124);
            this.mskngaysinh.Mask = "00/00/0000";
            this.mskngaysinh.Name = "mskngaysinh";
            this.mskngaysinh.Size = new System.Drawing.Size(111, 22);
            this.mskngaysinh.TabIndex = 20;
            this.mskngaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // msksdt
            // 
            this.msksdt.Location = new System.Drawing.Point(635, 160);
            this.msksdt.Mask = "(999) 000-0000";
            this.msksdt.Name = "msksdt";
            this.msksdt.Size = new System.Drawing.Size(111, 22);
            this.msksdt.TabIndex = 21;
            // 
            // cbbque
            // 
            this.cbbque.FormattingEnabled = true;
            this.cbbque.Location = new System.Drawing.Point(635, 194);
            this.cbbque.Name = "cbbque";
            this.cbbque.Size = new System.Drawing.Size(261, 24);
            this.cbbque.TabIndex = 22;
            // 
            // btxoaa
            // 
            this.btxoaa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btxoaa.Location = new System.Drawing.Point(859, 491);
            this.btxoaa.Name = "btxoaa";
            this.btxoaa.Size = new System.Drawing.Size(101, 23);
            this.btxoaa.TabIndex = 23;
            this.btxoaa.Text = "Đóng";
            this.btxoaa.UseVisualStyleBackColor = false;
            this.btxoaa.Click += new System.EventHandler(this.btxoaa_Click);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(635, 88);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(261, 22);
            this.txtdiachi.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(565, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Địa chỉ:";
            // 
            // rdogit
            // 
            this.rdogit.AutoSize = true;
            this.rdogit.Location = new System.Drawing.Point(325, 164);
            this.rdogit.Name = "rdogit";
            this.rdogit.Size = new System.Drawing.Size(58, 20);
            this.rdogit.TabIndex = 26;
            this.rdogit.Text = "Nam";
            this.rdogit.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(499, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 32);
            this.label8.TabIndex = 27;
            this.label8.Text = " NHÂN VIÊN";
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1195, 544);
            this.Controls.Add(this.mskngaysinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdogit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btxoaa);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.btboqua);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.msksdt);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.cbbque);
            this.Controls.Add(this.dtgrvnhanvien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.Nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvnhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.DataGridView dtgrvnhanvien;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btboqua;
        private System.Windows.Forms.MaskedTextBox mskngaysinh;
        private System.Windows.Forms.MaskedTextBox msksdt;
        private System.Windows.Forms.ComboBox cbbque;
        private System.Windows.Forms.Button btxoaa;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox rdogit;
        private System.Windows.Forms.Label label8;
    }
}