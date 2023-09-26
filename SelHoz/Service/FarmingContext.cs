using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SelHoz;

public partial class FarmingContext : DbContext
{
    public FarmingContext()
    {
    }

    public FarmingContext(DbContextOptions<FarmingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CultivatedArea> CultivatedAreas { get; set; }

    public virtual DbSet<Culture> Cultures { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Farming> Farmings { get; set; }

    public virtual DbSet<Fertilizer> Fertilizers { get; set; }

    public virtual DbSet<Harvesting> Harvestings { get; set; }

    public virtual DbSet<OrderingFertilizer> OrderingFertilizers { get; set; }

    public virtual DbSet<OrderingTechnique> OrderingTechniques { get; set; }

    public virtual DbSet<Provider> Providers { get; set; }

    public virtual DbSet<Technique> Techniques { get; set; }

    public virtual DbSet<User> User { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=Farming;Username=postgres;Password=123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CultivatedArea>(entity =>
        {
            entity.HasKey(e => e.IdArea).HasName("cultivated_areas_pkey");

            entity.ToTable("cultivated_areas", "farmingschema");

            entity.Property(e => e.IdArea)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_area");
            entity.Property(e => e.Area)
                .HasMaxLength(15)
                .HasColumnName("area");
            entity.Property(e => e.HarvestDate)
                .HasMaxLength(30)
                .HasColumnName("harvest_date");
            entity.Property(e => e.SowingDate)
                .HasMaxLength(30)
                .HasColumnName("sowing_date");
        });

        modelBuilder.Entity<Culture>(entity =>
        {
            entity.HasKey(e => e.IdCulture).HasName("culture_pkey");

            entity.ToTable("culture", "farmingschema");

            entity.Property(e => e.IdCulture)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_culture");
            entity.Property(e => e.DescriptionCulture)
                .HasMaxLength(50)
                .HasColumnName("description_culture");
            entity.Property(e => e.IdArea).HasColumnName("id_area");
            entity.Property(e => e.NameCulture)
                .HasMaxLength(50)
                .HasColumnName("name_culture");
            entity.Property(e => e.RipeningPeriod)
                .HasMaxLength(30)
                .HasColumnName("ripening_period");
            entity.Property(e => e.Seasonality)
                .HasMaxLength(30)
                .HasColumnName("seasonality");

            entity.HasOne(d => d.IdAreaNavigation).WithMany(p => p.Cultures)
                .HasForeignKey(d => d.IdArea)
                .HasConstraintName("culture_id_area_fkey");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.IdEmployee).HasName("employee_pkey");

            entity.ToTable("employee", "farmingschema");

            entity.Property(e => e.IdEmployee)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_employee");
            entity.Property(e => e.AddressEmployee)
                .HasMaxLength(50)
                .HasColumnName("address_employee");
            entity.Property(e => e.BirthdayDate)
                .HasMaxLength(50)
                .HasColumnName("birthday_date");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .HasColumnName("email");
            entity.Property(e => e.NameEmployee)
                .HasMaxLength(30)
                .HasColumnName("name_employee");
            entity.Property(e => e.PatronymicEmployee)
                .HasMaxLength(30)
                .HasColumnName("patronymic_employee");
            entity.Property(e => e.PhoneNumberEmployee)
                .HasMaxLength(11)
                .HasColumnName("phone_number_employee");
            entity.Property(e => e.Post)
                .HasMaxLength(30)
                .HasColumnName("post");
            entity.Property(e => e.Sex)
                .HasMaxLength(10)
                .HasColumnName("sex");
            entity.Property(e => e.SurnameEmployee)
                .HasMaxLength(30)
                .HasColumnName("surname_employee");
        });

        modelBuilder.Entity<Farming>(entity =>
        {
            entity.HasKey(e => e.IdFarming).HasName("farming_pkey");

            entity.ToTable("farming", "farmingschema");

            entity.Property(e => e.IdFarming)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_farming");
            entity.Property(e => e.AddressFarming)
                .HasMaxLength(50)
                .HasColumnName("address_farming");
            entity.Property(e => e.IdCulture).HasColumnName("id_culture");
            entity.Property(e => e.IdEmployee).HasColumnName("id_employee");
            entity.Property(e => e.IdFertilizer).HasColumnName("id_fertilizer");
            entity.Property(e => e.IdHarvest).HasColumnName("id_harvest");
            entity.Property(e => e.IdTechnique).HasColumnName("id_technique");
            entity.Property(e => e.NameFarming)
                .HasMaxLength(50)
                .HasColumnName("name_farming");

            entity.HasOne(d => d.IdCultureNavigation).WithMany(p => p.Farmings)
                .HasForeignKey(d => d.IdCulture)
                .HasConstraintName("farming_id_culture_fkey");

            entity.HasOne(d => d.IdEmployeeNavigation).WithMany(p => p.Farmings)
                .HasForeignKey(d => d.IdEmployee)
                .HasConstraintName("farming_id_employee_fkey");

            entity.HasOne(d => d.IdFertilizerNavigation).WithMany(p => p.Farmings)
                .HasForeignKey(d => d.IdFertilizer)
                .HasConstraintName("farming_id_fertilizer_fkey");

            entity.HasOne(d => d.IdHarvestNavigation).WithMany(p => p.Farmings)
                .HasForeignKey(d => d.IdHarvest)
                .HasConstraintName("farming_id_harvest_fkey");

            entity.HasOne(d => d.IdTechniqueNavigation).WithMany(p => p.Farmings)
                .HasForeignKey(d => d.IdTechnique)
                .HasConstraintName("farming_id_technique_fkey");
        });

        modelBuilder.Entity<Fertilizer>(entity =>
        {
            entity.HasKey(e => e.IdFertilizer).HasName("fertilizer_pkey");

            entity.ToTable("fertilizer", "farmingschema");

            entity.Property(e => e.IdFertilizer)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_fertilizer");
            entity.Property(e => e.DateManufacture)
                .HasMaxLength(50)
                .HasColumnName("date_manufacture");
            entity.Property(e => e.DescriptionFertilizer)
                .HasMaxLength(50)
                .HasColumnName("description_fertilizer");
            entity.Property(e => e.ExpirationDate)
                .HasMaxLength(50)
                .HasColumnName("expiration_date");
            entity.Property(e => e.NameFertilizer)
                .HasMaxLength(50)
                .HasColumnName("name_fertilizer");
            entity.Property(e => e.PriceFert).HasColumnName("Price_Fert");
        });

        modelBuilder.Entity<Harvesting>(entity =>
        {
            entity.HasKey(e => e.IdHarvest).HasName("harvesting_pkey");

            entity.ToTable("harvesting", "farmingschema");

            entity.Property(e => e.IdHarvest)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_harvest");
            entity.Property(e => e.CollectionDate).HasColumnName("collection_date");
            entity.Property(e => e.HarvestedAmount).HasColumnName("harvested_amount");
        });

        modelBuilder.Entity<OrderingFertilizer>(entity =>
        {
            entity.HasKey(e => e.IdOrderFertilizer).HasName("ordering_fertilizer_pkey");

            entity.ToTable("ordering_fertilizer", "farmingschema");

            entity.Property(e => e.IdOrderFertilizer)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_order_fertilizer");
            
            entity.Property(e => e.IdFertilizer).HasColumnName("id_fertilizer");
            entity.Property(e => e.IdProvider).HasColumnName("id_provider");
            
                
                
            

            entity.HasOne(d => d.IdFertilizerNavigation).WithMany(p => p.OrderingFertilizers)
                .HasForeignKey(d => d.IdFertilizer)
                .HasConstraintName("ordering_fertilizer_id_fertilizer_fkey");

            entity.HasOne(d => d.IdProviderNavigation).WithMany(p => p.OrderingFertilizers)
                .HasForeignKey(d => d.IdProvider)
                .HasConstraintName("ordering_fertilizer_id_provider_fkey");
        });

        modelBuilder.Entity<OrderingTechnique>(entity =>
        {
            entity.HasKey(e => e.IdOrderTechnique).HasName("ordering_technique_pkey");

            entity.ToTable("ordering_technique", "farmingschema");

            entity.Property(e => e.IdOrderTechnique)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_order_technique");
            entity.Property(e => e.IdProvider).HasColumnName("id_provider");
            entity.Property(e => e.IdTechnique).HasColumnName("id_technique");
                                                    
            entity.HasOne(d => d.IdProviderNavigation).WithMany(p => p.OrderingTechniques)
                .HasForeignKey(d => d.IdProvider)
                .HasConstraintName("ordering_technique_id_provider_fkey");

            entity.HasOne(d => d.IdTechniqueNavigation).WithMany(p => p.OrderingTechniques)
                .HasForeignKey(d => d.IdTechnique)
                .HasConstraintName("ordering_technique_id_technique_fkey");
        });

        modelBuilder.Entity<Provider>(entity =>
        {
            entity.HasKey(e => e.IdProvider).HasName("provider_pkey");

            entity.ToTable("provider", "farmingschema");

            entity.Property(e => e.IdProvider)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_provider");
            entity.Property(e => e.AddressProvider)
                .HasMaxLength(50)
                .HasColumnName("address_provider");
            entity.Property(e => e.NameProvider)
                .HasMaxLength(50)
                .HasColumnName("name_provider");
            entity.Property(e => e.PhoneNumberProvider)
                .HasMaxLength(11)
                .HasColumnName("phone_number_provider");
        });

        modelBuilder.Entity<Technique>(entity =>
        {
            entity.HasKey(e => e.IdTechnique).HasName("technique_pkey");

            entity.ToTable("technique", "farmingschema");

            entity.Property(e => e.IdTechnique)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_technique");
            entity.Property(e => e.DescriptionTechnique)
                .HasMaxLength(50)
                .HasColumnName("description_technique");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .HasColumnName("model");
            entity.Property(e => e.NameTechnique)
                .HasMaxLength(50)
                .HasColumnName("name_technique");
            entity.Property(e => e.PriceTech).HasColumnName("Price_Tech");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("Users_pkey");

            entity.ToTable("Users", "farmingschema");

            entity.Property(e => e.IdUser)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id_user");
            entity.Property(e => e.LoginUser)
                .HasMaxLength(30)
                .HasColumnName("login_user");
            entity.Property(e => e.NameUser)
                .HasMaxLength(30)
                .HasColumnName("name_user");
            entity.Property(e => e.PasswordUser)
                .HasMaxLength(30)
                .HasColumnName("password_user");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
