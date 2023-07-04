using BUS.BusinessObject;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeviceManage
{
    public partial class frmTaoTaiKhoan : Form
    {
        UserModel LoginInUser;
        
        public frmTaoTaiKhoan(UserModel user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            LoginInUser = user;
        }
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            UserModel user = new UserModel();
            user.UserName = "Admin";
            user.Status = 0;
            LoginInUser = user;
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (!Check())
                {

                    MessageBox.Show("Thông Tin Không Được Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int status = 0;
                    if (cbQuyen.SelectedItem.ToString() == "Admin")
                    {
                        status = 1;
                    }
                    UserModel user = new UserModel();
                    user.CreatedDate = DateTime.Now;
                    user.CreatedUserId = LoginInUser.Id;
                    user.IsDeleted = false;
                    user.Status = status;
                    user.UserName = txtTenDangNhap.Text;
                    user.Pass = SettingClass.GetMD5(txtMatKhau.Text);
                    user.Name = txtTenHienThi.Text;
                    UserBus.InsertUser(user);
                    MessageBox.Show("Tạo Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Check()
        {
            if (txtTenDangNhap.Text.Trim() == "")
            {
                return false;
            }
            if (txtMatKhau.Text.Trim() == "" || txtMatKhau.Text.Length <= 6)
            {
                return false;
            }
            if (txtTenHienThi.Text.Trim() == "")
            {
                return false;
            }
            if (cbQuyen.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                this.Close();
            }
        }
    }
}
