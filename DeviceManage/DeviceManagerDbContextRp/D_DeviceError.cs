namespace DeviceManage.DeviceManagerDbContextRp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class D_DeviceError
    {
        public int Id { get; set; }

        public int DeviceTypeId { get; set; }

        [StringLength(20)]
        public string ErrorCode { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [StringLength(100)]
        public string Solution { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedUserId { get; set; }

        public bool? IsDeleted { get; set; }

        public int? Status { get; set; }
    }
}
