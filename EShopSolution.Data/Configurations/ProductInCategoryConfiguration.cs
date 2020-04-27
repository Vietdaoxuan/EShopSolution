using EShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShopSolution.Data.Configurations
{
    class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");
            builder.HasKey(x => new { x.ProductID, x.CategoryID });
            builder.HasOne(x => x.Product).WithMany(t => t.ProductInCategories).HasForeignKey(t =>t.ProductID);
            builder.HasOne(x => x.Category).WithMany(t => t.ProductsInCategory).HasForeignKey(t =>t.CategoryID);
        }
    }
}
