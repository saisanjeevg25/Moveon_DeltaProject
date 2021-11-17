using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MoveOn_Application_Api.Models
{
    public partial class MOVEON_DBContext : DbContext
    {
        public MOVEON_DBContext()
        {
        }

        public MOVEON_DBContext(DbContextOptions<MOVEON_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblRequest> TblRequests { get; set; }
        public virtual DbSet<TblShipment> TblShipments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("data source=.;initial catalog=MOVEON_DB;integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblRequest>(entity =>
            {
                entity.HasKey(e => e.JobApplicationNumber)
                    .HasName("PK__tbl_Requ__885B891EA8F6490F");

                entity.ToTable("tbl_Requests");

                entity.Property(e => e.JobApplicationNumber)
                    .HasMaxLength(20)
                    .HasColumnName("Job_Application_Number");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FromAddress)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("From_Address");

                entity.Property(e => e.FromCity)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("From_City");

                entity.Property(e => e.FromCountry)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("From_Country");

                entity.Property(e => e.FromState)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("From_State");

                entity.Property(e => e.ItemCategory)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Item_Category");

                entity.Property(e => e.ItemDescription)
                    .IsUnicode(false)
                    .HasColumnName("Item_Description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.PickupDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Pickup_Date");

                entity.Property(e => e.ShipmentTypeId).HasColumnName("Shipment_Type_Id");

                entity.Property(e => e.ToAddress)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("To_Address");

                entity.Property(e => e.ToCity)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("To_City");

                entity.Property(e => e.ToCountry)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("To_Country");

                entity.Property(e => e.ToState)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("To_State");

                entity.HasOne(d => d.ShipmentType)
                    .WithMany(p => p.TblRequests)
                    .HasForeignKey(d => d.ShipmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_Reque__Shipm__2D27B809");
            });

            modelBuilder.Entity<TblShipment>(entity =>
            {
                entity.HasKey(e => e.ShipmentTypeId)
                    .HasName("PK__tbl_Ship__C431DD16D21C9DC8");

                entity.ToTable("tbl_Shipments");

                entity.Property(e => e.ShipmentTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("Shipment_Type_Id");

                entity.Property(e => e.ShipmentType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Shipment_Type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
