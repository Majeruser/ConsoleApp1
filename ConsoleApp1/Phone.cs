using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Phone
    {
        public string marka { get; set; }
        public string tipus { get; set; }
        public int price { get; set; }
        public Phone(string Marka, string Tipus, int Price = 100000) {
            marka = Marka;
            tipus = Tipus;
            price = Price;
        }
        public override string ToString() {
            return $"{marka} {tipus} {price}-Ft";
        }    
    }
}
