using CarShop.Application.Interfaces;
using CarShop.Domain.Interfaces;
using CarShop.Domain.Models;

namespace CarShop.Application.Services;

public class ShopService:IShopService
{
    private readonly IShopRepository _shopRepository;

    public ShopService(IShopRepository shopRepository)
    {
        _shopRepository = shopRepository;
    }
    //returns true, If Creating Category Be Succeeded
    public bool CreateCategory(CreateCarCategory command)
    {
        return _shopRepository.CreateCategory(command);
    }

    public bool EditCarCategory(EditCarCategory command)
    {
        return _shopRepository.EditCarCategory(command);
    }

    public bool DeleteCarCategory(long id)
    {
        return _shopRepository.DeleteCarCategory(id);
    }

    public CarCategory GetCategory(long id)
    {
        return _shopRepository.GetCategory(id);
    }

    public List<CarCategory> GetAllCategories()
    {
        return _shopRepository.GetAllCategories();
    }
}