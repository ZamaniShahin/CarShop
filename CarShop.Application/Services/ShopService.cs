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
        var newCategory = new CarCategory(command.Name);
        return !string.IsNullOrWhiteSpace(newCategory.CategoryName);
    }

    public bool EditCarCategory(EditCarCategory command)
    {
        throw new NotImplementedException();
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
}