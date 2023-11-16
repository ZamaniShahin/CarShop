using CarShop.Domain.Models;

namespace CarShop.Application.Interfaces;

public interface ICarRepositoryService
{
    public bool CreateCar(CreateCar command);
    public bool EditCar(EditCar command);
    public void DeleteCar(long id);
    public CarCategory GetCar(long id);
    public List<CarCategory> GetAllCars();
}