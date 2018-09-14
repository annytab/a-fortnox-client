using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
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
                    FileId = "0a2316bc-6ede-4678-97d3-cbab5e63e8f7",
                    SupplierInvoiceNumber = "50"
                }
            };

            // Add the post
            FortnoxResponse<SupplierInvoiceFileConnectionRoot> fr = await config.fortnox_client.Add<SupplierInvoiceFileConnectionRoot>(post, "supplierinvoicefileconnections");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestAddPost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            FortnoxResponse<SupplierInvoiceFileConnectionRoot> fr = await config.fortnox_client.Get<SupplierInvoiceFileConnectionRoot>("supplierinvoicefileconnections/0a2316bc-6ede-4678-97d3-cbab5e63e8f7");

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
            FortnoxResponse<SupplierInvoiceFileConnectionsRoot> fr = await config.fortnox_client.Get<SupplierInvoiceFileConnectionsRoot>("supplierinvoicefileconnections?limit=2&page=1");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            FortnoxResponse<bool> fr = await config.fortnox_client.Delete("supplierinvoicefileconnections/26d1074f-36bb-4e88-a490-9e14998ed35c");

            // Log the error
            if (fr.model == false)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreEqual(true, fr.model);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace