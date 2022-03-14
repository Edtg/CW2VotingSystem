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
    public partial class frmAdministrator : Form
    {
        public frmAdministrator()
        {
            InitializeComponent();

            foreach(var vote in Database.database.GetVotes())
            {
                cboVote.Items.Add(vote);
            }
        }

        private void btnAddVote_Click(object sender, EventArgs e)
        {
            Database.database.CreateVote(new Vote(editVoteName.Text, editVoteDescription.Text, dateStartDate.Value, dateEndDate.Value));
            MessageBox.Show("New vote created");

            cboVote.Items.Clear();
            foreach (var vote in Database.database.GetVotes())
            {
                cboVote.Items.Add(vote);
            }
        }

        private void btnAddOption_Click(object sender, EventArgs e)
        {
            Database.database.CreateVoteOption(new VoteOption(editOptionName.Text, editOptionDescription.Text), (Vote)cboVote.SelectedItem);
            MessageBox.Show("New vote option added");
        }
    }
}
