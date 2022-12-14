using Pro01_20CT111.BusinessLayer;
using Pro01_20CT111.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 


namespace Pro01_20CT111
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Kiểm tra textbox Tài khoản
            if (!string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                if (!string.IsNullOrEmpty(txtMatKhau.Text))
                {
                    if (KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
                    {
                        trangThaiDongForm = true;
                        ClsMain.taiKhoan = txtTaiKhoan.Text;
                        ClsMain.users = bd.GetUsers();//Lay ds users trong bien toan cuc
                        this.Close();//đóng form login
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản và mật khẩu không đúng \n Xin lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTaiKhoan.ResetText();
                        txtMatKhau.Text = string.Empty;
                        txtTaiKhoan.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập mật khẩu \n Xin lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tài khoản \n Xin lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
            }
            
        }
        BLLUser bd;
        string err = string.Empty;
       
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            bd = new BLLUser(ref err,ClsMain.path);

        }
        private bool KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            return bd.KiemTraUser(taiKhoan, matKhau);

            //if (taiKhoan.Equals("admin") && matKhau.Equals("admin"))
            //    return true;
            //return false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //this.Close();//Đóng form hiện tại
            trangThaiDongForm = true;
            Application.Exit();//đóng toàn bộ chương trình
        }
        bool trangThaiDongForm = false;
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(trangThaiDongForm==true)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Font SmallFont = new Font("Arial", 8);
        private void label4_Click(object sender, EventArgs e)
        {
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        User userr;
        

        private void button1_Click(object sender, EventArgs e)
        {
           


        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                txtMatKhau.PasswordChar = '\0';
            }else 
                {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void img_NoShow_Click(object sender, EventArgs e)
        {
            
        }
    }
}
