using BUS.BusinessOjectBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Model;
using DAO.DataLayer;
using System.Windows.Forms;

namespace BUS.BusinessObject
{
    public class DeviceType_SpecsBus : DeviceType_SpecsBusBase
    {
        public static bool InsertOrUpdate(List<DeviceType_SpecsModel> listDeviceType_Specs, bool isUpdate, int deviceTypeId)
        {
            foreach (DeviceType_SpecsModel dp in listDeviceType_Specs)
            {
                try
                {
                    if (isUpdate)
                    {
                        DeviceType_SpecsDataLayer.Update(dp);
                        MessageBox.Show("Thanh cong");
                    }
                    else
                    {
                        EventInsert(dp, deviceTypeId, dp.SpecsName);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Lỗi Insert/Update/n" + e.Message);
                    return false;
                }
            }
            MessageBox.Show("Thành Công");
            return true;
        }

        public static bool EventInsert(DeviceType_SpecsModel dp, int deviceTypeId, string specsName)
        {
            try
            {
                int kq = DeviceType_SpecsDataLayer.Insert(dp);
                AddDetail(deviceTypeId, kq, specsName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại! Lỗi " + ex.Message, "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            
            return true;
        }

        public static void AddDetail(int deviceTypeId, int DeviceType_SpecsId, string specsName)
        {
            List<DeviceModel> deviceChange = DeviceBus.SelectAllDynamicWhere(null, deviceTypeId,null,null, null, null, null, null, null, null, null, null, null, null, false, null);
            if (deviceChange.Count > 0)
            {
                foreach (DeviceModel de in deviceChange)
                {
                    try
                    {
                        int kq = DeviceDetailBus.Insert(GetDeviceDetail(DeviceType_SpecsId, de.Id, specsName));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thất bại! Lỗi " + ex.Message, "Thông Báo", MessageBoxButtons.OK);
                    }
                }
                MessageBox.Show("Thành công", "Thông Báo", MessageBoxButtons.OK);

            }
        }
        public static DeviceDetailModel GetDeviceDetail(int deviceType_SpecsId, int deviceId, string specsName)
        {
            DeviceDetailModel dtl = new DeviceDetailModel();
            dtl.DeviceId = deviceId;
            dtl.DeviceTypeSpecsId = deviceType_SpecsId;
            dtl.NameSpecs = specsName;
            dtl.CreatedDate = DateTime.Now;
            dtl.CreatedUserId = 1;
            dtl.Description = "";
            dtl.IsDeleted = false;
            dtl.Status = 0;
            return dtl;
        }
    }
}
