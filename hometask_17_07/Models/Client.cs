using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_17_07.Models
{
    public class Client:BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<Car>? Cars { get; set; }
        public ICollection<Bus>? Buss { get; set; }
    }
}
