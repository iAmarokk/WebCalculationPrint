using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalculationPrint.Models
{
    public class Paper
    {
        public int PaperID { get; set; }
        public int Thickness { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal PaperCost { get; set; }
    }
}
