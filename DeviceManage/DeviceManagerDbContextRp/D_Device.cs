namespace DeviceManage.DeviceManagerDbContextRp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class D_Device
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int DeviceTypeId { get; set; }

        public int? ShipmentId { get; set; }

        public int? FacultyId { get; set; }

        public int? BrandId { get; set; }

        [StringLength(100)]
        public string QR_Code { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [StringLength(100)]
        public string Note { get; set; }

        [StringLength(100)]
        public string Image { get; set; }

        public DateTime? WarrantyPeriod { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedUserId { get; set; }

        public bool? IsDeleted { get; set; }

        public int? Status { get; set; }
    }
}
