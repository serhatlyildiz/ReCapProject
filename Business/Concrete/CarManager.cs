﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _ICarDal;

        public CarManager(ICarDal carDal)
        {
            _ICarDal = carDal;
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            _ICarDal.Add(car);

            return new SuccessResult(Messages.CarAdded);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Car>>(_ICarDal.GetAll(), Messages.CarsListed);
        }

        public IDataResult<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Car> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Car> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
