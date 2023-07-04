using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.ModelBase
{
    public class DeviceRegistrationModelBase
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int RoomId { get; set; }
        public int LocationId { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int? Status { get; set; }
    }
}
