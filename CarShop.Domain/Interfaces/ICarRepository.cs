using CarShop.Domain.Models;

namespace CarShop.Domain.Interfaces;

public interface ICarRepository
{
    public bool CreateCar(CreateCar command);
    public void EditCar(EditCar command);
    public void DeleteCar(long id);
    public CarCategory GetCar(long id);
    public List<CarCategory> GetAllCars();
}