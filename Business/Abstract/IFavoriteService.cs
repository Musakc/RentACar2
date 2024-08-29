using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFavoriteService
    {
        List<Favorite> GetAll();
        Favorite GetById(int Id);
        void Add(Favorite favorite);
        void Delete(Favorite favorite);
        void Update(Favorite favorite);
    }
}
