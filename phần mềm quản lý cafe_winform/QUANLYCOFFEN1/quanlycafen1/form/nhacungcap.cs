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
    public partial class nhacungcap : Form
    {
        public nhacungcap()
        {
            funtion.ketnoi();
            InitializeComponent();
        }
        DataTable tbl_ncc;
        private void nhacungcap_Load(object sender, EventArgs e)
        {
            txtmancc.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT * FROM tbl_ncc";
            tbl_ncc = funtion.GetDataToTable(sql);
            DataGridView.DataSource = tbl_ncc;
            DataGridView.Columns[0].HeaderText = "Mã nhà cung cấp";
            DataGridView.Columns[1].HeaderText = "Tên nhà cung cấp";
            DataGridView.Columns[2].HeaderText = "Địa chỉ";
            DataGridView.Columns[3].HeaderText = "Số điện thoại";
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmancc.Focus();
                return;
            }
            if (tbl_ncc.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmancc.Text = DataGridView.CurrentRow.Cells["mancc"].Value.ToString();
            txttenncc.Text = DataGridView.CurrentRow.Cells["tenncc"].Value.ToString();
            txtdc.Text = DataGridView.CurrentRow.Cells["diachi"].Value.ToString();
            msksdt.Text = DataGridView.CurrentRow.Cells["sdt"].Value.ToString();
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
            txtmancc.Enabled = true;
            txtmancc.Focus();
            reset();
        }
        private void reset()
        {
            txtmancc.Text = "";
            txttenncc.Text = "";
            txtdc.Text = "";
            msksdt.Text = "";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmancc.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmancc.Focus();
                return;
            }
            if (txttenncc.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenncc.Focus();
                return;
            }
            if (txtdc.Text == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdc.Focus();
                return;
            }
            if (msksdt.Text == "(   )    -")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                msksdt.Focus();
                return;
            }
            string sql;
            sql = "SELECT mancc FROM tbl_ncc WHERE mancc=N'" + txtmancc.Text.Trim() + "'";
            if (funtion.CheckKey(sql))
            {
                MessageBox.Show("Mã nhà cung cấp này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmancc.Focus();
                txtmancc.Text = "";
                return;
            }
            sql = "INSERT INTO tbl_ncc(mancc,tenncc, diachi, sdt) VALUES(N'" + txtmancc.Text.Trim() + "', N'" + txttenncc.Text.Trim() + "', N'" + txtdc.Text.Trim() + "','" + msksdt.Text + "')";
            funtion.RunSql(sql);
            Load_DataGridView();
            reset();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmancc.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbl_ncc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmancc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttenncc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenncc.Focus();
                return;
            }
            if (txtdc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdc.Focus();
                return;
            }
            if (msksdt.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                msksdt.Focus();
                return;
            }
            sql = "UPDATE tbl_ncc SET  tenncc=N'" + txttenncc.Text.Trim().ToString() + "',diachi=N'" + txtdc.Text.Trim().ToString() + "',sdt='" + msksdt.Text.ToString() + "' WHERE mancc=N'" + txtmancc.Text + "'";
            funtion.RunSql(sql);
            Load_DataGridView();
            reset();
            btnboqua.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbl_ncc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmancc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tbl_ncc WHERE mancc=N'" + txtmancc.Text + "'";
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
            txtmancc.Enabled = false;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn thực sự muốn thoát ", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
