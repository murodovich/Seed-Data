using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_17_07.Models
{
    public class Bus:BaseEntity
    {
        public string? Name { get; set; }
        public int Speed { get; set; }
        public ICollection<Client>? Clients { get; set; }
    }
}
