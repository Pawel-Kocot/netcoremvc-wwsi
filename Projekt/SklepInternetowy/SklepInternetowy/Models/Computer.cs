using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace SklepInternetowy.Models
{
    public class Computer
    {
        public int Id { get; set; }

        public int GPUID { get; set; }
        [ForeignKey("GPUID")]
        public GPU GPU { get; set; }

        public int CPUID { get; set; }
        [ForeignKey("CPUID")]
        public CPU CPU { get; set; }
        
        public int RAMID { get; set; }
        [ForeignKey("RAMID")]
        public RAM RAM { get; set; }

        public int PSUID { get; set; }
        [ForeignKey("PSUID")]
        public PSU PSU { get; set; }

        public int STORAGEID { get; set; }
        [ForeignKey("STORAGEID")]
        public Storage STORAGE { get; set; }

        public double Cena { get; set; }
    }
}
