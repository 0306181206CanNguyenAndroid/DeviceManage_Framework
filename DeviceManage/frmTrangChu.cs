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
    public partial class frmTrangChu : Form
    {
        public UserModel LoginInUser;
        public event FireEventForAction_LogoutSuccess logout = null;
        public frmTrangChu(UserModel user)
        {
            InitializeComponent();
            Setting();
            LoginInUser = user;
            lblNameUser.Text = LoginInUser.Name;
        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            
        }

        public void Setting()
        {
            Rectangle r = new Rectangle(0, 0, userImage.Width, userImage.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            gp.AddEllipse(0, 0, userImage.Width - 3, userImage.Height - 3);
            Region rg = new Region(gp);
            userImage.Region = rg;
        }



        private void pictureBox_Logo_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            lbl_text.Text = "QUẢN LÝ THIẾT BỊ PHÒNG MÁY";
        }



        private void btnQLPhongMay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyPhongMay(LoginInUser));
            lbl_text.Text = btnQLPhongMay.Text;
        }

        private void btnQlThietBi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeviceMangement());
            lbl_text.Text = btnQlThietBi.Text;
        }

        private void btnQlKhoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyKhoa(LoginInUser));
            lbl_text.Text = btnQlKhoa.Text;
        }

        private void btnQlThuongHieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyThuongHieu(LoginInUser));
            lbl_text.Text = btnQlThuongHieu.Text;
        }

        private void btnQlThanhLy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyThanhLy());
            lbl_text.Text = btnQlThanhLy.Text;
        }

        private void btbQlLoaiThietBi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyLoaiThietBi(LoginInUser));
            lbl_text.Text = btnQlLoaiThietBi.Text;
        }

        private void btnQlGiaoVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyGiaoVien(LoginInUser));
            lbl_text.Text = btnQlGiaoVien.Text;
        }
        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyTaiKhoan(LoginInUser));
            lbl_text.Text = btnQLTaiKhoan.Text;
        }

        private void frmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageClass.Message_Event_YesNo("thoát chương trình","Lưu ý!"))
            {
                if(logout!=null)
                {
                    logout(this, new Action_LogoutSuccessEventArgs { });
                }
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBaoCaoThongKe());
            lbl_text.Text=btnBaoCaoThongKe.Text;
        }
    }
}
