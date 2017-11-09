using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestPreDefinedAccounts
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestPreDefinedAccounts()
        {
            this.config = new Config();

        } // End of the constructor

        #endregion

        #region Methods

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            PreDefinedAccountRoot post = new PreDefinedAccountRoot
            {
                PreDefinedAccount = new PreDefinedAccount
                {
                    Account = "1931"
                }
            };

            // Update the post
            post = await config.fortnox_repository.Update<PreDefinedAccountRoot>(config.client, post, "predefinedaccounts/BG");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            PreDefinedAccountRoot post = await config.fortnox_repository.Get<PreDefinedAccountRoot>(config.client, "predefinedaccounts/BG");

            // Test evaluation
            Assert.AreNotEqual(null, post.PreDefinedAccount);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            PreDefinedAccountsRoot post = await config.fortnox_repository.Get<PreDefinedAccountsRoot>(config.client, "predefinedaccounts?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.PreDefinedAccounts.Count);

        } // End of the TestGetList method

        #endregion

    } // End of the class

} // End of the namespace