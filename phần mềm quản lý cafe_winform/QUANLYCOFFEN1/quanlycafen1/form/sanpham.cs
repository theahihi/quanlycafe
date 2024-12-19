using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using quanlycafen1;

namespace quanlycaphe.Forms
{
    public partial class sanpham : Form
    {
        public sanpham()
        {
            InitializeComponent();
        }
        DataTable tbl_sanpham;
        private void sanpham_Load(object sender, EventArgs e)
        {
            txtmasanpham.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
            funtion.FillCombo("SELECT maloai, tenloai FROM tbl_loaisp", cbomaloai, "maloai", "tenloai");
            cbomaloai.SelectedIndex = -1;
            funtion.FillCombo("SELECT macongdung, tencongdung FROM tbl_congdung", cbomacongdung, "macongdung", "tencongdung");
            cbomacongdung.SelectedIndex = -1;
            reset();
        }
        private void reset()
        {
            txtmasanpham.Text = "";
            txttensanpham.Text = "";
            cbomaloai.SelectedIndex = -1;
            txtsoluong.Text = "0";
            txtgianhap.Text = "0";
            txtgiaban.Text = "0";
            txtsoluong.Enabled = false;
            txtgianhap.Enabled = false;
            cbomacongdung.SelectedIndex = -1;
            txtgiaban.Enabled = false;
            txthinhanh.Text = "";
            pichinhanh.Image = null;       
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT masanpham, tensanpham, maloai, soluong, gianhap, giaban, macongdung FROM tbl_sanpham";
            tbl_sanpham = funtion.GetDataToTable(sql);
            DataGridView.DataSource = tbl_sanpham;
            DataGridView.Columns[0].HeaderText = "Mã sản phẩm";
            DataGridView.Columns[1].HeaderText = "Tên sản phẩm";
            DataGridView.Columns[2].HeaderText = "Loại sản phẩm";
            DataGridView.Columns[3].HeaderText = "Số lượng";
            DataGridView.Columns[4].HeaderText = "Đơn giá nhập";
            DataGridView.Columns[5].HeaderText = "Đơn giá bán";
            DataGridView.Columns[6].HeaderText = "Công dụng";
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmasanpham.Focus();
                return;
            }
            if (tbl_sanpham.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmasanpham.Text = DataGridView.CurrentRow.Cells["masanpham"].Value.ToString();
            txttensanpham.Text = DataGridView.CurrentRow.Cells["tensanpham"].Value.ToString();
            ma = DataGridView.CurrentRow.Cells["maloai"].Value.ToString();
           
            cbomaloai.Text = funtion.GetFieldValues("SELECT tenloai FROM tbl_loaisp WHERE maloai = N'" + ma + "'");
            ma = DataGridView.CurrentRow.Cells["macongdung"].Value.ToString();
            cbomacongdung.Text = funtion.GetFieldValues("SELECT tencongdung FROM tbl_congdung WHERE macongdung = N'" + ma + "'");
            txtsoluong.Text = DataGridView.CurrentRow.Cells["soluong"].Value.ToString();
            txtgianhap.Text = DataGridView.CurrentRow.Cells["gianhap"].Value.ToString();
            txtgiaban.Text = DataGridView.CurrentRow.Cells["giaban"].Value.ToString();
            txthinhanh.Text = funtion.GetFieldValues("SELECT hinhanh FROM tbl_sanpham WHERE masanpham = N'" + txtmasanpham.Text + "'");
            pichinhanh.Image = Image.FromFile(txthinhanh.Text);
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "bitmap(*.bmp)|*.bmp|Gif(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.InitialDirectory = "D:\\";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chon hinh anh de hien thi";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                pichinhanh.Image = Image.FromFile(dlgOpen.FileName);
                txthinhanh.Text = dlgOpen.FileName;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            reset();
            txtmasanpham.Enabled = true;
            txtmasanpham.Focus();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmasanpham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmasanpham.Focus();
                return;
            }
            if (txttensanpham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttensanpham.Focus();
                return;
            }
            if (cbomaloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomaloai.Focus();
                return;
            }
            if (cbomacongdung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập công dụng của sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomacongdung.Focus();
                return;
            }
            if (txthinhanh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txthinhanh.Focus();
                return;
            }
            sql = "SELECT masanpham FROM tbl_sanpham WHERE masanpham=N'" + txtmasanpham.Text.Trim() + "'";
            if (funtion.CheckKey(sql))
            {
                MessageBox.Show("Mã sản phẩm này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmasanpham.Focus();
                txtmasanpham.Text = "";
                return;
            }
            sql = "INSERT INTO tbl_sanpham VALUES(N'" + txtmasanpham.Text.Trim() + "',N'" + txttensanpham.Text.Trim() + "',N'" + cbomaloai.SelectedValue.ToString() + "'," + txtgianhap.Text + "," + txtgiaban.Text + ",'" + txtsoluong.Text.Trim() + "',N'" + cbomacongdung.SelectedValue.ToString() + "',N'" + txthinhanh.Text + "')";
            funtion.RunSql(sql);
            Load_DataGridView();
            reset();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmasanpham.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbl_sanpham.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmasanpham.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttensanpham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttensanpham.Focus();
                return;
            }
            if (cbomaloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomaloai.Focus();
                return;
            }
            if (cbomacongdung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập công dụng của sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomacongdung.Focus();
                return;
            }
            if (txthinhanh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txthinhanh.Focus();
                return;
            }
            sql = "UPDATE tbl_sanpham SET  tensanpham=N'" + txttensanpham.Text.Trim().ToString() + "',maloai=N'" + cbomaloai.SelectedValue.ToString() + "',macongdung=N'" + cbomacongdung.SelectedValue.ToString() + "',hinhanh=N'" + txthinhanh.Text + "'WHERE masanpham=N'" + txtmasanpham.Text + "'";
            funtion.RunSql(sql);
            Load_DataGridView();
            reset();
            btnboqua.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbl_sanpham.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmasanpham.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tbl_sanpham WHERE masanpham=N'" + txtmasanpham.Text + "'";
                funtion.RunSql(sql);
                Load_DataGridView();
                reset();
            }
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            reset();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmasanpham.Enabled = false;
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT masanpham, tensanpham, maloai, soluong, gianhap, giaban, macongdung, hinhanh FROM tbl_sanpham";
            tbl_sanpham = funtion.GetDataToTable(sql);
            DataGridView.DataSource = tbl_sanpham;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn muốn đóng ứng dụng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(a== DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtmasanpham.Text == "") && (txttensanpham.Text == "") && (cbomaloai.Text == "") && (cbomacongdung.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tbl_sanpham WHERE 1=1";
            if (txtmasanpham.Text != "")
                sql = sql + " AND masanpham Like N'%" + txtmasanpham.Text + "%'";
            //sql = sql + " AND masanpham = N'" + txtmasanpham.Text + "'"; (tìm kiếm chính xác)
            if (txttensanpham.Text != "")
                sql = sql + " AND tensanpham Like N'%" + txttensanpham.Text + "%'";
            //sql = sql + " AND tensanpham = N'" + txttensanpham.Text + "'"; (tìm kiếm chính xác)
            if (cbomaloai.Text != "")
                sql = sql + " AND maloai Like N'%" + cbomaloai.SelectedValue + "%'";
            //sql = sql + " AND maloai = N'" + cbomaloai.SelectedValue + "'"; (tìm kiếm chính xác)
            if (cbomacongdung.Text != "")
                sql = sql + " AND macongdung Like N'%" + cbomacongdung.SelectedValue + "%'";
            //sql = sql + " AND macongdung = N'" + cbomacongdung.SelectedValue + "'"; (tìm kiếm chính xác)
            tbl_sanpham = funtion.GetDataToTable(sql);
            if (tbl_sanpham.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tbl_sanpham.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DataGridView.DataSource = tbl_sanpham;
            reset();
        }

        private void pichinhanh_Click(object sender, EventArgs e)
        {

        }
    }
}
