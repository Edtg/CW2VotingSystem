using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2VotingSystem
{
    public class Session
    {
        private static Session _session;

        public static Session session
        {
            get
            {
                if (_session == null)
                    _session = new Session();
                return _session;
            }
        }

        private static User? _currentUser { get; set; }

        public static User? currentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }

        private static int _userType { get; set; }

        public static int userType
        {
            get { return _userType; }
            set { _userType = value; }
        }

        public bool Login(string username, string password)
        {
            Tuple<User, int>? user = Database.database.GetUsers().Where(u => u.Item1.username == username && u.Item1.password == password).FirstOrDefault();
            if (user == null)
                return false;

            currentUser = user.Item1;
            userType = user.Item2;

            return true;
        }

        public void Register(string username, string password, int userType)
        {
            Database.database.CreateUser(new User(username, password), userType);
        }
    }
}
