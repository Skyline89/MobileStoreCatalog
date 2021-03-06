﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mobile_Store_Catalog_wandio.Models
{
    public static class ModelBuilderExtension
    {
        public static void Populate(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufactor>().HasData(
                new Manufactor
                {
                    ManufactorId = 1,
                    ManufactorName = "Apple"
                },
                new Manufactor
                {
                    ManufactorId = 2,
                    ManufactorName = "Samsung"
                },
                new Manufactor
                {
                    ManufactorId = 3,
                    ManufactorName = "WindowsPhone"
                },
                new Manufactor  
                {
                    ManufactorId = 4,
                    ManufactorName = "Huawei"
                }
            );
            modelBuilder.Entity<OperationSystem>().HasData(
                new OperationSystem
                {
                    OperationSystemId = 1,
                    OperationSystemName = "IOS7"
                }, 
                new OperationSystem
                {
                    OperationSystemId = 2,
                    OperationSystemName = "IOS8"
                },
                new OperationSystem
                {
                    OperationSystemId = 3,
                    OperationSystemName = "IOS9"
                }, 
                new OperationSystem
                {
                    OperationSystemId = 4,
                    OperationSystemName = "IOS10"
                }, 
                new OperationSystem
                {
                    OperationSystemId = 5,
                    OperationSystemName = "IOS13"
                },
                new OperationSystem
                {
                    OperationSystemId = 6,
                    OperationSystemName = "Windows Phone 7"
                },
                new OperationSystem
                {
                    OperationSystemId = 7,
                    OperationSystemName = "Windows Phone 7.5"
                },
                new OperationSystem
                {
                    OperationSystemId = 8,
                    OperationSystemName = "Windows Phone 8"
                },
                new OperationSystem
                {
                    OperationSystemId = 9,
                    OperationSystemName = "Android 4.1 Jelly Bean"
                },
                new OperationSystem
                {
                    OperationSystemId = 10,
                    OperationSystemName = "Android 4.4 KitKat"
                },
                new OperationSystem
                {
                    OperationSystemId = 11,
                    OperationSystemName = "Android 5.0 Lollipop"
                },
                new OperationSystem
                {
                    OperationSystemId = 12,
                    OperationSystemName = "Android 6.0"
                },
                new OperationSystem
                {
                    OperationSystemId = 13,
                    OperationSystemName = "Android 7.0"
                },
                new OperationSystem
                {
                    OperationSystemId = 14,
                    OperationSystemName = "Android 8.0"
                },
                new OperationSystem
                {
                    OperationSystemId = 15,
                    OperationSystemName = "Android 9"
                },
                new OperationSystem
                {
                    OperationSystemId = 16,
                    OperationSystemName = "Android 11"
                }
            );
            modelBuilder.Entity<Phone>().HasData(
                new Phone
                {
                    PhoneId = 1,
                    ManufactorId = 1,
                    OperationSystemId = 1,
                    PhoneName = "iphone 5",
                    Size = 4.0,
                    Wight = 4.05,
                    ScreenResolution = "1334 - by - 750 - pixel",
                    Processor = "A7",
                    Memory = "16GB, 1GB RAM",
                    VideoPath = @"F:\PhoneVideos\Iphone5"
                },
                new Phone
                {
                    PhoneId = 2,
                    ManufactorId = 1,
                    OperationSystemId = 2,
                    PhoneName = "iphone 6",
                    Size = 4.7,
                    Wight = 4.55,
                    ScreenResolution = "1600-by-850-pixel",
                    Processor = "A8",
                    Memory = "32GB, 2GB RAM",
                    VideoPath = @"F:\PhoneVideos\Iphone6"
                },
                new Phone
                {
                    PhoneId = 3,
                    ManufactorId = 1,
                    OperationSystemId = 3,
                    PhoneName = "iphone 7",
                    Size = 4.7,
                    Wight = 4.55,
                    ScreenResolution = "1700-by-850-pixel",
                    Processor = "A9",
                    Memory = "32GB, 2GB RAM",
                    VideoPath = @"F:\PhoneVideos\Iphone7"
                },
                new Phone
                {
                    PhoneId = 4,
                    ManufactorId = 1,
                    OperationSystemId = 3,
                    PhoneName = "iphone 8",
                    Size = 4.7,
                    Wight = 4.55,
                    ScreenResolution = "1700-by-850-pixel",
                    Processor = "A9",
                    Memory = "32GB, 3GB RAM",
                    VideoPath = @"F:\PhoneVideos\Iphone8"
                }, 
                new Phone
                {
                    PhoneId = 5,
                    ManufactorId = 1,
                    OperationSystemId = 4,
                    PhoneName = "iphone X",
                    Size = 5.0,
                    Wight = 4.70,
                    ScreenResolution = "2300-by-1000-pixel",
                    Processor = "A10",
                    Memory = "64GB, 3GB RAM",
                    VideoPath = @"F:\PhoneVideos\IphoneX"
                },
                new Phone
                {
                    PhoneId = 6,
                    ManufactorId = 1,
                    OperationSystemId = 5,
                    PhoneName = "iphone 11",
                    Size = 5.2,
                    Wight = 5.0,
                    ScreenResolution = "2300-by-1000-pixel",
                    Processor = "A11",
                    Memory = "128GB, 4GB RAM",
                    VideoPath = @"F:\PhoneVideos\Iphone11"
                },
                new Phone
                {
                    PhoneId = 7,
                    ManufactorId = 2,
                    OperationSystemId = 9,
                    PhoneName = "Samsung A21",
                    Size = 4.2,
                    Wight = 4.55,
                    ScreenResolution = "1334-by-750-pixel",
                    Processor = "Exynos 5 Octa",
                    Memory = "16GB, 1GB RAM",
                    VideoPath = @"F:\PhoneVideos\SamsungA21"
                },
                new Phone
                {
                    PhoneId = 8,
                    ManufactorId = 2,
                    OperationSystemId = 10,
                    PhoneName = "Samsung Note2",
                    Size = 5.6,
                    Wight = 5.55,
                    ScreenResolution = "1700-by-750-pixel",
                    Processor = "Exynos 7 Octa",
                    Memory = "16GB, 2GB RAM",
                    VideoPath = @"F:\PhoneVideos\SamsungNote2"
                },
                new Phone
                {
                    PhoneId = 9,
                    ManufactorId = 2,
                    OperationSystemId = 11,
                    PhoneName = "Samsung Note3",
                    Size = 5.6,
                    Wight = 5.55,
                    ScreenResolution = "1800-by-850-pixel",
                    Processor = "Exynos 8 Octa",
                    Memory = "32GB, 2GB RAM",
                    VideoPath = @"F:\PhoneVideos\SamsungNote3"
                },
                new Phone
                {
                    PhoneId = 10,
                    ManufactorId = 2,
                    OperationSystemId = 12,
                    PhoneName = "Samsung Galaxy7",
                    Size = 4.8,
                    Wight = 4.7,
                    ScreenResolution = "1800-by-850-pixel",
                    Processor = "Exynos 8 Octa",
                    Memory = "64GB, 3GB RAM",
                    VideoPath = @"F:\PhoneVideos\SamsungGalaxy7"
                },
                new Phone
                {
                    PhoneId = 11,
                    ManufactorId = 3,
                    OperationSystemId = 6,
                    PhoneName = "Windows Lumia R10",
                    Size = 4.8,
                    Wight = 5.2,
                    ScreenResolution = "1800-by-850-pixel",
                    Processor = "Dual-core 480p",
                    Memory = "16GB, 2GB RAM",
                    VideoPath = @"F:\PhoneVideos\WindowLumiaR10"
                },
                new Phone
                {
                    PhoneId = 12,
                    ManufactorId = 3,
                    OperationSystemId = 8,
                    PhoneName = "Windows Lumia R15",
                    Size = 4.8,
                    Wight = 5.2,
                    ScreenResolution = "2000-by-950-pixel",
                    Processor = "Quad-core 1080p",
                    Memory = "32GB, 2GB RAM",
                    VideoPath = @"F:\PhoneVideos\WindowLumiaR15"
                },
                new Phone
                {
                    PhoneId = 13,
                    ManufactorId = 4,
                    OperationSystemId = 16,
                    PhoneName = "Huawei P40",
                    Size = 5.4,
                    Wight = 5.2,
                    ScreenResolution = "2000-by-950-pixel",
                    Processor = "Quad-core 1080p",
                    Memory = "64GB, 4GB RAM",
                    VideoPath = @"F:\PhoneVideos\HuaweiP40"
                },
                new Phone
                {
                    PhoneId = 14,
                    ManufactorId = 4,
                    OperationSystemId = 15,
                    PhoneName = "Huawei P30",
                    Size = 5.4,
                    Wight = 5.2,
                    ScreenResolution = "2000-by-950-pixel",
                    Processor = "Quad-core 1080p",
                    Memory = "64GB, 3GB RAM",
                    VideoPath = @"F:\PhoneVideos\HuaweiP30"
                }
            );
        }
    }
}
