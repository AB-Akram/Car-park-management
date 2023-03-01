using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParking.Models
{
    [Index(nameof(NIC), IsUnique = true)]
    public class Person
    {
        public int Id { get; set; }
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
       
        public string NIC { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        //public int BadgeId { get; set; }
        

        public string Type { get; set; } = null!;
    }
}
