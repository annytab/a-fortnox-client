using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestCurrencies
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestCurrencies()
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
            CurrencyRoot post = new CurrencyRoot
            {
                Currency = new Currency
                {
                    Code = "DKK",
                    Description = "Tripple X",
                    BuyRate = 1M,
                    SellRate = 1M,
                    Unit = 1M
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<CurrencyRoot>(config.client, post, "currencies");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            CurrencyRoot post = new CurrencyRoot
            {
                Currency = new Currency
                {
                    Code = "DKK",
                    Description = "Danska kronor",
                    BuyRate = 7.889M,
                    SellRate = 8.4555M,
                    Unit = 1M
                }
            };

            // Update the post
            post = await config.fortnox_repository.Update<CurrencyRoot>(config.client, post, "currencies/DKK");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            CurrencyRoot post = await config.fortnox_repository.Get<CurrencyRoot>(config.client, "currencies/DKK");

            // Test evaluation
            Assert.AreNotEqual(null, post.Currency);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            CurrenciesRoot post = await config.fortnox_repository.Get<CurrenciesRoot>(config.client, "currencies?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.Currencies.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "currencies/DKK");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace