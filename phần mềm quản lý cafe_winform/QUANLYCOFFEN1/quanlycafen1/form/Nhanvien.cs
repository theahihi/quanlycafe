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
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();
        }

        DataTable tbnv;

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            
            btluu.Enabled=false;
            btboqua.Enabled=false;
            txtmanv.Enabled=false;
            load_dtgv();
            loadcbbque();
            cbbque.DropDownStyle = ComboBoxStyle.DropDownList;
          
            cbbque.Enabled = false;
        }
        private void load_dtgv()
        {

            string sql = "select*from tbl_nhanvien";
            tbnv = funtion.GetDataToTable(sql);
            dtgrvnhanvien.DataSource = tbnv;
            dtgrvnhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dtgrvnhanvien.Columns[1].HeaderText = "Tên nhân viên";
            dtgrvnhanvien.Columns[2].HeaderText = "Địa chỉ";
            dtgrvnhanvien.Columns[3].HeaderText = "Giới tính";
            dtgrvnhanvien.Columns[4].HeaderText = "Ngày Sinh";
            dtgrvnhanvien.Columns[5].HeaderText = "Mã quê";
            dtgrvnhanvien.Columns[6].HeaderText = "Số điện thoại";
            dtgrvnhanvien.AllowUserToAddRows = false;
            dtgrvnhanvien.EditMode = DataGridViewEditMode.EditProgrammatically;



        }
        private void loadcbbque()
        {
            funtion.FillCombo("select *from tbl_que", cbbque, "maque", "tenque");

        }

        private void dtgrvnhanvien_Click(object sender, EventArgs e)
        {
            string ma;
            if(btthem.Enabled==false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(tbnv.Rows.Count == 0 )
            {
                MessageBox.Show("Không có dữ liệu  ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtmanv.Text = dtgrvnhanvien.CurrentRow.Cells["manv"].Value.ToString();
            txttennv.Text= dtgrvnhanvien.CurrentRow.Cells["tennv"].Value.ToString();
            if(dtgrvnhanvien.CurrentRow.Cells["gioitinh"].Value.ToString() == "Nam")
                rdogit.Checked = true;
            else
                rdogit.Checked= false;  
            mskngaysinh.Text= dtgrvnhanvien.CurrentRow.Cells["ngaysinh"].Value.ToString();
            msksdt.Text= dtgrvnhanvien.CurrentRow.Cells["sdt"].Value.ToString();
            ma = dtgrvnhanvien.CurrentRow.Cells["maque"].Value.ToString();
            cbbque.Text = funtion.GetFieldValues("select tenque from tbl_que where maque = N'" + ma + "'");
            txtdiachi.Text = dtgrvnhanvien.CurrentRow.Cells["diachi"].Value.ToString();
            btboqua.Enabled = true;
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            reset();
            btthem.Enabled = false;
            btluu.Enabled = true;
            btboqua.Enabled = true;
            txtmanv.Enabled = true;
            cbbque.Enabled = true;
            btxoa.Enabled = false;
            btsua.Enabled = false;
           
        }
        private void reset()
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            txtdiachi.Text = "";
            rdogit.Checked = false;
            mskngaysinh.Text = "  /  /";
            msksdt.Text = "(   )    -";
            cbbque.SelectedIndex = -1;

        }

        private void btluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmanv.Text == "")
            {
                MessageBox.Show("chưa có Mã nhân viên ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmanv.Focus();
                return;
            }
            if (txttennv.Text == "")
            {
                MessageBox.Show("Chưa có tên nhân viên ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttennv.Focus();   
                return;
            }
            if (mskngaysinh.Text == "  /  /")
            {
                MessageBox.Show("Chưa có ngày sinh ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskngaysinh.Focus();
                return;
            }
            if (msksdt.Text == "(   )    -")
            {
                MessageBox.Show("Chưa có số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msksdt.Focus();
                return;
            }
            if (cbbque.Text == "")
            {
                MessageBox.Show("chưa có mã quê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbque.Focus();
                return;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show("chưa có địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbque.Focus();
                return;
            }
            if (!funtion.IsDate(mskngaysinh.Text))
            {
                MessageBox.Show("nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskngaysinh.Focus();
                mskngaysinh.Text = "";
                return;
            }
            sql = "select manv from tbl_nhanvien where manv = N'" + txtmanv.Text + "'";
            if(funtion.CheckKey(sql))
            {
                MessageBox.Show("Mã Nhân viên đã có ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
              txtmanv.Focus();
               txtmanv.Text = "";
                return;
            }
            string gt;
            if (rdogit.Checked == true)
            {
                gt = "Nam";
            }
            else
                gt = "Nữ";
            string manv = txtmanv.Text.Replace(" ", "");
            sql = "insert into tbl_nhanvien values(N'" + manv.ToUpper()+ "',N'" + txttennv.Text + "',N'"+txtdiachi.Text+"',N'" + gt + "',N'" + funtion.ConvertDateTime(mskngaysinh.Text) + "',N'" + cbbque.SelectedValue.ToString() + "',N'" + msksdt.Text + "')";
            funtion.RunSql(sql);
            load_dtgv();
            reset();
            txtmanv.Enabled= false;
            btthem.Enabled=true;
            btluu.Enabled=false;
            btboqua.Enabled=false;
            btxoa.Enabled=true;
            btsua.Enabled=true;
           

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if(tbnv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu nào để xoá ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtmanv.Text == "")
            {
                MessageBox.Show("hãy chọn dữ liệu để xoá ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult a = MessageBox.Show("Bạn thực sự muốn xoá dữ liệu này","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                string sql;
                sql = "delete from tbl_nhanvien where manv =N'" + txtmanv.Text + "'";
                funtion.RunSql(sql);
                load_dtgv();
                reset();
                return;
            }

            
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if(txtmanv.Text == "")
            {
                MessageBox.Show("hãy chọn dữ liệu để xoá ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                return;
            }
            if (txttennv.Text == "")
            {
                MessageBox.Show("hãy nhập tên nhân viên", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttennv.Focus();
                return;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show("hãy nhập địa chỉ nhân viên", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 txtdiachi.Focus();
                return;
            }
            if(mskngaysinh.Text== "  /  /")
            {
                MessageBox.Show("hãy nhập ngày sinh nhân viên", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskngaysinh.Focus();
                return;
            }
            if(msksdt.Text== "(   )    -")
            {
                MessageBox.Show("hãy nhập số điện thoại  nhân viên", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msksdt.Focus();
                return;
            }
            string sql,gt;
            if (rdogit.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            if (!funtion.IsDate(mskngaysinh.Text))
            {
                MessageBox.Show("nhập lại ngày sinh ","Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                mskngaysinh.Text = "";
                mskngaysinh.Focus();
                return;
            }
            sql = " update tbl_nhanvien set tennv=N'" + txttennv.Text + "', diachi=N'" + txtdiachi.Text + "',gioitinh=N'" + gt + "',ngaysinh=N'" + funtion.ConvertDateTime(mskngaysinh.Text) + "',maque='" + cbbque.Text + "', sdt ='" + msksdt.Text + "' where manv=N'"+txtmanv.Text+"'  ";
            funtion.RunSql(sql);
            load_dtgv();
            reset();
            btboqua.Enabled = false;


        }

        private void btboqua_Click(object sender, EventArgs e)
        {
           reset();
            txtmanv.Enabled= false;
            btthem.Enabled = true;
            btluu.Enabled = false;
            btboqua.Enabled = false;
            btxoa.Enabled = true;
            btsua.Enabled = true;
            load_dtgv();
           


        }

        private void btxoaa_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn thực sự muốn đóng ","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(a == DialogResult.Yes)
            {
                this.Close();
            }
        }

      
        
    }
}
