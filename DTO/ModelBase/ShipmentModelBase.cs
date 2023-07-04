using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.ModelBase
{
    public class ShipmentModelBase
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ApproverId { get; set; }
        public string Name { get; set; }
        public string Invoice { get; set; }
        public DateTime? ImportDate { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int? Status { get; set; }
    }
}
