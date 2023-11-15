using CarShop.Domain.Interfaces;
using CarShop.Domain.Models;
using CarShop.Infra.Data.Context;

namespace CarShop.Infra.Data.Repository;

public class ShopRepository:IShopRepository
{
    private readonly ShopContext _context;

    public ShopRepository(ShopContext context)
    {
        _context = context;
    }
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
        category.CategoryName = command.Name;
        SaveChanges();
        //checks if newCategory be notnull, returns true
        return !string.IsNullOrWhiteSpace(category.CategoryName);
    }

    public bool DeleteCarCategory(long id)
    {
        throw new NotImplementedException();
    }

    public CarCategory GetCategory(long id)
    {
        throw new NotImplementedException();
    }

    public List<CarCategory> GetAllCategories()
    {
        throw new NotImplementedException();
    }

    public void SaveChanges()
    {
        throw new NotImplementedException();
    }
}