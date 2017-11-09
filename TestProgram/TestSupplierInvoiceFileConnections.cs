using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestSupplierInvoiceFileConnections
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestSupplierInvoiceFileConnections()
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
            SupplierInvoiceFileConnectionRoot post = new SupplierInvoiceFileConnectionRoot
            {
                SupplierInvoiceFileConnection = new SupplierInvoiceFileConnection
                {
                    FileId = "26d1074f-36bb-4e88-a490-9e14998ed35c",
                    SupplierInvoiceNumber = "9"
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<SupplierInvoiceFileConnectionRoot>(config.client, post, "supplierinvoicefileconnections");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            SupplierInvoiceFileConnectionRoot post = await config.fortnox_repository.Get<SupplierInvoiceFileConnectionRoot>(config.client, "supplierinvoicefileconnections/26d1074f-36bb-4e88-a490-9e14998ed35c");

            // Test evaluation
            Assert.AreNotEqual(null, post.SupplierInvoiceFileConnection);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            SupplierInvoiceFileConnectionsRoot post = await config.fortnox_repository.Get<SupplierInvoiceFileConnectionsRoot>(config.client, "supplierinvoicefileconnections?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.SupplierInvoiceFileConnections.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "supplierinvoicefileconnections/26d1074f-36bb-4e88-a490-9e14998ed35c");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace