using CarShop.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Infra.Data.Context;

public class ShopContext(DbContextOptions<ShopContext> options) : DbContext(options)
{
    public DbSet<CarCategory> CarCategories { get; set; }
}