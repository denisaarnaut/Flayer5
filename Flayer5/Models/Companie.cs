using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Flayer5.Models
{
    public class Companie
    {
        public int ID { get; set; }
        public string Nume_Companie { get; set; }
        public ICollection<Bilet> Bilete { get; set; }

    }
}
