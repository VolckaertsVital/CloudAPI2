using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirsoftBase.Model
{
    public class DBInititializer
    {
        public static void Init(Context ctxt)
        {
            ctxt.Database.EnsureCreated();
            if (!ctxt.Airsofts.Any())
            {
                var air1 = new AirsoftGun()
                {
                    Brand = "ARES",
                    Type = "submachine",
                    Name = "MP5",
                    MagazineSize = 100,
                    FPS = 250,
                    Caliber = 6,
                    Joule = 1,
                    GearBox = "Gas",
                    Lenght = 66,
                    Weight = 2.8,
                    Battery = false,
                    Description = "This submachine is compact and full metal."

                };

                var air2 = new AirsoftGun()
                {
                    Brand = "AEG",
                    Type = "Rifle",
                    Name = "M14",
                    MagazineSize = 400,
                    FPS = 350,
                    Caliber = 6,
                    Joule = 1.4,
                    GearBox = "version 3",
                    Lenght = 140,
                    Weight = 3.5,
                    Battery = true,
                    Description = "This Rifle is very accurate at long distance."

                };

                ctxt.Airsofts.Add(air1);
                ctxt.Airsofts.Add(air2);
                ctxt.SaveChanges();
            };
        }
    }
}
