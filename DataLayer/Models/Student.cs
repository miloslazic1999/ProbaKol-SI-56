using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Index { get; set; }
        public Decimal Average { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Index}, {Average}";
        }
    }
}
