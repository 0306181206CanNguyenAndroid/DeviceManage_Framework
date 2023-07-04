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
    public partial class frmLogin : Form
    {
        private Button button1;
        private CheckBox checkBox1;

        public frmLogin()
        {
            InitializeComponent();
        }
        private void T_logout(object sender, Action_LogoutSuccessEventArgs e)
        {
            //throw new NotImplementedException();
            this.Show();
        }

        private void btbDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == ""||txtMatKhau.Text=="")
            {
                MessageBox.Show("Tên Đăng Nhập Hoặc Mật Khẩu Trống");
            }
            else
            {
                string UserName = txtTenDangNhap.Text;
                string Pass =SettingClass.GetMD5 (txtMatKhau.Text);
                UserModel user = DecentralizationBus.GetUserByUserName_Pass(UserName, Pass);
                if (user != null)
                {
                    int UserId=user.Id;
                    if(DecentralizationBus.CheckUserId(UserId))
                    {
                        int Status = DecentralizationBus.GetStatusByUserId(UserId);
                        this.Hide();
                        if (Status == 1) {
                            //là admin
                            UserModel userModel=DecentralizationBus.GetInfoById(UserId);
                            frmTrangChu frmTrangChu = new frmTrangChu(userModel);
                            frmTrangChu.logout += T_logout;
                            frmTrangChu.ShowDialog();
                            
                        }else if(Status==0) 
                        {
                            //giáo viên
                            UserModel userModel = DecentralizationBus.GetInfoById(UserId);
                            frmTrangChuGiaoVien frmTrangChuGiaoVien=new frmTrangChuGiaoVien(userModel);
                            frmTrangChuGiaoVien.logout += T_logout;
                            frmTrangChuGiaoVien.ShowDialog();
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn Không Có Quyền Đăng Nhập");
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
