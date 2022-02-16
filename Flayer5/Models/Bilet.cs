using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Flayer5.Models
{
    public class Bilet
    {
        public int ID { get; set; } 
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Destinatie { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        public decimal Pret { get; set; }
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        public int CompanieID { get; set; }
        public Companie Companie { get; set; } 
        public ICollection<BiletPachet> BiletPachete { get; set; }
    }
}
