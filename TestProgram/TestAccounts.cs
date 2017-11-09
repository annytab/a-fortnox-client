using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestAccounts
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestAccounts()
        {
            this.config = new Config();

        } // End of the constructor

        #endregion

        #region Methods

        /// <summary>
        /// Test to add a post
        /// </summary>
        [TestMethod]
        public async Task TestAddPost()
        {
            // Create a post
            AccountRoot post = new AccountRoot
            {
                Account = new Account
                {
                    Active = true,
                    Number = "9004",
                    Description = "Test account",
                    SRU = "8001"
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<AccountRoot>(config.client, post, "accounts");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            AccountRoot post = new AccountRoot
            {
                Account = new Account
                {
                    Active = true,
                    Number = "9004",
                    Description = "Updated account",
                    SRU = "8002"
                }
            };

            // Update the post
            post = await config.fortnox_repository.Update<AccountRoot>(config.client, post, "accounts/9004");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            AccountRoot post = await config.fortnox_repository.Get<AccountRoot>(config.client, "accounts/9004");

            // Test evaluation
            Assert.AreNotEqual(null, post.Account);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            AccountsRoot post = await config.fortnox_repository.Get<AccountsRoot>(config.client, "accounts?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.Accounts.Count);

        } // End of the TestGetList method

        #endregion

    } // End of the class

} // End of the namespace