namespace quanlycafen1
{
    partial class nhacungcap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nhacungcap));
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.msksdt = new System.Windows.Forms.MaskedTextBox();
            this.txttenncc = new System.Windows.Forms.TextBox();
            this.txtmancc = new System.Windows.Forms.TextBox();
            this.lblsdt = new System.Windows.Forms.Label();
            this.lbldc = new System.Windows.Forms.Label();
            this.lbltenncc = new System.Windows.Forms.Label();
            this.lblmancc = new System.Windows.Forms.Label();
            this.btndong = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(82, 167);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.Size = new System.Drawing.Size(776, 156);
            this.DataGridView.TabIndex = 53;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(588, 72);
            this.txtdc.Margin = new System.Windows.Forms.Padding(4);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(132, 22);
            this.txtdc.TabIndex = 52;
            // 
            // msksdt
            // 
            this.msksdt.Location = new System.Drawing.Point(588, 111);
            this.msksdt.Margin = new System.Windows.Forms.Padding(4);
            this.msksdt.Mask = "(999) 000-0000";
            this.msksdt.Name = "msksdt";
            this.msksdt.Size = new System.Drawing.Size(132, 22);
            this.msksdt.TabIndex = 51;
            // 
            // txttenncc
            // 
            this.txttenncc.Location = new System.Drawing.Point(273, 110);
            this.txttenncc.Margin = new System.Windows.Forms.Padding(4);
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.Size = new System.Drawing.Size(132, 22);
            this.txttenncc.TabIndex = 50;
            // 
            // txtmancc
            // 
            this.txtmancc.Location = new System.Drawing.Point(273, 68);
            this.txtmancc.Margin = new System.Windows.Forms.Padding(4);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new System.Drawing.Size(132, 22);
            this.txtmancc.TabIndex = 49;
            // 
            // lblsdt
            // 
            this.lblsdt.AutoSize = true;
            this.lblsdt.Location = new System.Drawing.Point(476, 114);
            this.lblsdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsdt.Name = "lblsdt";
            this.lblsdt.Size = new System.Drawing.Size(88, 16);
            this.lblsdt.TabIndex = 48;
            this.lblsdt.Text = "Số điện thoại:";
            // 
            // lbldc
            // 
            this.lbldc.AutoSize = true;
            this.lbldc.Location = new System.Drawing.Point(476, 72);
            this.lbldc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldc.Name = "lbldc";
            this.lbldc.Size = new System.Drawing.Size(50, 16);
            this.lbldc.TabIndex = 47;
            this.lbldc.Text = "Địa chỉ:";
            // 
            // lbltenncc
            // 
            this.lbltenncc.AutoSize = true;
            this.lbltenncc.Location = new System.Drawing.Point(139, 111);
            this.lbltenncc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltenncc.Name = "lbltenncc";
            this.lbltenncc.Size = new System.Drawing.Size(117, 16);
            this.lbltenncc.TabIndex = 46;
            this.lbltenncc.Text = "Tên nhà cung cấp:";
            // 
            // lblmancc
            // 
            this.lblmancc.AutoSize = true;
            this.lblmancc.Location = new System.Drawing.Point(139, 71);
            this.lblmancc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmancc.Name = "lblmancc";
            this.lblmancc.Size = new System.Drawing.Size(112, 16);
            this.lblmancc.TabIndex = 45;
            this.lblmancc.Text = "Mã nhà cung cấp:";
            // 
            // btndong
            // 
            this.btndong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndong.Location = new System.Drawing.Point(790, 384);
            this.btndong.Margin = new System.Windows.Forms.Padding(4);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(101, 28);
            this.btndong.TabIndex = 44;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = false;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnboqua.Location = new System.Drawing.Point(657, 384);
            this.btnboqua.Margin = new System.Windows.Forms.Padding(4);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(101, 28);
            this.btnboqua.TabIndex = 43;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = false;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnluu.Location = new System.Drawing.Point(526, 384);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(94, 28);
            this.btnluu.TabIndex = 42;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsua.Location = new System.Drawing.Point(365, 384);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(112, 28);
            this.btnsua.TabIndex = 41;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnxoa.Location = new System.Drawing.Point(221, 384);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(106, 28);
            this.btnxoa.TabIndex = 40;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnthem.Location = new System.Drawing.Point(65, 384);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(118, 28);
            this.btnthem.TabIndex = 39;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 32);
            this.label1.TabIndex = 54;
            this.label1.Text = "NHÀ CUNG CẤP";
            // 
            // nhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(952, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.txtdc);
            this.Controls.Add(this.msksdt);
            this.Controls.Add(this.txttenncc);
            this.Controls.Add(this.txtmancc);
            this.Controls.Add(this.lblsdt);
            this.Controls.Add(this.lbldc);
            this.Controls.Add(this.lbltenncc);
            this.Controls.Add(this.lblmancc);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "nhacungcap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà cung cấp";
            this.Load += new System.EventHandler(this.nhacungcap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.MaskedTextBox msksdt;
        private System.Windows.Forms.TextBox txttenncc;
        private System.Windows.Forms.TextBox txtmancc;
        private System.Windows.Forms.Label lblsdt;
        private System.Windows.Forms.Label lbldc;
        private System.Windows.Forms.Label lbltenncc;
        private System.Windows.Forms.Label lblmancc;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label1;
    }
}