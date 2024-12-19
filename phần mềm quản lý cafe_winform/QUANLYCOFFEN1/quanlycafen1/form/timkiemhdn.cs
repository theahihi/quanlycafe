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
    public partial class timkiemhdn : Form
    {
        public timkiemhdn()
        {
            InitializeComponent();
        }
        DataTable tbhdn;
        private void timkiemhdn_Load(object sender, EventArgs e)
        {
            load_datagrvid("select*from tbl_hoadonnhap where mahdn=N'"+cbbmahdn.Text+"' ");
            funtion.FillCombo("select mahdn from tbl_hoadonnhap", cbbmahdn, "mahdn", "mahdn");
            funtion.FillCombo("select manv from tbl_nhanvien", cbbnv, "manv", "manv");
            funtion.FillCombo("select mancc from tbl_ncc", cbbncc, "mancc", "mancc");
            cbbmahdn.SelectedIndex = -1;
            cbbnv.SelectedIndex = -1;
            cbbncc.SelectedIndex = -1;
            
        }
        private void load_datagrvid(string sql)
        {
           tbhdn = funtion.GetDataToTable(sql);
            dtgrdtkhdn.DataSource = tbhdn;
            dtgrdtkhdn.Columns[0].HeaderText = "Mã hoá đơn";
            dtgrdtkhdn.Columns[1].HeaderText = "Ngày nhập";
            dtgrdtkhdn.Columns[2].HeaderText = "Mã nhân viên nhập";
            dtgrdtkhdn.Columns[3].HeaderText = "Mã NCC";
            dtgrdtkhdn.Columns[4].HeaderText = "Tổng tiền";
            dtgrdtkhdn.EditMode = DataGridViewEditMode.EditProgrammatically; 
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
            if (cbbmahdn.Text=="" && mskngaynhap.Text== "  /  /" && cbbnv.Text=="" && cbbncc.Text==""&& txttongtien.Text == "")
            {
                MessageBox.Show("Hãy nhập 1 dữ liệu để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql;
            sql = "select *from tbl_hoadonnhap where 1=1 ";
            if (cbbmahdn.Text != "")
            {
                sql = sql +" and mahdn like N'%" + cbbmahdn.Text + "%'";
            }
            if(mskngaynhap.Text != "  /  /")
            {
                if (!funtion.IsDate(mskngaynhap.Text))
                {
                    MessageBox.Show("Hãy nhập lại ngày nhập","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskngaynhap.Text = "";
                    mskngaynhap.Focus();
                    return;
                }
                sql = sql + " and ngaynhap =N'" + funtion.ConvertDateTime(mskngaynhap.Text) + "'";
            }
            if (cbbnv.Text != "")
            {
                sql = sql + "and manv like N'%" + cbbnv.Text + "%'";
            }
            if(cbbncc.Text != "")
            {
                sql = sql + "and mancc like N'%" + cbbncc.Text + "%'";
            }
            if (txttongtien.Text != "")
            {
                sql = sql + "and tongtien = " + txttongtien.Text + "    ";
            }
            DataTable tbhdn = funtion.GetDataToTable(sql);
            if (tbhdn.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi nào thoả mãn","Thông báo ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                reset();
                return;
                
            }
            else
            {
                MessageBox.Show("Có "+tbhdn.Rows.Count+" bản ghi nào thoả mãn", "Thông báo ", MessageBoxButtons.OK);
                reset();

            }
            load_datagrvid(sql);
        }
        private void reset()
        {
            cbbmahdn.SelectedIndex = -1;
            mskngaynhap.Text = "";
            cbbnv.SelectedIndex = -1;
            cbbncc.SelectedIndex = -1;
            txttongtien.Text = "";
        }

        private void bttimlai_Click(object sender, EventArgs e)
        {
            cbbmahdn.Text = "";
            cbbncc.Text = "";
            cbbnv.Text = "";
            cbbmahdn.SelectedIndex = -1;
            cbbnv.SelectedIndex = -1;
            cbbncc.SelectedIndex = -1;
            mskngaynhap.Text = "";
            txttongtien.Text = "";
            load_datagrvid("select*from tbl_hoadonnhap where mahdn=N'" + cbbmahdn.Text + "' "); 
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
