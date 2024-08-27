using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal Fiyat { get; set; }
    }
}
