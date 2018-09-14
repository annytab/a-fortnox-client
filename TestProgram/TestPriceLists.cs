using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
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
            FortnoxResponse<PriceListRoot> fr = await config.fortnox_client.Add<PriceListRoot>(post, "pricelists");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

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
            FortnoxResponse<PriceListRoot> fr = await config.fortnox_client.Update<PriceListRoot>(post, "pricelists/AD");

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
            FortnoxResponse<PriceListRoot> fr = await config.fortnox_client.Get<PriceListRoot>("pricelists/AD");

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
            FortnoxResponse<PriceListsRoot> fr = await config.fortnox_client.Get<PriceListsRoot>("pricelists?limit=2&page=1");

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