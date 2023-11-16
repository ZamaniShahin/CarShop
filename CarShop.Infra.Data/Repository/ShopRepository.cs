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
        _context.CarCategories.Add(newCategory);
        SaveChanges();
        //checks if newCategory be notnull, returns true
        return !string.IsNullOrWhiteSpace(newCategory.CategoryName);
    }

    public bool EditCarCategory(EditCarCategory command)
    {
        var category = _context.CarCategories.FirstOrDefault(x=>x.Id == command.Id);
        category.Edit(command.Name);
        SaveChanges();
        //checks if newCategory be notnull, returns true
        return !string.IsNullOrWhiteSpace(category.CategoryName);
    }

    public void DeleteCarCategory(long id)
    {
        var category = _context.CarCategories.FirstOrDefault(x => x.Id == id);
        _context.CarCategories.Remove(category);
        SaveChanges();
    }

    public CarCategory GetCategory(long id)
    {
        return _context.CarCategories.FirstOrDefault(c => c.Id == id);
    }

    public List<CarCategory> GetAllCategories()
    {
        return _context.CarCategories.ToList();
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}