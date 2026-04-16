

namespace ConsoleApp1.SOLID.S.BetterExample
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }

        public User(string Username, string Email)
        {
            this.Username = Username;
            this.Email = Email;
        }
    }
}