using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalculationPrint.Models
{
    public class Calculation
    {
        public int CalculationID { get; set; }
        public decimal FormatRatio { get; set; }
        public Format Format { get; set; }
        public decimal PaperCost { get; set; }
        public Paper Paper { get; set; }
        public decimal ColourfulnessRate { get; set; }
        public Colourfulness Colourfulness { get; set; }
        public decimal TotalPages { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalCost { get; set; }
    }
}
