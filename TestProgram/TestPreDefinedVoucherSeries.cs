using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestPreDefinedVoucherSeries
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestPreDefinedVoucherSeries()
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
            PreDefinedVoucherSeriesRoot post = new PreDefinedVoucherSeriesRoot
            {
                PreDefinedVoucherSeries = new PreDefinedVoucherSeries
                {
                    Name = "INVOICE",
                    VoucherSeries = "A"
                }
            };

            // Update the post
            post = await config.fortnox_repository.Update<PreDefinedVoucherSeriesRoot>(config.client, post, "predefinedvoucherseries/INVOICE");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            PreDefinedVoucherSeriesRoot post = await config.fortnox_repository.Get<PreDefinedVoucherSeriesRoot>(config.client, "predefinedvoucherseries/INVOICE");

            // Test evaluation
            Assert.AreNotEqual(null, post.PreDefinedVoucherSeries);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            PreDefinedVoucherSeriesCollectionRoot post = await config.fortnox_repository.Get<PreDefinedVoucherSeriesCollectionRoot>(config.client, "predefinedvoucherseries?limit=10&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.PreDefinedVoucherSeriesCollection.Count);

        } // End of the TestGetList method

        #endregion

    } // End of the class

} // End of the namespace