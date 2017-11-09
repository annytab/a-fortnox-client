using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestPriceLists
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestPriceLists()
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
            PriceListRoot post = new PriceListRoot
            {
                PriceList = new PriceList
                {
                    Code = "AD",
                    Description = "Pricelist for Art Directors.",
                    PreSelected = false
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<PriceListRoot>(config.client, post, "pricelists");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            PriceListRoot post = new PriceListRoot
            {
                PriceList = new PriceList
                {
                    Code = "AD",
                    Description = "Pricelist for Advanced people.",
                    PreSelected = false
                }
            };

            // Update the post
            post = await config.fortnox_repository.Update<PriceListRoot>(config.client, post, "pricelists/AD");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            PriceListRoot post = await config.fortnox_repository.Get<PriceListRoot>(config.client, "pricelists/AD");

            // Test evaluation
            Assert.AreNotEqual(null, post.PriceList);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            PriceListsRoot post = await config.fortnox_repository.Get<PriceListsRoot>(config.client, "pricelists?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.PriceLists.Count);

        } // End of the TestGetList method

        #endregion

    } // End of the class

} // End of the namespace