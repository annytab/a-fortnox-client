using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            post = await config.fortnox_repository.Add<VoucherSeriesRoot>(config.client, post, "voucherseries");

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
            post = await config.fortnox_repository.Update<VoucherSeriesRoot>(config.client, post, "voucherseries/X");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            VoucherSeriesRoot post = await config.fortnox_repository.Get<VoucherSeriesRoot>(config.client, "voucherseries/X");

            // Test evaluation
            Assert.AreNotEqual(null, post.VoucherSeries);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            VoucherSeriesCollectionRoot post = await config.fortnox_repository.Get<VoucherSeriesCollectionRoot>(config.client, "voucherseries?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.VoucherSeriesCollection.Count);

        } // End of the TestGetList method

        #endregion

    } // End of the class

} // End of the namespace