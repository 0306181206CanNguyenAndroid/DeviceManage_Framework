using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DeviceManage.DeviceManagerDbContextRp
{
    public partial class DeviceManagerDbContext : DbContext
    {
        public DeviceManagerDbContext()
            : base("name=DeviceManagerDbContext")
        {
        }

        public virtual DbSet<D_Brand> D_Brand { get; set; }
        public virtual DbSet<D_Device> D_Device { get; set; }
        public virtual DbSet<D_Device_Specs> D_Device_Specs { get; set; }
        public virtual DbSet<D_Device_Type> D_Device_Type { get; set; }
        public virtual DbSet<D_DeviceDetail> D_DeviceDetail { get; set; }
        public virtual DbSet<D_DeviceError> D_DeviceError { get; set; }
        public virtual DbSet<D_DeviceRegistration> D_DeviceRegistration { get; set; }
        public virtual DbSet<D_DeviceType_Specs> D_DeviceType_Specs { get; set; }
        public virtual DbSet<D_Faculty> D_Faculty { get; set; }
        public virtual DbSet<D_Location> D_Location { get; set; }
        public virtual DbSet<D_Malfunction> D_Malfunction { get; set; }
        public virtual DbSet<D_Position> D_Position { get; set; }
        public virtual DbSet<D_Room> D_Room { get; set; }
        public virtual DbSet<D_Shipment> D_Shipment { get; set; }
        public virtual DbSet<D_Shipment_Detail> D_Shipment_Detail { get; set; }
        public virtual DbSet<S_Teacher> S_Teacher { get; set; }
        public virtual DbSet<System_Borrow_Device_Detail> System_Borrow_Device_Detail { get; set; }
        public virtual DbSet<System_Borrow_Device_Letter> System_Borrow_Device_Letter { get; set; }
        public virtual DbSet<System_User> System_User { get; set; }
        public virtual DbSet<System_Decentralization> System_Decentralization { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<D_Device>()
                .Property(e => e.QR_Code)
                .IsUnicode(false);

            modelBuilder.Entity<D_Device>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<D_DeviceError>()
                .Property(e => e.ErrorCode)
                .IsUnicode(false);

            modelBuilder.Entity<S_Teacher>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<S_Teacher>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<System_User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<System_User>()
                .Property(e => e.Pass)
                .IsUnicode(false);
        }
    }
}
