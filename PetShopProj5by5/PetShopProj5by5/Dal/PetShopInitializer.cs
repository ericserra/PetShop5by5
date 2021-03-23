using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using PetShopProj5by5.Models;

namespace PetShopProj5by5.Dal
{
    public class PetShopInitializer : DropCreateDatabaseIfModelChanges<PetShopContext>
    {
        protected override void Seed(PetShopContext context)
        {
            var services = new List<Services>
            {
                new Services{ServiceType = 1, TotalValue = 50, ServiceDescription = "Banho" },
                new Services{ServiceType = 2, TotalValue = 80, ServiceDescription = "Tosa" },
                new Services{ServiceType = 3, TotalValue = 100, ServiceDescription = "Banho e Tosa" }
            };
            services.ForEach(s => context.Services.Add(s));
            context.SaveChanges();
        }
    }
}