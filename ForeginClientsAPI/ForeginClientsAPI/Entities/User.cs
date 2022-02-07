namespace ForeginClientsAPI.Entities
{
    public class User
    {
        public int Id { get; set; }    // database ID
        public string UniqueHash { get; set; } // the PESEL that will be hashed into uniqueHash
        public string Email { get; set; } // used for login
        public string PasswordHash { get; set; } // stored as a hash for security reasons



    }
}
