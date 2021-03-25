using PetShopProj5by5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetShopProj5by5.Dal
{
    public class ProductInitializer : DropCreateDatabaseIfModelChanges<PetShopContext>
    {
        protected override void Seed(PetShopContext context)
        {
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

