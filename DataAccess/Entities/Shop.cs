using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Shop
    {
        public int Id { get; set; } 
        public string Names { get; set; }
        public String OpeningHours { get; set; }
        public string Address { get; set; }
    }
}
