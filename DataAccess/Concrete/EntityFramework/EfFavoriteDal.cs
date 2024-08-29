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
    public class EfFavoriteDal : IFavoriteDal
    {
        public void Add(Favorite favorite)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Favorite.Add(favorite);
                context.SaveChanges();
            }
        }

        public void Delete(Favorite favorite)
        {
            using (var context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(favorite);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

                //context.Favorite.Remove(favorite);
                //        context.SaveChanges();
            }
        }

        public List<Favorite> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Favorite.ToList();
            }
        }

        public Favorite GetById(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Favorite.Find(id);
            }
        }

        public void Update(Favorite favorite)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Entry(favorite).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
