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
    public partial class frmQuanLyThuongHieu : Form
    {
        private int RowIndex;
        public UserModel LoginInUser;
        public frmQuanLyThuongHieu(UserModel user)
        {
            InitializeComponent();
            dgvThuongHieu.AutoGenerateColumns = false;
            LoginInUser = user;
        }

        private void frmQuanLyThuongHieu_Load(object sender, EventArgs e)
        {
            //dgvThuongHieu.DataSource = BrandBus.GetAllBrand();
            dgvThuongHieu.DataSource = BrandBus.GetBrandAfterDelete();
        }

        private void btnThemThuongHieu_Click(object sender, EventArgs e)
        {
            try
            {
                BrandModel brandModel = new BrandModel();
                brandModel.Name = txtTenThuongHieu.Text;
                brandModel.Address = rtbDiaChi.Text;
                brandModel.CreatedUserId = LoginInUser.Id;
                brandModel.CreatedDate = DateTime.Now;
                brandModel.IsDeleted = false;
                brandModel.Status = 0;
                if (txtTenThuongHieu.Text == "" || rtbDiaChi.Text == "")
                {
                    MessageBox.Show("Thông Tin Không Được Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    BrandBus.InsertBrand(brandModel);
                    MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //dgvThuongHieu.DataSource = BrandBus.GetAllBrand();
                    txtTenThuongHieu.Text = "";
                    rtbDiaChi.Text = "";
                    dgvThuongHieu.DataSource = BrandBus.GetBrandAfterDelete();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvThuongHieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvThuongHieu.Rows[e.RowIndex];

                txtTenThuongHieu.Text = row.Cells[1].Value.ToString();
                rtbDiaChi.Text = row.Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnSuaThuongHieu_Click(object sender, EventArgs e)
        {

            try
            {
                //DataGridViewRow row = dgvThuongHieu.Rows[RowIndex];
                int Id = Convert.ToInt32(dgvThuongHieu.CurrentRow.Cells[0].Value);
                BrandModel brandModel = new BrandModel();
                brandModel.Id = Id;
                brandModel.Name = txtTenThuongHieu.Text;
                brandModel.Address = rtbDiaChi.Text;
                brandModel.CreatedUserId = LoginInUser.Id;
                brandModel.CreatedDate = DateTime.Now;
                brandModel.IsDeleted = false;
                brandModel.Status = 0;
                if (txtTenThuongHieu.Text == "" || rtbDiaChi.Text == "")
                {
                    MessageBox.Show("Thông Tin Không Được Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    BrandBus.UpdateBrand(brandModel);
                    MessageBox.Show("Cập Nhật Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //dgvThuongHieu.DataSource = BrandBus.GetAllBrand();
                    txtTenThuongHieu.Text = "";
                    rtbDiaChi.Text = "";
                    dgvThuongHieu.DataSource = BrandBus.GetBrandAfterDelete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaThuongHieu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvThuongHieu.SelectedRows.Count > 0)
                {
                    int rowIndex = dgvThuongHieu.SelectedRows[0].Index;
                    int Id = Int32.Parse(dgvThuongHieu.Rows[rowIndex].Cells["ID"].Value.ToString());

                    CurrencyManager currencyManager = (CurrencyManager)BindingContext[dgvThuongHieu.DataSource];
                    currencyManager.SuspendBinding();
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //dgvPhongMay.CurrentCell = dgvPhongMay.Rows[0].Cells[0];
                        BrandBus.DeleteBrand(Id);
                        dgvThuongHieu.Rows[rowIndex].Visible = false;
                        MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTenThuongHieu.Text = "";
                        rtbDiaChi.Text = "";
                        dgvThuongHieu.DataSource = BrandBus.GetBrandAfterDelete();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiemThuongHieu_Click(object sender, EventArgs e)
        {
            string Name = txtTiemKiemThuongHieu.Text;
            if (txtTiemKiemThuongHieu.Text == "")
            {
                MessageBox.Show("Nhập Thông Tin Cần Tìm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable result = BrandBus.SearchBrandByName(Name);
                dgvThuongHieu.DataSource = result;

            }
        }
    }
}
