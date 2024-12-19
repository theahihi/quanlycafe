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
    public partial class congdung : Form
    {
        public congdung()
        {
            InitializeComponent();
        }
        DataTable tbl_congdung;
        private void congdung_Load(object sender, EventArgs e)
        {
            txtmacongdung.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT * FROM tbl_congdung";
            tbl_congdung = funtion.GetDataToTable(sql);
            DataGridView.DataSource = tbl_congdung;
            DataGridView.Columns[0].HeaderText = "Mã công dụng";
            DataGridView.Columns[1].HeaderText = "Tên công dụng";
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmacongdung.Focus();
                return;
            }
            if (tbl_congdung.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            txtmacongdung.Text = DataGridView.CurrentRow.Cells["macongdung"].Value.ToString();
            txttencongdung.Text = DataGridView.CurrentRow.Cells["tencongdung"].Value.ToString();
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
            txtmacongdung.Enabled = true;
            txtmacongdung.Focus();
            reset();
        }
        private void reset()
        {
            txtmacongdung.Text = "";
            txttencongdung.Text = "";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmacongdung.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã công dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmacongdung.Focus();
                return;
            }
            if (txttencongdung.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên công dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttencongdung.Focus();
                return;
            }
            string sql;
            sql = "SELECT macongdung FROM tbl_congdung WHERE macongdung=N'" + txtmacongdung.Text.Trim() + "'";
            if (funtion.CheckKey(sql))
            {
                MessageBox.Show("Mã công dụng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmacongdung.Focus();
                txtmacongdung.Text = "";
                return;
            }
            sql = "INSERT INTO tbl_congdung(macongdung,tencongdung) VALUES(N'" + txtmacongdung.Text.Trim() + "', N'" + txttencongdung.Text.Trim() + "')";
            funtion.RunSql(sql);
            Load_DataGridView();
            reset();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmacongdung.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbl_congdung.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmacongdung.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttencongdung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên công dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttencongdung.Focus();
                return;
            }
            sql = "UPDATE tbl_congdung SET tencongdung=N'" + txttencongdung.Text.ToString() + "' WHERE macongdung=N'" + txtmacongdung.Text + "'";
           funtion.RunSql(sql);
            Load_DataGridView();
            reset();
            btnboqua.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbl_congdung.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmacongdung.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tbl_congdung WHERE macongdung=N'" + txtmacongdung.Text + "'";
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
            txtmacongdung.Enabled = false;
        }
        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
