using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
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
                    Account = "1930"
                }
            };

            // Update the post
            FortnoxResponse<PreDefinedAccountRoot> fr = await config.fortnox_client.Update<PreDefinedAccountRoot>(post, "predefinedaccounts/BG");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            FortnoxResponse<PreDefinedAccountRoot> fr = await config.fortnox_client.Get<PreDefinedAccountRoot>("predefinedaccounts/BG");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            FortnoxResponse<PreDefinedAccountsRoot> fr = await config.fortnox_client.Get<PreDefinedAccountsRoot>("predefinedaccounts?limit=2&page=1");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestGetList method

        #endregion

    } // End of the class

} // End of the namespace