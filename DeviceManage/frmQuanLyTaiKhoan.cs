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
    public partial class frmQuanLyTaiKhoan : Form
    {
        public UserModel LoginInUser;
        public frmQuanLyTaiKhoan(UserModel user)
        {
            InitializeComponent();
            LoginInUser = user;

            CkbSua.Checked = false;
            txtTenDangNhap.Visible = false;
            txtMatKhauMoi.Visible = false;
            lblMatKhauCu.Visible = false;
            lblMatKhauMoi.Visible = false;
            btnCapNhatUser.Visible = false;
            CkbSua.Visible = false;
            btnSuaTk.Enabled = false;
            btnSuaTk.BackColor = System.Drawing.Color.LightGray;
            dgvTaiKhoan.AutoGenerateColumns = false;


            dgvTaiKhoan.AutoGenerateColumns = false;
            dgvTaiKhoan.CellFormatting += dgvTaiKhoan_CellFormatting;
            dtNgaySinh.CustomFormat = "dd/MM/yyyy";
            
        }

        private void CkbMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbSua.Checked)
            {
                txtMatKhauMoi.Visible
                    = true;
                txtTenDangNhap.Visible = true;
                lblMatKhauCu.Visible = true;
                lblMatKhauMoi.Visible = true;
                btnCapNhatUser.Visible = true;
                //btnCapNhatUser.BackColor = System.Drawing.Color.Lime;
            }
            else
            {
                txtTenDangNhap.Visible = false;
                txtMatKhauMoi.Visible = false;
                lblMatKhauCu.Visible = false;
                lblMatKhauMoi.Visible = false;
                btnCapNhatUser.Visible = false;

            }
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            cbTeacher.DataSource = TeacherBus.GetTeachersAfterDelete();
            cbTeacher.DisplayMember = "FullName";
            cbTeacher.ValueMember = "Id";

            cbTenTaiKhoan.DataSource = UserBus.SelectAll();
            cbTenTaiKhoan.DisplayMember = "Name";
            cbTenTaiKhoan.ValueMember = "Id";
            dgvTaiKhoan.DataSource = DecentralizationBus.GetAllDecentralization();
        }

        private void btnTaoTk_Click(object sender, EventArgs e)
        {
            frmTaoTaiKhoan frmTaoTaiKhoan = new frmTaoTaiKhoan(LoginInUser);
            frmTaoTaiKhoan.Show();
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvTaiKhoan.Rows[e.RowIndex];
                cbTeacher.Text = row.Cells["TeacherName"].Value.ToString();
                bool currentGender = (bool)dgvTaiKhoan.Rows[e.RowIndex].Cells["TeacherGender"].Value;
                if (currentGender)
                {
                    rdNam.Checked = true;
                }
                else
                {
                    rdNu.Checked = true;
                }
                txtSDT.Text = row.Cells["TeacherPhone"].Value.ToString();
                dtNgaySinh.Text = row.Cells["TeacherBirth"].Value.ToString();
                cbTenTaiKhoan.Text = row.Cells["NameUser"].Value.ToString();

                CkbSua.Visible = true;
                btnSuaTk.Enabled = true;
                btnSuaTk.BackColor = System.Drawing.Color.Transparent;

            }
            catch
            {

            }
        }

        private void dgvTaiKhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvTaiKhoan.Columns["TeacherGender"].Index)
            {
                if (e.Value != null)
                {
                    string gender = e.Value.ToString();
                    {
                        if (gender == "True")
                        {
                            e.Value = "Nam";
                        }
                        else if (gender == "False")
                        {
                            e.Value = "Nữ";
                        }
                    }
                }
            }
        }

        private void btnThemTk_Click(object sender, EventArgs e)
        {
            DecentralizationModel decentralizationModel = new DecentralizationModel();
            decentralizationModel.TeacherId = (int)cbTeacher.SelectedValue;
            decentralizationModel.UserId = (int)cbTenTaiKhoan.SelectedValue;
            decentralizationModel.CreatedDate = DateTime.Now;
            decentralizationModel.CreatedUserId = LoginInUser.Id;
            decentralizationModel.IsDeleted = false;
            try
            {
                DecentralizationBus.InSertDecentralization(decentralizationModel);
                MessageBox.Show("Tạo Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTaiKhoan.DataSource = DecentralizationBus.GetAllDecentralization();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnSuaTk_Click(object sender, EventArgs e)
        {

            DecentralizationModel decentralizationModel = new DecentralizationModel();
            int Id = Convert.ToInt32(dgvTaiKhoan.CurrentRow.Cells[0].Value);
            decentralizationModel.Id = Id;
            decentralizationModel.TeacherId = (int)cbTeacher.SelectedValue;
            decentralizationModel.UserId = (int)cbTenTaiKhoan.SelectedValue;
            decentralizationModel.CreatedDate = DateTime.Now;
            decentralizationModel.CreatedUserId = LoginInUser.Id;
            decentralizationModel.IsDeleted = false;
            try
            {
                DecentralizationBus.UpdateDecentralization(decentralizationModel);
                MessageBox.Show("Cập Nhật Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTaiKhoan.DataSource = DecentralizationBus.GetAllDecentralization();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhatUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenDangNhap.Text == "" || txtMatKhauMoi.Text == "")
                {
                    MessageBox.Show("Thông Tin Không Được Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int Id = Convert.ToInt32(dgvTaiKhoan.CurrentRow.Cells["UserId"].Value);
                    UserModel user = new UserModel();
                    user.Id = Id;
                    user.UserName = txtTenDangNhap.Text;
                    user.Pass = SettingClass.GetMD5(txtMatKhauMoi.Text);
                    user.CreatedDate = DateTime.Now;
                    user.CreatedUserId = LoginInUser.Id;
                    user.IsDeleted = false;
                    DecentralizationBus.UpdateUserNameAndPass(user);
                    MessageBox.Show("Cập Nhật Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnThuHoiTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTaiKhoan.SelectedRows.Count > 0)
                {
                    int rowIndex = dgvTaiKhoan.SelectedRows[0].Index;
                    int Id = Int32.Parse(dgvTaiKhoan.Rows[rowIndex].Cells["UserId"].Value.ToString());

                    CurrencyManager currencyManager = (CurrencyManager)BindingContext[dgvTaiKhoan.DataSource];
                    currencyManager.SuspendBinding();
                    DialogResult result = MessageBox.Show("Bạn Có Muốn Thu Hồi Không?", "Thu Hồi", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //dgvPhongMay.CurrentCell = dgvPhongMay.Rows[0].Cells[0];
                        DecentralizationBus.DeleteDecentralization(Id);
                        dgvTaiKhoan.Rows[rowIndex].Visible = false;
                        MessageBox.Show("Thu Hồi Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dgvTaiKhoan.DataSource = DecentralizationBus.GetAllDecentralization();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
