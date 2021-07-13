using RentCarProject.DataAccess.Abstract;
using RentCarProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RentCarProject.DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ Id=1,BrandId = 2,ColorId = 3,DailyPrice = 10,Description="test",ModelYear =1999 }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var deletedCars = _cars.SingleOrDefault(w => w.Id == car.Id);
            _cars.Remove(deletedCars);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(w => w.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            var updatedCar = _cars.SingleOrDefault(s => s.Id == car.Id);
            updatedCar.BrandId = car.BrandId;
            updatedCar.ColorId = car.ColorId;
            updatedCar.DailyPrice = car.DailyPrice;
            updatedCar.Description = car.Description;
        }
    }
}
