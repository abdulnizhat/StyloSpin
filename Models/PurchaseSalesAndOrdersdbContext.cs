using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace POsWebAPITesting.Models;

public partial class PurchaseSalesAndOrdersdbContext : DbContext
{
    public PurchaseSalesAndOrdersdbContext()
    {
    }

    public PurchaseSalesAndOrdersdbContext(DbContextOptions<PurchaseSalesAndOrdersdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Designation> Designations { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeContact> EmployeeContacts { get; set; }

    public virtual DbSet<JobTitle> JobTitles { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<State> States { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS_AR; Database=PurchaseSalesAndOrdersdb; User ID=sa;Password=root@123; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      => optionsBuilder.UseSqlServer("name=constring");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PK__Cities__F2D21A9622D8A919");

            entity.HasIndex(e => e.CityCode, "UQ__Cities__B488218C4A15A33F").IsUnique();

            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CityCode).HasMaxLength(50);
            entity.Property(e => e.CityName).HasMaxLength(256);
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.PostalCode).HasMaxLength(50);
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValue("Active");

            entity.HasOne(d => d.Country).WithMany(p => p.Cities)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK__Cities__CountryI__66603565");

            entity.HasOne(d => d.State).WithMany(p => p.Cities)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK__Cities__StateID__656C112C");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK__Countrie__10D160BFB5B8FBC5");

            entity.HasIndex(e => e.CountryCode, "UQ__Countrie__5D9B0D2C53E99CD1").IsUnique();

            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CountryCode).HasMaxLength(50);
            entity.Property(e => e.CountryName).HasMaxLength(256);
            entity.Property(e => e.Region).HasMaxLength(150);
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__Departme__B2079BCD698008C2");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DepartmentDisplayName).HasMaxLength(150);
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Designation>(entity =>
        {
            entity.HasKey(e => e.DesignationId).HasName("PK__Designat__BABD603E94FB733D");

            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DesignationDisplayName).HasMaxLength(150);
            entity.Property(e => e.DesignationName).HasMaxLength(100);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValue("Active");

            entity.HasOne(d => d.Department).WithMany(p => p.Designations)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Designati__Depar__6C190EBB");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04FF1C5444AEA");

            entity.HasIndex(e => e.PersonalEmailId, "UQ__Employee__6B2E58F657B85E60").IsUnique();

            entity.HasIndex(e => e.OfficialEmailId, "UQ__Employee__C6FF5A25C487E661").IsUnique();

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.AlternateContactNumber).HasMaxLength(50);
            entity.Property(e => e.ContactNumber).HasMaxLength(50);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.EmployeeFullName).HasMaxLength(250);
            entity.Property(e => e.FirstName).HasMaxLength(250);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.JobTitleId).HasColumnName("JobTitleID");
            entity.Property(e => e.LastName).HasMaxLength(250);
            entity.Property(e => e.MaritalStatus).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(250);
            entity.Property(e => e.OfficialEmailId).HasMaxLength(100);
            entity.Property(e => e.PersonalEmailId).HasMaxLength(100);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValue("Active");
            entity.Property(e => e.UserName).HasMaxLength(256);
            entity.Property(e => e.UserPassword).HasMaxLength(256);

            entity.HasOne(d => d.Department).WithMany(p => p.Employees)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Employees__Depar__76969D2E");

            entity.HasOne(d => d.Designation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.DesignationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Employees__Desig__778AC167");

            entity.HasOne(d => d.JobTitle).WithMany(p => p.Employees)
                .HasForeignKey(d => d.JobTitleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Employees__JobTi__797309D9");

            entity.HasOne(d => d.Role).WithMany(p => p.Employees)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Employees__RoleI__787EE5A0");
        });

        modelBuilder.Entity<EmployeeContact>(entity =>
        {
            entity.HasKey(e => e.EmployeeContactId).HasName("PK__Employee__54F63692BB9E4ECA");

            entity.Property(e => e.EmployeeContactId).HasColumnName("EmployeeContactID");
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.EmergencyContactName).HasMaxLength(100);
            entity.Property(e => e.EmergencyContactPhone).HasMaxLength(50);
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.PostalCode).HasMaxLength(50);
            entity.Property(e => e.StateId).HasColumnName("StateID");

            entity.HasOne(d => d.City).WithMany(p => p.EmployeeContacts)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EmployeeC__CityI__00200768");

            entity.HasOne(d => d.Country).WithMany(p => p.EmployeeContacts)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EmployeeC__Count__7E37BEF6");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeContacts)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EmployeeC__Emplo__7D439ABD");

            entity.HasOne(d => d.State).WithMany(p => p.EmployeeContacts)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EmployeeC__State__7F2BE32F");
        });

        modelBuilder.Entity<JobTitle>(entity =>
        {
            entity.HasKey(e => e.JobTitleId).HasName("PK__JobTitle__35382FC91914E867");

            entity.Property(e => e.JobTitleId).HasColumnName("JobTitleID");
            entity.Property(e => e.JobTitle1)
                .HasMaxLength(100)
                .HasColumnName("JobTitle");
            entity.Property(e => e.JobTitleDisplayName).HasMaxLength(100);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValue("Active");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.Property(e => e.ExtraField1).HasMaxLength(50);
            entity.Property(e => e.ExtraField2).HasMaxLength(50);
            entity.Property(e => e.ExtraField3).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProductImagePath).HasMaxLength(500);
            entity.Property(e => e.ProductName).HasMaxLength(50);
            entity.Property(e => e.ProductPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Roles__8AFACE3A71779FBA");

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleDisplayName).HasMaxLength(150);
            entity.Property(e => e.RoleName).HasMaxLength(150);
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.StateId).HasName("PK__States__C3BA3B5A7B9A0993");

            entity.HasIndex(e => e.StateCode, "UQ__States__D515E98A2D4D8CC7").IsUnique();

            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.StateCode).HasMaxLength(10);
            entity.Property(e => e.StateName).HasMaxLength(256);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValue("Active");

            entity.HasOne(d => d.Country).WithMany(p => p.States)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK__States__CountryI__60A75C0F");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
