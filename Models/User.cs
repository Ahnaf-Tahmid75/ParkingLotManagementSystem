namespace ParkingLotManagementSystem.Models
{
    public class User
    {
        public int UserID { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; } 

        public User(int userId, string username, string password, string role)
        {
            UserID = userId;
            Username = username;
            Password = password;
            Role = role;
        }
    }
}

