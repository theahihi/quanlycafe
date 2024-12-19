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

namespace quanlycaphe.Forms
{
    public partial class loaisp : Form
    {
        public loaisp()
        {
            InitializeComponent();
        }
        DataTable tbl_loaisp;
        private void loaisp_Load(object sender, EventArgs e)
        {
            txtmaloai.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT * FROM tbl_loaisp";
            tbl_loaisp =funtion.GetDataToTable(sql);
            DataGridView.DataSource = tbl_loaisp;
            DataGridView.Columns[0].HeaderText = "Mã loại";
            DataGridView.Columns[1].HeaderText = "Tên loại";
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmaloai.Focus();
                return;
            }
            if (tbl_loaisp.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,
    MessageBoxIcon.Information);
                return;
            }
            txtmaloai.Text = DataGridView.CurrentRow.Cells["maloai"].Value.ToString();
            txttenloai.Text = DataGridView.CurrentRow.Cells["tenloai"].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnluu.Enabled = true;
            btnboqua.Enabled = true;
            txtmaloai.Enabled = true;
            txtmaloai.Focus();
            reset();
        }
        private void reset()
        {
            txtmaloai.Text = "";
            txttenloai.Text = "";
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmaloai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmaloai.Focus();
                return;
            }
            if (txttenloai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenloai.Focus();
                return;
            }
            string sql;
            sql = "SELECT maloai FROM tbl_loaisp WHERE maloai=N'" + txtmaloai.Text.Trim() + "'";
            if (funtion.CheckKey(sql))
            {
                MessageBox.Show("Mã loại này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmaloai.Focus();
                txtmaloai.Text = "";
                return;
            }
            sql = "INSERT INTO tbl_loaisp(maloai,tenloai) VALUES(N'" + txtmaloai.Text.Trim() + "', N'" + txttenloai.Text.Trim() + "')";
           funtion.RunSql(sql);
            Load_DataGridView();
            reset();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmaloai.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbl_loaisp.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtmaloai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttenloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên loại", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenloai.Focus();
                return;
            }
            sql = "UPDATE tbl_loaisp SET tenloai=N'" + txttenloai.Text.ToString() +"' WHERE maloai=N'" + txtmaloai.Text + "'";
            funtion.RunSql(sql);
            Load_DataGridView();
            reset();
            btnboqua.Enabled = false;
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbl_loaisp.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtmaloai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tbl_loaisp WHERE maloai=N'" + txtmaloai.Text + "'";
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
            txtmaloai.Enabled = false;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
