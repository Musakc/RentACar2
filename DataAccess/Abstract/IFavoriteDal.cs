using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IFavoriteDal
    {
        List<Favorite> GetAll();
        Favorite GetById(int id);
        void Add(Favorite favorite);
        void Update(Favorite favorite);
        void Delete(Favorite favorite);
    }
}
