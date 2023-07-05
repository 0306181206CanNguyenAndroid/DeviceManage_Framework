namespace DeviceManage.DeviceManagerDbContextRp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class D_Malfunction
    {
        public int Id { get; set; }

        public int DeviceId { get; set; }

        public int ErrorId { get; set; }

        public int? MaintenanceTimes { get; set; }

        [StringLength(100)]
        public string Note { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedUserId { get; set; }

        public bool? IsDeleted { get; set; }

        public int? Status { get; set; }
    }
}
