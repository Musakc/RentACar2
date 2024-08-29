using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Favorite : IEntity
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public decimal Fiyat { get; set; }
        public string Renk { get; set; }    
        public int KM { get; set; }
        public int PropertyId { get; set; }
    }
}
