using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ModelBase
{
    public class DeviceDetailModelBase
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int DeviceTypeSpecsId { get; set; }
        public int BrandId { get; set; }
        public decimal? Values { get; set; }
        public string NameSpecs { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int? Status { get; set; }
    }
}

