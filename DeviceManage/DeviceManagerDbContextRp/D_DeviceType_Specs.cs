namespace DeviceManage.DeviceManagerDbContextRp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class D_DeviceType_Specs
    {
        public int Id { get; set; }

        public int DeviceTypeId { get; set; }

        public int DeviceSpecsId { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedUserId { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
