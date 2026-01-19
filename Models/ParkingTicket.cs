using System;

namespace ParkingLotManagementSystem.Models
{
    public class ParkingTicket
    {
        public int TicketID { get; private set; }

        public Vehicle Vehicle { get; private set; }
        public ParkingSlot ParkingSlot { get; private set; }
        public User User { get; private set; }

        public DateTime EntryTime { get; private set; }
        public DateTime? ExitTime { get; private set; }

        public ParkingTicket(
            int ticketId,
            Vehicle vehicle,
            ParkingSlot parkingSlot,
            User user)
        {
            TicketID = ticketId;
            Vehicle = vehicle;
            ParkingSlot = parkingSlot;
            User = user;
            EntryTime = DateTime.Now;
        }

        public void CloseTicket()
        {
            ExitTime = DateTime.Now;
        }
    }
}

