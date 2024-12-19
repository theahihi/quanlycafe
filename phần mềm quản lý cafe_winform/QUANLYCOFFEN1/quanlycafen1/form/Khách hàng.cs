using quanlycafen1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlynhanvien
{
    public partial class khachhang : Form
    {
        public khachhang()
        {
            InitializeComponent();
        }
        DataTable tbkhach;
        private void khachhang_Load(object sender, EventArgs e)
        {
            btluu.Enabled = false;
            btboqua.Enabled = false;
            txtmakhach.Enabled = false;
            load_dtgv();
        }
        private void load_dtgv()
        {
            string sql;
            sql = "select*from tbl_khachhang";
           
            tbkhach = funtion.GetDataToTable(sql);
            dtgrvkhachhang.DataSource = tbkhach;
            dtgrvkhachhang.Columns[0].HeaderText = "Mã Khách";
            dtgrvkhachhang.Columns[1].HeaderText = "Tên Khách";
            dtgrvkhachhang.Columns[2].HeaderText = "Số điện thoại";
            dtgrvkhachhang.Columns[3].HeaderText = "Địa chỉ";
            dtgrvkhachhang.AllowUserToAddRows = false;
            dtgrvkhachhang.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void dtgrvkhachhang_Click(object sender, EventArgs e)
        {
            if (btthem.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbkhach.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu  ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           txtdiachi.Text= dtgrvkhachhang.CurrentRow.Cells["diachi"].Value.ToString();
            txtmakhach.Text = dtgrvkhachhang.CurrentRow.Cells["makh"].Value.ToString();
            txttenkhach.Text = dtgrvkhachhang.CurrentRow.Cells["tenkh"].Value.ToString();
            msksdt.Text = dtgrvkhachhang.CurrentRow.Cells["sodienthoai"].Value.ToString();
            btboqua.Enabled = true;
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            reset();
            btthem.Enabled = false;
            btluu.Enabled = true;
            btboqua.Enabled = true;
            txtmakhach.Enabled = true;
            btxoa.Enabled = false;
            btsua.Enabled = false;
        }
        private void reset()
        {
            txtmakhach.Text = "";
            txttenkhach.Text = "";
            txtdiachi.Text = "";
            msksdt.Text = "(   )    -";
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmakhach.Text == "")
            {
                MessageBox.Show("chưa có Mã khách hàng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmakhach.Focus();
                return;
            }
            if (txttenkhach.Text == "")
            {
                MessageBox.Show("Chưa có tên khách hàng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttenkhach.Focus();
                return;
            }
            
            if (txtdiachi.Text == "")
            {
                MessageBox.Show("chưa có địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdiachi.Focus();
                return;
            }
            if (msksdt.Text == "(   )    -")
            {
                MessageBox.Show("Chưa có số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msksdt.Focus();
                return;
            }
            sql = "select makh from tbl_khachhang where makh = N'" + txtmakhach.Text + "'";
            if (funtion.CheckKey(sql))
            {
                MessageBox.Show("Mã Khách hàng đã có ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmakhach.Focus();
                txtmakhach.Text = "";
                return;
            }
            string makhach = txtmakhach.Text.Replace(" ", "");
            sql = "insert into tbl_khachhang values(N'" + makhach.ToUpper() + "',N'" + txttenkhach.Text + "',N'" + msksdt.Text + "',N'" + txtdiachi.Text + "')";
            funtion.RunSql(sql);
            load_dtgv();
            reset();
            txtmakhach.Enabled = false;
            btthem.Enabled = true;
            btluu.Enabled = false;
            btboqua.Enabled = false;
            btxoa.Enabled = true;
            btsua.Enabled = true;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (tbkhach.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu nào để xoá ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtmakhach.Text == "")
            {
                MessageBox.Show("hãy chọn dữ liệu để xoá ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult a = MessageBox.Show("Bạn thực sự muốn xoá dữ liệu này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                string sql;
                sql = "delete from tbl_khachhang where makh =N'" + txtmakhach.Text + "'";
                funtion.RunSql(sql);
                load_dtgv();
                reset();
                return;
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (txtmakhach.Text == "")
            {
                MessageBox.Show("hãy chọn dữ liệu để xoá ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (txttenkhach.Text == "")
            {
                MessageBox.Show("hãy nhập tên khách hàng ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttenkhach.Focus();
                return;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show("hãy nhập địa chỉ khách hàng ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdiachi.Focus();
                return;
            }
            if (msksdt.Text == "(   )    -")
            {
                MessageBox.Show("hãy nhập số điện thoại  của khách hàng ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msksdt.Focus();
                return;
            }
            string sql;
            sql = " update tbl_khachhang set tenkh=N'" + txttenkhach.Text + "', diachi=N'" + txtdiachi.Text + "', sodienthoai ='" + msksdt.Text + "' where makh=N'" + txtmakhach.Text + "'  ";
            funtion.RunSql(sql);
            load_dtgv();
            reset();
            btboqua.Enabled = false;
        }

        private void btboqua_Click(object sender, EventArgs e)
        {
            reset();
            txtmakhach.Enabled = false;
            btthem.Enabled = true;
            btluu.Enabled = false;
            btboqua.Enabled = false;
            btxoa.Enabled = true;
            btsua.Enabled = true;
        }

        private void btdong_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn thực sự muốn đóng ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
