using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CW2VotingSystem
{
    public class Voter : User
    {
        public Voter(string newUsername, string newPassword) : base(newUsername, newPassword)
        {
        }

        public void SubmitVote(Vote vote, VoteOption option)
        {
            option.IncrementCount();

            Database.database.UpdateVoteOption(option, vote);

            Database.database.AddVoterVote(new VoterVote(this, vote));
        }

        public bool HasVoted(Vote vote)
        {
            return Database.database.HasVoterVoted(this, vote);
        }
    }
}
