using Microsoft.VisualStudio.TestTools.UnitTesting;
using CW2VotingSystem;
using System;
using System.IO;
using System.Linq;

namespace VotingSystemTests
{
    [TestClass]
    public class VotingSystemTests
    {
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            // Reset test database.
            Database.database.DeleteDatabase($"{Directory.GetCurrentDirectory()}\\TestDatabase.db");
            Database.connection = Database.database.CreateDatabaseConnection($"{Directory.GetCurrentDirectory()}\\TestDatabase.db");
            Database.database.InitialiseDatabase();
        }

        [TestMethod, TestCategory("User")]
        public void UserConstructTest()
        {
            User testUser = new User("TestUser", "TestPassword");

            Assert.AreEqual(testUser.username, "TestUser");
            Assert.AreEqual(testUser.password, "TestPassword");
        }


        [TestMethod, TestCategory("Session")]
        public void SessionUserLoginTest()
        {
            Session.session.Register("TestUser", "TestPassword", 0);
            Assert.IsTrue(Session.session.Login("TestUser", "TestPassword"));
            Assert.AreNotEqual(Session.currentUser, null);
        }

        [TestMethod, TestCategory("VoteOption")]
        public void VoteOptionIncrementTest()
        {
            VoteOption option = new VoteOption("TestOption", "TestDescription");

            for (int i = 0; i < 10; i++)
            {
                option.IncrementCount();
            }

            Assert.AreEqual(option.count, 10);
        }

        [TestMethod, TestCategory("VoteOption")]
        public void VoteOptionRandomIncrementTest()
        {
            VoteOption option = new VoteOption("TestOption", "TestDescription");

            int incrementCount = (new System.Random()).Next(50);
            for (int i = 0; i < incrementCount; i++)
            {
                option.IncrementCount();
            }

            Assert.AreEqual(option.count, incrementCount);
        }

        [TestMethod, TestCategory("Vote")]
        public void AddVoteOptionTest()
        {
            Vote vote = new Vote("TestVote", "TestDescription", DateTime.Today, DateTime.Today.AddDays(2));

            VoteOption option = new VoteOption("TestOption", "TestDescription");

            Assert.IsFalse(vote.options.Contains(option));

            vote.AddOption(option);

            Assert.IsTrue(vote.options.Contains(option));
        }

        [TestMethod, TestCategory("Vote")]
        public void RemoveVoteOptionTest()
        {
            Vote vote = new Vote("TestVote", "TestDescription", DateTime.Today, DateTime.Today.AddDays(2));

            VoteOption option = new VoteOption("TestOption", "TestDescription");

            vote.AddOption(option);

            Assert.IsTrue(vote.options.Contains(option));

            vote.RemoveOption(option);

            Assert.IsFalse(vote.options.Contains(option));
        }

        [TestMethod, TestCategory("Vote")]
        public void WinningVoteTest()
        {
            Vote vote = new Vote("TestVote", "TestDescriotion", DateTime.Today, DateTime.Today.AddDays(2));

            vote.AddOption(new VoteOption("TestOption1", "TestDescription"));
            vote.AddOption(new VoteOption("TestOption2", "TestDescription"));

            for (int i = 0; i < 5; i++)
            {
                vote.options[0].IncrementCount();
            }

            for (int i = 0; i < 4; i++)
            {
                vote.options[1].IncrementCount();
            }

            // Test first option is winning
            Assert.AreEqual(vote.GetWinningOption()[0], vote.options[0]);

            for (int i = 0; i < 2; i++)
            {
                vote.options[1].IncrementCount();
            }

            // Test second option is now winning
            Assert.AreEqual(vote.GetWinningOption()[0], vote.options[1]);

            vote.options[0].IncrementCount();

            // Test both votes are returned
            Assert.IsTrue(vote.GetWinningOption().Contains(vote.options[0]));
            Assert.IsTrue(vote.GetWinningOption().Contains(vote.options[1]));
        }

