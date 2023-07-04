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
    public partial class frmQuanLyKhoa : Form
    {
        public UserModel LoginInUser;
        public frmQuanLyKhoa(UserModel user)
        {
            InitializeComponent();
            dgvQlKhoa.AutoGenerateColumns = false;
            LoginInUser = user;
        }

        private void frmQuanLyKhoa_Load(object sender, EventArgs e)
        {
            // dgvQlKhoa.DataSource = FacultyBus.GetAllFaculty();
            dgvQlKhoa.DataSource = FacultyBus.GetFacultyAfterDelete();
        }

        private void dgvQlKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvQlKhoa.Rows[e.RowIndex];
                txtTenKhoa.Text = row.Cells[1].Value.ToString();
                rtbKhoa.Text = row.Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                FacultyModel facultyModel = new FacultyModel();

                facultyModel.Name = txtTenKhoa.Text;
                facultyModel.Description = rtbKhoa.Text;
                facultyModel.CreatedUserId = LoginInUser.Id;
                facultyModel.CreatedDate = DateTime.Now;
                facultyModel.IsDeleted = false;
                if (txtTenKhoa.Text == "" || rtbKhoa.Text == "")
                {
                    MessageBox.Show("Thông Tin Không Được Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FacultyBus.InsertFaculty(facultyModel);
                    MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //dgvQlKhoa.DataSource = FacultyBus.GetAllFaculty();
                    dgvQlKhoa.DataSource = FacultyBus.GetFacultyAfterDelete();
                    txtTenKhoa.Text = "";
                    rtbKhoa.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaKhoa_Click(object sender, EventArgs e)
        {

            try
            {
                int Id = Convert.ToInt32(dgvQlKhoa.CurrentRow.Cells[0].Value);
                FacultyModel facultyModel = new FacultyModel();
                facultyModel.Id = Id;
                facultyModel.Name = txtTenKhoa.Text;
                facultyModel.Description = rtbKhoa.Text;
                facultyModel.CreatedUserId = LoginInUser.Id;
                facultyModel.CreatedDate = DateTime.Now;
                facultyModel.IsDeleted = false;
                if (txtTenKhoa.Text == "" || rtbKhoa.Text == "")
                {
                    MessageBox.Show("Thông Tin Không Được Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FacultyBus.UpdateFaculty(facultyModel);
                    MessageBox.Show("Cập Nhật Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //dgvQlKhoa.DataSource = FacultyBus.GetAllFaculty();
                    dgvQlKhoa.DataSource = FacultyBus.GetFacultyAfterDelete();
                    txtTenKhoa.Text = "";
                    rtbKhoa.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvQlKhoa.SelectedRows.Count > 0)
                {
                    int rowIndex = dgvQlKhoa.SelectedRows[0].Index;
                    int Id = Int32.Parse(dgvQlKhoa.Rows[rowIndex].Cells["FacultyID"].Value.ToString());

                    CurrencyManager currencyManager = (CurrencyManager)BindingContext[dgvQlKhoa.DataSource];
                    currencyManager.SuspendBinding();
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //dgvPhongMay.CurrentCell = dgvPhongMay.Rows[0].Cells[0];
                        FacultyBus.DeleteFaculty(Id);
                        dgvQlKhoa.Rows[rowIndex].Visible = false;
                        MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTenKhoa.Text = "";
                        rtbKhoa.Text = "";
                        dgvQlKhoa.DataSource = FacultyBus.GetFacultyAfterDelete();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiemKhoa_Click(object sender, EventArgs e)
        {
            string Name = txtTimKiemKhoa.Text;
            if (txtTimKiemKhoa.Text == "")
            {
                MessageBox.Show("Nhập Thông Tin Cần Tìm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable result = FacultyBus.SearchFacultyByName(Name);
                dgvQlKhoa.DataSource = result;
                //txtTiemKiemPhong.Text = "";
            }
        }
    }
}
