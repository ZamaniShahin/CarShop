using CarShop.Domain.Interfaces;
using CarShop.Domain.Models;

namespace CarShop.Infra.Data.Repository;

public class ShopRepository:IShopRepository
{
    public bool CreateCategory(CreateCarCategory command)
    {
        throw new NotImplementedException();
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