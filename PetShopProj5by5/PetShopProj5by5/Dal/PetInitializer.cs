using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using PetShopProj5by5.Models;

namespace PetShopProj5by5.Dal
{
    public class PetInitializer : DropCreateDatabaseIfModelChanges<PetShopContext>
    {
        protected override void Seed(PetShopContext context)
        {
            var services = new List<Services>
            {
                new Services{ ServiceType = 1, TotalValue = 50, ServiceDescription = "Banho" },
                new Services{ ServiceType = 2, TotalValue = 80, ServiceDescription = "Tosa" },
                new Services{ ServiceType = 3, TotalValue = 100, ServiceDescription = "Banho e Tosa" }
            };
            services.ForEach(s => context.Services.Add(s));
            context.SaveChanges();
            var product = new List<Product>
            {
                new Product{ Type = "Ração",  ProductDescription = "Ração para cachorro de frango ", IndividualValue = 4.99M},
                new Product{ Type = "Brinquedo" ,  ProductDescription = "Bolinha de plástico ", IndividualValue = 6.99M },
                new Product{ Type = "Petisco" , ProductDescription = "Ossinho para limpeza bucal do animal", IndividualValue = 14.99M }
            };
            product.ForEach(p => context.Products.Add(p));
            context.SaveChanges();
        }     
    }
}