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


namespace quanlycafen1
{
    public partial class formbaocaonhaphang : Form
    {
        public formbaocaonhaphang()
        {
            InitializeComponent();
        }
        DataTable tbhdn,tbsp;

        private void formbaocaonhaphang_Load(object sender, EventArgs e)
        {
            load_datagrvid("select *from dsnhap");
            load_datagrvidsp("select tensanpham, sum(soluong) from dsnhap group by tensanpham ");
            funtion.FillCombo("select mahdn from tbl_hoadonnhap ",cbbmahdn,"mahdn", "mahdn");
            funtion.FillCombo("select tensanpham from tbl_sanpham ",cbbtensp, "tensanpham", "tensanpham");
            funtion.FillCombo("select tennv from tbl_nhanvien ", cbbnhanviennhap, "tennv", "tennv");
            funtion.FillCombo("select tenncc from tbl_ncc ", cbbncc, "tenncc", "tenncc");
            cbbmahdn.SelectedIndex = -1;
            cbbtensp.SelectedIndex = -1;
            cbbnhanviennhap.SelectedIndex = -1;
            cbbncc.SelectedIndex = -1;
            grbkhoang.Enabled = false;
            mskngaynhap.Enabled = false;
        }
        private void load_datagrvidsp(string sql)
        {
            tbsp = funtion.GetDataToTable(sql);
            dtgrvdsp.DataSource = tbsp;
            dtgrvdsp.Columns[0].HeaderText = "Sản phẩm";
            dtgrvdsp.Columns[1].HeaderText = "Số lượng nhập";
            dtgrvdsp.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void load_datagrvid(string sql )
        {
            
            tbhdn= funtion.GetDataToTable(sql);
            dtgrvidcthdn.DataSource = tbhdn;
            dtgrvidcthdn.Columns[0].HeaderText = "Mã hoá đơn";
            dtgrvidcthdn.Columns[1].HeaderText = "Tên sản phẩm";
            dtgrvidcthdn.Columns[2].HeaderText = "Mã sản phẩm";
            dtgrvidcthdn.Columns[3].HeaderText = "số lượng";
            dtgrvidcthdn.Columns[4].HeaderText = "Đơn giá nhập";
            dtgrvidcthdn.Columns[5].HeaderText = "Thành tiền";
            dtgrvidcthdn.Columns[6].HeaderText = "Chiết khấu";
            dtgrvidcthdn.Columns[7].HeaderText = "Ngày nhập";
            dtgrvidcthdn.Columns[8].HeaderText = "Tên nhân viên nhập";
            dtgrvidcthdn.Columns[9].HeaderText = "Tên nhà cung cấp";

            dtgrvidcthdn.EditMode = DataGridViewEditMode.EditProgrammatically; 

        }

        private void bttim_Click(object sender, EventArgs e)
        {
            string sql,sql1;
            if (cbbmahdn.SelectedValue == null && cbbtensp.SelectedValue == null && txtdongianhap.Text == "" && mskngaynhap.Text == "  /  /" && cbbncc.SelectedValue == null && cbbnhanviennhap.SelectedValue == null&&msktungay.Text== "  /  /"&&msktungay.Text== "  /  /")
            {
                MessageBox.Show("Hãy nhập ít nhất 1 dữ liệu để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            sql = "select * from dsnhap where 1=1";  
            if (cbbmahdn.SelectedValue != null)
            {
                sql = sql + " and mahdn=N'" + cbbmahdn.Text + "' ";
            }
            if (cbbtensp.SelectedValue != null)
            {
                sql = sql + " and tensanpham =N'" + cbbtensp.Text + "'";
            }
            if (txtdongianhap.Text != "")
            {
                sql = sql + " and dongia =" + txtdongianhap.Text + "";
            }
            if(mskngaynhap.Text!= "  /  /")
            {
                if (!funtion.IsDate(mskngaynhap.Text))
                {
                    MessageBox.Show("Hãy nhập lại ngày nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskngaynhap.Focus();
                    mskngaynhap.Text = "";
                    return;
                }
                sql = sql + "and ngaynhap='" + funtion.ConvertDateTime(mskngaynhap.Text) + "'";
            }
            if(msktungay.Text!= "  /  /")
            {
                if(mskdenngay.Text== "  /  /")
                {
                    MessageBox.Show("Hãy nhập đến ngày ","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskdenngay.Focus();
                    return;
                }
            }
            if(mskdenngay.Text!= "  /  /")
            {
                if(msktungay.Text== "  /  /")
                {

                    MessageBox.Show("Hãy nhập từ ngày ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msktungay.Focus();
                    return;
                }
            }
            if(msktungay.Text!= "  /  /"&&mskdenngay.Text!= "  /  /")
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
                if (DateTime.ParseExact(msktungay.Text, "dd/MM/yyyy",CultureInfo.InvariantCulture) > DateTime.ParseExact(mskdenngay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskdenngay.Text = "";
                    msktungay.Text = "";
                    return;
                }
                sql = sql + "and (ngaynhap between'" + funtion.ConvertDateTime(msktungay.Text) + "' and '"+funtion.ConvertDateTime(mskdenngay.Text)+"')";
            }
            if (cbbncc.SelectedValue != null)
            {
                sql = sql + " and tenncc =N'" + cbbncc.Text + "'";
            }
            if(cbbnhanviennhap.SelectedValue != null)
            {
                sql = sql + "and tennv=N'" + cbbnhanviennhap.Text + "'";
            }
            DataTable tbbchdn;
            tbbchdn= funtion.GetDataToTable(sql);
            if (tbbchdn.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                reset();
                return;
            }
            else
            {
                MessageBox.Show("có "+tbbchdn.Rows.Count+" bản ghi cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset();
                load_datagrvid(sql);
                sql1 = " where 1=1";
                if (cbbmahdn.SelectedValue != null)
                {
                    sql1 = sql1 + " and mahdn=N'" + cbbmahdn.Text + "' ";
                }
                if (cbbtensp.SelectedValue != null)
                {
                    sql1 = sql1 + " and tensanpham =N'" + cbbtensp.Text + "'";
                }
                if (txtdongianhap.Text != "")
                {
                    sql1 = sql1 + " and dongia =" + txtdongianhap.Text + "";
                }
                if (mskngaynhap.Text != "  /  /")
                {
                    if (!funtion.IsDate(mskngaynhap.Text))
                    {
                        MessageBox.Show("Hãy nhập lại ngày nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mskngaynhap.Focus();
                        mskngaynhap.Text = "";
                        return;
                    }
                    sql1 = sql1 + "and ngaynhap='" + funtion.ConvertDateTime(mskngaynhap.Text) + "'";
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
                    sql1 = sql1 + "and (ngaynhap between'" + funtion.ConvertDateTime(msktungay.Text) + "' and '" + funtion.ConvertDateTime(mskdenngay.Text) + "')";
                }
                if (cbbncc.SelectedValue != null)
                {
                    sql1 = sql1 + " and tenncc =N'" + cbbncc.Text + "'";
                }
                if (cbbnhanviennhap.SelectedValue != null)
                {
                    sql1 = sql1 + "and tennv=N'" + cbbnhanviennhap.Text + "'";
                }
                load_datagrvidsp("select tensanpham, sum(soluong) from dsnhap " + sql1 + " group by tensanpham");

                if (tbhdn.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    load_datagrvid("select*from dsnhap");
                    reset();
                    return;
                }
            }
        }

        private void btin_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            //DataTable  tbldanhsach;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];
            
            exRange.Range["E10:F10:G10"].Font.Size = 14;
            exRange.Range["E10:F10:G10"].Font.Name = "Times new roman";
            exRange.Range["E10:F10:G10"].Font.Bold = true;
            exRange.Range["E10:F10:G10"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["E10:F10:G10"].MergeCells = true;
            exRange.Range["E10:F10:G10"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["E10:F10:G10"].Value = "Danh sách nhập hàng ";




            
           
            exRange.Range["A12:F12"].Font.Bold = true;
            exRange.Range["A12:F12"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A12:A12"].Value = "STT";
            exRange.Range["B12:B12"].Value = "Mã hoá đơn";
            exRange.Range["B12:B12"].ColumnWidth = 20;
            exRange.Range["C12:C12"].Value = "Tên sản phẩm";
            exRange.Range["C12:C12"].ColumnWidth = 20;
            exRange.Range["D12:D12"].Value = "Mã sản phẩm";
            exRange.Range["D12:D12"].ColumnWidth = 15;
            exRange.Range["E12:E12"].Value = "Số lượng";
            exRange.Range["E12:E12"].ColumnWidth = 14;
            exRange.Range["F12:F12"].Value = "Đơn giá nhập";
            exRange.Range["F12:F12"].ColumnWidth = 20;
            exRange.Range["G12:G12"].Value = "Thành tiền";
            exRange.Range["G12:G12"].ColumnWidth = 20;
            exRange.Range["H12:H12"].Value = "Chiết khấu";
            exRange.Range["H12:H12"].ColumnWidth = 9.5;
            exRange.Range["I12:I12"].Value = "Ngày nhập";
            exRange.Range["I12:I12"].ColumnWidth = 9.5;
            exRange.Range["J12:J12"].Value = "Tên nhân viên";
            exRange.Range["J12:J12"].ColumnWidth = 20;
            exRange.Range["K12:K12"].Value = "Tên nhà cung cấp";
            exRange.Range["K12:K12"].ColumnWidth = 20;
            for (int row = 0; row < tbhdn.Rows.Count; row++)
            {
                exSheet.Cells[1][row + 13] = row + 1;
                for (int col = 0; col < tbhdn.Columns.Count; col++)
                {
                    if (tbhdn.Columns[col].ColumnName == "ngaynhap")
                    {
                     
                        DateTime ngayNhap = Convert.ToDateTime(tbhdn.Rows[row]["ngaynhap"]);
                        exSheet.Cells[col + 2][row + 13] = ngayNhap.ToShortDateString();
                    }
                    else
                    {
                      
                        exSheet.Cells[col + 2][row + 13] = tbhdn.Rows[row][col].ToString();
                    }
                }
            }

            for (hang = 0; hang < tbhdn.Rows.Count; hang++)
            {
                exSheet.Cells[1][hang + 13] = hang + 1;
                for (cot = 0; cot < tbhdn.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 2][hang + 13] = tbhdn.Rows[hang][cot].ToString();
                }
            }

            exRange.Range["N12:N12"].Value = "Tên sản Phẩm";
            exRange.Range["N12:N12"].ColumnWidth = 20;
            exRange.Range["O12:O12"].Value = "Số lượng nhập";
            exRange.Range["N12:N12"].ColumnWidth = 20;
            for ( hang = 0; hang < tbsp.Rows.Count; hang++)
            {
                exSheet.Cells[1][hang + 13] = hang + 1;
                for ( cot = 0; cot < tbsp.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 14][hang + 13] = tbsp.Rows[hang][cot].ToString();
                }
            }


            exApp.Visible = true;
        }

       

        private void reset()
        {
            cbbmahdn.SelectedIndex = -1;
            cbbtensp.SelectedIndex = -1;
            txtdongianhap.Text = "";
            mskngaynhap.Text = "";
            cbbncc.SelectedIndex = -1;
            cbbnhanviennhap.SelectedIndex = -1;
            rdobtkhoang.Checked = false;
            grbkhoang.Enabled = false;
            rdobtngay.Checked = false;
            mskngaynhap.Enabled = false;
            msktungay.Text = "";
            mskdenngay.Text = "";
        }

        private void bthienthi_Click(object sender, EventArgs e)
        {
           
            load_datagrvid("select *from dsnhap");
            load_datagrvidsp("select tensanpham, sum(soluong) from dsnhap group by tensanpham ");
            reset();
        }

        private void txtdongianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;

        }

        

        private void rdobtngay_CheckedChanged(object sender, EventArgs e)
        {
            if(rdobtngay.Checked==true)
                mskngaynhap.Enabled = true;
            else
            {
                mskngaynhap.Enabled = false;
                mskngaynhap.Text = "";
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
    }
}
