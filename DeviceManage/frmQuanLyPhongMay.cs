using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO.Model;
using BUS.BusinessObject;

namespace DeviceManage
{
    public partial class frmQuanLyPhongMay : Form
    {
        private int selectedRowIndex;
        public UserModel LoginLoginInUser;
        public frmQuanLyPhongMay(UserModel loginLoginInUser)
        {
            InitializeComponent();
            dgvPhongMay.AutoGenerateColumns = false;
            LoginLoginInUser = loginLoginInUser;
        }

        private void frmQuanLyPhongMay_Load(object sender, EventArgs e)
        {
            //dgvPhongMay.DataSource = RoomBus.GetAllRoom();
            dgvPhongMay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            cb_Room.DataSource = RoomBus.GetRoomAfterDelete();
            //dgvPhongMay.DataSource = RoomBus.GetRoomAfterDelete();
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            //RoomModel roomModel = new RoomModel();
            //roomModel.Code = txtMaPhong.Text;
            //roomModel.Name = txtTenPhong.Text;
            //roomModel.Description = rtbGhiChuPhong.Text;
            //roomModel.CreatedDate = DateTime.Now;
            //roomModel.CreatedUserId = 1;
            //roomModel.IsDeleted = false;
            //roomModel.Status = 0;
            //int deviceQuantity;
            //if (int.TryParse(txtSoLuongTB.Text, out deviceQuantity))
            //{
            //    roomModel.DeviceQuantity = deviceQuantity;
            //}
            //else
            //{
            //    MessageBox.Show("Số Lượng Thiết Bị Phải là Số Nguyên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //try
            //{
            //    if (txtMaPhong.Text == "" || txtTenPhong.Text == "" || rtbGhiChuPhong.Text == "" || txtSoLuongTB.Text == "")
            //    {
            //        MessageBox.Show("Thông Tin Không Được Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    {
            //        RoomBus.InSertRoom(roomModel);
            //        MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        //dgvPhongMay.DataSource = RoomBus.GetAllRoom();
            //        dgvPhongMay.DataSource = RoomBus.GetRoomAfterDelete();
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


        }

        private void dgvPhongMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    DataGridViewRow row = new DataGridViewRow();
            //    row = dgvPhongMay.Rows[e.RowIndex];
            //    txtMaPhong.Text = row.Cells[1].Value.ToString();
            //    txtTenPhong.Text = row.Cells[2].Value.ToString();
            //    txtSoLuongTB.Text = row.Cells[4].Value.ToString();
            //    rtbGhiChuPhong.Text = row.Cells[3].Value.ToString();
            //    selectedRowIndex = e.RowIndex;
            //}
            //catch
            //{

            //}
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            //    DataGridViewRow row = dgvPhongMay.Rows[selectedRowIndex];
            //    int Id = int.Parse(row.Cells[0].Value.ToString());
            //    RoomModel roomModel = new RoomModel();
            //    roomModel.Id = Id;
            //    roomModel.Code = txtMaPhong.Text;
            //    roomModel.Name = txtTenPhong.Text;
            //    roomModel.Description = rtbGhiChuPhong.Text;
            //    roomModel.CreatedDate = DateTime.Now;
            //    roomModel.CreatedUserId = 1;
            //    roomModel.IsDeleted = false;
            //    roomModel.Status = 0;
            //    int deviceQuantity;
            //    if (int.TryParse(txtSoLuongTB.Text, out deviceQuantity))
            //    {
            //        roomModel.DeviceQuantity = deviceQuantity;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Số Lượng Thiết Bị Phải là Số Nguyên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    try
            //    {
            //        if (txtMaPhong.Text == "" || txtTenPhong.Text == "" || rtbGhiChuPhong.Text == "" || txtSoLuongTB.Text == "")
            //        {
            //            MessageBox.Show("Thông Tin Không Được Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        else
            //        {
            //            RoomBus.UpdateRoom(roomModel);
            //            MessageBox.Show("Cập Nhật Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            //dgvPhongMay.DataSource = RoomBus.GetAllRoom();
            //            dgvPhongMay.DataSource = RoomBus.GetRoomAfterDelete();
            //            txtMaPhong.Text = "";
            //            txtTenPhong.Text = "";
            //            rtbGhiChuPhong.Text = "";
            //            txtSoLuongTB.Text = "";
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPhongMay.SelectedRows.Count > 0)
                {
                    int rowIndex = dgvPhongMay.SelectedRows[0].Index;
                    int Id = Int32.Parse(dgvPhongMay.Rows[rowIndex].Cells["ID"].Value.ToString());

                    CurrencyManager currencyManager = (CurrencyManager)BindingContext[dgvPhongMay.DataSource];
                    currencyManager.SuspendBinding();
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //dgvPhongMay.CurrentCell = dgvPhongMay.Rows[0].Cells[0];
                        RoomBus.DeleteRoom(Id);
                        dgvPhongMay.Rows[rowIndex].Visible = false;
                        MessageBox.Show("Xóa Thành Công");
                        //txtMaPhong.Text = "";
                        //txtTenPhong.Text = "";
                        //txtSoLuongTB.Text = "";
                        //rtbGhiChuPhong.Text = "";
                        dgvPhongMay.DataSource = RoomBus.GetRoomAfterDelete();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiemPhong_Click(object sender, EventArgs e)
        {
            string Name = txtTiemKiemPhong.Text;
            if (txtTiemKiemPhong.Text == "")
            {
                MessageBox.Show("Nhập Thông Tin Cần Tìm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable result = RoomBus.SearchRoomByName(Name);
                dgvPhongMay.DataSource = result;
                //txtTiemKiemPhong.Text = "";
            }
        }
    }
}
