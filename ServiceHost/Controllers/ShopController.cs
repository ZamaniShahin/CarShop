using CarShop.Domain.Interfaces;
using CarShop.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ControllerBase
    {
        private readonly ICarCategoryRepository _carCategoryRepository;
        private readonly ICarRepository _carRepository;
        public ShopController(ICarCategoryRepository carCategoryRepository, ICarRepository carRepository)
        {
            _carCategoryRepository = carCategoryRepository;
            _carRepository = carRepository;
        }

        [HttpGet(Name = "GetIndex")]
        public List<CarCategory> Get()
        {
            var list = _carCategoryRepository.GetAllCategories();
            return list;
        }
    }
}
