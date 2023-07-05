namespace DeviceManage.DeviceManagerDbContextRp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class D_Device_Specs
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Ordinal { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedUserId { get; set; }

        public bool? IsDeleted { get; set; }

        public int? Status { get; set; }
    }
}
