using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2VotingSystem
{
    public class VoterVote
    {
        public Voter voter { get; set; }
        public Vote vote { get; set; }

        public VoterVote(Voter newVoter, Vote newVote)
        {
            voter = newVoter;
            vote = newVote;
        }
    }
}
