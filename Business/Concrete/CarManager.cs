using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{   //manager talepte bulunduklarımız
    
    public class CarManager : ICarService  
    {
        private EfCarDal _carDal; 

       // EfCarDal _carDal = new EfCarDal(); 

        public CarManager(ICarDal carDal)
        {
            _carDal = (EfCarDal)carDal;
        }

        public void Add(Property property)
        {
            _carDal.Add(property);
        }

        public void Delete(Property property)
        {
            _carDal.Delete(property);
        }
  
        public Property GetById(int Id)
        {
            return _carDal.GetById(Id);
        }

        public void Update(Property property)
        {
            _carDal.Update(property);
        }

        public List<Property> GetAll()
        {
            return _carDal.GetAll();
        }
    }
}
