using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestVoucherFileConnections
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestVoucherFileConnections()
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
            VoucherFileConnectionRoot post = new VoucherFileConnectionRoot
            {
                VoucherFileConnection = new VoucherFileConnection
                {
                    FileId = "ef905d4e-789d-4b31-9c12-c13c94f1c1ac",
                    VoucherSeries = "L",
                    VoucherNumber = "1"
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<VoucherFileConnectionRoot>(config.client, post, "voucherfileconnections?financialyeardate=2017-12-31");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            VoucherFileConnectionRoot post = await config.fortnox_repository.Get<VoucherFileConnectionRoot>(config.client, "voucherfileconnections/cc2f8264-a0b6-4820-add3-b7127ab209f9");

            // Test evaluation
            Assert.AreNotEqual(null, post.VoucherFileConnection);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            VoucherFileConnectionsRoot post = await config.fortnox_repository.Get<VoucherFileConnectionsRoot>(config.client, "voucherfileconnections?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.VoucherFileConnections.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "voucherfileconnections/cc2f8264-a0b6-4820-add3-b7127ab209f9");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace