using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW2VotingSystem
{
    public partial class frmAuditor : Form
    {
        public frmAuditor()
        {
            InitializeComponent();
            foreach(var vote in Database.database.GetVotes())
            {
                cboVote.Items.Add(vote);
            }
        }

        private void btnWinningOption_Click(object sender, EventArgs e)
        {
            Vote vote = (Vote)cboVote.SelectedItem;

            if (vote.startDate > DateTime.Now)
            {
                MessageBox.Show("This vote has not started yet");
                return;
            }

            if (vote.endDate > DateTime.Now && MessageBox.Show("This vote has not ended yet, are you sure you want to display results?", "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }


            List<VoteOption> options = vote.GetWinningOption();
            if (options.Count == 1)
            {
                MessageBox.Show($"The winning option for {vote.name} is {options[0].name}");
            }
            else if (options.Count > 1)
            {
                string message = $"The winning options for {vote.name} are tied at {options[0].count} votes with:";
                foreach (var option in options)
                {
                    message += $"\n{option.name}";
                }
                MessageBox.Show(message);
            }
        }

        private void btnAllVotes_Click(object sender, EventArgs e)
        {
            Vote vote = (Vote)cboVote.SelectedItem;

            if (vote.startDate > DateTime.Now)
            {
                MessageBox.Show("This vote has not started yet");
                return;
            }

            if (vote.endDate > DateTime.Now && MessageBox.Show("This vote has not ended yet, are you sure you want to display results?", "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            string message = $"The total count of each option for {vote.name} is:";
            foreach(var option in vote.options)
            {
                message += $"\n{option.name}: {option.count} votes";
            }
            MessageBox.Show(message);
        }
    }
}
