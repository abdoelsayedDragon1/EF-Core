using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.P01_SalesDatabase.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        public DateTime? Date { get; set; }
        public List<Product>? Product { get; set; }
        public List<Customer>? Customer { get; set; }
        public List<Store>? Store { get; set; }

    }
}
