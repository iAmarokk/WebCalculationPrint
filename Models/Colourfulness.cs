using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalculationPrint.Models
{
    public class Colourfulness
    {
        public int ColourfulnessID { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal ColourfulnessRate { get; set; }
    }
}
