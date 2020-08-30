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
    [Migration("20200830131418_addingphotos")]
    partial class addingphotos
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

                    b.HasData(
                        new
                        {
                            ManufactorId = 1,
                            ManufactorName = "Apple"
                        },
                        new
                        {
                            ManufactorId = 2,
                            ManufactorName = "Samsung"
                        },
                        new
                        {
                            ManufactorId = 3,
                            ManufactorName = "WindowsPhone"
                        },
                        new
                        {
                            ManufactorId = 4,
                            ManufactorName = "Huawei"
                        });
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

                    b.HasData(
                        new
                        {
                            OperationSystemId = 1,
                            OperationSystemName = "IOS7"
                        },
                        new
                        {
                            OperationSystemId = 2,
                            OperationSystemName = "IOS8"
                        },
                        new
                        {
                            OperationSystemId = 3,
                            OperationSystemName = "IOS9"
                        },
                        new
                        {
                            OperationSystemId = 4,
                            OperationSystemName = "IOS10"
                        },
                        new
                        {
                            OperationSystemId = 5,
                            OperationSystemName = "IOS13"
                        },
                        new
                        {
                            OperationSystemId = 6,
                            OperationSystemName = "Windows Phone 7"
                        },
                        new
                        {
                            OperationSystemId = 7,
                            OperationSystemName = "Windows Phone 7.5"
                        },
                        new
                        {
                            OperationSystemId = 8,
                            OperationSystemName = "Windows Phone 8"
                        },
                        new
                        {
                            OperationSystemId = 9,
                            OperationSystemName = "Android 4.1 Jelly Bean"
                        },
                        new
                        {
                            OperationSystemId = 10,
                            OperationSystemName = "Android 4.4 KitKat"
                        },
                        new
                        {
                            OperationSystemId = 11,
                            OperationSystemName = "Android 5.0 Lollipop"
                        },
                        new
                        {
                            OperationSystemId = 12,
                            OperationSystemName = "Android 6.0"
                        },
                        new
                        {
                            OperationSystemId = 13,
                            OperationSystemName = "Android 7.0"
                        },
                        new
                        {
                            OperationSystemId = 14,
                            OperationSystemName = "Android 8.0"
                        },
                        new
                        {
                            OperationSystemId = 15,
                            OperationSystemName = "Android 9"
                        },
                        new
                        {
                            OperationSystemId = 16,
                            OperationSystemName = "Android 11"
                        });
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

                    b.HasData(
                        new
                        {
                            PhoneId = 1,
                            ManufactorId = 1,
                            Memory = "16GB, 1GB RAM",
                            OperationSystemId = 1,
                            PhoneName = "iphone 5",
                            Processor = "A7",
                            ScreenResolution = "1334 - by - 750 - pixel",
                            Size = 4.0,
                            VideoPath = "F:\\PhoneVideos\\Iphone5",
                            Wight = 4.0499999999999998
                        },
                        new
                        {
                            PhoneId = 2,
                            ManufactorId = 1,
                            Memory = "32GB, 2GB RAM",
                            OperationSystemId = 2,
                            PhoneName = "iphone 6",
                            Processor = "A8",
                            ScreenResolution = "1600-by-850-pixel",
                            Size = 4.7000000000000002,
                            VideoPath = "F:\\PhoneVideos\\Iphone6",
                            Wight = 4.5499999999999998
                        },
                        new
                        {
                            PhoneId = 3,
                            ManufactorId = 1,
                            Memory = "32GB, 2GB RAM",
                            OperationSystemId = 3,
                            PhoneName = "iphone 7",
                            Processor = "A9",
                            ScreenResolution = "1700-by-850-pixel",
                            Size = 4.7000000000000002,
                            VideoPath = "F:\\PhoneVideos\\Iphone7",
                            Wight = 4.5499999999999998
                        },
                        new
                        {
                            PhoneId = 4,
                            ManufactorId = 1,
                            Memory = "32GB, 3GB RAM",
                            OperationSystemId = 3,
                            PhoneName = "iphone 8",
                            Processor = "A9",
                            ScreenResolution = "1700-by-850-pixel",
                            Size = 4.7000000000000002,
                            VideoPath = "F:\\PhoneVideos\\Iphone8",
                            Wight = 4.5499999999999998
                        },
                        new
                        {
                            PhoneId = 5,
                            ManufactorId = 1,
                            Memory = "64GB, 3GB RAM",
                            OperationSystemId = 4,
                            PhoneName = "iphone X",
                            Processor = "A10",
                            ScreenResolution = "2300-by-1000-pixel",
                            Size = 5.0,
                            VideoPath = "F:\\PhoneVideos\\IphoneX",
                            Wight = 4.7000000000000002
                        },
                        new
                        {
                            PhoneId = 6,
                            ManufactorId = 1,
                            Memory = "128GB, 4GB RAM",
                            OperationSystemId = 5,
                            PhoneName = "iphone 11",
                            Processor = "A11",
                            ScreenResolution = "2300-by-1000-pixel",
                            Size = 5.2000000000000002,
                            VideoPath = "F:\\PhoneVideos\\Iphone11",
                            Wight = 5.0
                        },
                        new
                        {
                            PhoneId = 7,
                            ManufactorId = 2,
                            Memory = "16GB, 1GB RAM",
                            OperationSystemId = 9,
                            PhoneName = "Samsung A21",
                            Processor = "Exynos 5 Octa",
                            ScreenResolution = "1334-by-750-pixel",
                            Size = 4.2000000000000002,
                            VideoPath = "F:\\PhoneVideos\\SamsungA21",
                            Wight = 4.5499999999999998
                        },
                        new
                        {
                            PhoneId = 8,
                            ManufactorId = 2,
                            Memory = "16GB, 2GB RAM",
                            OperationSystemId = 10,
                            PhoneName = "Samsung Note2",
                            Processor = "Exynos 7 Octa",
                            ScreenResolution = "1700-by-750-pixel",
                            Size = 5.5999999999999996,
                            VideoPath = "F:\\PhoneVideos\\SamsungNote2",
                            Wight = 5.5499999999999998
                        },
                        new
                        {
                            PhoneId = 9,
                            ManufactorId = 2,
                            Memory = "32GB, 2GB RAM",
                            OperationSystemId = 11,
                            PhoneName = "Samsung Note3",
                            Processor = "Exynos 8 Octa",
                            ScreenResolution = "1800-by-850-pixel",
                            Size = 5.5999999999999996,
                            VideoPath = "F:\\PhoneVideos\\SamsungNote3",
                            Wight = 5.5499999999999998
                        },
                        new
                        {
                            PhoneId = 10,
                            ManufactorId = 2,
                            Memory = "64GB, 3GB RAM",
                            OperationSystemId = 12,
                            PhoneName = "Samsung Galaxy7",
                            Processor = "Exynos 8 Octa",
                            ScreenResolution = "1800-by-850-pixel",
                            Size = 4.7999999999999998,
                            VideoPath = "F:\\PhoneVideos\\SamsungGalaxy7",
                            Wight = 4.7000000000000002
                        },
                        new
                        {
                            PhoneId = 11,
                            ManufactorId = 3,
                            Memory = "16GB, 2GB RAM",
                            OperationSystemId = 6,
                            PhoneName = "Windows Lumia R10",
                            Processor = "Dual-core 480p",
                            ScreenResolution = "1800-by-850-pixel",
                            Size = 4.7999999999999998,
                            VideoPath = "F:\\PhoneVideos\\WindowLumiaR10",
                            Wight = 5.2000000000000002
                        },
                        new
                        {
                            PhoneId = 12,
                            ManufactorId = 3,
                            Memory = "32GB, 2GB RAM",
                            OperationSystemId = 8,
                            PhoneName = "Windows Lumia R15",
                            Processor = "Quad-core 1080p",
                            ScreenResolution = "2000-by-950-pixel",
                            Size = 4.7999999999999998,
                            VideoPath = "F:\\PhoneVideos\\WindowLumiaR15",
                            Wight = 5.2000000000000002
                        },
                        new
                        {
                            PhoneId = 13,
                            ManufactorId = 4,
                            Memory = "64GB, 4GB RAM",
                            OperationSystemId = 16,
                            PhoneName = "Huawei P40",
                            Processor = "Quad-core 1080p",
                            ScreenResolution = "2000-by-950-pixel",
                            Size = 5.4000000000000004,
                            VideoPath = "F:\\PhoneVideos\\HuaweiP40",
                            Wight = 5.2000000000000002
                        },
                        new
                        {
                            PhoneId = 14,
                            ManufactorId = 4,
                            Memory = "64GB, 3GB RAM",
                            OperationSystemId = 15,
                            PhoneName = "Huawei P30",
                            Processor = "Quad-core 1080p",
                            ScreenResolution = "2000-by-950-pixel",
                            Size = 5.4000000000000004,
                            VideoPath = "F:\\PhoneVideos\\HuaweiP30",
                            Wight = 5.2000000000000002
                        });
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

                    b.HasData(
                        new
                        {
                            PhotoId = 1,
                            PhoneId = 1,
                            PhotoPath = "F:\\PhonePhotos\\Iphone5_1"
                        });
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
