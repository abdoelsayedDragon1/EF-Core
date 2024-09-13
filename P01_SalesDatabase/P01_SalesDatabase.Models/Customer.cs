using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.P01_SalesDatabase.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? CreaditCardNumber { get; set; }
        public decimal Sales { get;  set; }
        public int SaleId { get; set; }
        public Sale? Sale { get; set; }


    }
}