        [TestMethod, TestCategory("User")]
        public void SubmitVoteTest()
        {
            Vote vote = new Vote("TestVote", "TestDescriotion", DateTime.Today, DateTime.Today.AddDays(2));

            vote.AddOption(new VoteOption("TestOption1", "TestDescription"));
            vote.AddOption(new VoteOption("TestOption2", "TestDescription"));

            Voter voter = new Voter("TestVoter", "TestPassword");

            voter.SubmitVote(vote, vote.options[0]);

            Assert.AreEqual(vote.options[0].count, 1);
            Assert.AreEqual(vote.GetWinningOption()[0], vote.options[0]);
        }

        [TestMethod, TestCategory("User")]
        public void HasVotedTest()
        {
            Vote vote = new Vote("TestVote", "TestDescriotion", DateTime.Today, DateTime.Today.AddDays(2));

            vote.AddOption(new VoteOption("TestOption1", "TestDescription"));
            vote.AddOption(new VoteOption("TestOption2", "TestDescription"));

            Voter voter = new Voter("TestVoter", "TestPassword");

            voter.SubmitVote(vote, vote.options[0]);

            Assert.IsTrue(voter.HasVoted(vote));
        }

        [TestMethod, TestCategory("Session")]
        public void Logintest()
        {
            Voter voter = new Voter("TestVoter", "TestPassword");

            Database.database.CreateUser(voter, 0);

            Assert.IsTrue(Session.session.Login("TestVoter", "TestPassword"));

            Assert.AreEqual(Session.currentUser.username, voter.username);
            Assert.AreEqual(Session.userType, 0);
        }


        [TestMethod, TestCategory("Database")]
        public void DatabaseUserTest()
        {
            Database.database.DeleteDatabase($"{Directory.GetCurrentDirectory()}\\UserTestDatabase.db");
            Database.connection = Database.database.CreateDatabaseConnection($"{Directory.GetCurrentDirectory()}\\UserTestDatabase.db");
            Database.database.InitialiseDatabase();

            Voter voter = new Voter("DatabaseTestVoter", "DatabaseTestPassword");

            Assert.AreEqual(Database.database.GetUsers().Count(), 2);

            Database.database.CreateUser(voter, 0);

            Assert.AreEqual(Database.database.GetUsers().Count(), 3);

            Database.connection = Database.database.CreateDatabaseConnection($"{Directory.GetCurrentDirectory()}\\TestDatabase.db");
        }

        [TestMethod, TestCategory("Database")]
        public void DatabaseVoteTest()
        {
            Database.database.DeleteDatabase($"{Directory.GetCurrentDirectory()}\\VoteTestDatabase.db");
            Database.connection = Database.database.CreateDatabaseConnection($"{Directory.GetCurrentDirectory()}\\VoteTestDatabase.db");
            Database.database.InitialiseDatabase();

            Vote vote = new Vote("DatabaseTestVote", "DatabaseTestDescriotion", DateTime.Today, DateTime.Today.AddDays(2));

            Assert.AreEqual(Database.database.GetVotes().Count(), 0);

            Database.database.CreateVote(vote);

            Assert.AreEqual(Database.database.GetVotes().Count(), 1);

            Database.connection = Database.database.CreateDatabaseConnection($"{Directory.GetCurrentDirectory()}\\TestDatabase.db");
        }

        [TestMethod, TestCategory("Database")]
        public void DatabaseVoteOptionTest()
        {
            Database.database.DeleteDatabase($"{Directory.GetCurrentDirectory()}\\VoteOptionTestDatabase.db");
            Database.connection = Database.database.CreateDatabaseConnection($"{Directory.GetCurrentDirectory()}\\VoteOptionTestDatabase.db");
            Database.database.InitialiseDatabase();

            Vote vote = new Vote("DatabaseTestVote", "DatabaseTestDescriotion", DateTime.Today, DateTime.Today.AddDays(2));
            VoteOption option = new VoteOption("DatabaseTestOption1", "DatabaseTestDescription");

            Assert.AreEqual(Database.database.GetVoteOptions(vote).Count(), 0);

            Database.database.CreateVoteOption(option, vote);

            Assert.AreEqual(Database.database.GetVoteOptions(vote).Count(), 1);

            Database.connection = Database.database.CreateDatabaseConnection($"{Directory.GetCurrentDirectory()}\\TestDatabase.db");
        }
    }
}
