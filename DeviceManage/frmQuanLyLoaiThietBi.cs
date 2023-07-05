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
    public partial class frmQuanLyLoaiThietBi : Form
    {
        int currentDeviceType = 0;
        public UserModel LoginInUser;
        public frmQuanLyLoaiThietBi(UserModel user)
        {
            InitializeComponent();
            dgvLoaiTb.AutoGenerateColumns = false;
            QuanLyLoaiThietBi_Load();
            LoginInUser = user;
        }

        private void QuanLyLoaiThietBi_Load()
        {
            dgvLoaiTb.DataSource = Device_TypeBus.GetDevice_TypeAfterDelete();
            //dgvLoaiTb.DataSource = Device_TypeBus.getAllDevice_Type();
        }

        private void frmQuanLyLoaiThietBi_Load(object sender, EventArgs e)
        {
            //dgvLoaiTb.DataSource = Device_TypeBus.getAllDevice_Type();
            dgvLoaiTb.DataSource = Device_TypeBus.GetDevice_TypeAfterDelete();
        }

        private void btnThemLoaiTB_Click(object sender, EventArgs e)
        {
            try
            {
                Device_TypeModel _TypeModel = new Device_TypeModel();

                _TypeModel.Name = txtTenLoaiTB.Text;
                _TypeModel.Description = rtbMotaLoaiTB.Text;
                _TypeModel.CreatedUserId = LoginInUser.Id;
                _TypeModel.CreatedDate = DateTime.Now;
                _TypeModel.IsDeleted = false;
                _TypeModel.Status = 0;
                if (txtTenLoaiTB.Text == "" || rtbMotaLoaiTB.Text == "")
                {
                    MessageBox.Show("Thông Tin Không Được Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Device_TypeBus.InsertDevice_Type(_TypeModel);
                    MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvLoaiTb.DataSource = Device_TypeBus.GetDevice_TypeAfterDelete();
                    txtTenLoaiTB.Text = "";
                    rtbMotaLoaiTB.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvLoaiTb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvLoaiTb.Rows[e.RowIndex];
                currentDeviceType = (int)row.Cells[0].Value;
                txtTenLoaiTB.Text = row.Cells[1].Value.ToString();
                rtbMotaLoaiTB.Text = row.Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        private void dtgvListDevice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLoaiTb.SelectedCells.Count > 0)
            {
                currentDeviceType = (int)dgvLoaiTb.SelectedCells[0].OwningRow.Cells["DeviceTypeId"].Value;
            }

        }

        private void btnSuaLoaiTb_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(dgvLoaiTb.CurrentRow.Cells[0].Value);
                Device_TypeModel _TypeModel = new Device_TypeModel();
                _TypeModel.Id = Id;
                _TypeModel.Name = txtTenLoaiTB.Text;
                _TypeModel.Description = rtbMotaLoaiTB.Text;
                _TypeModel.CreatedUserId = 1;
                _TypeModel.CreatedDate = DateTime.Now;
                _TypeModel.IsDeleted = false;
                _TypeModel.Status = 0;
                if (txtTenLoaiTB.Text == "" || rtbMotaLoaiTB.Text == "")
                {
                    MessageBox.Show("Thông Tin Không Được Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Device_TypeBus.UpdateDevice_Type(_TypeModel);
                    MessageBox.Show("Cập Nhật Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvLoaiTb.DataSource = Device_TypeBus.GetDevice_TypeAfterDelete();
                    txtTenLoaiTB.Text = "";
                    rtbMotaLoaiTB.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaLoaiTb_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLoaiTb.SelectedRows.Count > 0)
                {
                    int rowIndex = dgvLoaiTb.SelectedRows[0].Index;
                    int Id = Int32.Parse(dgvLoaiTb.Rows[rowIndex].Cells["DeviceTypeId"].Value.ToString());

                    CurrencyManager currencyManager = (CurrencyManager)BindingContext[dgvLoaiTb.DataSource];
                    currencyManager.SuspendBinding();
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //dgvPhongMay.CurrentCell = dgvPhongMay.Rows[0].Cells[0];
                        Device_TypeBus.DeleteDevice_Type(Id);
                        dgvLoaiTb.Rows[rowIndex].Visible = false;
                        MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTenLoaiTB.Text = "";
                        rtbMotaLoaiTB.Text = "";
                        dgvLoaiTb.DataSource = Device_TypeBus.GetDevice_TypeAfterDelete();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddSpecs_Click(object sender, EventArgs e)
        {
            if (currentDeviceType != 0)
            {
                Form addSpecs = new frmSetSpecsForDeviceType(Device_TypeBus.SelectByPrimaryKey(currentDeviceType));
                addSpecs.Show();
            }
        }

        private void btnTimKiemLoaiTb_Click(object sender, EventArgs e)
        {

        }
    }
}
