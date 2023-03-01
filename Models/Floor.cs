using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParking.Models
{
    public class Floor
    {
        public int Id { get; set; }
        public string Type { get; set; } = null!;
        public ICollection<ParkingTime> parkingTimes { get; set; }
        //public virtual List<ParkingTime>? ParkingTimes { get; set; }
    }
}
