using CarShop.Domain.Models;

namespace CarShop.Domain.Interfaces
{
    public interface ICarCategoryRepository
    {
        public bool CreateCategory(CreateCarCategory command);
        public bool EditCarCategory(EditCarCategory command);
        public void DeleteCarCategory(long id);
        public CarCategory GetCategory(long id);
        public List<CarCategory> GetAllCategories();

        public void SaveChanges();
    }
}
