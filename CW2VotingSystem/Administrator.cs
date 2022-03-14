using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2VotingSystem
{
    public class Administrator : User
    {
        public Administrator(string newUsername, string newPassword) : base(newUsername, newPassword)
        {
        }
    }
}
