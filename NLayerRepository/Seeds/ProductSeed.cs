using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                CategoryId = 1,
                Price = 1,
                Stock = 20,
                CrearedDate = DateTime.Now,
                Name = "Pencil 1"
            },
            new Product
            {
                Id = 2,
                CategoryId = 1,
                Price = 2,
                Stock = 60,
                CrearedDate = DateTime.Now,
                Name = "Pencil 2"
            },
            new Product
            {
                Id = 3,
                CategoryId = 2,
                Price = 25,
                Stock = 15,
                CrearedDate = DateTime.Now,
                Name = "Book 1"
            }, new Product
            {
                Id = 4,
                CategoryId = 2,
                Price = 20,
                Stock = 40,
                CrearedDate = DateTime.Now,
                Name = "Book 2"
            }
            );


        }
    }
}
