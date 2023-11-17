using CarShop.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarShop.Infra.Data.Context.Configurations.CarCategoryConfigurations;

public class CarCategoryConfiguration:IEntityTypeConfiguration<CarCategory>
{
    public void Configure(EntityTypeBuilder<CarCategory> builder)
    {
        //builder.ToTable("CarCategories");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.CategoryName).HasMaxLength(250).IsRequired();
        builder.Property(x => x.DateCreated).HasMaxLength(300);
    }
}