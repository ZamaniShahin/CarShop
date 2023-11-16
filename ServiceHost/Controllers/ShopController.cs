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

        public ShopController(ICarCategoryRepository carCategoryRepository)
        {
            _carCategoryRepository = carCategoryRepository;
        }

        [HttpGet(Name = "GetIndex")]
        public List<CarCategory> Get()
        {
            var list = _carCategoryRepository.GetAllCategories();
            return list;
        }
    }
}
