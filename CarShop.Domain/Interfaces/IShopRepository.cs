using CarShop.Domain.Models;

namespace CarShop.Domain.Interfaces
{
    public interface IShopRepository
    {
        public bool CreateCategory(CreateCarCategory command);
        public bool EditCarCategory(EditCarCategory command);
        public bool DeleteCarCategory(long id);
        public CarCategory GetCategory(long id);
        public List<CarCategory> GetAllCategories();
    }
}
