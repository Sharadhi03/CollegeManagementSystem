using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CollegeManagement.Data.Entities;

public partial class KmsContext : DbContext
{
    public KmsContext()
    {
    }

    public KmsContext(DbContextOptions<KmsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblAddress> TblAddresses { get; set; }

    public virtual DbSet<TblCourse> TblCourses { get; set; }

    public virtual DbSet<TblStaff> TblStaffs { get; set; }

    public virtual DbSet<TblStudent> TblStudents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=KMS;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblAddress>(entity =>
        {
            entity.ToTable("tblAddress");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AddressCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("address_city");
            entity.Property(e => e.AddressPin)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("address_pin");
            entity.Property(e => e.AddressStreet1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("address_street1");
            entity.Property(e => e.AddressStreet2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("address_street2");
        });

        modelBuilder.Entity<TblCourse>(entity =>
        {
            entity.ToTable("tblCourse");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblStaff>(entity =>
        {
            entity.ToTable("tblStaff");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblStudent>(entity =>
        {
            entity.ToTable("tblStudent");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.CollegeName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Usn)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("USN");

            entity.HasOne(d => d.Address).WithMany(p => p.TblStudents)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("FK_tblStudent_tblAddress");

            entity.HasOne(d => d.Course).WithMany(p => p.TblStudents)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_tblStudent_tblCourse");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
