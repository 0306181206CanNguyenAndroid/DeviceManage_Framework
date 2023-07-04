﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO.ModelBase
{
    public class RoomModelBase
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DeviceQuantity { get; set; }
       public DateTime? CreatedDate { get; set; }
        public int? CreatedUserId { get; set; }
       public bool IsDeleted { get; set; }
        public int? Status { get; set; }
    }
}
