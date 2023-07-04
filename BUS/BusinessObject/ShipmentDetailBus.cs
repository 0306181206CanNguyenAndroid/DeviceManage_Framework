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
    public class ShipmentDetailBus : ShipmentDetailBusBase
    {

        public static List<ShipmentDetailModel> SelectDeviceInfoAndCollectByShipmentId(int shipmentId)
        {
            return ShipmentDetailDataLayer.SelectDeviceInfoAndCollectByShipmentId(shipmentId);
        }
    }
}
