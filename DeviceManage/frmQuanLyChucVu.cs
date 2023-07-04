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
    public partial class frmQuanLyChucVu : Form
    {
        public frmQuanLyChucVu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
        }

        private void frmQuanLyChucVu_Load(object sender, EventArgs e)
        {
            //dgvChucVu.DataSource = PositionBus.GetAllPosition();
            dgvChucVu.DataSource = PositionBus.GetPositonAfterDelete();
        }

        private void btnThemChucVu_Click(object sender, EventArgs e)
        {
            try
            {
                PositionModel positionModel = new PositionModel();
                positionModel.Name = txtTenChucVu.Text;
                positionModel.CreatedUserId = 1;
                positionModel.CreatedDate = DateTime.Now;
                positionModel.IsDeleted = false;
                if (txtTenChucVu.Text == "")
                {
                    MessageBox.Show("Thông Tin Không Được Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PositionBus.InsertPosition(positionModel);
                    MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // dgvChucVu.DataSource = PositionBus.GetAllPosition();
                    dgvChucVu.DataSource = PositionBus.GetPositonAfterDelete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvChucVu.Rows[e.RowIndex];
                txtTenChucVu.Text = row.Cells[1].Value.ToString();

            }
            catch
            {

            }
        }

        private void btnSuaChucVu_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(dgvChucVu.CurrentRow.Cells[0].Value);
                PositionModel positionModel = new PositionModel();
                positionModel.Id = Id;
                positionModel.Name = txtTenChucVu.Text;
                positionModel.CreatedUserId = 1;
                positionModel.CreatedDate = DateTime.Now;
                positionModel.IsDeleted = false;
                if (txtTenChucVu.Text == "")
                {
                    MessageBox.Show("Thông Tin Không Được Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PositionBus.UpdatePosition(positionModel);
                    MessageBox.Show("Cập Nhật Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //dgvChucVu.DataSource = PositionBus.GetAllPosition();
                    dgvChucVu.DataSource = PositionBus.GetPositonAfterDelete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaChucVu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvChucVu.SelectedRows.Count > 0)
                {
                    int rowIndex = dgvChucVu.SelectedRows[0].Index;
                    int Id = Int32.Parse(dgvChucVu.Rows[rowIndex].Cells["PositionId"].Value.ToString());

                    CurrencyManager currencyManager = (CurrencyManager)BindingContext[dgvChucVu.DataSource];
                    currencyManager.SuspendBinding();
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //dgvPhongMay.CurrentCell = dgvPhongMay.Rows[0].Cells[0];
                        PositionBus.DeletePosition(Id);
                        dgvChucVu.Rows[rowIndex].Visible = false;
                        MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTenChucVu.Text = "";
                        dgvChucVu.DataSource = PositionBus.GetPositonAfterDelete();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiemChucVu_Click(object sender, EventArgs e)
        {
            string Name = txtTiemKiemChucVu.Text;
            if (txtTiemKiemChucVu.Text == "")
            {
                MessageBox.Show("Nhập Thông Tin Cần Tìm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable result = PositionBus.SearchPositionByName(Name);
                dgvChucVu.DataSource = result;

            }
        }
    }
}
