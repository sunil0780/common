using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TesterCore
{
    public partial class iaso_v001Context : DbContext
    {
        public iaso_v001Context()
        {
        }

        public iaso_v001Context(DbContextOptions<iaso_v001Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Board> Board { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=vm-mel-ejb01;Database=iaso_v001;user id=postgres;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Board>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UpdateDate).HasColumnType("date");

                entity.Property(e => e.UpdatedById).HasColumnName("UpdatedBy_Id");
            });

            modelBuilder.Entity<clientupdate>(entity =>
            {
                entity.HasKey(e => new { e.clientid, e.updatetype })
                     .HasName("clientupdate_pkey");

                entity.ToTable("clientupdate");

                entity.Property(e => e.clientid).HasColumnName("clientid");

                entity.Property(e => e.updatetype).HasColumnName("updatetype");

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
