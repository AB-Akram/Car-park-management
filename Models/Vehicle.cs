using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParking.Models
{
    [Index(nameof(VehicleNumber), IsUnique = true)]
    public class Vehicle
    {
        public int Id { get; set; }
        public string VehicleNumber { get; set; } = null!;
        public string Brand { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string Type { get; set; } = null!;
       // public int BadgeId { get; set; }
        public Badge Badge { get; set; } = null!;

        public string VehicleType { get; set; } = null!;
        public ICollection<ParkingTime> parkingTimes { get; set; }
        //public virtual List<ParkingTime>? ParkingTimes { get; set; }
    }
}
