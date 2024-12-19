using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using quanlycaphe.Forms;
using quanlynhanvien;
using quandidulieu;
using quanlycafen1.form;

namespace quanlycafen1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            funtion.ketnoi(); 
        }

       

        private void nhânviênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhanvien a = new Nhanvien();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        

        private void hoáĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hdn a = new hdn();  
            this.Hide(); a.ShowDialog();
            this.Show();
        }

        private void côngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            congdung a = new congdung();
            this.Hide(); a.ShowDialog();
            this.Show();
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loaisp a = new loaisp();
            this.Hide(); a.ShowDialog();
            this.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sanpham a = new sanpham();
            this.Hide(); a.ShowDialog();
            this.Show();
           
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            khachhang a = new khachhang();
            this.Hide(); a.ShowDialog();
            this.Show();
        }

        private void hoáĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmhoadonbanhang a = new frmhoadonbanhang();
            this.Hide(); a.ShowDialog();
            this.Show();


        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void báoCáoDanhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nhacungcap a = new nhacungcap();
            this.Hide(); a.ShowDialog();
            this.Show();
        }

        private void chiTiếtHoáĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void báoCáoThanhSachSáchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoHoáĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formbaocaonhaphang a = new formbaocaonhaphang();
            this.Hide(); a.ShowDialog();
            this.Show();
        }

        private void báoCáoBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baocaodanhsachban a = new baocaodanhsachban();
            this.Hide(); a.ShowDialog();
            this.Show();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn thức sự muốn đóng ứng dụng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void hoáĐơnNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timkiemhdn a = new timkiemhdn();
            this.Hide(); a.ShowDialog();
            this.Show();
        }

        private void hoáĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timkiemhoadonban a = new timkiemhoadonban();
            this.Hide(); a.ShowDialog();
            this.Show();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baocaodoanhthu a = new baocaodoanhthu();
            this.Hide(); a.ShowDialog();
            this.Show();
        }
    }
}
