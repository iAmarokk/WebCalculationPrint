using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalculationPrint.Models
{
    public class Calculation
    {
        public int CalculationID { get; set; }
        public int FormatID { get; set; }
        public Format Format { get; set; }
        public int PaperID { get; set; }
        public Paper Paper { get; set; }
        public int ColourfulnessID { get; set; }
        public Colourfulness Colourfulness { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal TotalPages { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Discount { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal TotalCost { get; set; }
    }
}
