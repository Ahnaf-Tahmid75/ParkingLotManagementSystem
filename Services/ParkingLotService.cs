using ParkingLotManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingLotManagementSystem.Services
{
    public class ParkingLotService
    {
        private List<ParkingSlot> slots;
        private int ticketCounter = 1;
        private int paymentCounter = 1;

        public ParkingLotService(int totalSlots)
        {
            slots = new List<ParkingSlot>();
            for (int i = 1; i <= totalSlots; i++)
            {
                slots.Add(new ParkingSlot(i));
            }
        }

        public ParkingTicket ParkVehicle(Vehicle vehicle, User currentUser)
        {
            var emptySlot = slots.FirstOrDefault(s => !s.IsOccupied);
            if (emptySlot == null)
                return null;

            emptySlot.ParkVehicle(vehicle);

            return new ParkingTicket(
                ticketCounter++,
                vehicle,
                emptySlot,
                currentUser,
                DateTime.Now
            );
        }

        public Payment RemoveVehicle(ParkingTicket ticket, decimal ratePerHour)
        {
            ticket.ParkingSlot.RemoveVehicle();

            var exitTime = DateTime.Now;
            var totalHours = Math.Ceiling(
                (exitTime - ticket.EntryTime).TotalHours
            );

            return new Payment(
                paymentCounter++,
                ticket,
                totalHours,
                ratePerHour,
                exitTime
            );
        }
    }
}


