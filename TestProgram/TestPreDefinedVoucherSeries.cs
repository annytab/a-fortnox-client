using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
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
                    VoucherSeries = "B"
                }
            };

            // Update the post
            FortnoxResponse<PreDefinedVoucherSeriesRoot> fr = await config.fortnox_client.Update<PreDefinedVoucherSeriesRoot>(post, "predefinedvoucherseries/INVOICE");
            
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
            FortnoxResponse<PreDefinedVoucherSeriesRoot> fr = await config.fortnox_client.Get<PreDefinedVoucherSeriesRoot>("predefinedvoucherseries/INVOICE");

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
            FortnoxResponse<PreDefinedVoucherSeriesCollectionRoot> fr = await config.fortnox_client.Get<PreDefinedVoucherSeriesCollectionRoot>("predefinedvoucherseries?limit=10&page=1");

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