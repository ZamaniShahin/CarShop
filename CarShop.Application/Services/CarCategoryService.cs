using CarShop.Application.Interfaces;
using CarShop.Domain.Interfaces;
using CarShop.Domain.Models;

namespace CarShop.Application.Services;

public class CarCategoryService:ICarCategoryService
{
    private readonly ICarCategoryRepository _carCategoryRepository;

    public CarCategoryService(ICarCategoryRepository carCategoryRepository)
    {
        _carCategoryRepository = carCategoryRepository;
    }
    //returns true, If Creating Category Be Succeeded
    public bool CreateCategory(CreateCarCategory command)
    {
        return _carCategoryRepository.CreateCategory(command);
    }

    public bool EditCarCategory(EditCarCategory command)
    {
        return _carCategoryRepository.EditCarCategory(command);
    }

    public void DeleteCarCategory(long id)
    {
        _carCategoryRepository.DeleteCarCategory(id);
    }

    public CarCategory GetCategory(long id)
    {
        return _carCategoryRepository.GetCategory(id);
    }

    public List<CarCategory> GetAllCategories()
    {
        return _carCategoryRepository.GetAllCategories();
    }
}