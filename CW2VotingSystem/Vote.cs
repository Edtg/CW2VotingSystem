using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2VotingSystem
{
    public class Vote
    {
        public string name { get; set; }
        public string description { get; set; }
        public List<VoteOption> options { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public Vote(string newName, string newDescription, DateTime newStartDate, DateTime newEndDate)
        {
            name = newName;
            description = newDescription;
            options = new List<VoteOption>();
            startDate = newStartDate;
            endDate = newEndDate;
        }

        public void AddOption(VoteOption option)
        {
            options.Add(option);
        }

        public void RemoveOption(VoteOption option)
        {
            options.Remove(option);
        }

        public List<VoteOption> GetWinningOption()
        {
            List<VoteOption> result = new List<VoteOption>();
            int highestCount = 0;
            foreach(var option in options)
            {
                if (option.count > highestCount)
                {
                    highestCount = option.count;
                    result.Clear();
                    result.Add(option);
                }
                else if (option.count == highestCount)
                {
                    result.Add(option);
                }
            }
            return result;
        }

        public int GetCountForOption(VoteOption option)
        {
            return option.count;
        }
    }
}
