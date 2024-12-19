namespace quanlycafen1
{
    partial class timkiemhdn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timkiemhdn));
            this.label1 = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.mskngaynhap = new System.Windows.Forms.MaskedTextBox();
            this.dtgrdtkhdn = new System.Windows.Forms.DataGridView();
            this.bttim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbnv = new System.Windows.Forms.ComboBox();
            this.cbbncc = new System.Windows.Forms.ComboBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.cbbmahdn = new System.Windows.Forms.ComboBox();
            this.bttimlai = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdtkhdn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hoá đơn:";
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(601, 172);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(172, 22);
            this.txttongtien.TabIndex = 1;
            this.txttongtien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttongtien_KeyPress);
            // 
            // mskngaynhap
            // 
            this.mskngaynhap.Location = new System.Drawing.Point(211, 151);
            this.mskngaynhap.Mask = "00/00/0000";
            this.mskngaynhap.Name = "mskngaynhap";
            this.mskngaynhap.Size = new System.Drawing.Size(151, 22);
            this.mskngaynhap.TabIndex = 3;
            this.mskngaynhap.ValidatingType = typeof(System.DateTime);
            // 
            // dtgrdtkhdn
            // 
            this.dtgrdtkhdn.AllowUserToAddRows = false;
            this.dtgrdtkhdn.AllowUserToDeleteRows = false;
            this.dtgrdtkhdn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrdtkhdn.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgrdtkhdn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdtkhdn.Location = new System.Drawing.Point(12, 244);
            this.dtgrdtkhdn.Name = "dtgrdtkhdn";
            this.dtgrdtkhdn.RowHeadersWidth = 51;
            this.dtgrdtkhdn.RowTemplate.Height = 24;
            this.dtgrdtkhdn.Size = new System.Drawing.Size(852, 150);
            this.dtgrdtkhdn.TabIndex = 4;
            // 
            // bttim
            // 
            this.bttim.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttim.Location = new System.Drawing.Point(420, 426);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(107, 47);
            this.bttim.TabIndex = 5;
            this.bttim.Text = "Tìm kiếm ";
            this.bttim.UseVisualStyleBackColor = false;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã nhân viên nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã nhà cung cấp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tổng tiền:";
            // 
            // cbbnv
            // 
            this.cbbnv.FormattingEnabled = true;
            this.cbbnv.Location = new System.Drawing.Point(211, 194);
            this.cbbnv.Name = "cbbnv";
            this.cbbnv.Size = new System.Drawing.Size(195, 24);
            this.cbbnv.TabIndex = 10;
            // 
            // cbbncc
            // 
            this.cbbncc.FormattingEnabled = true;
            this.cbbncc.Location = new System.Drawing.Point(601, 116);
            this.cbbncc.Name = "cbbncc";
            this.cbbncc.Size = new System.Drawing.Size(172, 24);
            this.cbbncc.TabIndex = 11;
            // 
            // btthoat
            // 
            this.btthoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btthoat.Location = new System.Drawing.Point(710, 426);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(92, 47);
            this.btthoat.TabIndex = 12;
            this.btthoat.Text = "Thoát ";
            this.btthoat.UseVisualStyleBackColor = false;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // cbbmahdn
            // 
            this.cbbmahdn.FormattingEnabled = true;
            this.cbbmahdn.Location = new System.Drawing.Point(211, 105);
            this.cbbmahdn.Name = "cbbmahdn";
            this.cbbmahdn.Size = new System.Drawing.Size(195, 24);
            this.cbbmahdn.TabIndex = 13;
            // 
            // bttimlai
            // 
            this.bttimlai.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttimlai.Location = new System.Drawing.Point(570, 426);
            this.bttimlai.Name = "bttimlai";
            this.bttimlai.Size = new System.Drawing.Size(107, 47);
            this.bttimlai.TabIndex = 14;
            this.bttimlai.Text = "Tìm kiếm lại";
            this.bttimlai.UseVisualStyleBackColor = false;
            this.bttimlai.Click += new System.EventHandler(this.bttimlai_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(230, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(366, 32);
            this.label6.TabIndex = 30;
            this.label6.Text = "TÌM KIẾM HOÁ ĐƠN NHẬP";
            // 
            // timkiemhdn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(876, 531);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bttimlai);
            this.Controls.Add(this.cbbmahdn);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.cbbncc);
            this.Controls.Add(this.cbbnv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttim);
            this.Controls.Add(this.dtgrdtkhdn);
            this.Controls.Add(this.mskngaynhap);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "timkiemhdn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm hoá đơn nhập ";
            this.Load += new System.EventHandler(this.timkiemhdn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdtkhdn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.MaskedTextBox mskngaynhap;
        private System.Windows.Forms.DataGridView dtgrdtkhdn;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbnv;
        private System.Windows.Forms.ComboBox cbbncc;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.ComboBox cbbmahdn;
        private System.Windows.Forms.Button bttimlai;
        private System.Windows.Forms.Label label6;
    }
}