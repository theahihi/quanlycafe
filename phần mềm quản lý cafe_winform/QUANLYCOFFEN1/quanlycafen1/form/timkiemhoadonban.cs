using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlycafen1
{
    public partial class timkiemhoadonban : Form
    {
        public timkiemhoadonban()
        {
            InitializeComponent();
        }
        DataTable tbhdb;

        private void timkiemhoadonban_Load(object sender, EventArgs e)
        {
            load_datagrvid("select*from tbl_hoadonban where mahdb=N'" + cbbmahdb.Text + "'");
            funtion.FillCombo("select mahdb from tbl_hoadonban", cbbmahdb, "mahdb", "mahdb");
            funtion.FillCombo("select manv from tbl_nhanvien", cbbnv, "manv", "manv");
            funtion.FillCombo("select makh from tbl_khachhang", cbbkh, "makh", "makh");
            cbbmahdb.SelectedIndex = -1;
            cbbnv.SelectedIndex = -1;
            cbbkh.SelectedIndex = -1;
        }
        private void load_datagrvid(string sql)
        {
            tbhdb = funtion.GetDataToTable(sql);
            dtgrdtkhdb.DataSource = tbhdb;
            dtgrdtkhdb.Columns[0].HeaderText = "Mã hoá đơn";
            dtgrdtkhdb.Columns[1].HeaderText = "Ngày bán";
            dtgrdtkhdb.Columns[2].HeaderText = "Mã nhân viên bán";
            dtgrdtkhdb.Columns[3].HeaderText = "Mã Khách hàng";
            dtgrdtkhdb.Columns[4].HeaderText = "Tổng tiền";
            dtgrdtkhdb.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void txttongtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void bttim_Click(object sender, EventArgs e)
        {

            if (cbbmahdb.Text == "" && mskngayban.Text == "  /  /" && cbbnv.Text == "" && cbbkh.Text == "" && txttongtien.Text == "")
            {
                MessageBox.Show("Hãy nhập 1 dữ liệu để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql;
            sql = "select *from tbl_hoadonban where 1=1 ";
            if (cbbmahdb.Text != "")
            {
                sql = sql + " and mahdb like N'%" + cbbmahdb.Text + "%'";
            }
            if (mskngayban.Text != "  /  /")
            {
                if (!funtion.IsDate(mskngayban.Text))
                {
                    MessageBox.Show("Hãy nhập lại ngày nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskngayban.Text = "";
                    mskngayban.Focus();
                    return;
                }
                sql = sql + " and ngaynhap =N'" + funtion.ConvertDateTime(mskngayban.Text) + "'";
            }
            if (cbbnv.Text != "")
            {
                sql = sql + "and manv like N'%" + cbbnv.Text + "%'";
            }
            if (cbbkh.Text != "")
            {
                sql = sql + "and makh like N'%" + cbbkh.Text + "%'";
            }
            if (txttongtien.Text != "")
            {
                sql = sql + "and tongtien = " + txttongtien.Text + "    ";
            }
            DataTable tbhdb = funtion.GetDataToTable(sql);
            if (tbhdb.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi nào thoả mãn", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset();
                return;

            }
            else
            {
                MessageBox.Show("Có " + tbhdb.Rows.Count + " bản ghi nào thoả mãn", "Thông báo ", MessageBoxButtons.OK);
                reset();

            }
            load_datagrvid(sql);
        }
        private void reset()
        {
            cbbmahdb.SelectedIndex = -1;
            mskngayban.Text = "";
            cbbnv.SelectedIndex = -1;
            cbbkh.SelectedIndex = -1;
            txttongtien.Text = "";
        }
        private void bttimlai_Click(object sender, EventArgs e)
        {
            cbbmahdb.SelectedIndex = -1;
            cbbnv.SelectedIndex = -1;
            cbbkh.SelectedIndex = -1;
            mskngayban.Text = "";
            txttongtien.Text="";
            cbbmahdb.Text = "";
            cbbnv.Text = "";
            cbbkh.Text = "";
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn thức sự muốn đóng ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
