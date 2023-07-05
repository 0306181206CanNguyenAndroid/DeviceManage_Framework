namespace DeviceManage.DeviceManagerDbContextRp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class D_DeviceDetail
    {
        public int Id { get; set; }

        public int DeviceId { get; set; }

        public int DeviceTypeSpecsId { get; set; }

        [StringLength(50)]
        public string NameSpecs { get; set; }

        public int? BrandId { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedUserId { get; set; }

        public bool? IsDeleted { get; set; }

        public int? Status { get; set; }
    }
}
