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
    public partial class DeviceDetail : Form
    {
        private DeviceModel device;
        public DeviceDetailModel currientDetail = null;

        List<DeviceDetailModel> listDetail = null;
        BindingSource bs = new BindingSource();
        public DeviceDetail(DeviceModel de)
        {
            InitializeComponent();
            device = de;
            Setting();
            //AddSpecsByType(de.DeviceTypeId, de.Id);
            lb_DeviceName.Text = de.Name;
            ptb_Device.Image = !String.IsNullOrEmpty(de.Image) ? Image.FromFile(SettingClass.path_Folder_Image_Device + de.Image) : Image.FromFile(SettingClass.path_NoImage_Default);
            LoadListDetail();
            Load_Form();
            
        }

        #region Load
        private void EventChangeData(object Sender, Action_AddSpecsForDeviceTypeEventArgs eventArgs)
        {
            MessageBox.Show("Có cập nhật", "Thông Báo", MessageBoxButtons.OK);
        }
        public void Load_Form()
        {
            lb_DeviceName.Text = device.Name;
            
            Load_ComboboxSpecs();
            Load_DataGridView();
            if (listDetail.Count > 0)
            {
                cb_ListSpecs.SelectedValue = listDetail[0].Id;
                txt_Description.Text = listDetail[0].Description;
            }
        }

        private List<DeviceDetailModel> GetDetail(int deviceId)
        {
            return DeviceDetailBus.SelectAllDynamicWhere(null, deviceId, null, null, null, null, null, null, null, false, null);
        }

        public void Load_ComboboxSpecs()
        {
            
            cb_ListSpecs.ValueMember = "Id";
            cb_ListSpecs.DisplayMember = "NameSpecs";
            cb_ListSpecs.DataSource = listDetail.ToList();

            var cbData = (DataGridViewComboBoxColumn)dtgv_ListDetail.Columns["Specs"];
            cbData.DisplayMember = "NameSpecs";
            cbData.ValueMember = "Id";
            cbData.DataSource = listDetail;
        }

        private void LoadListDetail()
        {
            listDetail = GetDetail(device.Id);
        }

        public void Load_DeviceInfo()
        {
            string description = "";
            foreach (DeviceDetailModel dt in listDetail)
            {
                description += dt.NameSpecs + ": " + dt.Description+";";
            }
            //txtDescription.Text = description;
        }

        public void Setting()
        {
            dtgv_ListDetail.AutoGenerateColumns = false;
            ptb_Device.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public void Load_DataGridView()
        {
            bs.DataSource = listDetail.ToList();
            dtgv_ListDetail.DataSource = bs;
        }
        #endregion



        private void btn_Update_Click(object sender, EventArgs e)
        {
            if(currientDetail!=null)
            {
                currientDetail.Description = txt_Description.Text.Trim();
                try
                {
                    DeviceDetailBus.Update(currientDetail);
                    MessageBox.Show("Thành công", "Thông Báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thất bại! Lỗi " + ex.Message, "Thông Báo", MessageBoxButtons.OK);
                    return;
                }
            }

            Load_DataGridView();
            //Load_DeviceInfo();
        }

        private void dtgv_ListDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ListDetail.SelectedCells.Count > 0)
            {
                int detailId = (int)dtgv_ListDetail.SelectedCells[0].OwningRow.Cells["Specs"].Value;
                
                foreach (DeviceDetailModel de in listDetail)
                {
                    if (de.Id == detailId)
                    {
                        currientDetail = de;
                        cb_ListSpecs.SelectedValue = de.Id;
                        txt_Description.Text = de.Description;
                        return;
                    }
                }

            }
        }

        private void cb_ListSpecs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int detailId = (int)cb_ListSpecs.SelectedValue;
            foreach (DeviceDetailModel de in listDetail)
            {
                if (de.Id == detailId)
                {
                    currientDetail = de;
                    txt_Description.Text = de.Description;
                    int len = listDetail.Count;
                    foreach (DataGridViewRow r in dtgv_ListDetail.Rows)
                    {
                        if (detailId == (int)r.Cells["Specs"].Value)
                        {
                            dtgv_ListDetail.ClearSelection();
                            r.Selected = true;
                            return;
                        }
                            
                        
                    }
                    
                }
            }
        }
    }
}
