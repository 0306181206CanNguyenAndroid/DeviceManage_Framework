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
    public partial class frmShipment : Form
    {

        public frmShipment()
        {
            InitializeComponent();
            Setting();
            LoadForm();
        }
        #region Model

        public ShipmentModel currentShipment = null;
        public ShipmentDetailModel currentShipmentDetail = null;
        private List<ShipmentModel> listShipment = null;
        private List<ShipmentDetailModel> listShipmentDetails = null;
        BindingSource bs = new BindingSource();
        BindingSource bsDtl = new BindingSource();


        #endregion


        #region Load form

        private void Setting()
        {
            dtp_ImportDate.CustomFormat = "dd/MM/yyyy";
            dtp_ShipmentDate.CustomFormat = "dd/MM/yyyy";
            dtgv_Shipment.AutoGenerateColumns = false;
            dtgv_ShipmentDetail.AutoGenerateColumns = false;
            dtgv_Shipment.AllowUserToAddRows = false;
            dtgv_ShipmentDetail.AllowUserToAddRows = false;
        }

        private void LoadForm()
        {
            LoadShipmentSource();
            currentShipment = listShipment.Count > 0 ? listShipment[0] : null;
            LoadBeginData();
            LoadDataGridViewShipment();
            LoadComboboxBrand();
            LoadShipmentDetailSource();
            LoadDataGridViewShipmentDetail();
            
        }

        private void LoadBeginData()
        {
            if(currentShipment != null)
            {
                txt_ShipmentName.Text = currentShipment.Name;
                cb_Brand.SelectedValue = currentShipment.BrandId;
                txt_Invoice.Text = currentShipment.Invoice;
                dtp_ImportDate.Value = currentShipment.ImportDate.Value;
                txt_Note.Text = currentShipment.Description;
            }
        }

        private void LoadShipmentSource()
        {
            listShipment = ShipmentBus.SelectAllDynamicWhere(null, null, null, null, null, null, null, null, null, false, null);
        }

        private void LoadDataGridViewShipment()
        {
            bs.DataSource = listShipment;
            dtgv_Shipment.DataSource = bs;
        }

        private void LoadComboboxBrand()
        {
            cb_Brand.DisplayMember = "Name";
            cb_Brand.ValueMember = "Id";
            cb_Brand.DataSource = BrandBus.GetBrandAfterDelete();
        }

        private void LoadShipmentDetailSource()
        {
            if (currentShipment != null)
            {
                listShipmentDetails = ShipmentDetailBus.SelectAllDynamicWhere(null, currentShipment.Id, null, null, null, null, false, null,null);
                if(listShipmentDetails.Count>0)
                {
                    foreach (ShipmentDetailModel sdtl in listShipmentDetails)
                    {
                        DeviceModel d = DeviceBus.SelectByPrimaryKey(sdtl.DeviceId);
                        sdtl.DeviceName = d.Name;
                        sdtl.DevicePrice = d.Price.HasValue ? Math.Round(d.Price.Value,1) + " VND" : "0.0 VND";
                    }
                }
            }
            else
            {
                listShipment = new List<ShipmentModel>();
            }
            currentShipmentDetail = listShipmentDetails.Count > 0 ? listShipmentDetails[0] : null;
        }

        private void LoadDataGridViewShipmentDetail()
        {
            bsDtl.DataSource = listShipmentDetails.ToList();
            dtgv_ShipmentDetail.DataSource = bsDtl;
        }

        #endregion

        #region Create and Update Shipment

        #endregion

        private void btn_Del_Click(object sender, EventArgs e)
        {

        }

        private void tab_Shipment_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddDevice_Click(object sender, EventArgs e)
        {

        }
    }
}
