namespace ParkingLotManagementSystem.Models
{
    public class ParkingSlot
    {
        public int SlotID { get; private set; }
        public int SlotNumber { get; private set; }
        public bool IsOccupied { get; private set; }

        public Vehicle ParkedVehicle { get; private set; }

        public ParkingSlot(int slotId, int slotNumber)
        {
            SlotID = slotId;
            SlotNumber = slotNumber;
            IsOccupied = false;
            ParkedVehicle = null;
        }

        public void ParkVehicle(Vehicle vehicle)
        {
            ParkedVehicle = vehicle;
            IsOccupied = true;
        }

        public void RemoveVehicle()
        {
            ParkedVehicle = null;
            IsOccupied = false;
        }
    }
}
