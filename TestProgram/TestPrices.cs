using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestPrices
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestPrices()
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
            PriceRoot post = new PriceRoot
            {
                Price = new Price
                {
                    ArticleNumber = "1",
                    FromQuantity = 0M,
                    PriceList = "AD",
                    Amount = 86.88M
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<PriceRoot>(config.client, post, "prices");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            PriceRoot post = new PriceRoot
            {
                Price = new Price
                {
                    ArticleNumber = "1",
                    FromQuantity = 200M,
                    PriceList = "AD",
                    Amount = 30.33M
                }
            };

            // Update the post
            post = await config.fortnox_repository.Update<PriceRoot>(config.client, post, "prices/AD/1/200.00");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            PriceRoot post = await config.fortnox_repository.Get<PriceRoot>(config.client, "prices/AD/1/200.00");

            // Test evaluation
            Assert.AreNotEqual(null, post.Price);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            PricesRoot post = await config.fortnox_repository.Get<PricesRoot>(config.client, "prices/sublist/AD/1?limit=3&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.Prices.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "prices/AD/1/300.00");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace