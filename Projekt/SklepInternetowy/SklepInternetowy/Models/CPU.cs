using SklepInternetowy.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SklepInternetowy.Models
{
    public class CPU:IEntityBase
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="Wprowadź nazwę firmy")]
        public string Firma { get; set; }

        [Required(ErrorMessage = "Wprowadź model")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Wprowadź cenę")]
        public double Cena { get; set; }

        
    }
}
