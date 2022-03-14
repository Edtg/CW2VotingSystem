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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Session.session.Login(editUsername.Text, editPassword.Text))
            {
                // Next Window
                switch(Session.userType)
                {
                    case 0:
                        frmVoter voterForm = new frmVoter();
                        voterForm.Show();
                        break;
                    case 1:
                        frmAdministrator administratorForm = new frmAdministrator();
                        administratorForm.Show();
                        break;
                    case 2:
                        frmAuditor auditorForm = new frmAuditor();
                        auditorForm.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Username and password do not match records, please register as a voter");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (editUsername.Text.Length == 0 || editPassword.Text.Length == 0)
            {
                MessageBox.Show("Please enter a username and password to register");
            }
            else
            {
                Session.session.Register(editUsername.Text, editPassword.Text, 0);
                MessageBox.Show("New voter registered");
            }
        }
    }
}
