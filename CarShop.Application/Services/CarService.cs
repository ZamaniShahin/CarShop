using CarShop.Application.Interfaces;
using CarShop.Domain.Interfaces;
using CarShop.Domain.Models;

namespace CarShop.Application.Services;

public class CarService:ICarService
{
    private readonly ICarRepository _carRepository;

    public CarService(ICarRepository carRepository)
    {
        _carRepository = carRepository;
    }

    public bool CreateCar(CreateCar command)
    {
       return _carRepository.CreateCar(command);
    }

    public void EditCar(EditCar command)
    {
        _carRepository.EditCar(command);
    }

    public void DeleteCar(long id)
    {
        _carRepository.DeleteCar(id);
    }

    public Car GetCar(long id)
    {
        return _carRepository.GetCar(id);
    }

    public List<Car> GetAllCars()
    {
        return _carRepository.GetAllCars();
    }
}