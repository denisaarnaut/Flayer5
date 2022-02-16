using System.Collections.Generic;

namespace Flayer5.Models
{
    public class Pachet
    {
        public int ID { get; set; }
        public string Nume_Pachet { get; set; }
        public ICollection<BiletPachet> BiletPachete { get; set; }
    }
}
