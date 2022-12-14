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
    public partial class FrmQuanLyTaiKhoan_Modified : Form
    {
        public FrmQuanLyTaiKhoan_Modified()
        {
            InitializeComponent();
        }
 
        BLLUser bd;
        string err = string.Empty;

        public User user = null;
        public bool isAdd = false;


        private void FrmQuanLyTaiKhoan_Modified_Load(object sender, EventArgs e)
        {
            bd = new BLLUser(ref err,ClsMain.path);
            if (isAdd == true)
            {
                //them moi va tạo id tu dong tang 
               txtID.Text= TangIDTuDong().ToString();
                txtID.Enabled=false;
                {
}

            }
            else
            {
                // sua 
                txtID.Text = user.ID.ToString();
                txtID.Enabled = false;
                txtTaiKhoan.Text = user.TaiKhoan;
                txtMatKhau.Text = user.MatKhau;
                txtHoVaTen.Text = user.HoVaTen;
                ckbNhoMatKhau.Checked = user.NhoMatKhau;
            }
        }

        private int TangIDTuDong()
        {
            int maxID = 0;
             foreach (User item in ClsMain.users)
             {
                if (item.ID >= maxID)
                    maxID = item.ID;
            }
            return maxID + 1;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //kiem tra du lieu
            if(!string.IsNullOrEmpty(txtID.Text))
            {
                if (!string.IsNullOrEmpty(txtTaiKhoan.Text))
                {
                    if(!string.IsNullOrEmpty(txtMatKhau.Text))
                    {
                        if(!string.IsNullOrEmpty(txtHoVaTen.Text))
                        {
                            user = new User()
                            {
                                ID = Convert.ToInt32(txtID.Text),
                                TaiKhoan = txtTaiKhoan.Text,
                                MatKhau = txtMatKhau.Text,
                                HoVaTen = txtHoVaTen.Text,
                                NhoMatKhau = ckbNhoMatKhau.Checked
                            }; if (isAdd) { ClsMain.users.Add(user); }
                            else
                            {
                                foreach(User item in ClsMain.users){
                                if(item.ID == user.ID)
                                {
                                    item.TaiKhoan = user.TaiKhoan;
                                    item.MatKhau = user.MatKhau;
                                    item.HoVaTen = user.HoVaTen;
                                    item.NhoMatKhau = user.NhoMatKhau;
                                    
                                    }
                                    
                                }
                            }
                            
                            if(bd.WriterUser(ref err,ClsMain.users))
                            {
                                MessageBox.Show("Thanh cong");
                                this.Close();
                            }
                        }
                    }
                }
            }
        }

        
    }
}
