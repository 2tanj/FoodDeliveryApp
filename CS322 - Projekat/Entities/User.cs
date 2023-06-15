using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322___Projekat
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string CreationDate{ get; set; }

        public User(int userId, string username, string password, string eMail, string creationDate)
        {
            UserId = userId;
            Username = username;
            Password = password;
            Email = eMail;
            CreationDate = creationDate;
        }
        public User(int userId, string username, string password, string eMail)
        {
            UserId = userId;
            Username = username;
            Password = password;
            Email = eMail;
        }
        public User() { }

        public static bool CheckCredentials(List<User> users, ref User user, string username, string password)
        {
            foreach (var r in users)
            {
                if (r.Username == username && r.Password == password)
                {
                    user = r;
                    return true;
                }
            }

            return false;
        }

    }
}
