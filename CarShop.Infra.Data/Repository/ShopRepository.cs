using CarShop.Domain.Interfaces;
using CarShop.Domain.Models;
using CarShop.Infra.Data.Context;

namespace CarShop.Infra.Data.Repository;

public class ShopRepository(ShopContext context) : IShopRepository
{
    private readonly ShopContext _context = context;

    public bool CreateCategory(CreateCarCategory command)
    {
        var newCategory = new CarCategory(command.Name);
        _context.Categories.Add(newCategory);
        SaveChanges();
        //checks if newCategory be notnull, returns true
        return !string.IsNullOrWhiteSpace(newCategory.CategoryName);
    }

    public bool EditCarCategory(EditCarCategory command)
    {
        var category = _context.Categories.FirstOrDefault(x=>x.Id == command.Id);
        category.Edit(command.Name);
        SaveChanges();
        //checks if newCategory be notnull, returns true
        return !string.IsNullOrWhiteSpace(category.CategoryName);
    }

    public void DeleteCarCategory(long id)
    {
        var category = _context.Categories.FirstOrDefault(x => x.Id == id);
        _context.Categories.Remove(category);
        SaveChanges();
    }

    public CarCategory GetCategory(long id)
    {
        return _context.Categories.FirstOrDefault(c => c.Id == id);
    }

    public List<CarCategory> GetAllCategories()
    {
        return _context.Categories.ToList();
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}