using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro01_20CT111
{
    
    public partial class FrmMain : Form
    {
        private bool trangThaiDongForm;

        public FrmMain()
        {
            InitializeComponent();
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();//mở form như hộp thoại
            //frmLogin.Show();//mở form
            lblThongTinDangNhap.Text = string.Format("Tài khoản đăng nhập: {0}", ClsMain.taiKhoan);
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmQuanLyTaiKhoan_Main frmQuanLyTaiKhoan_Main = new FrmQuanLyTaiKhoan_Main();
        frmQuanLyTaiKhoan_Main.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void FormRegionAndBorder(Form form, float radius, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
              
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                     
                   
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        
                         
                    }
                }
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle clientRectangle, float radius)
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
         
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmQuanLyTaiKhoan_Main frmQuanLyTaiKhoan_Main = new FrmQuanLyTaiKhoan_Main();
            frmQuanLyTaiKhoan_Main.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();


        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            trangThaiDongForm = true;
            Application.Exit();//đóng toàn bộ chương trình
        }
    }
    }



