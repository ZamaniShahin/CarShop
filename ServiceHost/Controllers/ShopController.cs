using CarShop.Application.ViewModels;
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
        public List<CarCategoryDto> Get()
        {
            var carCategories = _carCategoryRepository.GetAllCategories().Select(x => new CarCategoryDto
            {
                Name = x.CategoryName,
                DateCreated = x.DateCreated.ToString()
            }).ToList();
            return carCategories;
        }
        [HttpGet(Name = "GetCarsIndex")]
        public List<CarDto> GetCars()
        {
            var categoryName = _carCategoryRepository;
            var cars = _carRepository.GetAllCars().Select(x => new CarDto
            {
                CarBrand = x.CarBrand,
                CarColor = x.CarColor,
                CarCreatedYear = x.CarCreatedYear,
                CarName = x.CarName
            }).ToList();
            return cars;
        }

        [HttpGet(Name = "GetCarDetails")]
        public CarDto GetCarDetails(int id)
        {
            var car = _carRepository.GetCar(id);
            var result = new CarDto
            {
                CarBrand = car.CarBrand,
                CarColor = car.CarColor,
                CarCreatedYear = car.CarCreatedYear,
                CarName = car.CarName,
                CarCategory = car.Category.CategoryName,
            };
            return result;
        }

        [HttpGet(Name = "GetCreateCar")]
        public StatusCodeResult GetCreateCar(CreateCar command)
        {
            var car = _carRepository.CreateCar(command);
            return Ok();
        }
    }
}
