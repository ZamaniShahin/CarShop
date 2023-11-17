using CarShop.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarShop.Infra.Data.Context.Configurations.CarConfigurations
{
    public class CarConfiguration:IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            //builder.ToTable("Cars");
            builder.HasKey(x => x.CarId);
            builder.Property(x => x.CarBrand).HasMaxLength(250).IsRequired();
            builder.Property(x => x.CarName).HasMaxLength(250).IsRequired();
            builder.Property(x => x.CarColor).HasMaxLength(50).IsRequired();
            builder.Property(x => x.CarCreatedYear).HasMaxLength(250).IsRequired();
            builder.Property(x => x.DateCarCreatedBanner).HasMaxLength(250).IsRequired();

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Cars)
                .HasForeignKey(x => x.CarId);
        }
    }
}
