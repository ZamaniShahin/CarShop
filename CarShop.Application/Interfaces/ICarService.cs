using CarShop.Domain.Models;

namespace CarShop.Application.Interfaces;

public interface ICarService
{
    public bool CreateCar(CreateCar command);
    public void EditCar(EditCar command);
    public void DeleteCar(long id);
    public Car GetCar(long id);
    public List<Car> GetAllCars();
}