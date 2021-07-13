using Microsoft.EntityFrameworkCore;
using RentCarProject.DataAccess.Abstract;
using RentCarProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RentCarProject.DataAccess.Concrete
{
    public class EFCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            using (RentCarContext context = new RentCarContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RentCarContext context = new RentCarContext())
            {
                return filter != null ? context.Set<Car>().Where(filter).ToList() : context.Set<Car>().ToList();
            }
        }

        public void Update(Car entity)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
