namespace quanlycaphe.Forms
{
    partial class loaisp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loaisp));
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.txttenloai = new System.Windows.Forms.TextBox();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.lbltenloai = new System.Windows.Forms.Label();
            this.lblmaloai = new System.Windows.Forms.Label();
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
            this.DataGridView.Location = new System.Drawing.Point(78, 175);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.Size = new System.Drawing.Size(594, 177);
            this.DataGridView.TabIndex = 33;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // txttenloai
            // 
            this.txttenloai.Location = new System.Drawing.Point(523, 115);
            this.txttenloai.Margin = new System.Windows.Forms.Padding(4);
            this.txttenloai.Name = "txttenloai";
            this.txttenloai.Size = new System.Drawing.Size(96, 22);
            this.txttenloai.TabIndex = 32;
            // 
            // txtmaloai
            // 
            this.txtmaloai.Location = new System.Drawing.Point(181, 112);
            this.txtmaloai.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(96, 22);
            this.txtmaloai.TabIndex = 31;
            // 
            // lbltenloai
            // 
            this.lbltenloai.AutoSize = true;
            this.lbltenloai.Location = new System.Drawing.Point(455, 115);
            this.lbltenloai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltenloai.Name = "lbltenloai";
            this.lbltenloai.Size = new System.Drawing.Size(59, 16);
            this.lbltenloai.TabIndex = 30;
            this.lbltenloai.Text = "Tên loại:";
            // 
            // lblmaloai
            // 
            this.lblmaloai.AutoSize = true;
            this.lblmaloai.Location = new System.Drawing.Point(114, 115);
            this.lblmaloai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmaloai.Name = "lblmaloai";
            this.lblmaloai.Size = new System.Drawing.Size(54, 16);
            this.lblmaloai.TabIndex = 29;
            this.lblmaloai.Text = "Mã loại:";
            // 
            // btndong
            // 
            this.btndong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndong.Location = new System.Drawing.Point(634, 384);
            this.btndong.Margin = new System.Windows.Forms.Padding(4);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(84, 30);
            this.btndong.TabIndex = 28;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = false;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnboqua.Location = new System.Drawing.Point(525, 384);
            this.btnboqua.Margin = new System.Windows.Forms.Padding(4);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(84, 30);
            this.btnboqua.TabIndex = 27;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = false;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnluu.Location = new System.Drawing.Point(408, 384);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(77, 30);
            this.btnluu.TabIndex = 26;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsua.Location = new System.Drawing.Point(273, 384);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(95, 30);
            this.btnsua.TabIndex = 25;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnxoa.Location = new System.Drawing.Point(156, 384);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(80, 30);
            this.btnxoa.TabIndex = 24;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnthem.Location = new System.Drawing.Point(41, 384);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(85, 30);
            this.btnthem.TabIndex = 23;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 32);
            this.label1.TabIndex = 34;
            this.label1.Text = "DANH SÁCH LOẠI SẢN PHẨM";
            // 
            // loaisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(740, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.txttenloai);
            this.Controls.Add(this.txtmaloai);
            this.Controls.Add(this.lbltenloai);
            this.Controls.Add(this.lblmaloai);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "loaisp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại sản phẩm";
            this.Load += new System.EventHandler(this.loaisp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TextBox txttenloai;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.Label lbltenloai;
        private System.Windows.Forms.Label lblmaloai;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label1;
    }
}