using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace quanlycafen1
{
    public partial class hdn : Form
    {
        public hdn()
        {
            InitializeComponent();
        }
        DataTable tbhdn;

        private void hdn_Load(object sender, EventArgs e)
        {
            btluu.Enabled = false;
            
           
            
            btboqua.Enabled = false;
            txtmahdn.Enabled = false;
            txttenncc.Enabled = false;
            txtdiachi.Enabled = false;
            txtsdtncc.Enabled = false;
            txttennv.Enabled = false;
            txttensp.Enabled = false;
           txttongtien.Enabled = false;
            txtck.Text = "0";
            txttongtien.Text = "0";
            funtion.FillCombo("select mancc from tbl_ncc",cbbmancc,"mancc","mancc");
            cbbmancc.SelectedIndex = -1;
            funtion.FillCombo("select manv from tbl_nhanvien ", cbbmanv, "manv", "manv");
            cbbmanv.SelectedIndex = -1;
            funtion.FillCombo("select masanpham from tbl_sanpham",cbbmasanpham, "masanpham", "masanpham");
            cbbmasanpham.SelectedIndex = -1;
            funtion.FillCombo("select mahdn from tbl_hoadonnhap", cbbmahdn, "mahdn", "mahdn");
            cbbmahdn.SelectedIndex = -1;
            hdxoa.Visible = false;
            load_dtgrhdn();
        }
        private void load_dtgrhdn()
        {
            string sql;
            sql = "select b.masanpham , b.tensanpham,a.dongia,a.soluong , a.thanhtien, a.chietkhau  from tbl_chitiethdn a inner join tbl_sanpham b on a.masanpham = b.masanpham where mahdn =N'"+txtmahdn.Text+"' ";
            tbhdn = funtion.GetDataToTable(sql);
            dtgrvhdn.DataSource = tbhdn;
            dtgrvhdn.Columns[0].HeaderText = "Mã sản phẩm";
            dtgrvhdn.Columns[1].HeaderText = "Tên sản phẩm";
            dtgrvhdn.Columns[2].HeaderText = "Đơn giá nhập";
            dtgrvhdn.Columns[3].HeaderText = "Số lượng";
            dtgrvhdn.Columns[4].HeaderText = "Thành tiền";
            dtgrvhdn.Columns[5].HeaderText = "Chiết khấu (%) ";

        }
        

       

        private void cbbmancc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbmancc.SelectedValue != null)
            {
                string ma;
                ma = cbbmancc.SelectedValue.ToString();
                txttenncc.Text = funtion.GetFieldValues("select tenncc from tbl_ncc where mancc =N'" + ma + "' ");
                txtdiachi.Text= funtion.GetFieldValues("select  diachi from tbl_ncc where mancc =N'" + ma + "' ");
                txtsdtncc.Text= funtion.GetFieldValues("select  sdt from tbl_ncc where mancc =N'" + ma + "' ");
            }
          
        }

        private void cbbmanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbmanv.SelectedValue != null)
            {
                string ma;
                ma = cbbmanv.SelectedValue.ToString();
                txttennv.Text = funtion.GetFieldValues("select tennv from tbl_nhanvien where manv =N'" + ma + "' ");
              
            }
        }

        private void cbbmasanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbmasanpham.SelectedValue != null)
            {
                string ma;
                ma = cbbmasanpham.SelectedValue.ToString();
                txttensp.Text = funtion.GetFieldValues("select tensanpham from tbl_sanpham where masanpham =N'" + ma + "' ");
                txtdongianhap.Text = funtion.GetFieldValues("select gianhap from tbl_sanpham where  masanpham =N'" + ma + "'  ");

            }
        }
        private void resertvalue()
        {
            txtmahdn.Text = "";
            mskngaynhap.Text = "";
            cbbmancc.SelectedIndex = -1;
            cbbmanv.SelectedIndex = -1;
            cbbmasanpham.SelectedIndex = -1;
            txttenncc.Text = "";
            txtdiachi.Text = "";
            txtsdtncc.Text = "";
            txttennv.Text = "";
            txttensp.Text = "";
            txtsoluong.Text = "";
            txtdongianhap.Text = "";
            txtck.Text = "0";
            cbbmahdn.SelectedIndex = -1;
            txttongtien.Text= "0";
            lbtongtienchu.Text = "Bằng chữ: ";

            
        }
        private void resetttsp()
        {
            cbbmasanpham.SelectedIndex = -1;
            txttensp.Text = "";
            txtsoluong.Text = "";
            txtdongianhap.Text = "";
            txtck.Text = "0";
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            resertvalue();
            load_dtgrhdn();
            mskngaynhap.Text= DateTime.Now.ToShortDateString();
            btthem.Enabled= false;
            btxoa.Enabled = false;
            btsua.Enabled = false;
            btluu.Enabled = true;
            btboqua.Enabled = true;
           grbtim.Enabled = false;
            txtmahdn.Text = funtion.CreateKey("HDN");
            cbbmancc.Enabled = true;
            cbbmanv.Enabled = true;

        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if(mskngaynhap.Text== "  /  /")
            {
                MessageBox.Show("hãy nhập ngày nhập hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskngaynhap.Focus();
                return;
            }
            if (cbbmancc.SelectedIndex == -1)
            {
                MessageBox.Show("hãy chọn nhà cung cấp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbbmanv.SelectedIndex == -1)
            {
                MessageBox.Show("hãy chọn nhân viên nhập ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbbmasanpham.SelectedIndex == -1)
            {
                MessageBox.Show("hãy chọn nhân viên nhập ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtsoluong.Text == "")
            {
                MessageBox.Show("hãy nhập ngày nhập số lượng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsoluong.Focus();
                return;
            }
            if (txtdongianhap.Text == "")
            {
                MessageBox.Show("hãy nhập ngày nhập giá nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdongianhap.Focus();
                return;
            }
            if (txtck.Text == "")
            {
                MessageBox.Show("hãy nhập ngày nhập chiết khấu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtck.Focus();
                return;
            }
           
           
            if (!funtion.IsDatenow(mskngaynhap.Text))
            {
                MessageBox.Show("ngày nhập lớn hơn hiện tại, hãy nhập lại ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskngaynhap.Focus();
                mskngaynhap.Text = "";
                return;
            }
            if (!funtion.IsDate(mskngaynhap.Text))
            {

                MessageBox.Show("Nhập sai ngày nhập, hãy nhập lại ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskngaynhap.Focus();
                mskngaynhap.Text = "";
                return;
            }
            string sql;
            
            if (!funtion.CheckKey("select mahdn from tbl_hoadonnhap where mahdn='" + txtmahdn.Text + "'") )
            {
                sql = " insert into tbl_hoadonnhap values(N'" + txtmahdn.Text + "','" + funtion.ConvertDateTime(mskngaynhap.Text) + "',N'" + cbbmanv.Text + "',N'" + cbbmancc.Text + "','0') ";
                funtion.RunSql(sql);
                float thanhtien = Convert.ToSingle(txtsoluong.Text) * Convert.ToSingle(txtdongianhap.Text);
                float chietkhau = Convert.ToSingle(txtck.Text) / 100;
                float tongtien = thanhtien * (1 - chietkhau);
                sql = "update tbl_hoadonnhap set tongtien = tongtien + '" + tongtien + "' where mahdn = '" + txtmahdn.Text + "'";
                funtion.RunSql(sql);
            } 
            else if(!funtion.CheckKey("select mahdn,masanpham from tbl_chitiethdn where mahdn=N'" + txtmahdn.Text + "' and masanpham='" + cbbmasanpham.Text + "'"))
            {
                float thanhtien = Convert.ToSingle(txtsoluong.Text) * Convert.ToSingle(txtdongianhap.Text);
                float chietkhau = Convert.ToSingle(txtck.Text) / 100;
                float tongtien = thanhtien * (1 - chietkhau);
                sql = "update tbl_hoadonnhap set tongtien = tongtien + '" + tongtien + "' where mahdn = '" + txtmahdn.Text + "'";
                funtion.RunSql(sql);
            }
            
            if(funtion.CheckKey("select mahdn,masanpham from tbl_chitiethdn where mahdn=N'" + txtmahdn.Text + "' and masanpham='" + cbbmasanpham.Text + "'"))
            {
                MessageBox.Show("đã có mã hoá đơn và mã sản phẩm này hãy thay đổi mã hoá đơn hoặc mã sản phẩm ","Thông báo ",MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbmasanpham.SelectedIndex = -1;
                return;
            }
            else
            {
                decimal tt = Convert.ToInt32(txtsoluong.Text) * Convert.ToInt32(txtdongianhap.Text);
                sql = "insert into tbl_chitiethdn values(N'" + txtmahdn.Text + "',N'" + cbbmasanpham.Text + "','" + txtsoluong.Text + "','" + txtdongianhap.Text + "','" + tt + "','" + txtck.Text + "')";
                funtion.RunSql(sql);
                sql = "update tbl_sanpham set gianhap =" + txtdongianhap.Text + ",giaban ="+txtdongianhap.Text+"*1.1 ,soluong= soluong+"+ txtsoluong.Text+" where masanpham ='"+cbbmasanpham.Text+"'";
                funtion.RunSql(sql);


            }
           txttongtien.Text= funtion.GetFieldValues("select tongtien from tbl_hoadonnhap where mahdn =N'"+txtmahdn.Text+"'").ToString();
            load_dtgrhdn();
            resetttsp();
            hdxoa.Visible= true;
            funtion.FillCombo("select mahdn from tbl_hoadonnhap", cbbmahdn, "mahdn", "mahdn");
            cbbmahdn.SelectedIndex = -1;
            lbtongtienchu.Text = "Bằng chữ: " + funtion.ChuyenSoSangChu(txttongtien.Text);
            cbbmancc.Enabled = false;
            cbbmanv.Enabled = false;

        }

        private void btboqua_Click(object sender, EventArgs e)
        {
            resertvalue();
            btthem.Enabled = true;
            btxoa.Enabled = true;
            btsua.Enabled = true;   
            btluu.Enabled = false;
            btboqua.Enabled = false;
            grbtim.Enabled = true;
            hdxoa.Visible = false;
            lbtongtienchu.Text = "Bằng chữ: ";
            cbbmancc.Enabled= true;
            cbbmanv.Enabled= true;
            load_dtgrhdn();
        }

       

        private void dtgrvhdn_Click(object sender, EventArgs e)
        {
            if (btthem.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbhdn.Rows.Count == 0)
            {
                MessageBox.Show("không có dữ liệu ", "Thống Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            cbbmasanpham.Text = dtgrvhdn.CurrentRow.Cells["masanpham"].Value.ToString();
            txtsoluong.Text= dtgrvhdn.CurrentRow.Cells["soluong"].Value.ToString();
            txtdongianhap.Text= dtgrvhdn.CurrentRow.Cells["dongia"].Value.ToString();
            txtck.Text= dtgrvhdn.CurrentRow.Cells["chietkhau"].Value.ToString();





        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (cbbmahdn.Text == "")
            {
                MessageBox.Show("Hãy chọn 1 hoá đơn để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult a = MessageBox.Show("Bạn thực sự muốn xoá hoá đơn " + cbbmahdn.Text + " ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(a == DialogResult.Yes)
            {
                string sql;
                DataTable trusoluong = funtion.GetDataToTable("SELECT masanpham, soluong FROM tbl_chitiethdn WHERE mahdn=N'" + cbbmahdn.Text + "'");

               
                foreach (DataRow row in trusoluong.Rows)
                {
                    string masanpham = row["masanpham"].ToString();
                    float soluong = Convert.ToSingle(row["soluong"]);

                    
                    sql = "UPDATE tbl_sanpham SET soluong = soluong - " + soluong + " WHERE masanpham = '" + masanpham + "'";
                    funtion.RunSql(sql);
                }
                sql = "delete tbl_chitiethdn where mahdn=N'" + cbbmahdn.Text + "'";
                funtion.RunSql(sql);
                sql = "delete tbl_hoadonnhap where mahdn=N'" + cbbmahdn.Text + "' ";
                funtion.RunSql(sql);
                funtion.FillCombo("select mahdn from tbl_hoadonnhap", cbbmahdn, "mahdn", "mahdn");
                resertvalue();
                load_dtgrhdn();
            }
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            
            if (cbbmahdn.Text=="")
            {
                MessageBox.Show("hãy chọn mã hoá đơn để tìm", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
               
                hdxoa.Visible = true;

            }

            resetttsp();
            string ma;
            ma = cbbmahdn.SelectedValue.ToString();
            txtmahdn.Text = funtion.GetFieldValues("select mahdn from tbl_hoadonnhap where mahdn =N'" + ma + "'");
            mskngaynhap.Text = funtion.GetFieldValues("select ngaynhap from tbl_hoadonnhap where mahdn=N'" + ma + "'");
            cbbmancc.Text = funtion.GetFieldValues("select mancc from tbl_hoadonnhap where mahdn ='" + ma + "'");
            txttenncc.Text = funtion.GetFieldValues("select tenncc from tbl_ncc where mancc =N'" + cbbmancc.Text + "' ");
            txtdiachi.Text = funtion.GetFieldValues("select  diachi from tbl_ncc where mancc =N'" + cbbmancc.Text + "' ");
            txtsdtncc.Text = funtion.GetFieldValues("select  sdt from tbl_ncc where mancc =N'" + cbbmancc.Text + "' ");
            cbbmanv.Text = funtion.GetFieldValues("select manv from tbl_hoadonnhap  where mahdn ='" + ma + "'");
            txttennv.Text = funtion.GetFieldValues("select tennv from tbl_nhanvien where manv =N'" + cbbmanv.Text + "' ");
            txttongtien.Text = funtion.GetFieldValues("select tongtien from tbl_hoadonnhap where mahdn=N'" + ma + "'");
            lbtongtienchu.Text = "Bằng chữ: " + funtion.ChuyenSoSangChu(txttongtien.Text);
            btboqua.Enabled = true;
            load_dtgrhdn();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (txtmahdn.Text == "")
            {
                MessageBox.Show("Hãy chọn hoá đơn để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            string sql;
           
            if(cbbmasanpham.Text == "")
            {
                sql = "update tbl_hoadonnhap set ngaynhap='" + funtion.ConvertDateTime(mskngaynhap.Text) + "', manv =N'" + cbbmanv.Text + "',mancc=N'" + cbbmancc.Text + "' where mahdn =N'" + txtmahdn.Text + "'  ";
                funtion.RunSql(sql);

            }
            else
            {
                

                if (txtsoluong.Text == "")
                {
                    MessageBox.Show("Hãy nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtsoluong.Focus();
                    return;
                }
                if (txtdongianhap.Text == "")
                {
                    MessageBox.Show("Hãy nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdongianhap.Focus();
                    return;
                }
                if (txtck.Text == "")
                {
                    MessageBox.Show("Hãy nhập chiết khấu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdongianhap.Focus();
                    return;
                }
                float soLuongMoi = Convert.ToSingle(txtsoluong.Text);
                float soLuongCu = Convert.ToSingle(dtgrvhdn.CurrentRow.Cells["soluong"].Value.ToString());

                if (soLuongMoi > soLuongCu)
                {
                    sql = "update tbl_sanpham set soluong = soluong + (" + soLuongMoi + " - " + soLuongCu + ") where masanpham ='" + cbbmasanpham.Text + "'";
                    funtion.RunSql(sql);
                }
                else
                {
                    sql = "update tbl_sanpham set soluong = soluong - (select soluong from tbl_chitiethdn where mahdn=N'" + txtmahdn.Text + "' and masanpham=N'" + cbbmasanpham.Text + "') + " + txtsoluong.Text + " where masanpham ='" + cbbmasanpham.Text + "'";
                    funtion.RunSql(sql);
                }
                sql = "update tbl_sanpham set gianhap =" + txtdongianhap.Text + ",giaban =" + txtdongianhap.Text + "*1.1  where masanpham ='" + cbbmasanpham.Text + "'";
                funtion.RunSql(sql);

                sql = "update tbl_hoadonnhap set ngaynhap='" + funtion.ConvertDateTime(mskngaynhap.Text) + "', manv =N'" + cbbmanv.Text + "',mancc=N'" + cbbmancc.Text + "' where mahdn =N'" + txtmahdn.Text + "' ";
                funtion.RunSql(sql);

                float thanhtien = Convert.ToSingle(txtsoluong.Text) * Convert.ToSingle(txtdongianhap.Text);
                float chietkhau = Convert.ToSingle(txtck.Text);
               
                sql = "update tbl_chitiethdn set soluong=" + txtsoluong.Text + ",dongia=" + txtdongianhap.Text + ",thanhtien =" + thanhtien + ", chietkhau=" + txtck.Text + " where mahdn=N'" + txtmahdn.Text + "' and masanpham=N'" + dtgrvhdn.CurrentRow.Cells["masanpham"].Value.ToString() + "' ";
                funtion.RunSql(sql);

                float tongtien = Convert.ToSingle(funtion.GetFieldValues("select sum(thanhtien*(1-chietkhau/100)) from tbl_chitiethdn where mahdn =N'" + txtmahdn.Text + "'").ToString());
                sql = "update tbl_hoadonnhap set tongtien = " + tongtien + " where mahdn = N'" + txtmahdn.Text + "'";
                funtion.RunSql(sql);

                txttongtien.Text = funtion.GetFieldValues("select tongtien from tbl_hoadonnhap where mahdn =N'" + txtmahdn.Text + "'").ToString();
                lbtongtienchu.Text = "Bằng chữ: " + funtion.ChuyenSoSangChu(txttongtien.Text);
                load_dtgrhdn();
                resetttsp();
            }
           
            
        }

       

        private void dtgrvhdn_DoubleClick(object sender, EventArgs e)
        {
        
            DialogResult a = MessageBox.Show("Bạn chắc chắn muốn xoá dữ liệu này","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                string sql;
                sql = "update tbl_sanpham set soluong= soluong -" + txtsoluong.Text + " where masanpham=N'" + cbbmasanpham.Text + "'";
                funtion.RunSql(sql);
                sql = "delete from tbl_chitiethdn where mahdn =N'" + txtmahdn.Text + "' and masanpham=N'" + cbbmasanpham.Text + "' ";
                funtion.RunSql(sql);
                float thanhtien = Convert.ToSingle(dtgrvhdn.CurrentRow.Cells["thanhtien"].Value.ToString());
                float chietkhau = Convert.ToSingle(dtgrvhdn.CurrentRow.Cells["chietkhau"].Value.ToString()) / 100;
                float khoantru = thanhtien * (1 - chietkhau);
                sql = "update tbl_hoadonnhap set tongtien = tongtien -'" + khoantru + "' where mahdn = N'" + txtmahdn.Text + "'";
                funtion.RunSql(sql);
                txttongtien.Text = funtion.GetFieldValues("select tongtien from tbl_hoadonnhap where mahdn =N'" + txtmahdn.Text + "'").ToString();
                lbtongtienchu.Text = "Bằng chữ: " + funtion.ChuyenSoSangChu(txttongtien.Text);
                load_dtgrhdn();
                resetttsp();

                if (tbhdn.Rows.Count == 0)
                {
                    sql = "delete from tbl_hoadonnhap where mahdn =N'" + txtmahdn.Text + "'";
                    funtion.RunSql(sql);
                    funtion.FillCombo("select mahdn from tbl_hoadonnhap", cbbmahdn, "mahdn", "mahdn");
                    resertvalue();
                }
            }
            
        }

        private void btdong_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn chắc chắn muốn đóng ứng dụng","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btin_Click(object sender, EventArgs e)
        {
            if (txtmahdn.Text == "")
            {
                MessageBox.Show("hãy chọn hoá đơn để in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinhoadon, tblThongtinsanpham;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Quán cafe";

            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "12 Chùa Bộc - Hà Nội";

            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: ";


            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN NHẬP ";
            sql = "SELECT a.mahdn, a.ngaynhap, a.tongtien, b.tennv, c.tenncc " + "FROM tbl_hoadonnhap AS a " + "INNER JOIN tbl_nhanvien AS b ON a.manv = b.manv " +"INNER JOIN tbl_ncc AS c ON a.mancc = c.mancc " +"WHERE a.mahdn = N'" + txtmahdn.Text + "'";
            tblThongtinhoadon = funtion.GetDataToTable(sql);

            exRange.Range["A7:F10"].Font.Size = 12;
            exRange.Range["A7:A7"].Value = "Mã hoá đơn:";
            exRange.Range["B7:F7"].MergeCells = true;
            exRange.Range["B7:F7"].Value = tblThongtinhoadon.Rows[0]["mahdn"].ToString();
            exRange.Range["A8:A8"].Value = "Ngày nhập:";
            exRange.Range["B8:F8"].MergeCells = true;
            exRange.Range["B8:F8"].Value = Convert.ToDateTime(tblThongtinhoadon.Rows[0]["ngaynhap"]).ToShortDateString();
            exRange.Range["A9:A9"].Value = "Nhân viên nhập:";
            exRange.Range["B9:F9"].MergeCells = true;
            exRange.Range["B9:F9"].Value = tblThongtinhoadon.Rows[0]["tennv"].ToString();
            exRange.Range["A10:A10"].Value = "Nhà cung cấp:";
            exRange.Range["B10:F10"].MergeCells = true;
            exRange.Range["B10:F10"].Value = tblThongtinhoadon.Rows[0]["tenncc"].ToString();
            exRange.Range["A11:A11"].Value = "Tổng tiền:";
            exRange.Range["B11:F11"].MergeCells = true;
            exRange.Range["B11:F11"].Value = tblThongtinhoadon.Rows[0]["tongtien"].ToString();

            sql = "SELECT b.tensanpham, a.soluong, a.dongia,a.thanhtien ,a.chietkhau " +
          "FROM tbl_chitiethdn AS a , tbl_sanpham AS b " +
          "WHERE a.mahdn = N'" + txtmahdn.Text + "' AND a.masanpham = b.masanpham";
            tblThongtinsanpham = funtion.GetDataToTable(sql);
            exRange.Range["A12:F12"].Font.Bold = true;
            exRange.Range["A12:F12"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A12:A12"].Value = "STT";
            exRange.Range["B12:B12"].Value = "Tên sản phẩm";
            exRange.Range["C12:C12"].Value = "Số lượng";
            exRange.Range["D12:D12"].Value = "Đơn giá";
            exRange.Range["E12:E12"].Value = "Thành tiền";
            exRange.Range["E12:E12"].ColumnWidth = 15;
            exRange.Range["F12:F12"].Value = "Chiết khấu";

            for (hang = 0; hang < tblThongtinsanpham.Rows.Count; hang++)
            {
                exSheet.Cells[1][hang + 13] = hang + 1;
                for (cot = 0; cot < tblThongtinsanpham.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 2][hang + 13] = tblThongtinsanpham.Rows[hang][cot].ToString();
                }
            }
            exRange = exSheet.Cells[cot][hang + 15];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 15];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinhoadon.Rows[0][2].ToString();

           
            exApp.Visible = true;

           
           
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void txtdongianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void txtck_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void grbtim_Enter(object sender, EventArgs e)
        {

        }
    }
    }

      
    

