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
    public partial class frmVoter : Form
    {
        public frmVoter()
        {
            InitializeComponent();

            foreach (var vote in Database.database.GetVotes().Where(v => v.startDate <= DateTime.Now && v.endDate >= DateTime.Now))
            {
                cboVote.Items.Add(vote);
            }
        }

        private void cboVote_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboVoteOption.Items.Clear();

            foreach(var option in ((Vote)cboVote.SelectedItem).options)
            {
                cboVoteOption.Items.Add(option);
            }

            textVoteDescription.Text = ((Vote)cboVote.SelectedItem).name;
        }

        private void cboVoteOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            textVoteOptionDescription.Text = ((VoteOption)cboVoteOption.SelectedItem).description;
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            if (Session.currentUser != null)
            {
                if (!((Voter)Session.currentUser).HasVoted((Vote)cboVote.SelectedItem))
                {
                    ((Voter)Session.currentUser).SubmitVote((Vote)cboVote.SelectedItem, (VoteOption)cboVoteOption.SelectedItem);
                    MessageBox.Show("Vote submitted");
                }
                else
                {
                    MessageBox.Show("You have already participated in this vote");
                }
            }
        }
    }
}
