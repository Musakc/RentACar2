using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FavoriteManager : IFavoriteService
    {
        //EfCarDal _favoriteDal = new EfCarDal();

        private IFavoriteDal _favoriteDal;

        public FavoriteManager(IFavoriteDal favoriteDal)
        {
            _favoriteDal = favoriteDal;
        }


        public void Add(Favorite favorite)
        {
            _favoriteDal.Add(favorite);
        }

        public void Delete(Favorite favorite)
        {
            try
            {
                _favoriteDal.Delete(favorite);
            }
            catch
            {
                throw new Exception("Silme gerçekleşemedi!");
            }
        }

        public List<Favorite> GetAll()
        {
            return _favoriteDal.GetAll();
        }

        public Favorite GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Favorite favorite)
        {
            throw new NotImplementedException();
        }
    }
}
