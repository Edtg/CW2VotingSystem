using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace CW2VotingSystem
{
    public class Database
    {
        private static Database _database;
        private static SQLiteConnection _connection;

        private Database()
        {
        }

        public static Database database
        {
            get { 
                if (_database == null)
                    _database = new Database();
                return _database;
            }
        }

        public static SQLiteConnection connection
        {
            get {
                if (_connection == null)
                    _connection = new SQLiteConnection();
                return _connection;
            }
            set {
                if (_connection != null)
                {
                    _connection.Close();
                    _connection.Dispose();
                }
                _connection = value;
            }
        }

        public SQLiteConnection CreateDatabaseConnection(string databasePath)
        {
            string connectionString = $"URI=file:{databasePath}";
            return new SQLiteConnection(connectionString);
        }

        public void InitialiseDatabase()
        {
            connection.Open();

            SQLiteCommand cmd = connection.CreateCommand();

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS user(Username VARCHAR(50) NOT NULL UNIQUE PRIMARY KEY, Password VARCHAR(50) NOT NULL, UserType INT NOT NULL)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE IF  NOT EXISTS vote(Name VARCHAR(50) NOT NULL UNIQUE, Description VARCHAR(50), StartDate DATETIME, EndDate DATETIME)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE IF  NOT EXISTS voteoption(Name VARCHAR(50) NOT NULL, Description VARCHAR(50), Count INT NOT NULL, VoteName VARCHAR(50) NOT NULL)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE IF  NOT EXISTS votervote(Username VARCHAR(50) NOT NULL, VoteName VARCHAR(50) NOT NULL)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT * FROM user WHERE Username = 'admin'";
            if (cmd.ExecuteScalar() == null)
            {
                cmd.CommandText = "INSERT INTO user VALUES('admin', 'admin', 1)";
                cmd.ExecuteNonQuery();
            }

            cmd.CommandText = "SELECT * FROM user WHERE Username = 'auditor'";
            if (cmd.ExecuteScalar() == null)
            {
                cmd.CommandText = "INSERT INTO user VALUES('auditor', 'auditor', 2)";
                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }

        public void DeleteDatabase(string databasePath)
        {
            if (File.Exists(databasePath))
            {
                try
                {
                    connection = null;
                    SQLiteConnection.ClearAllPools();
                }
                catch(Exception) { }
                File.Delete(databasePath);
            }
        }

        public IEnumerable<Tuple<User, int>> GetUsers()
        {
            connection.Open();

            List<Tuple<User, int>> users = new List<Tuple<User, int>>();

            SQLiteCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM user";
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int userType = reader.GetInt32(2);
                switch(userType)
                {
                    case 0:
                        User voter = new Voter(reader.GetString(0), reader.GetString(1));
                        users.Add(new Tuple<User, int>(voter, userType));
                        break;
                    case 1:
                        User administrator = new Administrator(reader.GetString(0), reader.GetString(1));
                        users.Add(new Tuple<User, int>(administrator, userType));
                        break;
                    case 2:
                        User auditor = new Auditor(reader.GetString(0), reader.GetString(1));
                        users.Add(new Tuple<User, int>(auditor, userType));
                        break;
                }
            }

            connection.Close();

            return users;
        }

        public void CreateUser(User newUser, int newUserType)
        {
            connection.Open();

            SQLiteCommand cmd = connection.CreateCommand();
            try
            {
                cmd.CommandText = $"INSERT INTO user VALUES('{newUser.username}', '{newUser.password}', '{newUserType}')";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }

            connection.Close();
        }

        public IEnumerable<Vote> GetVotes()
        {
            connection.Open();

            List<Vote> votes = new List<Vote>();

            SQLiteCommand cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM vote";
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Vote vote = new Vote(reader.GetString(0), reader.GetString(1), (DateTime)reader.GetDateTime(2), (DateTime)reader.GetDateTime(3));
                SQLiteCommand cmd2 = connection.CreateCommand();
                cmd2.CommandText = $"SELECT * FROM voteoption WHERE VoteName = '{vote.name}'";
                var reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    vote.AddOption(new VoteOption(reader2.GetString(0), reader2.GetString(1), reader2.GetInt32(2)));
                }
                votes.Add(vote);
            }

            connection.Close();

            return votes;
        }

        public void CreateVote(Vote newVote)
        {
            connection.Open();

            SQLiteCommand cmd = connection.CreateCommand();
            try
            {
                cmd.CommandText = $"INSERT INTO vote VALUES('{newVote.name}', '{newVote.description}', '{newVote.startDate.ToString("yyyy-MM-dd HH:mm:ss")}', '{newVote.endDate.ToString("yyyy-MM-dd HH:mm:ss")}')";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }

            connection.Close();
        }

        public void UpdateVote(Vote updatedVote)
        {
            connection.Open();

            SQLiteCommand cmd = connection.CreateCommand();
            try
            {
                cmd.CommandText = $"UPDATE vote SET Name = '{updatedVote.name}', Description = '{updatedVote.description}', StartDate = '{updatedVote.startDate.ToString("yyyy-MM-dd HH:mm:ss")}', EndDate = '{updatedVote.endDate.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE Name = '{updatedVote.name}'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }

            connection.Close();
        }

        public IEnumerable<Tuple<VoteOption, string>> GetVoteOptions(Vote vote)
        {
            connection.Open();

            List<Tuple<VoteOption, string>> options = new List<Tuple<VoteOption, string>>();

            SQLiteCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"SELECT * FROM voteoption WHERE VoteName = '{vote.name}'";
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                options.Add(new Tuple<VoteOption, string>(new VoteOption(reader.GetString(0), reader.GetString(1)), reader.GetString(3)));
            }

            connection.Close();

            return options;
        }

        public void CreateVoteOption(VoteOption newOption, Vote vote)
        {
            connection.Open();

            SQLiteCommand cmd = connection.CreateCommand();
            try
            {
                cmd.CommandText = $"INSERT INTO voteoption VALUES('{newOption.name}', '{newOption.description}', {newOption.count}, '{vote.name}')";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }

            connection.Close();
        }

        public void UpdateVoteOption(VoteOption updatedOption, Vote vote)
        {
            connection.Open();

            SQLiteCommand cmd = connection.CreateCommand();
            try
            {
                cmd.CommandText = $"UPDATE voteoption SET Name = '{updatedOption.name}', Description = '{updatedOption.description}', Count = {updatedOption.count} WHERE Name = '{updatedOption.name}' AND VoteName = '{vote.name}'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }

            connection.Close();
        }

        public void AddVoterVote(VoterVote vv)
        {
            connection.Open();

            SQLiteCommand cmd = connection.CreateCommand();
            try
            {
                cmd.CommandText = $"INSERT INTO votervote VALUES('{vv.voter.username}', '{vv.vote.name}')";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }

            connection.Close();
        }

        public bool HasVoterVoted(Voter voter, Vote vote)
        {
            connection.Open();

            bool result = false;

            SQLiteCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"SELECT * FROM votervote WHERE Username = '{voter.username}' AND VoteName = '{vote.name}'";
            try
            {
                if (cmd.ExecuteScalar() != null)
                {
                    result = true;
                }
            }
            catch(Exception ex) { }

            connection.Close();

            return result;
        }
    }
}
