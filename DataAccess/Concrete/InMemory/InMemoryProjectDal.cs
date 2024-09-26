﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProjectDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryProjectDal()
        {
            _cars = new List<Car>() 
            { 
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=1999,DailyPrice=120000,Description="Hastasına"},
                new Car{CarId=2,BrandId=2,ColorId=1,ModelYear=2005,DailyPrice=250000,Description="Acil"},
                new Car{CarId=3,BrandId=2,ColorId=3,ModelYear=2010,DailyPrice=300000,Description="Temiz"},
                new Car{CarId=4,BrandId=1,ColorId=1,ModelYear=2017,DailyPrice=780000,Description="Otomatik"},
                new Car{CarId=5,BrandId=3,ColorId=2,ModelYear=2024,DailyPrice=1800000,Description="LPG mevcut"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete=_cars.SingleOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.CarId == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate =_cars.SingleOrDefault(p=>p.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
