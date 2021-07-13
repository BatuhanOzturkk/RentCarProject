using RentCarProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentCarProject.Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
        void Add(Car car);
    }
}
