namespace quanlycaphe.Forms
{
    partial class congdung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(congdung));
            this.btndong = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.lblmacongdung = new System.Windows.Forms.Label();
            this.lbltencongdung = new System.Windows.Forms.Label();
            this.txtmacongdung = new System.Windows.Forms.TextBox();
            this.txttencongdung = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btndong
            // 
            this.btndong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndong.Location = new System.Drawing.Point(630, 371);
            this.btndong.Margin = new System.Windows.Forms.Padding(4);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 30);
            this.btndong.TabIndex = 23;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = false;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnboqua.Location = new System.Drawing.Point(523, 371);
            this.btnboqua.Margin = new System.Windows.Forms.Padding(4);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 30);
            this.btnboqua.TabIndex = 22;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = false;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnluu.Location = new System.Drawing.Point(413, 371);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(68, 30);
            this.btnluu.TabIndex = 21;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsua.Location = new System.Drawing.Point(288, 371);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(86, 30);
            this.btnsua.TabIndex = 20;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnxoa.Location = new System.Drawing.Point(167, 371);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(80, 30);
            this.btnxoa.TabIndex = 19;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnthem.Location = new System.Drawing.Point(36, 371);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(92, 30);
            this.btnthem.TabIndex = 18;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // lblmacongdung
            // 
            this.lblmacongdung.AutoSize = true;
            this.lblmacongdung.Location = new System.Drawing.Point(193, 91);
            this.lblmacongdung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmacongdung.Name = "lblmacongdung";
            this.lblmacongdung.Size = new System.Drawing.Size(95, 16);
            this.lblmacongdung.TabIndex = 24;
            this.lblmacongdung.Text = "Mã công dụng:";
            // 
            // lbltencongdung
            // 
            this.lbltencongdung.AutoSize = true;
            this.lbltencongdung.Location = new System.Drawing.Point(193, 121);
            this.lbltencongdung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltencongdung.Name = "lbltencongdung";
            this.lbltencongdung.Size = new System.Drawing.Size(100, 16);
            this.lbltencongdung.TabIndex = 25;
            this.lbltencongdung.Text = "Tên công dụng:";
            // 
            // txtmacongdung
            // 
            this.txtmacongdung.Location = new System.Drawing.Point(324, 88);
            this.txtmacongdung.Margin = new System.Windows.Forms.Padding(4);
            this.txtmacongdung.Name = "txtmacongdung";
            this.txtmacongdung.Size = new System.Drawing.Size(133, 22);
            this.txtmacongdung.TabIndex = 26;
            // 
            // txttencongdung
            // 
            this.txttencongdung.Location = new System.Drawing.Point(324, 118);
            this.txttencongdung.Margin = new System.Windows.Forms.Padding(4);
            this.txttencongdung.Name = "txttencongdung";
            this.txttencongdung.Size = new System.Drawing.Size(133, 22);
            this.txttencongdung.TabIndex = 27;
            // 
            // DataGridView
            // 
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(56, 165);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.Size = new System.Drawing.Size(623, 174);
            this.DataGridView.TabIndex = 28;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 32);
            this.label1.TabIndex = 35;
            this.label1.Text = "DANH SÁCH CÔNG DỤNG SẢN PHẨM\r\n";
            // 
            // congdung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(738, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.txttencongdung);
            this.Controls.Add(this.txtmacongdung);
            this.Controls.Add(this.lbltencongdung);
            this.Controls.Add(this.lblmacongdung);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "congdung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Công dụng";
            this.Load += new System.EventHandler(this.congdung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label lblmacongdung;
        private System.Windows.Forms.Label lbltencongdung;
        private System.Windows.Forms.TextBox txtmacongdung;
        private System.Windows.Forms.TextBox txttencongdung;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label label1;
    }
}