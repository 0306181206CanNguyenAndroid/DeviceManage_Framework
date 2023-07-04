using DTO.ModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO.Model
{
    public class DeviceModel : DeviceModelBase
    {
        public string BrandName { get; set; }
        public string DeviceTypeName { get; set; }
        public string UserName { get; set; }
        public string ShipmentName { get; set; }
        public int? RoomId { get; set; }
        public int? LocationId { get; set; }
        public string LocationName { get; set; }

        public List<DeviceDetailModel> deviceDetail { get; set; }
        public DeviceModel() { }
    }
}
