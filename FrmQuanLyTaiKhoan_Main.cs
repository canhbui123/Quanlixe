
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
    public partial class FrmQuanLyTaiKhoan_Main : Form
    {
        public FrmQuanLyTaiKhoan_Main()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmQuanLyTaiKhoan_Modified frmQuanLyTaiKhoan_Modified = new FrmQuanLyTaiKhoan_Modified();
            frmQuanLyTaiKhoan_Modified.isAdd = true;
            frmQuanLyTaiKhoan_Modified.ShowDialog();
            LoadUsers();
        }

       
        String er = string.Empty;
        private void FrmQuanLyTaiKhoan_Main_Load(object sender, EventArgs e)
        {
            bd = new BLLUser(ref er, ClsMain.path);
            LoadUsers();
        }

        private void LoadUsers()
        {
            var bindingList = new BindingList<User>(ClsMain.users);
            var source = new BindingSource(bindingList, null);
        
            dgvUsers.DataSource = source;
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //lay du lieu User de chua 
          
           
        }
        //tao 1 bien kieu user
        User user;
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                FrmQuanLyTaiKhoan_Modified frmQuanLyTaiKhoan_Modified = new FrmQuanLyTaiKhoan_Modified();
                frmQuanLyTaiKhoan_Modified.user = user;
                frmQuanLyTaiKhoan_Modified.isAdd = false;
                frmQuanLyTaiKhoan_Modified.ShowDialog();
                LoadUsers();    
            }
        }

        private void dgvUsers_Click(object sender, EventArgs e)
        {
            if (dgvUsers.Rows.Count > 0)
            {
                user = new User()
                {
                    ID = Convert.ToInt32(dgvUsers.CurrentRow.Cells["colID"].Value.ToString()),
                    TaiKhoan = dgvUsers.CurrentRow.Cells["colTaiKhoan"].Value.ToString(),
                    MatKhau = dgvUsers.CurrentRow.Cells["colMatKhau"].Value.ToString(),
                    HoVaTen = dgvUsers.CurrentRow.Cells["colHoVaTen"].Value.ToString(),
                    NhoMatKhau = Convert.ToBoolean(dgvUsers.CurrentRow.Cells["colNhoMatKhau"].Value.ToString()),
                };
            }
        }
        BLLUser bd;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                int index = 0;
                foreach(User item in ClsMain.users.ToList()){
                
                    if (item.ID == user.ID)
                    {
                        ClsMain.users.RemoveAt(index);
                        break;
                    }
                    index++;
                }

             
                if (bd.WriterUser(ref er, ClsMain.users))
                {
                    LoadUsers();
                    MessageBox.Show("Thanh cong");
                 
                }
            }
            else
            {
                MessageBox.Show("chưa chọn user cần xóa !!!! \n chọn lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNap_Click(object sender, EventArgs e)
        {
            FrmQuanLyTaiKhoan_Modified frmQuanLyTaiKhoan_Modified = new FrmQuanLyTaiKhoan_Modified();
            frmQuanLyTaiKhoan_Modified.isAdd = true;
            frmQuanLyTaiKhoan_Modified.ShowDialog();
            LoadUsers();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmQuanLyTaiKhoan_Modified frmQuanLyTaiKhoan_Modified = new FrmQuanLyTaiKhoan_Modified();
            frmQuanLyTaiKhoan_Modified.isAdd = true;
            frmQuanLyTaiKhoan_Modified.ShowDialog();
            LoadUsers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                FrmQuanLyTaiKhoan_Modified frmQuanLyTaiKhoan_Modified = new FrmQuanLyTaiKhoan_Modified();
                frmQuanLyTaiKhoan_Modified.user = user;
                frmQuanLyTaiKhoan_Modified.isAdd = false;
                frmQuanLyTaiKhoan_Modified.ShowDialog();
                LoadUsers();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                int index = 0;
                foreach (User item in ClsMain.users.ToList())
                {

                    if (item.ID == user.ID)
                    {
                        ClsMain.users.RemoveAt(index);
                        break;
                    }
                    index++;
                }


                if (bd.WriterUser(ref er, ClsMain.users))
                {
                    LoadUsers();
                    MessageBox.Show("Thanh cong");

                }
            }
            else
            {
                MessageBox.Show("chưa chọn user cần xóa !!!! \n chọn lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
