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
    public partial class frmQuanLyGiaoVien : Form
    {
        public UserModel LoginInUser;
        public frmQuanLyGiaoVien(UserModel user)
        {
            InitializeComponent();
            dgvGiaoVien.CellFormatting += dgvGiaoVien_CellFormatting;
            dgvGiaoVien.AutoGenerateColumns = false;
            dtNgaySinhGV.CustomFormat = "dd/MM/yyyy";
            LoginInUser = user;
        }

        private void btnQlChucVu_Click(object sender, EventArgs e)
        {
            frmQuanLyChucVu frmQuanLyChucVu = new frmQuanLyChucVu();
            frmQuanLyChucVu.Show();
        }

        private void frmQuanLyGiaoVien_Load(object sender, EventArgs e)
        {
            cbChucVu.DataSource = PositionBus.GetPositonAfterDelete();
            cbChucVu.DisplayMember = "Name";
            cbChucVu.ValueMember = "Id";

            //dgvGiaoVien.DataSource = TeacherBus.GetAllTeachers();
            dgvGiaoVien.DataSource = TeacherBus.GetTeachersAfterDelete();


        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvGiaoVien.Rows[e.RowIndex];
                txtHoGV.Text = row.Cells[1].Value.ToString();
                txtTenGV.Text = row.Cells[2].Value.ToString();
                dtNgaySinhGV.Text = row.Cells[4].Value.ToString();
                //rdNam.Checked = row.Cells[5].Value.ToString();
                rtbDiaChiGv.Text = row.Cells[6].Value.ToString();
                txtSdtGV.Text = row.Cells[7].Value.ToString();
                txtEmail.Text = row.Cells[8].Value.ToString();
                cbChucVu.Text = row.Cells[10].Value.ToString();
                bool currentGender = (bool)dgvGiaoVien.Rows[e.RowIndex].Cells["Gender"].Value;

                // Hiển thị RadioButton tương ứng với giới tính hiện tại
                if (currentGender)
                {
                    rdNam.Checked = true;
                }
                else
                {
                    rdbNu.Checked = true;
                }
            }
            catch
            {

            }
        }

        private void btnThemGv_Click(object sender, EventArgs e)
        {
            try
            {
                TeacherModel teacher = new TeacherModel();
                teacher.FirstName = txtHoGV.Text;
                teacher.LastName = txtTenGV.Text;
                teacher.FullName = teacher.FirstName + " " + teacher.LastName;
                teacher.Birth = dtNgaySinhGV.Value.Date;
                teacher.Email = txtEmail.Text;
                teacher.Address = rtbDiaChiGv.Text;
                teacher.Gender = rdNam.Checked;
                teacher.PositionId = (int)cbChucVu.SelectedValue;
                teacher.Phone = txtSdtGV.Text;
                teacher.CreatedUserId = LoginInUser.Id;
                teacher.CreatedDate = DateTime.Now;
                teacher.IsDeleted = false;
                teacher.Status = 0;

                TeacherBus.InsertTeacher(teacher);
                //txtHoGV.Text = "";
                //txtTenGV.Text = "";
                //txtEmail.Text = "";
                //txtSdtGV.Text = "";
                //rtbDiaChiGv.Text = "";
                dtNgaySinhGV.Value = DateTime.Now;
                cbChucVu.SelectedIndex = 0;
                rdNam.Checked = true;
                //dgvGiaoVien.DataSource = TeacherBus.GetAllTeachers();
                dgvGiaoVien.DataSource = TeacherBus.GetTeachersAfterDelete();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Đổi true false thành Nam nữ
        private void dgvGiaoVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvGiaoVien.Columns["Gender"].Index)
            {
                if (e.Value != null)
                {
                    string gender = e.Value.ToString();
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

        private void btnSuaGv_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(dgvGiaoVien.CurrentRow.Cells[0].Value);
                TeacherModel teacher = new TeacherModel();
                teacher.Id = Id;
                teacher.FirstName = txtHoGV.Text;
                teacher.LastName = txtTenGV.Text;
                teacher.FullName = teacher.FirstName + " " + teacher.LastName;
                teacher.Birth = dtNgaySinhGV.Value.Date;
                teacher.Email = txtEmail.Text;
                teacher.Address = rtbDiaChiGv.Text;
                teacher.Gender = rdNam.Checked;
                teacher.PositionId = (int)cbChucVu.SelectedValue;
                teacher.Phone = txtSdtGV.Text;
                teacher.CreatedUserId = LoginInUser.Id;
                teacher.CreatedDate = DateTime.Now;
                teacher.IsDeleted = false;
                teacher.Status = 0;

                TeacherBus.UpdateTeacher(teacher);
                txtHoGV.Text = "";
                txtTenGV.Text = "";
                txtEmail.Text = "";
                txtSdtGV.Text = "";
                rtbDiaChiGv.Text = "";
                dtNgaySinhGV.Value = DateTime.Now;
                cbChucVu.SelectedIndex = 0;
                rdNam.Checked = true;
                //dgvGiaoVien.DataSource = TeacherBus.GetAllTeachers();
                dgvGiaoVien.DataSource = TeacherBus.GetTeachersAfterDelete();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGiaoVien.SelectedRows.Count > 0)
                {
                    int rowIndex = dgvGiaoVien.SelectedRows[0].Index;
                    int Id = Int32.Parse(dgvGiaoVien.Rows[rowIndex].Cells["TeacherId"].Value.ToString());

                    CurrencyManager currencyManager = (CurrencyManager)BindingContext[dgvGiaoVien.DataSource];
                    currencyManager.SuspendBinding();
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //dgvPhongMay.CurrentCell = dgvPhongMay.Rows[0].Cells[0];
                        TeacherBus.DeleteTeacher(Id);
                        dgvGiaoVien.Rows[rowIndex].Visible = false;
                        MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtHoGV.Text = "";
                        txtTenGV.Text = "";
                        txtEmail.Text = "";
                        txtSdtGV.Text = "";
                        rtbDiaChiGv.Text = "";
                        dtNgaySinhGV.Value = DateTime.Now;
                        cbChucVu.SelectedIndex = 0;
                        rdNam.Checked = true;
                        dgvGiaoVien.DataSource = TeacherBus.GetTeachersAfterDelete();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiemGV_Click(object sender, EventArgs e)
        {
            if (txtTimKiemGV.Text == "")
            {
                MessageBox.Show("Nhập Thông Tin Cần Tìm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rdbFirstName.Checked)
                {
                    string FirstName = txtTimKiemGV.Text;
                    DataTable result = TeacherBus.SearchTeacherByFirstName(FirstName);
                    dgvGiaoVien.DataSource = result;
                }
                else if (rdbLastName.Checked)
                {
                    string LastName = txtTimKiemGV.Text;
                    DataTable result = TeacherBus.SearchTeacherByLastName(LastName);
                    dgvGiaoVien.DataSource = result;
                }
                else if (rdbPhone.Checked)
                {
                    string Phone = txtTimKiemGV.Text;
                    DataTable result = TeacherBus.SearchTeacherByPhone(Phone);
                    dgvGiaoVien.DataSource = result;
                }
                else
                {
                    MessageBox.Show("Vui Lòng Chọn 1 Phương Thức Tìm Kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
