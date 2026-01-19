using System;

namespace ParkingLotManagementSystem.Models
{
    public class Payment
    {
        public int PaymentID { get; private set; }
        public ParkingTicket Ticket { get; private set; }
        public double TotalHours { get; private set; }
        public decimal RatePerHour { get; private set; }
        public decimal TotalAmount { get; private set; }
        public DateTime PaymentTime { get; private set; }

        public Payment(
            int paymentId,
            ParkingTicket ticket,
            double totalHours,
            decimal ratePerHour,
            DateTime paymentTime)
        {
            PaymentID = paymentId;
            Ticket = ticket;
            TotalHours = totalHours;
            RatePerHour = ratePerHour;
            TotalAmount = (decimal)totalHours * ratePerHour;
            PaymentTime = paymentTime;
        }
    }
}


