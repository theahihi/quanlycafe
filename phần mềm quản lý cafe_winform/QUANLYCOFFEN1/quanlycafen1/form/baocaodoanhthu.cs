using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace quanlycafen1.form
{
    public partial class baocaodoanhthu : Form
    {
        public baocaodoanhthu()
        {
            InitializeComponent();
        }

        
        DataTable tblDT;
        private void baocaodoanhthu_Load(object sender, EventArgs e)
        {
            Load_DataGridView("select * from tbl_doanhthu");
            funtion.FillCombo("select tensanpham from tbl_sanpham", cbotensp, "tensanpham", "tensanpham");
            cbotensp.SelectedIndex = -1;
            txttongtien.Text = funtion.GetFieldValues("SELECT sum(doanhthusanpham) FROM tbl_doanhthu");
            mskngayban.Enabled = false;
            grbkhoang.Enabled = false;
            lbtongtienchu.Text = "Bằng chữ: " + funtion.ChuyenSoSangChu(txttongtien.Text);
            txttsl.Text = funtion.GetFieldValues("SELECT sum(soluongban) FROM tbl_doanhthu");
            lbltsl.Text = "Bằng chữ: " + funtion.ChuyenSoSangChu(txttsl.Text);
            txttongtien.Enabled = false;
            txttsl.Enabled = false;

        }
        private void Load_DataGridView(string sql)
        {
            tblDT = funtion.GetDataToTable(sql);
            dataGridView.DataSource = tblDT;
            dataGridView.Columns[0].HeaderText = "Ngày bán";
            
            dataGridView.Columns[1].HeaderText = "Tên sản phẩm";
            dataGridView.Columns[2].HeaderText = "Số lượng bán";
            dataGridView.Columns[3].HeaderText = "Đơn giá bán";
            dataGridView.Columns[4].HeaderText = "Doanh thu";
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void Reset()
        {
            mskngayban.Text = "";
            cbotensp.Text = "";
            txttongtien.Text = "";
            txtsoluong.Text = "0";
            txtgiaban.Text = "0";
            txtsoluong.Enabled = false;
            txtgiaban.Enabled = false;
            txtdoanhthu.Text = "0";
            txtdoanhthu.Enabled = false;
        }
       
        private void dataGridView_Click(object sender, EventArgs e)
        {
            string ma;
            
            if (tblDT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            mskngayban.Text = dataGridView.CurrentRow.Cells["ngayban"].Value.ToString();
            
            ma = dataGridView.CurrentRow.Cells["tensanpham"].Value.ToString();
            cbotensp.Text = funtion.GetFieldValues("SELECT tensanpham FROM tbl_sanpham WHERE tensanpham = N'" + ma + "'");
            
            txtsoluong.Text = dataGridView.CurrentRow.Cells["soluongban"].Value.ToString();
            txtgiaban.Text = dataGridView.CurrentRow.Cells["gia_san_pham"].Value.ToString();
            txtdoanhthu.Text = dataGridView.CurrentRow.Cells["doanhthusanpham"].Value.ToString();

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if (cbotensp.SelectedValue == null && txtgiaban.Text == "" && mskngayban.Text == "  /  /" && txtdoanhthu.Text == null && msktungay.Text == "  /  /" && mskdenngay.Text == "  /  /")
            {
                MessageBox.Show("Hãy nhập ít nhất 1 dữ liệu để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sql = "select * from tbl_doanhthu where 1=1";
            if (cbotensp.SelectedValue != null)
            {
                sql += " and tensanpham = N'" + cbotensp.Text + "'";
            }

            if (txtgiaban.Text != "")
            {
                sql += " and gia_san_pham = " + txtgiaban.Text;
            }
            if (mskngayban.Text != "  /  /")
            {
                if (!funtion.IsDate(mskngayban.Text))
                {
                    MessageBox.Show("Hãy nhập lại ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskngayban.Focus();
                    mskngayban.Text = "";
                    return;
                }
                sql += " and ngayban = '" + funtion.ConvertDateTime(mskngayban.Text) + "'";
            }
            if (msktungay.Text != "  /  /" && mskdenngay.Text != "  /  /")
            {
                if (!funtion.IsDate(mskdenngay.Text) || !funtion.IsDate(msktungay.Text))
                {
                    MessageBox.Show("Hãy nhập lại ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskdenngay.Focus();
                    mskdenngay.Text = "";
                    msktungay.Text = "";
                    return;
                }
                if (DateTime.ParseExact(msktungay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture) > DateTime.ParseExact(mskdenngay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskdenngay.Text = "";
                    msktungay.Text = "";
                    return;
                }
                sql += " and ngayban between '" + funtion.ConvertDateTime(msktungay.Text) + "' and '" + funtion.ConvertDateTime(mskdenngay.Text) + "'";
            }
            if (txtdoanhthu.Text != "")
            {
                sql += " and doanhthusanpham >= " + txtdoanhthu.Text;
            }

            Load_DataGridView(sql);
            txttongtien.Text = funtion.GetFieldValues("SELECT sum(doanhthusanpham) FROM  tbl_doanhthu WHERE " + sql.Substring(sql.IndexOf("where") + 5));
            lbtongtienchu.Text = "Bằng chữ: " + funtion.ChuyenSoSangChu(txttongtien.Text);
            txttsl.Text = funtion.GetFieldValues("SELECT sum(soluongban) FROM  tbl_doanhthu WHERE " + sql.Substring(sql.IndexOf("where") + 5));

            lbltsl.Text = "Bằng chữ: " + funtion.ChuyenSoSangChu(txttsl.Text);
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_doanhthu";
            Load_DataGridView(sql);
            funtion.FillCombo("SELECT tensanpham FROM tbl_sanpham", cbotensp, "tensanpham", "tensanpham");
            cbotensp.SelectedIndex = -1;
            txtgiaban.Text = "";
            mskngayban.Text = "";
            txtsoluong.Text = "";
            txtdoanhthu.Text = "";
            txttongtien.Text = funtion.GetFieldValues("SELECT sum(doanhthusanpham) FROM tbl_doanhthu");
            txttsl.Text = funtion.GetFieldValues("SELECT sum(soluongban) FROM tbl_doanhthu");
            rdobtkhoang.Checked = false;
            rdobtngay.Checked = false;
            mskngayban.Enabled = false;
            grbkhoang.Enabled = false;
            msktungay.Text = "";
            mskdenngay.Text = "";
            lbtongtienchu.Text = "Bằng chữ: " + funtion.ChuyenSoSangChu(txttongtien.Text);
            lbltsl.Text = "Bằng chữ: " + funtion.ChuyenSoSangChu(txttsl.Text);
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;

            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];

            exRange.Range["C10: D10:E10"].Font.Size = 14;
            exRange.Range["C10: D10:E10"].Font.Name = "Times new roman";
            exRange.Range["C10: D10:E10"].Font.Bold = true;
            exRange.Range["C10:D10:E10"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C10:D10:E10"].MergeCells = true;
            exRange.Range["C10: D10:E10"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C10: D10:E10"].Value = "Báo cáo doanh thu ";

            int rowCount = tblDT.Rows.Count;
            int colCount = tblDT.Columns.Count;

            // Phạm vi bắt đầu từ ô A1 và kết thúc ở ô cuối cùng chứa dữ liệu
            COMExcel.Range dataRange = exSheet.Range[exSheet.Cells[12, 1], exSheet.Cells[rowCount + 12, colCount + 1]];

            // Thiết lập viền cho phạm vi dữ liệu
            dataRange.Borders.LineStyle = COMExcel.XlLineStyle.xlContinuous;

            exRange.Range["H12:H12"].Value = "Tổng tiền:";

            exRange.Range["I12:I12"].Value = txttongtien.Text;

            exRange.Range["H14:H14"].Value = "Tổng số lượng:";
            exRange.Range["I14:I14"].Value = txttsl.Text;

            exRange.Range["A12:F12"].Font.Bold = true;
            exRange.Range["A12:F12"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A12:A12"].Value = "STT";
            exRange.Range["B12:B12"].Value = "Ngày bán";
            exRange.Range["B12:B12"].ColumnWidth = 9.7;
            exRange.Range["C12:C12"].Value = "Tên sản phẩm";
            exRange.Range["C12:C12"].ColumnWidth = 25;
            exRange.Range["D12:D12"].Value = "Số lượng bán";
            exRange.Range["D12:D12"].ColumnWidth = 15;
            exRange.Range["E12:E12"].Value = "Giá bán sản phẩm";
            exRange.Range["E12:E12"].ColumnWidth = 15;
            exRange.Range["F12:F12"].Value = "Doanh thu sản phẩm ";
            exRange.Range["F12:F12"].ColumnWidth = 20;

            for (hang = 0; hang < tblDT.Rows.Count; hang++)
            {
                exSheet.Cells[1][hang + 13] = hang + 1;
                for (cot = 0; cot < tblDT.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 2][hang + 13] = tblDT.Rows[hang][cot].ToString();
                }
            }
            exApp.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rdobtngay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdobtngay.Checked == true)
                mskngayban.Enabled = true;
            else
            {
                mskngayban.Enabled = false;
                mskngayban.Text = "";
            }
        }

        private void rdobtkhoang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdobtkhoang.Checked == true)
                grbkhoang.Enabled = true;
            else
            {
                grbkhoang.Enabled = false;
                msktungay.Text = "";
                mskdenngay.Text = "";
            }
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtgiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtdoanhthu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
