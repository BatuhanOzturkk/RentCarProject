using RentCarProject.Business.Concrete;
using RentCarProject.DataAccess.Concrete;
using RentCarProject.Entities.Concrete;
using System;
using System.Linq;

namespace RentCar.UI
{
    class Program
    {

        static void Main(string[] args)
        {
            CarTest();
            //ColorTest();
            //BrandTest();
        }

        public static void CarTest()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            carManager.Add(new Car
            {
                BrandId = 1,
                ColorId = 2,
                DailyPrice = 0,
                Id = 3,
                ModelYear = 2003
            });

            var cars = carManager.GetAll();

            if (cars.Any())
            {
                foreach (var item in cars)
                {
                    Console.WriteLine($"Daily Price: {item.DailyPrice}");
                }
            }
        }
        public static void BrandTest()
        {
            // To do
        }

        public static void ColorTest()
        {
            // To do
        }


    }
}