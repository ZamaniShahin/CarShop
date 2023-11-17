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

        [HttpGet("GetIndex")]
        public List<CarCategoryDto> Get()
        {
            var carCategories = _carCategoryRepository.GetAllCategories().Select(x => new CarCategoryDto
            {
                Name = x.CategoryName,
                DateCreated = x.DateCreated.ToString()
            }).ToList();
            return carCategories;
        }
        [HttpGet("Cars")]
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

        [HttpGet("GetCarDetails")]
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

        [HttpPost("CreateCar")]
        public StatusCodeResult GetCreateCar(CreateCar command)
        {
            _carRepository.CreateCar(command);
            return Ok();
        }
        [HttpPost("EditCar")]
        public StatusCodeResult GetEditCar(EditCar command)
        {
            _carRepository.EditCar(command);
            return Ok();
        }

    }
}
