namespace GestionParking.Models
{
    public class ParkingTime
    {
        public DateTime DateEntry { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Price { get; set; }
        public int VehicleId { get; set; }
        public  Vehicle Vehicle { get; set; } = null!;
        public int FloorId { get; set; }
        public  Floor Floor { get; set; } = null!;
    }
}