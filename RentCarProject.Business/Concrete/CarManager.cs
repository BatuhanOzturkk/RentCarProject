using RentCarProject.Business.Abstract;
using RentCarProject.DataAccess.Abstract;
using RentCarProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentCarProject.Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
    }
}
