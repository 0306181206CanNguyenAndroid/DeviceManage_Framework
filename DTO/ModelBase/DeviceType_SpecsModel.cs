using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ModelBase
{
    public class DeviceType_SpecsModelBase
    {
        public int Id { get; set; }
        public int DeviceTypeId { get; set; }
        public int SpecsId { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUserId { get; set; }
        //public int? Status { get; set; }
        public bool IsDeleted { get; set; }
    }
}

