using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalculationPrint.Models
{
    public class Calculation
    {
        [Display(Name = "Номер")]
        public int CalculationID { get; set; }
        [Display(Name = "Формат")]
        public int FormatID { get; set; }
        [Display(Name = "Формат")]
        public Format Format { get; set; }
        [Display(Name = "Плотность бумаги")]
        public int PaperID { get; set; }
        [Display(Name = "Плотность бумаги")]
        public Paper Paper { get; set; }
        [Display(Name = "Цветность")]
        public int ColourfulnessID { get; set; }
        [Display(Name = "Цветность")]
        public Colourfulness Colourfulness { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        [Display(Name = "Общее количество страниц")]
        public decimal TotalPages { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        [Display(Name = "Скидка")]
        public decimal Discount { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        [Display(Name = "Общая сумма")]
        public decimal TotalCost { get; set; }
    }
}
