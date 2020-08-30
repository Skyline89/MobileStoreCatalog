using Mobile_Store_Catalog_wandio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobile_Store_Catalog_wandio.Data
{
    public static class DbInitializer
    {
        public static void Initialze(MobileStoreCatalogContext db)
        {
            db.Database.EnsureCreated();

            if (db.Phones.Any())
            {
                return;
            }
            var manufactors = new Manufactor[]
            {
                new Manufactor{ManufactorId =1, ManufactorName ="Apple"},
                new Manufactor{ManufactorId =2, ManufactorName ="Samsung"},
                new Manufactor{ManufactorId =3, ManufactorName ="Windows Phone"},
                new Manufactor{ManufactorId =4, ManufactorName ="Huawei"},
            };
            foreach(Manufactor man in manufactors)
            {
                db.Manufactors.Add(man);
            }
            db.SaveChanges();
            var operationSystems = new OperationSystem[]
            {
                new OperationSystem{OperationSystemId = 1, OperationSystemName = "IOS7"},
                new OperationSystem{OperationSystemId = 2, OperationSystemName = "IOS8"},
                new OperationSystem{OperationSystemId = 3, OperationSystemName = "IOS9"},
                new OperationSystem{OperationSystemId = 4, OperationSystemName = "IOSX"},
                new OperationSystem{OperationSystemId = 5, OperationSystemName = "IOS13"},
                new OperationSystem{OperationSystemId = 6, OperationSystemName = "Windows Phone 7"},
                new OperationSystem{OperationSystemId = 7, OperationSystemName = "Windows Phone 7.5"},
                new OperationSystem{OperationSystemId = 8, OperationSystemName = "Windows Phone 8"},
                new OperationSystem{OperationSystemId = 9, OperationSystemName = "Android 4.1 Jelly Bean"},
                new OperationSystem{OperationSystemId = 10, OperationSystemName = "Android 4.4 KitKat"},
                new OperationSystem{OperationSystemId = 11, OperationSystemName = "Android 5.0 Lollipop"},
                new OperationSystem{OperationSystemId = 12, OperationSystemName = "Android 6.0"},
                new OperationSystem{OperationSystemId = 13, OperationSystemName = "Android 7.0"},
                new OperationSystem{OperationSystemId = 14, OperationSystemName = "Android 8.0"},
                new OperationSystem{OperationSystemId = 15, OperationSystemName = "Android 9"},
                new OperationSystem{OperationSystemId = 16, OperationSystemName = "Android 11"},
            };
            foreach(OperationSystem os in operationSystems)
            {
                db.OperationSystems.Add(os);
            }
            db.SaveChanges();
            var phone = new Phone[]
            {
                new Phone{ ManufactorId = 1, OperationSystemId = 1, PhoneName="iphone 5", Size = 4.0, Wight = 4.05, ScreenResolution = "1334-by-750-pixel",Processor = "A7",Memory ="16GB, 1GB RAM" },
                new Phone{ ManufactorId = 1, OperationSystemId = 2, PhoneName="iphone 6", Size = 4.7, Wight = 4.55, ScreenResolution = "1600-by-850-pixel",Processor = "A8",Memory ="32GB, 2GB RAM" },
                new Phone{ ManufactorId = 1, OperationSystemId = 3, PhoneName="iphone 7", Size = 4.7, Wight = 4.55, ScreenResolution = "1700-by-850-pixel",Processor = "A9",Memory ="32GB, 2GB RAM" },
                new Phone{ ManufactorId = 1, OperationSystemId = 3, PhoneName="iphone 8", Size = 4.7, Wight = 4.55, ScreenResolution = "1700-by-850-pixel",Processor = "A9",Memory ="32GB, 3GB RAM" },
                new Phone{ ManufactorId = 1, OperationSystemId = 4, PhoneName="iphone X", Size = 5.0, Wight = 4.70, ScreenResolution = "2300-by-1000-pixel",Processor = "A10",Memory ="64GB, 3GB RAM" },
                new Phone{ ManufactorId = 1, OperationSystemId = 5, PhoneName="iphone 11", Size = 5.2, Wight = 5.0, ScreenResolution = "2300-by-1000-pixel",Processor = "A11",Memory ="128GB, 4GB RAM" },
                new Phone{ ManufactorId = 2, OperationSystemId = 9, PhoneName="Samsung A21", Size = 4.2, Wight = 4.55, ScreenResolution = "1334-by-750-pixel",Processor = "Exynos 5 Octa",Memory ="16GB, 1GB RAM" },
                new Phone{ ManufactorId = 2, OperationSystemId = 10, PhoneName="Samsung Note2", Size = 5.6, Wight = 5.55, ScreenResolution = "1700-by-750-pixel",Processor = "Exynos 7 Octa",Memory ="16GB, 1GB RAM" },
                new Phone{ ManufactorId = 2, OperationSystemId = 11, PhoneName="Samsung Note3", Size = 5.6, Wight = 5.55, ScreenResolution = "1800-by-850-pixel",Processor = "Exynos 8 Octa",Memory ="32GB, 2GB RAM" },
                new Phone{ ManufactorId = 2, OperationSystemId = 12, PhoneName="Samsung Galaxy7", Size = 4.8, Wight = 4.70, ScreenResolution = "1800-by-800-pixel",Processor = "Exynos 8 Octa",Memory ="64GB, 3GB RAM" },

                new Phone{ ManufactorId = 3, OperationSystemId = 6, PhoneName="Lumia R10", Size = 4.8, Wight = 5.2, ScreenResolution = "1800-by-850-pixel",Processor = "Dual-core 480p",Memory ="16GB, 2GB RAM" },
                new Phone{ ManufactorId = 3, OperationSystemId = 6, PhoneName="Lumia R15", Size = 4.8, Wight = 5.2, ScreenResolution = "2000-by-950-pixel",Processor = "Quad-core 1080p",Memory ="32GB, 3GB RAM" },
                new Phone{ ManufactorId = 4, OperationSystemId = 16, PhoneName="P40", Size = 5.4, Wight = 5.2, ScreenResolution = "2000-by-950-pixel",Processor = "Quad-core 1080p",Memory ="32GB, 3GB RAM" },
            };
        }
    }
}
