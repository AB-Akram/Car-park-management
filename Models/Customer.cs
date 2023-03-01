using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParking.Models
{
    public class Customer: Person
    {
        public Badge Badge { get; set; } = null!;
    }
}
