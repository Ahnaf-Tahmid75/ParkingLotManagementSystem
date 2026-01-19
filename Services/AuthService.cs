using System.Collections.Generic;
using System.Linq;

namespace ParkingLotManagementSystem.Services
{
    public class AuthService
    {
        private List<ParkingLotManagementSystem.Models.User> users =
            new List<ParkingLotManagementSystem.Models.User>
        {
            new ParkingLotManagementSystem.Models.User(1, "admin", "1234", "Admin"),
            new ParkingLotManagementSystem.Models.User(2, "staff", "1111", "Staff")
        };

        public ParkingLotManagementSystem.Models.User Login(string username, string password)
        {
            return users.FirstOrDefault(u =>
                u.Username == username && u.Password == password);
        }
    }
}

