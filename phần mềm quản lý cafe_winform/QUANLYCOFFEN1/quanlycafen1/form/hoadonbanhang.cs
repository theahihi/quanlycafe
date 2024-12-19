using quanlycafen1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace quandidulieu
{
    public partial class frmhoadonbanhang : Form
    {
        public frmhoadonbanhang()
        {
            InitializeComponent();
        }
        DataTable tblHDB;

        private void frmhoadonbanhang_Load(object sender, EventArgs e)
        {
            btnthemhoadon.Enabled = true;
            btnluu.Enabled = false;
            btnhuyhoadon.Enabled = false;
            btninhoadon.Enabled = false;
            txtmahoadon.ReadOnly = true;
            txttennhanvien.ReadOnly = true;
            txttenkhachhang.ReadOnly = true;
            txtdiachi.ReadOnly = true;
            txtdienthoai.ReadOnly = true;
            txttensanpham.ReadOnly = true;
            txtdongia.ReadOnly = true;
            txtthanhtien.ReadOnly = true;
            txttongtien.ReadOnly = true;
            txtkhuyenmai.Text = "0";
            txttongtien.Text = "0";
            funtion.FillCombo("SELECT makh, Tenkh FROM tbl_khachhang", cbbmakhachhang, "makh", "makh");
            cbbmakhachhang.SelectedIndex = -1;
            funtion.FillCombo("SELECT manv, tennv FROM tbl_nhanvien", cbbmanhanvien, "manv", "manv");
            cbbmanhanvien.SelectedIndex = -1;
            funtion.FillCombo("SELECT masanpham, tensanpham FROM tbl_sanpham", cbbmasanpham, "masanpham", "masanpham");
            cbbmasanpham.SelectedIndex = -1;
            funtion.FillCombo("SELECT mahdb FROM tbl_hoadonban", cbbmahoadon, "mahdb", "mahdb");
            cbbmahoadon.SelectedIndex = -1;
            if (txtmahoadon.Text != "")
            {
                Load_ThongtinHD();
                btnhuyhoadon.Enabled = true;
                btninhoadon.Enabled = true;
            }
            Load_dtgrvchitiet();
        }
        private void Load_dtgrvchitiet()
        {
            string sql;
            sql = "SELECT a.masanpham, b.tensanpham, a.soluong, b.giaban, a.khuyenmai, a.thanhtien FROM tbl_chitiethoadonban AS a, tbl_sanpham AS b WHERE a.mahdb = N'" + txtmahoadon.Text + "' AND a.masanpham=b.masanpham";
            tblHDB= funtion.GetDataToTable(sql);
            dtgrvchitiet.DataSource = tblHDB;
            dtgrvchitiet.Columns[0].HeaderText = "Mã Sản Phẩm ";
            dtgrvchitiet.Columns[1].HeaderText = "Tên Sản phẩm";
            dtgrvchitiet.Columns[2].HeaderText = "Số lượng";
            dtgrvchitiet.Columns[3].HeaderText = "Đơn giá";
            dtgrvchitiet.Columns[4].HeaderText = "Khuyến mãi %";
            dtgrvchitiet.Columns[5].HeaderText = "Thành tiền";
            dtgrvchitiet.AllowUserToAddRows = false;
            dtgrvchitiet.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void Load_ThongtinHD()
        {
            string str;
            str = "SELECT ngayban FROM tbl_hoadonban WHERE mahdb = N'" + txtmahoadon.Text + "'";
            txtngayban.Text = funtion.ConvertDateTime(funtion.GetFieldValues(str));
            str = "SELECT manv FROM tbl_hoadonban WHERE Mahdb = N'" + txtmahoadon.Text + "'";
            cbbmanhanvien.Text = funtion.GetFieldValues(str);

            str = "SELECT makh FROM tbl_hoadonban WHERE mahdb = N'" + txtmahoadon.Text + "'";
            cbbmakhachhang.Text = funtion.GetFieldValues(str);

            str = "SELECT tongtien FROM tbl_hoadonban WHERE mahdb = N'" + txtmahoadon.Text + "'";
            txttongtien.Text = funtion.GetFieldValues(str);

            lblbangchu.Text = "Bằng chữ: " + funtion.ChuyenSoSangChu(txttongtien.Text);
        }
        private void ResetValues()

        {
            txtmahoadon.Text = "";
            txtngayban.Text = DateTime.Now.ToShortDateString();
            cbbmanhanvien.SelectedIndex = -1;
            txttennhanvien.Text = "";
            cbbmakhachhang.SelectedIndex = -1;
            txttenkhachhang.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            txttongtien.Text = "0";
            lblbangchu.Text = "Bằng chữ: ";
            cbbmasanpham.SelectedIndex = -1;
            txttensanpham.Text = "";
            txtdongia.Text = "";
            txtsoluong.Text = "";
            txtkhuyenmai.Text = "0";
            txtthanhtien.Text = "0";
        }
        private void ResetValuesHang()
        {
            cbbmasanpham.Text = "";
            txtsoluong.Text = "";
            txtkhuyenmai.Text = "0";
            txtthanhtien.Text = "0";
        }

        private void btnthemhoadon_Click(object sender, EventArgs e)
        {
            btnhuyhoadon.Enabled = false;
            btnluu.Enabled = true;
            btninhoadon.Enabled = false;
            btnthemhoadon.Enabled = false;
            ResetValues();
            txtmahoadon.Text = funtion.CreateKey("HDB");
            Load_dtgrvchitiet();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT mahdb FROM tbl_hoadonban WHERE mahdb=N'" + txtmahoadon.Text + "'";
            if (!funtion.CheckKey(sql))
            {
                if (txtngayban.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtngayban.Focus();
                    return;
                }
                if (cbbmanhanvien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbbmanhanvien.Focus();
                    return;
                }
                if (cbbmakhachhang.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbbmakhachhang.Focus();
                    return;
                }
                sql = "INSERT INTO tbl_hoadonban(mahdb, ngayban, manv, makh, tongtien) " +
                    "VALUES(N'" + txtmahoadon.Text.Trim() + "','" + funtion.ConvertDateTime(txtngayban.Text.Trim()) + "',N'" + cbbmanhanvien.SelectedValue + "',N'" + cbbmakhachhang.SelectedValue + "','" + txttongtien.Text + "')";
                funtion.RunSql(sql);
            }
            if (cbbmasanpham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbmasanpham.Focus();
                return;
            }
            if ((txtsoluong.Text.Trim().Length == 0) || (txtsoluong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtsoluong.Text = "";
                txtsoluong.Focus();
                return;
            }
            if (txtkhuyenmai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtkhuyenmai.Focus();
                return;
            }
            sql = "SELECT masanpham FROM tbl_chitiethoadonban WHERE masanpham=N'" +
            cbbmasanpham.SelectedValue + "' AND mahdb = N'" + txtmahoadon.Text.Trim() + "'";
            if (funtion.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValuesHang();
                cbbmasanpham.Focus();
                return;
            }
            sl = Convert.ToDouble(funtion.GetFieldValues("SELECT soluong FROM tbl_sanpham WHERE masanpham = N'" + cbbmasanpham.SelectedValue + "'"));
            if (Convert.ToDouble(txtsoluong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluong.Text = "";
                txtsoluong.Focus();
                return;
            }
            sql = "INSERT INTO tbl_chitiethoadonban(mahdb,masanpham,soluong,khuyenmai,thanhtien)" +
                 "VALUES(N'" + txtmahoadon.Text.Trim() + "', N'" + cbbmasanpham.SelectedValue + "'," + txtsoluong.Text + "," + txtkhuyenmai.Text + "," + txtthanhtien.Text + ")";
            funtion.RunSql(sql);
            Load_dtgrvchitiet();
            SLcon = sl - Convert.ToDouble(txtsoluong.Text);
            sql = "UPDATE tbl_sanpham SET soluong =" + SLcon + " WHERE masanpham= N'" + cbbmasanpham.SelectedValue + "'";
            funtion.RunSql(sql);
            tong = Convert.ToDouble(funtion.GetFieldValues("SELECT tongtien FROM tbl_hoadonban WHERE mahdb = N'" + txtmahoadon.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtthanhtien.Text);
            sql = "UPDATE tbl_hoadonban SET tongtien =" + Tongmoi + " WHERE mahdb = N'" +
            txtmahoadon.Text + "'";
            funtion.RunSql(sql);
            txttongtien.Text = Tongmoi.ToString();
            lblbangchu.Text = "Bằng chữ: " + funtion.ChuyenSoSangChu(Tongmoi.ToString());
            ResetValuesHang();
            btnhuyhoadon.Enabled = true;
            btnthemhoadon.Enabled = true;
            btninhoadon.Enabled = true;
        }

        private void cbbmanhanvien_TextChanged(object sender, EventArgs e)
        {
            string str;

            if (cbbmanhanvien.Text == "")
                txttennhanvien.Text = "";
            str = "Select tennv from tbl_nhanvien where manv =N'" +
            cbbmanhanvien.SelectedValue + "'";
            txttennhanvien.Text = funtion.GetFieldValues(str);
        }

        private void cbbmakhachhang_TextChanged(object sender, EventArgs e)
        {
            string str;

            if (cbbmanhanvien.Text == "")
            {
                txttenkhachhang.Text = "";
                txtdiachi.Text = "";
                txtdienthoai.Text = "";
            }
            str = "Select tenkh from tbl_khachhang where makh = N'" + cbbmakhachhang.SelectedValue + "'";
            txttenkhachhang.Text = funtion.GetFieldValues(str);
            str = "Select diachi from tbl_khachhang where makh = N'" + cbbmakhachhang.SelectedValue + "'";
            txtdiachi.Text = funtion.GetFieldValues(str);
            str = "Select sodienthoai from tbl_khachhang where makh= N'" + cbbmakhachhang.SelectedValue + "'";
            txtdienthoai.Text = funtion.GetFieldValues(str);
        }

        private void cbbmasanpham_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbbmasanpham.Text == "")
            {
                txttensanpham.Text = "";
                txtdongia.Text = "";
            }
            str = "SELECT tensanpham  FROM tbl_sanpham WHERE masanpham =N'" + cbbmasanpham.SelectedValue + "'";
            txttensanpham.Text = funtion.GetFieldValues(str);
            str = "SELECT giaban FROM tbl_sanpham WHERE masanpham =N'" + cbbmasanpham.SelectedValue + "'";
            txtdongia.Text = funtion.GetFieldValues(str);
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtsoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtsoluong.Text);
            if (txtkhuyenmai.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtkhuyenmai.Text);
            if (txtdongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtdongia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtthanhtien.Text = tt.ToString();
        }

        private void txtkhuyenmai_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtsoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtsoluong.Text);
            if (txtkhuyenmai.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtkhuyenmai.Text);
            if (txtdongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtdongia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtthanhtien.Text = tt.ToString();
        }

        private void DelHang(string mahdb, string masanpham)
        {
            Double s, sl, SLcon;
            string sql;
            sql = "SELECT soluong FROM tbl_chitiethoadonban WHERE mahdb = N'" + mahdb + "' AND masanpham = N'" + masanpham + "'";
            s = Convert.ToDouble(funtion.GetFieldValues(sql));
            sql = "DELETE From tbl_chitiethoadonban WHERE mahdb=N'" + mahdb + "' AND masanpham = N'" + masanpham + "'";
            funtion.RunSql(sql);
            sql = "SELECT soluong FROM tbl_sanpham WHERE masanpham = N'" + masanpham + "'";
            sl = Convert.ToDouble(funtion.GetFieldValues(sql));
            SLcon = sl + s;
            sql = "UPDATE tbl_sanpham SET soluong =" + SLcon + " WHERE masanpham= N'" + masanpham + "'";
            funtion.RunSql(sql);
        }
        private void DelUpdateTongtien(string Mahoadon, double Thanhtien)
        {
            Double Tong, Tongmoi;
            string sql;
            sql = "SELECT tongtien FROM tbl_hoadonban WHERE mahdb = N'" + Mahoadon + "'";
            Tong = Convert.ToDouble(funtion.GetFieldValues(sql));
            Tongmoi = Tong - Thanhtien;
            sql = "UPDATE tbl_hoadonban SET tongtien =" + Tongmoi + " WHERE mahdb = N'" +
            Mahoadon + "'";
            funtion.RunSql(sql);
            txttongtien.Text = Tongmoi.ToString();
            lblbangchu.Text = "Bằng chữ: " + funtion.ChuyenSoSangChu(Tongmoi.ToString());
        }

        private void dtgrvchitiet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string masanpham;
            Double Thanhtien;
            if (tblHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng
                masanpham = dtgrvchitiet.CurrentRow.Cells["masanpham"].Value.ToString();
                DelHang(txtmahoadon.Text, masanpham);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                Thanhtien = Convert.ToDouble(dtgrvchitiet.CurrentRow.Cells["thanhtien"].Value.ToString());
                DelUpdateTongtien(txtmahoadon.Text, Thanhtien);
                Load_dtgrvchitiet();
            }
        }

        private void btnhuyhoadon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string[] masanpham = new string[20];
                string sql;
                int n = 0;
                int i;
                sql = "SELECT masanpham FROM tbl_chitiethoadonban WHERE mahdb = N'" +
                txtmahoadon.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, funtion.conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                   masanpham[n] = reader.GetString(0).ToString();
                    n = n + 1;
                }
                reader.Close();
                for (i = 0; i <= n - 1; i++) DelHang(txtmahoadon.Text, masanpham[i]);
                sql = "DELETE tbl_hoadonban WHERE Mahdb=N'" + txtmahoadon.Text + "'";
                funtion.RunSql (sql);
                ResetValues();
                Load_dtgrvchitiet();
                btnhuyhoadon.Enabled = false;
                btninhoadon.Enabled = false;

            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (cbbmahoadon.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbmahoadon.Focus();
                return;
            }
            txtmahoadon.Text = cbbmahoadon.Text;
            Load_ThongtinHD();
            Load_dtgrvchitiet();
            btnhuyhoadon.Enabled = true;
            btnluu.Enabled = true;
            btninhoadon.Enabled = true;
            cbbmahoadon.SelectedIndex = -1;
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtkhuyenmai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void cbbmahoadon_DropDown(object sender, EventArgs e)
        {
            funtion.FillCombo("SELECT mahdb FROM tbl_hoadonban", cbbmahoadon, "mahdb","mahdb");
            cbbmahoadon.SelectedIndex = -1;
        }

        private void frmhoadonbanhang_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetValues();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn thực sự muốn đóng ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtdongia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btninhoadon_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; 
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Quan ca phe";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Đống Đa - Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (076)2417148";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3;
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            sql = "SELECT a.mahdb, a.ngayban, a.tongtien, b.tenkh, b.diachi,b.sodienthoai, c.tennv FROM tbl_hoadonban AS a, tbl_khachhang AS b, tbl_nhanvien AS c WHERE a.Mahdb = N'" + txtmahoadon.Text + "' AND a.makh = b.makh AND a.manv =c.manv";

            tblThongtinHD = funtion.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;   
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            
           
            sql = "SELECT b.tensanpham, a.soluong, b.giaban, a.khuyenmai, a.thanhtien FROM tbl_chitiethoadonban AS a , tbl_sanpham AS b WHERE a.mahdb = N'" + txtmahoadon.Text + "' AND a.masanpham = b.masanpham";
            tblThongtinHang = funtion.GetDataToTable(sql);
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang <= tblThongtinHang.Rows.Count - 1; hang++)
            {
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblThongtinHang.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                   exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + funtion.ChuyenSoSangChu
            (tblThongtinHD.Rows[0][2].ToString());
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + "năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
          
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }

        private void dtgrvchitiet_DoubleClick(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }   
}
