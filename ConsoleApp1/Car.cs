using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car
    {
        public string brand {  get; set; }
        public string type { get; set; }
        public int year { get; set; }
        public int age { get; set; }
        public Car(string brand, string type, int year)
        {
            this.brand = brand;
            this.type = type;
            this.year = year;
            age = 2026 - year;
        }
        public override string ToString() {
            return $"{brand} {type} {year} {age}"; 
        }

    }
}
