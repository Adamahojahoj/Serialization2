using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization2.Models
{
    public class Obed
    {
        public int Id { get; set; }
        public string Nazev { get; set; }

        public override string ToString()
        {
            return $"{Id} {Nazev}";
        }
    }
}
