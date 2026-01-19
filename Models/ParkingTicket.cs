using System;

namespace ParkingLotManagementSystem.Models
{
    public class ParkingTicket
    {
        public int TicketID { get; private set; }
        public Vehicle Vehicle { get; private set; }
        public ParkingSlot ParkingSlot { get; private set; }
        public User IssuedBy { get; private set; }
        public DateTime EntryTime { get; private set; }

        public ParkingTicket(
            int ticketId,
            Vehicle vehicle,
            ParkingSlot parkingSlot,
            User issuedBy,
            DateTime entryTime)
        {
            TicketID = ticketId;
            Vehicle = vehicle;
            ParkingSlot = parkingSlot;
            IssuedBy = issuedBy;
            EntryTime = entryTime;
        }
    }
}



