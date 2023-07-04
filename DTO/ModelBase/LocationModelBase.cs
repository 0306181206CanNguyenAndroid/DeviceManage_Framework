using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.ModelBase
{
    public class LocationModelBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string Note { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        //public int? Status { get; set; }
    }
}
