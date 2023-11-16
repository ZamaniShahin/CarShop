using CarShop.Domain.Interfaces;
using CarShop.Domain.Models;
using CarShop.Infra.Data.Context;

namespace CarShop.Infra.Data.Repository;

public class CarRepository(ShopContext context) : ICarRepository
{
    private readonly ShopContext _context = context;

    public bool CreateCar(CreateCar command)
    {
        var newCar = new Car(command.CarName,command.CarBrand,command.CarCreatedYear,command.CarColor);
        _context.Cars.Add(newCar);
        SaveChanges();
        //checks if newCategory be notnull, returns true
        return !string.IsNullOrWhiteSpace(newCar.CarName);
    }

    public bool EditCarCategory(EditCarCategory command)
    {
        var category = _context.CarCategories.FirstOrDefault(x => x.Id == command.Id);
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