﻿using CarShop.Application.Interfaces;
using CarShop.Domain.Models;

namespace CarShop.Application.Services;

public class CarService:ICarService
{
    public bool CreateCar(CreateCar command)
    {
        throw new NotImplementedException();
    }

    public bool EditCar(EditCar command)
    {
        throw new NotImplementedException();
    }

    public void DeleteCar(long id)
    {
        throw new NotImplementedException();
    }

    public CarCategory GetCar(long id)
    {
        throw new NotImplementedException();
    }

    public List<CarCategory> GetAllCars()
    {
        throw new NotImplementedException();
    }
}