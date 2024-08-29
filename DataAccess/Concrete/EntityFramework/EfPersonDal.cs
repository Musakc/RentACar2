using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPersonDal : IPersonDal
    {
        public void Add(Person person)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Persons.Add(person);
                context.SaveChanges();
            }
        }

        public void Delete(Person person)
        {
            using (var context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(person);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Person> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Persons.ToList();
            }
        }

        public Person GetById(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Persons.Find(id);
            }
        }

        public void Update(Person person)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Entry(person).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
