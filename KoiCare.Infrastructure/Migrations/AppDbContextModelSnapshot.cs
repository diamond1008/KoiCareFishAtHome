﻿// <auto-generated />
using System;
using KoiCare.Infrastructure.Dependencies.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace KoiCare.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("KoiCare.Domain.Entities.BlogPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("BlogPosts");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.FeedCalculation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CalculationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("DailyAmount")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Frequency")
                        .HasColumnType("numeric");

                    b.Property<int>("KoiIndividualId")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("KoiIndividualId");

                    b.ToTable("FeedCalculations");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.FeedingSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<int>("KoiIndividualId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Period")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("KoiIndividualId");

                    b.ToTable("FeedingSchedules");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.HasKey("Id");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Male"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Female"
                        });
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.KoiGrowth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("KoiIndividualId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Length")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("MeasuredAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("Weight")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("KoiIndividualId");

                    b.ToTable("KoiGrowths");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.KoiIndividual", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal?>("Age")
                        .HasColumnType("numeric");

                    b.Property<string>("Breed")
                        .HasColumnType("text");

                    b.Property<int?>("Gender")
                        .HasColumnType("integer");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<int>("KoiTypeId")
                        .HasColumnType("integer");

                    b.Property<decimal?>("Length")
                        .HasColumnType("numeric");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Origin")
                        .HasColumnType("text");

                    b.Property<int>("PondId")
                        .HasColumnType("integer");

                    b.Property<int?>("Shape")
                        .HasColumnType("integer");

                    b.Property<decimal?>("Weight")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("KoiTypeId");

                    b.HasIndex("PondId");

                    b.ToTable("KoiIndividuals");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.KoiType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("KoiTypes");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CompletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("Total")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.PerfectWaterVolume", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("KoiTypeId")
                        .HasColumnType("integer");

                    b.Property<decimal>("MaxVolume")
                        .HasColumnType("numeric");

                    b.Property<decimal>("MinVolume")
                        .HasColumnType("numeric");

                    b.Property<decimal>("OptimalVolume")
                        .HasColumnType("numeric");

                    b.Property<decimal>("RecommendedSaltLevel")
                        .HasColumnType("numeric");

                    b.Property<decimal>("WaterLevel")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("KoiTypeId");

                    b.ToTable("PerfectWaterVolumes");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.Pond", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Depth")
                        .HasColumnType("numeric");

                    b.Property<decimal>("DrainageCount")
                        .HasColumnType("numeric");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<decimal>("Length")
                        .HasColumnType("numeric");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OwnerId")
                        .HasColumnType("integer");

                    b.Property<decimal>("PumpCapacity")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Volume")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Width")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Ponds");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "User"
                        });
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.SaltRequirement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("PondId")
                        .HasColumnType("integer");

                    b.Property<decimal>("RequiredAmount")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("PondId")
                        .IsUnique();

                    b.ToTable("SaltRequirements");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int?>("GenderId")
                        .HasColumnType("integer");

                    b.Property<string>("IdentityId")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.WaterParameter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("MeasuredAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal?>("NO2")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("NO3")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("Oxygen")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("PO4")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("Ph")
                        .HasColumnType("numeric");

                    b.Property<int>("PondId")
                        .HasColumnType("integer");

                    b.Property<decimal?>("Salinity")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("Temperature")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("PondId");

                    b.ToTable("WaterParameters");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.BlogPost", b =>
                {
                    b.HasOne("KoiCare.Domain.Entities.User", "Author")
                        .WithMany("BlogPosts")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.FeedCalculation", b =>
                {
                    b.HasOne("KoiCare.Domain.Entities.KoiIndividual", "KoiIndividual")
                        .WithMany("FeedCalculations")
                        .HasForeignKey("KoiIndividualId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KoiIndividual");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.FeedingSchedule", b =>
                {
                    b.HasOne("KoiCare.Domain.Entities.KoiIndividual", "KoiIndividual")
                        .WithMany("FeedingSchedules")
                        .HasForeignKey("KoiIndividualId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KoiIndividual");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.KoiGrowth", b =>
                {
                    b.HasOne("KoiCare.Domain.Entities.KoiIndividual", "KoiIndividual")
                        .WithMany("KoiGrowths")
                        .HasForeignKey("KoiIndividualId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KoiIndividual");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.KoiIndividual", b =>
                {
                    b.HasOne("KoiCare.Domain.Entities.KoiType", "KoiType")
                        .WithMany("KoiIndividuals")
                        .HasForeignKey("KoiTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KoiCare.Domain.Entities.Pond", "Pond")
                        .WithMany("KoiIndividuals")
                        .HasForeignKey("PondId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KoiType");

                    b.Navigation("Pond");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.Order", b =>
                {
                    b.HasOne("KoiCare.Domain.Entities.User", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.OrderDetail", b =>
                {
                    b.HasOne("KoiCare.Domain.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KoiCare.Domain.Entities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.PerfectWaterVolume", b =>
                {
                    b.HasOne("KoiCare.Domain.Entities.KoiType", "KoiType")
                        .WithMany("PerfectWaterVolumes")
                        .HasForeignKey("KoiTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KoiType");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.Pond", b =>
                {
                    b.HasOne("KoiCare.Domain.Entities.User", "User")
                        .WithMany("Ponds")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.Product", b =>
                {
                    b.HasOne("KoiCare.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.SaltRequirement", b =>
                {
                    b.HasOne("KoiCare.Domain.Entities.Pond", "Pond")
                        .WithOne("SaltRequirement")
                        .HasForeignKey("KoiCare.Domain.Entities.SaltRequirement", "PondId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pond");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.User", b =>
                {
                    b.HasOne("KoiCare.Domain.Entities.Gender", "Gender")
                        .WithMany("Users")
                        .HasForeignKey("GenderId");

                    b.HasOne("KoiCare.Domain.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.WaterParameter", b =>
                {
                    b.HasOne("KoiCare.Domain.Entities.Pond", "Pond")
                        .WithMany("WaterParameters")
                        .HasForeignKey("PondId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pond");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.Gender", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.KoiIndividual", b =>
                {
                    b.Navigation("FeedCalculations");

                    b.Navigation("FeedingSchedules");

                    b.Navigation("KoiGrowths");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.KoiType", b =>
                {
                    b.Navigation("KoiIndividuals");

                    b.Navigation("PerfectWaterVolumes");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.Pond", b =>
                {
                    b.Navigation("KoiIndividuals");

                    b.Navigation("SaltRequirement")
                        .IsRequired();

                    b.Navigation("WaterParameters");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("KoiCare.Domain.Entities.User", b =>
                {
                    b.Navigation("BlogPosts");

                    b.Navigation("Orders");

                    b.Navigation("Ponds");
                });
#pragma warning restore 612, 618
        }
    }
}
