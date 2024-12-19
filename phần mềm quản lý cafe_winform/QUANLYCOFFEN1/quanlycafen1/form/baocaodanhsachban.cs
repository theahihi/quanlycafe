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
    public partial class baocaodanhsachban : Form
    {
        public baocaodanhsachban()
        {
            InitializeComponent();
        }
        DataTable tbhdb,tbsp;

        private void baocaodanhsachban_Load(object sender, EventArgs e)
        {
            load_datagrvid("select*from dsban");
            load_datagrvidsp("select tensanpham, sum(soluong) from dsban group by tensanpham order by sum(soluong) desc");
            funtion.FillCombo("select mahdb from tbl_hoadonban", cbbmahdb, "mahdb", "mahdb");
            funtion.FillCombo("select tensanpham from tbl_sanpham", cbbtensp, "tensanpham", "tensanpham");
            funtion.FillCombo("select tenkh from tbl_khachhang", cbbkhachhang, "tenkh", "tenkh");
            funtion.FillCombo("select tennv from tbl_nhanvien ", cbbnvban, "tennv", "tennv");
            cbbmahdb.SelectedIndex = -1;
            cbbtensp.SelectedIndex = -1;
            cbbkhachhang.SelectedIndex = -1;
            cbbnvban.SelectedIndex  = -1;
            grbkhoang.Enabled = false;
            mskngayban.Enabled = false;
        }
        private void load_datagrvidsp(string sql)
        {
            tbsp = funtion.GetDataToTable(sql);
            dtgrvdsp.DataSource = tbsp;
            dtgrvdsp.Columns[0].HeaderText = "Sản phẩm";
            dtgrvdsp.Columns[1].HeaderText = "Số lượng bán";
            dtgrvdsp.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void load_datagrvid(string sql)
        {

            tbhdb = funtion.GetDataToTable(sql);
            dtgrvidcthdb.DataSource = tbhdb;
            dtgrvidcthdb.Columns[0].HeaderText = "Mã hoá đơn";
            dtgrvidcthdb.Columns[1].HeaderText = "Tên sản phẩm";
            dtgrvidcthdb.Columns[2].HeaderText = "Mã sản phẩm";
            dtgrvidcthdb.Columns[3].HeaderText = "số lượng bán ";
            dtgrvidcthdb.Columns[4].HeaderText = "Đơn giá bán";
            dtgrvidcthdb.Columns[5].HeaderText = "Khuyến mãi";
            dtgrvidcthdb.Columns[6].HeaderText = "Thành tiền";
            dtgrvidcthdb.Columns[7].HeaderText = "Ngày bán";
            dtgrvidcthdb.Columns[8].HeaderText = "Tên Khách hàng";
            dtgrvidcthdb.Columns[9].HeaderText = "Tên nhân viên bán ";

            dtgrvidcthdb.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void bttim_Click(object sender, EventArgs e)
        {
            string sql,sql1;
            if (cbbmahdb.SelectedValue == null && cbbtensp.SelectedValue == null && txtdongiaban.Text == "" && mskngayban.Text == "  /  /" && cbbkhachhang.SelectedValue == null && cbbnvban.SelectedValue == null&& msktungay.Text == "  /  /" && msktungay.Text == "  /  /")
            {
                MessageBox.Show("Hãy nhập ít nhất 1 dữ liệu để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sql = "select * from dsban where 1=1";
            if (cbbmahdb.SelectedValue != null)
            {
                sql = sql + " and mahdb=N'" + cbbmahdb.Text + "' ";
            }
            if (cbbtensp.SelectedValue != null)
            {
                sql = sql + " and tensanpham =N'" + cbbtensp.Text + "'";
            }
            if (txtdongiaban.Text != "")
            {
                sql = sql + " and giaban =" + txtdongiaban.Text + "";
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
                sql = sql + "and ngayban='" + funtion.ConvertDateTime(mskngayban.Text) + "'";
            }
            if (msktungay.Text != "  /  /")
            {
                if (mskdenngay.Text == "  /  /")
                {
                    MessageBox.Show("Hãy nhập đến ngày ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskdenngay.Focus();
                    return;
                }
            }
            if (mskdenngay.Text != "  /  /")
            {
                if (msktungay.Text == "  /  /")
                {

                    MessageBox.Show("Hãy nhập từ ngày ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msktungay.Focus();
                    return;
                }
            }
            if (msktungay.Text != "  /  /" && mskdenngay.Text != "  /  /")
            {
                if (!funtion.IsDate(mskdenngay.Text))
                {
                    MessageBox.Show("Hãy nhập lại đến ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskdenngay.Focus();
                    mskdenngay.Text = "";
                    return;
                }
                if (!funtion.IsDate(msktungay.Text))
                {
                    MessageBox.Show("Hãy nhập lại tu ngày ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msktungay.Focus();
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
                sql = sql + "and (ngayban between'" + funtion.ConvertDateTime(msktungay.Text) + "' and '" + funtion.ConvertDateTime(mskdenngay.Text) + "')";
            }
            if (cbbkhachhang.SelectedValue != null)
            {
                sql = sql + " and tenkh =N'" + cbbkhachhang.Text + "'";
            }
            if (cbbnvban.SelectedValue != null)
            {
                sql = sql + "and tennv=N'" + cbbnvban.Text + "'";
            }
            DataTable tbbchdb;
            tbbchdb = funtion.GetDataToTable(sql);
            if (tbbchdb.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                reset();
                return;
            }
            else
            {
                MessageBox.Show("có " + tbbchdb.Rows.Count + " bản ghi cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset();
                

                load_datagrvid(sql);
                sql1 = " where 1=1";
                if (cbbmahdb.SelectedValue != null)
                {
                    sql1 = sql1 + " and mahdb=N'" + cbbmahdb.Text + "' ";
                }
                if (cbbtensp.SelectedValue != null)
                {
                    sql1 = sql1 + " and tensanpham =N'" + cbbtensp.Text + "'";
                }
                if (txtdongiaban.Text != "")
                {
                    sql1 = sql1 + " and dongia =" + txtdongiaban.Text + "";
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
                    sql1 = sql1 + "and ngayban='" + funtion.ConvertDateTime(mskngayban.Text) + "'";
                }

                if (msktungay.Text != "  /  /" && mskdenngay.Text != "  /  /")
                {
                    if (!funtion.IsDate(mskdenngay.Text))
                    {
                        MessageBox.Show("Hãy nhập lại đến ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mskdenngay.Focus();
                        mskdenngay.Text = "";
                        return;
                    }
                    if (!funtion.IsDate(msktungay.Text))
                    {
                        MessageBox.Show("Hãy nhập lại từ ngày ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        msktungay.Focus();
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
                    sql1 = sql1 + "and (ngayban between'" + funtion.ConvertDateTime(msktungay.Text) + "' and '" + funtion.ConvertDateTime(mskdenngay.Text) + "')";
                }
                if (cbbkhachhang.SelectedValue != null)
                {
                    sql1 = sql1 + " and tenkh =N'" + cbbkhachhang.Text + "'";
                }
                if (cbbnvban.SelectedValue != null)
                {
                    sql1 = sql1 + "and tennv=N'" + cbbnvban.Text + "'";
                }
                load_datagrvidsp("select tensanpham, sum(soluong) from dsban " + sql1 + " group by tensanpham order by sum(soluong) desc ");
               
            }
        }
        private void reset()
        {
            cbbmahdb.SelectedIndex = -1;
            cbbtensp.SelectedIndex = -1;
            cbbkhachhang.SelectedIndex = -1;
            cbbnvban.SelectedIndex = -1;
            txtdongiaban.Text = "";
            mskngayban.Text = "";
            rdobtkhoang.Checked = false;
            grbkhoang.Enabled = false;
            rdobtngay.Checked = false;
            mskngayban.Enabled = false;
            msktungay.Text = "";
            mskdenngay.Text = "";
        }
        private void bthienthi_Click(object sender, EventArgs e)
        {
            load_datagrvid("select*from dsban");
            load_datagrvidsp("select tensanpham, sum(soluong) from dsban group by tensanpham order by sum(soluong) desc ");
            reset();

        }

        private void btin_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tbldanhsach;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];

            exRange.Range["E10:F10:G10"].Font.Size = 14;
            exRange.Range["E10:F10:G10"].Font.Name = "Times new roman";
            exRange.Range["E10:F10:G10"].Font.Bold = true;
            exRange.Range["E10:F10:G10"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["E10:F10:G10"].MergeCells = true;
            exRange.Range["E10:F10:G10"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["E10:F10:G10"].Value = "Danh sách Bán hàng ";






            exRange.Range["A12:F12"].Font.Bold = true;
            exRange.Range["A12:F12"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A12:A12"].Value = "STT";
            exRange.Range["B12:B12"].Value = "Mã hoá đơn";
            exRange.Range["B12:B12"].ColumnWidth = 20;
            exRange.Range["C12:C12"].Value = "Tên sản phẩm";
            exRange.Range["C12:C12"].ColumnWidth = 20;
            exRange.Range["D12:D12"].Value = "Mã sản phẩm";
            exRange.Range["D12:D12"].ColumnWidth = 15;
            exRange.Range["E12:E12"].Value = "Số lượng Bán";
            exRange.Range["E12:E12"].ColumnWidth = 14;
            exRange.Range["F12:F12"].Value = "Đơn giá bán";
            exRange.Range["F12:F12"].ColumnWidth = 20;
            exRange.Range["G12:G12"].Value = "Khuyến mãi";
            exRange.Range["G12:G12"].ColumnWidth = 9.5;
            exRange.Range["H12:H12"].Value = "Thành tiền";
            exRange.Range["H12:H12"].ColumnWidth = 20;
            exRange.Range["I12:I12"].Value = "Ngày bán";
            exRange.Range["I12:I12"].ColumnWidth = 9.5;
            exRange.Range["J12:J12"].Value = "Tên khách hàng";
            exRange.Range["J12:J12"].ColumnWidth = 20;
            exRange.Range["K12:K12"].Value = "Tên nhân viên bán";
            exRange.Range["K12:K12"].ColumnWidth = 20;
            for (int row = 0; row < tbhdb.Rows.Count; row++)
            {
                exSheet.Cells[1][row + 13] = row + 1;
                for (int col = 0; col < tbhdb.Columns.Count; col++)
                {
                    if (tbhdb.Columns[col].ColumnName == "ngayban")
                    {
                       
                        DateTime ngayNhap = Convert.ToDateTime(tbhdb.Rows[row]["ngayban"]);
                        exSheet.Cells[col + 2][row + 13] = ngayNhap.ToShortDateString();
                    }
                    else
                    {
                       
                        exSheet.Cells[col + 2][row + 13] = tbhdb.Rows[row][col].ToString();
                    }
                }
            }

            for (hang = 0; hang < tbhdb.Rows.Count; hang++)
            {
                exSheet.Cells[1][hang + 13] = hang + 1;
                for (cot = 0; cot < tbhdb.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 2][hang + 13] = tbhdb.Rows[hang][cot].ToString();
                }
            }



            exRange.Range["N12:N12"].Value = "Tên sản Phẩm";
            exRange.Range["N12:N12"].ColumnWidth = 20;
            exRange.Range["O12:O12"].Value = "Số lượng bán";
            exRange.Range["N12:N12"].ColumnWidth = 20;
            for (hang = 0; hang < tbsp.Rows.Count; hang++)
            {
                exSheet.Cells[1][hang + 13] = hang + 1;
                for (cot = 0; cot < tbsp.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 14][hang + 13] = tbsp.Rows[hang][cot].ToString();
                }
            }

            exApp.Visible = true;
        }

        private void txtdongiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;

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



       
    }
}
