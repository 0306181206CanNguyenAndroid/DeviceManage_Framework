using BUS.BusinessOjectBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Model;
using DAO.DataLayer;

namespace BUS.BusinessObject
{
    public class DeviceBus : DeviceBusBase
    {
        public static List<DeviceModel> GetAllDeviceUnUsing(int quantity)
        {
            return DeviceDataLayer.GetAllDeviceUnUsing(quantity);
        }

        public static List<DeviceModel> GetAllDeviceInRoom(int roomId)
        {
            List<DeviceModel> list = DeviceDataLayer.GetAllDeviceInRoom(roomId);
            if(list.Count > 0)
            {
                foreach(DeviceModel d in list)
                {
                    try
                    {
                        LocationModel lm = LocationBus.SelectByPrimaryKey(d.LocationId.Value);
                        d.LocationName = lm.Name;
                    }
                    catch(Exception ex)
                    {
                        d.LocationName = "Trong";
                    }
                }
            }
            return list;
        }

    }
}
