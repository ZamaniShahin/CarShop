using CarShop.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Infra.Data.Context;

public class ShopContext : DbContext
{
    public ShopContext(DbContextOptions<ShopContext> options)
        : base(options) { }
    public DbSet<CarCategory> Categories { get; set; }
}