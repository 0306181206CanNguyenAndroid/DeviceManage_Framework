using BUS.BusinessObject;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeviceManage
{
    public partial class frmTrangChuGiaoVien : Form
    {
        public UserModel LoginInUser;
        public event FireEventForAction_LogoutSuccess logout = null;
        public frmTrangChuGiaoVien(UserModel user)
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

        private void btnQlThanhLy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyThanhLy());
            lbl_text.Text = btnQlThanhLy.Text;
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyTaiKhoan(LoginInUser));
            lbl_text.Text = btnQLTaiKhoan.Text;
        }

        private void frmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông Báo", MessageBoxButtons.OKCancel)
                == System.Windows.Forms.DialogResult.OK)
            {
                if (logout != null)
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
    }
}
