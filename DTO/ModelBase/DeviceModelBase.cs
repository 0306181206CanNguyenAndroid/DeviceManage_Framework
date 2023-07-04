using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ModelBase
{
    public class DeviceModelBase
    {
        public int Id { get; set; }
        public int DeviceTypeId { get; set; }
        public int ShipmentId { get; set; }
        public int FacultyId { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string QR_Code { get; set; }
        public string Image { get; set; }
        public string Note { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public DateTime? WarrantyPeriod { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int? Status { get; set; }
    }
}

