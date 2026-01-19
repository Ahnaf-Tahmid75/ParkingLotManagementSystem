namespace ParkingLotManagementSystem.Models
{
    public class Vehicle
    {
        public string LicensePlate { get; private set; }
        public string VehicleType { get; private set; }

        public Vehicle(string licensePlate, string vehicleType)
        {
            LicensePlate = licensePlate;
            VehicleType = vehicleType;
        }
    }
}

