﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonService
    {
        List<Person> GetAll();
        Person GetById(int Id);
        void Add(Person person);
        void Delete(Person person);
        void Update(Person person); 
    }
}


