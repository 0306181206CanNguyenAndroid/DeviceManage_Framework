using DTO.ModelBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Model
{
    public class ShipmentDetailModel : ShipmentDetailModelBase
    {
        public ShipmentDetailModel() { }

        public int? DeviceTypeId { get; set; }
        public int CountNumber { get; set; }
        public string DeviceName { get; set; }
        public string DeviceInfo { get; set; }
        public string Quantity { get; set; }
        public string DevicePrice { get; set; }
        public string TotalPrice { get; set; }
    }
}
