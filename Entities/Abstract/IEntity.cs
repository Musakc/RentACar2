using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IEntity 
    {
        int Id { get; set; }
        string Marka { get; set; }
        string Model { get; set; }
        decimal Fiyat { get; set; }
    }   
}
