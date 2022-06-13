using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication18.Models
{
    public class Customer
    {
        public long CustomerID { get; set; }
        public long TC { get; set; }
        public string AdSoyad { get; set; }
        public string DogumYeri { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string BabaAdi { get; set; }
        public string AnneAdi { get; set; }
    }
}
