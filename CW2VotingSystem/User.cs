using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2VotingSystem
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }

        public User(string newUsername, string newPassword)
        {
            username = newUsername;
            password = newPassword;
        }
    }
}
