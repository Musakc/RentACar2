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
    public class PersonManager : IPersonService
    {
        private IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }
        public void Add(Person person)
        {
            _personDal.Add(person);
        }

        public void Delete(Person person)
        {
            try
            {
                _personDal.Delete(person);
            }
            catch
            {
                throw new Exception("Silme gerçekleşemedi!");
            }
        }

        public List<Person> GetAll()
        {
            return _personDal.GetAll();
        }

        public Person GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
