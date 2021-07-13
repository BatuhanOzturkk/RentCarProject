using RentCarProject.Business.Concrete;
using RentCarProject.DataAccess.Concrete;
using System;

namespace RentCar.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine($"Daily Price: {item.DailyPrice}");
            }
        }
    }
}
