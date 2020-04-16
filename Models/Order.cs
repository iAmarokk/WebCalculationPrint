using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalculationPrint.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public Client Client { get; set; }
        public int CalculationsID { get; set; }
        public Calculation Calculation { get; set; }
        public DateTime Date { get; set; }
    }
}
