using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Property property)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Property.Add(property);
                context.SaveChanges();
            }
        }

        public void Delete(Property property)
        {
            using (var context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(property);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Property> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Property.ToList();
            }
        }

        public Property GetById(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Property.Find(id);
            }
        }

        public void Update(Property property)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Entry(property).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        List<Property> ICarDal.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
