using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int points { get; set; }
        public Player(string Name, int Level = 1, int points = 0) { 
            this.Name = Name;
            this.Level = Level;
            this.points = points;
        }
        public override string ToString()
        {
            return $"{Name}, {Level}lvl, {points}pt";
        }
    }
}
