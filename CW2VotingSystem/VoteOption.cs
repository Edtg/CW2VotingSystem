using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2VotingSystem
{
    public class VoteOption
    {
        public string name { get; set; }
        public string description { get; set; }
        public int count { get; private set; }

        public VoteOption(string newName, string newDescription, int newCount = 0)
        {
            name = newName;
            description = newDescription;
            count = newCount;
        }

        public void IncrementCount()
        {
            count++;
        }
    }
}
