using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestVoucherSeries
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestVoucherSeries()
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
            VoucherSeriesRoot post = new VoucherSeriesRoot
            {
                VoucherSeries = new VoucherSeries
                {
                    Code = "X",
                    Description = "Other vouchers",
                    Manual = true
                }
            };

            // Add the post
            FortnoxResponse<VoucherSeriesRoot> fr = await config.fortnox_client.Add<VoucherSeriesRoot>(post, "voucherseries");

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
            VoucherSeriesRoot post = new VoucherSeriesRoot
            {
                VoucherSeries = new VoucherSeries
                {
                    Code = "X",
                    Description = "Övriga verifikationer",
                    Manual = false
                }
            };

            // Update the post
            FortnoxResponse<VoucherSeriesRoot> fr = await config.fortnox_client.Update<VoucherSeriesRoot>(post, "voucherseries/X");

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
            FortnoxResponse<VoucherSeriesRoot> fr = await config.fortnox_client.Get<VoucherSeriesRoot>("voucherseries/N");

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
            FortnoxResponse<VoucherSeriesCollectionRoot> fr = await config.fortnox_client.Get<VoucherSeriesCollectionRoot>("voucherseries?limit=2&page=1");

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