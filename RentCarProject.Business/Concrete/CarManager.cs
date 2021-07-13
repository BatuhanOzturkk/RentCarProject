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

        public void Add(Car car)
        {
            if (car.DailyPrice <= 0)
                throw new Exception($"Daily price can not be less than zero - {car.DailyPrice}");
            _carDal.Add(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(w => w.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(w => w.ColorId == colorId);
        }
    }
}
