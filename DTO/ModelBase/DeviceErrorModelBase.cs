using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.ModelBase
{
    public class DeviceErrorModelBase
    {
        public int Id { get; set; }
        public int DeviceTypeId { get; set; }
        public string ErrorCode { get; set; }
        public string Solution { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int? Status { get; set; }
    }
}
