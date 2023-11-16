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

    public void EditCar(EditCar command)
    {
        var car = _context.Cars.FirstOrDefault(x => x.CarId == command.CarId);
        car.Edit(command.CarName,command.CarBrand,command.CarCreatedYear,command.CarColor);
        SaveChanges();
    }

    public void DeleteCar(long id)
    {
        var car = _context.Cars.FirstOrDefault(x => x.CarId == id);
        _context.Cars.Remove(car);
        SaveChanges();
    }

    public Car GetCar(long id)
    {
        return _context.Cars.FirstOrDefault(c => c.CarId == id);
    }

    public List<Car> GetAllCars()
    {
        return _context.Cars.ToList();
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}