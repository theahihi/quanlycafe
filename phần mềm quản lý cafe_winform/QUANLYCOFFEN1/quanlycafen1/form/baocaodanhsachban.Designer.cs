﻿namespace quanlycafen1.form
{
    partial class baocaodanhsachban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(baocaodanhsachban));
            this.btin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbkhachhang = new System.Windows.Forms.ComboBox();
            this.cbbnvban = new System.Windows.Forms.ComboBox();
            this.txtdongiaban = new System.Windows.Forms.TextBox();
            this.cbbtensp = new System.Windows.Forms.ComboBox();
            this.cbbmahdb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgrvidcthdb = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mskngayban = new System.Windows.Forms.MaskedTextBox();
            this.bttim = new System.Windows.Forms.Button();
            this.bthienthi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbkhoang = new System.Windows.Forms.GroupBox();
            this.mskdenngay = new System.Windows.Forms.MaskedTextBox();
            this.msktungay = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rdobtkhoang = new System.Windows.Forms.RadioButton();
            this.rdobtngay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgrvdsp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvidcthdb)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbkhoang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvdsp)).BeginInit();
            this.SuspendLayout();
            // 
            // btin
            // 
            this.btin.Location = new System.Drawing.Point(1680, 776);
            this.btin.Name = "btin";
            this.btin.Size = new System.Drawing.Size(132, 41);
            this.btin.TabIndex = 12;
            this.btin.Text = "In báo cáo ";
            this.btin.UseVisualStyleBackColor = true;
            this.btin.Click += new System.EventHandler(this.btin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(675, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "BÁO CÁO BÁN HÀNG ";
            // 
            // cbbkhachhang
            // 
            this.cbbkhachhang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbkhachhang.FormattingEnabled = true;
            this.cbbkhachhang.Location = new System.Drawing.Point(450, 34);
            this.cbbkhachhang.Name = "cbbkhachhang";
            this.cbbkhachhang.Size = new System.Drawing.Size(152, 24);
            this.cbbkhachhang.TabIndex = 18;
            // 
            // cbbnvban
            // 
            this.cbbnvban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbnvban.FormattingEnabled = true;
            this.cbbnvban.Location = new System.Drawing.Point(450, 73);
            this.cbbnvban.Name = "cbbnvban";
            this.cbbnvban.Size = new System.Drawing.Size(152, 24);
            this.cbbnvban.TabIndex = 17;
            // 
            // txtdongiaban
            // 
            this.txtdongiaban.Location = new System.Drawing.Point(450, 119);
            this.txtdongiaban.Name = "txtdongiaban";
            this.txtdongiaban.Size = new System.Drawing.Size(152, 22);
            this.txtdongiaban.TabIndex = 16;
            this.txtdongiaban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdongiaban_KeyPress);
            // 
            // cbbtensp
            // 
            this.cbbtensp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbtensp.FormattingEnabled = true;
            this.cbbtensp.Location = new System.Drawing.Point(133, 70);
            this.cbbtensp.Name = "cbbtensp";
            this.cbbtensp.Size = new System.Drawing.Size(152, 24);
            this.cbbtensp.TabIndex = 15;
            // 
            // cbbmahdb
            // 
            this.cbbmahdb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmahdb.FormattingEnabled = true;
            this.cbbmahdb.Location = new System.Drawing.Point(133, 41);
            this.cbbmahdb.Name = "cbbmahdb";
            this.cbbmahdb.Size = new System.Drawing.Size(152, 24);
            this.cbbmahdb.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tên khách hàng";
            // 
            // dtgrvidcthdb
            // 
            this.dtgrvidcthdb.AllowUserToAddRows = false;
            this.dtgrvidcthdb.AllowUserToDeleteRows = false;
            this.dtgrvidcthdb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvidcthdb.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgrvidcthdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvidcthdb.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgrvidcthdb.Location = new System.Drawing.Point(12, 277);
            this.dtgrvidcthdb.Name = "dtgrvidcthdb";
            this.dtgrvidcthdb.RowHeadersWidth = 51;
            this.dtgrvidcthdb.RowTemplate.Height = 24;
            this.dtgrvidcthdb.Size = new System.Drawing.Size(1391, 483);
            this.dtgrvidcthdb.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nhân viên bán ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đơn giá bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên sản phẩm";
            // 
            // mskngayban
            // 
            this.mskngayban.Location = new System.Drawing.Point(857, 81);
            this.mskngayban.Mask = "00/00/0000";
            this.mskngayban.Name = "mskngayban";
            this.mskngayban.Size = new System.Drawing.Size(152, 22);
            this.mskngayban.TabIndex = 8;
            this.mskngayban.ValidatingType = typeof(System.DateTime);
            // 
            // bttim
            // 
            this.bttim.Location = new System.Drawing.Point(1123, 185);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(123, 41);
            this.bttim.TabIndex = 7;
            this.bttim.Text = "Tìm kiếm";
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // bthienthi
            // 
            this.bthienthi.Location = new System.Drawing.Point(1529, 776);
            this.bthienthi.Name = "bthienthi";
            this.bthienthi.Size = new System.Drawing.Size(123, 41);
            this.bthienthi.TabIndex = 11;
            this.bthienthi.Text = "Hiển Thị";
            this.bthienthi.UseVisualStyleBackColor = true;
            this.bthienthi.Click += new System.EventHandler(this.bthienthi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grbkhoang);
            this.groupBox1.Controls.Add(this.rdobtkhoang);
            this.groupBox1.Controls.Add(this.rdobtngay);
            this.groupBox1.Controls.Add(this.cbbkhachhang);
            this.groupBox1.Controls.Add(this.cbbnvban);
            this.groupBox1.Controls.Add(this.txtdongiaban);
            this.groupBox1.Controls.Add(this.bttim);
            this.groupBox1.Controls.Add(this.cbbtensp);
            this.groupBox1.Controls.Add(this.cbbmahdb);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mskngayban);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(220, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1246, 226);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "tìm kiếm ";
            // 
            // grbkhoang
            // 
            this.grbkhoang.Controls.Add(this.mskdenngay);
            this.grbkhoang.Controls.Add(this.msktungay);
            this.grbkhoang.Controls.Add(this.label2);
            this.grbkhoang.Controls.Add(this.label9);
            this.grbkhoang.Location = new System.Drawing.Point(801, 27);
            this.grbkhoang.Name = "grbkhoang";
            this.grbkhoang.Size = new System.Drawing.Size(420, 38);
            this.grbkhoang.TabIndex = 29;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Đến";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Từ";
            // 
            // rdobtkhoang
            // 
            this.rdobtkhoang.AutoSize = true;
            this.rdobtkhoang.Location = new System.Drawing.Point(679, 36);
            this.rdobtkhoang.Name = "rdobtkhoang";
            this.rdobtkhoang.Size = new System.Drawing.Size(108, 20);
            this.rdobtkhoang.TabIndex = 28;
            this.rdobtkhoang.TabStop = true;
            this.rdobtkhoang.Text = "Theo khoảng";
            this.rdobtkhoang.UseVisualStyleBackColor = true;
            this.rdobtkhoang.CheckedChanged += new System.EventHandler(this.rdobtkhoang_CheckedChanged);
            // 
            // rdobtngay
            // 
            this.rdobtngay.AutoSize = true;
            this.rdobtngay.Location = new System.Drawing.Point(679, 81);
            this.rdobtngay.Name = "rdobtngay";
            this.rdobtngay.Size = new System.Drawing.Size(96, 20);
            this.rdobtngay.TabIndex = 27;
            this.rdobtngay.TabStop = true;
            this.rdobtngay.Text = "Theo ngày ";
            this.rdobtngay.UseVisualStyleBackColor = true;
            this.rdobtngay.CheckedChanged += new System.EventHandler(this.rdobtngay_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hoá đơn";
            // 
            // dtgrvdsp
            // 
            this.dtgrvdsp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvdsp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgrvdsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvdsp.Location = new System.Drawing.Point(1447, 277);
            this.dtgrvdsp.Name = "dtgrvdsp";
            this.dtgrvdsp.RowHeadersWidth = 51;
            this.dtgrvdsp.RowTemplate.Height = 24;
            this.dtgrvdsp.Size = new System.Drawing.Size(365, 483);
            this.dtgrvdsp.TabIndex = 13;
            // 
            // baocaodanhsachban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.dtgrvdsp);
            this.Controls.Add(this.btin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgrvidcthdb);
            this.Controls.Add(this.bthienthi);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "baocaodanhsachban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo bán hàng ";
            this.Load += new System.EventHandler(this.baocaodanhsachban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvidcthdb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbkhoang.ResumeLayout(false);
            this.grbkhoang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvdsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbkhachhang;
        private System.Windows.Forms.ComboBox cbbnvban;
        private System.Windows.Forms.TextBox txtdongiaban;
        private System.Windows.Forms.ComboBox cbbtensp;
        private System.Windows.Forms.ComboBox cbbmahdb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgrvidcthdb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskngayban;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Button bthienthi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbkhoang;
        private System.Windows.Forms.MaskedTextBox mskdenngay;
        private System.Windows.Forms.MaskedTextBox msktungay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdobtkhoang;
        private System.Windows.Forms.RadioButton rdobtngay;
        private System.Windows.Forms.DataGridView dtgrvdsp;
    }
}