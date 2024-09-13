using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.P01_SalesDatabase.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        public string? Name { get; set; }
        public decimal Sales { get; set; }
        public int SaleId { get; set; }
        public Sale? Sale { get; set; }
    }
}
