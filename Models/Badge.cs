using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParking.Models
{
    public class Badge
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public int Point { get; set; }
        public string Type { get; set; } = null!;
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
