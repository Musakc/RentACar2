﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IPersonDal
    {
        List<Person> GetAll();
        Person GetById(int id);
        void Add(Person person);
        void Update(Person person);
        void Delete(Person person);
    }
}
