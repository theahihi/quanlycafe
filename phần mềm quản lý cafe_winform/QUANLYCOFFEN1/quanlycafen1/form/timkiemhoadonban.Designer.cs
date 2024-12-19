namespace quanlycafen1
{
    partial class timkiemhoadonban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timkiemhoadonban));
            this.bttimlai = new System.Windows.Forms.Button();
            this.cbbmahdb = new System.Windows.Forms.ComboBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.cbbkh = new System.Windows.Forms.ComboBox();
            this.cbbnv = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttim = new System.Windows.Forms.Button();
            this.dtgrdtkhdb = new System.Windows.Forms.DataGridView();
            this.mskngayban = new System.Windows.Forms.MaskedTextBox();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdtkhdb)).BeginInit();
            this.SuspendLayout();
            // 
            // bttimlai
            // 
            this.bttimlai.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttimlai.Location = new System.Drawing.Point(678, 452);
            this.bttimlai.Name = "bttimlai";
            this.bttimlai.Size = new System.Drawing.Size(107, 47);
            this.bttimlai.TabIndex = 28;
            this.bttimlai.Text = "Tìm kiếm lại";
            this.bttimlai.UseVisualStyleBackColor = false;
            this.bttimlai.Click += new System.EventHandler(this.bttimlai_Click);
            // 
            // cbbmahdb
            // 
            this.cbbmahdb.FormattingEnabled = true;
            this.cbbmahdb.Location = new System.Drawing.Point(225, 98);
            this.cbbmahdb.Name = "cbbmahdb";
            this.cbbmahdb.Size = new System.Drawing.Size(195, 24);
            this.cbbmahdb.TabIndex = 27;
            // 
            // btthoat
            // 
            this.btthoat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btthoat.Location = new System.Drawing.Point(821, 452);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(92, 47);
            this.btthoat.TabIndex = 26;
            this.btthoat.Text = "Thoát ";
            this.btthoat.UseVisualStyleBackColor = false;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // cbbkh
            // 
            this.cbbkh.FormattingEnabled = true;
            this.cbbkh.Location = new System.Drawing.Point(626, 114);
            this.cbbkh.Name = "cbbkh";
            this.cbbkh.Size = new System.Drawing.Size(172, 24);
            this.cbbkh.TabIndex = 25;
            // 
            // cbbnv
            // 
            this.cbbnv.FormattingEnabled = true;
            this.cbbnv.Location = new System.Drawing.Point(225, 172);
            this.cbbnv.Name = "cbbnv";
            this.cbbnv.Size = new System.Drawing.Size(195, 24);
            this.cbbnv.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tổng tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mã nhân viên bán:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ngày bán:";
            // 
            // bttim
            // 
            this.bttim.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttim.Location = new System.Drawing.Point(530, 452);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(107, 47);
            this.bttim.TabIndex = 19;
            this.bttim.Text = "Tìm kiếm ";
            this.bttim.UseVisualStyleBackColor = false;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // dtgrdtkhdb
            // 
            this.dtgrdtkhdb.AllowUserToAddRows = false;
            this.dtgrdtkhdb.AllowUserToDeleteRows = false;
            this.dtgrdtkhdb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrdtkhdb.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgrdtkhdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdtkhdb.Location = new System.Drawing.Point(12, 233);
            this.dtgrdtkhdb.Name = "dtgrdtkhdb";
            this.dtgrdtkhdb.RowHeadersWidth = 51;
            this.dtgrdtkhdb.RowTemplate.Height = 24;
            this.dtgrdtkhdb.Size = new System.Drawing.Size(940, 179);
            this.dtgrdtkhdb.TabIndex = 18;
            // 
            // mskngayban
            // 
            this.mskngayban.Location = new System.Drawing.Point(225, 135);
            this.mskngayban.Mask = "00/00/0000";
            this.mskngayban.Name = "mskngayban";
            this.mskngayban.Size = new System.Drawing.Size(151, 22);
            this.mskngayban.TabIndex = 17;
            this.mskngayban.ValidatingType = typeof(System.DateTime);
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(626, 161);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(172, 22);
            this.txttongtien.TabIndex = 16;
            this.txttongtien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttongtien_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã hoá đơn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(283, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(354, 32);
            this.label6.TabIndex = 29;
            this.label6.Text = "TÌM KIẾM HOÁ ĐƠN BÁN ";
            // 
            // timkiemhoadonban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(975, 532);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bttimlai);
            this.Controls.Add(this.cbbmahdb);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.cbbkh);
            this.Controls.Add(this.cbbnv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttim);
            this.Controls.Add(this.dtgrdtkhdb);
            this.Controls.Add(this.mskngayban);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "timkiemhoadonban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm hoá đơn bán ";
            this.Load += new System.EventHandler(this.timkiemhoadonban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdtkhdb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttimlai;
        private System.Windows.Forms.ComboBox cbbmahdb;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.ComboBox cbbkh;
        private System.Windows.Forms.ComboBox cbbnv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.DataGridView dtgrdtkhdb;
        private System.Windows.Forms.MaskedTextBox mskngayban;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}