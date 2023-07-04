using DAO.DataLayer;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusinessOjectBase
{
    public class Device_TypeBusBase
    {
        public static List<Device_TypeModel> getAllDevice_Type()
        {
            return Device_TypeDao.getData();
        }

        public static Device_TypeModel SelectByPrimaryKey(int id)
        {
            return Device_TypeDao.SelectByPrimaryKey(id);
        }

        public static List<Device_TypeModel> SelectSpecsDropDownListData()
        {
            return Device_TypeDao.SelectDeviceTypeDropDownListData();
        }

        public static void InsertDevice_Type(Device_TypeModel device_Type) 
        {
            if(Device_TypeDao.CheckNameDevice_Type(device_Type.Name))
            {
                throw new Exception("Tên Loại Thiết Bị Đã Tồn Tại");
            }
            else
            {
                Device_TypeDao.InsertDevice_Type(device_Type);
            }
           
        }
        public static void UpdateDevice_Type(Device_TypeModel device_Type)
        {
            if(Device_TypeDao.IsDuplicateDecice_Type(device_Type,device_Type.Id))
            {
                throw new Exception("Tên Loại Thiết Bị Đã Tồn Tại");
            }
            else
            {
                Device_TypeDao.UpDateDevice_Type(device_Type);
            }
            
        }
        public static List<Device_TypeModel> GetDevice_TypeAfterDelete()
        {
            return Device_TypeDao.GetDevice_TypeAfterDelete();
        }
        public static void DeleteDevice_Type(int id)
        {
            Device_TypeDao.DeleteDevice_Type(id);
        }
    }
}
