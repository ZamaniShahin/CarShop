using CarShop.Domain.Interfaces;
using CarShop.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ControllerBase
    {
        private readonly IShopRepository _shopRepository;

        public ShopController(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }

        [HttpGet(Name = "GetIndex")]
        public List<CarCategory> Get()
        {
            var list = _shopRepository.GetAllCategories();
            return list;
        }
    }
}
