namespace SpaDay.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string VerifyPassword { get; set; }
        public string Email {get; set; }
        

        public User()
        {

        }

        public User(string username, string password, string verify, string email)
        {
            UserName = username;
            Password = password;
            VerifyPassword = verify;
            Email = email;
        }

    }

}
