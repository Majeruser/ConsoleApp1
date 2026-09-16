using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DogClass
    {
        public string name { get; set; }
        public string breed { get; set; }
        public int age { get; set; }
        public DogClass(string name, string breed, int age)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
        }
        public override string ToString()
        {
            return $"{name} {breed} {age}éves";
        }
    }
}
