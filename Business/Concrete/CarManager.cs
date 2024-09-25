using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public List<Car> GetAll()
        {
            return _ICarDal.GetAll();
        }
    }
}
