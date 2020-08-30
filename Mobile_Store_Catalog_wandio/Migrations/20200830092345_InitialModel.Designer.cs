﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mobile_Store_Catalog_wandio.Data;

namespace Mobile_Store_Catalog_wandio.Migrations
{
    [DbContext(typeof(MobileStoreCatalogContext))]
    [Migration("20200830092345_InitialModel")]
    partial class InitialModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mobile_Store_Catalog_wandio.Models.Manufactor", b =>
                {
                    b.Property<int>("ManufactorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ManufactorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("ManufactorId");

                    b.ToTable("Manufactors");
                });

            modelBuilder.Entity("Mobile_Store_Catalog_wandio.Models.OperationSystem", b =>
                {
                    b.Property<int>("OperationSystemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OperationSystemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("OperationSystemId");

                    b.ToTable("OperationSystems");
                });

            modelBuilder.Entity("Mobile_Store_Catalog_wandio.Models.Phone", b =>
                {
                    b.Property<int>("PhoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ManufactorId")
                        .HasColumnType("int");

                    b.Property<string>("Memory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OperationSystemId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ScreenResolution")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<double>("Size")
                        .HasColumnType("float");

                    b.Property<string>("VideoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<double>("Wight")
                        .HasColumnType("float");

                    b.HasKey("PhoneId");

                    b.HasIndex("ManufactorId");

                    b.HasIndex("OperationSystemId");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("Mobile_Store_Catalog_wandio.Models.Photo", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PhoneId")
                        .HasColumnType("int");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("PhotoId");

                    b.HasIndex("PhoneId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("Mobile_Store_Catalog_wandio.Models.Phone", b =>
                {
                    b.HasOne("Mobile_Store_Catalog_wandio.Models.Manufactor", "Manufactor")
                        .WithMany("Phones")
                        .HasForeignKey("ManufactorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mobile_Store_Catalog_wandio.Models.OperationSystem", "OperationSystem")
                        .WithMany("Phones")
                        .HasForeignKey("OperationSystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Mobile_Store_Catalog_wandio.Models.Photo", b =>
                {
                    b.HasOne("Mobile_Store_Catalog_wandio.Models.Phone", "Phone")
                        .WithMany("Photos")
                        .HasForeignKey("PhoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
